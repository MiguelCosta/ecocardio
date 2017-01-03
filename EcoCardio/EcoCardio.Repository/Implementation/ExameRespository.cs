namespace EcoCardio.Repository.Implementation
{
    internal class ExameRespository : GenericRepository<Domain.Exame>, Abstract.IExameRespository
    {
        internal ExameRespository(EcoCardioContext context)
           : base(context)
        {
        }
    }
}
