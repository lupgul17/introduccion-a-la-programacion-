internal class Program
{
    static float num1, num2, num3, num4, num5, resultado;
    private static void sumar()
    {

        Console.Write("Opcion 1: SUMA ");
        Console.Write("Porfavor ingrese el primer numero: ");
        num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el segundo numero: ");
        num2 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el tercer numero: ");
        num3 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el cuarto numero: ");
        num4 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el quinto numero: ");
        num5 = Convert.ToSingle(Console.ReadLine());
        resultado = num1 + num2 + num3 + num4 + num5;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("El resultado de la suma es: " + resultado);
        Console.ReadLine();//lectura con el fin de hacer una espera antes de regresar al menu 
        Console.Clear();
    }
    public static void resta()
    {
        Console.Write("Opcion 1: RESTA ");
        Console.Write("Porfavor ingrese el primer numero: ");
        num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el segundo numero: ");
        num2 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el tercer numero: ");
        num3 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el cuarto numero: ");
        num4 = Convert.ToSingle(Console.ReadLine());
        resultado = num1 - num2 - num3 - num4;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("El resultado de la resta es: " + resultado);
        Console.ReadLine();//lectura con el fin de hacer una espera antes de regresar al menu 
        Console.Clear();
    }
    public static void multiplicacion()
    {
        Console.Write("Opcion 1: MULTIPLICACION ");
        Console.Write("Porfavor ingrese el primer numero: ");
        num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el segundo numero: ");
        num2 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el tercer numero: ");
        num3 = Convert.ToSingle(Console.ReadLine());
        resultado = num1 * num2 * num3;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("El resultado de la multiplicaion es: " + resultado);
        Console.ReadLine();//lectura con el fin de hacer una espera antes de regresar al menu 
        Console.Clear();
    }
    public static void Divicion()
    {
        Console.Write("Opcion 1: DIVICION ");
        Console.Write("Porfavor ingrese el primer numero: ");
        num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Porfavor ingrese el segundo numero: ");
        num2 = Convert.ToSingle(Console.ReadLine());

        resultado = num1 / num2;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("El resultado de la divicion es: " + resultado);
        Console.ReadLine();//lectura con el fin de hacer una espera antes de regresar al menu 
        Console.Clear();
    }
    private static void Main(string[] args)
    {
        int op = 100;


        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu de operaciones ");
            Console.WriteLine("1.Sumar ");
            Console.WriteLine("2.Restar ");
            Console.WriteLine("3.Muliplicar ");
            Console.WriteLine("4.Divicion ");
            Console.WriteLine("5.Todas las anteriores ");
            Console.WriteLine("0.salir ");
            Console.Write("Ingrese la opcion deseada:....");
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 0:
                    break;
                case 1:
                    sumar();
                    break;
                case 2:
                    resta();
                    break;
                case 3:
                    multiplicacion();
                    break;
                case 4:
                    Divicion();
                    break;
                case 5:
                    sumar();
                    resta();
                    multiplicacion();
                    Divicion();
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }
        } while (op != 0);

    }
}