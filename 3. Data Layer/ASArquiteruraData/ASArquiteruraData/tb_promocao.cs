
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
    
public partial class tb_promocao
{

    public tb_promocao()
    {

        this.tb_cliente = new HashSet<tb_cliente>();

        this.tbr_promocao_produto = new HashSet<tbr_promocao_produto>();

        this.tb_convenio = new HashSet<tb_convenio>();

        this.tb_unid_negocio = new HashSet<tb_unid_negocio>();

    }


    public int prm_id { get; set; }

    public string prm_observacao { get; set; }

    public Nullable<System.DateTime> prm_dt_inicio { get; set; }

    public Nullable<System.DateTime> prm_dt_fim { get; set; }

    public string prm_tip_aplicacao { get; set; }

    public string prm_situacao { get; set; }

    public Nullable<System.DateTime> prm_dt_cadastro { get; set; }

    public Nullable<System.DateTime> prm_dt_alteracao { get; set; }

    public Nullable<decimal> prm_cpf_alteracao { get; set; }

    public Nullable<int> tippro_id { get; set; }



    public virtual ICollection<tb_cliente> tb_cliente { get; set; }

    public virtual ICollection<tbr_promocao_produto> tbr_promocao_produto { get; set; }

    public virtual ICollection<tb_convenio> tb_convenio { get; set; }

    public virtual ICollection<tb_unid_negocio> tb_unid_negocio { get; set; }

}

}
