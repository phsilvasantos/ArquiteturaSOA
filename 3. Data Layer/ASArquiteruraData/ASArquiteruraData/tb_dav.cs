
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
    
public partial class tb_dav
{

    public tb_dav()
    {

        this.tb_dav_itens____ = new HashSet<tb_dav_itens____>();

    }


    public int dav_id { get; set; }

    public Nullable<int> uneg_id { get; set; }

    public Nullable<int> venda_id { get; set; }

    public Nullable<int> venda_pdv { get; set; }

    public Nullable<System.DateTime> venda_data { get; set; }

    public System.DateTime dav_data { get; set; }

    public System.DateTime dav_data_emissao { get; set; }

    public Nullable<int> dav_numero { get; set; }

    public Nullable<int> dav_numero_controle { get; set; }

    public string ecf_numero_serie_emissao { get; set; }

    public int dav_coo_emissao { get; set; }

    public int dav_gnf_emissao { get; set; }

    public string dav_cpf_cnpj { get; set; }

    public string dav_nome_adquirente { get; set; }

    public Nullable<int> dav_num_ecf_venda { get; set; }

    public Nullable<int> dav_coo_venda { get; set; }

    public Nullable<int> dav_coo_cupom_vinculado_venda { get; set; }

    public string dav_titulo { get; set; }

    public Nullable<decimal> dav_valor_total { get; set; }

    public string dav_status { get; set; }

    public string ecf_numero_serie_fechamento_cupom { get; set; }

    public string dav_md5 { get; set; }



    public virtual ICollection<tb_dav_itens____> tb_dav_itens____ { get; set; }

    public virtual tb_venda tb_venda { get; set; }

}

}
