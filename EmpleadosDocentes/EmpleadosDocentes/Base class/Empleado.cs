using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosDocentes.Base_class
{
    public abstract class Empleado
    {
        private string PrimerNombre;
        private string ApellidoPatern { get; set; }
        private string NSS { get; set; }

        public Empleado(string nombre, string apellido, string NSS)
        {
            this.PrimerNombre = nombre;
            this.ApellidoPatern = apellido;
            this.NSS = NSS;
        }

        //getters y setters
        public string pimerNombre
        {
            get { return PrimerNombre; }
            set { ApellidoPatern = value; }
        }

        public string apellidoPatern 
        {
            get { return ApellidoPatern; }
            set { ApellidoPatern = value; }
        }

        public string nss 
        {
            get { return NSS; }
            set { NSS = value; }
        }
        

        public abstract decimal CalcularSalario();
    }
}
