
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
    
public partial class tb_sincronizacao
{

    public int id_sincronizacao { get; set; }

    public Nullable<int> id_terminal { get; set; }

    public Nullable<int> id_registro { get; set; }

    public string entidade_registro { get; set; }

    public Nullable<System.DateTime> dt_alteracao { get; set; }

    public Nullable<System.DateTime> dt_inclusao { get; set; }

    public Nullable<int> status { get; set; }



    public virtual tb_terminal tb_terminal { get; set; }

}

}
