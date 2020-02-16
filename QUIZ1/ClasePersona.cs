using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class ClasePersona
    {

        #region AtributosPersona

        private int _id;
        private string _nombre;
        private string _apellido;
        private int _cedula;


        // set / get
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }


        //Constructores
        public ClasePersona()
        {
        }

        public ClasePersona(int id, string nombre, string apellido, int cedula)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _cedula = cedula;
        }

        #endregion

        public virtual String  NombreCompleto()
        {

            return string.Format("Nombre: {0}, {1}", _apellido, _nombre);
        }

    }
}
