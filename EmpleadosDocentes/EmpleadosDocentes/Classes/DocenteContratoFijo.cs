﻿using EmpleadosDocentes.Base_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDocentes.Classes
{
    internal class DocenteContratoFijo : Empleado
    {

        private decimal SalarioFijo { get; set; }

        private bool AlcanzoMeta { get; set; }


        public DocenteContratoFijo(string nombre, string apellido, string NSS, decimal Salario, bool AlcanzoMeta)
            : base(nombre, apellido, NSS)
        {
            this.SalarioFijo = Salario;
            this.AlcanzoMeta = AlcanzoMeta;

        }
        
        public override decimal CalcularSalario()
        {
           
            if (AlcanzoMeta)
            {
                return SalarioFijo;
            }
            else
            {
                return SalarioFijo / 2;
            }

        }
    }
}
