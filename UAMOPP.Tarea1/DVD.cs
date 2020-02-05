using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMOPP.Tarea1
{
    class DVD : IReproductores
    {
        //Atributos
        private int _id;
        private string _nombre;

        //Get y set
        public int ID { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        //Constructores
        public DVD()
        {
        }

        public DVD(int iD, string nombre)
        {
            _id = ID;
            _nombre = Nombre;
        }

        #region IReproductores
        public void FW()
        {
            Console.WriteLine("{0} - fw ", _nombre);
        }

        public void Play()
        {
            Console.WriteLine("{0} - play ", _nombre);
        }

        public void RW()
        {
            Console.WriteLine("{0} - rw ", _nombre);
        }

        public void Stop()
        {
            Console.WriteLine("{0} - Stop ", _nombre);
        }
        #endregion
    }
}
