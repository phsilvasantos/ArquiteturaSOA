﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
  public  class tb_financeiro_bancosRepository : Repository<tb_financeiro_bancos> , Itb_financeiro_bancosRepository
    {
    }
}
