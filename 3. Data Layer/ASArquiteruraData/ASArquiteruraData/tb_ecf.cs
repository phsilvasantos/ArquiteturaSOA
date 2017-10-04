
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
    
public partial class tb_ecf
{

    public tb_ecf()
    {

        this.tb_ecf_dd = new HashSet<tb_ecf_dd>();

        this.tb_reducao_z = new HashSet<tb_reducao_z>();

        this.tb_venda = new HashSet<tb_venda>();

        this.tbr_ecf_finalizadora = new HashSet<tbr_ecf_finalizadora>();

        this.tbr_ecf_tributacao = new HashSet<tbr_ecf_tributacao>();

    }


    public string ecf_numero_serie { get; set; }

    public int ecf_numero_ecf { get; set; }

    public int ecfm_id_marca { get; set; }

    public int ecfm_id_modelo { get; set; }

    public int ecfm_id_versao { get; set; }

    public string ecf_versao_firmware { get; set; }

    public System.DateTime ecf_data_instalacao_software_basico { get; set; }

    public string ecf_numero_usuario_atual { get; set; }

    public Nullable<int> ecf_qtdlinhas_guilhotina { get; set; }

    public Nullable<int> ecf_velocidade_porta { get; set; }

    public string ecf_situacao { get; set; }

    public Nullable<System.DateTime> ecf_dt_cadastro { get; set; }

    public Nullable<System.DateTime> ecf_dt_alteracao { get; set; }

    public string ecf_cpf_alteracao { get; set; }

    public Nullable<int> uneg_id { get; set; }



    public virtual ICollection<tb_ecf_dd> tb_ecf_dd { get; set; }

    public virtual tb_ecf_modelo tb_ecf_modelo { get; set; }

    public virtual ICollection<tb_reducao_z> tb_reducao_z { get; set; }

    public virtual ICollection<tb_venda> tb_venda { get; set; }

    public virtual ICollection<tbr_ecf_finalizadora> tbr_ecf_finalizadora { get; set; }

    public virtual ICollection<tbr_ecf_tributacao> tbr_ecf_tributacao { get; set; }

}

}
