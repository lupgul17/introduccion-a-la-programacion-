internal class Program
{
    private static void Main(string[] args)
    {
        int annio, dia, mesNumero;
        string mes;
        Console.WriteLine("Porfavor ingrese el dia en numero: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Porfavor ingrese el annio en numero: ");
        annio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Porfavor ingrese el mes en letras con inicial mayuscula: ");
        mes = Console.ReadLine();
        if ((dia >= 1 && dia <= 31))
        {
            switch (mes)
            {
                case "Enero":
                    mesNumero = 1;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Febrero":
                    mesNumero = 2;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Marzo":
                    mesNumero = 3;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Abril":
                    mesNumero = 4;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Mayo":
                    mesNumero = 5;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Junio":
                    mesNumero = 6;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Julio":
                    mesNumero = 7;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Agosto":
                    mesNumero = 8;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Septiembre":
                    mesNumero = 9;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Octubre":
                    mesNumero = 10;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Noviembre":
                    mesNumero = 11;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                case "Diciembre":
                    mesNumero = 12;
                    Console.WriteLine("estamos en el " + dia + " del" + mesNumero + "del año " + annio);
                    break;
                default:
                    Console.WriteLine("El mes ingresado no es valido");
                    break;
            }
        }
        else
        {
            Console.WriteLine("El dia(" + dia + ") no es valido");
        }

    }
        }