using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using ProyectoAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAWS.Services
{
    public class DynamoDBService
    {
        private readonly AmazonDynamoDBClient _client;
        private readonly DynamoDBContext _context;

        public DynamoDBService()
        {
            _client = new AmazonDynamoDBClient();
           _context = new DynamoDBContext(_client);
        }

        public async Task Add(Usuario usuario)
        {
            await _context.SaveAsync(usuario);
        }


        public async Task<List<Usuario>> All()
        {
            var tabla = _context.GetTargetTable<Usuario>();
            var scanOptions = new ScanOperationConfig();
            var results = tabla.Scan(scanOptions);

            List<Document> data = await results.GetNextSetAsync();
            IEnumerable<Usuario> users = this._context.FromDocuments<Usuario>(data);
            return users.ToList();
        }

        public async Task<Usuario> Single(int id)
        {
            return await _context.LoadAsync<Usuario>(id);
        }


        public async Task Remove(int id)
        {
            await _context.DeleteAsync<Usuario>(id);
        }

        public async Task Update(Usuario usuario)
        {
            await _context.SaveAsync(usuario);
        }
    }
}
