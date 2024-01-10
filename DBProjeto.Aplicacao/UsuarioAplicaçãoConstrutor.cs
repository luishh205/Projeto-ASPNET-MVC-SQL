﻿using BDProjeto.Aplicacao;
using BDProjeto.RepositorioADO;
using BDProjeto.RepositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjeto.Aplicacao
{
    public class UsuarioAplicaçãoConstrutor
    {
        public static UsuarioAplicacao UsuarioApADO()
        {
            return new UsuarioAplicacao(new UsuarioAplicacaoADO());
        }

        public static UsuarioAplicacao UsuarioApEF()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioEF());
        }
    }
}
