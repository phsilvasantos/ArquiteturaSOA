
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
    
public partial class tb_tipo_logradouro
{

    public tb_tipo_logradouro()
    {

        this.tb_unid_negocio = new HashSet<tb_unid_negocio>();

    }


    public int tiplog_id { get; set; }

    public string tiplog_abreviatura { get; set; }

    public string tiplog_descricao { get; set; }

    public string tiplog_situacao { get; set; }

    public Nullable<System.DateTime> tiplog_dt_cadastro { get; set; }

    public Nullable<System.DateTime> tiplog_dt_alteracao { get; set; }

    public string tiplog_cpf_alteracao { get; set; }



    public virtual ICollection<tb_unid_negocio> tb_unid_negocio { get; set; }

}

}
