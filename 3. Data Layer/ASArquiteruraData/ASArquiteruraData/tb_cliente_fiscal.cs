
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
    
public partial class tb_cliente_fiscal
{

    public tb_cliente_fiscal()
    {

        this.tb_venda = new HashSet<tb_venda>();

    }


    public string cli_fisc_cpf_cnpj { get; set; }

    public string cli_fisc_nome { get; set; }

    public string cli_fisc_email { get; set; }

    public string cli_fisc_endereco { get; set; }

    public string cli_fisc_tp_logradouro { get; set; }

    public Nullable<int> cli_fisc_numero { get; set; }

    public string cli_fisc_complemento { get; set; }

    public string cli_fisc_bairro { get; set; }

    public string cli_fisc_cidade { get; set; }

    public string cli_fisc_uf { get; set; }

    public string cli_fisc_cep { get; set; }

    public System.DateTime cli_fisc_data_cadastro { get; set; }

    public string cli_fisc_ibge_codigo { get; set; }

    public int usr_id { get; set; }

    public int uneg_id { get; set; }



    public virtual tb_unid_negocio tb_unid_negocio { get; set; }

    public virtual tb_usuario tb_usuario { get; set; }

    public virtual ICollection<tb_venda> tb_venda { get; set; }

}

}
