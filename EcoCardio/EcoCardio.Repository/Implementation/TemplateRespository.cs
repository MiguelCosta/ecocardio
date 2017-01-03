namespace EcoCardio.Repository.Implementation
{
    internal class TemplateRespository : GenericRepository<Domain.Template>, Abstract.ITemplateRespository
    {
        public TemplateRespository(EcoCardioContext context)
            : base(context)
        {
        }
    }
}
