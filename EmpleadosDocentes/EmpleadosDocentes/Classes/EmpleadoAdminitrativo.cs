using EmpleadosDocentes.Base_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDocentes.Classes
{
    internal class EmpleadoAdminitrativo : Empleado
    {
       
        private decimal SalarioFijo { get; set; }
        private bool AlcanzoMeta { get; set; }

        
        public EmpleadoAdminitrativo(string nombre, string apellido, string NSS, decimal Salario, bool AlcanzoMeta)
            : base(nombre, apellido, NSS)
        {
            this.SalarioFijo = Salario;
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

