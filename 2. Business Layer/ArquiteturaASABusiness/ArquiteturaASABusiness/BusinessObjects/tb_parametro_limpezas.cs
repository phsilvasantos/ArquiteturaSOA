﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_parametro_limpezas
    {
        #region Primitive Properties
        public virtual Int32 tb_id { get; set; }

        public virtual Nullable<DateTime> tb_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> tb_cpf_alteracao { get; set; }

        public virtual Nullable<DateTime> tb_data_exec { get; set; }

        public virtual Nullable<Int32> LJ_tb_abertura_caixa { get; set; }

        public virtual Nullable<Int32> LJ_tb_checkin { get; set; }

        public virtual Nullable<Int32> LJ_tb_checkout { get; set; }

        public virtual Nullable<Int32> LJ_tb_abcfarma_periodo { get; set; }

        public virtual Nullable<Int32> LJ_tb_sangrias { get; set; }

        public virtual Nullable<Int32> LJ_tb_suprimentos { get; set; }

        public virtual Nullable<Int32> LJ_tb_reducao_z { get; set; }

        public virtual Nullable<Int32> LJ_tb_venda { get; set; }

        public virtual Nullable<Int32> LJ_tb_promocao { get; set; }

        public virtual Nullable<Int32> LJ_tb_ponto { get; set; }

        public virtual Nullable<Int32> LJ_tb_nfe { get; set; }

        public virtual Nullable<Int32> LJ_tb_privatelabel { get; set; }

        public virtual Nullable<Int32> LJ_tb_recarga { get; set; }

        public virtual Nullable<Int32> LJ_tb_lancto_financeiro { get; set; }

        public virtual Nullable<Int32> LJ_tb_agenda_produto { get; set; }

        public virtual Nullable<Int32> LJ_tb_crediario { get; set; }

        #endregion

    }
}
