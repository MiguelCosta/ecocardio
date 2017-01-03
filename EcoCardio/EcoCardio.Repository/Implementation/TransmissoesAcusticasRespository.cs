namespace EcoCardio.Repository.Implementation
{
    internal class TransmissoesAcusticasRespository : GenericRepository<Domain.TransmissaoAcustica>, Abstract.ITransmissaoAcusticaRespository
    {
        public TransmissoesAcusticasRespository(EcoCardioContext context)
            : base(context)
        {
        }
    }
}
