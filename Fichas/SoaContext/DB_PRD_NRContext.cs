using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fichas.SoaContext
{
    public partial class DB_PRD_NRContext : DbContext
    {
        public DB_PRD_NRContext()
        {
        }

        public DB_PRD_NRContext(DbContextOptions<DB_PRD_NRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<APedido> APedido { get; set; }
        public virtual DbSet<BcAcampantes> BcAcampantes { get; set; }
        public virtual DbSet<BcAnteriores> BcAnteriores { get; set; }
        public virtual DbSet<BcCategoria> BcCategoria { get; set; }
        public virtual DbSet<BcChale> BcChale { get; set; }
        public virtual DbSet<BcEscola> BcEscola { get; set; }
        public virtual DbSet<BcFamilia> BcFamilia { get; set; }
        public virtual DbSet<BcHistorico> BcHistorico { get; set; }
        public virtual DbSet<BcInscricao> BcInscricao { get; set; }
        public virtual DbSet<BcMae> BcMae { get; set; }
        public virtual DbSet<BcOutro> BcOutro { get; set; }
        public virtual DbSet<BcPacote> BcPacote { get; set; }
        public virtual DbSet<BcPai> BcPai { get; set; }
        public virtual DbSet<BcReservas> BcReservas { get; set; }
        public virtual DbSet<BcTemporada> BcTemporada { get; set; }
        public virtual DbSet<BcTemporadaBPacote> BcTemporadaBPacote { get; set; }
        public virtual DbSet<BcVagasChale> BcVagasChale { get; set; }
        public virtual DbSet<E002tpt> E002tpt { get; set; }
        public virtual DbSet<E006pai> E006pai { get; set; }
        public virtual DbSet<E007ufs> E007ufs { get; set; }
        public virtual DbSet<E008cep> E008cep { get; set; }
        public virtual DbSet<E017rve> E017rve { get; set; }
        public virtual DbSet<E025fer> E025fer { get; set; }
        public virtual DbSet<E028cpg> E028cpg { get; set; }
        public virtual DbSet<E080ser> E080ser { get; set; }
        public virtual DbSet<E085cli> E085cli { get; set; }
        public virtual DbSet<E085hcl> E085hcl { get; set; }
        public virtual DbSet<E090hrp> E090hrp { get; set; }
        public virtual DbSet<E090rep> E090rep { get; set; }
        public virtual DbSet<E120isp> E120isp { get; set; }
        public virtual DbSet<E120ped> E120ped { get; set; }
        public virtual DbSet<E301mcr> E301mcr { get; set; }
        public virtual DbSet<E301mor> E301mor { get; set; }
        public virtual DbSet<E301tcr> E301tcr { get; set; }
        public virtual DbSet<Higienizacao> Higienizacao { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<TbBasAgencia> TbBasAgencia { get; set; }
        public virtual DbSet<TbBasAssociacaoformulario> TbBasAssociacaoformulario { get; set; }
        public virtual DbSet<TbBasBanco> TbBasBanco { get; set; }
        public virtual DbSet<TbBasBandeiracartao> TbBasBandeiracartao { get; set; }
        public virtual DbSet<TbBasBandeiracartaoAutomatico> TbBasBandeiracartaoAutomatico { get; set; }
        public virtual DbSet<TbBasCategoria> TbBasCategoria { get; set; }
        public virtual DbSet<TbBasCategoriaCarga> TbBasCategoriaCarga { get; set; }
        public virtual DbSet<TbBasCategoriaabati> TbBasCategoriaabati { get; set; }
        public virtual DbSet<TbBasCategoriadiario> TbBasCategoriadiario { get; set; }
        public virtual DbSet<TbBasCidade> TbBasCidade { get; set; }
        public virtual DbSet<TbBasCondpagto> TbBasCondpagto { get; set; }
        public virtual DbSet<TbBasConveniomedico> TbBasConveniomedico { get; set; }
        public virtual DbSet<TbBasDashboardpagina> TbBasDashboardpagina { get; set; }
        public virtual DbSet<TbBasDashboardportlet> TbBasDashboardportlet { get; set; }
        public virtual DbSet<TbBasDepartamentonr> TbBasDepartamentonr { get; set; }
        public virtual DbSet<TbBasDescontoirmao> TbBasDescontoirmao { get; set; }
        public virtual DbSet<TbBasDistribuicaochale> TbBasDistribuicaochale { get; set; }
        public virtual DbSet<TbBasEsportecultura> TbBasEsportecultura { get; set; }
        public virtual DbSet<TbBasEstadocivil> TbBasEstadocivil { get; set; }
        public virtual DbSet<TbBasFeriado> TbBasFeriado { get; set; }
        public virtual DbSet<TbBasFeriadounidadenr> TbBasFeriadounidadenr { get; set; }
        public virtual DbSet<TbBasFormacaoescolar> TbBasFormacaoescolar { get; set; }
        public virtual DbSet<TbBasFormacaoescolarcurso> TbBasFormacaoescolarcurso { get; set; }
        public virtual DbSet<TbBasFormacaoescolarstatus> TbBasFormacaoescolarstatus { get; set; }
        public virtual DbSet<TbBasFormularioFuncionalidade> TbBasFormularioFuncionalidade { get; set; }
        public virtual DbSet<TbBasFuncionalidade> TbBasFuncionalidade { get; set; }
        public virtual DbSet<TbBasGenero> TbBasGenero { get; set; }
        public virtual DbSet<TbBasGrauparentesco> TbBasGrauparentesco { get; set; }
        public virtual DbSet<TbBasGrupoparametro> TbBasGrupoparametro { get; set; }
        public virtual DbSet<TbBasIdioma> TbBasIdioma { get; set; }
        public virtual DbSet<TbBasIndisponibilidade> TbBasIndisponibilidade { get; set; }
        public virtual DbSet<TbBasLog> TbBasLog { get; set; }
        public virtual DbSet<TbBasMeiospagto> TbBasMeiospagto { get; set; }
        public virtual DbSet<TbBasMeiotransporte> TbBasMeiotransporte { get; set; }
        public virtual DbSet<TbBasMidia> TbBasMidia { get; set; }
        public virtual DbSet<TbBasMidiassociais> TbBasMidiassociais { get; set; }
        public virtual DbSet<TbBasModalidade> TbBasModalidade { get; set; }
        public virtual DbSet<TbBasModalidadeUnidades> TbBasModalidadeUnidades { get; set; }
        public virtual DbSet<TbBasNacionalidade> TbBasNacionalidade { get; set; }
        public virtual DbSet<TbBasNecessespecial> TbBasNecessespecial { get; set; }
        public virtual DbSet<TbBasOnibusitem> TbBasOnibusitem { get; set; }
        public virtual DbSet<TbBasOnibusopcaoitem> TbBasOnibusopcaoitem { get; set; }
        public virtual DbSet<TbBasOperadora> TbBasOperadora { get; set; }
        public virtual DbSet<TbBasPais> TbBasPais { get; set; }
        public virtual DbSet<TbBasPalavrarestrita> TbBasPalavrarestrita { get; set; }
        public virtual DbSet<TbBasPeriodoatividades> TbBasPeriodoatividades { get; set; }
        public virtual DbSet<TbBasPermanencia> TbBasPermanencia { get; set; }
        public virtual DbSet<TbBasRacacor> TbBasRacacor { get; set; }
        public virtual DbSet<TbBasRights> TbBasRights { get; set; }
        public virtual DbSet<TbBasRightsauthassignment> TbBasRightsauthassignment { get; set; }
        public virtual DbSet<TbBasRightsauthitem> TbBasRightsauthitem { get; set; }
        public virtual DbSet<TbBasRightsauthitemchild> TbBasRightsauthitemchild { get; set; }
        public virtual DbSet<TbBasSexo> TbBasSexo { get; set; }
        public virtual DbSet<TbBasTermocontrato> TbBasTermocontrato { get; set; }
        public virtual DbSet<TbBasTipocamiseta> TbBasTipocamiseta { get; set; }
        public virtual DbSet<TbBasTipodocsdigitalizados> TbBasTipodocsdigitalizados { get; set; }
        public virtual DbSet<TbBasTipodoctemplate> TbBasTipodoctemplate { get; set; }
        public virtual DbSet<TbBasTipodoctemplatemacro> TbBasTipodoctemplatemacro { get; set; }
        public virtual DbSet<TbBasTipoendereco> TbBasTipoendereco { get; set; }
        public virtual DbSet<TbBasTipoescola> TbBasTipoescola { get; set; }
        public virtual DbSet<TbBasTipomensagem> TbBasTipomensagem { get; set; }
        public virtual DbSet<TbBasTipopessoa> TbBasTipopessoa { get; set; }
        public virtual DbSet<TbBasTipopremiacao> TbBasTipopremiacao { get; set; }
        public virtual DbSet<TbBasTiporg> TbBasTiporg { get; set; }
        public virtual DbSet<TbBasTipotelefone> TbBasTipotelefone { get; set; }
        public virtual DbSet<TbBasTipovinculopessoa> TbBasTipovinculopessoa { get; set; }
        public virtual DbSet<TbBasUf> TbBasUf { get; set; }
        public virtual DbSet<TbBasVisibilidade> TbBasVisibilidade { get; set; }
        public virtual DbSet<TbBasVisibilidadeUnidades> TbBasVisibilidadeUnidades { get; set; }
        public virtual DbSet<TbCadAcessoCantina> TbCadAcessoCantina { get; set; }
        public virtual DbSet<TbCadAgenciarepresentante> TbCadAgenciarepresentante { get; set; }
        public virtual DbSet<TbCadAlocacaoonibus> TbCadAlocacaoonibus { get; set; }
        public virtual DbSet<TbCadAlocacaoonibusOnibus> TbCadAlocacaoonibusOnibus { get; set; }
        public virtual DbSet<TbCadAlocacaoonibusPacote> TbCadAlocacaoonibusPacote { get; set; }
        public virtual DbSet<TbCadBoleto> TbCadBoleto { get; set; }
        public virtual DbSet<TbCadBoletoacampante> TbCadBoletoacampante { get; set; }
        public virtual DbSet<TbCadBoletoacampanteInscricao> TbCadBoletoacampanteInscricao { get; set; }
        public virtual DbSet<TbCadCamiseta> TbCadCamiseta { get; set; }
        public virtual DbSet<TbCadCamisetaTemporada> TbCadCamisetaTemporada { get; set; }
        public virtual DbSet<TbCadChale> TbCadChale { get; set; }
        public virtual DbSet<TbCadChaleCarga> TbCadChaleCarga { get; set; }
        public virtual DbSet<TbCadCupom> TbCadCupom { get; set; }
        public virtual DbSet<TbCadCupomItem> TbCadCupomItem { get; set; }
        public virtual DbSet<TbCadCupomUtilizacao> TbCadCupomUtilizacao { get; set; }
        public virtual DbSet<TbCadDocumento> TbCadDocumento { get; set; }
        public virtual DbSet<TbCadEmails> TbCadEmails { get; set; }
        public virtual DbSet<TbCadEmails20190626> TbCadEmails20190626 { get; set; }
        public virtual DbSet<TbCadEmailsCarga> TbCadEmailsCarga { get; set; }
        public virtual DbSet<TbCadEnquete> TbCadEnquete { get; set; }
        public virtual DbSet<TbCadEnqueteEscolasegrupos> TbCadEnqueteEscolasegrupos { get; set; }
        public virtual DbSet<TbCadEnquetetemporada> TbCadEnquetetemporada { get; set; }
        public virtual DbSet<TbCadEscBoleto> TbCadEscBoleto { get; set; }
        public virtual DbSet<TbCadEscCategoria> TbCadEscCategoria { get; set; }
        public virtual DbSet<TbCadEscEvento> TbCadEscEvento { get; set; }
        public virtual DbSet<TbCadEscEvento2> TbCadEscEvento2 { get; set; }
        public virtual DbSet<TbCadEscEventoAntiga> TbCadEscEventoAntiga { get; set; }
        public virtual DbSet<TbCadEscEventoBackup> TbCadEscEventoBackup { get; set; }
        public virtual DbSet<TbCadEscEventoNova> TbCadEscEventoNova { get; set; }
        public virtual DbSet<TbCadEscPagamento> TbCadEscPagamento { get; set; }
        public virtual DbSet<TbCadEscPessoa> TbCadEscPessoa { get; set; }
        public virtual DbSet<TbCadEscPessoa2> TbCadEscPessoa2 { get; set; }
        public virtual DbSet<TbCadEscPessoaFormacao> TbCadEscPessoaFormacao { get; set; }
        public virtual DbSet<TbCadEscPessoaNova> TbCadEscPessoaNova { get; set; }
        public virtual DbSet<TbCadEscSapiens> TbCadEscSapiens { get; set; }
        public virtual DbSet<TbCadEscVinculo> TbCadEscVinculo { get; set; }
        public virtual DbSet<TbCadEscVinculo20170207> TbCadEscVinculo20170207 { get; set; }
        public virtual DbSet<TbCadEscVinculo20170210> TbCadEscVinculo20170210 { get; set; }
        public virtual DbSet<TbCadEscola> TbCadEscola { get; set; }
        public virtual DbSet<TbCadEscolacontato> TbCadEscolacontato { get; set; }
        public virtual DbSet<TbCadEscolaendereco> TbCadEscolaendereco { get; set; }
        public virtual DbSet<TbCadEvento> TbCadEvento { get; set; }
        public virtual DbSet<TbCadExcecaoIdAcampante> TbCadExcecaoIdAcampante { get; set; }
        public virtual DbSet<TbCadFilaSms> TbCadFilaSms { get; set; }
        public virtual DbSet<TbCadFormulario> TbCadFormulario { get; set; }
        public virtual DbSet<TbCadInscricao> TbCadInscricao { get; set; }
        public virtual DbSet<TbCadInscricaoCarga> TbCadInscricaoCarga { get; set; }
        public virtual DbSet<TbCadItemformulario> TbCadItemformulario { get; set; }
        public virtual DbSet<TbCadLancatividades> TbCadLancatividades { get; set; }
        public virtual DbSet<TbCadLogCartao> TbCadLogCartao { get; set; }
        public virtual DbSet<TbCadLogCartaoSistema> TbCadLogCartaoSistema { get; set; }
        public virtual DbSet<TbCadLogCielo20161013> TbCadLogCielo20161013 { get; set; }
        public virtual DbSet<TbCadLogCupom> TbCadLogCupom { get; set; }
        public virtual DbSet<TbCadMensagem> TbCadMensagem { get; set; }
        public virtual DbSet<TbCadMensagemcoletiva> TbCadMensagemcoletiva { get; set; }
        public virtual DbSet<TbCadMensagensgerais> TbCadMensagensgerais { get; set; }
        public virtual DbSet<TbCadNrmail> TbCadNrmail { get; set; }
        public virtual DbSet<TbCadNrmailImap> TbCadNrmailImap { get; set; }
        public virtual DbSet<TbCadOnibus> TbCadOnibus { get; set; }
        public virtual DbSet<TbCadOnibusAlocacao> TbCadOnibusAlocacao { get; set; }
        public virtual DbSet<TbCadOnibusAlocacao20171021> TbCadOnibusAlocacao20171021 { get; set; }
        public virtual DbSet<TbCadOnibusPacote> TbCadOnibusPacote { get; set; }
        public virtual DbSet<TbCadOnibusSaida> TbCadOnibusSaida { get; set; }
        public virtual DbSet<TbCadPacote> TbCadPacote { get; set; }
        public virtual DbSet<TbCadPacoteCarga> TbCadPacoteCarga { get; set; }
        public virtual DbSet<TbCadPacoteonibus20160324> TbCadPacoteonibus20160324 { get; set; }
        public virtual DbSet<TbCadPacoteonibusPoltrona20160324> TbCadPacoteonibusPoltrona20160324 { get; set; }
        public virtual DbSet<TbCadPacoteprecos> TbCadPacoteprecos { get; set; }
        public virtual DbSet<TbCadPacotetabelaprecos> TbCadPacotetabelaprecos { get; set; }
        public virtual DbSet<TbCadPacotetemporada> TbCadPacotetemporada { get; set; }
        public virtual DbSet<TbCadPacotetemporadaCarga> TbCadPacotetemporadaCarga { get; set; }
        public virtual DbSet<TbCadPagamento> TbCadPagamento { get; set; }
        public virtual DbSet<TbCadPagamentoAcampante> TbCadPagamentoAcampante { get; set; }
        public virtual DbSet<TbCadPagamentoAcampanteTicket> TbCadPagamentoAcampanteTicket { get; set; }
        public virtual DbSet<TbCadPagamentoAcampanteTicketind> TbCadPagamentoAcampanteTicketind { get; set; }
        public virtual DbSet<TbCadPagamentoCondmeio> TbCadPagamentoCondmeio { get; set; }
        public virtual DbSet<TbCadPagamentoParcela> TbCadPagamentoParcela { get; set; }
        public virtual DbSet<TbCadPagtoinscricao> TbCadPagtoinscricao { get; set; }
        public virtual DbSet<TbCadPagtoinscricaoParcela> TbCadPagtoinscricaoParcela { get; set; }
        public virtual DbSet<TbCadParametro> TbCadParametro { get; set; }
        public virtual DbSet<TbCadParametronr> TbCadParametronr { get; set; }
        public virtual DbSet<TbCadPessoa> TbCadPessoa { get; set; }
        public virtual DbSet<TbCadPessoa2> TbCadPessoa2 { get; set; }
        public virtual DbSet<TbCadPessoaAntiga> TbCadPessoaAntiga { get; set; }
        public virtual DbSet<TbCadPessoaassistente> TbCadPessoaassistente { get; set; }
        public virtual DbSet<TbCadPessoaassistenteDisponibilidade> TbCadPessoaassistenteDisponibilidade { get; set; }
        public virtual DbSet<TbCadPessoaassistenteDisponibilidadeEsc> TbCadPessoaassistenteDisponibilidadeEsc { get; set; }
        public virtual DbSet<TbCadPessoaassistenteDisponibilidadeTemp> TbCadPessoaassistenteDisponibilidadeTemp { get; set; }
        public virtual DbSet<TbCadPessoaassistenteEspcultura> TbCadPessoaassistenteEspcultura { get; set; }
        public virtual DbSet<TbCadPessoaconveniomedico> TbCadPessoaconveniomedico { get; set; }
        public virtual DbSet<TbCadPessoadiario> TbCadPessoadiario { get; set; }
        public virtual DbSet<TbCadPessoadoc> TbCadPessoadoc { get; set; }
        public virtual DbSet<TbCadPessoadocdigitalizado> TbCadPessoadocdigitalizado { get; set; }
        public virtual DbSet<TbCadPessoaexpprofissional> TbCadPessoaexpprofissional { get; set; }
        public virtual DbSet<TbCadPessoaficha> TbCadPessoaficha { get; set; }
        public virtual DbSet<TbCadPessoafichatelefone> TbCadPessoafichatelefone { get; set; }
        public virtual DbSet<TbCadPessoafichatelefoneEmergencial> TbCadPessoafichatelefoneEmergencial { get; set; }
        public virtual DbSet<TbCadPessoaformacao> TbCadPessoaformacao { get; set; }
        public virtual DbSet<TbCadPessoaformulario> TbCadPessoaformulario { get; set; }
        public virtual DbSet<TbCadPessoaformulariores> TbCadPessoaformulariores { get; set; }
        public virtual DbSet<TbCadPessoaidacampante> TbCadPessoaidacampante { get; set; }
        public virtual DbSet<TbCadPessoaidioma> TbCadPessoaidioma { get; set; }
        public virtual DbSet<TbCadPessoamidiasocial> TbCadPessoamidiasocial { get; set; }
        public virtual DbSet<TbCadPessoanecessespec> TbCadPessoanecessespec { get; set; }
        public virtual DbSet<TbCadPessoanrmail> TbCadPessoanrmail { get; set; }
        public virtual DbSet<TbCadPessoapapel> TbCadPessoapapel { get; set; }
        public virtual DbSet<TbCadPessoapapelCarga> TbCadPessoapapelCarga { get; set; }
        public virtual DbSet<TbCadPessoapapelreserva> TbCadPessoapapelreserva { get; set; }
        public virtual DbSet<TbCadPessoapapelreservaCarga> TbCadPessoapapelreservaCarga { get; set; }
        public virtual DbSet<TbCadPessoapapelreservaDobra> TbCadPessoapapelreservaDobra { get; set; }
        public virtual DbSet<TbCadPessoapapelreservaTicket> TbCadPessoapapelreservaTicket { get; set; }
        public virtual DbSet<TbCadPessoapapelreservaTicketind> TbCadPessoapapelreservaTicketind { get; set; }
        public virtual DbSet<TbCadPessoapapelreservaTransporte> TbCadPessoapapelreservaTransporte { get; set; }
        public virtual DbSet<TbCadPessoapapelreservaent> TbCadPessoapapelreservaent { get; set; }
        public virtual DbSet<TbCadPessoapapelreservahist> TbCadPessoapapelreservahist { get; set; }
        public virtual DbSet<TbCadPessoapremiacao> TbCadPessoapremiacao { get; set; }
        public virtual DbSet<TbCadPessoarel> TbCadPessoarel { get; set; }
        public virtual DbSet<TbCadPessoarel20161201> TbCadPessoarel20161201 { get; set; }
        public virtual DbSet<TbCadPessoarel20161220> TbCadPessoarel20161220 { get; set; }
        public virtual DbSet<TbCadPessoarelBkp20160118> TbCadPessoarelBkp20160118 { get; set; }
        public virtual DbSet<TbCadPessoarelBkp20160509> TbCadPessoarelBkp20160509 { get; set; }
        public virtual DbSet<TbCadPessoarelBkp20160615> TbCadPessoarelBkp20160615 { get; set; }
        public virtual DbSet<TbCadPessoarelBkp20161201> TbCadPessoarelBkp20161201 { get; set; }
        public virtual DbSet<TbCadPessoares> TbCadPessoares { get; set; }
        public virtual DbSet<TbCadPropostacomercial> TbCadPropostacomercial { get; set; }
        public virtual DbSet<TbCadPushMensagem> TbCadPushMensagem { get; set; }
        public virtual DbSet<TbCadPushMensagemToken> TbCadPushMensagemToken { get; set; }
        public virtual DbSet<TbCadPushToken> TbCadPushToken { get; set; }
        public virtual DbSet<TbCadRemessa> TbCadRemessa { get; set; }
        public virtual DbSet<TbCadRepresentante> TbCadRepresentante { get; set; }
        public virtual DbSet<TbCadRepresentanteagencia> TbCadRepresentanteagencia { get; set; }
        public virtual DbSet<TbCadRetorno> TbCadRetorno { get; set; }
        public virtual DbSet<TbCadRetornoConteudo> TbCadRetornoConteudo { get; set; }
        public virtual DbSet<TbCadSmsComunicacaoTransporte> TbCadSmsComunicacaoTransporte { get; set; }
        public virtual DbSet<TbCadSmsComunicacaoTransportehist> TbCadSmsComunicacaoTransportehist { get; set; }
        public virtual DbSet<TbCadSolicitacaocontato> TbCadSolicitacaocontato { get; set; }
        public virtual DbSet<TbCadSolicitacaocontatoevento> TbCadSolicitacaocontatoevento { get; set; }
        public virtual DbSet<TbCadSolicitacaocontatohist> TbCadSolicitacaocontatohist { get; set; }
        public virtual DbSet<TbCadTempchaleDistribuicao> TbCadTempchaleDistribuicao { get; set; }
        public virtual DbSet<TbCadTempchaleDistribuicaoCarga> TbCadTempchaleDistribuicaoCarga { get; set; }
        public virtual DbSet<TbCadTemporada> TbCadTemporada { get; set; }
        public virtual DbSet<TbCadTemporadaCarga> TbCadTemporadaCarga { get; set; }
        public virtual DbSet<TbCadTemporadachale> TbCadTemporadachale { get; set; }
        public virtual DbSet<TbCadTemporadachaleCarga> TbCadTemporadachaleCarga { get; set; }
        public virtual DbSet<TbCadTemporadaequipe> TbCadTemporadaequipe { get; set; }
        public virtual DbSet<TbCadTemporadaequipeFoto> TbCadTemporadaequipeFoto { get; set; }
        public virtual DbSet<TbCadTemporadaequipeFotopessoa> TbCadTemporadaequipeFotopessoa { get; set; }
        public virtual DbSet<TbCadTemporadaequipePessoas> TbCadTemporadaequipePessoas { get; set; }
        public virtual DbSet<TbCadTemporadaturma> TbCadTemporadaturma { get; set; }
        public virtual DbSet<TbCadTeste> TbCadTeste { get; set; }
        public virtual DbSet<TbCadTicket> TbCadTicket { get; set; }
        public virtual DbSet<TbCadTipopapel> TbCadTipopapel { get; set; }
        public virtual DbSet<TbCadTurmanr> TbCadTurmanr { get; set; }
        public virtual DbSet<TbCadTurmanrAcampante> TbCadTurmanrAcampante { get; set; }
        public virtual DbSet<TbCadTurmanrlog> TbCadTurmanrlog { get; set; }
        public virtual DbSet<TbCadUnidadenr> TbCadUnidadenr { get; set; }
        public virtual DbSet<TbCadUsuario> TbCadUsuario { get; set; }
        public virtual DbSet<TbCadUsuarioatalho> TbCadUsuarioatalho { get; set; }
        public virtual DbSet<TbCronPush> TbCronPush { get; set; }
        public virtual DbSet<TbImpPessoares> TbImpPessoares { get; set; }
        public virtual DbSet<TbImpPessoares2> TbImpPessoares2 { get; set; }
        public virtual DbSet<TbRptLogCartaoSistema> TbRptLogCartaoSistema { get; set; }
        public virtual DbSet<TbTempDescontoirmao> TbTempDescontoirmao { get; set; }
        public virtual DbSet<TbTempEquipeacampante> TbTempEquipeacampante { get; set; }
        public virtual DbSet<TbTempEscEvento> TbTempEscEvento { get; set; }
        public virtual DbSet<TbTempEscEvento20180219> TbTempEscEvento20180219 { get; set; }
        public virtual DbSet<VwBoletosSapiens> VwBoletosSapiens { get; set; }
        public virtual DbSet<VwLog> VwLog { get; set; }
        public virtual DbSet<VwNrTransporte> VwNrTransporte { get; set; }
        public virtual DbSet<VwParametro> VwParametro { get; set; }
        public virtual DbSet<VwParametronr> VwParametronr { get; set; }
        public virtual DbSet<VwUnidadenr> VwUnidadenr { get; set; }
        public virtual DbSet<VwUspJobEscEvento> VwUspJobEscEvento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:192.168.15.200;Initial Catalog=DB_PRD_NR;MultipleActiveResultSets=true;User ID=sa;Password=Kalel2018");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("A_PEDIDO");

                entity.Property(e => e.EveCod)
                    .IsRequired()
                    .HasColumnName("EVE_COD")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PedCod)
                    .HasColumnName("PED_COD")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.PedDte)
                    .HasColumnName("PED_DTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedDts)
                    .HasColumnName("PED_DTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.PedRep)
                    .HasColumnName("PED_REP")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<BcAcampantes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_ACAMPANTES");

                entity.Property(e => e.AcaAfa)
                    .HasColumnName("ACA_AFA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcaAge)
                    .HasColumnName("ACA_AGE")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.AcaAlt)
                    .HasColumnName("ACA_ALT")
                    .HasColumnType("numeric(7, 3)");

                entity.Property(e => e.AcaAno).HasColumnName("ACA_ANO");

                entity.Property(e => e.AcaApe)
                    .HasColumnName("ACA_APE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaArtaxe).HasColumnName("ACA_ARTAXE");

                entity.Property(e => e.AcaArtbal).HasColumnName("ACA_ARTBAL");

                entity.Property(e => e.AcaArtdan).HasColumnName("ACA_ARTDAN");

                entity.Property(e => e.AcaArtdes).HasColumnName("ACA_ARTDES");

                entity.Property(e => e.AcaArtmag).HasColumnName("ACA_ARTMAG");

                entity.Property(e => e.AcaArtmal).HasColumnName("ACA_ARTMAL");

                entity.Property(e => e.AcaArtout)
                    .HasColumnName("ACA_ARTOUT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaArtpin).HasColumnName("ACA_ARTPIN");

                entity.Property(e => e.AcaArtpir).HasColumnName("ACA_ARTPIR");

                entity.Property(e => e.AcaArtsap).HasColumnName("ACA_ARTSAP");

                entity.Property(e => e.AcaArttea).HasColumnName("ACA_ARTTEA");

                entity.Property(e => e.AcaAti)
                    .HasColumnName("ACA_ATI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcaAtu)
                    .HasColumnName("ACA_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaBan)
                    .HasColumnName("ACA_BAN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AcaBer)
                    .HasColumnName("ACA_BER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCad)
                    .HasColumnName("ACA_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaCal)
                    .HasColumnName("ACA_CAL")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCam)
                    .HasColumnName("ACA_CAM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCar).HasColumnName("ACA_CAR");

                entity.Property(e => e.AcaCarre)
                    .HasColumnName("ACA_CARRE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCco)
                    .HasColumnName("ACA_CCO")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCel)
                    .HasColumnName("ACA_CEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCod).HasColumnName("ACA_COD");

                entity.Property(e => e.AcaCon1)
                    .HasColumnName("ACA_CON1")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaCon2)
                    .HasColumnName("ACA_CON2")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaCon3)
                    .HasColumnName("ACA_CON3")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaContr)
                    .HasColumnName("ACA_CONTR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCpf)
                    .HasColumnName("ACA_CPF")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.AcaCur3)
                    .HasColumnName("ACA_CUR3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaDep)
                    .HasColumnName("ACA_DEP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AcaDisanores)
                    .HasColumnName("ACA_DISANORES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaDisanosn).HasColumnName("ACA_DISANOSN");

                entity.Property(e => e.AcaDisferres)
                    .HasColumnName("ACA_DISFERRES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaDisfersn).HasColumnName("ACA_DISFERSN");

                entity.Property(e => e.AcaEsc1)
                    .HasColumnName("ACA_ESC1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaEsc2)
                    .HasColumnName("ACA_ESC2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaEsc3)
                    .HasColumnName("ACA_ESC3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaEspalp).HasColumnName("ACA_ESPALP");

                entity.Property(e => e.AcaEspatl).HasColumnName("ACA_ESPATL");

                entity.Property(e => e.AcaEspbas).HasColumnName("ACA_ESPBAS");

                entity.Property(e => e.AcaEspfut).HasColumnName("ACA_ESPFUT");

                entity.Property(e => e.AcaEsphan).HasColumnName("ACA_ESPHAN");

                entity.Property(e => e.AcaEsphip).HasColumnName("ACA_ESPHIP");

                entity.Property(e => e.AcaEspmus).HasColumnName("ACA_ESPMUS");

                entity.Property(e => e.AcaEspnat).HasColumnName("ACA_ESPNAT");

                entity.Property(e => e.AcaEspsur).HasColumnName("ACA_ESPSUR");

                entity.Property(e => e.AcaEspten).HasColumnName("ACA_ESPTEN");

                entity.Property(e => e.AcaEsptre).HasColumnName("ACA_ESPTRE");

                entity.Property(e => e.AcaEspvol).HasColumnName("ACA_ESPVOL");

                entity.Property(e => e.AcaFoto)
                    .HasColumnName("ACA_FOTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaGra)
                    .HasColumnName("ACA_GRA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AcaHab).HasColumnName("ACA_HAB");

                entity.Property(e => e.AcaHob)
                    .HasColumnName("ACA_HOB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaImp)
                    .HasColumnName("ACA_IMP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcaIni)
                    .HasColumnName("ACA_INI")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaInt)
                    .HasColumnName("ACA_INT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaLinesp).HasColumnName("ACA_LINESP");

                entity.Property(e => e.AcaLining).HasColumnName("ACA_LINING");

                entity.Property(e => e.AcaLinout).HasColumnName("ACA_LINOUT");

                entity.Property(e => e.AcaLinoutd)
                    .HasColumnName("ACA_LINOUTD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMail)
                    .HasColumnName("ACA_MAIL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMailChe).HasColumnName("ACA_MAIL_CHE");

                entity.Property(e => e.AcaMor)
                    .HasColumnName("ACA_MOR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMorMail)
                    .HasColumnName("ACA_MOR_MAIL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMorNom)
                    .HasColumnName("ACA_MOR_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMorPar)
                    .HasColumnName("ACA_MOR_PAR")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMorTel)
                    .HasColumnName("ACA_MOR_TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMusbat).HasColumnName("ACA_MUSBAT");

                entity.Property(e => e.AcaMuscan).HasColumnName("ACA_MUSCAN");

                entity.Property(e => e.AcaMuscor).HasColumnName("ACA_MUSCOR");

                entity.Property(e => e.AcaMusout)
                    .HasColumnName("ACA_MUSOUT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcaMusper).HasColumnName("ACA_MUSPER");

                entity.Property(e => e.AcaMustec).HasColumnName("ACA_MUSTEC");

                entity.Property(e => e.AcaMusvio).HasColumnName("ACA_MUSVIO");

                entity.Property(e => e.AcaNas)
                    .HasColumnName("ACA_NAS")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaNeg)
                    .HasColumnName("ACA_NEG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcaNom)
                    .HasColumnName("ACA_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AcaObs)
                    .HasColumnName("ACA_OBS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaOem)
                    .HasColumnName("ACA_OEM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AcaOrd).HasColumnName("ACA_ORD");

                entity.Property(e => e.AcaOut).HasColumnName("ACA_OUT");

                entity.Property(e => e.AcaPad)
                    .HasColumnName("ACA_PAD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcaPer)
                    .HasColumnName("ACA_PER")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AcaPes)
                    .HasColumnName("ACA_PES")
                    .HasColumnType("numeric(7, 3)");

                entity.Property(e => e.AcaProcar)
                    .HasColumnName("ACA_PROCAR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AcaProcid)
                    .HasColumnName("ACA_PROCID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AcaProcon).HasColumnName("ACA_PROCON");

                entity.Property(e => e.AcaProfim)
                    .HasColumnName("ACA_PROFIM")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaProini)
                    .HasColumnName("ACA_PROINI")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaProres)
                    .HasColumnName("ACA_PRORES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaProult)
                    .HasColumnName("ACA_PROULT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AcaReg)
                    .HasColumnName("ACA_REG")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AcaRes)
                    .HasColumnName("ACA_RES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaSen)
                    .HasColumnName("ACA_SEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcaSer)
                    .HasColumnName("ACA_SER")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AcaSex)
                    .HasColumnName("ACA_SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcaTrg)
                    .HasColumnName("ACA_TRG")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AcaUltc)
                    .HasColumnName("ACA_ULTC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaUnico)
                    .HasColumnName("ACA_UNICO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AcaUnidt)
                    .HasColumnName("ACA_UNIDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcaUnisn).HasColumnName("ACA_UNISN");

                entity.Property(e => e.AcaVetagu).HasColumnName("ACA_VETAGU");

                entity.Property(e => e.AcaVetfaz).HasColumnName("ACA_VETFAZ");

                entity.Property(e => e.AcaVetfer).HasColumnName("ACA_VETFER");

                entity.Property(e => e.AcaVetgua).HasColumnName("ACA_VETGUA");

                entity.Property(e => e.AcaVetitu).HasColumnName("ACA_VETITU");

                entity.Property(e => e.AcaVetsao).HasColumnName("ACA_VETSAO");

                entity.Property(e => e.AcaVetsap).HasColumnName("ACA_VETSAP");

                entity.Property(e => e.ArqRg)
                    .HasColumnName("ARQ_RG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BcatCod).HasColumnName("BCAT_COD");

                entity.Property(e => e.CatmCod).HasColumnName("CATM_COD");

                entity.Property(e => e.DivEsc)
                    .HasColumnName("DIV_ESC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EscCod).HasColumnName("ESC_COD");

                entity.Property(e => e.FamCod)
                    .HasColumnName("FAM_COD")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.MaeCod)
                    .HasColumnName("MAE_COD")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.ObsFin)
                    .HasColumnName("OBS_FIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaiCod)
                    .HasColumnName("PAI_COD")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.ResCod).HasColumnName("RES_COD");

                entity.Property(e => e.ResFin).HasColumnName("RES_FIN");

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcAnteriores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_ANTERIORES");

                entity.Property(e => e.Acacod).HasColumnName("ACACOD");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Datalt)
                    .HasColumnName("DATALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datcad)
                    .HasColumnName("DATCAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paccod).HasColumnName("PACCOD");

                entity.Property(e => e.Pacdes)
                    .HasColumnName("PACDES")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Texant)
                    .HasColumnName("TEXANT")
                    .HasColumnType("text");

                entity.Property(e => e.Usucod).HasColumnName("USUCOD");

                entity.Property(e => e.Usunom)
                    .HasColumnName("USUNOM")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BcCategoria>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_CATEGORIA");

                entity.Property(e => e.BcatAba).HasColumnName("BCAT_ABA");

                entity.Property(e => e.BcatAtu)
                    .HasColumnName("BCAT_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.BcatCad)
                    .HasColumnName("BCAT_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.BcatCod).HasColumnName("BCAT_COD");

                entity.Property(e => e.BcatDesc)
                    .HasColumnName("BCAT_DESC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BcatDia)
                    .HasColumnName("BCAT_DIA")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.BcatTip)
                    .HasColumnName("BCAT_TIP")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcChale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_CHALE");

                entity.Property(e => e.ChaAtu)
                    .HasColumnName("CHA_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChaCad)
                    .HasColumnName("CHA_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChaCod).HasColumnName("CHA_COD");

                entity.Property(e => e.ChaNom)
                    .HasColumnName("CHA_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ChaSex)
                    .HasColumnName("CHA_SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChaVag)
                    .HasColumnName("CHA_VAG")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.UniCod).HasColumnName("UNI_COD");

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcEscola>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_ESCOLA");

                entity.Property(e => e.EscAlt)
                    .HasColumnName("ESC_ALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EscCad)
                    .HasColumnName("ESC_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.EscCod).HasColumnName("ESC_COD");

                entity.Property(e => e.EscNom)
                    .HasColumnName("ESC_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcFamilia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_FAMILIA");

                entity.Property(e => e.FamAtu)
                    .HasColumnName("FAM_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.FamBai)
                    .HasColumnName("FAM_BAI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FamCad)
                    .HasColumnName("FAM_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.FamCep)
                    .HasColumnName("FAM_CEP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FamCid)
                    .HasColumnName("FAM_CID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FamCod)
                    .HasColumnName("FAM_COD")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.FamEnd)
                    .HasColumnName("FAM_END")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FamEst)
                    .HasColumnName("FAM_EST")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FamMer)
                    .HasColumnName("FAM_MER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FamObs)
                    .HasColumnName("FAM_OBS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FamPai)
                    .HasColumnName("FAM_PAI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FamTel)
                    .HasColumnName("FAM_TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FamTel1)
                    .HasColumnName("FAM_TEL1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FamTel2)
                    .HasColumnName("FAM_TEL2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FamTel3)
                    .HasColumnName("FAM_TEL3")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FamZip)
                    .HasColumnName("FAM_ZIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuAtu).HasColumnName("USU_ATU");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_HISTORICO");

                entity.Property(e => e.AcaCod).HasColumnName("ACA_COD");

                entity.Property(e => e.HisCod).HasColumnName("HIS_COD");

                entity.Property(e => e.HisDat)
                    .HasColumnName("HIS_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.HisOri)
                    .HasColumnName("HIS_ORI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HisTex)
                    .HasColumnName("HIS_TEX")
                    .HasColumnType("text");

                entity.Property(e => e.HisTip)
                    .HasColumnName("HIS_TIP")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");

                entity.Property(e => e.UsuNom)
                    .HasColumnName("USU_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BcInscricao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_INSCRICAO");

                entity.Property(e => e.AcaCod).HasColumnName("ACA_COD");

                entity.Property(e => e.BarCod).HasColumnName("BAR_COD");

                entity.Property(e => e.BarVar)
                    .HasColumnName("BAR_VAR")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.BcatCod).HasColumnName("BCAT_COD");

                entity.Property(e => e.CodCpg)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DatCfm)
                    .HasColumnName("DAT_CFM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataIda)
                    .HasColumnName("DATA_IDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVolta)
                    .HasColumnName("DATA_VOLTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DivEsc)
                    .HasColumnName("DIV_ESC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EscCod).HasColumnName("ESC_COD");

                entity.Property(e => e.HoraIda)
                    .HasColumnName("HORA_IDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraVolta)
                    .HasColumnName("HORA_VOLTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsAba)
                    .HasColumnName("INS_ABA")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.InsAno).HasColumnName("INS_ANO");

                entity.Property(e => e.InsAtu)
                    .HasColumnName("INS_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsBar)
                    .HasColumnName("INS_BAR")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.InsCad)
                    .HasColumnName("INS_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsCam)
                    .HasColumnName("INS_CAM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InsCar)
                    .HasColumnName("INS_CAR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsCarv)
                    .HasColumnName("INS_CARV")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsCfm)
                    .HasColumnName("INS_CFM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InsCod).HasColumnName("INS_COD");

                entity.Property(e => e.InsCon).HasColumnName("INS_CON");

                entity.Property(e => e.InsDat)
                    .HasColumnName("INS_DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsDes)
                    .HasColumnName("INS_DES")
                    .HasColumnType("numeric(11, 4)");

                entity.Property(e => e.InsGra)
                    .HasColumnName("INS_GRA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InsMor)
                    .HasColumnName("INS_MOR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsMorEma)
                    .HasColumnName("INS_MOR_EMA")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InsMorNom)
                    .HasColumnName("INS_MOR_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InsMorPar)
                    .HasColumnName("INS_MOR_PAR")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InsMorTel)
                    .HasColumnName("INS_MOR_TEL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InsPed).HasColumnName("INS_PED");

                entity.Property(e => e.InsPol).HasColumnName("INS_POL");

                entity.Property(e => e.InsPolv).HasColumnName("INS_POLV");

                entity.Property(e => e.InsPro)
                    .HasColumnName("INS_PRO")
                    .HasColumnType("numeric(11, 4)");

                entity.Property(e => e.InsSen)
                    .HasColumnName("INS_SEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsSer)
                    .HasColumnName("INS_SER")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InsSta)
                    .HasColumnName("INS_STA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsTab)
                    .HasColumnName("INS_TAB")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.InsTra).HasColumnName("INS_TRA");

                entity.Property(e => e.InsTrav).HasColumnName("INS_TRAV");

                entity.Property(e => e.InsVab)
                    .HasColumnName("INS_VAB")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.InsVde)
                    .HasColumnName("INS_VDE")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.InsVlb)
                    .HasColumnName("INS_VLB")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.InsVll)
                    .HasColumnName("INS_VLL")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.InsVpr)
                    .HasColumnName("INS_VPR")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.ModeloIda)
                    .HasColumnName("MODELO_IDA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloVolta)
                    .HasColumnName("MODELO_VOLTA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OniCod).HasColumnName("ONI_COD");

                entity.Property(e => e.OniCodv).HasColumnName("ONI_CODV");

                entity.Property(e => e.PacCod).HasColumnName("PAC_COD");

                entity.Property(e => e.PgtCod).HasColumnName("PGT_COD");

                entity.Property(e => e.PlacaIda)
                    .HasColumnName("PLACA_IDA")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlacaVolta)
                    .HasColumnName("PLACA_VOLTA")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ResCod).HasColumnName("RES_COD");

                entity.Property(e => e.ResponsavelIda)
                    .HasColumnName("RESPONSAVEL_IDA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsavelVolta)
                    .HasColumnName("RESPONSAVEL_VOLTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcMae>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_MAE");

                entity.Property(e => e.CpfMae)
                    .HasColumnName("CPF_MAE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MaeAtu)
                    .HasColumnName("MAE_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaeCad)
                    .HasColumnName("MAE_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaeCod)
                    .HasColumnName("MAE_COD")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.MaeEmp)
                    .HasColumnName("MAE_EMP")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MaeFal).HasColumnName("MAE_FAL");

                entity.Property(e => e.MaeFun)
                    .HasColumnName("MAE_FUN")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MaeMail)
                    .HasColumnName("MAE_MAIL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MaeMailAti).HasColumnName("MAE_MAIL_ATI");

                entity.Property(e => e.MaeMer)
                    .HasColumnName("MAE_MER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaeNom)
                    .HasColumnName("MAE_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MaeNomsol)
                    .HasColumnName("MAE_NOMSOL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MaeObs)
                    .HasColumnName("MAE_OBS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaeTel1)
                    .HasColumnName("MAE_TEL1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaeTel2)
                    .HasColumnName("MAE_TEL2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaeTel3)
                    .HasColumnName("MAE_TEL3")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaeTel4)
                    .HasColumnName("MAE_TEL4")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaeVet)
                    .HasColumnName("MAE_VET")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaeVetagu).HasColumnName("MAE_VETAGU");

                entity.Property(e => e.MaeVetfaz).HasColumnName("MAE_VETFAZ");

                entity.Property(e => e.MaeVetfer).HasColumnName("MAE_VETFER");

                entity.Property(e => e.MaeVetgua).HasColumnName("MAE_VETGUA");

                entity.Property(e => e.MaeVetitu).HasColumnName("MAE_VETITU");

                entity.Property(e => e.MaeVetsao).HasColumnName("MAE_VETSAO");

                entity.Property(e => e.MaeVetsap).HasColumnName("MAE_VETSAP");

                entity.Property(e => e.OemMae)
                    .HasColumnName("OEM_MAE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RgMae)
                    .HasColumnName("RG_MAE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuAtu).HasColumnName("USU_ATU");

                entity.Property(e => e.UsuCod)
                    .HasColumnName("USU_COD")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<BcOutro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_OUTRO");

                entity.Property(e => e.CpfOut)
                    .HasColumnName("CPF_OUT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DatAlt)
                    .HasColumnName("DAT_ALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatCad)
                    .HasColumnName("DAT_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrauParentesco)
                    .HasColumnName("GRAU_PARENTESCO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OemOut)
                    .HasColumnName("OEM_OUT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OutCod).HasColumnName("OUT_COD");

                entity.Property(e => e.OutEmp)
                    .HasColumnName("OUT_EMP")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OutFal).HasColumnName("OUT_FAL");

                entity.Property(e => e.OutFun)
                    .HasColumnName("OUT_FUN")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OutMail)
                    .HasColumnName("OUT_MAIL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OutMailAti).HasColumnName("OUT_MAIL_ATI");

                entity.Property(e => e.OutMer)
                    .HasColumnName("OUT_MER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OutNom)
                    .HasColumnName("OUT_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OutObs)
                    .HasColumnName("OUT_OBS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OutPar)
                    .HasColumnName("OUT_PAR")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OutTel1)
                    .HasColumnName("OUT_TEL1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutTel2)
                    .HasColumnName("OUT_TEL2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutTel3)
                    .HasColumnName("OUT_TEL3")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutTel4)
                    .HasColumnName("OUT_TEL4")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutVet)
                    .HasColumnName("OUT_VET")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OutVetagu).HasColumnName("OUT_VETAGU");

                entity.Property(e => e.OutVetfaz).HasColumnName("OUT_VETFAZ");

                entity.Property(e => e.OutVetfer).HasColumnName("OUT_VETFER");

                entity.Property(e => e.OutVetgua).HasColumnName("OUT_VETGUA");

                entity.Property(e => e.OutVetitu).HasColumnName("OUT_VETITU");

                entity.Property(e => e.OutVetsao).HasColumnName("OUT_VETSAO");

                entity.Property(e => e.OutVetsap).HasColumnName("OUT_VETSAP");

                entity.Property(e => e.RgOut)
                    .HasColumnName("RG_OUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuAlt).HasColumnName("USU_ALT");

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");
            });

            modelBuilder.Entity<BcPacote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_PACOTE");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ATIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodSer)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PacAlt)
                    .HasColumnName("PAC_ALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PacCad)
                    .HasColumnName("PAC_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.PacCod).HasColumnName("PAC_COD");

                entity.Property(e => e.PacDes)
                    .HasColumnName("PAC_DES")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PacEma)
                    .HasColumnName("PAC_EMA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PacFil).HasColumnName("PAC_FIL");

                entity.Property(e => e.PacNdi)
                    .HasColumnName("PAC_NDI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcPai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_PAI");

                entity.Property(e => e.CpfPai)
                    .HasColumnName("CPF_PAI")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.OemPai)
                    .HasColumnName("OEM_PAI")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PaiCad)
                    .HasColumnName("PAI_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaiCod)
                    .HasColumnName("PAI_COD")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.PaiEmp)
                    .HasColumnName("PAI_EMP")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PaiFal).HasColumnName("PAI_FAL");

                entity.Property(e => e.PaiFun)
                    .HasColumnName("PAI_FUN")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PaiMail)
                    .HasColumnName("PAI_MAIL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PaiMailAti).HasColumnName("PAI_MAIL_ATI");

                entity.Property(e => e.PaiMer)
                    .HasColumnName("PAI_MER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaiNom)
                    .HasColumnName("PAI_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PaiObs)
                    .HasColumnName("PAI_OBS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaiTel1)
                    .HasColumnName("PAI_TEL1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaiTel2)
                    .HasColumnName("PAI_TEL2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaiTel3)
                    .HasColumnName("PAI_TEL3")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaiTel4)
                    .HasColumnName("PAI_TEL4")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaiVet)
                    .HasColumnName("PAI_VET")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaiVetagu).HasColumnName("PAI_VETAGU");

                entity.Property(e => e.PaiVetfaz).HasColumnName("PAI_VETFAZ");

                entity.Property(e => e.PaiVetfer).HasColumnName("PAI_VETFER");

                entity.Property(e => e.PaiVetgua).HasColumnName("PAI_VETGUA");

                entity.Property(e => e.PaiVetitu).HasColumnName("PAI_VETITU");

                entity.Property(e => e.PaiVetsao).HasColumnName("PAI_VETSAO");

                entity.Property(e => e.PaiVetsap).HasColumnName("PAI_VETSAP");

                entity.Property(e => e.PiaAtu)
                    .HasColumnName("PIA_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.RgPai)
                    .HasColumnName("RG_PAI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuAtu).HasColumnName("USU_ATU");

                entity.Property(e => e.UsuCod)
                    .HasColumnName("USU_COD")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<BcReservas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_RESERVAS");

                entity.Property(e => e.AcaCod).HasColumnName("ACA_COD");

                entity.Property(e => e.AcaDep).HasColumnName("ACA_DEP");

                entity.Property(e => e.AcarCod).HasColumnName("ACAR_COD");

                entity.Property(e => e.BcatCod).HasColumnName("BCAT_COD");

                entity.Property(e => e.CbsCod).HasColumnName("CBS_COD");

                entity.Property(e => e.CbsObs)
                    .HasColumnName("CBS_OBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntCod)
                    .HasColumnName("ENT_COD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PacCod).HasColumnName("PAC_COD");

                entity.Property(e => e.ResAtu)
                    .HasColumnName("RES_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResBai)
                    .HasColumnName("RES_BAI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResCad)
                    .HasColumnName("RES_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResCep)
                    .HasColumnName("RES_CEP")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ResCid)
                    .HasColumnName("RES_CID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResCod).HasColumnName("RES_COD");

                entity.Property(e => e.ResDatEnt)
                    .HasColumnName("RES_DAT_ENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResDvl)
                    .HasColumnName("RES_DVL")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResEnd)
                    .HasColumnName("RES_END")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ResEscCod).HasColumnName("RES_ESC_COD");

                entity.Property(e => e.ResHorEnt)
                    .HasColumnName("RES_HOR_ENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResMaiRes)
                    .HasColumnName("RES_MAI_RES")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ResMer)
                    .HasColumnName("RES_MER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResMerRes)
                    .HasColumnName("RES_MER_RES")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResNas)
                    .HasColumnName("RES_NAS")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResNom)
                    .HasColumnName("RES_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ResNomRes)
                    .HasColumnName("RES_NOM_RES")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ResObs)
                    .HasColumnName("RES_OBS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResPai)
                    .HasColumnName("RES_PAI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResParRes)
                    .HasColumnName("RES_PAR_RES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResSex)
                    .HasColumnName("RES_SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResSta)
                    .HasColumnName("RES_STA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResTelRes1)
                    .HasColumnName("RES_TEL_RES")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResTelcel)
                    .HasColumnName("RES_TELCEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResTelfax)
                    .HasColumnName("RES_TELFAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResTelout)
                    .HasColumnName("RES_TELOUT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResTelres)
                    .HasColumnName("RES_TELRES")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResUfs)
                    .HasColumnName("RES_UFS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ResVal)
                    .HasColumnName("RES_VAL")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ResZip)
                    .HasColumnName("RES_ZIP")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod)
                    .HasColumnName("USU_COD")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<BcTemporada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_TEMPORADA");

                entity.Property(e => e.DesTur)
                    .HasColumnName("DES_TUR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCalouro).HasColumnName("ID_CALOURO");

                entity.Property(e => e.TemAtu)
                    .HasColumnName("TEM_ATU")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemBar)
                    .HasColumnName("TEM_BAR")
                    .HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TemCad)
                    .HasColumnName("TEM_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemCod).HasColumnName("TEM_COD");

                entity.Property(e => e.TemDch)
                    .HasColumnName("TEM_DCH")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemDsa)
                    .HasColumnName("TEM_DSA")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemHch)
                    .HasColumnName("TEM_HCH")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemHsa)
                    .HasColumnName("TEM_HSA")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemIma).HasColumnName("TEM_IMA");

                entity.Property(e => e.TemImi).HasColumnName("TEM_IMI");

                entity.Property(e => e.TemLch)
                    .HasColumnName("TEM_LCH")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TemLsa)
                    .HasColumnName("TEM_LSA")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TemNom)
                    .IsRequired()
                    .HasColumnName("TEM_NOM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TemSta).HasColumnName("TEM_STA");

                entity.Property(e => e.TemVfe).HasColumnName("TEM_VFE");

                entity.Property(e => e.TemVfeAca).HasColumnName("TEM_VFE_ACA");

                entity.Property(e => e.TemVfeAcaOcu).HasColumnName("TEM_VFE_ACA_OCU");

                entity.Property(e => e.TemVfeAss).HasColumnName("TEM_VFE_ASS");

                entity.Property(e => e.TemVfeAssOcu).HasColumnName("TEM_VFE_ASS_OCU");

                entity.Property(e => e.TemVfeMon).HasColumnName("TEM_VFE_MON");

                entity.Property(e => e.TemVfeMonOcu).HasColumnName("TEM_VFE_MON_OCU");

                entity.Property(e => e.TemVma).HasColumnName("TEM_VMA");

                entity.Property(e => e.TemVmaAca).HasColumnName("TEM_VMA_ACA");

                entity.Property(e => e.TemVmaAcaOcu).HasColumnName("TEM_VMA_ACA_OCU");

                entity.Property(e => e.TemVmaAss).HasColumnName("TEM_VMA_ASS");

                entity.Property(e => e.TemVmaAssOcu).HasColumnName("TEM_VMA_ASS_OCU");

                entity.Property(e => e.TemVmaMon).HasColumnName("TEM_VMA_MON");

                entity.Property(e => e.TemVmaMonOcu).HasColumnName("TEM_VMA_MON_OCU");

                entity.Property(e => e.TurAti)
                    .HasColumnName("TUR_ATI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UniCod).HasColumnName("UNI_COD");

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.UsuCod).HasColumnName("USU_COD");
            });

            modelBuilder.Entity<BcTemporadaBPacote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_TEMPORADA_B_PACOTE");

                entity.Property(e => e.PacCod).HasColumnName("PAC_COD");

                entity.Property(e => e.TemCod).HasColumnName("TEM_COD");

                entity.Property(e => e.TemNom)
                    .HasColumnName("TEM_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BcVagasChale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BC_VAGAS_CHALE");

                entity.Property(e => e.DatAlt)
                    .HasColumnName("DAT_ALT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatCad)
                    .HasColumnName("DAT_CAD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Indice).HasColumnName("INDICE");

                entity.Property(e => e.TemCod).HasColumnName("TEM_COD");

                entity.Property(e => e.UsuAlt).HasColumnName("USU_ALT");

                entity.Property(e => e.UsuCad).HasColumnName("USU_CAD");

                entity.Property(e => e.VchAca)
                    .HasColumnName("VCH_ACA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VchAss)
                    .HasColumnName("VCH_ASS")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VchCod)
                    .HasColumnName("VCH_COD")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.VchMon)
                    .HasColumnName("VCH_MON")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VchNom)
                    .HasColumnName("VCH_NOM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.VchSex)
                    .HasColumnName("VCH_SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VchVag)
                    .HasColumnName("VCH_VAG")
                    .HasColumnType("decimal(20, 0)");
            });

            modelBuilder.Entity<E002tpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E002TPT");

                entity.Property(e => e.AbrTpt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AplTpt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodImp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTpt)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesTpt)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Excvar)
                    .IsRequired()
                    .HasColumnName("excvar")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GerDct)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Gerrgw)
                    .HasColumnName("gerrgw")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PagSom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecSom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sittpt)
                    .HasColumnName("sittpt")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SomIrf)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Titfis).HasColumnName("titfis");

                entity.Property(e => e.Titpar)
                    .HasColumnName("titpar")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VenCac)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E006pai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E006PAI");

                entity.Property(e => e.CodMoe)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodPai)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MerSul)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NomPai)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Paianp).HasColumnName("paianp");

                entity.Property(e => e.Paidir).HasColumnName("paidir");

                entity.Property(e => e.Paisis).HasColumnName("paisis");

                entity.Property(e => e.Paispe)
                    .HasColumnName("paispe")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VisEnt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E007ufs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E007UFS");

                entity.Property(e => e.AbrUfs)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodPai)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NomUfs)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SigUfs)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E008cep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E008CEP");

                entity.Property(e => e.BaiCid)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Coddip).HasColumnName("coddip");

                entity.Property(e => e.Codsia).HasColumnName("codsia");

                entity.Property(e => e.Datalt)
                    .HasColumnName("datalt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datger)
                    .HasColumnName("datger")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndCid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Horalt).HasColumnName("horalt");

                entity.Property(e => e.Horger).HasColumnName("horger");

                entity.Property(e => e.ImpIss)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NomCid)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PerIss).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Perisc)
                    .HasColumnName("perisc")
                    .HasColumnType("numeric(6, 4)");

                entity.Property(e => e.SigUfs)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Usualt).HasColumnName("usualt");

                entity.Property(e => e.Usuger).HasColumnName("usuger");
            });

            modelBuilder.Entity<E017rve>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E017RVE");

                entity.Property(e => e.AbrRve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodRve)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Datalt)
                    .HasColumnName("datalt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datger)
                    .HasColumnName("datger")
                    .HasColumnType("datetime");

                entity.Property(e => e.Horalt).HasColumnName("horalt");

                entity.Property(e => e.Horger).HasColumnName("horger");

                entity.Property(e => e.NomRve)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RecVmt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.SupRve)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usualt).HasColumnName("usualt");

                entity.Property(e => e.Usuger).HasColumnName("usuger");

                entity.Property(e => e.VenVmn).HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<E025fer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E025FER");

                entity.Property(e => e.DesFer)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FerBan)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E028cpg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E028CPG");

                entity.Property(e => e.AbrCpg)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AcrFin).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.AplCpg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodCpg)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodTpr)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Comtit)
                    .HasColumnName("comtit")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CprDsc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.DarPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DatPal).HasColumnType("datetime");

                entity.Property(e => e.Datatu)
                    .HasColumnName("datatu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datger)
                    .HasColumnName("datger")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesCpg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaEsp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiaMes)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.DiaSem)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Dscant)
                    .HasColumnName("dscant")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Dscpon)
                    .HasColumnName("dscpon")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.EmbPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EncPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FrePar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FveCpg)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FveDec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Horatu).HasColumnName("horatu");

                entity.Property(e => e.Horger).HasColumnName("horger");

                entity.Property(e => e.IcmPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ideuni).HasColumnName("ideuni");

                entity.Property(e => e.Intwmw)
                    .HasColumnName("intwmw")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IpiPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Irfpar)
                    .IsRequired()
                    .HasColumnName("irfpar")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IssPar)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Jurven)
                    .HasColumnName("jurven")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Meses1).HasColumnName("meses1");

                entity.Property(e => e.Meses2).HasColumnName("meses2");

                entity.Property(e => e.Meses3).HasColumnName("meses3");

                entity.Property(e => e.OutPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PerCom).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDsc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Perenc)
                    .HasColumnName("perenc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PgtAnt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RedCom).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Retiss)
                    .HasColumnName("retiss")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SegPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SitCpg)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipcju).HasColumnName("tipcju");

                entity.Property(e => e.Txajur)
                    .HasColumnName("txajur")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Usuatu).HasColumnName("usuatu");

                entity.Property(e => e.Usuger).HasColumnName("usuger");

                entity.Property(e => e.VenDsc).HasColumnType("numeric(5, 2)");
            });

            modelBuilder.Entity<E080ser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E080SER");

                entity.Property(e => e.Apoesp).HasColumnName("apoesp");

                entity.Property(e => e.Bascre).HasColumnName("bascre");

                entity.Property(e => e.Catmnt)
                    .HasColumnName("catmnt")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Clacni).HasColumnName("clacni");

                entity.Property(e => e.CodCcu)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodClf)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodFam)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodFie)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CodFif)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodFim)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodPin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodSer)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CodStr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTic)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTrd)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTri)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodTst)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codagg)
                    .HasColumnName("codagg")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Codagt)
                    .HasColumnName("codagt")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Codatv)
                    .HasColumnName("codatv")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Codbic)
                    .HasColumnName("codbic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codces)
                    .HasColumnName("codces")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Coddfs).HasColumnName("coddfs");

                entity.Property(e => e.Codexp)
                    .HasColumnName("codexp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codfil).HasColumnName("codfil");

                entity.Property(e => e.Codnbs)
                    .HasColumnName("codnbs")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Codote).HasColumnName("codote");

                entity.Property(e => e.Codprc)
                    .HasColumnName("codprc")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codpri)
                    .HasColumnName("codpri")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codseg).HasColumnName("codseg");

                entity.Property(e => e.Codtge).HasColumnName("codtge");

                entity.Property(e => e.Codtpr)
                    .HasColumnName("codtpr")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codtra).HasColumnName("codtra");

                entity.Property(e => e.Conagu).HasColumnName("conagu");

                entity.Property(e => e.Conene).HasColumnName("conene");

                entity.Property(e => e.CplSer)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cstcoc)
                    .HasColumnName("cstcoc")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cstcof)
                    .HasColumnName("cstcof")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cstipc)
                    .HasColumnName("cstipc")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cstipi)
                    .HasColumnName("cstipi")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cstiss)
                    .HasColumnName("cstiss")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cstpic)
                    .HasColumnName("cstpic")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cstpis)
                    .HasColumnName("cstpis")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Datalt)
                    .HasColumnName("datalt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datger)
                    .HasColumnName("datger")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datini)
                    .HasColumnName("datini")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesNfv)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DesSer)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Desfis)
                    .HasColumnName("desfis")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fincdp).HasColumnName("fincdp");

                entity.Property(e => e.Fincrp).HasColumnName("fincrp");

                entity.Property(e => e.Fortri).HasColumnName("fortri");

                entity.Property(e => e.Gruten).HasColumnName("gruten");

                entity.Property(e => e.Horalt).HasColumnName("horalt");

                entity.Property(e => e.Horger).HasColumnName("horger");

                entity.Property(e => e.Idamax).HasColumnName("idamax");

                entity.Property(e => e.Idamin).HasColumnName("idamin");

                entity.Property(e => e.Ideren).HasColumnName("ideren");

                entity.Property(e => e.Imoser)
                    .HasColumnName("imoser")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndOct)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indm21)
                    .HasColumnName("indm21")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indspr)
                    .HasColumnName("indspr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itefis)
                    .HasColumnName("itefis")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Modpre).HasColumnName("modpre");

                entity.Property(e => e.Natati).HasColumnName("natati");

                entity.Property(e => e.Natcof).HasColumnName("natcof");

                entity.Property(e => e.Natpis).HasColumnName("natpis");

                entity.Property(e => e.Natren)
                    .HasColumnName("natren")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.NotFor).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Numcbo).HasColumnName("numcbo");

                entity.Property(e => e.ObsSer)
                    .HasMaxLength(999)
                    .IsUnicode(false);

                entity.Property(e => e.Orimer)
                    .HasColumnName("orimer")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Parcom)
                    .HasColumnName("parcom")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PerCof).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerCom).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerCsl).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerDsc).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerIns).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerIpi).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.PerIrf).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerIss).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PerOur).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerPis).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Perape)
                    .HasColumnName("perape")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Percim)
                    .HasColumnName("percim")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Percit)
                    .HasColumnName("percit")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Perdif)
                    .HasColumnName("perdif")
                    .HasColumnType("numeric(7, 4)");

                entity.Property(e => e.Perifp)
                    .HasColumnName("perifp")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Perine)
                    .HasColumnName("perine")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Perpim)
                    .HasColumnName("perpim")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Persen)
                    .HasColumnName("persen")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PreCpr).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.PreVen).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.Prztge).HasColumnName("prztge");

                entity.Property(e => e.QtdPad).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.Qtdmax)
                    .HasColumnName("qtdmax")
                    .HasColumnType("numeric(12, 5)");

                entity.Property(e => e.Qtdmin)
                    .HasColumnName("qtdmin")
                    .HasColumnType("numeric(12, 5)");

                entity.Property(e => e.Qtdmlt)
                    .HasColumnName("qtdmlt")
                    .HasColumnType("numeric(12, 5)");

                entity.Property(e => e.RecCof)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecIcm)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecIpi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecPis)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regtri)
                    .HasColumnName("regtri")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Seqhas).HasColumnName("seqhas");

                entity.Property(e => e.Serimp)
                    .HasColumnName("serimp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SitSer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Somico)
                    .HasColumnName("somico")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Somips)
                    .HasColumnName("somips")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TemIcm)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tiplig).HasColumnName("tiplig");

                entity.Property(e => e.Tipren).HasColumnName("tipren");

                entity.Property(e => e.Tipser).HasColumnName("tipser");

                entity.Property(e => e.Tiptge)
                    .HasColumnName("tiptge")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tiputi).HasColumnName("tiputi");

                entity.Property(e => e.Tprcof)
                    .HasColumnName("tprcof")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Tpripi)
                    .HasColumnName("tpripi")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Tprpis)
                    .HasColumnName("tprpis")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TriCof)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TriPis)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Trinfs)
                    .HasColumnName("trinfs")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UniMed)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usualt).HasColumnName("usualt");

                entity.Property(e => e.Usuger).HasColumnName("usuger");

                entity.Property(e => e.Varser)
                    .HasColumnName("varser")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Vlrfin)
                    .HasColumnName("vlrfin")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrini)
                    .HasColumnName("vlrini")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrser)
                    .HasColumnName("vlrser")
                    .HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<E085cli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E085CLI");

                entity.Property(e => e.ApeCli)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaiCli)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BaiCob)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BaiEnt)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BloCre)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CalFun)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Calsen)
                    .HasColumnName("calsen")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CidCli)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CidCob)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CidEnt)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Cidspc)
                    .HasColumnName("cidspc")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Clatri).HasColumnName("clatri");

                entity.Property(e => e.CliCon)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CliFor)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CliPrx)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.CodAma)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodGal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodPai)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodRam)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodRoe)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodSab)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodSro)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodSuf)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codms2).HasColumnName("codms2");

                entity.Property(e => e.Codms3).HasColumnName("codms3");

                entity.Property(e => e.Codms4).HasColumnName("codms4");

                entity.Property(e => e.Codmsg).HasColumnName("codmsg");

                entity.Property(e => e.Codrtr).HasColumnName("codrtr");

                entity.Property(e => e.Codtaf)
                    .HasColumnName("codtaf")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Confin)
                    .HasColumnName("confin")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CplCob)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CplEnd)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CplEnt)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DatAtu).HasColumnType("datetime");

                entity.Property(e => e.DatCad).HasColumnType("datetime");

                entity.Property(e => e.DatFim).HasColumnType("datetime");

                entity.Property(e => e.DatIcv).HasColumnType("datetime");

                entity.Property(e => e.DatMot).HasColumnType("datetime");

                entity.Property(e => e.DatPal).HasColumnType("datetime");

                entity.Property(e => e.DatPdv).HasColumnType("datetime");

                entity.Property(e => e.DatSuf).HasColumnType("datetime");

                entity.Property(e => e.DatVct).HasColumnType("datetime");

                entity.Property(e => e.Datspc)
                    .HasColumnName("datspc")
                    .HasColumnType("datetime");

                entity.Property(e => e.EenCli)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.EenCob)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.EenEnt)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Emaent)
                    .HasColumnName("emaent")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Emanfe)
                    .HasColumnName("emanfe")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndCli)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndCob)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndEnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntCor)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Entpaa)
                    .HasColumnName("entpaa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstCob)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EstEnt)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Faxcli)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FonCl2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FonCl3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FonCl4)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FonCl5)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FonCli)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fonent)
                    .HasColumnName("fonent")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdeCli)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Indcoo)
                    .HasColumnName("indcoo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indnif).HasColumnName("indnif");

                entity.Property(e => e.Infspc).HasColumnName("infspc");

                entity.Property(e => e.InsEnt)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InsEst)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InsMun)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Insanp).HasColumnName("insanp");

                entity.Property(e => e.IntNet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LimRet)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MarCli)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Msgpdv)
                    .HasColumnName("msgpdv")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Natcof).HasColumnName("natcof");

                entity.Property(e => e.Natcsl).HasColumnName("natcsl");

                entity.Property(e => e.Natirp).HasColumnName("natirp");

                entity.Property(e => e.Natpis).HasColumnName("natpis");

                entity.Property(e => e.Natret).HasColumnName("natret");

                entity.Property(e => e.Nencli)
                    .HasColumnName("nencli")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nencob)
                    .HasColumnName("nencob")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nenent)
                    .HasColumnName("nenent")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NomCli)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numanx).HasColumnName("numanx");

                entity.Property(e => e.Numidf)
                    .HasColumnName("numidf")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ObsMot)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Perain)
                    .HasColumnName("perain")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Regest).HasColumnName("regest");

                entity.Property(e => e.RetCof)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RetCsl)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RetIrf)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RetOur)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RetPis)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RetPro)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rotanx).HasColumnName("rotanx");

                entity.Property(e => e.SenCli)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Seqhas).HasColumnName("seqhas");

                entity.Property(e => e.SigUfs)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SitCli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TemCob)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TemEnt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipCli)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipMer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipace).HasColumnName("tipace");

                entity.Property(e => e.Tipemp).HasColumnName("tipemp");

                entity.Property(e => e.Tipvin).HasColumnName("tipvin");

                entity.Property(e => e.TriCof)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TriIcm)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TriIpi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TriPis)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsuBloqUsu)
                    .HasColumnName("usu_bloq_usu")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsuBlqcli)
                    .HasColumnName("usu_blqcli")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsuDepide)
                    .HasColumnName("usu_depide")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuMotBloq)
                    .HasColumnName("usu_mot_bloq")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ususpc).HasColumnName("ususpc");

                entity.Property(e => e.Vlrlat)
                    .HasColumnName("vlrlat")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vlrlon)
                    .HasColumnName("vlrlon")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCod)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Zipent)
                    .HasColumnName("zipent")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E085hcl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E085HCL");

                entity.Property(e => e.AcePar)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcrDia).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.AntDsc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ApmDen)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Avaati)
                    .HasColumnName("avaati")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Avamot).HasColumnName("avamot");

                entity.Property(e => e.Avaobs)
                    .HasColumnName("avaobs")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Avavlr)
                    .HasColumnName("avavlr")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Avavls)
                    .HasColumnName("avavls")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Avavlu)
                    .HasColumnName("avavlu")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Avdalt)
                    .HasColumnName("avdalt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Avdger)
                    .HasColumnName("avdger")
                    .HasColumnType("datetime");

                entity.Property(e => e.Avhalt).HasColumnName("avhalt");

                entity.Property(e => e.Avhger).HasColumnName("avhger");

                entity.Property(e => e.Avualt).HasColumnName("avualt");

                entity.Property(e => e.Avuger).HasColumnName("avuger");

                entity.Property(e => e.CcbCli)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CifFob)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodAge)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodBan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodCpg)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodCrp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodCrt)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodFcr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodFrj)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodIn1)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodIn2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodMar)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodRve)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTab)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodTpr)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codcca)
                    .HasColumnName("codcca")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codfin).HasColumnName("codfin");

                entity.Property(e => e.Codpdv).HasColumnName("codpdv");

                entity.Property(e => e.Codstr)
                    .HasColumnName("codstr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codtic)
                    .HasColumnName("codtic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codtrd)
                    .HasColumnName("codtrd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Confin)
                    .HasColumnName("confin")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CriEdv)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ctaaad).HasColumnName("ctaaad");

                entity.Property(e => e.Ctaaux).HasColumnName("ctaaux");

                entity.Property(e => e.DatAtr).HasColumnType("datetime");

                entity.Property(e => e.DatLim).HasColumnType("datetime");

                entity.Property(e => e.DatMac).HasColumnType("datetime");

                entity.Property(e => e.DatMfa).HasColumnType("datetime");

                entity.Property(e => e.DatPal).HasColumnType("datetime");

                entity.Property(e => e.DatPmr).HasColumnType("datetime");

                entity.Property(e => e.DatUfa).HasColumnType("datetime");

                entity.Property(e => e.DatUpc).HasColumnType("datetime");

                entity.Property(e => e.DatUpe).HasColumnType("datetime");

                entity.Property(e => e.DatUpg).HasColumnType("datetime");

                entity.Property(e => e.Datalt)
                    .HasColumnName("datalt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datger)
                    .HasColumnName("datger")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiaEsp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dscant)
                    .HasColumnName("dscant")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Dscpon)
                    .HasColumnName("dscpon")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Dscprd)
                    .HasColumnName("dscprd")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EcpCnp)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EpcPed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExiAge)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExiLcp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FveCpg)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FveFpg)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FveTns)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GerTcc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Horalt).HasColumnName("horalt");

                entity.Property(e => e.Horger).HasColumnName("horger");

                entity.Property(e => e.IndAgr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indorf)
                    .HasColumnName("indorf")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indpre)
                    .HasColumnName("indpre")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JunPed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LimApr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Motdes).HasColumnName("motdes");

                entity.Property(e => e.PerAqa).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerCom).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs1).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs2).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs3).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs4).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDsc).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerEmb).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerEnc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerFre).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerIss).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PerOf1).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerOf2).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerOut).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerSeg).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Perccr)
                    .HasColumnName("perccr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Perdif)
                    .HasColumnName("perdif")
                    .HasColumnType("numeric(7, 4)");

                entity.Property(e => e.Perds5)
                    .HasColumnName("perds5")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Perisr)
                    .HasColumnName("perisr")
                    .HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PorNa1)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PorNa2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PorSi1)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PorSi2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Prddsc)
                    .HasColumnName("prddsc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Qdiprt).HasColumnName("qdiprt");

                entity.Property(e => e.RecJmm).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.RecMul).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.RecTjr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SalCre).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.SalDup).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.SalOut).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Seqcob).HasColumnName("seqcob");

                entity.Property(e => e.Seqent).HasColumnName("seqent");

                entity.Property(e => e.Tiptcc).HasColumnName("tiptcc");

                entity.Property(e => e.UltSnf)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usualt).HasColumnName("usualt");

                entity.Property(e => e.Usuger).HasColumnName("usuger");

                entity.Property(e => e.VlrAtr).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLim).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrMac).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrMfa).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrPfa).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrPrt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrUfa).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrUpc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrUpe).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrUpg).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlracr)
                    .HasColumnName("vlracr")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Volsep)
                    .HasColumnName("volsep")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zerdif)
                    .HasColumnName("zerdif")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E090hrp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E090HRP");

                entity.Property(e => e.Avaati)
                    .HasColumnName("avaati")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Avamot).HasColumnName("avamot");

                entity.Property(e => e.Avaobs)
                    .HasColumnName("avaobs")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Avavlr)
                    .HasColumnName("avavlr")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Avavls)
                    .HasColumnName("avavls")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Avavlu)
                    .HasColumnName("avavlu")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Avdalt)
                    .HasColumnName("avdalt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Avdger)
                    .HasColumnName("avdger")
                    .HasColumnType("datetime");

                entity.Property(e => e.Avhalt).HasColumnName("avhalt");

                entity.Property(e => e.Avhger).HasColumnName("avhger");

                entity.Property(e => e.Avualt).HasColumnName("avualt");

                entity.Property(e => e.Avuger).HasColumnName("avuger");

                entity.Property(e => e.CatRep)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CcbRep)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Cffcom)
                    .HasColumnName("cffcom")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodAge)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodBan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodRve)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CofCom)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ComFat).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ComPri)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ComRec).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ComSup).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Comass)
                    .HasColumnName("comass")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ConEst)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CslCom)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DarCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmbCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EncCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IcmCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsCom)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IpiCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IrfCom)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IssCom)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OurCom)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OutCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PerCom).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerCos).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerCqt).HasColumnType("numeric(7, 4)");

                entity.Property(e => e.PerCvl).HasColumnType("numeric(7, 4)");

                entity.Property(e => e.PerIns).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerIrf).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerIss).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Pifcom)
                    .HasColumnName("pifcom")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PisCom)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecAdc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecAoc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecPcc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecPce)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecPcj)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecPcm)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecPco)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecVmt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Repaud)
                    .HasColumnName("repaud")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SegCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubCom)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VenVmp).HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<E090rep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E090REP");

                entity.Property(e => e.ApeRep)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaiRep)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CalIns)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CalIrf)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CalIss)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CidRep)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CplEnd)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DatAtu).HasColumnType("datetime");

                entity.Property(e => e.DatCad).HasColumnType("datetime");

                entity.Property(e => e.DatMot).HasColumnType("datetime");

                entity.Property(e => e.DatNas).HasColumnType("datetime");

                entity.Property(e => e.DatPal).HasColumnType("datetime");

                entity.Property(e => e.DatRge).HasColumnType("datetime");

                entity.Property(e => e.EenRep)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.EndRep)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaxRep)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Firind)
                    .HasColumnName("firind")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FonRe2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FonRe3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FonRep)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GerTit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Horatu).HasColumnName("horatu");

                entity.Property(e => e.Horcad).HasColumnName("horcad");

                entity.Property(e => e.InsEst)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InsMun)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IntNet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Intwmw)
                    .HasColumnName("intwmw")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nenrep)
                    .HasColumnName("nenrep")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NomRep)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumRge)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Numidf)
                    .HasColumnName("numidf")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ObsMot)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrgRge)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SenRep)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SigUfs)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SitRep)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipRep)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Usuatu).HasColumnName("usuatu");

                entity.Property(e => e.Usucad).HasColumnName("usucad");

                entity.Property(e => e.ZipCod)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E120isp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E120ISP");

                entity.Property(e => e.Alicff)
                    .HasColumnName("alicff")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.Alifcp)
                    .HasColumnName("alifcp")
                    .HasColumnType("numeric(7, 4)");

                entity.Property(e => e.Aliipi)
                    .HasColumnName("aliipi")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.Alipif)
                    .HasColumnName("alipif")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.Astfcp)
                    .HasColumnName("astfcp")
                    .HasColumnType("numeric(7, 4)");

                entity.Property(e => e.Basfcp)
                    .HasColumnName("basfcp")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Basidf)
                    .HasColumnName("basidf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Bstfcp)
                    .HasColumnName("bstfcp")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.CodCcu)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodFam)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodMcp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodMoe)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodSer)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CodTic)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTpr)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodTrd)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTri)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodTst)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codrep).HasColumnName("codrep");

                entity.Property(e => e.Codstr)
                    .HasColumnName("codstr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CotMfp).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CotMoe).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CplIsp)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcvs)
                    .HasColumnName("cptcvs")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ctrcvs).HasColumnName("ctrcvs");

                entity.Property(e => e.DatCpt).HasColumnType("datetime");

                entity.Property(e => e.DatEnt).HasColumnType("datetime");

                entity.Property(e => e.DatGer).HasColumnType("datetime");

                entity.Property(e => e.DatMfp).HasColumnType("datetime");

                entity.Property(e => e.DatMoe).HasColumnType("datetime");

                entity.Property(e => e.Datalt)
                    .HasColumnName("datalt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datini)
                    .HasColumnName("datini")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dscvar)
                    .HasColumnName("dscvar")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Empfre).HasColumnName("empfre");

                entity.Property(e => e.Empocp).HasColumnName("empocp");

                entity.Property(e => e.FecMoe)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Filctr).HasColumnName("filctr");

                entity.Property(e => e.Filfre).HasColumnName("filfre");

                entity.Property(e => e.Filnco).HasColumnName("filnco");

                entity.Property(e => e.Filnfv).HasColumnName("filnfv");

                entity.Property(e => e.Filref).HasColumnName("filref");

                entity.Property(e => e.Gernec).HasColumnName("gernec");

                entity.Property(e => e.Horalt).HasColumnName("horalt");

                entity.Property(e => e.Icmade)
                    .HasColumnName("icmade")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Icmafc)
                    .HasColumnName("icmafc")
                    .HasColumnType("numeric(7, 4)");

                entity.Property(e => e.Icmaor)
                    .HasColumnName("icmaor")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Icmbde)
                    .HasColumnName("icmbde")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Icmbfc)
                    .HasColumnName("icmbfc")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Icmvde)
                    .HasColumnName("icmvde")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Icmvfc)
                    .HasColumnName("icmvfc")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Icmvor)
                    .HasColumnName("icmvor")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Itecan)
                    .HasColumnName("itecan")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Locent).HasColumnName("locent");

                entity.Property(e => e.Motdes).HasColumnName("motdes");

                entity.Property(e => e.Numint)
                    .HasColumnName("numint")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Numnco).HasColumnName("numnco");

                entity.Property(e => e.Numnfv).HasColumnName("numnfv");

                entity.Property(e => e.ObsIsp)
                    .HasMaxLength(999)
                    .IsUnicode(false);

                entity.Property(e => e.ObsMot)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pdsvar)
                    .HasColumnName("pdsvar")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PedCli)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pedref).HasColumnName("pedref");

                entity.Property(e => e.PerCom).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerCrt).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerCsl).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerDs1).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs2).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs3).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs4).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDsc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerIcm).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerIns).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerIpi).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.PerIrf).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerIss).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PerOur).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PerPit).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Percff)
                    .HasColumnName("percff")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Perdif)
                    .HasColumnName("perdif")
                    .HasColumnType("numeric(7, 4)");

                entity.Property(e => e.Perds5)
                    .HasColumnName("perds5")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Peridf)
                    .HasColumnName("peridf")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Perjur)
                    .HasColumnName("perjur")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Permgc)
                    .HasColumnName("permgc")
                    .HasColumnType("numeric(14, 5)");

                entity.Property(e => e.Perpif)
                    .HasColumnName("perpif")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.PreUni).HasColumnType("numeric(21, 10)");

                entity.Property(e => e.QtdAbe).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.QtdCan).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.QtdFat).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.QtdPed).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.QtdRea).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.Qtdbcf)
                    .HasColumnName("qtdbcf")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Qtdbip)
                    .HasColumnName("qtdbip")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Qtdbpf)
                    .HasColumnName("qtdbpf")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Senapr)
                    .HasColumnName("senapr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeqPcl)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Seqctr).HasColumnName("seqctr");

                entity.Property(e => e.Seqflc).HasColumnName("seqflc");

                entity.Property(e => e.Seqhas).HasColumnName("seqhas");

                entity.Property(e => e.Seqipv).HasColumnName("seqipv");

                entity.Property(e => e.Seqnco).HasColumnName("seqnco");

                entity.Property(e => e.Seqref).HasColumnName("seqref");

                entity.Property(e => e.Snfnco)
                    .HasColumnName("snfnco")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Snfnfv)
                    .HasColumnName("snfnfv")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tabfre)
                    .HasColumnName("tabfre")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TnsSer)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UniMed)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usualt).HasColumnName("usualt");

                entity.Property(e => e.Varser)
                    .HasColumnName("varser")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VlrBcl).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBco).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBct).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBic).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBin).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBip).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBir).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBis).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBor).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBpt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBru).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBsi).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCom).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCrt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCsl).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDar).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs1).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs2).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs3).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs4).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDsc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDzf).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrEnc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrFin).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIcm).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIcs).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIns).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIpi).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIrf).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIss).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLiq).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLou).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLse).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOur).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOut).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrPit).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrRis).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrbcf)
                    .HasColumnName("vlrbcf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrbpf)
                    .HasColumnName("vlrbpf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrcff)
                    .HasColumnName("vlrcff")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrds5)
                    .HasColumnName("vlrds5")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrfcp)
                    .HasColumnName("vlrfcp")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlricd)
                    .HasColumnName("vlricd")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlridf)
                    .HasColumnName("vlridf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlroud)
                    .HasColumnName("vlroud")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrpfm)
                    .HasColumnName("vlrpfm")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrpif)
                    .HasColumnName("vlrpif")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrtot)
                    .HasColumnName("vlrtot")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vstfcp)
                    .HasColumnName("vstfcp")
                    .HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<E120ped>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E120PED");

                entity.Property(e => e.AcePar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AnaEmb)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Anovei)
                    .HasColumnName("anovei")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Basfcp)
                    .HasColumnName("basfcp")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Basidf)
                    .HasColumnName("basidf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Bstfcp)
                    .HasColumnName("bstfcp")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Cepfim).HasColumnName("cepfim");

                entity.Property(e => e.Cepini).HasColumnName("cepini");

                entity.Property(e => e.CifFob)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodCpg)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodCrt)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodFcr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodLip)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodMar)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodMcp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodMoe)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodPor)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodRoe)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodSro)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodVia)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codapc).HasColumnName("codapc");

                entity.Property(e => e.Codsaf)
                    .HasColumnName("codsaf")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codtab)
                    .HasColumnName("codtab")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cooimp).HasColumnName("cooimp");

                entity.Property(e => e.CotMfp).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CotMoe).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.Croecf).HasColumnName("croecf");

                entity.Property(e => e.Curmil)
                    .HasColumnName("curmil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatAge).HasColumnType("datetime");

                entity.Property(e => e.DatBlo).HasColumnType("datetime");

                entity.Property(e => e.DatEmi).HasColumnType("datetime");

                entity.Property(e => e.DatFcr).HasColumnType("datetime");

                entity.Property(e => e.DatFec).HasColumnType("datetime");

                entity.Property(e => e.DatGer).HasColumnType("datetime");

                entity.Property(e => e.DatMfp).HasColumnType("datetime");

                entity.Property(e => e.DatMoe).HasColumnType("datetime");

                entity.Property(e => e.DatPrv).HasColumnType("datetime");

                entity.Property(e => e.Datapr)
                    .HasColumnName("datapr")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datnsu)
                    .HasColumnName("datnsu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datpre)
                    .HasColumnName("datpre")
                    .HasColumnType("datetime");

                entity.Property(e => e.Desdef)
                    .HasColumnName("desdef")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Desmod)
                    .HasColumnName("desmod")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Eqfimp).HasColumnName("eqfimp");

                entity.Property(e => e.Expwms).HasColumnName("expwms");

                entity.Property(e => e.Fatped).HasColumnName("fatped");

                entity.Property(e => e.FecMoe)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Forent)
                    .HasColumnName("forent")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Horapr).HasColumnName("horapr");

                entity.Property(e => e.Hornsu).HasColumnName("hornsu");

                entity.Property(e => e.Icmbfc)
                    .HasColumnName("icmbfc")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Icmvfc)
                    .HasColumnName("icmvfc")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Ideevt)
                    .HasColumnName("ideevt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndAgr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndSig)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indexp).HasColumnName("indexp");

                entity.Property(e => e.Indpre)
                    .HasColumnName("indpre")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Motwms).HasColumnName("motwms");

                entity.Property(e => e.NumEmp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Numanx).HasColumnName("numanx");

                entity.Property(e => e.Numces).HasColumnName("numces");

                entity.Property(e => e.Numint)
                    .HasColumnName("numint")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Numnsu).HasColumnName("numnsu");

                entity.Property(e => e.Numren)
                    .HasColumnName("numren")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ObsMot)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ObsPed)
                    .HasMaxLength(999)
                    .IsUnicode(false);

                entity.Property(e => e.PedBlo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PedCli)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PerDs1).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs2).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs3).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDs4).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerEmb).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerEnc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerFre).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerOf1).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerOf2).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerOut).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerSeg).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Perds5)
                    .HasColumnName("perds5")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Perecf)
                    .HasColumnName("perecf")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PgtAnt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PlaVei)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtdAbe).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.QtdAen).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.QtdFre).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.QtdOri).HasColumnType("numeric(14, 5)");

                entity.Property(e => e.Qtdbcf)
                    .HasColumnName("qtdbcf")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Qtdbip)
                    .HasColumnName("qtdbip")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Qtdbpf)
                    .HasColumnName("qtdbpf")
                    .HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Qtditp).HasColumnName("qtditp");

                entity.Property(e => e.Qtdits).HasColumnName("qtdits");

                entity.Property(e => e.Qtdpac).HasColumnName("qtdpac");

                entity.Property(e => e.Rotanx).HasColumnName("rotanx");

                entity.Property(e => e.Senapr)
                    .HasColumnName("senapr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Seqhas).HasColumnName("seqhas");

                entity.Property(e => e.Sitmes).HasColumnName("sitmes");

                entity.Property(e => e.Sitpac).HasColumnName("sitpac");

                entity.Property(e => e.SnfNco)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Somfre)
                    .HasColumnName("somfre")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TemPar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Temava)
                    .HasColumnName("temava")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipdav).HasColumnName("tipdav");

                entity.Property(e => e.Tipent).HasColumnName("tipent");

                entity.Property(e => e.TnsPro)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TnsSer)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCodpai)
                    .HasColumnName("usu_codpai")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCodped)
                    .HasColumnName("usu_codped")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usuapr).HasColumnName("usuapr");

                entity.Property(e => e.Usupac).HasColumnName("usupac");

                entity.Property(e => e.Vencal)
                    .HasColumnName("vencal")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VlrAdt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBcl).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBco).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBct).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBic).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBin).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBip).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBir).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBis).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBor).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBpr).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBpt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBsc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBse).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBsi).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBsp).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCom).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCrt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCsl).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDar).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDpr).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs1).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs2).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs3).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDs4).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDse).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDzf).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrEmb).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrEnc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrFin).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrFrd).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrFre).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrFum).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIcm).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIns).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIpi).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIrf).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrIss).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLiq).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLou).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLpr).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLse).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOfe).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOri).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOud).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOur).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOut).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrPit).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrRis).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrSeg).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrSic).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrStc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrStp).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrbcf)
                    .HasColumnName("vlrbcf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrbde)
                    .HasColumnName("vlrbde")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrbpf)
                    .HasColumnName("vlrbpf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrcff)
                    .HasColumnName("vlrcff")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrds5)
                    .HasColumnName("vlrds5")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrecf)
                    .HasColumnName("vlrecf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrfcp)
                    .HasColumnName("vlrfcp")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlricd)
                    .HasColumnName("vlricd")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlride)
                    .HasColumnName("vlride")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlridf)
                    .HasColumnName("vlridf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrior)
                    .HasColumnName("vlrior")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrpif)
                    .HasColumnName("vlrpif")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrtot)
                    .HasColumnName("vlrtot")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vstfcp)
                    .HasColumnName("vstfcp")
                    .HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<E301mcr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E301MCR");

                entity.Property(e => e.Chvlot)
                    .HasColumnName("chvlot")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.CjmAnt).HasColumnType("datetime");

                entity.Property(e => e.CodCcu)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodCrt)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodFrj)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodPor)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodTns)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodTpt)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CotFrj).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CotMcr).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CrtAnt)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Crtcal)
                    .HasColumnName("crtcal")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Cslcal)
                    .HasColumnName("cslcal")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.DatCco).HasColumnType("datetime");

                entity.Property(e => e.DatGer).HasColumnType("datetime");

                entity.Property(e => e.DatLib).HasColumnType("datetime");

                entity.Property(e => e.DatMov).HasColumnType("datetime");

                entity.Property(e => e.DatPgt).HasColumnType("datetime");

                entity.Property(e => e.Filfix).HasColumnName("filfix");

                entity.Property(e => e.Filori).HasColumnName("filori");

                entity.Property(e => e.IndVcr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indexp).HasColumnName("indexp");

                entity.Property(e => e.Intdif)
                    .HasColumnName("intdif")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Intimp)
                    .HasColumnName("intimp")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Irfcal)
                    .HasColumnName("irfcal")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.JrsCal).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.JrsPro)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LctFin)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lotbai).HasColumnName("lotbai");

                entity.Property(e => e.Lotbfi).HasColumnName("lotbfi");

                entity.Property(e => e.NumCco)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NumDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRlc)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumTit)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Numctr).HasColumnName("numctr");

                entity.Property(e => e.Numfix).HasColumnName("numfix");

                entity.Property(e => e.Numpdv).HasColumnName("numpdv");

                entity.Property(e => e.ObsMcr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ourcal)
                    .HasColumnName("ourcal")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.PerJrs).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Pitcal)
                    .HasColumnName("pitcal")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.PorAnt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProJrs)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Reaanb)
                    .HasColumnName("reaanb")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecJoa)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecJod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Recmoa)
                    .HasColumnName("recmoa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Seqlba).HasColumnName("seqlba");

                entity.Property(e => e.Toldsc).HasColumnName("toldsc");

                entity.Property(e => e.Toljrs).HasColumnName("toljrs");

                entity.Property(e => e.Tolmul).HasColumnName("tolmul");

                entity.Property(e => e.TptRlc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UltPgt).HasColumnType("datetime");

                entity.Property(e => e.VctPro).HasColumnType("datetime");

                entity.Property(e => e.VlrAbe).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBcl).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBco).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBcr).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBct).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBor).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBpr).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBpt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCof).HasColumnType("numeric(14, 2)");

                entity.Property(e => e.VlrCom).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCor).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCrt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCsl).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDsc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrEnc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrJrs).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrLiq).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrMov).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrMul).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOac).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOcl).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOct).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOde).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOor).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOpt).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOur).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrPis).HasColumnType("numeric(14, 2)");

                entity.Property(e => e.VlrPit).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrbir)
                    .HasColumnName("vlrbir")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrint)
                    .HasColumnName("vlrint")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrirf)
                    .HasColumnName("vlrirf")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlroir)
                    .HasColumnName("vlroir")
                    .HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<E301mor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E301MOR");

                entity.Property(e => e.CodTpt)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DatMov).HasColumnType("datetime");

                entity.Property(e => e.NumTit)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ObsTit)
                    .IsRequired()
                    .HasMaxLength(4999)
                    .IsUnicode(false);

                entity.Property(e => e.TipObs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<E301tcr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("E301TCR");

                entity.Property(e => e.AntDsc)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bancar)
                    .HasColumnName("bancar")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Carcov)
                    .HasColumnName("carcov")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Carpre)
                    .HasColumnName("carpre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Catext)
                    .HasColumnName("catext")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cattef)
                    .HasColumnName("cattef")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheAge)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CheBan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CheCta)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CheNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Chvagr).HasColumnName("chvagr");

                entity.Property(e => e.CodBar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodCcu)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CodCrp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodCrt)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodFrj)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodIn1)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodIn2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodMoe)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodMpt)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodOcr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodPor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodSnf)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTns)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodTpt)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Codcnv).HasColumnName("codcnv");

                entity.Property(e => e.Codequ).HasColumnName("codequ");

                entity.Property(e => e.Codfin).HasColumnName("codfin");

                entity.Property(e => e.Codope).HasColumnName("codope");

                entity.Property(e => e.Codpco).HasColumnName("codpco");

                entity.Property(e => e.ComRec).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Conlcd)
                    .HasColumnName("conlcd")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CotEmi).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CotFrj).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CotNeg).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CotUcm).HasColumnType("numeric(19, 10)");

                entity.Property(e => e.CpgNeg)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cptpco)
                    .HasColumnName("cptpco")
                    .HasColumnType("datetime");

                entity.Property(e => e.Croecf).HasColumnName("croecf");

                entity.Property(e => e.CrtAnt)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ctpneg)
                    .HasColumnName("ctpneg")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ctrfre).HasColumnName("ctrfre");

                entity.Property(e => e.Ctrnre).HasColumnName("ctrnre");

                entity.Property(e => e.DatCjm).HasColumnType("datetime");

                entity.Property(e => e.DatDsc).HasColumnType("datetime");

                entity.Property(e => e.DatEmi).HasColumnType("datetime");

                entity.Property(e => e.DatEnt).HasColumnType("datetime");

                entity.Property(e => e.DatGer).HasColumnType("datetime");

                entity.Property(e => e.DatNeg).HasColumnType("datetime");

                entity.Property(e => e.DatPpt).HasColumnType("datetime");

                entity.Property(e => e.DatPre).HasColumnType("datetime");

                entity.Property(e => e.DatUcm).HasColumnType("datetime");

                entity.Property(e => e.Datagr)
                    .HasColumnName("datagr")
                    .HasColumnType("datetime");

                entity.Property(e => e.DscNeg).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Dscpon)
                    .HasColumnName("dscpon")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Empcto).HasColumnName("empcto");

                entity.Property(e => e.Filagr).HasColumnName("filagr");

                entity.Property(e => e.Filcto).HasColumnName("filcto");

                entity.Property(e => e.Filpfi).HasColumnName("filpfi");

                entity.Property(e => e.Indadc)
                    .HasColumnName("indadc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Indtcf)
                    .HasColumnName("indtcf")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Intre2)
                    .HasColumnName("intre2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Intre4)
                    .HasColumnName("intre4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JrsDia).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.JrsNeg).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Jurven)
                    .HasColumnName("jurven")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Libccl).HasColumnName("libccl");

                entity.Property(e => e.Loctit)
                    .HasColumnName("loctit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MulNeg).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Nsuhst)
                    .HasColumnName("nsuhst")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nsutef)
                    .HasColumnName("nsutef")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumAce)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumNdb)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumTit)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Numcfi).HasColumnName("numcfi");

                entity.Property(e => e.Numdfs).HasColumnName("numdfs");

                entity.Property(e => e.Nummal)
                    .HasColumnName("nummal")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Numpfi)
                    .HasColumnName("numpfi")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Numpvc).HasColumnName("numpvc");

                entity.Property(e => e.Numrvc).HasColumnName("numrvc");

                entity.Property(e => e.ObsTcr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Orisub).HasColumnName("orisub");

                entity.Property(e => e.OutNeg).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Parcar).HasColumnName("parcar");

                entity.Property(e => e.Pedfre).HasColumnName("pedfre");

                entity.Property(e => e.Pednre).HasColumnName("pednre");

                entity.Property(e => e.PerCom).HasColumnType("numeric(7, 4)");

                entity.Property(e => e.PerDsc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerJrs).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerMul).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PorAnt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Prddsc)
                    .HasColumnName("prddsc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProJrs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Reatcr)
                    .HasColumnName("reatcr")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rotsap).HasColumnName("rotsap");

                entity.Property(e => e.Seqcob).HasColumnName("seqcob");

                entity.Property(e => e.SitTit)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sitant)
                    .HasColumnName("sitant")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sitpef).HasColumnName("sitpef");

                entity.Property(e => e.SnfNfc)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TaxNeg).HasColumnType("numeric(13, 10)");

                entity.Property(e => e.TipEfe)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipJrs)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TitBan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TnsPre)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TptNdb)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UltPgt).HasColumnType("datetime");

                entity.Property(e => e.UsuPedido).HasColumnName("usu_pedido");

                entity.Property(e => e.Ususit).HasColumnName("ususit");

                entity.Property(e => e.VctOri).HasColumnType("datetime");

                entity.Property(e => e.VctPro).HasColumnType("datetime");

                entity.Property(e => e.VlrAbe).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrBco).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrCom).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDca).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDcb).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrDsc).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOri).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOrm).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrOud).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.VlrPre).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrint)
                    .HasColumnName("vlrint")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrmoe)
                    .HasColumnName("vlrmoe")
                    .HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<Higienizacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("higienizacao");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoares).HasColumnName("cod_pessoares");

                entity.Property(e => e.FlgAtualizado)
                    .HasColumnName("flg_atualizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Logradouro)
                    .HasColumnName("LOGRADOURO")
                    .HasMaxLength(255);

                entity.Property(e => e.NovoComplemento)
                    .HasColumnName("NOVO COMPLEMENTO")
                    .HasMaxLength(255);

                entity.Property(e => e.NovoLogradouro)
                    .HasColumnName("NOVO LOGRADOURO")
                    .HasMaxLength(255);

                entity.Property(e => e.NovoNumero)
                    .HasColumnName("NOVO NUMERO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("{{storage}}");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TbBasAgencia>(entity =>
            {
                entity.HasKey(e => e.IdAgencia);

                entity.ToTable("tb_bas_agencia");

                entity.HasIndex(e => new { e.DesNomeagencia, e.CodAgencia, e.IdAgencia })
                    .HasName("sk_tb_bas_agencia")
                    .IsUnique();

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.CodAgencia)
                    .HasColumnName("cod_agencia")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodBanco).HasColumnName("cod_banco");

                entity.Property(e => e.CodMunicipio).HasColumnName("cod_municipio");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesNomeagencia)
                    .HasColumnName("des_nomeagencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodBancoNavigation)
                    .WithMany(p => p.TbBasAgencia)
                    .HasForeignKey(d => d.CodBanco)
                    .HasConstraintName("FK_tb_bas_agencia_tb_bas_banco");
            });

            modelBuilder.Entity<TbBasAssociacaoformulario>(entity =>
            {
                entity.HasKey(e => e.CodAssociacaoformulario)
                    .HasName("PK_tb_cad_associacaoformulario");

                entity.ToTable("tb_bas_associacaoformulario");

                entity.Property(e => e.CodAssociacaoformulario).HasColumnName("cod_associacaoformulario");

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodFormulario).HasColumnName("cod_formulario");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgCalouro)
                    .HasColumnName("flg_calouro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgVeterano)
                    .HasColumnName("flg_veterano")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.TbBasAssociacaoformulario)
                    .HasForeignKey(d => d.CodCategoria)
                    .HasConstraintName("FK_tb_bas_associacaoformulario_tb_bas_categoria");

                entity.HasOne(d => d.CodFormularioNavigation)
                    .WithMany(p => p.TbBasAssociacaoformulario)
                    .HasForeignKey(d => d.CodFormulario)
                    .HasConstraintName("FK_tb_bas_associacaoformulario_tb_cad_formulario");
            });

            modelBuilder.Entity<TbBasBanco>(entity =>
            {
                entity.HasKey(e => e.CodBanco);

                entity.ToTable("tb_bas_banco");

                entity.HasIndex(e => new { e.DesBanco, e.CodFebraban, e.CodBanco })
                    .HasName("sk_tb_bas_banco")
                    .IsUnique();

                entity.Property(e => e.CodBanco).HasColumnName("cod_banco");

                entity.Property(e => e.CodFebraban)
                    .HasColumnName("cod_febraban")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBanco)
                    .HasColumnName("des_banco")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasBandeiracartao>(entity =>
            {
                entity.HasKey(e => e.CodBandeiracartao);

                entity.ToTable("tb_bas_bandeiracartao");

                entity.Property(e => e.CodBandeiracartao)
                    .HasColumnName("cod_bandeiracartao")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesBandeiracartao)
                    .HasColumnName("des_bandeiracartao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesSiglabandeiracartao)
                    .HasColumnName("des_siglabandeiracartao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCreditoavista)
                    .HasColumnName("flg_creditoavista")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCreditoparcelado)
                    .HasColumnName("flg_creditoparcelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgDebito)
                    .HasColumnName("flg_debito")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgGateway)
                    .HasColumnName("flg_gateway")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCvc).HasColumnName("num_cvc");

                entity.Property(e => e.NumMaximoCartao).HasColumnName("num_maximo_cartao");
            });

            modelBuilder.Entity<TbBasBandeiracartaoAutomatico>(entity =>
            {
                entity.HasKey(e => e.CodBandeiracartaoAutomatico)
                    .HasName("PK_tb_cad_bandeiracartao_automatico");

                entity.ToTable("tb_bas_bandeiracartao_automatico");

                entity.Property(e => e.CodBandeiracartaoAutomatico).HasColumnName("cod_bandeiracartao_automatico");

                entity.Property(e => e.CodBandeiracartao).HasColumnName("cod_bandeiracartao");

                entity.Property(e => e.NumCartaoComecacom)
                    .HasColumnName("num_cartao_comecacom")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodBandeiracartaoNavigation)
                    .WithMany(p => p.TbBasBandeiracartaoAutomatico)
                    .HasForeignKey(d => d.CodBandeiracartao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_bas_bandeiracartao_automatico_tb_bas_bandeiracartao");
            });

            modelBuilder.Entity<TbBasCategoria>(entity =>
            {
                entity.HasKey(e => e.CodCategoria)
                    .HasName("tb_bas_categoria_pk");

                entity.ToTable("tb_bas_categoria");

                entity.HasIndex(e => e.DesCategoria)
                    .HasName("UK_tb_bas_categoria")
                    .IsUnique();

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodCategoriat).HasColumnName("cod_categoriat");

                entity.Property(e => e.CodTipopessoa).HasColumnName("cod_tipopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesCategoria)
                    .HasColumnName("des_categoria")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodTipopessoaNavigation)
                    .WithMany(p => p.TbBasCategoria)
                    .HasForeignKey(d => d.CodTipopessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_bas_categoria_tb_bas_tipopessoa");
            });

            modelBuilder.Entity<TbBasCategoriaCarga>(entity =>
            {
                entity.HasKey(e => e.CodCategoria)
                    .HasName("tb_bas_categoria_carga_pk");

                entity.ToTable("tb_bas_categoria_carga");

                entity.HasIndex(e => e.DesCategoria)
                    .HasName("UK_tb_bas_categoria_carga")
                    .IsUnique();

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodTipopessoa).HasColumnName("cod_tipopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesCategoria)
                    .HasColumnName("des_categoria")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasCategoriaabati>(entity =>
            {
                entity.HasKey(e => e.CodCategoriaabati);

                entity.ToTable("tb_bas_categoriaabati");

                entity.Property(e => e.CodCategoriaabati).HasColumnName("cod_categoriaabati");

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAbatimento)
                    .HasColumnName("des_abatimento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValAbatimento).HasColumnName("val_abatimento");

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.TbBasCategoriaabati)
                    .HasForeignKey(d => d.CodCategoria)
                    .HasConstraintName("FK_tb_bas_categoriaabati_tb_bas_categoria");
            });

            modelBuilder.Entity<TbBasCategoriadiario>(entity =>
            {
                entity.HasKey(e => e.CodCategoriadiario);

                entity.ToTable("tb_bas_categoriadiario");

                entity.HasIndex(e => new { e.DesCategoriadiario, e.CodCategoriadiario })
                    .HasName("SK_tb_bas_categoriadiario")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodCategoriadiario, e.DesCategoriadiario, e.FlgAtivo })
                    .HasName("UK_tb_bas_categoriadiario")
                    .IsUnique();

                entity.Property(e => e.CodCategoriadiario)
                    .HasColumnName("cod_categoriadiario")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCategoriadiario)
                    .HasColumnName("des_categoriadiario")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasCidade>(entity =>
            {
                entity.HasKey(e => e.CodCidade);

                entity.ToTable("tb_bas_cidade");

                entity.HasIndex(e => new { e.DesCidade, e.CodMunicipio, e.CodUf, e.CodCidade })
                    .HasName("sk_tb_bas_cidade")
                    .IsUnique();

                entity.Property(e => e.CodCidade).HasColumnName("cod_cidade");

                entity.Property(e => e.CodMunicipio).HasColumnName("cod_municipio");

                entity.Property(e => e.CodUf)
                    .HasColumnName("cod_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasCondpagto>(entity =>
            {
                entity.HasKey(e => e.CodCondpagto);

                entity.ToTable("tb_bas_condpagto");

                entity.Property(e => e.CodCondpagto).HasColumnName("cod_condpagto");

                entity.Property(e => e.CodMeiospagto).HasColumnName("cod_meiospagto");

                entity.Property(e => e.CodSapiens)
                    .HasColumnName("cod_sapiens")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAbreviatura)
                    .HasColumnName("des_abreviatura")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DesCondpagto)
                    .HasColumnName("des_condpagto")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumParcelas).HasColumnName("num_parcelas");
            });

            modelBuilder.Entity<TbBasConveniomedico>(entity =>
            {
                entity.HasKey(e => e.CodConveniomedico);

                entity.ToTable("tb_bas_conveniomedico");

                entity.Property(e => e.CodConveniomedico).HasColumnName("cod_conveniomedico");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesConveniomedico)
                    .HasColumnName("des_conveniomedico")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.DesSite)
                    .HasColumnName("des_site")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefone)
                    .HasColumnName("num_telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasDashboardpagina>(entity =>
            {
                entity.HasKey(e => e.CodDashboardpagina);

                entity.ToTable("tb_bas_dashboardpagina");

                entity.Property(e => e.CodDashboardpagina).HasColumnName("cod_dashboardpagina");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DesTitulo)
                    .HasColumnName("des_titulo")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesUrl)
                    .HasColumnName("des_url")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbBasDashboardportlet>(entity =>
            {
                entity.HasKey(e => e.CodDashboardportlet);

                entity.ToTable("tb_bas_dashboardportlet");

                entity.Property(e => e.CodDashboardportlet).HasColumnName("cod_dashboardportlet");

                entity.Property(e => e.CodDashboard).HasColumnName("cod_dashboard");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DesConfiguracoes)
                    .HasColumnName("des_configuracoes")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasDepartamentonr>(entity =>
            {
                entity.HasKey(e => e.CodDepto);

                entity.ToTable("tb_bas_departamentonr");

                entity.HasIndex(e => e.NomDepto)
                    .HasName("UK_tb_bas_departamentonr")
                    .IsUnique();

                entity.HasIndex(e => new { e.NomDepto, e.FlgReserva, e.CodDepto })
                    .HasName("SK_tb_bas_departamentonr")
                    .IsUnique();

                entity.Property(e => e.CodDepto)
                    .HasColumnName("cod_depto")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgReserva)
                    .HasColumnName("flg_reserva")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomDepto)
                    .HasColumnName("nom_depto")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasDescontoirmao>(entity =>
            {
                entity.HasKey(e => e.CodDescontoirmao);

                entity.ToTable("tb_bas_descontoirmao");

                entity.Property(e => e.CodDescontoirmao).HasColumnName("cod_descontoirmao");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesDesconto).HasColumnName("des_desconto");

                entity.Property(e => e.NumFilho).HasColumnName("num_filho");
            });

            modelBuilder.Entity<TbBasDistribuicaochale>(entity =>
            {
                entity.HasKey(e => e.CodDistribuicaochale);

                entity.ToTable("tb_bas_distribuicaochale");

                entity.Property(e => e.CodDistribuicaochale)
                    .HasColumnName("cod_distribuicaochale")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesDistribuicaochale)
                    .HasColumnName("des_distribuicaochale")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesIcone)
                    .HasColumnName("des_icone")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasEsportecultura>(entity =>
            {
                entity.HasKey(e => e.CodEsportecultura);

                entity.ToTable("tb_bas_esportecultura");

                entity.Property(e => e.CodEsportecultura)
                    .HasColumnName("cod_esportecultura")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesItem)
                    .HasColumnName("des_item")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipo)
                    .HasColumnName("des_tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasEstadocivil>(entity =>
            {
                entity.HasKey(e => e.CodEstadocivil);

                entity.ToTable("tb_bas_estadocivil");

                entity.HasIndex(e => e.DesEstadocivil)
                    .HasName("UK_tb_bas_estadocivil")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesEstadocivil, e.DesEstadocivilAbrev, e.ValOrdem, e.CodEstadocivil })
                    .HasName("sk_tb_bas_estadocivil")
                    .IsUnique();

                entity.Property(e => e.CodEstadocivil)
                    .HasColumnName("cod_estadocivil")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEstadocivil)
                    .HasColumnName("des_estadocivil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEstadocivilAbrev)
                    .HasColumnName("des_estadocivil_abrev")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbBasFeriado>(entity =>
            {
                entity.HasKey(e => e.CodFeriado);

                entity.ToTable("tb_bas_feriado");

                entity.Property(e => e.CodFeriado).HasColumnName("cod_feriado");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatFeriado)
                    .HasColumnName("dat_feriado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesFeriado)
                    .IsRequired()
                    .HasColumnName("des_feriado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgFacultativo)
                    .HasColumnName("flg_facultativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasFeriadounidadenr>(entity =>
            {
                entity.HasKey(e => e.CodFeriadounidadenr);

                entity.ToTable("tb_bas_feriadounidadenr");

                entity.Property(e => e.CodFeriadounidadenr).HasColumnName("cod_feriadounidadenr");

                entity.Property(e => e.CodFeriado).HasColumnName("cod_feriado");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.HasOne(d => d.CodFeriadoNavigation)
                    .WithMany(p => p.TbBasFeriadounidadenr)
                    .HasForeignKey(d => d.CodFeriado)
                    .HasConstraintName("FK_tb_bas_feriadounidadenr_tb_bas_feriado");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbBasFeriadounidadenr)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_bas_feriadounidadenr_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbBasFormacaoescolar>(entity =>
            {
                entity.HasKey(e => e.CodFormacaoescolar);

                entity.ToTable("tb_bas_formacaoescolar");

                entity.HasIndex(e => e.DesFormacaoescolar)
                    .HasName("UK_tb_bas_formacaoescolar")
                    .IsUnique();

                entity.HasIndex(e => new { e.NumGrau, e.ValOrdem, e.DesFormacaoescolar, e.CodFormacaoescolar })
                    .HasName("sk_tb_bas_formacaoescolar")
                    .IsUnique();

                entity.Property(e => e.CodFormacaoescolar)
                    .HasColumnName("cod_formacaoescolar")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesFormacaoescolar)
                    .HasColumnName("des_formacaoescolar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumGrau).HasColumnName("num_grau");

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbBasFormacaoescolarcurso>(entity =>
            {
                entity.HasKey(e => e.CodFormacaoescolarcurso);

                entity.ToTable("tb_bas_formacaoescolarcurso");

                entity.HasIndex(e => e.NomCurso)
                    .HasName("sk_tb_bas_formacaoescolarcurso");

                entity.HasIndex(e => new { e.NomCurso, e.CodFormacaoescolarcurso })
                    .HasName("uk_tb_bas_formacaoescolarcurso")
                    .IsUnique();

                entity.Property(e => e.CodFormacaoescolarcurso).HasColumnName("cod_formacaoescolarcurso");

                entity.Property(e => e.CodFormacaoescolar).HasColumnName("cod_formacaoescolar");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NomCurso)
                    .HasColumnName("nom_curso")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodFormacaoescolarNavigation)
                    .WithMany(p => p.TbBasFormacaoescolarcurso)
                    .HasForeignKey(d => d.CodFormacaoescolar)
                    .HasConstraintName("FK_tb_bas_formacaoescolarcurso_tb_bas_formacaoescolar");
            });

            modelBuilder.Entity<TbBasFormacaoescolarstatus>(entity =>
            {
                entity.HasKey(e => e.CodFormacaoescolarstatus);

                entity.ToTable("tb_bas_formacaoescolarstatus");

                entity.HasIndex(e => e.DesFormacaoescolarstatus)
                    .HasName("UK_tb_bas_formacaoescolarstatus")
                    .IsUnique();

                entity.HasIndex(e => new { e.ValOrdem, e.DesFormacaoescolarstatus, e.CodFormacaoescolarstatus })
                    .HasName("sk_tb_bas_formacaoescolarstatus")
                    .IsUnique();

                entity.Property(e => e.CodFormacaoescolarstatus)
                    .HasColumnName("cod_formacaoescolarstatus")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesFormacaoescolarstatus)
                    .HasColumnName("des_formacaoescolarstatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbBasFormularioFuncionalidade>(entity =>
            {
                entity.HasKey(e => e.CodFormularioFuncionalidade);

                entity.ToTable("tb_bas_formulario_funcionalidade");

                entity.HasIndex(e => e.DesFormularioFuncionalidade)
                    .HasName("sk_tb_bas_formulario_funcionalidade");

                entity.Property(e => e.CodFormularioFuncionalidade)
                    .HasColumnName("cod_formulario_funcionalidade")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesFormularioFuncionalidade)
                    .HasColumnName("des_formulario_funcionalidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasFuncionalidade>(entity =>
            {
                entity.HasKey(e => e.CodFuncionalidade);

                entity.ToTable("tb_bas_funcionalidade");

                entity.HasIndex(e => new { e.DesFuncionalidade, e.DesOrdem, e.FlgAtivo, e.DesMenu, e.DesImg, e.DesLink, e.CodFuncionalidade })
                    .HasName("SK_tb_bas_funcionalidade")
                    .IsUnique();

                entity.Property(e => e.CodFuncionalidade)
                    .HasColumnName("cod_funcionalidade")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesFuncionalidade)
                    .HasColumnName("des_funcionalidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesImg)
                    .HasColumnName("des_img")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesLink)
                    .HasColumnName("des_link")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesMenu)
                    .HasColumnName("des_menu")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesOrdem).HasColumnName("des_ordem");

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasGenero>(entity =>
            {
                entity.HasKey(e => e.CodGenero);

                entity.ToTable("tb_bas_genero");

                entity.Property(e => e.CodGenero)
                    .HasColumnName("cod_genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesGenero)
                    .HasColumnName("des_genero")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DesGeneroRed)
                    .HasColumnName("des_genero_red")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasGrauparentesco>(entity =>
            {
                entity.HasKey(e => e.CodGrauparentesco);

                entity.ToTable("tb_bas_grauparentesco");

                entity.HasIndex(e => e.DesGrauparentesco)
                    .HasName("UK_tb_bas_grauparentesco")
                    .IsUnique();

                entity.Property(e => e.CodGrauparentesco)
                    .HasColumnName("cod_grauparentesco")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodGrauparentescoRed)
                    .HasColumnName("cod_grauparentesco_red")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodGrauparentescoinverso).HasColumnName("cod_grauparentescoinverso");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesGrauparentesco)
                    .HasColumnName("des_grauparentesco")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasGrupoparametro>(entity =>
            {
                entity.HasKey(e => e.CodGrupoparametro);

                entity.ToTable("tb_bas_grupoparametro");

                entity.HasIndex(e => new { e.DesGrupoparametro, e.CodGrupoparametro })
                    .HasName("sk_tb_bas_grupoparametro");

                entity.Property(e => e.CodGrupoparametro)
                    .HasColumnName("cod_grupoparametro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesGrupoparametro)
                    .HasColumnName("des_grupoparametro")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasIdioma>(entity =>
            {
                entity.HasKey(e => e.CodIdioma);

                entity.ToTable("tb_bas_idioma");

                entity.HasIndex(e => e.DesIdioma)
                    .HasName("UK_tb_bas_idioma")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesIdioma, e.ValOrdem, e.CodIdioma })
                    .HasName("sk_tb_bas_idioma")
                    .IsUnique();

                entity.Property(e => e.CodIdioma)
                    .HasColumnName("cod_idioma")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIdioma)
                    .HasColumnName("des_idioma")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbBasIndisponibilidade>(entity =>
            {
                entity.HasKey(e => e.CodIndisponibilidade);

                entity.ToTable("tb_bas_indisponibilidade");

                entity.Property(e => e.CodIndisponibilidade).HasColumnName("cod_indisponibilidade");

                entity.Property(e => e.CodEntrevistador).HasColumnName("cod_entrevistador");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesMotivo)
                    .HasColumnName("des_motivo")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasLog>(entity =>
            {
                entity.HasKey(e => e.CodLog);

                entity.ToTable("tb_bas_log");

                entity.HasIndex(e => new { e.DesFuncionalidade, e.DesMensagem, e.DatAtualizacao, e.CodLog, e.CodUsuario })
                    .HasName("sk_tb_bas_log")
                    .IsUnique();

                entity.Property(e => e.CodLog).HasColumnName("cod_log");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesFuncionalidade)
                    .HasColumnName("des_funcionalidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasMeiospagto>(entity =>
            {
                entity.HasKey(e => e.CodMeiospagto);

                entity.ToTable("tb_bas_meiospagto");

                entity.Property(e => e.CodMeiospagto)
                    .HasColumnName("cod_meiospagto")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodMeiossapiens)
                    .HasColumnName("cod_meiossapiens")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesMeiospagto)
                    .HasColumnName("des_meiospagto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasMeiotransporte>(entity =>
            {
                entity.HasKey(e => e.CodMeiotransporte);

                entity.ToTable("tb_bas_meiotransporte");

                entity.Property(e => e.CodMeiotransporte)
                    .HasColumnName("cod_meiotransporte")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesMeiotransporte)
                    .HasColumnName("des_meiotransporte")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.FlgInformacoes)
                    .HasColumnName("flg_informacoes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPortal)
                    .HasColumnName("flg_portal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasMidia>(entity =>
            {
                entity.HasKey(e => e.CodMidia);

                entity.ToTable("tb_bas_midia");

                entity.HasIndex(e => e.DesMidia)
                    .HasName("UK_tb_bas_midia")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesMidia, e.DesComentario, e.FlgAtivo, e.CodMidia })
                    .HasName("sk_tb_bas_midia")
                    .IsUnique();

                entity.Property(e => e.CodMidia).HasColumnName("cod_midia");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesComentario)
                    .HasColumnName("des_comentario")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesMidia)
                    .HasColumnName("des_midia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasMidiassociais>(entity =>
            {
                entity.HasKey(e => e.CodMidiasocial);

                entity.ToTable("tb_bas_midiassociais");

                entity.HasIndex(e => e.NomMidiasocial)
                    .HasName("UK_tb_bas_midiassociais")
                    .IsUnique();

                entity.HasIndex(e => new { e.NomMidiasocial, e.CodMidiasocial })
                    .HasName("SK_tb_bas_midiassociais")
                    .IsUnique();

                entity.Property(e => e.CodMidiasocial).HasColumnName("cod_midiasocial");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesUrl)
                    .HasColumnName("des_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomMidiasocial)
                    .HasColumnName("nom_midiasocial")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasModalidade>(entity =>
            {
                entity.HasKey(e => e.CodModalidade);

                entity.ToTable("tb_bas_modalidade");

                entity.HasIndex(e => e.DesModalidade)
                    .HasName("UK_tb_bas_modalidade")
                    .IsUnique();

                entity.Property(e => e.CodModalidade)
                    .HasColumnName("cod_modalidade")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesModalidade)
                    .HasColumnName("des_modalidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasModalidadeUnidades>(entity =>
            {
                entity.HasKey(e => e.CodModalidadeUnidade);

                entity.ToTable("tb_bas_modalidade_unidades");

                entity.Property(e => e.CodModalidadeUnidade).HasColumnName("cod_modalidade_unidade");

                entity.Property(e => e.CodModalidade).HasColumnName("cod_modalidade");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.HasOne(d => d.CodModalidadeNavigation)
                    .WithMany(p => p.TbBasModalidadeUnidades)
                    .HasForeignKey(d => d.CodModalidade)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_bas_modalidade_unidades_tb_bas_modalidade");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbBasModalidadeUnidades)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_bas_modalidade_unidades_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbBasNacionalidade>(entity =>
            {
                entity.HasKey(e => e.CodNacionalidade);

                entity.ToTable("tb_bas_nacionalidade");

                entity.HasIndex(e => e.DesNacionalidade)
                    .HasName("UK_tb_bas_nacionalidade")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesNacionalidade, e.CodNacionalidade })
                    .HasName("sk_tb_bas_nacionalidade")
                    .IsUnique();

                entity.Property(e => e.CodNacionalidade).HasColumnName("cod_nacionalidade");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesNacionalidade)
                    .HasColumnName("des_nacionalidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasNecessespecial>(entity =>
            {
                entity.HasKey(e => e.CodNecessespecial);

                entity.ToTable("tb_bas_necessespecial");

                entity.HasIndex(e => e.DesNecessespecial)
                    .HasName("UK_tb_bas_necessespecial")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesNecessespecial, e.ValOrdem, e.CodNecessespecial })
                    .HasName("sk_tb_bas_necessespecial")
                    .IsUnique();

                entity.Property(e => e.CodNecessespecial)
                    .HasColumnName("cod_necessespecial")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesNecessespecial)
                    .HasColumnName("des_necessespecial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbBasOnibusitem>(entity =>
            {
                entity.HasKey(e => e.CodOnibusitem);

                entity.ToTable("tb_bas_onibusitem");

                entity.HasIndex(e => new { e.DesOnibusitem, e.CodOnibusitem })
                    .HasName("sk_tb_bas_onibusitem");

                entity.Property(e => e.CodOnibusitem)
                    .HasColumnName("cod_onibusitem")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesOnibusitem)
                    .HasColumnName("des_onibusitem")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasOnibusopcaoitem>(entity =>
            {
                entity.HasKey(e => e.CodOnibusopcaoitem);

                entity.ToTable("tb_bas_onibusopcaoitem");

                entity.Property(e => e.CodOnibusopcaoitem).HasColumnName("cod_onibusopcaoitem");

                entity.Property(e => e.CodOnibus).HasColumnName("cod_onibus");

                entity.Property(e => e.CodOnibusitem).HasColumnName("cod_onibusitem");

                entity.HasOne(d => d.CodOnibusitemNavigation)
                    .WithMany(p => p.TbBasOnibusopcaoitem)
                    .HasForeignKey(d => d.CodOnibusitem)
                    .HasConstraintName("FK_tb_bas_onibusopcaoitem_tb_bas_onibusitem");
            });

            modelBuilder.Entity<TbBasOperadora>(entity =>
            {
                entity.HasKey(e => e.CodOperadora);

                entity.ToTable("tb_bas_operadora");

                entity.HasIndex(e => e.DesOperadora)
                    .HasName("UK_tb_bas_operadora")
                    .IsUnique();

                entity.Property(e => e.CodOperadora)
                    .HasColumnName("cod_operadora")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesOperadora)
                    .HasColumnName("des_operadora")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasPais>(entity =>
            {
                entity.HasKey(e => e.CodPais);

                entity.ToTable("tb_bas_pais");

                entity.HasIndex(e => e.NomPais)
                    .HasName("UK_tb_bas_pais")
                    .IsUnique();

                entity.HasIndex(e => new { e.NomPais, e.CodPais })
                    .HasName("sk_tb_bas_pais");

                entity.Property(e => e.CodPais).HasColumnName("cod_pais");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPais)
                    .HasColumnName("nom_pais")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasPalavrarestrita>(entity =>
            {
                entity.HasKey(e => e.CodPalavrarestrita);

                entity.ToTable("tb_bas_palavrarestrita");

                entity.HasIndex(e => e.DesPalavrarestrita)
                    .HasName("UK_tb_bas_palavrarestrita")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesPalavrarestrita, e.FlgAtivo, e.CodPalavrarestrita })
                    .HasName("sk_tb_bas_palavrarestrita");

                entity.Property(e => e.CodPalavrarestrita).HasColumnName("cod_palavrarestrita");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesPalavrarestrita)
                    .HasColumnName("des_palavrarestrita")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasPeriodoatividades>(entity =>
            {
                entity.HasKey(e => e.CodPeriodoatividades);

                entity.ToTable("tb_bas_periodoatividades");

                entity.Property(e => e.CodPeriodoatividades).HasColumnName("cod_periodoatividades");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesInicio)
                    .HasColumnName("des_inicio")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DesPeriodo)
                    .HasColumnName("des_periodo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesTermino)
                    .HasColumnName("des_termino")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FlgDomingo)
                    .HasColumnName("flg_domingo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgFeriado)
                    .HasColumnName("flg_feriado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgQuarta)
                    .HasColumnName("flg_quarta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgQuinta)
                    .HasColumnName("flg_quinta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSabado)
                    .HasColumnName("flg_sabado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSegunda)
                    .HasColumnName("flg_segunda")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSexta)
                    .HasColumnName("flg_sexta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTerca)
                    .HasColumnName("flg_terca")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasPermanencia>(entity =>
            {
                entity.HasKey(e => e.CodPermanencia);

                entity.ToTable("tb_bas_permanencia");

                entity.Property(e => e.CodPermanencia).HasColumnName("cod_permanencia");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesPermanencia)
                    .HasColumnName("des_permanencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumDias).HasColumnName("num_dias");
            });

            modelBuilder.Entity<TbBasRacacor>(entity =>
            {
                entity.HasKey(e => e.CodRacacor);

                entity.ToTable("tb_bas_racacor");

                entity.HasIndex(e => e.DesRacacor)
                    .HasName("UK_tb_bas_racacor")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesRacacor, e.CodRacacor })
                    .HasName("sk_tb_bas_racacor")
                    .IsUnique();

                entity.Property(e => e.CodRacacor)
                    .HasColumnName("cod_racacor")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesRacacor)
                    .HasColumnName("des_racacor")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasRights>(entity =>
            {
                entity.HasKey(e => e.CodRights)
                    .HasName("PK__tb_bas_rights__1FB8AE52");

                entity.ToTable("tb_bas_rights");

                entity.Property(e => e.CodRights).HasColumnName("cod_rights");

                entity.Property(e => e.CodTipo).HasColumnName("cod_tipo");

                entity.Property(e => e.NomItem)
                    .IsRequired()
                    .HasColumnName("nom_item")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");

                entity.HasOne(d => d.NomItemNavigation)
                    .WithMany(p => p.TbBasRights)
                    .HasPrincipalKey(p => p.NomItem)
                    .HasForeignKey(d => d.NomItem)
                    .HasConstraintName("FK_tb_bas_rights_tb_bas_rightsauthitem");
            });

            modelBuilder.Entity<TbBasRightsauthassignment>(entity =>
            {
                entity.HasKey(e => e.CodRightsauthassignment);

                entity.ToTable("tb_bas_rightsauthassignment");

                entity.Property(e => e.CodRightsauthassignment).HasColumnName("cod_rightsauthassignment");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DesDados)
                    .HasColumnName("des_dados")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesRegranegocio)
                    .HasColumnName("des_regranegocio")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NomItem)
                    .IsRequired()
                    .HasColumnName("nom_item")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.NomItemNavigation)
                    .WithMany(p => p.TbBasRightsauthassignment)
                    .HasPrincipalKey(p => p.NomItem)
                    .HasForeignKey(d => d.NomItem)
                    .HasConstraintName("FK_tb_bas_rightsauthassignment_tb_bas_rightsauthitem");
            });

            modelBuilder.Entity<TbBasRightsauthitem>(entity =>
            {
                entity.HasKey(e => e.CodRightsauthitem);

                entity.ToTable("tb_bas_rightsauthitem");

                entity.HasIndex(e => e.NomItem)
                    .HasName("UK_tb_bas_rightsauthitem")
                    .IsUnique();

                entity.Property(e => e.CodRightsauthitem).HasColumnName("cod_rightsauthitem");

                entity.Property(e => e.CodTipo).HasColumnName("cod_tipo");

                entity.Property(e => e.DesDados)
                    .HasColumnName("des_dados")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesItem)
                    .HasColumnName("des_item")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesRegranegocio)
                    .HasColumnName("des_regranegocio")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NomItem)
                    .IsRequired()
                    .HasColumnName("nom_item")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasRightsauthitemchild>(entity =>
            {
                entity.HasKey(e => e.CodRightsauthitemchild)
                    .HasName("PK__tb_bas_rightsaut__2B2A60FE");

                entity.ToTable("tb_bas_rightsauthitemchild");

                entity.Property(e => e.CodRightsauthitemchild).HasColumnName("cod_rightsauthitemchild");

                entity.Property(e => e.DesPermissoes)
                    .IsRequired()
                    .HasColumnName("des_permissoes")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DesRelacoes)
                    .IsRequired()
                    .HasColumnName("des_relacoes")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.DesRelacoesNavigation)
                    .WithMany(p => p.TbBasRightsauthitemchild)
                    .HasPrincipalKey(p => p.NomItem)
                    .HasForeignKey(d => d.DesRelacoes)
                    .HasConstraintName("FK__tb_bas_ri__des_r__2C1E8537");
            });

            modelBuilder.Entity<TbBasSexo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_bas_sexo");

                entity.Property(e => e.CodSexo)
                    .HasColumnName("cod_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesSexo)
                    .HasColumnName("des_sexo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DesSexoRed)
                    .HasColumnName("des_sexo_red")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasTermocontrato>(entity =>
            {
                entity.HasKey(e => e.CodTermocontrato);

                entity.ToTable("tb_bas_termocontrato");

                entity.Property(e => e.CodTermocontrato)
                    .HasColumnName("cod_termocontrato")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesTermocontrato)
                    .HasColumnName("des_termocontrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesUtilizacao)
                    .HasColumnName("des_utilizacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasTipocamiseta>(entity =>
            {
                entity.HasKey(e => e.CodTipocamiseta);

                entity.ToTable("tb_bas_tipocamiseta");

                entity.HasIndex(e => new { e.DesTipocamiseta, e.FlgAtivo, e.CodTipocamiseta })
                    .HasName("SK_tb_bas_tipocamiseta")
                    .IsUnique();

                entity.Property(e => e.CodTipocamiseta).HasColumnName("cod_tipocamiseta");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesReduzida)
                    .HasColumnName("des_reduzida")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipocamiseta)
                    .IsRequired()
                    .HasColumnName("des_tipocamiseta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .IsRequired()
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasTipodocsdigitalizados>(entity =>
            {
                entity.HasKey(e => e.CodTipodocsdigitalizados);

                entity.ToTable("tb_bas_tipodocsdigitalizados");

                entity.HasIndex(e => e.DesTipodocsdigitalizados)
                    .HasName("UK_tb_bas_tipodocsdigitalizados")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesTipodocsdigitalizados, e.CodTipodocsdigitalizados })
                    .HasName("SK_tb_bas_tipodocsdigitalizados")
                    .IsUnique();

                entity.Property(e => e.CodTipodocsdigitalizados)
                    .HasColumnName("cod_tipodocsdigitalizados")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesTipodocsdigitalizados)
                    .HasColumnName("des_tipodocsdigitalizados")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasTipodoctemplate>(entity =>
            {
                entity.HasKey(e => e.CodTipodoctemplate);

                entity.ToTable("tb_bas_tipodoctemplate");

                entity.HasIndex(e => new { e.CodTipodoctemplate, e.DesTipodoctemplate })
                    .HasName("SK_tb_bas_tipodoctemplate");

                entity.Property(e => e.CodTipodoctemplate)
                    .HasColumnName("cod_tipodoctemplate")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesTipodoctemplate)
                    .HasColumnName("des_tipodoctemplate")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasTipodoctemplatemacro>(entity =>
            {
                entity.HasKey(e => e.CodTipodoctemplatemacro);

                entity.ToTable("tb_bas_tipodoctemplatemacro");

                entity.HasIndex(e => e.DesTag)
                    .HasName("UK_tb_bas_tipodoctemplatemacro")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodTipodoctemplatemacro, e.DesTipodoctemplatemacro })
                    .HasName("SK_tb_bas_tipodoctemplatemacro");

                entity.Property(e => e.CodTipodoctemplatemacro)
                    .HasColumnName("cod_tipodoctemplatemacro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesTag)
                    .HasColumnName("des_tag")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipodoctemplatemacro)
                    .HasColumnName("des_tipodoctemplatemacro")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasTipoendereco>(entity =>
            {
                entity.HasKey(e => e.CodTipoendereco);

                entity.ToTable("tb_bas_tipoendereco");

                entity.HasIndex(e => e.DesTipoendereco)
                    .HasName("UK_tb_bas_tipoendereco")
                    .IsUnique();

                entity.Property(e => e.CodTipoendereco).HasColumnName("cod_tipoendereco");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesTipoendereco)
                    .IsRequired()
                    .HasColumnName("des_tipoendereco")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbBasTipoescola>(entity =>
            {
                entity.HasKey(e => e.CodTipoescola);

                entity.ToTable("tb_bas_tipoescola");

                entity.HasIndex(e => e.DesTipoescola)
                    .HasName("UK_tb_bas_tipoescola")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesTipoescola, e.FlgAtivo, e.CodTipoescola })
                    .HasName("sk_tb_bas_tipoescola")
                    .IsUnique();

                entity.Property(e => e.CodTipoescola).HasColumnName("cod_tipoescola");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesTipoescola)
                    .HasColumnName("des_tipoescola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasTipomensagem>(entity =>
            {
                entity.HasKey(e => e.CodTipomensagem);

                entity.ToTable("tb_bas_tipomensagem");

                entity.HasIndex(e => e.DesTipomensagem)
                    .HasName("UK_tb_bas_tipomensagem")
                    .IsUnique();

                entity.Property(e => e.CodTipomensagem)
                    .HasColumnName("cod_tipomensagem")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesTipomensagem)
                    .HasColumnName("des_tipomensagem")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasTipopessoa>(entity =>
            {
                entity.HasKey(e => e.CodTipopessoa);

                entity.ToTable("tb_bas_tipopessoa");

                entity.Property(e => e.CodTipopessoa)
                    .HasColumnName("cod_tipopessoa")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesIconegrande)
                    .HasColumnName("des_iconegrande")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIconepequeno)
                    .HasColumnName("des_iconepequeno")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipopessoa)
                    .HasColumnName("des_tipopessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUrl)
                    .HasColumnName("des_url")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasTipopremiacao>(entity =>
            {
                entity.HasKey(e => e.CodTipopremiacao)
                    .HasName("tb_bas_premiacao_pk");

                entity.ToTable("tb_bas_tipopremiacao");

                entity.HasIndex(e => e.DesTipopremiacao)
                    .HasName("UK_tb_bas_tipopremiacao")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesTipopremiacao, e.FlgAtivo, e.CodTipopremiacao })
                    .HasName("sk_tb_bas_tipopremiacao")
                    .IsUnique();

                entity.Property(e => e.CodTipopremiacao).HasColumnName("cod_tipopremiacao");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesTipopremiacao)
                    .HasColumnName("des_tipopremiacao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasTiporg>(entity =>
            {
                entity.HasKey(e => e.CodTiporg);

                entity.ToTable("tb_bas_tiporg");

                entity.Property(e => e.CodTiporg)
                    .HasColumnName("cod_tiporg")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesTiporg)
                    .HasColumnName("des_tiporg")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasTipotelefone>(entity =>
            {
                entity.HasKey(e => e.CodTipotelefone);

                entity.ToTable("tb_bas_tipotelefone");

                entity.HasIndex(e => e.DesTipotelefone)
                    .HasName("UK_tb_bas_tipotelefone")
                    .IsUnique();

                entity.Property(e => e.CodTipotelefone)
                    .HasColumnName("cod_tipotelefone")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesTipotelefone)
                    .HasColumnName("des_tipotelefone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasTipovinculopessoa>(entity =>
            {
                entity.HasKey(e => e.CodTipovinculopessoa);

                entity.ToTable("tb_bas_tipovinculopessoa");

                entity.HasIndex(e => new { e.DesTipovinculopessoa, e.FlgAtivo, e.CodTipovinculopessoa })
                    .HasName("sk_tb_bas_tipovinculopessoa");

                entity.Property(e => e.CodTipovinculopessoa)
                    .HasColumnName("cod_tipovinculopessoa")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DesTipovinculopessoa)
                    .IsRequired()
                    .HasColumnName("des_tipovinculopessoa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbBasUf>(entity =>
            {
                entity.HasKey(e => e.CodIdUf);

                entity.ToTable("tb_bas_uf");

                entity.HasIndex(e => e.CodUf)
                    .HasName("UK_tb_bas_uf")
                    .IsUnique();

                entity.HasIndex(e => e.DesUf)
                    .HasName("UK_tb_bas_uf_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodUf, e.DesUf, e.CodIdUf })
                    .HasName("SK_tb_bas_uf")
                    .IsUnique();

                entity.Property(e => e.CodIdUf)
                    .HasColumnName("cod_id_uf")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUf)
                    .HasColumnName("cod_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasVisibilidade>(entity =>
            {
                entity.HasKey(e => e.CodVisibilidade);

                entity.ToTable("tb_bas_visibilidade");

                entity.Property(e => e.CodVisibilidade)
                    .HasColumnName("cod_visibilidade")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesVisibilidade)
                    .HasColumnName("des_visibilidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbBasVisibilidadeUnidades>(entity =>
            {
                entity.HasKey(e => e.CodVisibilidadeUnidade);

                entity.ToTable("tb_bas_visibilidade_unidades");

                entity.Property(e => e.CodVisibilidadeUnidade).HasColumnName("cod_visibilidade_unidade");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodVisibilidade).HasColumnName("cod_visibilidade");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbBasVisibilidadeUnidades)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_bas_visibilidade_unidades_tb_cad_unidadenr");

                entity.HasOne(d => d.CodVisibilidadeNavigation)
                    .WithMany(p => p.TbBasVisibilidadeUnidades)
                    .HasForeignKey(d => d.CodVisibilidade)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_bas_visibilidade_unidades_tb_bas_visibilidade");
            });

            modelBuilder.Entity<TbCadAcessoCantina>(entity =>
            {
                entity.HasKey(e => e.CodAcessoCantina);

                entity.ToTable("tb_cad_acesso_cantina");

                entity.Property(e => e.CodAcessoCantina).HasColumnName("cod_acesso_cantina");

                entity.Property(e => e.CodResponsavel).HasColumnName("cod_responsavel");

                entity.Property(e => e.DatAcesso)
                    .HasColumnName("dat_acesso")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesToken)
                    .HasColumnName("des_token")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadAgenciarepresentante>(entity =>
            {
                entity.HasKey(e => e.CodAgenciarepresentante)
                    .HasName("PK_tb_cad_agencia");

                entity.ToTable("tb_cad_agenciarepresentante");

                entity.HasIndex(e => new { e.DesAgenciarepresentante, e.DesLogin })
                    .HasName("UK_tb_cad_agenciarepresentante")
                    .IsUnique();

                entity.Property(e => e.CodAgenciarepresentante).HasColumnName("cod_agenciarepresentante");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAgenciarepresentante)
                    .HasColumnName("des_agenciarepresentante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogin)
                    .HasColumnName("des_login")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNumero)
                    .HasColumnName("des_numero")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesUrl)
                    .HasColumnName("des_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadAlocacaoonibus>(entity =>
            {
                entity.HasKey(e => e.CodAlocacaoonibus);

                entity.ToTable("tb_cad_alocacaoonibus");

                entity.Property(e => e.CodAlocacaoonibus).HasColumnName("cod_alocacaoonibus");

                entity.Property(e => e.DatAlocacaoonibus)
                    .HasColumnName("dat_alocacaoonibus")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgTipo)
                    .HasColumnName("flg_tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadAlocacaoonibusOnibus>(entity =>
            {
                entity.HasKey(e => e.CodAlocacaoonibusOnibus);

                entity.ToTable("tb_cad_alocacaoonibus_onibus");

                entity.Property(e => e.CodAlocacaoonibusOnibus).HasColumnName("cod_alocacaoonibus_onibus");

                entity.Property(e => e.CodAlocacaoonibus).HasColumnName("cod_alocacaoonibus");

                entity.Property(e => e.CodOnibus).HasColumnName("cod_onibus");

                entity.Property(e => e.NumAlocadas).HasColumnName("num_alocadas");

                entity.Property(e => e.NumVagas).HasColumnName("num_vagas");

                entity.HasOne(d => d.CodAlocacaoonibusNavigation)
                    .WithMany(p => p.TbCadAlocacaoonibusOnibus)
                    .HasForeignKey(d => d.CodAlocacaoonibus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_alocacaoonibus_onibus_tb_cad_alocacaoonibus");

                entity.HasOne(d => d.CodOnibusNavigation)
                    .WithMany(p => p.TbCadAlocacaoonibusOnibus)
                    .HasForeignKey(d => d.CodOnibus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_alocacaoonibus_onibus_tb_cad_onibus");
            });

            modelBuilder.Entity<TbCadAlocacaoonibusPacote>(entity =>
            {
                entity.HasKey(e => e.CodAlocacaoonibusPacote);

                entity.ToTable("tb_cad_alocacaoonibus_pacote");

                entity.Property(e => e.CodAlocacaoonibusPacote).HasColumnName("cod_alocacaoonibus_pacote");

                entity.Property(e => e.CodAlocacaoonibus).HasColumnName("cod_alocacaoonibus");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.HasOne(d => d.CodAlocacaoonibusNavigation)
                    .WithMany(p => p.TbCadAlocacaoonibusPacote)
                    .HasForeignKey(d => d.CodAlocacaoonibus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_alocacaoonibus_pacote_tb_cad_alocacaoonibus");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadAlocacaoonibusPacote)
                    .HasForeignKey(d => d.CodPacote)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_alocacaoonibus_pacote_tb_cad_pacote");
            });

            modelBuilder.Entity<TbCadBoleto>(entity =>
            {
                entity.HasKey(e => e.CodBoleto);

                entity.ToTable("tb_cad_boleto");

                entity.Property(e => e.CodBoleto).HasColumnName("cod_boleto");

                entity.Property(e => e.CodPagamentoParcela).HasColumnName("cod_pagamento_parcela");

                entity.Property(e => e.CodRemessa).HasColumnName("cod_remessa");

                entity.Property(e => e.CodRetorno).HasColumnName("cod_retorno");

                entity.Property(e => e.DatDocumento)
                    .HasColumnName("dat_documento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatVencimento)
                    .HasColumnName("dat_vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesCedente)
                    .HasColumnName("des_cedente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteBairro)
                    .HasColumnName("des_cliente_bairro")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteCep)
                    .HasColumnName("des_cliente_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteCidade)
                    .HasColumnName("des_cliente_cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteCpfCnpj)
                    .HasColumnName("des_cliente_cpf_cnpj")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteEndereco)
                    .HasColumnName("des_cliente_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteEnderecoComp)
                    .HasColumnName("des_cliente_endereco_comp")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteEstado)
                    .HasColumnName("des_cliente_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteNome)
                    .HasColumnName("des_cliente_nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstrucaocaixa)
                    .HasColumnName("des_instrucaocaixa")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstrucaocliente)
                    .HasColumnName("des_instrucaocliente")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesPdf)
                    .HasColumnName("des_pdf")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NumAgenciaCodcedente)
                    .HasColumnName("num_agencia_codcedente")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCarteira)
                    .HasColumnName("num_carteira")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumCarteiraCompleto)
                    .HasColumnName("num_carteira_completo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumContrato)
                    .HasColumnName("num_contrato")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("num_documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumLinhadigitavel)
                    .HasColumnName("num_linhadigitavel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumNossonumero)
                    .HasColumnName("num_nossonumero")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumVariacaocarteira)
                    .HasColumnName("num_variacaocarteira")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValCobrado)
                    .HasColumnName("val_cobrado")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValDesconto)
                    .HasColumnName("val_desconto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValDocumento)
                    .HasColumnName("val_documento")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValMulta)
                    .HasColumnName("val_multa")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValOutrasdeducoes)
                    .HasColumnName("val_outrasdeducoes")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValOutrosacrescimos)
                    .HasColumnName("val_outrosacrescimos")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodPagamentoParcelaNavigation)
                    .WithMany(p => p.TbCadBoleto)
                    .HasForeignKey(d => d.CodPagamentoParcela)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagamento_parcela");
            });

            modelBuilder.Entity<TbCadBoletoacampante>(entity =>
            {
                entity.HasKey(e => e.CodBoletoacampante);

                entity.ToTable("tb_cad_boletoacampante");

                entity.Property(e => e.CodBoletoacampante).HasColumnName("cod_boletoacampante");

                entity.Property(e => e.DatEnviopagto)
                    .HasColumnName("dat_enviopagto")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TbCadBoletoacampanteInscricao>(entity =>
            {
                entity.HasKey(e => e.CodBoletoacampanteInscricao);

                entity.ToTable("tb_cad_boletoacampante_inscricao");

                entity.Property(e => e.CodBoletoacampanteInscricao).HasColumnName("cod_boletoacampante_inscricao");

                entity.Property(e => e.CodBoletoacampante).HasColumnName("cod_boletoacampante");

                entity.Property(e => e.CodPagtoinscricao).HasColumnName("cod_pagtoinscricao");

                entity.HasOne(d => d.CodBoletoacampanteNavigation)
                    .WithMany(p => p.TbCadBoletoacampanteInscricao)
                    .HasForeignKey(d => d.CodBoletoacampante)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_boletoacampante_inscricao_tb_cad_boletoacampante");
            });

            modelBuilder.Entity<TbCadCamiseta>(entity =>
            {
                entity.HasKey(e => e.CodCamiseta)
                    .HasName("PK_tb_cad_camisetas");

                entity.ToTable("tb_cad_camiseta");

                entity.Property(e => e.CodCamiseta).HasColumnName("cod_camiseta");

                entity.Property(e => e.CodTipocamiseta).HasColumnName("cod_tipocamiseta");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.DesQtde).HasColumnName("des_qtde");
            });

            modelBuilder.Entity<TbCadCamisetaTemporada>(entity =>
            {
                entity.HasKey(e => e.CodCamisetaTemporada);

                entity.ToTable("tb_cad_camiseta_temporada");

                entity.HasIndex(e => new { e.CodTemporada, e.CodCamisetaTemporada })
                    .HasName("ix_tb_cad_camiseta_temporada");

                entity.Property(e => e.CodCamisetaTemporada).HasColumnName("cod_camiseta_temporada");

                entity.Property(e => e.CodCamiseta).HasColumnName("cod_camiseta");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.HasOne(d => d.CodCamisetaNavigation)
                    .WithMany(p => p.TbCadCamisetaTemporada)
                    .HasForeignKey(d => d.CodCamiseta)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_camiseta_temporada_tb_cad_camiseta");

                entity.HasOne(d => d.CodTemporadaNavigation)
                    .WithMany(p => p.TbCadCamisetaTemporada)
                    .HasForeignKey(d => d.CodTemporada)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_camiseta_temporada_tb_cad_temporada");
            });

            modelBuilder.Entity<TbCadChale>(entity =>
            {
                entity.HasKey(e => e.CodChale);

                entity.ToTable("tb_cad_chale");

                entity.HasIndex(e => new { e.CodUnidadenr, e.DesChale })
                    .HasName("UK_tb_cad_chale")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesChale, e.DesDetalhes, e.DesGenero, e.DesImagem, e.FlgAtivo, e.CodChale })
                    .HasName("sk_tb_cad_chale");

                entity.Property(e => e.CodChale).HasColumnName("cod_chale");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesChale)
                    .HasColumnName("des_chale")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesDetalhes)
                    .HasColumnName("des_detalhes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesGenero)
                    .HasColumnName("des_genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesImagem)
                    .HasColumnName("des_imagem")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumVagas).HasColumnName("num_vagas");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadChale)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_chale_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadChaleCarga>(entity =>
            {
                entity.HasKey(e => e.CodChale);

                entity.ToTable("tb_cad_chale_carga");

                entity.HasIndex(e => new { e.DesChale, e.CodUnidadenr })
                    .HasName("UK_tb_cad_chale_carga")
                    .IsUnique();

                entity.Property(e => e.CodChale).HasColumnName("cod_chale");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesChale)
                    .HasColumnName("des_chale")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesDetalhes)
                    .HasColumnName("des_detalhes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesGenero)
                    .HasColumnName("des_genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesImagem)
                    .HasColumnName("des_imagem")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumVagas).HasColumnName("num_vagas");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadChaleCarga)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_chale_carga_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadCupom>(entity =>
            {
                entity.HasKey(e => e.CodCupom);

                entity.ToTable("tb_cad_cupom");

                entity.Property(e => e.CodCupom).HasColumnName("cod_cupom");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCupom)
                    .HasColumnName("des_cupom")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesDescricao)
                    .HasColumnName("des_descricao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgModulo)
                    .HasColumnName("flg_modulo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTipo)
                    .HasColumnName("flg_tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTirounico)
                    .HasColumnName("flg_tirounico")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValCupomDinheiro)
                    .HasColumnName("val_cupom_dinheiro")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValCupomPorcentagem).HasColumnName("val_cupom_porcentagem");
            });

            modelBuilder.Entity<TbCadCupomItem>(entity =>
            {
                entity.HasKey(e => e.CodCupomItem);

                entity.ToTable("tb_cad_cupom_item");

                entity.HasIndex(e => e.DesCodCupom)
                    .HasName("UK_tb_cad_cupom_item")
                    .IsUnique();

                entity.Property(e => e.CodCupomItem).HasColumnName("cod_cupom_item");

                entity.Property(e => e.CodCupom).HasColumnName("cod_cupom");

                entity.Property(e => e.DatPago)
                    .HasColumnName("dat_pago")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatUtilizacao)
                    .HasColumnName("dat_utilizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCodCupom)
                    .HasColumnName("des_cod_cupom")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FlgPago)
                    .HasColumnName("flg_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgUtilizado)
                    .HasColumnName("flg_utilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumUtilizado).HasColumnName("num_utilizado");

                entity.HasOne(d => d.CodCupomNavigation)
                    .WithMany(p => p.TbCadCupomItem)
                    .HasForeignKey(d => d.CodCupom)
                    .HasConstraintName("FK_tb_cad_cupom_cod_cupom");
            });

            modelBuilder.Entity<TbCadCupomUtilizacao>(entity =>
            {
                entity.HasKey(e => e.CodCupomUtilizacao);

                entity.ToTable("tb_cad_cupom_utilizacao");

                entity.Property(e => e.CodCupomUtilizacao).HasColumnName("cod_cupom_utilizacao");

                entity.Property(e => e.CodCupom).HasColumnName("cod_cupom");

                entity.Property(e => e.CodCupomItem).HasColumnName("cod_cupom_item");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodReserva).HasColumnName("cod_reserva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatUtilizacao)
                    .HasColumnName("dat_utilizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FlgModulo)
                    .HasColumnName("flg_modulo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadDocumento>(entity =>
            {
                entity.HasKey(e => e.CodDocumento);

                entity.ToTable("tb_cad_documento");

                entity.HasIndex(e => new { e.DesTitulo, e.FlgAtivo, e.CodTipodoctemplate })
                    .HasName("UK_tb_cad_documento")
                    .IsUnique();

                entity.Property(e => e.CodDocumento).HasColumnName("cod_documento");

                entity.Property(e => e.CodSendgrid)
                    .HasColumnName("cod_sendgrid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipodoctemplate).HasColumnName("cod_tipodoctemplate");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCriacao)
                    .HasColumnName("dat_criacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesConteudo)
                    .HasColumnName("des_conteudo")
                    .IsUnicode(false);

                entity.Property(e => e.DesTitulo)
                    .HasColumnName("des_titulo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodTipodoctemplateNavigation)
                    .WithMany(p => p.TbCadDocumento)
                    .HasForeignKey(d => d.CodTipodoctemplate)
                    .HasConstraintName("FK_tb_cad_documento_tb_bas_tipodoctemplate");
            });

            modelBuilder.Entity<TbCadEmails>(entity =>
            {
                entity.HasKey(e => e.CodEmail);

                entity.ToTable("tb_cad_emails");

                entity.Property(e => e.CodEmail).HasColumnName("cod_email");

                entity.Property(e => e.CodFuncionalidade).HasColumnName("cod_funcionalidade");

                entity.Property(e => e.CodPacote)
                    .HasColumnName("cod_pacote")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodUnidadenr)
                    .HasColumnName("cod_unidadenr")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodUsuarioAprovacao).HasColumnName("cod_usuario_aprovacao");

                entity.Property(e => e.DatAprovacao)
                    .HasColumnName("dat_aprovacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEmail)
                    .HasColumnName("dat_email")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviar)
                    .HasColumnName("dat_enviar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnvio)
                    .HasColumnName("dat_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexos)
                    .HasColumnName("des_anexos")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DesAssunto)
                    .HasColumnName("des_assunto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesCc)
                    .HasColumnName("des_cc")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesCco)
                    .HasColumnName("des_cco")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DesMotivo)
                    .HasColumnName("des_motivo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesPara)
                    .HasColumnName("des_para")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesRemetente)
                    .HasColumnName("des_remetente")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAvaliaConteudo)
                    .HasColumnName("flg_avalia_conteudo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEmail)
                    .HasColumnName("flg_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgImpresso)
                    .HasColumnName("flg_impresso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSms)
                    .HasColumnName("flg_sms")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumTentativas).HasColumnName("num_tentativas");

                entity.HasOne(d => d.CodFuncionalidadeNavigation)
                    .WithMany(p => p.TbCadEmails)
                    .HasForeignKey(d => d.CodFuncionalidade)
                    .HasConstraintName("FK_tb_cad_emails_tb_bas_funcionalidade");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.TbCadEmails)
                    .HasForeignKey(d => d.CodUsuario)
                    .HasConstraintName("FK_tb_cad_emails_tb_cad_usuario");
            });

            modelBuilder.Entity<TbCadEmails20190626>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_emails_20190626");

                entity.Property(e => e.CodEmail)
                    .HasColumnName("cod_email")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodFuncionalidade).HasColumnName("cod_funcionalidade");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodUsuarioAprovacao).HasColumnName("cod_usuario_aprovacao");

                entity.Property(e => e.DatAprovacao)
                    .HasColumnName("dat_aprovacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEmail)
                    .HasColumnName("dat_email")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviar)
                    .HasColumnName("dat_enviar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnvio)
                    .HasColumnName("dat_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexos)
                    .HasColumnName("des_anexos")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DesAssunto)
                    .HasColumnName("des_assunto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesCc)
                    .HasColumnName("des_cc")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesCco)
                    .HasColumnName("des_cco")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DesMotivo)
                    .HasColumnName("des_motivo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesPara)
                    .HasColumnName("des_para")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesRemetente)
                    .HasColumnName("des_remetente")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAvaliaConteudo)
                    .HasColumnName("flg_avalia_conteudo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEmail)
                    .HasColumnName("flg_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgImpresso)
                    .HasColumnName("flg_impresso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSms)
                    .HasColumnName("flg_sms")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumTentativas).HasColumnName("num_tentativas");
            });

            modelBuilder.Entity<TbCadEmailsCarga>(entity =>
            {
                entity.HasKey(e => e.CodEmail);

                entity.ToTable("tb_cad_emails_carga");

                entity.Property(e => e.CodEmail).HasColumnName("cod_email");

                entity.Property(e => e.CodFuncionalidade).HasColumnName("cod_funcionalidade");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodUsuarioAprovacao).HasColumnName("cod_usuario_aprovacao");

                entity.Property(e => e.DatAprovacao)
                    .HasColumnName("dat_aprovacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEmail)
                    .HasColumnName("dat_email")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviar)
                    .HasColumnName("dat_enviar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnvio)
                    .HasColumnName("dat_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexos)
                    .HasColumnName("des_anexos")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DesAssunto)
                    .HasColumnName("des_assunto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesCc)
                    .HasColumnName("des_cc")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesCco)
                    .HasColumnName("des_cco")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DesMotivo)
                    .HasColumnName("des_motivo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesPara)
                    .HasColumnName("des_para")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesRemetente)
                    .HasColumnName("des_remetente")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAvaliaConteudo)
                    .HasColumnName("flg_avalia_conteudo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEmail)
                    .HasColumnName("flg_email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSms)
                    .HasColumnName("flg_sms")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumTentativas).HasColumnName("num_tentativas");
            });

            modelBuilder.Entity<TbCadEnquete>(entity =>
            {
                entity.HasKey(e => e.CodEnquete);

                entity.ToTable("tb_cad_enquete");

                entity.Property(e => e.CodEnquete).HasColumnName("cod_enquete");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesNomeEnquete)
                    .HasColumnName("des_nome_enquete")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgExibePortal)
                    .HasColumnName("flg_exibe_portal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadEnqueteEscolasegrupos>(entity =>
            {
                entity.HasKey(e => e.CodEnqueteEscolasegrupos);

                entity.ToTable("tb_cad_enquete_escolasegrupos");

                entity.Property(e => e.CodEnqueteEscolasegrupos).HasColumnName("cod_enquete_escolasegrupos");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatFinal)
                    .HasColumnName("dat_final")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEnquete)
                    .HasColumnName("des_enquete")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgExibePortal)
                    .HasColumnName("flg_exibe_portal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadEnquetetemporada>(entity =>
            {
                entity.HasKey(e => e.CodEnquetetemporada);

                entity.ToTable("tb_cad_enquetetemporada");

                entity.Property(e => e.CodEnquetetemporada).HasColumnName("cod_enquetetemporada");

                entity.Property(e => e.CodEnquete).HasColumnName("cod_enquete");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.HasOne(d => d.CodEnqueteNavigation)
                    .WithMany(p => p.TbCadEnquetetemporada)
                    .HasForeignKey(d => d.CodEnquete)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_enquetetemporada_tb_cad_enquete");

                entity.HasOne(d => d.CodTemporadaNavigation)
                    .WithMany(p => p.TbCadEnquetetemporada)
                    .HasForeignKey(d => d.CodTemporada)
                    .HasConstraintName("FK_tb_cad_enquetetemporada_tb_cad_temporada");
            });

            modelBuilder.Entity<TbCadEscBoleto>(entity =>
            {
                entity.HasKey(e => e.CodEscBoleto);

                entity.ToTable("tb_cad_esc_boleto");

                entity.Property(e => e.CodEscBoleto).HasColumnName("cod_esc_boleto");

                entity.Property(e => e.CodEscPagamento).HasColumnName("cod_esc_pagamento");

                entity.Property(e => e.CodRemessa).HasColumnName("cod_remessa");

                entity.Property(e => e.CodRetorno).HasColumnName("cod_retorno");

                entity.Property(e => e.DatDocumento)
                    .HasColumnName("dat_documento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatVencimento)
                    .HasColumnName("dat_vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesCedente)
                    .HasColumnName("des_cedente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteBairro)
                    .HasColumnName("des_cliente_bairro")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteCep)
                    .HasColumnName("des_cliente_cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteCidade)
                    .HasColumnName("des_cliente_cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteCpfCnpj)
                    .HasColumnName("des_cliente_cpf_cnpj")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteEndereco)
                    .HasColumnName("des_cliente_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteEnderecoComp)
                    .HasColumnName("des_cliente_endereco_comp")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteEstado)
                    .HasColumnName("des_cliente_estado")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DesClienteNome)
                    .HasColumnName("des_cliente_nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstrucaocaixa)
                    .HasColumnName("des_instrucaocaixa")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstrucaocliente)
                    .HasColumnName("des_instrucaocliente")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesPdf)
                    .HasColumnName("des_pdf")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NumAgenciaCodcedente)
                    .HasColumnName("num_agencia_codcedente")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCarteira)
                    .HasColumnName("num_carteira")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumCarteiraCompleto)
                    .HasColumnName("num_carteira_completo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumContrato)
                    .HasColumnName("num_contrato")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("num_documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumLinhadigitavel)
                    .HasColumnName("num_linhadigitavel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumNossonumero)
                    .HasColumnName("num_nossonumero")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumVariacaocarteira)
                    .HasColumnName("num_variacaocarteira")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValCobrado)
                    .HasColumnName("val_cobrado")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValDesconto)
                    .HasColumnName("val_desconto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValDocumento)
                    .HasColumnName("val_documento")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValMulta)
                    .HasColumnName("val_multa")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValOutrasdeducoes)
                    .HasColumnName("val_outrasdeducoes")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValOutrosacrescimos)
                    .HasColumnName("val_outrosacrescimos")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodEscPagamentoNavigation)
                    .WithMany(p => p.TbCadEscBoleto)
                    .HasForeignKey(d => d.CodEscPagamento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_esc_pagamento");
            });

            modelBuilder.Entity<TbCadEscCategoria>(entity =>
            {
                entity.HasKey(e => e.CodEscCategoria);

                entity.ToTable("tb_cad_esc_categoria");

                entity.Property(e => e.CodEscCategoria).HasColumnName("cod_esc_categoria");

                entity.Property(e => e.CodCategoriaSistema).HasColumnName("cod_categoria_sistema");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCategoria)
                    .HasColumnName("des_categoria")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadEscEvento>(entity =>
            {
                entity.HasKey(e => e.CodEscEvento);

                entity.ToTable("tb_cad_esc_evento");

                entity.Property(e => e.CodEscEvento).HasColumnName("cod_esc_evento");

                entity.Property(e => e.AnoParcelamento).HasColumnName("ano_parcelamento");

                entity.Property(e => e.AnoParcelamentoFixo).HasColumnName("ano_parcelamento_fixo");

                entity.Property(e => e.AnoParcelamentoRegressivo).HasColumnName("ano_parcelamento_regressivo");

                entity.Property(e => e.CodEscUrl)
                    .HasColumnName("cod_esc_url")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtivar)
                    .HasColumnName("dat_ativar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("dat_entrada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexoOrganizadores)
                    .HasColumnName("des_anexo_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesCorpoemailOrganizadores)
                    .HasColumnName("des_corpoemail_organizadores")
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .HasColumnName("des_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImgQrcode)
                    .HasColumnName("des_img_qrcode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoesAdicionais)
                    .HasColumnName("des_informacoes_adicionais")
                    .IsUnicode(false);

                entity.Property(e => e.DesOrganizadores)
                    .HasColumnName("des_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTemplate)
                    .HasColumnName("des_template")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAppCelular)
                    .HasColumnName("flg_app_celular")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivar)
                    .HasColumnName("flg_ativar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBloquear)
                    .HasColumnName("flg_bloquear")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCupom)
                    .HasColumnName("flg_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnvioOrganizadores)
                    .HasColumnName("flg_envio_organizadores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeBoleto)
                    .HasColumnName("flg_exibe_boleto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeCartao)
                    .HasColumnName("flg_exibe_cartao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MesParcelamento).HasColumnName("mes_parcelamento");

                entity.Property(e => e.MesParcelamentoFixo).HasColumnName("mes_parcelamento_fixo");

                entity.Property(e => e.MesParcelamentoRegressivo).HasColumnName("mes_parcelamento_regressivo");

                entity.Property(e => e.NumTotalVagas).HasColumnName("num_total_vagas");

                entity.Property(e => e.QtdBloquearDia).HasColumnName("qtd_bloquear_dia");

                entity.Property(e => e.QtdParcelamento).HasColumnName("qtd_parcelamento");

                entity.Property(e => e.QtdParcelamentoFixo).HasColumnName("qtd_parcelamento_fixo");

                entity.Property(e => e.QtdParcelamentoRegressivo).HasColumnName("qtd_parcelamento_regressivo");

                entity.Property(e => e.ValBoleto)
                    .HasColumnName("val_boleto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValEscola)
                    .HasColumnName("val_escola")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValNr)
                    .HasColumnName("val_nr")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadEscEvento2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_esc_evento_2");

                entity.Property(e => e.AnoParcelamento).HasColumnName("ano_parcelamento");

                entity.Property(e => e.AnoParcelamentoFixo).HasColumnName("ano_parcelamento_fixo");

                entity.Property(e => e.AnoParcelamentoRegressivo).HasColumnName("ano_parcelamento_regressivo");

                entity.Property(e => e.CodEscEvento)
                    .HasColumnName("cod_esc_evento")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodEscUrl)
                    .HasColumnName("cod_esc_url")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtivar)
                    .HasColumnName("dat_ativar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("dat_entrada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexoOrganizadores)
                    .HasColumnName("des_anexo_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesCorpoemailOrganizadores)
                    .HasColumnName("des_corpoemail_organizadores")
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .HasColumnName("des_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImgQrcode)
                    .HasColumnName("des_img_qrcode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoesAdicionais)
                    .HasColumnName("des_informacoes_adicionais")
                    .IsUnicode(false);

                entity.Property(e => e.DesOrganizadores)
                    .HasColumnName("des_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTemplate)
                    .HasColumnName("des_template")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAppCelular)
                    .HasColumnName("flg_app_celular")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivar)
                    .HasColumnName("flg_ativar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBloquear)
                    .HasColumnName("flg_bloquear")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCupom)
                    .HasColumnName("flg_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnvioOrganizadores)
                    .HasColumnName("flg_envio_organizadores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeBoleto)
                    .HasColumnName("flg_exibe_boleto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeCartao)
                    .HasColumnName("flg_exibe_cartao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MesParcelamento).HasColumnName("mes_parcelamento");

                entity.Property(e => e.MesParcelamentoFixo).HasColumnName("mes_parcelamento_fixo");

                entity.Property(e => e.MesParcelamentoRegressivo).HasColumnName("mes_parcelamento_regressivo");

                entity.Property(e => e.NumTotalVagas).HasColumnName("num_total_vagas");

                entity.Property(e => e.QtdBloquearDia).HasColumnName("qtd_bloquear_dia");

                entity.Property(e => e.QtdParcelamento).HasColumnName("qtd_parcelamento");

                entity.Property(e => e.QtdParcelamentoFixo).HasColumnName("qtd_parcelamento_fixo");

                entity.Property(e => e.QtdParcelamentoRegressivo).HasColumnName("qtd_parcelamento_regressivo");

                entity.Property(e => e.ValBoleto)
                    .HasColumnName("val_boleto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValEscola)
                    .HasColumnName("val_escola")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValNr)
                    .HasColumnName("val_nr")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadEscEventoAntiga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_esc_evento_ANTIGA");

                entity.Property(e => e.AnoParcelamento).HasColumnName("ano_parcelamento");

                entity.Property(e => e.AnoParcelamentoFixo).HasColumnName("ano_parcelamento_fixo");

                entity.Property(e => e.AnoParcelamentoRegressivo).HasColumnName("ano_parcelamento_regressivo");

                entity.Property(e => e.CodEscEvento)
                    .HasColumnName("cod_esc_evento")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodEscUrl)
                    .HasColumnName("cod_esc_url")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtivar)
                    .HasColumnName("dat_ativar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("dat_entrada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexoOrganizadores)
                    .HasColumnName("des_anexo_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesCorpoemailOrganizadores)
                    .HasColumnName("des_corpoemail_organizadores")
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .HasColumnName("des_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImgQrcode)
                    .HasColumnName("des_img_qrcode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoesAdicionais)
                    .HasColumnName("des_informacoes_adicionais")
                    .IsUnicode(false);

                entity.Property(e => e.DesOrganizadores)
                    .HasColumnName("des_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTemplate)
                    .HasColumnName("des_template")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAppCelular)
                    .HasColumnName("flg_app_celular")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivar)
                    .HasColumnName("flg_ativar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBloquear)
                    .HasColumnName("flg_bloquear")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCupom)
                    .HasColumnName("flg_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnvioOrganizadores)
                    .HasColumnName("flg_envio_organizadores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeBoleto)
                    .HasColumnName("flg_exibe_boleto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeCartao)
                    .HasColumnName("flg_exibe_cartao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MesParcelamento).HasColumnName("mes_parcelamento");

                entity.Property(e => e.MesParcelamentoFixo).HasColumnName("mes_parcelamento_fixo");

                entity.Property(e => e.MesParcelamentoRegressivo).HasColumnName("mes_parcelamento_regressivo");

                entity.Property(e => e.NumTotalVagas).HasColumnName("num_total_vagas");

                entity.Property(e => e.QtdBloquearDia).HasColumnName("qtd_bloquear_dia");

                entity.Property(e => e.QtdParcelamento).HasColumnName("qtd_parcelamento");

                entity.Property(e => e.QtdParcelamentoFixo).HasColumnName("qtd_parcelamento_fixo");

                entity.Property(e => e.QtdParcelamentoRegressivo).HasColumnName("qtd_parcelamento_regressivo");

                entity.Property(e => e.ValBoleto)
                    .HasColumnName("val_boleto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValEscola)
                    .HasColumnName("val_escola")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValNr)
                    .HasColumnName("val_nr")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadEscEventoBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_CAD_ESC_EVENTO_BACKUP");

                entity.Property(e => e.AnoParcelamento).HasColumnName("ano_parcelamento");

                entity.Property(e => e.AnoParcelamentoFixo).HasColumnName("ano_parcelamento_fixo");

                entity.Property(e => e.AnoParcelamentoRegressivo).HasColumnName("ano_parcelamento_regressivo");

                entity.Property(e => e.CodEscEvento)
                    .HasColumnName("cod_esc_evento")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtivar)
                    .HasColumnName("dat_ativar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("dat_entrada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexoOrganizadores)
                    .HasColumnName("des_anexo_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesCorpoemailOrganizadores)
                    .HasColumnName("des_corpoemail_organizadores")
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .HasColumnName("des_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoesAdicionais)
                    .HasColumnName("des_informacoes_adicionais")
                    .IsUnicode(false);

                entity.Property(e => e.DesOrganizadores)
                    .HasColumnName("des_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivar)
                    .HasColumnName("flg_ativar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBloquear)
                    .HasColumnName("flg_bloquear")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnvioOrganizadores)
                    .HasColumnName("flg_envio_organizadores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MesParcelamento).HasColumnName("mes_parcelamento");

                entity.Property(e => e.MesParcelamentoFixo).HasColumnName("mes_parcelamento_fixo");

                entity.Property(e => e.MesParcelamentoRegressivo).HasColumnName("mes_parcelamento_regressivo");

                entity.Property(e => e.NumTotalVagas).HasColumnName("num_total_vagas");

                entity.Property(e => e.QtdBloquearDia).HasColumnName("qtd_bloquear_dia");

                entity.Property(e => e.QtdParcelamento).HasColumnName("qtd_parcelamento");

                entity.Property(e => e.QtdParcelamentoFixo).HasColumnName("qtd_parcelamento_fixo");

                entity.Property(e => e.QtdParcelamentoRegressivo).HasColumnName("qtd_parcelamento_regressivo");

                entity.Property(e => e.ValEscola)
                    .HasColumnName("val_escola")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValNr)
                    .HasColumnName("val_nr")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadEscEventoNova>(entity =>
            {
                entity.HasKey(e => e.CodEscEvento)
                    .HasName("PK_tb_cad_esc_evento_2");

                entity.ToTable("tb_cad_esc_evento_nova");

                entity.Property(e => e.CodEscEvento).HasColumnName("cod_esc_evento");

                entity.Property(e => e.AnoParcelamento).HasColumnName("ano_parcelamento");

                entity.Property(e => e.AnoParcelamentoFixo).HasColumnName("ano_parcelamento_fixo");

                entity.Property(e => e.AnoParcelamentoRegressivo).HasColumnName("ano_parcelamento_regressivo");

                entity.Property(e => e.CodEscUrl)
                    .HasColumnName("cod_esc_url")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtivar)
                    .HasColumnName("dat_ativar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("dat_entrada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexoOrganizadores)
                    .HasColumnName("des_anexo_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesCorpoemailOrganizadores)
                    .HasColumnName("des_corpoemail_organizadores")
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .HasColumnName("des_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImgQrcode)
                    .HasColumnName("des_img_qrcode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoesAdicionais)
                    .HasColumnName("des_informacoes_adicionais")
                    .IsUnicode(false);

                entity.Property(e => e.DesOrganizadores)
                    .HasColumnName("des_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTemplate)
                    .HasColumnName("des_template")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAppCelular)
                    .HasColumnName("flg_app_celular")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivar)
                    .HasColumnName("flg_ativar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBloquear)
                    .HasColumnName("flg_bloquear")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCupom)
                    .HasColumnName("flg_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnvioOrganizadores)
                    .HasColumnName("flg_envio_organizadores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeBoleto)
                    .HasColumnName("flg_exibe_boleto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeCartao)
                    .HasColumnName("flg_exibe_cartao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MesParcelamento).HasColumnName("mes_parcelamento");

                entity.Property(e => e.MesParcelamentoFixo).HasColumnName("mes_parcelamento_fixo");

                entity.Property(e => e.MesParcelamentoRegressivo).HasColumnName("mes_parcelamento_regressivo");

                entity.Property(e => e.NumTotalVagas).HasColumnName("num_total_vagas");

                entity.Property(e => e.QtdBloquearDia).HasColumnName("qtd_bloquear_dia");

                entity.Property(e => e.QtdParcelamento).HasColumnName("qtd_parcelamento");

                entity.Property(e => e.QtdParcelamentoFixo).HasColumnName("qtd_parcelamento_fixo");

                entity.Property(e => e.QtdParcelamentoRegressivo).HasColumnName("qtd_parcelamento_regressivo");

                entity.Property(e => e.ValBoleto)
                    .HasColumnName("val_boleto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValEscola)
                    .HasColumnName("val_escola")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValNr)
                    .HasColumnName("val_nr")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadEscPagamento>(entity =>
            {
                entity.HasKey(e => e.CodEscPagamento);

                entity.ToTable("tb_cad_esc_pagamento");

                entity.Property(e => e.CodEscPagamento).HasColumnName("cod_esc_pagamento");

                entity.Property(e => e.CodCupomItem).HasColumnName("cod_cupom_item");

                entity.Property(e => e.CodEscAluno).HasColumnName("cod_esc_aluno");

                entity.Property(e => e.CodEscResponsavel).HasColumnName("cod_esc_responsavel");

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPagto)
                    .HasColumnName("dat_pagto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatUtilizacaoCupom)
                    .HasColumnName("dat_utilizacao_cupom")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesDetalhes)
                    .HasColumnName("des_detalhes")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAproi)
                    .HasColumnName("flg_aproi")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBoleto)
                    .HasColumnName("flg_boleto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgDiferenca)
                    .HasColumnName("flg_diferenca")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgGateway)
                    .HasColumnName("flg_gateway")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgGateway2)
                    .HasColumnName("flg_gateway2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCartao)
                    .HasColumnName("num_cartao")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCartao2)
                    .HasColumnName("num_cartao2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumNsu)
                    .HasColumnName("num_nsu")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumNsu2)
                    .HasColumnName("num_nsu2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumParcela).HasColumnName("num_parcela");

                entity.Property(e => e.NumParcela2).HasColumnName("num_parcela2");

                entity.Property(e => e.NumTid)
                    .HasColumnName("num_tid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumTid2)
                    .HasColumnName("num_tid2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumTransacao)
                    .HasColumnName("num_transacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTransacao2)
                    .HasColumnName("num_transacao2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValAproi)
                    .HasColumnName("val_aproi")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValCartao1)
                    .HasColumnName("val_cartao1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValCartao2)
                    .HasColumnName("val_cartao2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValParcela)
                    .HasColumnName("val_parcela")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValParcela2)
                    .HasColumnName("val_parcela2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTotal)
                    .HasColumnName("val_total")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodCupomItemNavigation)
                    .WithMany(p => p.TbCadEscPagamento)
                    .HasForeignKey(d => d.CodCupomItem)
                    .HasConstraintName("FK_tb_cad_esc_pagamento_cod_cupom_item");

                entity.HasOne(d => d.CodEscAlunoNavigation)
                    .WithMany(p => p.TbCadEscPagamentoCodEscAlunoNavigation)
                    .HasForeignKey(d => d.CodEscAluno)
                    .HasConstraintName("FK_tb_cad_esc_pagamento_tb_cad_esc_aluno");

                entity.HasOne(d => d.CodEscResponsavelNavigation)
                    .WithMany(p => p.TbCadEscPagamentoCodEscResponsavelNavigation)
                    .HasForeignKey(d => d.CodEscResponsavel)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_esc_pagamento_tb_cad_esc_responsavel");
            });

            modelBuilder.Entity<TbCadEscPessoa>(entity =>
            {
                entity.HasKey(e => e.CodEscPessoa);

                entity.ToTable("tb_cad_esc_pessoa");

                entity.Property(e => e.CodEscPessoa).HasColumnName("cod_esc_pessoa");

                entity.Property(e => e.CodCategoriaSistema).HasColumnName("cod_categoria_sistema");

                entity.Property(e => e.CodSexo)
                    .HasColumnName("cod_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatNascto)
                    .HasColumnName("dat_nascto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCodigoAcesso)
                    .HasColumnName("des_codigo_acesso")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNumero)
                    .HasColumnName("des_numero")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivoSistema)
                    .HasColumnName("flg_ativo_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoa)
                    .HasColumnName("nom_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumCpf)
                    .HasColumnName("num_cpf")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRg)
                    .HasColumnName("num_rg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneCelular)
                    .HasColumnName("num_telefone_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneComercial)
                    .HasColumnName("num_telefone_comercial")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneResidencial)
                    .HasColumnName("num_telefone_residencial")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadEscPessoa2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_esc_pessoa_2");

                entity.Property(e => e.CodCategoriaSistema).HasColumnName("cod_categoria_sistema");

                entity.Property(e => e.CodEscPessoa)
                    .HasColumnName("cod_esc_pessoa")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodSexo)
                    .HasColumnName("cod_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatNascto)
                    .HasColumnName("dat_nascto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCodigoAcesso)
                    .HasColumnName("des_codigo_acesso")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNumero)
                    .HasColumnName("des_numero")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivoSistema)
                    .HasColumnName("flg_ativo_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoa)
                    .HasColumnName("nom_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumCpf)
                    .HasColumnName("num_cpf")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRg)
                    .HasColumnName("num_rg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneCelular)
                    .HasColumnName("num_telefone_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneComercial)
                    .HasColumnName("num_telefone_comercial")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneResidencial)
                    .HasColumnName("num_telefone_residencial")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadEscPessoaFormacao>(entity =>
            {
                entity.HasKey(e => e.CodEscPessoaFormacao);

                entity.ToTable("tb_cad_esc_pessoa_formacao");

                entity.Property(e => e.CodEscPessoaFormacao).HasColumnName("cod_esc_pessoa_formacao");

                entity.Property(e => e.CodEscPessoa).HasColumnName("cod_esc_pessoa");

                entity.Property(e => e.CodSerie).HasColumnName("cod_serie");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesSerieOutro)
                    .HasColumnName("des_serie_outro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesTurma)
                    .HasColumnName("des_turma")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadEscPessoaNova>(entity =>
            {
                entity.HasKey(e => e.CodEscPessoa);

                entity.ToTable("tb_cad_esc_pessoa_nova");

                entity.Property(e => e.CodEscPessoa).HasColumnName("cod_esc_pessoa");

                entity.Property(e => e.CodCategoriaSistema).HasColumnName("cod_categoria_sistema");

                entity.Property(e => e.CodSexo)
                    .HasColumnName("cod_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatNascto)
                    .HasColumnName("dat_nascto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCodigoAcesso)
                    .HasColumnName("des_codigo_acesso")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNumero)
                    .HasColumnName("des_numero")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivoSistema)
                    .HasColumnName("flg_ativo_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoa)
                    .HasColumnName("nom_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumCpf)
                    .HasColumnName("num_cpf")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRg)
                    .HasColumnName("num_rg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneCelular)
                    .HasColumnName("num_telefone_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneComercial)
                    .HasColumnName("num_telefone_comercial")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefoneResidencial)
                    .HasColumnName("num_telefone_residencial")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadEscSapiens>(entity =>
            {
                entity.HasKey(e => e.CodEscSapiens);

                entity.ToTable("tb_cad_esc_sapiens");

                entity.Property(e => e.CodEscSapiens).HasColumnName("cod_esc_sapiens");

                entity.Property(e => e.CodEscPagamento).HasColumnName("cod_esc_pagamento");

                entity.Property(e => e.DatEnvio)
                    .HasColumnName("dat_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatParcela)
                    .HasColumnName("dat_parcela")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmitente)
                    .HasColumnName("des_emitente")
                    .IsUnicode(false);

                entity.Property(e => e.DesRetorno)
                    .HasColumnName("des_retorno")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRetornoSapiens)
                    .HasColumnName("des_retorno_sapiens")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCat)
                    .HasColumnName("num_cat")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumNsu)
                    .HasColumnName("num_nsu")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumParcela).HasColumnName("num_parcela");

                entity.Property(e => e.NumTid)
                    .HasColumnName("num_tid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumTitulo)
                    .HasColumnName("num_titulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValParcela)
                    .HasColumnName("val_parcela")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadEscVinculo>(entity =>
            {
                entity.HasKey(e => e.CodEscVinculo);

                entity.ToTable("tb_cad_esc_vinculo");

                entity.Property(e => e.CodEscVinculo).HasColumnName("cod_esc_vinculo");

                entity.Property(e => e.CodEscPessoa).HasColumnName("cod_esc_pessoa");

                entity.Property(e => e.CodEscPessoaDep).HasColumnName("cod_esc_pessoa_dep");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodGrauparentescoDep).HasColumnName("cod_grauparentesco_dep");

                entity.HasOne(d => d.CodEscPessoaNavigation)
                    .WithMany(p => p.TbCadEscVinculo)
                    .HasForeignKey(d => d.CodEscPessoa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_esc_vinculo_tb_cad_esc_pessoa");

                entity.HasOne(d => d.CodGrauparentescoNavigation)
                    .WithMany(p => p.TbCadEscVinculo)
                    .HasForeignKey(d => d.CodGrauparentesco)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_esc_vinculo_tb_bas_grauparentesco");
            });

            modelBuilder.Entity<TbCadEscVinculo20170207>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_esc_vinculo_20170207");

                entity.Property(e => e.CodEscPessoa).HasColumnName("cod_esc_pessoa");

                entity.Property(e => e.CodEscPessoaDep).HasColumnName("cod_esc_pessoa_dep");

                entity.Property(e => e.CodEscVinculo)
                    .HasColumnName("cod_esc_vinculo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodGrauparentescoDep).HasColumnName("cod_grauparentesco_dep");
            });

            modelBuilder.Entity<TbCadEscVinculo20170210>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_esc_vinculo_20170210");

                entity.Property(e => e.CodEscPessoa).HasColumnName("cod_esc_pessoa");

                entity.Property(e => e.CodEscPessoaDep).HasColumnName("cod_esc_pessoa_dep");

                entity.Property(e => e.CodEscVinculo)
                    .HasColumnName("cod_esc_vinculo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodGrauparentescoDep).HasColumnName("cod_grauparentesco_dep");
            });

            modelBuilder.Entity<TbCadEscola>(entity =>
            {
                entity.HasKey(e => e.CodEscola);

                entity.ToTable("tb_cad_escola");

                entity.HasIndex(e => new { e.NomEscola, e.NomFantasia, e.DesLogradouro, e.FlgOrigemcadastro, e.CodEscola })
                    .HasName("sk_tb_cad_escola");

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodPais).HasColumnName("cod_pais");

                entity.Property(e => e.CodTipoescola).HasColumnName("cod_tipoescola");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCnpj)
                    .HasColumnName("des_cnpj")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesContatoCelular)
                    .HasColumnName("des_contato_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesDdd)
                    .HasColumnName("des_ddd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesDddCelular)
                    .HasColumnName("des_ddd_celular")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouroNumero)
                    .HasColumnName("des_logradouro_numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesSite)
                    .HasColumnName("des_site")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgOrigemcadastro)
                    .IsRequired()
                    .HasColumnName("flg_origemcadastro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEscola)
                    .HasColumnName("nom_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomFantasia)
                    .HasColumnName("nom_fantasia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumCelular)
                    .HasColumnName("num_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefone)
                    .HasColumnName("num_telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPaisNavigation)
                    .WithMany(p => p.TbCadEscola)
                    .HasForeignKey(d => d.CodPais)
                    .HasConstraintName("FK_tb_cad_escola_tb_bas_pais");

                entity.HasOne(d => d.CodTipoescolaNavigation)
                    .WithMany(p => p.TbCadEscola)
                    .HasForeignKey(d => d.CodTipoescola)
                    .HasConstraintName("FK_tb_cad_escola_tb_bas_tipoescola");
            });

            modelBuilder.Entity<TbCadEscolacontato>(entity =>
            {
                entity.HasKey(e => e.CodEscolacontato);

                entity.ToTable("tb_cad_escolacontato");

                entity.HasIndex(e => new { e.NomContato, e.DatAniversario, e.CodEscolacontato })
                    .HasName("sk_tb_cad_escolacontato");

                entity.Property(e => e.CodEscolacontato).HasColumnName("cod_escolacontato");

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAniversario)
                    .HasColumnName("dat_aniversario")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCargo)
                    .HasColumnName("des_cargo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCelular)
                    .HasColumnName("des_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesDdd)
                    .HasColumnName("des_ddd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesDddCelular)
                    .HasColumnName("des_ddd_celular")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInfoadicionais)
                    .HasColumnName("des_infoadicionais")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone)
                    .HasColumnName("des_telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomContato)
                    .HasColumnName("nom_contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodEscolaNavigation)
                    .WithMany(p => p.TbCadEscolacontato)
                    .HasForeignKey(d => d.CodEscola)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_escolacontato_tb_cad_escola");
            });

            modelBuilder.Entity<TbCadEscolaendereco>(entity =>
            {
                entity.HasKey(e => e.CodEscolaendereco)
                    .HasName("PK_tb_cad_escolaendereco");

                entity.ToTable("tb_cad_escolaendereco");

                entity.HasIndex(e => new { e.DesLogradouro, e.CodEscolaendereco })
                    .HasName("sk_tb_cad_escolaendereco");

                entity.Property(e => e.CodEscolaendereco).HasColumnName("cod_escolaendereco");

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodPais).HasColumnName("cod_pais");

                entity.Property(e => e.CodTipoendereco).HasColumnName("cod_tipoendereco");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouroNumero)
                    .HasColumnName("des_logradouro_numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodEscolaNavigation)
                    .WithMany(p => p.TbCadEscolaendereco)
                    .HasForeignKey(d => d.CodEscola)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_escolaendereco_tb_cad_escola");

                entity.HasOne(d => d.CodPaisNavigation)
                    .WithMany(p => p.TbCadEscolaendereco)
                    .HasForeignKey(d => d.CodPais)
                    .HasConstraintName("FK_tb_cad_escolaendereco_tb_bas_pais");

                entity.HasOne(d => d.CodTipoenderecoNavigation)
                    .WithMany(p => p.TbCadEscolaendereco)
                    .HasForeignKey(d => d.CodTipoendereco)
                    .HasConstraintName("FK_tb_cad_escolaendereco_tb_bas_tipoendereco");
            });

            modelBuilder.Entity<TbCadEvento>(entity =>
            {
                entity.HasKey(e => e.CodEvento);

                entity.ToTable("tb_cad_evento");

                entity.Property(e => e.CodEvento).HasColumnName("cod_evento");

                entity.Property(e => e.CodTipoevento)
                    .HasColumnName("cod_tipoevento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoes)
                    .HasColumnName("des_informacoes")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesQtdemax).HasColumnName("des_qtdemax");

                entity.Property(e => e.DesQtdemin).HasColumnName("des_qtdemin");

                entity.Property(e => e.DesSeries)
                    .HasColumnName("des_series")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadExcecaoIdAcampante>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_excecao_id_acampante");

                entity.Property(e => e.CodExcecao)
                    .HasColumnName("cod_excecao")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodPessoaidacampante).HasColumnName("cod_pessoaidacampante");

                entity.Property(e => e.DigitoUtilizado).HasColumnName("digito_utilizado");
            });

            modelBuilder.Entity<TbCadFilaSms>(entity =>
            {
                entity.HasKey(e => e.CodFilaSms);

                entity.ToTable("tb_cad_fila_sms");

                entity.Property(e => e.CodFilaSms).HasColumnName("cod_fila_sms");

                entity.Property(e => e.DatAgendadoEnvio)
                    .HasColumnName("dat_agendado_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviado)
                    .HasColumnName("dat_enviado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatMensagemErro)
                    .HasColumnName("dat_mensagem_erro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagemErro)
                    .HasColumnName("des_mensagem_erro")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesOperadora)
                    .HasColumnName("des_operadora")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesSistema)
                    .HasColumnName("des_sistema")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlgEnviado)
                    .HasColumnName("flg_enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCelular)
                    .HasColumnName("num_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadFormulario>(entity =>
            {
                entity.HasKey(e => e.CodFormulario);

                entity.ToTable("tb_cad_formulario");

                entity.HasIndex(e => new { e.NomFormulario, e.CodFormulario })
                    .HasName("sk_tb_cad_formulario");

                entity.HasIndex(e => new { e.NomFormulario, e.CodUnidadenr })
                    .HasName("UK_tb_cad_formulario")
                    .IsUnique();

                entity.Property(e => e.CodFormulario).HasColumnName("cod_formulario");

                entity.Property(e => e.CodFormularioFuncionalidade).HasColumnName("cod_formulario_funcionalidade");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesExplicacao)
                    .HasColumnName("des_explicacao")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesTempomaximo).HasColumnName("des_tempomaximo");

                entity.Property(e => e.DesTermoAutorizacao)
                    .HasColumnName("des_termo_autorizacao")
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCancelar)
                    .HasColumnName("flg_cancelar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTermoAutorizacao)
                    .HasColumnName("flg_termo_autorizacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomFormulario)
                    .HasColumnName("nom_formulario")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodFormularioFuncionalidadeNavigation)
                    .WithMany(p => p.TbCadFormulario)
                    .HasForeignKey(d => d.CodFormularioFuncionalidade)
                    .HasConstraintName("FK_tb_cad_formulario_tb_bas_formulario_funcionalidade");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadFormulario)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_formulario_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadInscricao>(entity =>
            {
                entity.HasKey(e => e.CodInscricao);

                entity.ToTable("tb_cad_inscricao");

                entity.HasIndex(e => new { e.CodPessoa, e.FlgStatus })
                    .HasName("sk_cod_pessoa_flg_status");

                entity.Property(e => e.CodInscricao).HasColumnName("cod_inscricao");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoaCobranca).HasColumnName("cod_pessoa_cobranca");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodUsuarioInterrompido).HasColumnName("cod_usuario_interrompido");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatConfirmacao)
                    .HasColumnName("dat_confirmacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatContrato)
                    .HasColumnName("dat_contrato")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnvioSapiens)
                    .HasColumnName("dat_envio_sapiens")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicioInterrompido)
                    .HasColumnName("dat_inicio_interrompido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInscricao)
                    .HasColumnName("dat_inscricao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInterrompido)
                    .HasColumnName("dat_interrompido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacaoInterrompido)
                    .HasColumnName("des_informacao_interrompido")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesMotivoInterrompido)
                    .HasColumnName("des_motivo_interrompido")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenhaturmanr)
                    .HasColumnName("des_senhaturmanr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmailRespAlt)
                    .HasColumnName("email_resp_alt")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAutorizacaoCobranca)
                    .HasColumnName("flg_autorizacao_cobranca")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgInterrompido)
                    .HasColumnName("flg_interrompido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgLiberacaoTurmanr)
                    .HasColumnName("flg_liberacao_turmanr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgRepresentante)
                    .HasColumnName("flg_representante")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSapiens)
                    .HasColumnName("flg_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoaAlt)
                    .HasColumnName("nom_pessoa_alt")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumPedSapiens).HasColumnName("num_ped_sapiens");

                entity.Property(e => e.NumTentativasCielo)
                    .HasColumnName("num_tentativas_cielo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentAlt)
                    .HasColumnName("parent_alt")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadInscricao)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_inscricao_tb_cad_pessoapapelreserva");

                entity.HasOne(d => d.CodRepresentanteNavigation)
                    .WithMany(p => p.TbCadInscricao)
                    .HasForeignKey(d => d.CodRepresentante)
                    .HasConstraintName("FK_tb_cad_inscricao_tb_cad_representante");
            });

            modelBuilder.Entity<TbCadInscricaoCarga>(entity =>
            {
                entity.HasKey(e => e.CodInscricao);

                entity.ToTable("tb_cad_inscricao_carga");

                entity.Property(e => e.CodInscricao).HasColumnName("cod_inscricao");

                entity.Property(e => e.CodMeiotransporteIda).HasColumnName("cod_meiotransporte_ida");

                entity.Property(e => e.CodMeiotransporteVolta).HasColumnName("cod_meiotransporte_volta");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoaCobranca).HasColumnName("cod_pessoa_cobranca");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatConfirmacao)
                    .HasColumnName("dat_confirmacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInscricao)
                    .HasColumnName("dat_inscricao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesObsTransporteida)
                    .HasColumnName("des_obs_transporteida")
                    .IsUnicode(false);

                entity.Property(e => e.DesObsTransportevolta)
                    .HasColumnName("des_obs_transportevolta")
                    .IsUnicode(false);

                entity.Property(e => e.DesSenhaturmanr)
                    .HasColumnName("des_senhaturmanr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlgLiberacaoTurmanr)
                    .HasColumnName("flg_liberacao_turmanr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgRepresentante)
                    .HasColumnName("flg_representante")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadInscricaoCarga)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_inscricao_carga_tb_cad_pessoapapelreserva");

                entity.HasOne(d => d.CodRepresentanteNavigation)
                    .WithMany(p => p.TbCadInscricaoCarga)
                    .HasForeignKey(d => d.CodRepresentante)
                    .HasConstraintName("FK_tb_cad_inscricao_carga_tb_cad_representante");
            });

            modelBuilder.Entity<TbCadItemformulario>(entity =>
            {
                entity.HasKey(e => e.CodItemformulario);

                entity.ToTable("tb_cad_itemformulario");

                entity.HasIndex(e => new { e.DesPergunta, e.DesParametros, e.FlgTipo, e.FlgObservacoes, e.CodItemformulario })
                    .HasName("sk_tb_cad_itemformulario");

                entity.Property(e => e.CodItemformulario).HasColumnName("cod_itemformulario");

                entity.Property(e => e.CodFormulario).HasColumnName("cod_formulario");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesExplicacao)
                    .HasColumnName("des_explicacao")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DesOrdem).HasColumnName("des_ordem");

                entity.Property(e => e.DesParametros)
                    .HasColumnName("des_parametros")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DesPergunta)
                    .HasColumnName("des_pergunta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgObservacoes)
                    .HasColumnName("flg_observacoes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgOrientacao)
                    .HasColumnName("flg_orientacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTamanho)
                    .HasColumnName("flg_tamanho")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTipo)
                    .HasColumnName("flg_tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodFormularioNavigation)
                    .WithMany(p => p.TbCadItemformulario)
                    .HasForeignKey(d => d.CodFormulario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_itemformulario_tb_cad_formulario");
            });

            modelBuilder.Entity<TbCadLancatividades>(entity =>
            {
                entity.HasKey(e => e.CodLancatividades);

                entity.ToTable("tb_cad_lancatividades");

                entity.HasIndex(e => new { e.CodModalidade, e.CodPacote, e.CodPeriodoatividades, e.CodPessoa, e.DatAtividade })
                    .HasName("UK_tb_cad_lancatividades")
                    .IsUnique();

                entity.Property(e => e.CodLancatividades).HasColumnName("cod_lancatividades");

                entity.Property(e => e.CodModalidade).HasColumnName("cod_modalidade");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodPeriodoatividades).HasColumnName("cod_periodoatividades");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtividade)
                    .HasColumnName("dat_atividade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesComentario)
                    .HasColumnName("des_comentario")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodModalidadeNavigation)
                    .WithMany(p => p.TbCadLancatividades)
                    .HasForeignKey(d => d.CodModalidade)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_lancatividades_tb_bas_modalidade");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadLancatividades)
                    .HasForeignKey(d => d.CodPacote)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_lancatividades_tb_cad_pacote");

                entity.HasOne(d => d.CodPeriodoatividadesNavigation)
                    .WithMany(p => p.TbCadLancatividades)
                    .HasForeignKey(d => d.CodPeriodoatividades)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_lancatividades_tb_bas_periodoatividades");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadLancatividades)
                    .HasForeignKey(d => d.CodPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_cad_lancatividades_tb_cad_pessoa");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadLancatividades)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_lancatividades_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadLogCartao>(entity =>
            {
                entity.HasKey(e => e.CodLogCartao);

                entity.ToTable("tb_cad_log_cartao");

                entity.Property(e => e.CodLogCartao).HasColumnName("cod_log_cartao");

                entity.Property(e => e.CodInscricao).HasColumnName("cod_inscricao");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodStatus).HasColumnName("cod_status");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgGateway)
                    .HasColumnName("flg_gateway")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCartao)
                    .HasColumnName("num_cartao")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumNsu)
                    .HasColumnName("num_nsu")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumTid)
                    .HasColumnName("num_tid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTransacao)
                    .HasColumnName("num_transacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadLogCartaoSistema>(entity =>
            {
                entity.HasKey(e => e.CodLogCartaoSistema);

                entity.ToTable("tb_cad_log_cartao_sistema");

                entity.Property(e => e.CodLogCartaoSistema).HasColumnName("cod_log_cartao_sistema");

                entity.Property(e => e.CodStatus).HasColumnName("cod_status");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAcao)
                    .HasColumnName("des_acao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesFuncionalidade)
                    .HasColumnName("des_funcionalidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DesPortador)
                    .HasColumnName("des_portador")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSistema)
                    .HasColumnName("des_sistema")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgGateway)
                    .HasColumnName("flg_gateway")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCartao)
                    .HasColumnName("num_cartao")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumNsu)
                    .HasColumnName("num_nsu")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumParcela).HasColumnName("num_parcela");

                entity.Property(e => e.NumTid)
                    .HasColumnName("num_tid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTransacao)
                    .HasColumnName("num_transacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtdCartao)
                    .HasColumnName("qtd_cartao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValParcela)
                    .HasColumnName("val_parcela")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTotal)
                    .HasColumnName("val_total")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadLogCielo20161013>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_log_cielo_20161013");

                entity.Property(e => e.CodInscricao).HasColumnName("cod_inscricao");

                entity.Property(e => e.CodLogCielo)
                    .HasColumnName("cod_log_cielo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodStatus).HasColumnName("cod_status");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumCartao)
                    .HasColumnName("num_cartao")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumTid)
                    .HasColumnName("num_tid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTransacao)
                    .HasColumnName("num_transacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadLogCupom>(entity =>
            {
                entity.HasKey(e => e.CodLogCupom);

                entity.ToTable("tb_cad_log_cupom");

                entity.Property(e => e.CodLogCupom).HasColumnName("cod_log_cupom");

                entity.Property(e => e.CodCupom).HasColumnName("cod_cupom");

                entity.Property(e => e.CodCupomItem).HasColumnName("cod_cupom_item");

                entity.Property(e => e.CodReferencia).HasColumnName("cod_referencia");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatTentativa)
                    .HasColumnName("dat_tentativa")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAcao)
                    .HasColumnName("des_acao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesFuncionalidade)
                    .HasColumnName("des_funcionalidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DesSistema)
                    .HasColumnName("des_sistema")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadMensagem>(entity =>
            {
                entity.HasKey(e => e.CodMensagem);

                entity.ToTable("tb_cad_mensagem");

                entity.HasIndex(e => new { e.DesAssunto, e.FlgAtivo, e.DesMensagem, e.CodMensagem })
                    .HasName("sk_tb_cad_mensagem");

                entity.Property(e => e.CodMensagem)
                    .HasColumnName("cod_mensagem")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAssunto)
                    .HasColumnName("des_assunto")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(5120)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadMensagem)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_mensagem_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadMensagemcoletiva>(entity =>
            {
                entity.HasKey(e => e.CodMensagemcoletiva);

                entity.ToTable("tb_cad_mensagemcoletiva");

                entity.Property(e => e.CodMensagemcoletiva).HasColumnName("cod_mensagemcoletiva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnvio)
                    .HasColumnName("dat_envio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesMensagem)
                    .IsRequired()
                    .HasColumnName("des_mensagem")
                    .IsUnicode(false);

                entity.Property(e => e.DesPopulacao)
                    .IsRequired()
                    .HasColumnName("des_populacao")
                    .IsUnicode(false);

                entity.Property(e => e.DesTitulo)
                    .IsRequired()
                    .HasColumnName("des_titulo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumEmail).HasColumnName("num_email");
            });

            modelBuilder.Entity<TbCadMensagensgerais>(entity =>
            {
                entity.HasKey(e => e.CodMensagensgerais);

                entity.ToTable("tb_cad_mensagensgerais");

                entity.Property(e => e.CodMensagensgerais).HasColumnName("cod_mensagensgerais");

                entity.Property(e => e.CodTipomensagem).HasColumnName("cod_tipomensagem");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIdioma)
                    .HasColumnName("des_idioma")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(5120)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodTipomensagemNavigation)
                    .WithMany(p => p.TbCadMensagensgerais)
                    .HasForeignKey(d => d.CodTipomensagem)
                    .HasConstraintName("FK_tb_cad_mensagensgerais_tb_bas_tipomensagem");
            });

            modelBuilder.Entity<TbCadNrmail>(entity =>
            {
                entity.HasKey(e => e.CodNrmail);

                entity.ToTable("tb_cad_nrmail");

                entity.HasIndex(e => new { e.CodEmail, e.DesEmail })
                    .HasName("UK_tb_cad_nrmail")
                    .IsUnique();

                entity.Property(e => e.CodNrmail).HasColumnName("cod_nrmail");

                entity.Property(e => e.CodEmail).HasColumnName("cod_email");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoanrmail).HasColumnName("cod_pessoanrmail");

                entity.Property(e => e.CodResposta).HasColumnName("cod_resposta");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEmail)
                    .HasColumnName("dat_email")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatResposta)
                    .HasColumnName("dat_resposta")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.DesResposta)
                    .HasColumnName("des_resposta")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.FlgEnvio)
                    .HasColumnName("flg_envio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodEmailNavigation)
                    .WithMany(p => p.TbCadNrmail)
                    .HasForeignKey(d => d.CodEmail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_nrmail_tb_cad_emails");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadNrmail)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_nrmail_tb_cad_pessoa");

                entity.HasOne(d => d.CodPessoanrmailNavigation)
                    .WithMany(p => p.TbCadNrmail)
                    .HasForeignKey(d => d.CodPessoanrmail)
                    .HasConstraintName("FK_tb_cad_nrmail_tb_cad_pessoanrmail");
            });

            modelBuilder.Entity<TbCadNrmailImap>(entity =>
            {
                entity.HasKey(e => e.CodNrmailImap)
                    .HasName("PK_tb_cad_nrmail_1");

                entity.ToTable("tb_cad_nrmail_imap");

                entity.Property(e => e.CodNrmailImap).HasColumnName("cod_nrmail_imap");

                entity.Property(e => e.CodUid).HasColumnName("cod_uid");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEmail)
                    .HasColumnName("dat_email")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatImpressao)
                    .HasColumnName("dat_impressao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAssunto)
                    .HasColumnName("des_assunto")
                    .IsUnicode(false);

                entity.Property(e => e.DesDe)
                    .HasColumnName("des_de")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .IsUnicode(false);

                entity.Property(e => e.DesPara)
                    .HasColumnName("des_para")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadOnibus>(entity =>
            {
                entity.HasKey(e => e.CodOnibus)
                    .HasName("PK_tb_bas_onibus");

                entity.ToTable("tb_cad_onibus");

                entity.Property(e => e.CodOnibus).HasColumnName("cod_onibus");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesDdd)
                    .HasColumnName("des_ddd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmpresa)
                    .HasColumnName("des_empresa")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImagem)
                    .HasColumnName("des_imagem")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesOnibus)
                    .HasColumnName("des_onibus")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone)
                    .HasColumnName("des_telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumPoltronas).HasColumnName("num_poltronas");
            });

            modelBuilder.Entity<TbCadOnibusAlocacao>(entity =>
            {
                entity.HasKey(e => e.CodOnibusAlocacao);

                entity.ToTable("tb_cad_onibus_alocacao");

                entity.Property(e => e.CodOnibusAlocacao).HasColumnName("cod_onibus_alocacao");

                entity.Property(e => e.CodOnibusSaida).HasColumnName("cod_onibus_saida");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesPessoacpfNr)
                    .HasColumnName("des_pessoacpf_nr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesPessoargNr)
                    .HasColumnName("des_pessoarg_nr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgNr)
                    .HasColumnName("flg_nr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoaNr)
                    .HasColumnName("nom_pessoa_nr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumPoltrona).HasColumnName("num_poltrona");

                entity.HasOne(d => d.CodOnibusSaidaNavigation)
                    .WithMany(p => p.TbCadOnibusAlocacao)
                    .HasForeignKey(d => d.CodOnibusSaida)
                    .HasConstraintName("FK_tb_cad_onibus_alocacao_tb_cad_onibus_saida");

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadOnibusAlocacao)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_onibus_alocacao_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadOnibusAlocacao20171021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_onibus_alocacao_20171021");

                entity.Property(e => e.CodOnibusAlocacao)
                    .HasColumnName("cod_onibus_alocacao")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodOnibusSaida).HasColumnName("cod_onibus_saida");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesPessoacpfNr)
                    .HasColumnName("des_pessoacpf_nr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesPessoargNr)
                    .HasColumnName("des_pessoarg_nr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgNr)
                    .HasColumnName("flg_nr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoaNr)
                    .HasColumnName("nom_pessoa_nr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumPoltrona).HasColumnName("num_poltrona");
            });

            modelBuilder.Entity<TbCadOnibusPacote>(entity =>
            {
                entity.HasKey(e => e.CodOnibusPacote);

                entity.ToTable("tb_cad_onibus_pacote");

                entity.Property(e => e.CodOnibusPacote).HasColumnName("cod_onibus_pacote");

                entity.Property(e => e.CodOnibusSaida).HasColumnName("cod_onibus_saida");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.CodOnibusSaidaNavigation)
                    .WithMany(p => p.TbCadOnibusPacote)
                    .HasForeignKey(d => d.CodOnibusSaida)
                    .HasConstraintName("FK_tb_cad_onibus_pacote_tb_cad_onibus_saida");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadOnibusPacote)
                    .HasForeignKey(d => d.CodPacote)
                    .HasConstraintName("FK_tb_cad_onibus_pacote_tb_cad_pacote");
            });

            modelBuilder.Entity<TbCadOnibusSaida>(entity =>
            {
                entity.HasKey(e => e.CodOnibusSaida);

                entity.ToTable("tb_cad_onibus_saida");

                entity.Property(e => e.CodOnibusSaida).HasColumnName("cod_onibus_saida");

                entity.Property(e => e.CodOnibus).HasColumnName("cod_onibus");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgExibeportal)
                    .HasColumnName("flg_exibeportal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibesoa)
                    .HasColumnName("flg_exibesoa")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgOperacao)
                    .HasColumnName("flg_operacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodOnibusNavigation)
                    .WithMany(p => p.TbCadOnibusSaida)
                    .HasForeignKey(d => d.CodOnibus)
                    .HasConstraintName("FK_tb_cad_onibus_saida_tb_cad_onibus");
            });

            modelBuilder.Entity<TbCadPacote>(entity =>
            {
                entity.HasKey(e => e.CodPacote);

                entity.ToTable("tb_cad_pacote");

                entity.HasIndex(e => new { e.DesPacote, e.NumDiarias, e.FlgAtivo, e.CodPacote, e.CodUnidadenr, e.CodServico, e.CodUsuario })
                    .HasName("SK_tb_cad_pacote")
                    .IsUnique();

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodServico)
                    .HasColumnName("cod_servico")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatLimiteinscricao)
                    .HasColumnName("dat_limiteinscricao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatLimitereserva).HasColumnName("dat_limitereserva");

                entity.Property(e => e.DesPacote)
                    .HasColumnName("des_pacote")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DesPortal)
                    .HasColumnName("des_portal")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DesTermocontrato)
                    .HasColumnName("des_termocontrato")
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCantina)
                    .HasColumnName("flg_cantina")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NumDiarias).HasColumnName("num_diarias");

                entity.Property(e => e.ValCantina)
                    .HasColumnName("val_cantina")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadPacote)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_pacote_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadPacoteCarga>(entity =>
            {
                entity.HasKey(e => e.CodPacote);

                entity.ToTable("tb_cad_pacote_carga");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodServico)
                    .HasColumnName("cod_servico")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatLimiteinscricao)
                    .HasColumnName("dat_limiteinscricao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatLimitereserva)
                    .HasColumnName("dat_limitereserva")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesPacote)
                    .HasColumnName("des_pacote")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumDiarias).HasColumnName("num_diarias");

                entity.Property(e => e.ValCantina)
                    .HasColumnName("val_cantina")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadPacoteCarga)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_pacote_carga_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadPacoteonibus20160324>(entity =>
            {
                entity.HasKey(e => e.CodPacoteonibus)
                    .HasName("PK_tb_cad_pacoteonibus");

                entity.ToTable("tb_cad_pacoteonibus_20160324");

                entity.Property(e => e.CodPacoteonibus).HasColumnName("cod_pacoteonibus");

                entity.Property(e => e.CodOnibus).HasColumnName("cod_onibus");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.FlgExibeportal)
                    .HasColumnName("flg_exibeportal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgOperacao)
                    .HasColumnName("flg_operacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadPacoteonibusPoltrona20160324>(entity =>
            {
                entity.HasKey(e => e.CodPacoteonibusPoltrona)
                    .HasName("PK_tb_cad_pacoteonibus_poltrona");

                entity.ToTable("tb_cad_pacoteonibus_poltrona_20160324");

                entity.Property(e => e.CodPacoteonibusPoltrona).HasColumnName("cod_pacoteonibus_poltrona");

                entity.Property(e => e.CodPacoteonibus).HasColumnName("cod_pacoteonibus");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.FlgNr)
                    .HasColumnName("flg_nr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgOperacao)
                    .HasColumnName("flg_operacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumPoltrona).HasColumnName("num_poltrona");

                entity.HasOne(d => d.CodPacoteonibusNavigation)
                    .WithMany(p => p.TbCadPacoteonibusPoltrona20160324)
                    .HasForeignKey(d => d.CodPacoteonibus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pacoteonibus_poltrona_tb_cad_pacoteonibus");

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadPacoteonibusPoltrona20160324)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pacoteonibus_poltrona_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadPacoteprecos>(entity =>
            {
                entity.HasKey(e => e.CodPacoteprecos);

                entity.ToTable("tb_cad_pacoteprecos");

                entity.HasIndex(e => new { e.CodPacoteprecos, e.CodPacotetabelaprecos, e.CodCondpagto })
                    .HasName("sk_tb_cad_pacoteprecos");

                entity.Property(e => e.CodPacoteprecos).HasColumnName("cod_pacoteprecos");

                entity.Property(e => e.CodCondpagto).HasColumnName("cod_condpagto");

                entity.Property(e => e.CodPacotetabelaprecos).HasColumnName("cod_pacotetabelaprecos");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesComentario)
                    .HasColumnName("des_comentario")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgExibePortal)
                    .HasColumnName("flg_exibe_portal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValParcela)
                    .HasColumnName("val_parcela")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodCondpagtoNavigation)
                    .WithMany(p => p.TbCadPacoteprecos)
                    .HasForeignKey(d => d.CodCondpagto)
                    .HasConstraintName("FK_tb_cad_pacoteprecos_tb_bas_condpagto");

                entity.HasOne(d => d.CodPacotetabelaprecosNavigation)
                    .WithMany(p => p.TbCadPacoteprecos)
                    .HasForeignKey(d => d.CodPacotetabelaprecos)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pacoteprecos_tb_cad_pacote");
            });

            modelBuilder.Entity<TbCadPacotetabelaprecos>(entity =>
            {
                entity.HasKey(e => e.CodPacotetabelaprecos);

                entity.ToTable("tb_cad_pacotetabelaprecos");

                entity.Property(e => e.CodPacotetabelaprecos).HasColumnName("cod_pacotetabelaprecos");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatFim)
                    .HasColumnName("dat_fim")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesPacotetabelaprecos)
                    .HasColumnName("des_pacotetabelaprecos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgCalouro)
                    .HasColumnName("flg_calouro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgVeterano)
                    .HasColumnName("flg_veterano")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadPacotetemporada>(entity =>
            {
                entity.HasKey(e => e.CodPacotetemporada);

                entity.ToTable("tb_cad_pacotetemporada");

                entity.Property(e => e.CodPacotetemporada).HasColumnName("cod_pacotetemporada");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadPacotetemporada)
                    .HasForeignKey(d => d.CodPacote)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pacotetemporada_tb_cad_pacote");

                entity.HasOne(d => d.CodTemporadaNavigation)
                    .WithMany(p => p.TbCadPacotetemporada)
                    .HasForeignKey(d => d.CodTemporada)
                    .HasConstraintName("FK_tb_cad_pacotetemporada_tb_cad_temporada");
            });

            modelBuilder.Entity<TbCadPacotetemporadaCarga>(entity =>
            {
                entity.HasKey(e => e.CodPacotetemporada);

                entity.ToTable("tb_cad_pacotetemporada_carga");

                entity.Property(e => e.CodPacotetemporada).HasColumnName("cod_pacotetemporada");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadPacotetemporadaCarga)
                    .HasForeignKey(d => d.CodPacote)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pacotetemporada_carga_tb_cad_pacote");

                entity.HasOne(d => d.CodTemporadaNavigation)
                    .WithMany(p => p.TbCadPacotetemporadaCarga)
                    .HasForeignKey(d => d.CodTemporada)
                    .HasConstraintName("FK_tb_cad_pacotetemporada_carga_tb_cad_temporada");
            });

            modelBuilder.Entity<TbCadPagamento>(entity =>
            {
                entity.HasKey(e => e.CodPagamento);

                entity.ToTable("tb_cad_pagamento");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodCupomItem).HasColumnName("cod_cupom_item");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnvioSapiens)
                    .HasColumnName("dat_envio_sapiens")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviopagto)
                    .HasColumnName("dat_enviopagto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatMsgDobra)
                    .HasColumnName("dat_msg_dobra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPago)
                    .HasColumnName("dat_pago")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatUtilizacaoCupom)
                    .HasColumnName("dat_utilizacao_cupom")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesMsgDobra)
                    .HasColumnName("des_msg_dobra")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgCantina)
                    .HasColumnName("flg_cantina")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgLiberado)
                    .HasColumnName("flg_liberado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPago)
                    .HasColumnName("flg_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSapiens)
                    .HasColumnName("flg_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumPedSapiens).HasColumnName("num_ped_sapiens");

                entity.Property(e => e.ValIntegral)
                    .HasColumnName("val_integral")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTickets)
                    .HasColumnName("val_tickets")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTotal)
                    .HasColumnName("val_total")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTotalCupom)
                    .HasColumnName("val_total_cupom")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodCupomItemNavigation)
                    .WithMany(p => p.TbCadPagamento)
                    .HasForeignKey(d => d.CodCupomItem)
                    .HasConstraintName("FK_tb_cad_pagamento_cod_cupom_item");
            });

            modelBuilder.Entity<TbCadPagamentoAcampante>(entity =>
            {
                entity.HasKey(e => e.CodPagamentoAcampante);

                entity.ToTable("tb_cad_pagamento_acampante");

                entity.HasIndex(e => new { e.CodInscricao, e.CodPessoa, e.CodPagamento })
                    .HasName("idx_cod_pagamento");

                entity.Property(e => e.CodPagamentoAcampante).HasColumnName("cod_pagamento_acampante");

                entity.Property(e => e.CodInscricao).HasColumnName("cod_inscricao");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ValCupom)
                    .HasColumnName("val_cupom")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValIntegral)
                    .HasColumnName("val_integral")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValPorcentagem)
                    .HasColumnName("val_porcentagem")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTickets)
                    .HasColumnName("val_tickets")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTotal)
                    .HasColumnName("val_total")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodInscricaoNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampante)
                    .HasForeignKey(d => d.CodInscricao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_tb_cad_inscricao");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampante)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_tb_cad_pagamento");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampante)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPagamentoAcampanteTicket>(entity =>
            {
                entity.HasKey(e => e.CodPagamentoAcampanteTicket);

                entity.ToTable("tb_cad_pagamento_acampante_ticket");

                entity.Property(e => e.CodPagamentoAcampanteTicket).HasColumnName("cod_pagamento_acampante_ticket");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodPagamentoAcampante).HasColumnName("cod_pagamento_acampante");

                entity.Property(e => e.CodTicket).HasColumnName("cod_ticket");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampanteTicket)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_ticket_tb_cad_pagamento");

                entity.HasOne(d => d.CodPagamentoAcampanteNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampanteTicket)
                    .HasForeignKey(d => d.CodPagamentoAcampante)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_ticket_tb_cad_pagamento_acampante");

                entity.HasOne(d => d.CodTicketNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampanteTicket)
                    .HasForeignKey(d => d.CodTicket)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_ticket_tb_cad_pessoapapelreserva_ticket");
            });

            modelBuilder.Entity<TbCadPagamentoAcampanteTicketind>(entity =>
            {
                entity.HasKey(e => e.CodPagamentoAcampanteTicketind);

                entity.ToTable("tb_cad_pagamento_acampante_ticketind");

                entity.Property(e => e.CodPagamentoAcampanteTicketind).HasColumnName("cod_pagamento_acampante_ticketind");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodPagamentoAcampante).HasColumnName("cod_pagamento_acampante");

                entity.Property(e => e.CodTicketind).HasColumnName("cod_ticketind");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampanteTicketind)
                    .HasForeignKey(d => d.CodPagamento)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_ticketind_tb_cad_pagamento");

                entity.HasOne(d => d.CodPagamentoAcampanteNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampanteTicketind)
                    .HasForeignKey(d => d.CodPagamentoAcampante)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_ticketind_tb_cad_pagamento_acampante");

                entity.HasOne(d => d.CodTicketindNavigation)
                    .WithMany(p => p.TbCadPagamentoAcampanteTicketind)
                    .HasForeignKey(d => d.CodTicketind)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagamento_acampante_ticketind_tb_cad_pessoapapelreserva_ticketind");
            });

            modelBuilder.Entity<TbCadPagamentoCondmeio>(entity =>
            {
                entity.HasKey(e => e.CodPagamentoCondmeio);

                entity.ToTable("tb_cad_pagamento_condmeio");

                entity.Property(e => e.CodPagamentoCondmeio).HasColumnName("cod_pagamento_condmeio");

                entity.Property(e => e.CodCondpagto).HasColumnName("cod_condpagto");

                entity.Property(e => e.CodMeiopagto).HasColumnName("cod_meiopagto");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodStatusCielo).HasColumnName("cod_status_cielo");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesDiaVencimento)
                    .HasColumnName("des_dia_vencimento")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgGateway)
                    .HasColumnName("flg_gateway")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPrincipal)
                    .HasColumnName("flg_principal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCartao)
                    .HasColumnName("num_cartao")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumNsu)
                    .HasColumnName("num_nsu")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumTentativaCielo).HasColumnName("num_tentativa_cielo");

                entity.Property(e => e.NumTidCielo)
                    .HasColumnName("num_tid_cielo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTransacaoCielo)
                    .HasColumnName("num_transacao_cielo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCondpagtoNavigation)
                    .WithMany(p => p.TbCadPagamentoCondmeio)
                    .HasForeignKey(d => d.CodCondpagto)
                    .HasConstraintName("FK_tb_cad_pagamento_condmeio_tb_bas_condpagto");

                entity.HasOne(d => d.CodMeiopagtoNavigation)
                    .WithMany(p => p.TbCadPagamentoCondmeio)
                    .HasForeignKey(d => d.CodMeiopagto)
                    .HasConstraintName("FK_tb_cad_pagamento_condmeio_tb_bas_meiospagto");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.TbCadPagamentoCondmeio)
                    .HasForeignKey(d => d.CodPagamento)
                    .HasConstraintName("FK_tb_cad_pagamento_condmeio_tb_cad_pagamento");
            });

            modelBuilder.Entity<TbCadPagamentoParcela>(entity =>
            {
                entity.HasKey(e => e.CodPagamentoParcela);

                entity.ToTable("tb_cad_pagamento_parcela");

                entity.Property(e => e.CodPagamentoParcela).HasColumnName("cod_pagamento_parcela");

                entity.Property(e => e.CodAgencia).HasColumnName("cod_agencia");

                entity.Property(e => e.CodBanco).HasColumnName("cod_banco");

                entity.Property(e => e.CodPagamento).HasColumnName("cod_pagamento");

                entity.Property(e => e.CodPagamentoCondmeio).HasColumnName("cod_pagamento_condmeio");

                entity.Property(e => e.DatParcela)
                    .HasColumnName("dat_parcela")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAgencia)
                    .HasColumnName("des_agencia")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DesAnexo)
                    .HasColumnName("des_anexo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesContacorrente)
                    .HasColumnName("des_contacorrente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmitente)
                    .HasColumnName("des_emitente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNumero)
                    .HasColumnName("des_numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesObservacao)
                    .HasColumnName("des_observacao")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumBoleto)
                    .HasColumnName("num_boleto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumBoletoNossonumero)
                    .HasColumnName("num_boleto_nossonumero")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumParcela).HasColumnName("num_parcela");

                entity.Property(e => e.ValParcela)
                    .HasColumnName("val_parcela")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.TbCadPagamentoParcela)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagamento_parcela_tb_cad_pagamento");
            });

            modelBuilder.Entity<TbCadPagtoinscricao>(entity =>
            {
                entity.HasKey(e => e.CodPagtoinscricao);

                entity.ToTable("tb_cad_pagtoinscricao");

                entity.Property(e => e.CodPagtoinscricao).HasColumnName("cod_pagtoinscricao");

                entity.Property(e => e.CodCondpagto).HasColumnName("cod_condpagto");

                entity.Property(e => e.CodInscricao).HasColumnName("cod_inscricao");

                entity.Property(e => e.CodMeiospagto).HasColumnName("cod_meiospagto");

                entity.Property(e => e.CodStatusCielo).HasColumnName("cod_status_cielo");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnvioSapiens)
                    .HasColumnName("dat_envio_sapiens")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviopagto)
                    .HasColumnName("dat_enviopagto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatMensagemDobradinha)
                    .HasColumnName("dat_mensagem_dobradinha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPago)
                    .HasColumnName("dat_pago")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesMensagemDobradinha)
                    .HasColumnName("des_mensagem_dobradinha")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FlgPago)
                    .HasColumnName("flg_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSapiens)
                    .HasColumnName("flg_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumTidCielo)
                    .HasColumnName("num_tid_cielo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumpedSapiens).HasColumnName("numped_sapiens");

                entity.Property(e => e.ValCantina)
                    .HasColumnName("val_cantina")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValCantinaintegral)
                    .HasColumnName("val_cantinaintegral")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValDesconto)
                    .HasColumnName("val_desconto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValIntegral)
                    .HasColumnName("val_integral")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodInscricaoNavigation)
                    .WithMany(p => p.TbCadPagtoinscricao)
                    .HasForeignKey(d => d.CodInscricao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagtoinscricao_tb_cad_inscricao");
            });

            modelBuilder.Entity<TbCadPagtoinscricaoParcela>(entity =>
            {
                entity.HasKey(e => e.CodPagtoinscricaoParcela);

                entity.ToTable("tb_cad_pagtoinscricao_parcela");

                entity.Property(e => e.CodPagtoinscricaoParcela).HasColumnName("cod_pagtoinscricao_parcela");

                entity.Property(e => e.CodAgenciaCheque).HasColumnName("cod_agencia_cheque");

                entity.Property(e => e.CodBancoCheque).HasColumnName("cod_banco_cheque");

                entity.Property(e => e.CodPagtoinscricao).HasColumnName("cod_pagtoinscricao");

                entity.Property(e => e.DatPagtoparcela)
                    .HasColumnName("dat_pagtoparcela")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatParcela)
                    .HasColumnName("dat_parcela")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCcCheque)
                    .HasColumnName("des_cc_cheque")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmitenteCheque)
                    .HasColumnName("des_emitente_cheque")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNumeroCheque)
                    .HasColumnName("des_numero_cheque")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumBoleto)
                    .HasColumnName("num_boleto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumParcela).HasColumnName("num_parcela");

                entity.Property(e => e.ValPagtoparcela)
                    .HasColumnName("val_pagtoparcela")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValParcela)
                    .HasColumnName("val_parcela")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodPagtoinscricaoNavigation)
                    .WithMany(p => p.TbCadPagtoinscricaoParcela)
                    .HasForeignKey(d => d.CodPagtoinscricao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pagtoinscricao_parcela_tb_cad_pagtoinscricao");
            });

            modelBuilder.Entity<TbCadParametro>(entity =>
            {
                entity.HasKey(e => e.CodParametro);

                entity.ToTable("tb_cad_parametro");

                entity.HasIndex(e => e.DesChave)
                    .HasName("UK_tb_cad_parametro")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesChave, e.ValParametro, e.CodParametro })
                    .HasName("sk_tb_cad_parametro");

                entity.Property(e => e.CodParametro).HasColumnName("cod_parametro");

                entity.Property(e => e.CodGrupoparametro).HasColumnName("cod_grupoparametro");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesChave)
                    .HasColumnName("des_chave")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DesExplicacao)
                    .HasColumnName("des_explicacao")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValParametro)
                    .HasColumnName("val_parametro")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadParametronr>(entity =>
            {
                entity.HasKey(e => e.CodParametronr);

                entity.ToTable("tb_cad_parametronr");

                entity.HasIndex(e => e.DesChave)
                    .HasName("UK_tb_cad_parametronr")
                    .IsUnique();

                entity.HasIndex(e => new { e.DesChave, e.ValParametro, e.DesExplicacao, e.CodParametronr, e.CodUnidadenr })
                    .HasName("sk_tb_cad_parametronr")
                    .IsUnique();

                entity.Property(e => e.CodParametronr).HasColumnName("cod_parametronr");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesChave)
                    .HasColumnName("des_chave")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesExplicacao)
                    .HasColumnName("des_explicacao")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValParametro)
                    .HasColumnName("val_parametro")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadParametronr)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_parametronr_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadPessoa>(entity =>
            {
                entity.HasKey(e => e.CodPessoa)
                    .HasName("PK_tb_cad_pessoa_1");

                entity.ToTable("tb_cad_pessoa");

                entity.HasIndex(e => new { e.NomPessoa, e.DesEmaillogin })
                    .HasName("UK_tb_cad_pessoa")
                    .IsUnique();

                entity.HasIndex(e => new { e.NomPessoa, e.DesEmaillogin, e.CodDepositoidentificado, e.CodPessoa })
                    .HasName("sk_tb_cad_pessoa");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodClienteSapiens).HasColumnName("cod_cliente_sapiens");

                entity.Property(e => e.CodDepositoidentificado)
                    .HasColumnName("cod_depositoidentificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatLiberacao)
                    .HasColumnName("dat_liberacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmaillogin)
                    .HasColumnName("des_emaillogin")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImagem)
                    .HasColumnName("des_imagem")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesLembretesenha)
                    .HasColumnName("des_lembretesenha")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagembloqueio)
                    .HasColumnName("des_mensagembloqueio")
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExterior)
                    .HasColumnName("flg_exterior")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgLiberado)
                    .HasColumnName("flg_liberado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgVideoPortal)
                    .HasColumnName("flg_video_portal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoa)
                    .HasColumnName("nom_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoa2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_pessoa_2");

                entity.Property(e => e.CodClienteSapiens).HasColumnName("cod_cliente_sapiens");

                entity.Property(e => e.CodDepositoidentificado)
                    .HasColumnName("cod_depositoidentificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPessoa)
                    .HasColumnName("cod_pessoa")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatLiberacao)
                    .HasColumnName("dat_liberacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmaillogin)
                    .HasColumnName("des_emaillogin")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImagem)
                    .HasColumnName("des_imagem")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesLembretesenha)
                    .HasColumnName("des_lembretesenha")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagembloqueio)
                    .HasColumnName("des_mensagembloqueio")
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExterior)
                    .HasColumnName("flg_exterior")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgLiberado)
                    .HasColumnName("flg_liberado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgVideoPortal)
                    .HasColumnName("flg_video_portal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoa)
                    .HasColumnName("nom_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoaAntiga>(entity =>
            {
                entity.HasKey(e => e.CodPessoaAntiga)
                    .HasName("PK_tb_cad_pessoa");

                entity.ToTable("tb_cad_pessoa_antiga");

                entity.HasIndex(e => new { e.NomPessoa, e.DesEmaillogin })
                    .HasName("UK_tb_cad_pessoa")
                    .IsUnique();

                entity.HasIndex(e => new { e.NomPessoa, e.DesEmaillogin, e.CodDepositoidentificado, e.CodPessoaAntiga })
                    .HasName("sk_tb_cad_pessoa");

                entity.Property(e => e.CodPessoaAntiga).HasColumnName("cod_pessoa_antiga");

                entity.Property(e => e.CodClienteSapiens).HasColumnName("cod_cliente_sapiens");

                entity.Property(e => e.CodDepositoidentificado)
                    .HasColumnName("cod_depositoidentificado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatLiberacao)
                    .HasColumnName("dat_liberacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmaillogin)
                    .HasColumnName("des_emaillogin")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImagem)
                    .HasColumnName("des_imagem")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesLembretesenha)
                    .HasColumnName("des_lembretesenha")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagembloqueio)
                    .HasColumnName("des_mensagembloqueio")
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExterior)
                    .HasColumnName("flg_exterior")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgLiberado)
                    .HasColumnName("flg_liberado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgVideoPortal)
                    .HasColumnName("flg_video_portal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoa)
                    .HasColumnName("nom_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoaassistente>(entity =>
            {
                entity.HasKey(e => e.CodPessoaassistente);

                entity.ToTable("tb_cad_pessoaassistente");

                entity.Property(e => e.CodPessoaassistente).HasColumnName("cod_pessoaassistente");

                entity.Property(e => e.CodGrauescolaridade).HasColumnName("cod_grauescolaridade");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatConhecenr)
                    .HasColumnName("dat_conhecenr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviosenha)
                    .HasColumnName("dat_enviosenha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTerminoPrimeirograu)
                    .HasColumnName("dat_termino_primeirograu")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTerminoSegundograu)
                    .HasColumnName("dat_termino_segundograu")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTerminoSuperior)
                    .HasColumnName("dat_termino_superior")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAcompanhamento)
                    .HasColumnName("des_acompanhamento")
                    .IsUnicode(false);

                entity.Property(e => e.DesAgencia)
                    .HasColumnName("des_agencia")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesAnoletivo)
                    .HasColumnName("des_anoletivo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DesComoconhecenr)
                    .HasColumnName("des_comoconhecenr")
                    .IsUnicode(false);

                entity.Property(e => e.DesContacorrente)
                    .HasColumnName("des_contacorrente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesCurso)
                    .HasColumnName("des_curso")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesHobbies)
                    .HasColumnName("des_hobbies")
                    .IsUnicode(false);

                entity.Property(e => e.DesIndicadopor)
                    .HasColumnName("des_indicadopor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstituicaoPrimeirograu)
                    .HasColumnName("des_instituicao_primeirograu")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstituicaoSegundograu)
                    .HasColumnName("des_instituicao_segundograu")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstituicaoSuperior)
                    .HasColumnName("des_instituicao_superior")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInteresse)
                    .HasColumnName("des_interesse")
                    .IsUnicode(false);

                entity.Property(e => e.DesMotivoreprovacao)
                    .HasColumnName("des_motivoreprovacao")
                    .IsUnicode(false);

                entity.Property(e => e.DesNumeroinss)
                    .HasColumnName("des_numeroinss")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesObsfoto)
                    .HasColumnName("des_obsfoto")
                    .IsUnicode(false);

                entity.Property(e => e.DesOcupacoes)
                    .HasColumnName("des_ocupacoes")
                    .IsUnicode(false);

                entity.Property(e => e.DesOutroArte)
                    .HasColumnName("des_outro_arte")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesOutroEsporte)
                    .HasColumnName("des_outro_esporte")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesOutroMusica)
                    .HasColumnName("des_outro_musica")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesPeriodo)
                    .HasColumnName("des_periodo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesProfissaomae)
                    .HasColumnName("des_profissaomae")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesProfissaopai)
                    .HasColumnName("des_profissaopai")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesSemestre)
                    .HasColumnName("des_semestre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgCarro)
                    .HasColumnName("flg_carro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgConhecenr)
                    .HasColumnName("flg_conhecenr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgContratado)
                    .HasColumnName("flg_contratado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEntrevistado)
                    .HasColumnName("flg_entrevistado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnviarsenha)
                    .HasColumnName("flg_enviarsenha")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgHabilitacao)
                    .HasColumnName("flg_habilitacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgIndicacao)
                    .HasColumnName("flg_indicacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgReprovado)
                    .HasColumnName("flg_reprovado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomMae)
                    .HasColumnName("nom_mae")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomPai)
                    .HasColumnName("nom_pai")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoaassistenteDisponibilidade>(entity =>
            {
                entity.HasKey(e => e.CodPessoaassistenteDisponibilidade);

                entity.ToTable("tb_cad_pessoaassistente_disponibilidade");

                entity.Property(e => e.CodPessoaassistenteDisponibilidade).HasColumnName("cod_pessoaassistente_disponibilidade");

                entity.Property(e => e.CodEnquete).HasColumnName("cod_enquete");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoaassistente).HasColumnName("cod_pessoaassistente");

                entity.Property(e => e.CodTipocamiseta).HasColumnName("cod_tipocamiseta");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgAtividadeCulinaria)
                    .HasColumnName("flg_atividade_culinaria")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtividadeDanca)
                    .HasColumnName("flg_atividade_danca")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtividadeMarcenaria)
                    .HasColumnName("flg_atividade_marcenaria")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtividadeRevistanr)
                    .HasColumnName("flg_atividade_revistanr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtividadeSalaartes)
                    .HasColumnName("flg_atividade_salaartes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtividadeSofttenis)
                    .HasColumnName("flg_atividade_softtenis")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtividadeTeatro)
                    .HasColumnName("flg_atividade_teatro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEstagNaoremunerado)
                    .HasColumnName("flg_estag_naoremunerado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgFaixaetaria1)
                    .HasColumnName("flg_faixaetaria1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgFaixaetaria2)
                    .HasColumnName("flg_faixaetaria2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgFaixaetaria3)
                    .HasColumnName("flg_faixaetaria3")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgFaixaetaria4)
                    .HasColumnName("flg_faixaetaria4")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgOficinaAcaoaventura)
                    .HasColumnName("flg_oficina_acaoaventura")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgOficinaAlpinismo)
                    .HasColumnName("flg_oficina_alpinismo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSetorAnimacao)
                    .HasColumnName("flg_setor_animacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSetorArtistico)
                    .HasColumnName("flg_setor_artistico")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSetorRecreativo)
                    .HasColumnName("flg_setor_recreativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodEnqueteNavigation)
                    .WithMany(p => p.TbCadPessoaassistenteDisponibilidade)
                    .HasForeignKey(d => d.CodEnquete)
                    .HasConstraintName("FK_tb_cad_pessoaassistente_disponibilidade_tb_cad_enquete");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoaassistenteDisponibilidade)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoaassistente_disponibilidade_tb_cad_pessoa");

                entity.HasOne(d => d.CodPessoaassistenteNavigation)
                    .WithMany(p => p.TbCadPessoaassistenteDisponibilidade)
                    .HasForeignKey(d => d.CodPessoaassistente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoaassistente_disponibilidade_tb_cad_pessoaassistente");

                entity.HasOne(d => d.CodTipocamisetaNavigation)
                    .WithMany(p => p.TbCadPessoaassistenteDisponibilidade)
                    .HasForeignKey(d => d.CodTipocamiseta)
                    .HasConstraintName("FK_tb_cad_pessoaassistente_disponibilidade_tb_bas_tipocamiseta");
            });

            modelBuilder.Entity<TbCadPessoaassistenteDisponibilidadeEsc>(entity =>
            {
                entity.HasKey(e => e.CodPessoaassistenteDisponibilidadeEsc);

                entity.ToTable("tb_cad_pessoaassistente_disponibilidade_esc");

                entity.Property(e => e.CodPessoaassistenteDisponibilidadeEsc).HasColumnName("cod_pessoaassistente_disponibilidade_esc");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesModulo)
                    .HasColumnName("des_modulo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.DesSerie)
                    .HasColumnName("des_serie")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUnidadenr)
                    .HasColumnName("des_unidadenr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgDisponibilidade)
                    .HasColumnName("flg_disponibilidade")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PedApos)
                    .HasColumnName("ped_apos")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PedPara)
                    .HasColumnName("ped_para")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoaassistenteDisponibilidadeTemp>(entity =>
            {
                entity.HasKey(e => e.CodPessoaassistenteDisponibilidadeTemp);

                entity.ToTable("tb_cad_pessoaassistente_disponibilidade_temp");

                entity.Property(e => e.CodPessoaassistenteDisponibilidadeTemp).HasColumnName("cod_pessoaassistente_disponibilidade_temp");

                entity.Property(e => e.CodPessoaassistenteDisponibilidade).HasColumnName("cod_pessoaassistente_disponibilidade");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.HasOne(d => d.CodPessoaassistenteDisponibilidadeNavigation)
                    .WithMany(p => p.TbCadPessoaassistenteDisponibilidadeTemp)
                    .HasForeignKey(d => d.CodPessoaassistenteDisponibilidade)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoaassistente_disponibilidade_temp_tb_cad_pessoaassistente_disponibilidade");
            });

            modelBuilder.Entity<TbCadPessoaassistenteEspcultura>(entity =>
            {
                entity.HasKey(e => e.CodPessoaassistenteEspcultura);

                entity.ToTable("tb_cad_pessoaassistente_espcultura");

                entity.Property(e => e.CodPessoaassistenteEspcultura).HasColumnName("cod_pessoaassistente_espcultura");

                entity.Property(e => e.CodEsportecultura).HasColumnName("cod_esportecultura");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoaassistenteEspcultura)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoaassistente_espcultura_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoaconveniomedico>(entity =>
            {
                entity.HasKey(e => e.CodPessoaconveniomedico);

                entity.ToTable("tb_cad_pessoaconveniomedico");

                entity.Property(e => e.CodPessoaconveniomedico).HasColumnName("cod_pessoaconveniomedico");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCategoriaconvenio)
                    .HasColumnName("des_categoriaconvenio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesConveniomedico)
                    .HasColumnName("des_conveniomedico")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumCarteirinha)
                    .HasColumnName("num_carteirinha")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoaconveniomedico)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoaconveniomedico_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoadiario>(entity =>
            {
                entity.HasKey(e => e.CodPessoadiario);

                entity.ToTable("tb_cad_pessoadiario");

                entity.Property(e => e.CodPessoadiario).HasColumnName("cod_pessoadiario");

                entity.Property(e => e.CodCategoriadiario).HasColumnName("cod_categoriadiario");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesDiario)
                    .HasColumnName("des_diario")
                    .IsUnicode(false);

                entity.Property(e => e.FlgAutomatico)
                    .HasColumnName("flg_automatico")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoadiario)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoadiario_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoadoc>(entity =>
            {
                entity.HasKey(e => e.CodPessoadoc);

                entity.ToTable("tb_cad_pessoadoc");

                entity.HasIndex(e => e.CodPessoa)
                    .HasName("UK_tb_cad_pessoadoc")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodPessoadoc, e.CodPessoa })
                    .HasName("sk_tb_cad_pessoadoc");

                entity.Property(e => e.CodPessoadoc).HasColumnName("cod_pessoadoc");

                entity.Property(e => e.CodPais).HasColumnName("cod_pais");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPisagencia).HasColumnName("cod_pisagencia");

                entity.Property(e => e.CodPisbanco).HasColumnName("cod_pisbanco");

                entity.Property(e => e.CodTiporg).HasColumnName("cod_tiporg");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCnhvalidade)
                    .HasColumnName("dat_cnhvalidade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCtpsemissao)
                    .HasColumnName("dat_ctpsemissao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPassemissao)
                    .HasColumnName("dat_passemissao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPassvalidade)
                    .HasColumnName("dat_passvalidade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPisemissao)
                    .HasColumnName("dat_pisemissao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatRgemissao)
                    .HasColumnName("dat_rgemissao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTitemissao)
                    .HasColumnName("dat_titemissao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatVistoemissao)
                    .HasColumnName("dat_vistoemissao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatVistovalidade)
                    .HasColumnName("dat_vistovalidade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCnhcateg)
                    .HasColumnName("des_cnhcateg")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DesCtpsserie)
                    .HasColumnName("des_ctpsserie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesCtpsuf)
                    .HasColumnName("des_ctpsuf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesRgorgao)
                    .HasColumnName("des_rgorgao")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesRguf)
                    .HasColumnName("des_rguf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesTitsecao)
                    .HasColumnName("des_titsecao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesTituf)
                    .HasColumnName("des_tituf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesTitzona)
                    .HasColumnName("des_titzona")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgCertidao)
                    .HasColumnName("flg_certidao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCnh)
                    .HasColumnName("flg_cnh")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCpf)
                    .HasColumnName("flg_cpf")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCtps)
                    .HasColumnName("flg_ctps")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPassaporte)
                    .HasColumnName("flg_passaporte")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPis)
                    .HasColumnName("flg_pis")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgRg)
                    .HasColumnName("flg_rg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTit)
                    .HasColumnName("flg_tit")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgVisto)
                    .HasColumnName("flg_visto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCertidao)
                    .HasColumnName("num_certidao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCnh)
                    .HasColumnName("num_cnh")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumCpf)
                    .HasColumnName("num_cpf")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumCtps)
                    .HasColumnName("num_ctps")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumPassaporte)
                    .HasColumnName("num_passaporte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumPis)
                    .HasColumnName("num_pis")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRg)
                    .HasColumnName("num_rg")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumTit)
                    .HasColumnName("num_tit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumVisto)
                    .HasColumnName("num_visto")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPisagenciaNavigation)
                    .WithMany(p => p.TbCadPessoadoc)
                    .HasForeignKey(d => d.CodPisagencia)
                    .HasConstraintName("FK_tb_cad_pessoadoc_tb_bas_agencia");

                entity.HasOne(d => d.CodPisbancoNavigation)
                    .WithMany(p => p.TbCadPessoadoc)
                    .HasForeignKey(d => d.CodPisbanco)
                    .HasConstraintName("FK_tb_cad_pessoadoc_tb_bas_banco");
            });

            modelBuilder.Entity<TbCadPessoadocdigitalizado>(entity =>
            {
                entity.HasKey(e => e.CodPessoadocdigitalizado);

                entity.ToTable("tb_cad_pessoadocdigitalizado");

                entity.HasIndex(e => new { e.NomArquivo, e.DesArquivo, e.CodPessoadocdigitalizado, e.CodPessoa, e.CodTipodocsdigitalizados })
                    .HasName("SK_tb_cad_docdigitalizado")
                    .IsUnique();

                entity.Property(e => e.CodPessoadocdigitalizado).HasColumnName("cod_pessoadocdigitalizado");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodTipodocsdigitalizados).HasColumnName("cod_tipodocsdigitalizados");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesArquivo)
                    .HasColumnName("des_arquivo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomArquivo)
                    .HasColumnName("nom_arquivo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoadocdigitalizado)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoadocdigitalizado_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoaexpprofissional>(entity =>
            {
                entity.HasKey(e => e.CodPessoaexpprofissional);

                entity.ToTable("tb_cad_pessoaexpprofissional");

                entity.HasIndex(e => new { e.CodPessoaexpprofissional, e.CodPessoa })
                    .HasName("sk_tb_cad_pessoaexpprofissional");

                entity.Property(e => e.CodPessoaexpprofissional).HasColumnName("cod_pessoaexpprofissional");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatFim)
                    .HasColumnName("dat_fim")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAtividades)
                    .HasColumnName("des_atividades")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesCargo)
                    .HasColumnName("des_cargo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesLocal)
                    .HasColumnName("des_local")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCondicao)
                    .HasColumnName("flg_condicao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomEmpresa)
                    .HasColumnName("nom_empresa")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValSalario)
                    .HasColumnName("val_salario")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoaexpprofissional)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoaexpprofissional_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoaficha>(entity =>
            {
                entity.HasKey(e => e.CodPessoaficha);

                entity.ToTable("tb_cad_pessoaficha");

                entity.HasIndex(e => e.CodPessoa)
                    .HasName("UK_tb_cad_pessoaficha")
                    .IsUnique();

                entity.Property(e => e.CodPessoaficha).HasColumnName("cod_pessoaficha");

                entity.Property(e => e.CodEstadocivil).HasColumnName("cod_estadocivil");

                entity.Property(e => e.CodNacionalidade).HasColumnName("cod_nacionalidade");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodRacacor).HasColumnName("cod_racacor");

                entity.Property(e => e.CodSexo)
                    .HasColumnName("cod_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTipocamiseta).HasColumnName("cod_tipocamiseta");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatNascto)
                    .HasColumnName("dat_nascto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAltura).HasColumnName("des_altura");

                entity.Property(e => e.DesApelido)
                    .HasColumnName("des_apelido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmailcomercial)
                    .HasColumnName("des_emailcomercial")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmailparticular)
                    .HasColumnName("des_emailparticular")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNomesolteiro)
                    .HasColumnName("des_nomesolteiro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.DesPeso).HasColumnName("des_peso");

                entity.Property(e => e.FlgEmailmktcomercial)
                    .HasColumnName("flg_emailmktcomercial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEmailmktparticular)
                    .HasColumnName("flg_emailmktparticular")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgFalecido)
                    .HasColumnName("flg_falecido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSmsSistema)
                    .HasColumnName("flg_sms_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.FlgVeterano)
                    .HasColumnName("flg_veterano")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumQtdefilhos).HasColumnName("num_qtdefilhos");

                entity.HasOne(d => d.CodEstadocivilNavigation)
                    .WithMany(p => p.TbCadPessoaficha)
                    .HasForeignKey(d => d.CodEstadocivil)
                    .HasConstraintName("FK_tb_cad_pessoaficha_tb_bas_estadocivil");

                entity.HasOne(d => d.CodNacionalidadeNavigation)
                    .WithMany(p => p.TbCadPessoaficha)
                    .HasForeignKey(d => d.CodNacionalidade)
                    .HasConstraintName("FK_tb_cad_pessoaficha_tb_bas_nacionalidade");

                entity.HasOne(d => d.CodRacacorNavigation)
                    .WithMany(p => p.TbCadPessoaficha)
                    .HasForeignKey(d => d.CodRacacor)
                    .HasConstraintName("FK_tb_cad_pessoaficha_tb_bas_racacor");
            });

            modelBuilder.Entity<TbCadPessoafichatelefone>(entity =>
            {
                entity.HasKey(e => e.CodPessoafichatelefone);

                entity.ToTable("tb_cad_pessoafichatelefone");

                entity.HasIndex(e => new { e.CodPessoafichatelefone, e.CodPessoa })
                    .HasName("sk_tb_cad_pessoafichatelefone");

                entity.HasIndex(e => new { e.CodPessoafichatelefone, e.CodPessoa, e.FlgPrincipal })
                    .HasName("UK_tb_cad_pessoafichatelefone")
                    .IsUnique();

                entity.Property(e => e.CodPessoafichatelefone).HasColumnName("cod_pessoafichatelefone");

                entity.Property(e => e.CodOperadora).HasColumnName("cod_operadora");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodTipotelefone).HasColumnName("cod_tipotelefone");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesDdd)
                    .HasColumnName("des_ddd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesDdi)
                    .HasColumnName("des_ddi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesHorarioatendimento)
                    .HasColumnName("des_horarioatendimento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesLocalidade)
                    .HasColumnName("des_localidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgPrincipal)
                    .HasColumnName("flg_principal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSmsmkt)
                    .HasColumnName("flg_smsmkt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumTelefone)
                    .HasColumnName("num_telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoafichatelefoneEmergencial>(entity =>
            {
                entity.HasKey(e => e.CodPessoafichatelefoneEmergencial);

                entity.ToTable("tb_cad_pessoafichatelefone_emergencial");

                entity.Property(e => e.CodPessoafichatelefoneEmergencial).HasColumnName("cod_pessoafichatelefone_emergencial");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesDdd)
                    .HasColumnName("des_ddd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesDdi)
                    .HasColumnName("des_ddi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FlgOrdem).HasColumnName("flg_ordem");

                entity.Property(e => e.NumTelefone)
                    .HasColumnName("num_telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodGrauparentescoNavigation)
                    .WithMany(p => p.TbCadPessoafichatelefoneEmergencial)
                    .HasForeignKey(d => d.CodGrauparentesco)
                    .HasConstraintName("FK_tb_cad_pessoafichatelefone_emergencial_tb_bas_grauparentesco");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoafichatelefoneEmergencial)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoafichatelefone_emergencial_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoaformacao>(entity =>
            {
                entity.HasKey(e => e.CodPessoaformacao);

                entity.ToTable("tb_cad_pessoaformacao");

                entity.Property(e => e.CodPessoaformacao).HasColumnName("cod_pessoaformacao");

                entity.Property(e => e.CodFormacaoescolar).HasColumnName("cod_formacaoescolar");

                entity.Property(e => e.CodFormacaoescolarcurso).HasColumnName("cod_formacaoescolarcurso");

                entity.Property(e => e.CodFormacaoescolarstatus).HasColumnName("cod_formacaoescolarstatus");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAno)
                    .HasColumnName("des_ano")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DesInstituicao)
                    .HasColumnName("des_instituicao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesLocalidade)
                    .HasColumnName("des_localidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesSerie)
                    .HasColumnName("des_serie")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodFormacaoescolarNavigation)
                    .WithMany(p => p.TbCadPessoaformacao)
                    .HasForeignKey(d => d.CodFormacaoescolar)
                    .HasConstraintName("FK_tb_cad_pessoaformacao_tb_bas_formacaoescolar");

                entity.HasOne(d => d.CodFormacaoescolarcursoNavigation)
                    .WithMany(p => p.TbCadPessoaformacao)
                    .HasForeignKey(d => d.CodFormacaoescolarcurso)
                    .HasConstraintName("FK_tb_cad_pessoaformacao_tb_bas_formacaoescolarcurso");
            });

            modelBuilder.Entity<TbCadPessoaformulario>(entity =>
            {
                entity.HasKey(e => e.CodPessoaformulario);

                entity.ToTable("tb_cad_pessoaformulario");

                entity.Property(e => e.CodPessoaformulario).HasColumnName("cod_pessoaformulario");

                entity.Property(e => e.CodFormulario).HasColumnName("cod_formulario");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoaformularioOrigem).HasColumnName("cod_pessoaformulario_origem");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatLiberacao)
                    .HasColumnName("dat_liberacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatLimite)
                    .HasColumnName("dat_limite")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesTermoAutorizacao)
                    .HasColumnName("des_termo_autorizacao")
                    .IsUnicode(false);

                entity.Property(e => e.FlgOculto)
                    .HasColumnName("flg_oculto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodFormularioNavigation)
                    .WithMany(p => p.TbCadPessoaformulario)
                    .HasForeignKey(d => d.CodFormulario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoaformulario_tb_cad_formulario");
            });

            modelBuilder.Entity<TbCadPessoaformulariores>(entity =>
            {
                entity.HasKey(e => e.CodPessoaformulariores);

                entity.ToTable("tb_cad_pessoaformulariores");

                entity.Property(e => e.CodPessoaformulariores).HasColumnName("cod_pessoaformulariores");

                entity.Property(e => e.CodItemformulario).HasColumnName("cod_itemformulario");

                entity.Property(e => e.CodPessoaformulario).HasColumnName("cod_pessoaformulario");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesComentario)
                    .HasColumnName("des_comentario")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DesResposta)
                    .HasColumnName("des_resposta")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPessoaformularioNavigation)
                    .WithMany(p => p.TbCadPessoaformulariores)
                    .HasForeignKey(d => d.CodPessoaformulario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoaformulariores_tb_cad_pessoaformulario");
            });

            modelBuilder.Entity<TbCadPessoaidacampante>(entity =>
            {
                entity.HasKey(e => e.CodPessoaidacampante);

                entity.ToTable("tb_cad_pessoaidacampante");

                entity.HasIndex(e => e.CodPessoa)
                    .HasName("sk_cod_pessoa");

                entity.HasIndex(e => e.CodPessoaidacampante)
                    .HasName("sk_cod_pessoaidacampante");

                entity.Property(e => e.CodPessoaidacampante).HasColumnName("cod_pessoaidacampante");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoaidacampantet).HasColumnName("cod_pessoaidacampantet");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoaidacampante)
                    .HasForeignKey(d => d.CodPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_cad_pessoaidacampante_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoaidioma>(entity =>
            {
                entity.HasKey(e => e.CodPessoaidioma);

                entity.ToTable("tb_cad_pessoaidioma");

                entity.Property(e => e.CodPessoaidioma).HasColumnName("cod_pessoaidioma");

                entity.Property(e => e.CodIdioma).HasColumnName("cod_idioma");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ValDominio).HasColumnName("val_dominio");
            });

            modelBuilder.Entity<TbCadPessoamidiasocial>(entity =>
            {
                entity.HasKey(e => e.CodPessoamidiasocial);

                entity.ToTable("tb_cad_pessoamidiasocial");

                entity.HasIndex(e => new { e.CodPessoamidiasocial, e.CodPessoa, e.CodMidiasocial })
                    .HasName("sk_tb_cad_pessoamidiasocial");

                entity.Property(e => e.CodPessoamidiasocial).HasColumnName("cod_pessoamidiasocial");

                entity.Property(e => e.CodMidiasocial).HasColumnName("cod_midiasocial");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIdentificacao)
                    .HasColumnName("des_identificacao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodMidiasocialNavigation)
                    .WithMany(p => p.TbCadPessoamidiasocial)
                    .HasForeignKey(d => d.CodMidiasocial)
                    .HasConstraintName("FK_tb_cad_pessoamidiasocial_tb_bas_midiassociais");
            });

            modelBuilder.Entity<TbCadPessoanecessespec>(entity =>
            {
                entity.HasKey(e => e.CodPessoanecessespec);

                entity.ToTable("tb_cad_pessoanecessespec");

                entity.HasIndex(e => new { e.CodPessoanecessespec, e.CodPessoa })
                    .HasName("sk_tb_cad_pessoanecessespec");

                entity.Property(e => e.CodPessoanecessespec).HasColumnName("cod_pessoanecessespec");

                entity.Property(e => e.CodNecessespecial).HasColumnName("cod_necessespecial");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodNecessespecialNavigation)
                    .WithMany(p => p.TbCadPessoanecessespec)
                    .HasForeignKey(d => d.CodNecessespecial)
                    .HasConstraintName("FK_tb_cad_pessoanecessespec_tb_bas_necessespecial");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoanecessespec)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoanecessespec_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoanrmail>(entity =>
            {
                entity.HasKey(e => e.CodPessoanrmail);

                entity.ToTable("tb_cad_pessoanrmail");

                entity.Property(e => e.CodPessoanrmail).HasColumnName("cod_pessoanrmail");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesPessoanrmail)
                    .HasColumnName("des_pessoanrmail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoapapel>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapel);

                entity.ToTable("tb_cad_pessoapapel");

                entity.HasIndex(e => e.CodPessoapapel)
                    .HasName("sk_tb_cad_pessoapapel");

                entity.HasIndex(e => new { e.CodCategoria, e.CodPessoa })
                    .HasName("idx_cod_pessoa");

                entity.Property(e => e.CodPessoapapel).HasColumnName("cod_pessoapapel");

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.FlgIndefinido)
                    .HasColumnName("flg_indefinido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.TbCadPessoapapel)
                    .HasForeignKey(d => d.CodCategoria)
                    .HasConstraintName("FK_tb_cad_pessoapapel_tb_bas_categoria");
            });

            modelBuilder.Entity<TbCadPessoapapelCarga>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapel);

                entity.ToTable("tb_cad_pessoapapel_carga");

                entity.Property(e => e.CodPessoapapel).HasColumnName("cod_pessoapapel");

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.FlgIndefinido)
                    .HasColumnName("flg_indefinido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.TbCadPessoapapelCarga)
                    .HasForeignKey(d => d.CodCategoria)
                    .HasConstraintName("FK_tb_cad_pessoapapel_carga_tb_bas_categoria");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoapapelCarga)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoapapel_carga_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoapapelreserva>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreserva);

                entity.ToTable("tb_cad_pessoapapelreserva");

                entity.HasIndex(e => new { e.FlgStatus, e.CodPacote, e.CodPessoa })
                    .HasName("sk_tb_cad_pessoapapelreserva");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodGrauparentescoresponsavel).HasColumnName("cod_grauparentescoresponsavel");

                entity.Property(e => e.CodMidia).HasColumnName("cod_midia");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoapapel).HasColumnName("cod_pessoapapel");

                entity.Property(e => e.CodResponsavel).HasColumnName("cod_responsavel");

                entity.Property(e => e.CodTipoRetiradacamiseta).HasColumnName("cod_tipo_retiradacamiseta");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatContratocantina)
                    .HasColumnName("dat_contratocantina")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatKitcorreio)
                    .HasColumnName("dat_kitcorreio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatLimiteinscricao)
                    .HasColumnName("dat_limiteinscricao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatRetiradacamiseta)
                    .HasColumnName("dat_retiradacamiseta")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIndicado)
                    .HasColumnName("des_indicado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.DesObsRetiradacamiseta)
                    .HasColumnName("des_obs_retiradacamiseta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgCantina)
                    .HasColumnName("flg_cantina")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPendenciafinanceira)
                    .HasColumnName("flg_pendenciafinanceira")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodGrauparentescoresponsavelNavigation)
                    .WithMany(p => p.TbCadPessoapapelreserva)
                    .HasForeignKey(d => d.CodGrauparentescoresponsavel)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_tb_bas_grauparentesco");

                entity.HasOne(d => d.CodMidiaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreserva)
                    .HasForeignKey(d => d.CodMidia)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_tb_bas_midia");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadPessoapapelreserva)
                    .HasForeignKey(d => d.CodPacote)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_tb_cad_pacote");

                entity.HasOne(d => d.CodPessoapapelNavigation)
                    .WithMany(p => p.TbCadPessoapapelreserva)
                    .HasForeignKey(d => d.CodPessoapapel)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_tb_cad_pessoapapel");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadPessoapapelreserva)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadPessoapapelreservaCarga>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreserva);

                entity.ToTable("tb_cad_pessoapapelreserva_carga");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodGrauparentescoresponsavel).HasColumnName("cod_grauparentescoresponsavel");

                entity.Property(e => e.CodMidia).HasColumnName("cod_midia");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoapapel).HasColumnName("cod_pessoapapel");

                entity.Property(e => e.CodResponsavel).HasColumnName("cod_responsavel");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatKitcorreio)
                    .HasColumnName("dat_kitcorreio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatLimiteinscricao)
                    .HasColumnName("dat_limiteinscricao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodGrauparentescoresponsavelNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaCarga)
                    .HasForeignKey(d => d.CodGrauparentescoresponsavel)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_carga_tb_bas_grauparentesco");

                entity.HasOne(d => d.CodMidiaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaCarga)
                    .HasForeignKey(d => d.CodMidia)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_carga_tb_bas_midia");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaCarga)
                    .HasForeignKey(d => d.CodPacote)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_carga_tb_cad_pacote");

                entity.HasOne(d => d.CodResponsavelNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaCarga)
                    .HasForeignKey(d => d.CodResponsavel)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_carga_tb_cad_pessoa");

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaCarga)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_carga_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadPessoapapelreservaDobra>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreservaDobra);

                entity.ToTable("tb_cad_pessoapapelreserva_dobra");

                entity.Property(e => e.CodPessoapapelreservaDobra).HasColumnName("cod_pessoapapelreserva_dobra");

                entity.Property(e => e.CodDobra).HasColumnName("cod_dobra");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.DatDobra)
                    .HasColumnName("dat_dobra")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaDobra)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_dobra_tb_cad_pessoa");

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaDobra)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_dobra_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadPessoapapelreservaTicket>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreservaTicket);

                entity.ToTable("tb_cad_pessoapapelreserva_ticket");

                entity.Property(e => e.CodPessoapapelreservaTicket).HasColumnName("cod_pessoapapelreserva_ticket");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodTicket).HasColumnName("cod_ticket");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgObrigatorio)
                    .HasColumnName("flg_obrigatorio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgUtilizado)
                    .HasColumnName("flg_utilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaTicket)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_ticket_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadPessoapapelreservaTicketind>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreservaTicketind);

                entity.ToTable("tb_cad_pessoapapelreserva_ticketind");

                entity.Property(e => e.CodPessoapapelreservaTicketind).HasColumnName("cod_pessoapapelreserva_ticketind");

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesTicketind)
                    .HasColumnName("des_ticketind")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAutomatico)
                    .HasColumnName("flg_automatico")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgObrigatorio)
                    .HasColumnName("flg_obrigatorio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTipo)
                    .HasColumnName("flg_tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTipoDesconto)
                    .HasColumnName("flg_tipo_desconto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PorTicketind)
                    .HasColumnName("por_ticketind")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValTicketind)
                    .HasColumnName("val_ticketind")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaTicketind)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_ticketind_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadPessoapapelreservaTransporte>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreservaTransporte)
                    .HasName("PK_tb_cad_pessoapapelreserva_transporte_1");

                entity.ToTable("tb_cad_pessoapapelreserva_transporte");

                entity.Property(e => e.CodPessoapapelreservaTransporte).HasColumnName("cod_pessoapapelreserva_transporte");

                entity.Property(e => e.CodMeiotransporteIda).HasColumnName("cod_meiotransporte_ida");

                entity.Property(e => e.CodMeiotransporteVolta).HasColumnName("cod_meiotransporte_volta");

                entity.Property(e => e.CodPacoteonibusPoltronaIda).HasColumnName("cod_pacoteonibus_poltrona_ida");

                entity.Property(e => e.CodPacoteonibusPoltronaVolta).HasColumnName("cod_pacoteonibus_poltrona_volta");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAlocacao)
                    .HasColumnName("dat_alocacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatChegadacarroIda)
                    .HasColumnName("dat_chegadacarro_ida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatChegadacarroVolta)
                    .HasColumnName("dat_chegadacarro_volta")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCarroIda)
                    .HasColumnName("des_carro_ida")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesCarroVolta)
                    .HasColumnName("des_carro_volta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesCondutorIda)
                    .HasColumnName("des_condutor_ida")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesCondutorVolta)
                    .HasColumnName("des_condutor_volta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesObstransporteIda)
                    .HasColumnName("des_obstransporte_ida")
                    .IsUnicode(false);

                entity.Property(e => e.DesObstransporteVolta)
                    .HasColumnName("des_obstransporte_volta")
                    .IsUnicode(false);

                entity.Property(e => e.DesPlacaIda)
                    .HasColumnName("des_placa_ida")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesPlacaVolta)
                    .HasColumnName("des_placa_volta")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodMeiotransporteIdaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaTransporteCodMeiotransporteIdaNavigation)
                    .HasForeignKey(d => d.CodMeiotransporteIda)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_transporte_tb_bas_meiotransporte");

                entity.HasOne(d => d.CodMeiotransporteVoltaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaTransporteCodMeiotransporteVoltaNavigation)
                    .HasForeignKey(d => d.CodMeiotransporteVolta)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_transporte_tb_bas_meiotransporte1");

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaTransporte)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapapelreserva_transporte_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadPessoapapelreservaent>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreservaent);

                entity.ToTable("tb_cad_pessoapapelreservaent");

                entity.Property(e => e.CodPessoapapelreservaent).HasColumnName("cod_pessoapapelreservaent");

                entity.Property(e => e.CodEntrevistador).HasColumnName("cod_entrevistador");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrevista)
                    .HasColumnName("dat_entrevista")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesDuracao)
                    .HasColumnName("des_duracao")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DesLocalentrevista)
                    .HasColumnName("des_localentrevista")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAvisar)
                    .HasColumnName("flg_avisar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCancelada)
                    .HasColumnName("flg_cancelada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgRealizada)
                    .HasColumnName("flg_realizada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgRemarcacao)
                    .HasColumnName("flg_remarcacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservaent)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapapelreservaent_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadPessoapapelreservahist>(entity =>
            {
                entity.HasKey(e => e.CodPessoapapelreservahist);

                entity.ToTable("tb_cad_pessoapapelreservahist");

                entity.Property(e => e.CodPessoapapelreservahist).HasColumnName("cod_pessoapapelreservahist");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesHistorico)
                    .HasColumnName("des_historico")
                    .IsUnicode(false);

                entity.Property(e => e.FlgAutomatico)
                    .HasColumnName("flg_automatico")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadPessoapapelreservahist)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapapelreservahist_tb_cad_pessoapapelreserva");
            });

            modelBuilder.Entity<TbCadPessoapremiacao>(entity =>
            {
                entity.HasKey(e => e.CodPessoapremiacao);

                entity.ToTable("tb_cad_pessoapremiacao");

                entity.HasIndex(e => new { e.CodPessoa, e.CodPacote, e.CodTipopremiacao, e.DatPremiacao })
                    .HasName("UK_tb_cad_pessoapremiacao")
                    .IsUnique();

                entity.Property(e => e.CodPessoapremiacao).HasColumnName("cod_pessoapremiacao");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodTipopremiacao).HasColumnName("cod_tipopremiacao");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPremiacao)
                    .HasColumnName("dat_premiacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesComentarios)
                    .HasColumnName("des_comentarios")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadPessoapremiacao)
                    .HasForeignKey(d => d.CodPacote)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapremiacao_tb_cad_pacote");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadPessoapremiacao)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_pessoapremiacao_tb_cad_pessoa");

                entity.HasOne(d => d.CodTipopremiacaoNavigation)
                    .WithMany(p => p.TbCadPessoapremiacao)
                    .HasForeignKey(d => d.CodTipopremiacao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_pessoapremiacao_tb_bas_tipopremiacao");
            });

            modelBuilder.Entity<TbCadPessoarel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_pessoarel");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoadep).HasColumnName("cod_pessoadep");

                entity.Property(e => e.CodPessoarel)
                    .HasColumnName("cod_pessoarel")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodTipovinculopessoa).HasColumnName("cod_tipovinculopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoarel20161201>(entity =>
            {
                entity.HasKey(e => e.CodPessoarel)
                    .HasName("PK_tb_cad_pessoarel");

                entity.ToTable("tb_cad_pessoarel_20161201");

                entity.HasIndex(e => new { e.CodPessoadep, e.CodTipovinculopessoa, e.CodPessoa })
                    .HasName("idx_cod_pessoa");

                entity.Property(e => e.CodPessoarel).HasColumnName("cod_pessoarel");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoadep).HasColumnName("cod_pessoadep");

                entity.Property(e => e.CodTipovinculopessoa).HasColumnName("cod_tipovinculopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodGrauparentescoNavigation)
                    .WithMany(p => p.TbCadPessoarel20161201)
                    .HasForeignKey(d => d.CodGrauparentesco)
                    .HasConstraintName("FK_tb_cad_pessoarel_tb_bas_grauparentesco");

                entity.HasOne(d => d.CodPessoadepNavigation)
                    .WithMany(p => p.TbCadPessoarel20161201)
                    .HasForeignKey(d => d.CodPessoadep)
                    .HasConstraintName("FK_tb_cad_pessoarel_tb_cad_pessoa");
            });

            modelBuilder.Entity<TbCadPessoarel20161220>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_pessoarel_20161220");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoadep).HasColumnName("cod_pessoadep");

                entity.Property(e => e.CodPessoarel)
                    .HasColumnName("cod_pessoarel")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodTipovinculopessoa).HasColumnName("cod_tipovinculopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoarelBkp20160118>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_pessoarel_bkp_20160118");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoadep).HasColumnName("cod_pessoadep");

                entity.Property(e => e.CodPessoarel)
                    .HasColumnName("cod_pessoarel")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodTipovinculopessoa).HasColumnName("cod_tipovinculopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoarelBkp20160509>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_pessoarel_bkp_20160509");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoadep).HasColumnName("cod_pessoadep");

                entity.Property(e => e.CodPessoarel)
                    .HasColumnName("cod_pessoarel")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodTipovinculopessoa).HasColumnName("cod_tipovinculopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoarelBkp20160615>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_pessoarel_bkp_20160615");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoadep).HasColumnName("cod_pessoadep");

                entity.Property(e => e.CodPessoarel)
                    .HasColumnName("cod_pessoarel")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodTipovinculopessoa).HasColumnName("cod_tipovinculopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoarelBkp20161201>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_pessoarel_bkp_20161201");

                entity.Property(e => e.CodGrauparentesco).HasColumnName("cod_grauparentesco");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoadep).HasColumnName("cod_pessoadep");

                entity.Property(e => e.CodPessoarel)
                    .HasColumnName("cod_pessoarel")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodTipovinculopessoa).HasColumnName("cod_tipovinculopessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadPessoares>(entity =>
            {
                entity.HasKey(e => e.CodPessoares);

                entity.ToTable("tb_cad_pessoares");

                entity.HasIndex(e => new { e.CodPessoares, e.CodPessoa })
                    .HasName("sk_tb_cad_pessoares");

                entity.HasIndex(e => new { e.DesLogradouro, e.DesBairro, e.DesUf, e.DesNumero, e.DesCidade, e.CodPessoa })
                    .HasName("idx_cod_pessoa");

                entity.Property(e => e.CodPessoares).HasColumnName("cod_pessoares");

                entity.Property(e => e.CodPais).HasColumnName("cod_pais");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesNumero)
                    .HasColumnName("des_numero")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndExt)
                    .HasColumnName("end_ext")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgReside)
                    .HasColumnName("flg_reside")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadPropostacomercial>(entity =>
            {
                entity.HasKey(e => e.CodPropostacomercial);

                entity.ToTable("tb_cad_propostacomercial");

                entity.Property(e => e.CodPropostacomercial).HasColumnName("cod_propostacomercial");

                entity.Property(e => e.CodDocumento).HasColumnName("cod_documento");

                entity.Property(e => e.CodEvento).HasColumnName("cod_evento");

                entity.Property(e => e.CodSolicitacaocontato).HasColumnName("cod_solicitacaocontato");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAprovacaocli)
                    .HasColumnName("dat_aprovacaocli")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAprovacaonr)
                    .HasColumnName("dat_aprovacaonr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesComentario)
                    .HasColumnName("des_comentario")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesComentarioaprovacao)
                    .HasColumnName("des_comentarioaprovacao")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesDocumento)
                    .HasColumnName("des_documento")
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAprovadocli)
                    .HasColumnName("flg_aprovadocli")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAprovadonr)
                    .HasColumnName("flg_aprovadonr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnviado)
                    .HasColumnName("flg_enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSolicitaraprovacao)
                    .HasColumnName("flg_solicitaraprovacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomArquivo)
                    .HasColumnName("nom_arquivo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumAlunos).HasColumnName("num_alunos");

                entity.Property(e => e.ValAluno)
                    .HasColumnName("val_aluno")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CodSolicitacaocontatoNavigation)
                    .WithMany(p => p.TbCadPropostacomercial)
                    .HasForeignKey(d => d.CodSolicitacaocontato)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_propostacomercial_tb_cad_solicitacaocontato");
            });

            modelBuilder.Entity<TbCadPushMensagem>(entity =>
            {
                entity.HasKey(e => e.CodPushMensagem);

                entity.ToTable("tb_cad_push_mensagem");

                entity.Property(e => e.CodPushMensagem).HasColumnName("cod_push_mensagem");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEnviar)
                    .HasColumnName("dat_enviar")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesImgUrl)
                    .HasColumnName("des_img_url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DesLinkUrl)
                    .HasColumnName("des_link_url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DesLote)
                    .HasColumnName("des_lote")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipo)
                    .HasColumnName("des_tipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgEnviado)
                    .HasColumnName("flg_enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TbCadPushMensagemToken>(entity =>
            {
                entity.HasKey(e => e.CodPushMensagemToken);

                entity.ToTable("tb_cad_push_mensagem_token");

                entity.Property(e => e.CodPushMensagemToken).HasColumnName("cod_push_mensagem_token");

                entity.Property(e => e.CodPushMensagem).HasColumnName("cod_push_mensagem");

                entity.Property(e => e.CodPushToken).HasColumnName("cod_push_token");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgEnviado)
                    .HasColumnName("flg_enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgRecebido)
                    .HasColumnName("flg_recebido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPushMensagemNavigation)
                    .WithMany(p => p.TbCadPushMensagemToken)
                    .HasForeignKey(d => d.CodPushMensagem)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_push_mensagem_token_cod_push_mensagem");

                entity.HasOne(d => d.CodPushTokenNavigation)
                    .WithMany(p => p.TbCadPushMensagemToken)
                    .HasForeignKey(d => d.CodPushToken)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_push_mensagem_token_cod_push_token");
            });

            modelBuilder.Entity<TbCadPushToken>(entity =>
            {
                entity.HasKey(e => e.CodPushToken);

                entity.ToTable("tb_cad_push_token");

                entity.Property(e => e.CodPushToken).HasColumnName("cod_push_token");

                entity.Property(e => e.CodEscolaUrl)
                    .HasColumnName("cod_escola_url")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodIdPessoa)
                    .HasColumnName("cod_id_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatNascto)
                    .HasColumnName("dat_nascto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLocalizacao)
                    .HasColumnName("des_localizacao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone)
                    .HasColumnName("des_telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesToken)
                    .HasColumnName("des_token")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgPerfil)
                    .HasColumnName("flg_perfil")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPushAniversario)
                    .HasColumnName("flg_push_aniversario")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgPushEvento)
                    .HasColumnName("flg_push_evento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomPessoa)
                    .HasColumnName("nom_pessoa")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadRemessa>(entity =>
            {
                entity.HasKey(e => e.CodRemessa);

                entity.ToTable("tb_cad_remessa");

                entity.Property(e => e.CodRemessa).HasColumnName("cod_remessa");

                entity.Property(e => e.DatRemessa)
                    .HasColumnName("dat_remessa")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesArquivoremessa)
                    .IsRequired()
                    .HasColumnName("des_arquivoremessa")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesRemessa).HasColumnName("des_remessa");
            });

            modelBuilder.Entity<TbCadRepresentante>(entity =>
            {
                entity.HasKey(e => e.CodRepresentante);

                entity.ToTable("tb_cad_representante");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodCidade).HasColumnName("cod_cidade");

                entity.Property(e => e.CodUf)
                    .HasColumnName("cod_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInfoadicional)
                    .HasColumnName("des_infoadicional")
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone)
                    .HasColumnName("des_telefone")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadRepresentanteagencia>(entity =>
            {
                entity.HasKey(e => e.CodRepresentanteagencia);

                entity.ToTable("tb_cad_representanteagencia");

                entity.Property(e => e.CodRepresentanteagencia).HasColumnName("cod_representanteagencia");

                entity.Property(e => e.CodAgenciarepresentante).HasColumnName("cod_agenciarepresentante");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.TbCadRepresentanteagencia)
                    .HasForeignKey(d => d.CodUsuario)
                    .HasConstraintName("FK_tb_cad_representanteagencia_tb_cad_usuario");
            });

            modelBuilder.Entity<TbCadRetorno>(entity =>
            {
                entity.HasKey(e => e.CodRetorno);

                entity.ToTable("tb_cad_retorno");

                entity.Property(e => e.CodRetorno).HasColumnName("cod_retorno");

                entity.Property(e => e.CbAgenciaCedente)
                    .HasColumnName("cb_agencia_cedente")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CbCodNomeBanco)
                    .HasColumnName("cb_cod_nome_banco")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CbContaCedente)
                    .HasColumnName("cb_conta_cedente")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CbConvenio)
                    .HasColumnName("cb_convenio")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CbDataGravacao)
                    .HasColumnName("cb_data_gravacao")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CbDvAgenciaCedente)
                    .HasColumnName("cb_dv_agencia_cedente")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CbDvContaCedente)
                    .HasColumnName("cb_dv_conta_cedente")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CbIdTipoOperacao)
                    .HasColumnName("cb_id_tipo_operacao")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CbIdTipoServico)
                    .HasColumnName("cb_id_tipo_servico")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CbNomeCedente)
                    .HasColumnName("cb_nome_cedente")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CbNumeroConvenio)
                    .HasColumnName("cb_numero_convenio")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CbSequencialReg)
                    .HasColumnName("cb_sequencial_reg")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CbSequencialRet)
                    .HasColumnName("cb_sequencial_ret")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CbTipoOperacao)
                    .HasColumnName("cb_tipo_operacao")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CbTipoServico)
                    .HasColumnName("cb_tipo_servico")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DatRetorno)
                    .HasColumnName("dat_retorno")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesArquivoretorno)
                    .HasColumnName("des_arquivoretorno")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesRegistro)
                    .IsRequired()
                    .HasColumnName("des_registro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesRegistroRodape)
                    .HasColumnName("des_registro_rodape")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RdCobCaucNumAviso)
                    .HasColumnName("rd_cob_cauc_num_aviso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobCaucQtdTitulos)
                    .HasColumnName("rd_cob_cauc_qtd_titulos")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobCaucVlrTotal)
                    .HasColumnName("rd_cob_cauc_vlr_total")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobDescNumAviso)
                    .HasColumnName("rd_cob_desc_num_aviso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobDescQtdTitulos)
                    .HasColumnName("rd_cob_desc_qtd_titulos")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobDescVlrTotal)
                    .HasColumnName("rd_cob_desc_vlr_total")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobSimplesNumAviso)
                    .HasColumnName("rd_cob_simples_num_aviso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobSimplesQtdTitulos)
                    .HasColumnName("rd_cob_simples_qtd_titulos")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobSimplesVlrTotal)
                    .HasColumnName("rd_cob_simples_vlr_total")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobVendorNumAviso)
                    .HasColumnName("rd_cob_vendor_num_aviso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobVendorQtdTitulos)
                    .HasColumnName("rd_cob_vendor_qtd_titulos")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobVendorVlrTotal)
                    .HasColumnName("rd_cob_vendor_vlr_total")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobVincNumAviso)
                    .HasColumnName("rd_cob_vinc_num_aviso")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobVincQtdTitulos)
                    .HasColumnName("rd_cob_vinc_qtd_titulos")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RdCobVincValorTotal)
                    .HasColumnName("rd_cob_vinc_valor_total")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RdSequencialReg)
                    .HasColumnName("rd_sequencial_reg")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadRetornoConteudo>(entity =>
            {
                entity.HasKey(e => e.CodRetornoConteudo)
                    .HasName("PK__tb_cad_r__C364F765DA067A87");

                entity.ToTable("tb_cad_retorno_conteudo");

                entity.HasIndex(e => e.CodRetorno)
                    .HasName("FK_tb_cad_retorno_conteudo_tb_cad_retorno");

                entity.Property(e => e.CodRetornoConteudo).HasColumnName("cod_retorno_conteudo");

                entity.Property(e => e.CodRetorno).HasColumnName("cod_retorno");

                entity.Property(e => e.CtAbatimentoNAprov)
                    .HasColumnName("ct_abatimento_n_aprov")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtAgencia)
                    .HasColumnName("ct_agencia")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtAgenciaReceb)
                    .HasColumnName("ct_agencia_receb")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtBancoCredito1)
                    .HasColumnName("ct_banco_credito1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtBancoCredito2)
                    .HasColumnName("ct_banco_credito2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtBancoCredito3)
                    .HasColumnName("ct_banco_credito3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtBancoCredito4)
                    .HasColumnName("ct_banco_credito4")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtCamaraCompensacao1)
                    .HasColumnName("ct_camara_compensacao1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtCamaraCompensacao2)
                    .HasColumnName("ct_camara_compensacao2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtCamaraCompensacao3)
                    .HasColumnName("ct_camara_compensacao3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtCamaraCompensacao4)
                    .HasColumnName("ct_camara_compensacao4")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtCanalPagTitulo)
                    .HasColumnName("ct_canal_pag_titulo")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtCarteira)
                    .HasColumnName("ct_carteira")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtCcCedente)
                    .HasColumnName("ct_cc_cedente")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CtCodBanco)
                    .HasColumnName("ct_cod_banco")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtCodTipoDocComprador)
                    .HasColumnName("ct_cod_tipo_doc_comprador")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtComando)
                    .HasColumnName("ct_comando")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtConfirmacao)
                    .HasColumnName("ct_confirmacao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtContaCaucao)
                    .HasColumnName("ct_conta_caucao")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtContaCredito1)
                    .HasColumnName("ct_conta_credito1")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CtContaCredito2)
                    .HasColumnName("ct_conta_credito2")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CtContaCredito3)
                    .HasColumnName("ct_conta_credito3")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CtContaCredito4)
                    .HasColumnName("ct_conta_credito4")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CtControle)
                    .HasColumnName("ct_controle")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CtConvenio)
                    .HasColumnName("ct_convenio")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CtConversaoCnab240)
                    .HasColumnName("ct_conversao_cnab240")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtDataBbvendor)
                    .HasColumnName("ct_data_bbvendor")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CtDataCredito)
                    .HasColumnName("ct_data_credito")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtDataPagamento)
                    .HasColumnName("ct_data_pagamento")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtDataVencimento)
                    .HasColumnName("ct_data_vencimento")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtDescontoConcedido)
                    .HasColumnName("ct_desconto_concedido")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtDiasCalculo)
                    .HasColumnName("ct_dias_calculo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvAgCredito1)
                    .HasColumnName("ct_dv_ag_credito1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvAgCredito2)
                    .HasColumnName("ct_dv_ag_credito2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvAgCredito3)
                    .HasColumnName("ct_dv_ag_credito3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvAgCredito4)
                    .HasColumnName("ct_dv_ag_credito4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvAgencia)
                    .HasColumnName("ct_dv_agencia")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvAgenciaReceb)
                    .HasColumnName("ct_dv_agencia_receb")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvCcCedente)
                    .HasColumnName("ct_dv_cc_cedente")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvContaCredito1)
                    .HasColumnName("ct_dv_conta_credito1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvContaCredito2)
                    .HasColumnName("ct_dv_conta_credito2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvContaCredito3)
                    .HasColumnName("ct_dv_conta_credito3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvContaCredito4)
                    .HasColumnName("ct_dv_conta_credito4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtDvNossoNumero)
                    .HasColumnName("ct_dv_nosso_numero")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtEmails)
                    .HasColumnName("ct_emails")
                    .HasMaxLength(137)
                    .IsUnicode(false);

                entity.Property(e => e.CtEspecie)
                    .HasColumnName("ct_especie")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtIndCredDeb)
                    .HasColumnName("ct_ind_cred_deb")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtIndEpocaEqualizacao)
                    .HasColumnName("ct_ind_epoca_equalizacao")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtIndNatEqualizacao25)
                    .HasColumnName("ct_ind_nat_equalizacao25")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtIndNatEqualizacao26)
                    .HasColumnName("ct_ind_nat_equalizacao26")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtIndNaturEqualizacao)
                    .HasColumnName("ct_ind_natur_equalizacao")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtIndicadorValor)
                    .HasColumnName("ct_indicador_valor")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtIndicativoDc)
                    .HasColumnName("ct_indicativo_dc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtIofDesconto)
                    .HasColumnName("ct_iof_desconto")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtJurosDesconto)
                    .HasColumnName("ct_juros_desconto")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtJurosMora)
                    .HasColumnName("ct_juros_mora")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtLiquidacaoParcial)
                    .HasColumnName("ct_liquidacao_parcial")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtMotivoDevolucao)
                    .HasColumnName("ct_motivo_devolucao")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtNatureza)
                    .HasColumnName("ct_natureza")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtNomeComprador)
                    .HasColumnName("ct_nome_comprador")
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.CtNomeFavorecido1)
                    .HasColumnName("ct_nome_favorecido1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtNomeFavorecido2)
                    .HasColumnName("ct_nome_favorecido2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtNomeFavorecido3)
                    .HasColumnName("ct_nome_favorecido3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtNomeFavorecido4)
                    .HasColumnName("ct_nome_favorecido4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CtNossoNumero)
                    .HasColumnName("ct_nosso_numero")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CtNossonumero17posicoes)
                    .HasColumnName("ct_nossonumero_17posicoes")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CtNovoValorTitulo)
                    .HasColumnName("ct_novo_valor_titulo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtNumDocFavorecido1)
                    .HasColumnName("ct_num_doc_favorecido1")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CtNumDocFavorecido2)
                    .HasColumnName("ct_num_doc_favorecido2")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CtNumDocFavorecido3)
                    .HasColumnName("ct_num_doc_favorecido3")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CtNumDocFavorecido4)
                    .HasColumnName("ct_num_doc_favorecido4")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CtNumDocumentoComprador)
                    .HasColumnName("ct_num_documento_comprador")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CtNumOperacaoBbvendor)
                    .HasColumnName("ct_num_operacao_bbvendor")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CtNumTitulo)
                    .HasColumnName("ct_num_titulo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtOutrasDespesas)
                    .HasColumnName("ct_outras_despesas")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtOutrosRecebimentos)
                    .HasColumnName("ct_outros_recebimentos")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtPrazobloqCheque)
                    .HasColumnName("ct_prazobloq_cheque")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtPreAgCredito1)
                    .HasColumnName("ct_pre_ag_credito1")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtPreAgCredito2)
                    .HasColumnName("ct_pre_ag_credito2")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtPreAgCredito3)
                    .HasColumnName("ct_pre_ag_credito3")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtPreAgCredito4)
                    .HasColumnName("ct_pre_ag_credito4")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtSequencialReg)
                    .HasColumnName("ct_sequencial_reg")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CtTaxaDesconto)
                    .HasColumnName("ct_taxa_desconto")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtTaxaIof)
                    .HasColumnName("ct_taxa_iof")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoCaptura)
                    .HasColumnName("ct_tipo_captura")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoCobranca)
                    .HasColumnName("ct_tipo_cobranca")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoCobrancaCmd72)
                    .HasColumnName("ct_tipo_cobranca_cmd72")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoDocFavorecido1)
                    .HasColumnName("ct_tipo_doc_favorecido1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoDocFavorecido2)
                    .HasColumnName("ct_tipo_doc_favorecido2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoDocFavorecido3)
                    .HasColumnName("ct_tipo_doc_favorecido3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoDocFavorecido4)
                    .HasColumnName("ct_tipo_doc_favorecido4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtTipoServico)
                    .HasColumnName("ct_tipo_servico")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CtTrilhaCheque)
                    .HasColumnName("ct_trilha_cheque")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.CtTxJurosComprador)
                    .HasColumnName("ct_tx_juros_comprador")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtTxJurosVendedor)
                    .HasColumnName("ct_tx_juros_vendedor")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtUsoBanco1)
                    .HasColumnName("ct_uso_banco1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CtUsoBanco2)
                    .HasColumnName("ct_uso_banco2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtUsoBanco3)
                    .HasColumnName("ct_uso_banco3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtValEfetPartilha1)
                    .HasColumnName("ct_val_efet_partilha1")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValEfetPartilha2)
                    .HasColumnName("ct_val_efet_partilha2")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValEfetPartilha3)
                    .HasColumnName("ct_val_efet_partilha3")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValEfetPartilha4)
                    .HasColumnName("ct_val_efet_partilha4")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValInfoPartilha1)
                    .HasColumnName("ct_val_info_partilha1")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValInfoPartilha2)
                    .HasColumnName("ct_val_info_partilha2")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValInfoPartilha3)
                    .HasColumnName("ct_val_info_partilha3")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValInfoPartilha4)
                    .HasColumnName("ct_val_info_partilha4")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorAbatimento)
                    .HasColumnName("ct_valor_abatimento")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorAcumuladoAbat)
                    .HasColumnName("ct_valor_acumulado_abat")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorAjuste)
                    .HasColumnName("ct_valor_ajuste")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorCheque)
                    .HasColumnName("ct_valor_cheque")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorComissaoPerm)
                    .HasColumnName("ct_valor_comissao_perm")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorDifEqualizacao)
                    .HasColumnName("ct_valor_dif_equalizacao")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorEncargComp)
                    .HasColumnName("ct_valor_encarg_comp")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorEqualizacao)
                    .HasColumnName("ct_valor_equalizacao")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorEqualizacaoEst)
                    .HasColumnName("ct_valor_equalizacao_est")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorIofFinanciado)
                    .HasColumnName("ct_valor_iof_financiado")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorIofNfinanciado)
                    .HasColumnName("ct_valor_iof_nfinanciado")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorIofPeriodoatraso)
                    .HasColumnName("ct_valor_iof_periodoatraso")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorIofProrrogacao)
                    .HasColumnName("ct_valor_iof_prorrogacao")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorJurosProrrogacao)
                    .HasColumnName("ct_valor_juros_prorrogacao")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorLancamento)
                    .HasColumnName("ct_valor_lancamento")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorNovaEqualizacao)
                    .HasColumnName("ct_valor_nova_equalizacao")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorOriginalVenda)
                    .HasColumnName("ct_valor_original_venda")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorPagamento)
                    .HasColumnName("ct_valor_pagamento")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorTarifa)
                    .HasColumnName("ct_valor_tarifa")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorTitulo)
                    .HasColumnName("ct_valor_titulo")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CtValorTituloVenc)
                    .HasColumnName("ct_valor_titulo_venc")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CtVariacaoCarteira)
                    .HasColumnName("ct_variacao_carteira")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesRegistro)
                    .HasColumnName("des_registro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodRetornoNavigation)
                    .WithMany(p => p.TbCadRetornoConteudo)
                    .HasForeignKey(d => d.CodRetorno)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_retorno_conteudo_tb_cad_retorno");
            });

            modelBuilder.Entity<TbCadSmsComunicacaoTransporte>(entity =>
            {
                entity.HasKey(e => e.CodSmsComunicacaoTransporte);

                entity.ToTable("tb_cad_sms_comunicacao_transporte");

                entity.Property(e => e.CodSmsComunicacaoTransporte).HasColumnName("cod_sms_comunicacao_transporte");

                entity.Property(e => e.CodMeiotransporte).HasColumnName("cod_meiotransporte");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgOperacao)
                    .HasColumnName("flg_operacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodMeiotransporteNavigation)
                    .WithMany(p => p.TbCadSmsComunicacaoTransporte)
                    .HasForeignKey(d => d.CodMeiotransporte)
                    .HasConstraintName("FK_tb_cad_sms_comunicacao_transporte_tb_bas_meiotransporte");

                entity.HasOne(d => d.CodPacoteNavigation)
                    .WithMany(p => p.TbCadSmsComunicacaoTransporte)
                    .HasForeignKey(d => d.CodPacote)
                    .HasConstraintName("FK_tb_cad_sms_comunicacao_transporte_tb_cad_pacote");
            });

            modelBuilder.Entity<TbCadSmsComunicacaoTransportehist>(entity =>
            {
                entity.HasKey(e => e.CodSmsComunicacaoTransportehist);

                entity.ToTable("tb_cad_sms_comunicacao_transportehist");

                entity.Property(e => e.CodSmsComunicacaoTransportehist).HasColumnName("cod_sms_comunicacao_transportehist");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodResponsavel).HasColumnName("cod_responsavel");

                entity.Property(e => e.CodSmsComunicacaoTransporte).HasColumnName("cod_sms_comunicacao_transporte");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NumCelular)
                    .HasColumnName("num_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPessoapapelreservaNavigation)
                    .WithMany(p => p.TbCadSmsComunicacaoTransportehist)
                    .HasForeignKey(d => d.CodPessoapapelreserva)
                    .HasConstraintName("FK_tb_cad_sms_comunicacao_transportehist_tb_cad_pessoapapelreserva");

                entity.HasOne(d => d.CodResponsavelNavigation)
                    .WithMany(p => p.TbCadSmsComunicacaoTransportehist)
                    .HasForeignKey(d => d.CodResponsavel)
                    .HasConstraintName("FK_tb_cad_sms_comunicacao_transportehist_tb_cad_pessoa");

                entity.HasOne(d => d.CodSmsComunicacaoTransporteNavigation)
                    .WithMany(p => p.TbCadSmsComunicacaoTransportehist)
                    .HasForeignKey(d => d.CodSmsComunicacaoTransporte)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_sms_comunicacao_transportehist_tb_cad_sms_comunicacao_transporte");
            });

            modelBuilder.Entity<TbCadSolicitacaocontato>(entity =>
            {
                entity.HasKey(e => e.CodSolicitacaocontato);

                entity.ToTable("tb_cad_solicitacaocontato");

                entity.Property(e => e.CodSolicitacaocontato).HasColumnName("cod_solicitacaocontato");

                entity.Property(e => e.CodAgenciarepresentante).HasColumnName("cod_agenciarepresentante");

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodPermanencia).HasColumnName("cod_permanencia");

                entity.Property(e => e.CodTipoevento)
                    .HasColumnName("cod_tipoevento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodUsuarioalocado).HasColumnName("cod_usuarioalocado");

                entity.Property(e => e.DatAssociacao)
                    .HasColumnName("dat_associacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEvento)
                    .HasColumnName("dat_evento")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatFechamento)
                    .HasColumnName("dat_fechamento")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatMesevento).HasColumnName("dat_mesevento");

                entity.Property(e => e.DatPrimeiraproposta)
                    .HasColumnName("dat_primeiraproposta")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPropostacliente)
                    .HasColumnName("dat_propostacliente")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatPropostanr)
                    .HasColumnName("dat_propostanr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatUltimaproposta)
                    .HasColumnName("dat_ultimaproposta")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesCargo)
                    .HasColumnName("des_cargo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCelular)
                    .HasColumnName("des_celular")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesComentarios)
                    .HasColumnName("des_comentarios")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DesDddCelular)
                    .HasColumnName("des_ddd_celular")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesDddTelefone1)
                    .HasColumnName("des_ddd_telefone1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesDddTelefone2)
                    .HasColumnName("des_ddd_telefone2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesMotivofechamento)
                    .HasColumnName("des_motivofechamento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesSeries)
                    .HasColumnName("des_series")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone1)
                    .HasColumnName("des_telefone1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone2)
                    .HasColumnName("des_telefone2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomContato)
                    .HasColumnName("nom_contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumAlunos).HasColumnName("num_alunos");
            });

            modelBuilder.Entity<TbCadSolicitacaocontatoevento>(entity =>
            {
                entity.HasKey(e => e.CodSolicitacaocontatoevento);

                entity.ToTable("tb_cad_solicitacaocontatoevento");

                entity.Property(e => e.CodSolicitacaocontatoevento).HasColumnName("cod_solicitacaocontatoevento");

                entity.Property(e => e.CodEvento).HasColumnName("cod_evento");

                entity.Property(e => e.CodSolicitacaocontato).HasColumnName("cod_solicitacaocontato");
            });

            modelBuilder.Entity<TbCadSolicitacaocontatohist>(entity =>
            {
                entity.HasKey(e => e.CodSolicitacaocontatohist);

                entity.ToTable("tb_cad_solicitacaocontatohist");

                entity.Property(e => e.CodSolicitacaocontatohist).HasColumnName("cod_solicitacaocontatohist");

                entity.Property(e => e.CodSolicitacaocontato).HasColumnName("cod_solicitacaocontato");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatHistorico)
                    .HasColumnName("dat_historico")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesHistorico)
                    .HasColumnName("des_historico")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadTempchaleDistribuicao>(entity =>
            {
                entity.HasKey(e => e.CodTempchaleDistribuicao);

                entity.ToTable("tb_cad_tempchale_distribuicao");

                entity.Property(e => e.CodTempchaleDistribuicao).HasColumnName("cod_tempchale_distribuicao");

                entity.Property(e => e.CodDistribuicaochale).HasColumnName("cod_distribuicaochale");

                entity.Property(e => e.CodTemporadachale).HasColumnName("cod_temporadachale");

                entity.Property(e => e.DesQtde).HasColumnName("des_qtde");

                entity.HasOne(d => d.CodTemporadachaleNavigation)
                    .WithMany(p => p.TbCadTempchaleDistribuicao)
                    .HasForeignKey(d => d.CodTemporadachale)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_tempchale_distribuicao_tb_cad_temporadachale");
            });

            modelBuilder.Entity<TbCadTempchaleDistribuicaoCarga>(entity =>
            {
                entity.HasKey(e => e.CodTempchaleDistribuicao);

                entity.ToTable("tb_cad_tempchale_distribuicao_carga");

                entity.Property(e => e.CodTempchaleDistribuicao).HasColumnName("cod_tempchale_distribuicao");

                entity.Property(e => e.CodDistribuicaochale).HasColumnName("cod_distribuicaochale");

                entity.Property(e => e.CodTemporadachale).HasColumnName("cod_temporadachale");

                entity.Property(e => e.DesQtde).HasColumnName("des_qtde");

                entity.HasOne(d => d.CodTemporadachaleNavigation)
                    .WithMany(p => p.TbCadTempchaleDistribuicaoCarga)
                    .HasForeignKey(d => d.CodTemporadachale)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_tempchale_distribuicao_carga_tb_cad_temporadachale");
            });

            modelBuilder.Entity<TbCadTemporada>(entity =>
            {
                entity.HasKey(e => e.CodTemporada);

                entity.ToTable("tb_cad_temporada");

                entity.HasIndex(e => new { e.DesTemporada, e.DesIdadeinicial, e.DesIdadefinal, e.DesSaida, e.DesChegada, e.DatSaida, e.DatChegada, e.CodTemporada, e.CodUnidadenr })
                    .HasName("sk_tb_cad_temporada");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodCalouro).HasColumnName("cod_calouro");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatChegada)
                    .HasColumnName("dat_chegada")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesChegada)
                    .HasColumnName("des_chegada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEndchegada)
                    .HasColumnName("des_endchegada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEndsaida)
                    .HasColumnName("des_endsaida")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesGuiaacampante)
                    .HasColumnName("des_guiaacampante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIdadefinal).HasColumnName("des_idadefinal");

                entity.Property(e => e.DesIdadeinicial).HasColumnName("des_idadeinicial");

                entity.Property(e => e.DesSaida)
                    .HasColumnName("des_saida")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTemporada)
                    .HasColumnName("des_temporada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTurmanr)
                    .HasColumnName("des_turmanr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgIdade)
                    .HasColumnName("flg_idade")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgIndicacao)
                    .HasColumnName("flg_indicacao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgListaespera)
                    .HasColumnName("flg_listaespera")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTurmanr)
                    .HasColumnName("flg_turmanr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadTemporada)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_temporada_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadTemporadaCarga>(entity =>
            {
                entity.HasKey(e => e.CodTemporada);

                entity.ToTable("tb_cad_temporada_carga");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodCalouro).HasColumnName("cod_calouro");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatChegada)
                    .HasColumnName("dat_chegada")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatInicio)
                    .HasColumnName("dat_inicio")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatTermino)
                    .HasColumnName("dat_termino")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidade)
                    .HasColumnName("dat_validade")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesChegada)
                    .HasColumnName("des_chegada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEndchegada)
                    .HasColumnName("des_endchegada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEndsaida)
                    .HasColumnName("des_endsaida")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIdadefinal).HasColumnName("des_idadefinal");

                entity.Property(e => e.DesIdadeinicial).HasColumnName("des_idadeinicial");

                entity.Property(e => e.DesSaida)
                    .HasColumnName("des_saida")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTemporada)
                    .HasColumnName("des_temporada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTurmanr)
                    .HasColumnName("des_turmanr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgIdade)
                    .HasColumnName("flg_idade")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgListaespera)
                    .HasColumnName("flg_listaespera")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTurmanr)
                    .HasColumnName("flg_turmanr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadTemporadaCarga)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .HasConstraintName("FK_tb_cad_temporada_carga_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadTemporadachale>(entity =>
            {
                entity.HasKey(e => e.CodTemporadachale);

                entity.ToTable("tb_cad_temporadachale");

                entity.HasIndex(e => new { e.CodTemporadachale, e.CodTemporada, e.CodChale })
                    .HasName("sk_tb_cad_temporadachale");

                entity.Property(e => e.CodTemporadachale).HasColumnName("cod_temporadachale");

                entity.Property(e => e.CodChale).HasColumnName("cod_chale");

                entity.Property(e => e.CodGenero)
                    .HasColumnName("cod_genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.CodChaleNavigation)
                    .WithMany(p => p.TbCadTemporadachale)
                    .HasForeignKey(d => d.CodChale)
                    .HasConstraintName("FK_tb_cad_temporadachale_tb_cad_chale");

                entity.HasOne(d => d.CodGeneroNavigation)
                    .WithMany(p => p.TbCadTemporadachale)
                    .HasForeignKey(d => d.CodGenero)
                    .HasConstraintName("FK_tb_cad_temporadachale_tb_bas_genero");

                entity.HasOne(d => d.CodTemporadaNavigation)
                    .WithMany(p => p.TbCadTemporadachale)
                    .HasForeignKey(d => d.CodTemporada)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_temporadachale_tb_cad_temporada");
            });

            modelBuilder.Entity<TbCadTemporadachaleCarga>(entity =>
            {
                entity.HasKey(e => e.CodTemporadachale);

                entity.ToTable("tb_cad_temporadachale_carga");

                entity.Property(e => e.CodTemporadachale).HasColumnName("cod_temporadachale");

                entity.Property(e => e.CodChale).HasColumnName("cod_chale");

                entity.Property(e => e.CodGenero)
                    .HasColumnName("cod_genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.CodChaleNavigation)
                    .WithMany(p => p.TbCadTemporadachaleCarga)
                    .HasForeignKey(d => d.CodChale)
                    .HasConstraintName("FK_tb_cad_temporadachale_carga_tb_cad_chale");

                entity.HasOne(d => d.CodGeneroNavigation)
                    .WithMany(p => p.TbCadTemporadachaleCarga)
                    .HasForeignKey(d => d.CodGenero)
                    .HasConstraintName("FK_tb_cad_temporadachale_carga_tb_bas_genero");

                entity.HasOne(d => d.CodTemporadaNavigation)
                    .WithMany(p => p.TbCadTemporadachaleCarga)
                    .HasForeignKey(d => d.CodTemporada)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_temporadachale_carga_tb_cad_temporada");
            });

            modelBuilder.Entity<TbCadTemporadaequipe>(entity =>
            {
                entity.HasKey(e => e.CodTemporadaequipe);

                entity.ToTable("tb_cad_temporadaequipe");

                entity.Property(e => e.CodTemporadaequipe).HasColumnName("cod_temporadaequipe");

                entity.Property(e => e.CodChale).HasColumnName("cod_chale");

                entity.Property(e => e.CodResponsavelchale).HasColumnName("cod_responsavelchale");

                entity.Property(e => e.CodTemporadaturma).HasColumnName("cod_temporadaturma");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEquipe)
                    .HasColumnName("des_equipe")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadTemporadaequipeFoto>(entity =>
            {
                entity.HasKey(e => e.CodTemporadaequipeFoto);

                entity.ToTable("tb_cad_temporadaequipe_foto");

                entity.Property(e => e.CodTemporadaequipeFoto).HasColumnName("cod_temporadaequipe_foto");

                entity.Property(e => e.CodTemporadaequipe).HasColumnName("cod_temporadaequipe");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesImagem)
                    .HasColumnName("des_imagem")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodTemporadaequipeNavigation)
                    .WithMany(p => p.TbCadTemporadaequipeFoto)
                    .HasForeignKey(d => d.CodTemporadaequipe)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_temporadaequipe_foto_tb_cad_temporadaequipe");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.TbCadTemporadaequipeFoto)
                    .HasForeignKey(d => d.CodUsuario)
                    .HasConstraintName("FK_tb_cad_temporadaequipe_foto_tb_cad_usuario");
            });

            modelBuilder.Entity<TbCadTemporadaequipeFotopessoa>(entity =>
            {
                entity.HasKey(e => e.CodTemporadaequipeFotopessoa);

                entity.ToTable("tb_cad_temporadaequipe_fotopessoa");

                entity.Property(e => e.CodTemporadaequipeFotopessoa).HasColumnName("cod_temporadaequipe_fotopessoa");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodTemporadaequipeFoto).HasColumnName("cod_temporadaequipe_foto");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesIdentificacao)
                    .HasColumnName("des_identificacao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesLeft).HasColumnName("des_left");

                entity.Property(e => e.DesTop).HasColumnName("des_top");

                entity.Property(e => e.ValOrdem).HasColumnName("val_ordem");
            });

            modelBuilder.Entity<TbCadTemporadaequipePessoas>(entity =>
            {
                entity.HasKey(e => e.CodTemporadaequipePessoas);

                entity.ToTable("tb_cad_temporadaequipe_pessoas");

                entity.Property(e => e.CodTemporadaequipePessoas).HasColumnName("cod_temporadaequipe_pessoas");

                entity.Property(e => e.CodDistribuicaochale).HasColumnName("cod_distribuicaochale");

                entity.Property(e => e.CodFormulario).HasColumnName("cod_formulario");

                entity.Property(e => e.CodFormularioAltura).HasColumnName("cod_formulario_altura");

                entity.Property(e => e.CodFormularioPeso).HasColumnName("cod_formulario_peso");

                entity.Property(e => e.CodItemformulario).HasColumnName("cod_itemformulario");

                entity.Property(e => e.CodItemformularioAltura).HasColumnName("cod_itemformulario_altura");

                entity.Property(e => e.CodItemformularioPeso).HasColumnName("cod_itemformulario_peso");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodTemporadaequipe).HasColumnName("cod_temporadaequipe");

                entity.Property(e => e.CodTurmanr).HasColumnName("cod_turmanr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodDistribuicaochaleNavigation)
                    .WithMany(p => p.TbCadTemporadaequipePessoas)
                    .HasForeignKey(d => d.CodDistribuicaochale)
                    .HasConstraintName("FK_tb_cad_temporadaequipe_pessoas_tb_bas_distribuicaochale");

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadTemporadaequipePessoas)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_temporadaequipe_pessoas_tb_cad_pessoa");

                entity.HasOne(d => d.CodTemporadaequipeNavigation)
                    .WithMany(p => p.TbCadTemporadaequipePessoas)
                    .HasForeignKey(d => d.CodTemporadaequipe)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_temporadaequipe_pessoas_tb_cad_temporadaequipe");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.TbCadTemporadaequipePessoas)
                    .HasForeignKey(d => d.CodUsuario)
                    .HasConstraintName("FK_tb_cad_temporadaequipe_pessoas_tb_cad_usuario");
            });

            modelBuilder.Entity<TbCadTemporadaturma>(entity =>
            {
                entity.HasKey(e => e.CodTemporadaturma);

                entity.ToTable("tb_cad_temporadaturma");

                entity.HasIndex(e => new { e.CodTemporada, e.DesTurma })
                    .HasName("UK_TB_CAD_TEMPORADATURMA")
                    .IsUnique();

                entity.Property(e => e.CodTemporadaturma).HasColumnName("cod_temporadaturma");

                entity.Property(e => e.CodGenero)
                    .HasColumnName("cod_genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesObs)
                    .HasColumnName("des_obs")
                    .IsUnicode(false);

                entity.Property(e => e.DesTurma)
                    .IsRequired()
                    .HasColumnName("des_turma")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadTeste>(entity =>
            {
                entity.HasKey(e => e.CodTeste);

                entity.ToTable("TB_CAD_TESTE");

                entity.Property(e => e.CodTeste).HasColumnName("COD_TESTE");

                entity.Property(e => e.CpfTeste)
                    .HasColumnName("CPF_TESTE")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomTeste)
                    .HasColumnName("NOM_TESTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadTicket>(entity =>
            {
                entity.HasKey(e => e.CodTicket);

                entity.ToTable("tb_cad_ticket");

                entity.Property(e => e.CodTicket).HasColumnName("cod_ticket");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesTicket)
                    .HasColumnName("des_ticket")
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgTipo)
                    .HasColumnName("flg_tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomTicket)
                    .HasColumnName("nom_ticket")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValTicket)
                    .HasColumnName("val_ticket")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbCadTipopapel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cad_tipopapel");

                entity.HasIndex(e => e.CodTipopapel)
                    .HasName("PK_tb_cad_tipopapel")
                    .IsUnique();

                entity.Property(e => e.CodTipopapel).HasColumnName("cod_tipopapel");

                entity.Property(e => e.DesTipopapel)
                    .HasColumnName("des_tipopapel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DesTipopapelred)
                    .HasColumnName("des_tipopapelred")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadTurmanr>(entity =>
            {
                entity.HasKey(e => e.CodTurmanr);

                entity.ToTable("tb_cad_turmanr");

                entity.Property(e => e.CodTurmanr).HasColumnName("cod_turmanr");

                entity.Property(e => e.CodPacote).HasColumnName("cod_pacote");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodTurmanrUnif1).HasColumnName("cod_turmanr_unif1");

                entity.Property(e => e.CodTurmanrUnif2).HasColumnName("cod_turmanr_unif2");

                entity.Property(e => e.DatAbertura)
                    .HasColumnName("dat_abertura")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TbCadTurmanrAcampante>(entity =>
            {
                entity.HasKey(e => e.CodTurmanrAcampante);

                entity.ToTable("tb_cad_turmanr_acampante");

                entity.Property(e => e.CodTurmanrAcampante).HasColumnName("cod_turmanr_acampante");

                entity.Property(e => e.CodInscricao).HasColumnName("cod_inscricao");

                entity.Property(e => e.CodInscricaoConvite).HasColumnName("cod_inscricao_convite");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoaConvite).HasColumnName("cod_pessoa_convite");

                entity.Property(e => e.CodTemporada).HasColumnName("cod_temporada");

                entity.Property(e => e.CodTemporadaConvite).HasColumnName("cod_temporada_convite");

                entity.Property(e => e.CodTurmanr).HasColumnName("cod_turmanr");

                entity.Property(e => e.DatAceitacao)
                    .HasColumnName("dat_aceitacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlgAceito)
                    .HasColumnName("flg_aceito")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodPessoaNavigation)
                    .WithMany(p => p.TbCadTurmanrAcampante)
                    .HasForeignKey(d => d.CodPessoa)
                    .HasConstraintName("FK_tb_cad_turmanr_acampante_tb_cad_pessoa");

                entity.HasOne(d => d.CodTurmanrNavigation)
                    .WithMany(p => p.TbCadTurmanrAcampante)
                    .HasForeignKey(d => d.CodTurmanr)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tb_cad_turmanr_acampante_tb_cad_turmanr");
            });

            modelBuilder.Entity<TbCadTurmanrlog>(entity =>
            {
                entity.HasKey(e => e.CodTurmanrlog);

                entity.ToTable("tb_cad_turmanrlog");

                entity.Property(e => e.CodTurmanrlog).HasColumnName("cod_turmanrlog");

                entity.Property(e => e.CodTurmanr).HasColumnName("cod_turmanr");

                entity.Property(e => e.DesLog)
                    .HasColumnName("des_log")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCadUnidadenr>(entity =>
            {
                entity.HasKey(e => e.CodUnidadenr);

                entity.ToTable("tb_cad_unidadenr");

                entity.HasIndex(e => new { e.DesUnidadenr, e.FlgMatriz })
                    .HasName("UK_tb_cad_unidadenr")
                    .IsUnique();

                entity.Property(e => e.CodUnidadenr)
                    .HasColumnName("cod_unidadenr")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodEmpFilialSapiens).HasColumnName("cod_emp_filial_sapiens");

                entity.Property(e => e.CodEmpfilialSapiensCliente)
                    .HasColumnName("cod_empfilial_sapiens_cliente")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Campo para salvar as Empresas e Filiais do SAPIENS que o cliente deve ser cadastrado a partir da Ficha de Inscrição.");

                entity.Property(e => e.CodFilialSapiens).HasColumnName("cod_filial_sapiens");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesComplemento)
                    .HasColumnName("des_complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesDdd)
                    .HasColumnName("des_ddd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesFax)
                    .HasColumnName("des_fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouro)
                    .HasColumnName("des_logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesLogradouroNumero)
                    .HasColumnName("des_logradouro_numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesMercado)
                    .HasColumnName("des_mercado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesPais)
                    .HasColumnName("des_pais")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesPortaEmail)
                    .HasColumnName("des_porta_email")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenhaEmail)
                    .HasColumnName("des_senha_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesServidorEmail)
                    .HasColumnName("des_servidor_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone)
                    .HasColumnName("des_telefone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DesUnidadenr)
                    .HasColumnName("des_unidadenr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUsuarioEmail)
                    .HasColumnName("des_usuario_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgMatriz)
                    .HasColumnName("flg_matriz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgSistema)
                    .HasColumnName("flg_sistema")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadUsuario>(entity =>
            {
                entity.HasKey(e => e.CodIdUsuario);

                entity.ToTable("tb_cad_usuario");

                entity.HasIndex(e => e.DesEmail)
                    .HasName("UK_tb_cad_usuario_2")
                    .IsUnique();

                entity.Property(e => e.CodIdUsuario).HasColumnName("cod_id_usuario");

                entity.Property(e => e.CodDepto).HasColumnName("cod_depto");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodVisibilidade).HasColumnName("cod_visibilidade");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatCadastro)
                    .HasColumnName("dat_cadastro")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatUltimoLogon)
                    .HasColumnName("dat_ultimo_logon")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatValidadeSenha)
                    .HasColumnName("dat_validade_senha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesFoto)
                    .HasColumnName("des_foto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesIdioma)
                    .HasColumnName("des_idioma")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DesIp)
                    .HasColumnName("des_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DesSenha)
                    .HasColumnName("des_senha")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExpirada)
                    .HasColumnName("flg_expirada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomUsuario)
                    .HasColumnName("nom_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodUnidadenrNavigation)
                    .WithMany(p => p.TbCadUsuario)
                    .HasForeignKey(d => d.CodUnidadenr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_cad_usuario_tb_cad_unidadenr");
            });

            modelBuilder.Entity<TbCadUsuarioatalho>(entity =>
            {
                entity.HasKey(e => e.CodUsuarioatalho);

                entity.ToTable("tb_cad_usuarioatalho");

                entity.HasIndex(e => new { e.CodUsuarioatalho, e.CodUsuario, e.CodFuncionalidade })
                    .HasName("sk_tb_cad_usuarioatalho");

                entity.Property(e => e.CodUsuarioatalho).HasColumnName("cod_usuarioatalho");

                entity.Property(e => e.CodFuncionalidade).HasColumnName("cod_funcionalidade");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.HasOne(d => d.CodFuncionalidadeNavigation)
                    .WithMany(p => p.TbCadUsuarioatalho)
                    .HasForeignKey(d => d.CodFuncionalidade)
                    .HasConstraintName("FK_tb_cad_usuarioatalho_tb_bas_funcionalidade");
            });

            modelBuilder.Entity<TbCronPush>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cron_push");

                entity.Property(e => e.FlgStatus)
                    .HasColumnName("flg_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbImpPessoares>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_imp_pessoares");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoares).HasColumnName("cod_pessoares");
            });

            modelBuilder.Entity<TbImpPessoares2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_imp_pessoares2");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoares).HasColumnName("cod_pessoares");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtualizado)
                    .HasColumnName("flg_atualizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Logradouro)
                    .HasColumnName("logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbRptLogCartaoSistema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_rpt_log_cartao_sistema");

                entity.Property(e => e.Acao)
                    .HasColumnName("ACAO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cartao)
                    .HasColumnName("CARTAO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("COD_PEDIDO");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Escola)
                    .HasColumnName("ESCOLA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Evento)
                    .HasColumnName("EVENTO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Funcionalidade)
                    .HasColumnName("FUNCIONALIDADE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gateway)
                    .HasColumnName("GATEWAY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hora)
                    .HasColumnName("HORA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Parcelas).HasColumnName("PARCELAS");

                entity.Property(e => e.Portador)
                    .HasColumnName("PORTADOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QtdCartao)
                    .HasColumnName("QTD_CARTAO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .HasColumnName("SISTEMA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transacao)
                    .HasColumnName("TRANSACAO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario).HasColumnName("USUARIO");

                entity.Property(e => e.ValorParcela)
                    .HasColumnName("VALOR_PARCELA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("VALOR_TOTAL")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbTempDescontoirmao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_temp_descontoirmao");

                entity.Property(e => e.CodCategoria).HasColumnName("cod_categoria");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodPessoapapelreserva).HasColumnName("cod_pessoapapelreserva");

                entity.Property(e => e.CodSession)
                    .HasColumnName("cod_session")
                    .IsUnicode(false);

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ValAbatimento).HasColumnName("val_abatimento");

                entity.Property(e => e.ValPacote)
                    .HasColumnName("val_pacote")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbTempEquipeacampante>(entity =>
            {
                entity.HasKey(e => e.CodEquipeacampante);

                entity.ToTable("tb_temp_equipeacampante");

                entity.Property(e => e.CodEquipeacampante).HasColumnName("cod_equipeacampante");

                entity.Property(e => e.CodPessoa).HasColumnName("cod_pessoa");

                entity.Property(e => e.CodTemporadaequipe).HasColumnName("cod_temporadaequipe");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBeliche)
                    .HasColumnName("des_beliche")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbTempEscEvento>(entity =>
            {
                entity.HasKey(e => e.CodEscTmpEvento);

                entity.ToTable("tb_temp_esc_evento");

                entity.Property(e => e.CodEscTmpEvento).HasColumnName("cod_esc_tmp_evento");

                entity.Property(e => e.AnoParcelamento).HasColumnName("ano_parcelamento");

                entity.Property(e => e.AnoParcelamentoFixo).HasColumnName("ano_parcelamento_fixo");

                entity.Property(e => e.AnoParcelamentoRegressivo).HasColumnName("ano_parcelamento_regressivo");

                entity.Property(e => e.CodEscUrl)
                    .HasColumnName("cod_esc_url")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtivar)
                    .HasColumnName("dat_ativar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("dat_entrada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexoOrganizadores)
                    .HasColumnName("des_anexo_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesCorpoemailOrganizadores)
                    .HasColumnName("des_corpoemail_organizadores")
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .HasColumnName("des_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImgQrcode)
                    .HasColumnName("des_img_qrcode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoesAdicionais)
                    .HasColumnName("des_informacoes_adicionais")
                    .IsUnicode(false);

                entity.Property(e => e.DesOrganizadores)
                    .HasColumnName("des_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAppCelular)
                    .HasColumnName("flg_app_celular")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivar)
                    .HasColumnName("flg_ativar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBloquear)
                    .HasColumnName("flg_bloquear")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCupom)
                    .HasColumnName("flg_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnvioOrganizadores)
                    .HasColumnName("flg_envio_organizadores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeBoleto)
                    .HasColumnName("flg_exibe_boleto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeCartao)
                    .HasColumnName("flg_exibe_cartao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MesParcelamento).HasColumnName("mes_parcelamento");

                entity.Property(e => e.MesParcelamentoFixo).HasColumnName("mes_parcelamento_fixo");

                entity.Property(e => e.MesParcelamentoRegressivo).HasColumnName("mes_parcelamento_regressivo");

                entity.Property(e => e.NumTotalVagas).HasColumnName("num_total_vagas");

                entity.Property(e => e.QtdBloquearDia).HasColumnName("qtd_bloquear_dia");

                entity.Property(e => e.QtdParcelamento).HasColumnName("qtd_parcelamento");

                entity.Property(e => e.QtdParcelamentoFixo).HasColumnName("qtd_parcelamento_fixo");

                entity.Property(e => e.QtdParcelamentoRegressivo).HasColumnName("qtd_parcelamento_regressivo");

                entity.Property(e => e.ValBoleto)
                    .HasColumnName("val_boleto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValEscola)
                    .HasColumnName("val_escola")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValNr)
                    .HasColumnName("val_nr")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TbTempEscEvento20180219>(entity =>
            {
                entity.HasKey(e => e.CodEscTmpEvento);

                entity.ToTable("tb_temp_esc_evento_20180219");

                entity.Property(e => e.CodEscTmpEvento).HasColumnName("cod_esc_tmp_evento");

                entity.Property(e => e.AnoParcelamento).HasColumnName("ano_parcelamento");

                entity.Property(e => e.AnoParcelamentoFixo).HasColumnName("ano_parcelamento_fixo");

                entity.Property(e => e.AnoParcelamentoRegressivo).HasColumnName("ano_parcelamento_regressivo");

                entity.Property(e => e.CodEscUrl)
                    .HasColumnName("cod_esc_url")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEscola).HasColumnName("cod_escola");

                entity.Property(e => e.CodEvento)
                    .HasColumnName("cod_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido).HasColumnName("cod_pedido");

                entity.Property(e => e.CodRepresentante).HasColumnName("cod_representante");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtivar)
                    .HasColumnName("dat_ativar")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("dat_entrada")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("dat_saida")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesAnexoOrganizadores)
                    .HasColumnName("des_anexo_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContrato)
                    .HasColumnName("des_contrato")
                    .IsUnicode(false);

                entity.Property(e => e.DesCorpoemailOrganizadores)
                    .HasColumnName("des_corpoemail_organizadores")
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .HasColumnName("des_escola")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .HasColumnName("des_evento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesImgQrcode)
                    .HasColumnName("des_img_qrcode")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesInformacoesAdicionais)
                    .HasColumnName("des_informacoes_adicionais")
                    .IsUnicode(false);

                entity.Property(e => e.DesOrganizadores)
                    .HasColumnName("des_organizadores")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("des_representante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAppCelular)
                    .HasColumnName("flg_app_celular")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgAtivar)
                    .HasColumnName("flg_ativar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgBloquear)
                    .HasColumnName("flg_bloquear")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgCupom)
                    .HasColumnName("flg_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlgEmitenteSapiens)
                    .HasColumnName("flg_emitente_sapiens")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgEnvioOrganizadores)
                    .HasColumnName("flg_envio_organizadores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeBoleto)
                    .HasColumnName("flg_exibe_boleto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlgExibeCartao)
                    .HasColumnName("flg_exibe_cartao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MesParcelamento).HasColumnName("mes_parcelamento");

                entity.Property(e => e.MesParcelamentoFixo).HasColumnName("mes_parcelamento_fixo");

                entity.Property(e => e.MesParcelamentoRegressivo).HasColumnName("mes_parcelamento_regressivo");

                entity.Property(e => e.NumTotalVagas).HasColumnName("num_total_vagas");

                entity.Property(e => e.QtdBloquearDia).HasColumnName("qtd_bloquear_dia");

                entity.Property(e => e.QtdParcelamento).HasColumnName("qtd_parcelamento");

                entity.Property(e => e.QtdParcelamentoFixo).HasColumnName("qtd_parcelamento_fixo");

                entity.Property(e => e.QtdParcelamentoRegressivo).HasColumnName("qtd_parcelamento_regressivo");

                entity.Property(e => e.ValBoleto)
                    .HasColumnName("val_boleto")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValEscola)
                    .HasColumnName("val_escola")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValNr)
                    .HasColumnName("val_nr")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<VwBoletosSapiens>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BOLETOS_SAPIENS");

                entity.Property(e => e.Codcli).HasColumnName("CODCLI");

                entity.Property(e => e.Codemp).HasColumnName("CODEMP");

                entity.Property(e => e.Codfil).HasColumnName("CODFIL");

                entity.Property(e => e.Codtns)
                    .IsRequired()
                    .HasColumnName("CODTNS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Codtpt)
                    .IsRequired()
                    .HasColumnName("CODTPT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Datemi)
                    .HasColumnName("DATEMI")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datent)
                    .HasColumnName("DATENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Numtit)
                    .IsRequired()
                    .HasColumnName("NUMTIT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Obstcr)
                    .HasColumnName("OBSTCR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sittit)
                    .IsRequired()
                    .HasColumnName("SITTIT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Titban)
                    .HasColumnName("TITBAN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuPedido).HasColumnName("USU_PEDIDO");

                entity.Property(e => e.Vctpro)
                    .HasColumnName("VCTPRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Vlrabe)
                    .HasColumnName("VLRABE")
                    .HasColumnType("numeric(15, 2)");

                entity.Property(e => e.Vlrori)
                    .HasColumnName("VLRORI")
                    .HasColumnType("numeric(15, 2)");
            });

            modelBuilder.Entity<VwLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_log");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesFuncionalidade)
                    .HasColumnName("des_funcionalidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesMensagem)
                    .HasColumnName("des_mensagem")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .HasColumnName("nom_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwNrTransporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_NR_TRANSPORTE");

                entity.Property(e => e.CodigoAcampante).HasColumnName("CODIGO_ACAMPANTE");

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("DATA_NASCIMENTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomeAcampante)
                    .HasColumnName("NOME_ACAMPANTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OnibusVolta)
                    .HasColumnName("ONIBUS_VOLTA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OninusIda)
                    .HasColumnName("ONINUS_IDA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pacote)
                    .HasColumnName("PACOTE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PoltronaIda).HasColumnName("POLTRONA_IDA");

                entity.Property(e => e.PoltronaVolta).HasColumnName("POLTRONA_VOLTA");

                entity.Property(e => e.Rg)
                    .HasColumnName("RG")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Unidade)
                    .HasColumnName("UNIDADE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwParametro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_parametro");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesChave)
                    .HasColumnName("des_chave")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesExplicacao)
                    .HasColumnName("des_explicacao")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .HasColumnName("nom_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValParametro)
                    .HasColumnName("val_parametro")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwParametronr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_parametronr");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesChave)
                    .HasColumnName("des_chave")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesExplicacao)
                    .HasColumnName("des_explicacao")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DesUnidadenr)
                    .HasColumnName("des_unidadenr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .HasColumnName("nom_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValParametro)
                    .HasColumnName("val_parametro")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUnidadenr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_unidadenr");

                entity.Property(e => e.CodUnidadenr).HasColumnName("cod_unidadenr");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.DatAtualizacao)
                    .HasColumnName("dat_atualizacao")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DesBairro)
                    .HasColumnName("des_bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesCep)
                    .HasColumnName("des_cep")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DesCidade)
                    .HasColumnName("des_cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesContato)
                    .HasColumnName("des_contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEmail)
                    .HasColumnName("des_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesEndereco)
                    .HasColumnName("des_endereco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesFax)
                    .HasColumnName("des_fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesMercado)
                    .IsRequired()
                    .HasColumnName("des_mercado")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DesPais)
                    .HasColumnName("des_pais")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DesTelefone)
                    .HasColumnName("des_telefone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("des_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DesUnidadenr)
                    .HasColumnName("des_unidadenr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlgAtivo)
                    .HasColumnName("flg_ativo")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.NomUsuario)
                    .HasColumnName("nom_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUspJobEscEvento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_USP_JOB_ESC_EVENTO");

                entity.Property(e => e.CodEscola).HasColumnName("COD_ESCOLA");

                entity.Property(e => e.CodEvento)
                    .IsRequired()
                    .HasColumnName("COD_EVENTO")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodPedido)
                    .HasColumnName("COD_PEDIDO")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.CodRepresentante)
                    .HasColumnName("COD_REPRESENTANTE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodUnidadenr)
                    .HasColumnName("COD_UNIDADENR")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DatEntrada)
                    .HasColumnName("DAT_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatSaida)
                    .HasColumnName("DAT_SAIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesCidade)
                    .HasColumnName("DES_CIDADE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DesEscola)
                    .IsRequired()
                    .HasColumnName("DES_ESCOLA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesEvento)
                    .IsRequired()
                    .HasColumnName("DES_EVENTO")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DesRepresentante)
                    .HasColumnName("DES_REPRESENTANTE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesUf)
                    .HasColumnName("DES_UF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.QtdParcela).HasColumnName("QTD_PARCELA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
