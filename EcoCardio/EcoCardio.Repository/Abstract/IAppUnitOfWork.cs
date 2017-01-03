namespace EcoCardio.Repository.Abstract
{
    public interface IAppUnitOfWork
    {
        IExameRespository Exames { get; set; }

        IResponsavelRespository Responsaveis { get; set; }

        IServicoRespository Servicos { get; set; }

        ITemplateRespository Templates { get; set; }

        ITransmissaoAcusticaRespository TransmissoesAcusticas { get; set; }

        IUtenteRespository Utentes { get; set; }

        IUtilizadorRespository Utilizadores { get; set; }
    }
}
