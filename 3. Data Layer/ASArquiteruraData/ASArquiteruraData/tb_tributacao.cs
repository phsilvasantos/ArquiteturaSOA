
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
    
public partial class tb_tributacao
{

    public tb_tributacao()
    {

        this.tbr_ecf_tributacao = new HashSet<tbr_ecf_tributacao>();

        this.tbr_produto_tributacao = new HashSet<tbr_produto_tributacao>();

        this.tbr_produto_tributacao1 = new HashSet<tbr_produto_tributacao>();

    }


    public int trb_id { get; set; }

    public Nullable<decimal> trb_aliquota { get; set; }

    public Nullable<bool> trb_servico { get; set; }

    public Nullable<bool> trb_subst_trib { get; set; }

    public string trb_situacao { get; set; }

    public Nullable<System.DateTime> trb_dt_cadastro { get; set; }

    public Nullable<System.DateTime> trb_dt_alteracao { get; set; }



    public virtual ICollection<tbr_ecf_tributacao> tbr_ecf_tributacao { get; set; }

    public virtual ICollection<tbr_produto_tributacao> tbr_produto_tributacao { get; set; }

    public virtual ICollection<tbr_produto_tributacao> tbr_produto_tributacao1 { get; set; }

}

}
