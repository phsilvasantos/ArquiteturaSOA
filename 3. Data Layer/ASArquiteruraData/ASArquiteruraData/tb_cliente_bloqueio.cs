
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
    
public partial class tb_cliente_bloqueio
{

    public tb_cliente_bloqueio()
    {

        this.tb_cliente = new HashSet<tb_cliente>();

        this.tbr_convenio_cliente = new HashSet<tbr_convenio_cliente>();

    }


    public int bloq_id { get; set; }

    public string bloq_descricao { get; set; }

    public Nullable<decimal> bloq_tip_acao { get; set; }

    public string bloq_situacao { get; set; }

    public Nullable<System.DateTime> bloq_dt_cadastro { get; set; }

    public Nullable<System.DateTime> bloq_dt_alteracao { get; set; }



    public virtual ICollection<tb_cliente> tb_cliente { get; set; }

    public virtual ICollection<tbr_convenio_cliente> tbr_convenio_cliente { get; set; }

}

}
