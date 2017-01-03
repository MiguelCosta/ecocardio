namespace EcoCardio.Repository.Implementation
{
    internal class ResponsavelRespository : GenericRepository<Domain.Responsavel>, Abstract.IResponsavelRespository
    {
        public ResponsavelRespository(EcoCardioContext context)
            : base(context)
        {
        }
    }
}
