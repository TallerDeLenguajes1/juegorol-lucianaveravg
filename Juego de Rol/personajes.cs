using System;
using System.Collections.Generic;
using System.Text;

namespace Juego_de_Rol
{
    enum TipoPersonaje
    {
        Elfo,
        Tauren,
        Draenei,
        Humano,
        Otro
    }
   
    public class Personaje
    {
        private TipoPersonaje tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;
        private int salud;

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        public Personaje(string nombre, string apodo, TipoPersonaje tipo, DateTime fechaNacimiento, int edad)
        {

        }

        private void CrearValoresAleatorios()
        {
            Random random = new Random();
            velocidad = random.Next(1, 10);
            destreza = random.Next(1, 10);
            armadura = random.Next(1, 10);
            fuerza = random.Next(1, 10);
            Nivel = 1;
        }

        public TipoPersonaje Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }

    }
}

