
namespace Ejercicio_Herencia
{
    internal class Invertebrado : Animal
    {
        public string Tipo { get; set; }

        public bool TienePatas { get; set; }

        public int NumeroPatas { get; set; }

        public bool TieneConcha { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine("Color: " + Color + "\n Color" + Color);
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene patas: {(TienePatas ? "Si" : "No")}");
            Console.WriteLine($"Número de patas: {NumeroPatas}");
            Console.WriteLine($"Tiene concha: {(TieneConcha ? "Si" : "No")}");
        }
    }
}
