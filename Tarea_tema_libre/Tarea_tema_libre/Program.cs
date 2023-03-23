internal class Program
{
    private static void Main(string[] args)
    {
        float peso;
        int opcion;
        float resultado;
        Console.WriteLine("Tabla de conversiones de peso");
        Console.WriteLine("1)libras a Kilogramos");
        Console.WriteLine("2)libras a onzas");
        Console.WriteLine("3)libras a gramos");
        Console.WriteLine("4)kilogramos a libras");
        Console.WriteLine("5)kilogramos a onzas");
        Console.WriteLine("6)kilogramos a gramos");
        Console.WriteLine("7)onzas a libras");
        Console.WriteLine("8)onzas a gramos");
        Console.WriteLine("9)onzas a kilogramos");
        Console.WriteLine("0)Salir");
        Console.WriteLine("Ingrese la conversion que desea realizar: ");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese el peso que desea convertir: ");
        peso = Convert.ToSingle(Console.ReadLine());
        if (opcion == 0)
        {
            Console.WriteLine("Feliz dia");
        }
        else if (opcion == 1)
        {
            resultado = (float)(peso * 0.464);
            Console.WriteLine("El peso en kilogramos es de: " + resultado + " Kilogramos");
        }
        else if (opcion == 2)
        {
            resultado = (float)(peso * 16);
            Console.WriteLine("El peso en onzas es de: " + resultado + " onzas");
        }
        else if (opcion == 3)
        {
            resultado = (float)(peso * 0.464);
            Console.WriteLine("El peso en kilogramos es de: " + resultado + " Kilogramos");
        }
        else if (opcion == 4)
        {
            resultado = (float)(peso / 0.464);
            Console.WriteLine("El peso en libras es de: " + resultado + " libras");
        }
        else if (opcion == 5)
        {
            resultado = (float)(peso * 35.274);
            Console.WriteLine("El peso en onzas es de: " + resultado + " onzas");
        }
        else if (opcion == 6)
        {
            resultado = (float)(peso * 1000);
            Console.WriteLine("El peso en gramos es de: " + resultado + " gramos");
        }
        else if (opcion == 7)
        {
            resultado = (float)(peso / 16);
            Console.WriteLine("El peso en libras es de: " + resultado + " libras");
        }
        else if (opcion == 8)
        {
            resultado = (float)(peso * 28.34952);
            Console.WriteLine("El peso en gramos es de: " + resultado + " gramos");
        }
        else if (opcion == 9)
        {
            resultado = (float)((peso * 0.464) / 28.34952);
            Console.WriteLine("El peso en kilogramos es de: " + resultado + " Kilogramos");
        }
    }
}