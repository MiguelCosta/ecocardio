using EcoCardio.Domain;
using EcoCardio.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace EcoCardio.Repository.Implementation
{
    internal class TemplateRespository : GenericRepository<Domain.Template>, Abstract.ITemplateRespository
    {
        private EcoCardioContext _context;

        public TemplateRespository(EcoCardioContext context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<Template> GetByType(TemplateType type)
        {
            var items = _context.Templates
                .Where(t => t.Type == type)
                .OrderBy(t => t.Nome)
                .ToList()
                ;
            return items;
        }
    }
}
