using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGUI_36.clases
{
    class Conferencia
    {
        private String nombreConferencia;
        private String nombreConferencista;
        private String lugar;
        private String fecha;
        private String hora;
        private String categoria;//tecnologia, social, medicina, leyes   
        private int cantAsistentes;
        private double valorEntrada;

        public Conferencia()
        {
        }


        public String getNombreConferencia()
        {
            return nombreConferencia;
        }

        public void setNombreConferencia(String nombreConferencia)
        {
            this.nombreConferencia = nombreConferencia;
        }

        public String getNombreConferencista()
        {
            return nombreConferencista;
        }

        public void setNombreConferencista(String nombreConferencista)
        {
            this.nombreConferencista = nombreConferencista;
        }

        public String getLugar()
        {
            return lugar;
        }

        public void setLugar(String lugar)
        {
            this.lugar = lugar;
        }

        public String getFecha()
        {
            return fecha;
        }

        public void setFecha(String fecha)
        {
            this.fecha = fecha;
        }

        public String getHora()
        {
            return hora;
        }

        public void setHora(String hora)
        {
            this.hora = hora;
        }

        public String getCategoria()
        {
            return categoria;
        }

        public void setCategoria(String categoria)
        {
            this.categoria = categoria;
        }

        public int getCantAsistentes()
        {
            return cantAsistentes;
        }

        public void setCantAsistentes(int cantAsistentes)
        {
            this.cantAsistentes = cantAsistentes;
        }

        public double getValorEntrada()
        {
            return valorEntrada;
        }

        public void setValorEntrada(double valorEntrada)
        {
            this.valorEntrada = valorEntrada;
        }

    
    }
}
