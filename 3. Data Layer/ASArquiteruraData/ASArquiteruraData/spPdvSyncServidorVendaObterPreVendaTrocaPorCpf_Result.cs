
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ASArquiteruraData
{

using System;
    
public partial class spPdvSyncServidorVendaObterPreVendaTrocaPorCpf_Result
{

    public int vendaPv_id { get; set; }

    public System.DateTime vendaPv_data_preVenda { get; set; }

    public int uneg_id { get; set; }

    public int venda_pdv { get; set; }

    public Nullable<int> venda_id { get; set; }

    public Nullable<System.DateTime> venda_data { get; set; }

    public string vendaPv_num_preVenda { get; set; }

    public string vendaPv_num_comanda { get; set; }

    public Nullable<decimal> vendaPv_valorTotal { get; set; }

    public Nullable<decimal> vendaPv_valorTroco { get; set; }

    public Nullable<decimal> vendaPv_vlr_creditos { get; set; }

    public Nullable<decimal> vendaPv_desconto_final { get; set; }

    public Nullable<int> vendaPv_itens { get; set; }

    public Nullable<int> vendaPv_volmes { get; set; }

    public string vendaPv_observacao { get; set; }

    public Nullable<int> vendaPv_vendedor_id { get; set; }

    public Nullable<int> vendaPv_atendente_id { get; set; }

    public string vendaPv_situacao { get; set; }

    public string vendaPv_tip_pedido { get; set; }

    public string vendaPv_tip_faturamento { get; set; }

    public string vendaPv_dispositivo { get; set; }

    public Nullable<int> vendaPv_id_origem { get; set; }

    public Nullable<System.DateTime> vendaPv_data_preVenda_origem { get; set; }

    public Nullable<int> uneg_id_origem { get; set; }

    public Nullable<int> venda_pdv_origem { get; set; }

    public Nullable<int> vendaPv_end_cobranca { get; set; }

    public Nullable<System.DateTime> vendaPv_dt_entrega { get; set; }

    public Nullable<int> vendaPv_telefone_id { get; set; }

    public string vendaPv_paf_numero { get; set; }

    public string vendaPv_pbm_autorizacao_num { get; set; }

    public string vendaPv_pbm_autorizacao_tipo { get; set; }

    public Nullable<long> vendaPv_pbm_cpf { get; set; }

    public Nullable<long> vendaPv_pbm_cnpj { get; set; }

    public Nullable<decimal> vendaPv_pbm_avista { get; set; }

    public Nullable<decimal> vendaPv_pbm_reembolso { get; set; }

    public string vendaPv_pedido_compra_cliente { get; set; }

    public Nullable<int> vendaPv_cancela_vendedor_id { get; set; }

    public Nullable<System.DateTime> vendaPv_cancela_data { get; set; }

    public string vendaPv_cancela_motivo { get; set; }

    public Nullable<System.DateTime> vendaPv_entrega_dt_separacao { get; set; }

    public Nullable<System.DateTime> vendaPv_entrega_dt_retorno { get; set; }

    public Nullable<int> vendaPv_entrega_id_entregador { get; set; }

    public string vendaPv_status { get; set; }

    public Nullable<System.DateTime> vendaPv_data_alteracao { get; set; }

    public string vendaPv_nome_arquivo { get; set; }

    public string vendaPv_chave_acesso_nfe { get; set; }

    public string vendaPv_ecf_dv { get; set; }

    public string vendaPv_coo_dv { get; set; }

    public string vendaPv_chave_nfce_dv { get; set; }

    public string cli_fisc_cpf_cnpj { get; set; }

    public Nullable<long> cli_id { get; set; }

    public Nullable<int> cnv_id { get; set; }

    public Nullable<int> pbm_id { get; set; }

    public Nullable<long> end_telefone { get; set; }

    public Nullable<int> polo_id { get; set; }

    public Nullable<int> quadra_id { get; set; }

    public Nullable<int> rota_id { get; set; }

    public Nullable<int> arearisco_id { get; set; }

    public long cli_id1 { get; set; }

    public string cli_email { get; set; }

    public Nullable<decimal> cli_limite_compra { get; set; }

    public Nullable<decimal> cli_compra_acumulada { get; set; }

    public Nullable<System.DateTime> cli_dt_bloqueio { get; set; }

    public Nullable<decimal> cli_qtd_bloqueio { get; set; }

    public string cli_obs { get; set; }

    public Nullable<System.DateTime> cli_dt_ultima_compra { get; set; }

    public string cli_cpf_alteracao { get; set; }

    public string cli_tip_pessoa { get; set; }

    public Nullable<int> cli_titular_id { get; set; }

    public string cli_cpf { get; set; }

    public string cli_nome { get; set; }

    public string cli_id_numero { get; set; }

    public string cli_id_orgao_expedidor { get; set; }

    public Nullable<System.DateTime> cli_id_dt_expedicao { get; set; }

    public Nullable<System.DateTime> cli_dt_nascimento { get; set; }

    public string cli_sexo { get; set; }

    public string cli_estado_civil { get; set; }

    public Nullable<decimal> cli_nu_filhos { get; set; }

    public string cli_nm_pai { get; set; }

    public string cli_nm_mae { get; set; }

    public string cli_cnpj { get; set; }

    public Nullable<decimal> cli_insc_estadual { get; set; }

    public string cli_razao_social { get; set; }

    public string cli_nome_fantasia { get; set; }

    public string cli_cnpj_rede { get; set; }

    public Nullable<decimal> cli_vlr_credito { get; set; }

    public Nullable<decimal> cli_polo_distribuidor { get; set; }

    public Nullable<decimal> cli_perc_csub { get; set; }

    public Nullable<decimal> cli_perc_ssub { get; set; }

    public Nullable<bool> cli_venda_imp_fracionada { get; set; }

    public Nullable<bool> cli_venda_imp_princativo { get; set; }

    public string cli_nm_contato { get; set; }

    public string cli_situacao { get; set; }

    public Nullable<System.DateTime> cli_dt_cadastro { get; set; }

    public Nullable<System.DateTime> cli_dt_alteracao { get; set; }

    public Nullable<int> prm_id { get; set; }

    public Nullable<int> final_id { get; set; }

    public Nullable<int> subfin_id { get; set; }

    public Nullable<int> bloq_id { get; set; }

    public Nullable<int> uneg_id1 { get; set; }

    public Nullable<int> uf_id { get; set; }

    public long cli_id2 { get; set; }

    public int end_id { get; set; }

    public string end_cep { get; set; }

    public string end_tp_logradouro { get; set; }

    public string end_nm_logradouro { get; set; }

    public Nullable<int> end_numero { get; set; }

    public string end_complemento { get; set; }

    public string end_bairro { get; set; }

    public string end_cidade { get; set; }

    public string end_referencia { get; set; }

    public string end_tipo { get; set; }

    public string end_situacao { get; set; }

    public Nullable<System.DateTime> end_dt_cadastro { get; set; }

    public Nullable<System.DateTime> end_dt_alteracao { get; set; }

    public string end_cpf_alteracao { get; set; }

    public Nullable<int> uf_id1 { get; set; }

}

}