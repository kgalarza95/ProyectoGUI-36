using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGUI_36.clases
{
    class Persona
    {
        private string cedula;
        private string alumno;

        public string Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }


        public string Cedula    
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public Persona(string cedula, string alumno)
        {
            this.cedula = cedula;
            this.alumno = alumno;
        }

        public Persona()
        {
        }

    }
}
