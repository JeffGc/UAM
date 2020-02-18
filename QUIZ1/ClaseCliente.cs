using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class ClaseCliente : ClasePersona
    {
        #region AtributosCliente

        // Atributos claseCliente

        private int _telefono;
        private string _correo;

        //Get / Set
        public int Telefono { get => _telefono; set => _telefono = value; }
        public string correo { get => _correo; set => _correo = value; }

        #endregion

        #region Constructores
        // Contructores
        public ClaseCliente()
        {
        }

        public ClaseCliente(int telefono, string correo)
        {
            _telefono = telefono;
            _correo = correo;
        }

        // Contructor que llama la clase base (ClasePersona)
        public ClaseCliente(int telefono, string correo, int id, string nombre, string apellido, int cedula)
            : base(id, nombre, apellido, cedula)
        {
            _telefono = telefono;
            _correo = correo;

        }

        #endregion

        // override ToString
        public override String NombreCompleto()
        {
            
            return string.Format(" Id: {0},  Nombre: {1} ", Id, Nombre);
        }

    }
}
