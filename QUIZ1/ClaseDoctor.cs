using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class ClaseDoctor : ClasePersona
    {
        #region Atributos Doctor
        //Atributos

        private string _especialidad;

        // get / set
        public string Especialidad { get => _especialidad; set => _especialidad = value; }

        // contructores
        public ClaseDoctor()
        {
        }

        public ClaseDoctor(string especialidad)
        {
            _especialidad = especialidad;
        }

        // Contructor que llama la clase base (ClasePersona)
        public ClaseDoctor(string especialidad, int id, string nombre, string apellido, int cedula) 
            : base( id, nombre, apellido, cedula)
        {
            _especialidad = especialidad;
        }

        #endregion
        // override ToString
        public override String NombreCompleto()
        {
            
            return string.Format(" Id: {0},  Nombre: {1}, Especialidad: {2} ", Id, Nombre, Especialidad);
        }

    }
}
