using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tipo de fruta");
        Console.WriteLine("1. Naranja");
        Console.WriteLine("2. Fresa");
        Console.WriteLine("3. Mango");
        Console.Write("Seleccione una opción (1/2/3): ");
        

        string tipoDefruta = Console.ReadLine();

        int opcion =int.Parse(tipoDefruta);

        Console.WriteLine("Ingrese la distancia en km");
        string distanciaTexto = Console.ReadLine();
        
        float distancia = float.Parse(distanciaTexto); 

        float costodenvio = 0f;

        switch (tipoDefruta)
        {
            case "1":
                Console.WriteLine("Ha seleccionado Naranja.");
                if (distancia <= 30)
                {
                    costodenvio = 2.00f;
                }
                else
                {
                    costodenvio = 4.00f;
                }
                break;
            case "2":
                Console.WriteLine("Ha seleccionado Fresa.");
                if (distancia <= 30)
                {
                    costodenvio = 6.00f;
                }
                else
                {
                    costodenvio = 9.00f;
                }
                break;
            case "3":
                Console.WriteLine("Ha seleccionado Mango.");
                if (distancia <= 30)
                {
                    costodenvio = 3.00f;
                }
                else
                {
                    costodenvio = 5.00f;
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

       
            Console.WriteLine("El pago por realizarse por la carga : s./ " + costodenvio);
        Console.ReadLine();

       
    }
}
