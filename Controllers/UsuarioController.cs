using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoAWS.Models;
using ProyectoAWS.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAWS.Controllers
{
    public class UsuarioController : Controller
    {
        private DynamoDBService ServiceDynamo;
        private AWSS3Service serviceS3;

        public UsuarioController(DynamoDBService service, AWSS3Service services3)
        {
            this.ServiceDynamo = service;
            this.serviceS3 = services3;
        }

        public async Task<IActionResult> Index()
        {
            return View(await this.ServiceDynamo.All());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await this.ServiceDynamo.Single(id));
        }
        public async Task<IActionResult> FileAWS(string filename)
        {
            Stream stream = await this.serviceS3.GetFileAsync(filename);
            return File(stream, "image/jpg");
        }
        public async Task<IActionResult> Delete(int id)
        {
            Usuario usuario = await this.ServiceDynamo.Single(id);
            await this.ServiceDynamo.Remove(id);
            if (usuario.Fotos != null && usuario.Fotos.Count != 0)
            {
                foreach (Foto imagen in usuario.Fotos)
                {
                    await this.serviceS3.DeleteFileAsync(imagen.Imagen);
                }

            }
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario
            , String titulo
            , List<IFormFile> files)
        {
            List<Usuario> usuarios = await ServiceDynamo.All();
            if (usuarios.Count!=0)
            {
                usuario.IdUsuario = usuarios.OrderBy(u => u.IdUsuario).Last().IdUsuario+1;
            }
            else
            {
                usuario.IdUsuario = 1;
            }
            
            usuario.Fotos = new List<Foto>();
            usuario.fechaalta = DateTime.Now.ToShortDateString();
            if (files.Count > 0)
            {

                foreach (IFormFile file in files)
                {
                    Foto fotos = new Foto();

                    fotos.Titulo = titulo;

                    using (MemoryStream memory = new MemoryStream())
                    {
                        fotos.Imagen = file.FileName;
                        file.CopyTo(memory);
                        await this.serviceS3.UploadFileAsync(memory, file.FileName);
                    }

                    usuario.Fotos.Add(fotos);

                }

            }
            await this.ServiceDynamo.Add(usuario);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {
            Usuario usuario = await this.ServiceDynamo.Single(id);
            if (usuario.Fotos.Count != 0)
            {
                List<Foto> fotos = usuario.Fotos;
                ViewData["FOTO"] = fotos;
            }

            return View(usuario);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Usuario user, String accion, String titulo, List<IFormFile> files)
        {
            Usuario usuario = await this.ServiceDynamo.Single(user.IdUsuario);

            if (files != null)
            {
                user.Fotos = new List<Foto>();
                user.Fotos = usuario.Fotos;

                foreach (IFormFile file in files)
                {
                    Foto fotosnew = new Foto();

                    fotosnew.Titulo = titulo;

                    using (MemoryStream m = new MemoryStream())
                    {
                        fotosnew.Imagen = file.FileName;
                        file.CopyTo(m);
                        await this.serviceS3.UploadFileAsync(m, file.FileName);
                    }
                    user.Fotos.Add(fotosnew);
                }
            }

            await this.ServiceDynamo.Add(user);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteImage(int id, string imagen)
        {
            Usuario usuario = await this.ServiceDynamo.Single(id);
            foreach (Foto foto in usuario.Fotos.ToList())
            {
                var i = serviceS3.GetUrl(foto.Imagen);
                if (i.Contains(imagen))
                {
                    await this.serviceS3.DeleteFileAsync(foto.Imagen);
                    usuario.Fotos.Remove(foto);
                }
            }
            await ServiceDynamo.Add(usuario);
            return RedirectToAction("Update", new { id = id });
        }
    }
}
