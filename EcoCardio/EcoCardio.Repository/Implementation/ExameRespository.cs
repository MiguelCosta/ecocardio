using System;
using System.Collections.Generic;
using EcoCardio.Domain;
using System.Linq;

namespace EcoCardio.Repository.Implementation
{
    internal class ExameRespository : GenericRepository<Domain.Exame>, Abstract.IExameRespository
    {
        private EcoCardioContext _context;

        internal ExameRespository(EcoCardioContext context)
           : base(context)
        {
            _context = context;
        }

        public IEnumerable<Exame> Search(string nome, int numero, int maxResults = 200)
        {
            var query = _context.Exames
                .AsQueryable();

            if (string.IsNullOrWhiteSpace(nome) == false)
            {
                var names = System.Text.RegularExpressions.Regex.Split(nome, @"\s+");
                foreach (var n in names)
                {
                    query = query.Where(e => e.Utente.Nome.Contains(n) || e.Nome.Contains(n));
                }
            }

            if (numero > 0)
            {
                query = query.Where(e => e.Numero == numero);
            }

            var results = query
                .OrderByDescending(e => e.Data)
                .Take(maxResults)
                .ToList();
            return results;
        }
    }
}
