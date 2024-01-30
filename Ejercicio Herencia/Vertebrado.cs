
namespace Ejercicio_Herencia
{
    internal class Vertebrado : Animal
    {
        public string Tipo {  get; set; }

        public bool TienePatas { get; set; }

        public bool EsDomestico { get; set; }

        public bool EsHerbivoro { get; set; }

        public bool EsCarnivoro { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene patas: {(TienePatas ? "Si" : "No")}" );
            Console.WriteLine($"Es doméstico: {(EsDomestico ? "Si" : "No")}");
            Console.WriteLine($"Es herbívoro: {(EsHerbivoro ? "Si" : "No")}");
            Console.WriteLine($"Es carnívoro: {(EsCarnivoro ? "Si" : "No")}");
        }
    }
}
