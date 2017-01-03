namespace EcoCardio.Repository.Implementation
{
    internal class ServicoRespository : GenericRepository<Domain.Servico>, Abstract.IServicoRespository
    {
        public ServicoRespository(EcoCardioContext context)
            : base(context)
        {
        }
    }
}
