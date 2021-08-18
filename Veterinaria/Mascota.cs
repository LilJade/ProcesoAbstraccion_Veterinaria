using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria
{
    class Mascota
    {
        private string nombre;
        private string especie;
        private string raza;
        private double peso;
        private int edad;
        private string sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public void Vacunar() {
            Console.WriteLine("La mascota ha sido vacunada");
        }

        public void Examinar() {
            Console.WriteLine("La mascota ha sido examinada");
        }

        public void Operar() {
            Console.WriteLine("La mascota ha sido operada");
        }

        public Mascota() { }

        public Mascota(string nombre, string especie) {
            this.nombre = nombre;
            this.especie = especie;
        }

        public Mascota(string nombre, string especie, string raza, double peso, int edad, string sexo) 
        {
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.peso = peso;
            this.edad = edad;
            this.sexo = sexo;
        }
    }
}
