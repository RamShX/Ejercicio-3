using EmpleadosDocentes.Base_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDocentes.Classes
{
    internal class DocentePorHoras : Empleado
    {
        private decimal HorasTrabajada { get; set; }
        private decimal TarifaHoras = 800m;

  
        public DocentePorHoras(string nombre, string apellido, string NSS,decimal horasTrabajada)
            : base(nombre, apellido, NSS)
        {
            this.HorasTrabajada = horasTrabajada;
        }

        public override decimal CalcularSalario()
        {
            return this.HorasTrabajada * TarifaHoras;
        }
    }
}
