
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
    
public partial class tb_privatelabel_finalizadora
{

    public int uneg_id { get; set; }

    public int plabel_pdv { get; set; }

    public System.DateTime plabel_data { get; set; }

    public int plabel_id { get; set; }

    public string vpag_id { get; set; }

    public int final_id { get; set; }

    public int subfin_id { get; set; }

    public Nullable<int> vpag_num_referencia { get; set; }

    public decimal vpag_valor { get; set; }

    public Nullable<decimal> vpag_troco { get; set; }

    public Nullable<bool> vpag_vendatef { get; set; }

    public string vpag_tef_nsu_venda { get; set; }

    public string vpag_tef_nsu_host { get; set; }

    public string vpag_tipo_cartao { get; set; }

    public string vpag_comprovante_cliente { get; set; }

    public string vpag_comprovante_loja { get; set; }

    public string vpag_status { get; set; }

    public Nullable<int> prazo_id { get; set; }

    public Nullable<int> cli_id { get; set; }

    public Nullable<int> bcaixa_id { get; set; }



    public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

    public virtual tb_privatelabel tb_privatelabel { get; set; }

}

}