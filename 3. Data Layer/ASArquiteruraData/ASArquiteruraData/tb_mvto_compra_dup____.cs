
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
    
public partial class tb_mvto_compra_dup____
{

    public tb_mvto_compra_dup____()
    {

        this.tbr_mvto_compra_dup____ = new HashSet<tbr_mvto_compra_dup____>();

    }


    public int cmpdup_id { get; set; }

    public Nullable<int> cmpdup_numero { get; set; }

    public Nullable<System.DateTime> cmpdup_vencimento { get; set; }

    public Nullable<decimal> cmpdup_valor { get; set; }

    public Nullable<decimal> cmpdup_mora_dia { get; set; }

    public Nullable<decimal> cmpdup_taxa { get; set; }

    public Nullable<System.DateTime> cmpdup_dt_antecipacao { get; set; }

    public Nullable<decimal> cmpdup_vl_antecipacao { get; set; }

    public Nullable<long> cmpdup_NossoNumero { get; set; }



    public virtual tb_mvto_compra_dup____ tb_mvto_compra_dup____1 { get; set; }

    public virtual tb_mvto_compra_dup____ tb_mvto_compra_dup____2 { get; set; }

    public virtual ICollection<tbr_mvto_compra_dup____> tbr_mvto_compra_dup____ { get; set; }

}

}
