
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
    
public partial class tbr_convenio_cliente
{

    public int cnv_id { get; set; }

    public long cli_id { get; set; }

    public Nullable<decimal> clicnv_vlr_limite { get; set; }

    public Nullable<decimal> clicnv_vlr_acumulado { get; set; }

    public string clicnv_nu_matricula { get; set; }

    public string clicnv_situacao { get; set; }

    public Nullable<System.DateTime> clicnv_dt_cadastro { get; set; }

    public Nullable<System.DateTime> clicnv_dt_alteracao { get; set; }

    public Nullable<int> bloq_id { get; set; }

    public Nullable<int> prazo_id { get; set; }



    public virtual tb_cliente tb_cliente { get; set; }

    public virtual tb_cliente_bloqueio tb_cliente_bloqueio { get; set; }

    public virtual tb_convenio tb_convenio { get; set; }

    public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

}

}
