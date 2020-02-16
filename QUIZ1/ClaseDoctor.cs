using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class ClaseDoctor : ClasePersona
    {
        //Atributos

        private int _especialidad;

        // get / set
        public int Especialidad { get => _especialidad; set => _especialidad = value; }

        // contructores
        public ClaseDoctor()
        {
        }

        public ClaseDoctor(int especialidad)
        {
            _especialidad = especialidad;
        }

        // Contructor que llama la clase base (ClasePersona)
        public ClaseDoctor(int especialidad, int id, string nombre, string apellido, int cedula) 
            : base( id, nombre, apellido, cedula)
        {
            _especialidad = especialidad;
        }

        // override ToString

        public override String NombreCompleto()
        {
            Console.WriteLine(Nombre);
            return string.Format(" Id: {0}, /n Nombre: {1},/n Especialidad: {2} ", Id, Nombre, Especialidad);
        }

    }
}
