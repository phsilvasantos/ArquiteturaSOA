
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
    
public partial class tbr_produto_tributacao
{

    public int pro_id { get; set; }

    public int uf_id { get; set; }

    public string protrb_class_tributaria { get; set; }

    public int trb_id_interno { get; set; }

    public int trb_id_interestadual { get; set; }

    public Nullable<int> protrb_origem_cst { get; set; }

    public string protrb_situacao { get; set; }

    public Nullable<System.DateTime> protrb_dt_cadastro { get; set; }

    public Nullable<System.DateTime> protrb_dt_alteracao { get; set; }



    public virtual tb_produto tb_produto { get; set; }

    public virtual tb_tributacao tb_tributacao { get; set; }

    public virtual tb_tributacao tb_tributacao1 { get; set; }

    public virtual tb_uf tb_uf { get; set; }

}

}
