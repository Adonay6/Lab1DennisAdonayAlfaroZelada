using LAB1DENNISALFARO.Entidades;
using LAB1DENNISALFARO.Negocio;

Console.WriteLine("Escribe tu nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Escribe tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe tu sexo: ");
string sexo = Console.ReadLine();

Console.WriteLine("Escribe tu peso: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Escribe tu altura: ");
double altura = double.Parse(Console.ReadLine());

Persona persona = new Persona(nombre, edad, sexo, peso, altura);
ClsPersona clsPersona = new ClsPersona();

Console.WriteLine(clsPersona.CalcularIMC(persona));
Console.WriteLine(clsPersona.esMayorDeEdad(persona));
Console.ReadKey();