internal class Program
{
    
    private static void sumar()
    {
        Console.WriteLine("funcion suma");
    }
    public static void resta()
    {
        Console.WriteLine("funcion resta");
    }
    public static void multiplicacion()
    {
        Console.WriteLine("funcion Multi");
    }
    public static void Divicion()
    {
        Console.WriteLine("funcion divicion");
    }
    private static void Main(string[] args)
    {
        int op = 100;
    float num1, num2,num3,num4,num5;
    float resultado;
        
        do
        {
            Console.WriteLine("Menu de operaciones ");
            Console.WriteLine("Sumar(1) ");
            Console.WriteLine("Restar(2) ");
            Console.WriteLine("Muliplicar(3) ");
            Console.WriteLine("Divicion(4) ");
            Console.WriteLine("Todas las anteriores(5) ");
            Console.WriteLine("salir(0) ");
            Console.WriteLine("Ingrese la opcion deseada:....");
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
                    Console.WriteLine(op);
                    break;
                default: 
                    Console.WriteLine("opcion no valida");
                    break;
            }
        } while(op != 0);
       
    }
}