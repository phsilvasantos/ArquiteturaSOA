
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
    
public partial class tb_tipo_mvto_produto
{

    public tb_tipo_mvto_produto()
    {

        this.tb_tipo_nota = new HashSet<tb_tipo_nota>();

    }


    public int cdmvto_codigo { get; set; }

    public string cdmvto_descricao { get; set; }

    public string cdmvto_tipo { get; set; }

    public Nullable<bool> cdmvto_lanc_manual { get; set; }

    public string cdmvto_cd_anvisa { get; set; }

    public string cdmvto_situacao { get; set; }

    public Nullable<System.DateTime> cdmvto_dt_cadastro { get; set; }

    public Nullable<System.DateTime> cdmvto_dt_alteracao { get; set; }



    public virtual ICollection<tb_tipo_nota> tb_tipo_nota { get; set; }

}

}
