
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
    
public partial class tb_cliente_anvisa
{

    public string cli_anv_num_documento { get; set; }

    public string cli_anv_orgao_expedidor { get; set; }

    public string cli_anv_nome { get; set; }

    public string cli_anv_telefone { get; set; }

    public System.DateTime cli_anv_data_cadastro { get; set; }

    public Nullable<int> uf_id { get; set; }

    public int usr_id { get; set; }

    public int uneg_id { get; set; }



    public virtual tb_uf tb_uf { get; set; }

}

}
