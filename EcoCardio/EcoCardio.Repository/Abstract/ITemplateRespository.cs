using EcoCardio.Domain;
using System.Collections.Generic;

namespace EcoCardio.Repository.Abstract
{
    public interface ITemplateRespository : IGenericRepository<Template>
    {
        IEnumerable<Template> GetByType(Domain.Enums.TemplateType type);
    }
}
