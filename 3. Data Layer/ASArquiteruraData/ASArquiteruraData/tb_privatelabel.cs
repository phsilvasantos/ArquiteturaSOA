
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
    
public partial class tb_privatelabel
{

    public tb_privatelabel()
    {

        this.tb_privatelabel_finalizadora = new HashSet<tb_privatelabel_finalizadora>();

    }


    public int uneg_id { get; set; }

    public int plabel_pdv { get; set; }

    public System.DateTime plabel_data { get; set; }

    public int plabel_id { get; set; }

    public string plabel_nsu { get; set; }

    public string plabel_nome_rec { get; set; }

    public Nullable<decimal> plabel_tipo_rec { get; set; }

    public Nullable<decimal> plabel_tot_rec { get; set; }

    public Nullable<int> plabel_operado_cx { get; set; }

    public int emplabel_id { get; set; }



    public virtual tb_empresa_privatelabel tb_empresa_privatelabel { get; set; }

    public virtual ICollection<tb_privatelabel_finalizadora> tb_privatelabel_finalizadora { get; set; }

}

}