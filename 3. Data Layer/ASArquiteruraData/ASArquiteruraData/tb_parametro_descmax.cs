
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
    
public partial class tb_parametro_descmax
{

    public int par_id { get; set; }

    public string par_objeto { get; set; }

    public Nullable<bool> par_todos_usuarios { get; set; }

    public Nullable<bool> par_todas_funcoes { get; set; }

    public Nullable<bool> par_desconto_sobre_desconto { get; set; }

    public Nullable<decimal> par_preco_ate_1 { get; set; }

    public Nullable<decimal> par_percentual_1 { get; set; }

    public Nullable<decimal> par_preco_ate_2 { get; set; }

    public Nullable<decimal> par_percentual_2 { get; set; }

    public Nullable<decimal> par_preco_ate_3 { get; set; }

    public Nullable<decimal> par_percentual_3 { get; set; }

    public Nullable<decimal> par_preco_ate_4 { get; set; }

    public Nullable<decimal> par_percentual_4 { get; set; }

    public Nullable<decimal> par_preco_ate_5 { get; set; }

    public Nullable<decimal> par_percentual_5 { get; set; }

    public string par_situacao { get; set; }

    public Nullable<System.DateTime> par_dt_cadastro { get; set; }

    public Nullable<System.DateTime> par_dt_alteracao { get; set; }

    public string par_md5 { get; set; }

    public Nullable<int> pro_id { get; set; }

    public Nullable<int> sim_id { get; set; }

    public Nullable<int> cla_id { get; set; }

    public Nullable<int> lin_id { get; set; }

    public Nullable<int> fab_id { get; set; }

    public Nullable<int> div_id { get; set; }

    public Nullable<int> fam_id { get; set; }

    public Nullable<int> grp_id { get; set; }

    public Nullable<int> cat_id { get; set; }

    public Nullable<int> scat_id { get; set; }



    public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

    public virtual tb_produto tb_produto { get; set; }

    public virtual tb_produto_classe tb_produto_classe { get; set; }

    public virtual tb_produto_fam_categ_sub tb_produto_fam_categ_sub { get; set; }

    public virtual tb_produto_linha tb_produto_linha { get; set; }

    public virtual tb_produto_similaridade tb_produto_similaridade { get; set; }

}

}
