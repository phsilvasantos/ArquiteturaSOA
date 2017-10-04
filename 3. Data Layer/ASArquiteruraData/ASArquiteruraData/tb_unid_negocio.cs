
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
    using System.Collections.Generic;
    
public partial class tb_unid_negocio
{

    public tb_unid_negocio()
    {

        this.tb_agenda_produto = new HashSet<tb_agenda_produto>();

        this.tb_checkin_tmp = new HashSet<tb_checkin_tmp>();

        this.tb_cliente = new HashSet<tb_cliente>();

        this.tb_cliente_fiscal = new HashSet<tb_cliente_fiscal>();

        this.tb_crediario = new HashSet<tb_crediario>();

        this.tb_entrega_endereco = new HashSet<tb_entrega_endereco>();

        this.tb_entrega_polo = new HashSet<tb_entrega_polo>();

        this.tb_funcionario = new HashSet<tb_funcionario>();

        this.tb_funcionario1 = new HashSet<tb_funcionario>();

        this.tb_funcionario_visitante = new HashSet<tb_funcionario_visitante>();

        this.tb_lancto_financeiro = new HashSet<tb_lancto_financeiro>();

        this.tb_mvto_compra____ = new HashSet<tb_mvto_compra____>();

        this.tb_pedido_compra____ = new HashSet<tb_pedido_compra____>();

        this.tb_terminal = new HashSet<tb_terminal>();

        this.tbr_produto_estoque_lote = new HashSet<tbr_produto_estoque_lote>();

        this.tbr_produto_estoque_dia = new HashSet<tbr_produto_estoque_dia>();

        this.tb_venda_prevenda_item = new HashSet<tb_venda_prevenda_item>();

        this.tbr_convenio_un = new HashSet<tbr_convenio_un>();

        this.tbr_finalizadora_sub_un = new HashSet<tbr_finalizadora_sub_un>();

        this.tbr_finalizadora_un = new HashSet<tbr_finalizadora_un>();

        this.tbr_parametro_descprod_uneg = new HashSet<tbr_parametro_descprod_uneg>();

        this.tbr_parametro_descvend_uneg = new HashSet<tbr_parametro_descvend_uneg>();

        this.tbr_parametro_markup_uneg = new HashSet<tbr_parametro_markup_uneg>();

        this.tbr_produto_uneg = new HashSet<tbr_produto_uneg>();

        this.tb_promocao = new HashSet<tb_promocao>();

    }


    public int uneg_id { get; set; }

    public Nullable<decimal> uneg_numero { get; set; }

    public string uneg_cnpj { get; set; }

    public string uneg_nome { get; set; }

    public string uneg_razao_social { get; set; }

    public string uneg_fantasia { get; set; }

    public string uneg_inscricao_estadual { get; set; }

    public string uneg_inscricao_municipal { get; set; }

    public string uneg_situacao { get; set; }

    public string uneg_loja { get; set; }

    public Nullable<bool> uneg_cnpj_local { get; set; }

    public Nullable<bool> uneg_obriga_justif_diverg { get; set; }

    public int ibge_codigo { get; set; }

    public bool uneg_epp { get; set; }

    public byte[] uneg_img_logo { get; set; }

    public Nullable<int> uf_id { get; set; }

    public Nullable<System.DateTime> uneg_dt_cadastro { get; set; }

    public Nullable<System.DateTime> uneg_dt_alteracao { get; set; }

    public string uneg_cep { get; set; }

    public Nullable<int> uneg_tip_logradouro { get; set; }

    public string uneg_logradouro { get; set; }

    public string uneg_endereco_numero { get; set; }

    public string uneg_complemento { get; set; }

    public string uneg_bairro { get; set; }

    public string uneg_municipio { get; set; }

    public string uneg_telefones { get; set; }

    public string uneg_fax { get; set; }

    public string uneg_email { get; set; }

    public string uneg_regime { get; set; }

    public string uneg_nfe_automacao { get; set; }

    public string uneg_fid_login { get; set; }

    public string uneg_fid_senha { get; set; }

    public string uneg_cod_regime_fat { get; set; }

    public string uneg_cli_asafisco { get; set; }

    public string uneg_cli_ifarma { get; set; }

    public string uneg_vazio { get; set; }

    public string uneg_versao_banco { get; set; }

    public string uneg_tef_idLoja { get; set; }

    public string uneg_tef_IP { get; set; }

    public int cadcont_id { get; set; }



    public virtual ICollection<tb_agenda_produto> tb_agenda_produto { get; set; }

    public virtual tb_cadastro_contador tb_cadastro_contador { get; set; }

    public virtual ICollection<tb_checkin_tmp> tb_checkin_tmp { get; set; }

    public virtual ICollection<tb_cliente> tb_cliente { get; set; }

    public virtual ICollection<tb_cliente_fiscal> tb_cliente_fiscal { get; set; }

    public virtual ICollection<tb_crediario> tb_crediario { get; set; }

    public virtual ICollection<tb_entrega_endereco> tb_entrega_endereco { get; set; }

    public virtual ICollection<tb_entrega_polo> tb_entrega_polo { get; set; }

    public virtual ICollection<tb_funcionario> tb_funcionario { get; set; }

    public virtual ICollection<tb_funcionario> tb_funcionario1 { get; set; }

    public virtual ICollection<tb_funcionario_visitante> tb_funcionario_visitante { get; set; }

    public virtual tb_ibge tb_ibge { get; set; }

    public virtual ICollection<tb_lancto_financeiro> tb_lancto_financeiro { get; set; }

    public virtual ICollection<tb_mvto_compra____> tb_mvto_compra____ { get; set; }

    public virtual ICollection<tb_pedido_compra____> tb_pedido_compra____ { get; set; }

    public virtual ICollection<tb_terminal> tb_terminal { get; set; }

    public virtual tb_tipo_logradouro tb_tipo_logradouro { get; set; }

    public virtual tb_uf tb_uf { get; set; }

    public virtual ICollection<tbr_produto_estoque_lote> tbr_produto_estoque_lote { get; set; }

    public virtual ICollection<tbr_produto_estoque_dia> tbr_produto_estoque_dia { get; set; }

    public virtual ICollection<tb_venda_prevenda_item> tb_venda_prevenda_item { get; set; }

    public virtual ICollection<tbr_convenio_un> tbr_convenio_un { get; set; }

    public virtual ICollection<tbr_finalizadora_sub_un> tbr_finalizadora_sub_un { get; set; }

    public virtual ICollection<tbr_finalizadora_un> tbr_finalizadora_un { get; set; }

    public virtual ICollection<tbr_parametro_descprod_uneg> tbr_parametro_descprod_uneg { get; set; }

    public virtual ICollection<tbr_parametro_descvend_uneg> tbr_parametro_descvend_uneg { get; set; }

    public virtual ICollection<tbr_parametro_markup_uneg> tbr_parametro_markup_uneg { get; set; }

    public virtual ICollection<tbr_produto_uneg> tbr_produto_uneg { get; set; }

    public virtual ICollection<tb_promocao> tb_promocao { get; set; }

}

}