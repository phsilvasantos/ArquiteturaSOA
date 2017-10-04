
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
    
public partial class tb_produto
{

    public tb_produto()
    {

        this.tb_agenda_produto = new HashSet<tb_agenda_produto>();

        this.tb_checkin_item_tmp = new HashSet<tb_checkin_item_tmp>();

        this.tb_entrega_prod_continuo = new HashSet<tb_entrega_prod_continuo>();

        this.tb_mvto_compra_item____ = new HashSet<tb_mvto_compra_item____>();

        this.tb_nfe_item = new HashSet<tb_nfe_item>();

        this.tb_parametro_comissao = new HashSet<tb_parametro_comissao>();

        this.tb_parametro_descconv = new HashSet<tb_parametro_descconv>();

        this.tb_parametro_descmax = new HashSet<tb_parametro_descmax>();

        this.tb_parametro_descprod = new HashSet<tb_parametro_descprod>();

        this.tb_parametro_descvend = new HashSet<tb_parametro_descvend>();

        this.tb_parametro_markup = new HashSet<tb_parametro_markup>();

        this.tbr_produto_estoque_lote = new HashSet<tbr_produto_estoque_lote>();

        this.tb_produto_barra = new HashSet<tb_produto_barra>();

        this.tbr_produto_estoque_dia = new HashSet<tbr_produto_estoque_dia>();

        this.tb_venda_dav_item = new HashSet<tb_venda_dav_item>();

        this.tb_venda_item = new HashSet<tb_venda_item>();

        this.tb_venda_prevenda_item = new HashSet<tb_venda_prevenda_item>();

        this.tbr_dicionario_produto = new HashSet<tbr_dicionario_produto>();

        this.tbr_produto_tributacao = new HashSet<tbr_produto_tributacao>();

        this.tbr_produto_uneg = new HashSet<tbr_produto_uneg>();

    }


    public int pro_id { get; set; }

    public Nullable<decimal> pro_codigo { get; set; }

    public string pro_descricao { get; set; }

    public string pro_nome { get; set; }

    public string pro_dosagem { get; set; }

    public Nullable<decimal> pro_qtd_embalagem { get; set; }

    public string pro_embalagem { get; set; }

    public string pro_apresentacao { get; set; }

    public string pro_unidade_venda { get; set; }

    public string pro_situacao { get; set; }

    public Nullable<decimal> pro_ipi { get; set; }

    public Nullable<decimal> pro_ncm { get; set; }

    public Nullable<decimal> pro_tip_etiqueta { get; set; }

    public string pro_tip_compra { get; set; }

    public string pro_tip_preco { get; set; }

    public string pro_tip_produto { get; set; }

    public Nullable<decimal> pro_cod_ms { get; set; }

    public Nullable<bool> pro_uso_continuo { get; set; }

    public Nullable<decimal> pro_desc_max { get; set; }

    public Nullable<bool> pro_composto { get; set; }

    public Nullable<bool> pro_peso_variavel { get; set; }

    public Nullable<decimal> pro_validade_perec { get; set; }

    public Nullable<System.DateTime> pro_dt_cadastro { get; set; }

    public Nullable<System.DateTime> pro_dt_alteracao { get; set; }

    public Nullable<decimal> pro_cod_genero { get; set; }

    public Nullable<decimal> pro_qtde_m2 { get; set; }

    public Nullable<bool> pro_marca_crm { get; set; }

    public Nullable<bool> pro_fracionado { get; set; }

    public Nullable<decimal> pro_peso { get; set; }

    public Nullable<decimal> pro_pei { get; set; }

    public string pro_tb_balanca { get; set; }

    public Nullable<bool> pro_encarte { get; set; }

    public Nullable<decimal> pro_cod_dcb { get; set; }

    public Nullable<bool> pro_marca_propaganda { get; set; }

    public Nullable<int> pro_link_propaganda_1 { get; set; }

    public Nullable<int> pro_link_propaganda_2 { get; set; }

    public Nullable<int> pro_link_propaganda_3 { get; set; }

    public Nullable<int> pro_link_propaganda_4 { get; set; }

    public Nullable<int> pro_link_propaganda_5 { get; set; }

    public string pro_dados_adicionais { get; set; }

    public string pro_lista_icms_medic { get; set; }

    public Nullable<decimal> pro_mva { get; set; }

    public Nullable<decimal> pro_cod_origem { get; set; }

    public Nullable<decimal> pro_cod_cst_icms { get; set; }

    public Nullable<decimal> pro_cod_csosn_icms { get; set; }

    public string pro_class_trib_piscofins { get; set; }

    public Nullable<decimal> pro_cod_cst_piscofins { get; set; }

    public Nullable<int> sim_id { get; set; }

    public Nullable<int> cla_id { get; set; }

    public Nullable<int> pat_id { get; set; }

    public Nullable<int> lin_id { get; set; }

    public Nullable<int> rec_id { get; set; }

    public Nullable<int> abcf_id { get; set; }

    public Nullable<int> fab_id { get; set; }

    public Nullable<int> div_id { get; set; }

    public Nullable<int> fam_id { get; set; }

    public Nullable<int> grp_id { get; set; }

    public Nullable<int> cat_id { get; set; }

    public Nullable<int> scat_id { get; set; }

    public string piscofins_cod { get; set; }



    public virtual tb_abcfarma tb_abcfarma { get; set; }

    public virtual ICollection<tb_agenda_produto> tb_agenda_produto { get; set; }

    public virtual ICollection<tb_checkin_item_tmp> tb_checkin_item_tmp { get; set; }

    public virtual ICollection<tb_entrega_prod_continuo> tb_entrega_prod_continuo { get; set; }

    public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

    public virtual ICollection<tb_mvto_compra_item____> tb_mvto_compra_item____ { get; set; }

    public virtual ICollection<tb_nfe_item> tb_nfe_item { get; set; }

    public virtual ICollection<tb_parametro_comissao> tb_parametro_comissao { get; set; }

    public virtual ICollection<tb_parametro_descconv> tb_parametro_descconv { get; set; }

    public virtual ICollection<tb_parametro_descmax> tb_parametro_descmax { get; set; }

    public virtual ICollection<tb_parametro_descprod> tb_parametro_descprod { get; set; }

    public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend { get; set; }

    public virtual ICollection<tb_parametro_markup> tb_parametro_markup { get; set; }

    public virtual ICollection<tbr_produto_estoque_lote> tbr_produto_estoque_lote { get; set; }

    public virtual ICollection<tb_produto_barra> tb_produto_barra { get; set; }

    public virtual ICollection<tbr_produto_estoque_dia> tbr_produto_estoque_dia { get; set; }

    public virtual tb_produto_piscofins tb_produto_piscofins { get; set; }

    public virtual tb_produto_fam_categ_sub tb_produto_fam_categ_sub { get; set; }

    public virtual tb_produto_similaridade tb_produto_similaridade { get; set; }

    public virtual tb_produto_classe tb_produto_classe { get; set; }

    public virtual tb_produto_princativo tb_produto_princativo { get; set; }

    public virtual tb_produto_linha tb_produto_linha { get; set; }

    public virtual tb_produto_receituario tb_produto_receituario { get; set; }

    public virtual ICollection<tb_venda_dav_item> tb_venda_dav_item { get; set; }

    public virtual ICollection<tb_venda_item> tb_venda_item { get; set; }

    public virtual ICollection<tb_venda_prevenda_item> tb_venda_prevenda_item { get; set; }

    public virtual ICollection<tbr_dicionario_produto> tbr_dicionario_produto { get; set; }

    public virtual ICollection<tbr_produto_tributacao> tbr_produto_tributacao { get; set; }

    public virtual ICollection<tbr_produto_uneg> tbr_produto_uneg { get; set; }

}

}
