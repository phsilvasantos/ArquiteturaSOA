
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
    
public partial class tb_venda_estorno_tef
{

    public int vestef_id { get; set; }

    public int uneg_id { get; set; }

    public int venda_id { get; set; }

    public int venda_pdv { get; set; }

    public System.DateTime venda_data { get; set; }

    public int vpag_id { get; set; }

    public decimal vestef_usr_mat { get; set; }

    public decimal vestef_vendedor_mat { get; set; }



    public virtual tb_venda tb_venda { get; set; }

}

}
