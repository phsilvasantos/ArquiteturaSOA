
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
    
public partial class tb_produto_receituario
{

    public tb_produto_receituario()
    {

        this.tb_produto = new HashSet<tb_produto>();

    }


    public int rec_id { get; set; }

    public string rec_lista { get; set; }

    public string rec_lista_descricao { get; set; }

    public string rec_receita_descricao { get; set; }

    public Nullable<decimal> rec_reter_receita { get; set; }

    public string rec_situacao { get; set; }

    public Nullable<System.DateTime> rec_dt_cadastro { get; set; }

    public Nullable<System.DateTime> rec_dt_alteracao { get; set; }



    public virtual ICollection<tb_produto> tb_produto { get; set; }

}

}
