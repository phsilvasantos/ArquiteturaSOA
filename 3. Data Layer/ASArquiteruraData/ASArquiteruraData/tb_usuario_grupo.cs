
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
    
public partial class tb_usuario_grupo
{

    public tb_usuario_grupo()
    {

        this.tb_usuario = new HashSet<tb_usuario>();

    }


    public int grp_id { get; set; }

    public string grp_nome { get; set; }

    public string grp_diautil { get; set; }

    public string grp_sabado { get; set; }

    public string grp_domingo { get; set; }

    public string grp_feriado { get; set; }

    public Nullable<decimal> grp_tmp_senha { get; set; }

    public Nullable<bool> grp_acesso_filial_ilimitada { get; set; }

    public string grp_situacao { get; set; }

    public Nullable<System.DateTime> grp_dt_cadastro { get; set; }

    public Nullable<System.DateTime> grp_dt_alteracao { get; set; }



    public virtual ICollection<tb_usuario> tb_usuario { get; set; }

}

}
