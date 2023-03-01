using LAB1DENNISALFARO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1DENNISALFARO.Negocio
{
    internal class ClsPersona
    {
        public string CalcularIMC(Persona persona)
        {
            Double imc = persona.peso / (persona.altura * 2);
            if (imc < 24)
            {
                return "peso ideal";
            }
            else
            {
                return "Tiene sobrepeso";
            }
        }
        public string esMayorDeEdad(Persona persona)
        {
            if(persona.edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
    }
}
