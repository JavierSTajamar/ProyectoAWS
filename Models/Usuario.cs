using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAWS.Models
{
    [DynamoDBTable("usuarios")]
    public class Usuario
    {
        [DynamoDBProperty("idusuario")]
        [DynamoDBHashKey]
        [DisplayName("Id")]
        public int IdUsuario { get; set; }
        [DynamoDBProperty("nombre")]
        public String Nombre { get; set; }
        [DynamoDBProperty("descripcion")]
        public String Descripcion { get; set; }
        [DynamoDBProperty("fechaalta")]
        [DisplayName("Fecha Alta")]
        public String fechaalta { get; set; }

        [DynamoDBProperty("fotos")]
        public List<Foto> Fotos { get; set; }
    }
}
