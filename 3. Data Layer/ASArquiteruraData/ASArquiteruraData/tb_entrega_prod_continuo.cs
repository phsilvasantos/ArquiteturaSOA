
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
    
public partial class tb_entrega_prod_continuo
{

    public int uneg_id { get; set; }

    public int end_pdv { get; set; }

    public int end_id { get; set; }

    public System.DateTime end_data { get; set; }

    public int pro_id { get; set; }

    public Nullable<System.DateTime> proc_dt_ultima_compra { get; set; }

    public Nullable<decimal> proc_qt_ultima_compra { get; set; }

    public Nullable<decimal> proc_pr_ultima_compra { get; set; }



    public virtual tb_produto tb_produto { get; set; }

}

}
