
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
    
public partial class tb_finalizadora
{

    public tb_finalizadora()
    {

        this.tb_ecf_dd = new HashSet<tb_ecf_dd>();

        this.tb_finalizadora_sub = new HashSet<tb_finalizadora_sub>();

        this.tb_financeiro_sangria = new HashSet<tb_financeiro_sangria>();

        this.tb_venda_pagamento = new HashSet<tb_venda_pagamento>();

        this.tbr_ecf_finalizadora = new HashSet<tbr_ecf_finalizadora>();

        this.tbr_finalizadora_un = new HashSet<tbr_finalizadora_un>();

    }


    public int final_id { get; set; }

    public string final_descricao { get; set; }

    public Nullable<bool> final_permite_troco { get; set; }

    public Nullable<bool> final_permite_sangria { get; set; }

    public Nullable<long> final_vlr_sangria_aviso { get; set; }

    public Nullable<decimal> final_vlr_sangria_bloqueio { get; set; }

    public Nullable<bool> final_consulta_cli_tef { get; set; }

    public Nullable<bool> final_venda_tef { get; set; }

    public Nullable<bool> final_obriga_cliente { get; set; }

    public Nullable<bool> final_solicita_dados_ch { get; set; }

    public Nullable<bool> final_tipo_convenio { get; set; }

    public Nullable<bool> final_obriga_autenticacao { get; set; }

    public string final_tecla_atalho { get; set; }

    public Nullable<bool> final_db_folha { get; set; }

    public Nullable<int> final_emite_recibo { get; set; }

    public string final_situacao { get; set; }

    public string final_imagem { get; set; }

    public Nullable<System.DateTime> final_dt_cadastro { get; set; }

    public Nullable<System.DateTime> final_dt_alteracao { get; set; }



    public virtual ICollection<tb_ecf_dd> tb_ecf_dd { get; set; }

    public virtual ICollection<tb_finalizadora_sub> tb_finalizadora_sub { get; set; }

    public virtual ICollection<tb_financeiro_sangria> tb_financeiro_sangria { get; set; }

    public virtual ICollection<tb_venda_pagamento> tb_venda_pagamento { get; set; }

    public virtual ICollection<tbr_ecf_finalizadora> tbr_ecf_finalizadora { get; set; }

    public virtual ICollection<tbr_finalizadora_un> tbr_finalizadora_un { get; set; }

}

}