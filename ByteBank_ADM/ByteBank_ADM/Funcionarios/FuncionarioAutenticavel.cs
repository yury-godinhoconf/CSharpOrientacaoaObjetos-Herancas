﻿using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string senha, string login)
        {
            if (this.Senha == senha && this.Login == login)
            {
                return true;
            }
            return false;
        }
    }
}
