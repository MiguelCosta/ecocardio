using EcoCardio.Domain;
using System.Collections.Generic;

namespace EcoCardio.Repository.Abstract
{
    public interface IServicoRespository : IGenericRepository<Servico>
    {
        IEnumerable<Servico> GetByType(Domain.Enums.ServicoType type);
    }
}
