using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1DENNISALFARO.Entidades
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }

        public Persona(string nombre, int edad, string sexo, double peso, double altura) 
        { 
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
    }
}
