
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
    
public partial class tbr_produto_estoque_dia
{

    public int uneg_id { get; set; }

    public int pro_id { get; set; }

    public System.DateTime proes_dt_cadastro { get; set; }

    public Nullable<System.DateTime> proes_dt_alteracao { get; set; }

    public Nullable<System.DateTime> proes_dt_leiturax { get; set; }

    public Nullable<System.DateTime> proes_dt_update { get; set; }

    public Nullable<decimal> proes_estoque { get; set; }

    public decimal proes_estoque_dia { get; set; }

    public Nullable<decimal> proes_custo_nf { get; set; }

    public Nullable<decimal> proes_custo_real { get; set; }

    public Nullable<decimal> proes_custo_medio { get; set; }

    public Nullable<decimal> proes_preco_venda { get; set; }

    public string ecf_numero_serie { get; set; }



    public virtual tb_produto tb_produto { get; set; }

    public virtual tb_unid_negocio tb_unid_negocio { get; set; }

}

}
