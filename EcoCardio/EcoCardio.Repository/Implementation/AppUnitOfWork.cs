using EcoCardio.Repository.Abstract;

namespace EcoCardio.Repository.Implementation
{
    public class AppUnitOfWork : IAppUnitOfWork
    {
        private EcoCardioContext _context;

        public AppUnitOfWork()
        {
            _context = new EcoCardioContext();
            Exames = new ExameRespository(_context);
            Responsaveis = new ResponsavelRespository(_context);
            Servicos = new ServicoRespository(_context);
            Templates = new TemplateRespository(_context);
            TransmissoesAcusticas = new TransmissoesAcusticasRespository(_context);
            Utilizadores = new UtilizadorRespository(_context);
        }

        public IExameRespository Exames { get; set; }

        public IResponsavelRespository Responsaveis { get; set; }

        public IServicoRespository Servicos { get; set; }

        public ITemplateRespository Templates { get; set; }

        public ITransmissaoAcusticaRespository TransmissoesAcusticas { get; set; }

        public IUtilizadorRespository Utilizadores { get; set; }
    }
}
