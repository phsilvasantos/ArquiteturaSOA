
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
    
public partial class tb_usuario_dpto
{

    public tb_usuario_dpto()
    {

        this.tb_usuario = new HashSet<tb_usuario>();

        this.tbr_dpto_aplicativo = new HashSet<tbr_dpto_aplicativo>();

    }


    public int dpto_id { get; set; }

    public string dpto_nome { get; set; }

    public string dpto_situacao { get; set; }

    public Nullable<System.DateTime> dpto_dt_cadastro { get; set; }

    public Nullable<System.DateTime> dpto_dt_alteracao { get; set; }

    public Nullable<decimal> dpto_cpf_alteracao { get; set; }

    public Nullable<bool> dpto_apl_planilha { get; set; }

    public Nullable<bool> dpto_apl_checkin { get; set; }

    public Nullable<bool> dpto_apl_entrada_nf { get; set; }

    public Nullable<bool> dpto_apl_consulta_preco { get; set; }

    public Nullable<bool> dpto_apl_alteracao_preco { get; set; }

    public Nullable<bool> dpto_apl_vnd_balcao { get; set; }

    public Nullable<bool> dpto_apl_pdv { get; set; }

    public Nullable<bool> dpto_apl_vnd_callcenter { get; set; }

    public Nullable<bool> dpto_apl_supervisor_callcenter { get; set; }

    public Nullable<bool> dpto_apl_etiquetas_loja { get; set; }

    public Nullable<bool> dpto_apl_vnd_atacado { get; set; }

    public Nullable<bool> dpto_apl_checkout_atacado { get; set; }

    public Nullable<bool> dpto_apl_fat_atacado { get; set; }

    public Nullable<bool> dpto_apl_etiquetas_atacado { get; set; }

    public Nullable<bool> dpto_apl_supervisor_atacado { get; set; }



    public virtual ICollection<tb_usuario> tb_usuario { get; set; }

    public virtual ICollection<tbr_dpto_aplicativo> tbr_dpto_aplicativo { get; set; }

}

}