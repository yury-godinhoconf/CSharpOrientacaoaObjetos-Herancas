﻿using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        //public void Registrar(Diretor diretor) //sobrecarga
        //{
        //    this.TotalDeBonificacao += diretor.GetBonificacao();
        //}
    }
}
