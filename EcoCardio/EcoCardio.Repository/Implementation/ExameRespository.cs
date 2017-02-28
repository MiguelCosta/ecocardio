using EcoCardio.Domain;
using System.Collections.Generic;
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

        public IEnumerable<Exame> MostRecent(int maxResults = 100)
        {
            var results = _context.Exames
                .OrderByDescending(e => e.Data)
                .Take(maxResults)
                .ToList();
            return results;
        }

        public int NextNumber()
        {
            var currentNumber = _context.Exames.Max(e => e.Numero);
            return currentNumber++;
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
                    query = query.Where(e => e.FirstName.Contains(n) || e.LastName.Contains(n) || e.Nome.Contains(n));
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
