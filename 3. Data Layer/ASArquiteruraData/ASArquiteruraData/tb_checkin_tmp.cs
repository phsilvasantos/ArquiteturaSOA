
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
    
public partial class tb_checkin_tmp
{

    public tb_checkin_tmp()
    {

        this.tb_checkin_item_tmp = new HashSet<tb_checkin_item_tmp>();

    }


    public int chkin_id { get; set; }

    public Nullable<decimal> chkin_num_nf { get; set; }

    public Nullable<System.DateTime> chkin_data { get; set; }

    public Nullable<decimal> chkin_cpf_usuario { get; set; }

    public Nullable<System.DateTime> chkin_dt_alteracao { get; set; }

    public Nullable<int> uneg_id { get; set; }

    public Nullable<int> pedc_id { get; set; }

    public Nullable<int> fab_id { get; set; }

    public Nullable<int> div_id { get; set; }



    public virtual ICollection<tb_checkin_item_tmp> tb_checkin_item_tmp { get; set; }

    public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

    public virtual tb_pedido_compra____ tb_pedido_compra____ { get; set; }

    public virtual tb_unid_negocio tb_unid_negocio { get; set; }

}

}
