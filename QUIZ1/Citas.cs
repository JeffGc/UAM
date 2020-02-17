using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class Citas
    {
        #region Citas

        //Atributos
        private int _idCita;
        private string _nombreDoctor;
        private string _nombreCliente;


        //Get set
        public int IdCita { get => _idCita; set => _idCita = value; }
        public string NombreDoctor { get => _nombreDoctor; set => _nombreDoctor = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }

        public Citas()
        {
        }

        public Citas(int idCita, string nombreDoctor, string nombreCliente)
        {
            _idCita = idCita;
            _nombreDoctor = nombreDoctor;
            _nombreCliente = nombreCliente;
        }

        public override string ToString()
        {
            return "ID: " + _idCita + " Nombre Doctor: " + _nombreDoctor 
                + " Nombre Cliente: " + _nombreCliente;
        }
        #endregion


    }
}
