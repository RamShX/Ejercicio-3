using EmpleadosDocentes.Base_class;
using EmpleadosDocentes.Classes;

namespace EmpleadosDocentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pasarle como parametro argumentos o valores al DocenteContratoFijo: nombre, apellido, NSS,Salario, si alcanzo la meta (true/false).
            DocenteContratoFijo docenteFijo1 = new DocenteContratoFijo("Juan", "Peña", "HR454G23", 2540, true);

            //Pasarle argumentos o valores al DocentePorHoras: nombre, apellido, NSS, hora trabaja.
            DocentePorHoras docentePorHoras1 = new DocentePorHoras("Maria", "Diaz", "KLK48332", 5);

            //Pasarle como parametro argumentos o valores al EMpleadoAdminitrativo: nombre, apellido, NSS, salario, si alcanzo la meta (true/false).
            EmpleadoAdminitrativo empleadoAdminitrativo1 = new EmpleadoAdminitrativo("Tomas", "Dijol", "MS42K75S", 15000, false);

            //ALmacenarlo en una Array
            Empleado[] empleados = new Empleado[]
            {
                docenteFijo1,docentePorHoras1,empleadoAdminitrativo1
            };

            //Presentar el valor
            for (int i = 0; i < empleados.Length; i++) 
            {
                Console.WriteLine($"Empleado {i + 1}: {empleados[i].pimerNombre} y su salario es: {empleados[i].CalcularSalario()}");

            }


        }
    }
}
