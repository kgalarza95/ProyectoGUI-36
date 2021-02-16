using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGUI_36.clases
{
    class Promedio : Persona
    {
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;
        
        public string estado;

        private double promedio;

        public double MyPromedio    
        {
            get { return promedio; }
            set { promedio = value; }
        }

        public Promedio(int nota1, int nota2, int nota3, int nota4)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
        }


        public Promedio()
        {
           
        }

        public int obtenerNotaBaja()
        {
            int notaMenor = int.MaxValue;
            if (nota1 < nota2)
            {
                notaMenor = nota1;
            }
            else
            {
                notaMenor = nota2;
            }
            if (nota3 < notaMenor)
            {
                notaMenor = nota3;
            }
            if (nota4 < notaMenor)
            {
                notaMenor = nota4;
            }

            return notaMenor;
        }

        public double obtenerPromedio()
        {
            promedio = 0;
            promedio = (nota1 + nota2 + nota3 + nota4 - obtenerNotaBaja()) / 3.0;
            return Math.Round(promedio,2);

        }

        public double obtenerPromedio(int nota1, int nota2)
        {
            promedio = 0;
            promedio = (nota1 + nota2 ) / 2.0;
            return Math.Round(promedio, 2);

        }

        public string obtenerEstado()
        {
            estado = "";
            if (promedio>7 )
            {
                estado = "Aprobado";
            }
            else if(promedio <=7 && promedio>3) {

                estado = "Recuperacion";
            }
            else
            {
                estado = "Reprobado";
            }

            return estado;

        }

    }
}
