
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
    
public partial class tb_nfe_cfop
{

    public int uneg_id { get; set; }

    public int nfe_pdv { get; set; }

    public int nfe_id { get; set; }

    public System.DateTime nfe_data { get; set; }

    public int cfop_id { get; set; }

    public Nullable<decimal> cfop_base_icms { get; set; }

    public Nullable<decimal> cfop_aliq_icms { get; set; }

    public Nullable<decimal> cfop_valor_icms { get; set; }



    public virtual tb_cfop tb_cfop { get; set; }

}

}
