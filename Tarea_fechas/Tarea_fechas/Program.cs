// See https://aka.ms/new-console-template for more information

#region variables 
int diaActual;
int diaNacimiento;
int mesActual;
int mesNacimiento;
int annioActual;
int annioNacimiento;
bool verificador=false;
#endregion
#region Algoritmo
Console.WriteLine("Ingrese el dia que nacio....");
diaNacimiento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el mes que nacio....");
mesNacimiento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el annio que nacio....");
annioNacimiento = Convert.ToInt32(Console.ReadLine());
//fecha actual por medio de DateTime
diaActual = DateTime.Now.Day;
mesActual = DateTime.Now.Month;
annioActual = DateTime.Now.Year;
Console.WriteLine(diaActual +"-"+mesActual +"-"+annioActual);
//Algoritmo condicional 
if(annioActual-annioNacimiento > 18)
{
    verificador = true;    
}
else
{
    if(annioActual - annioNacimiento <= 16)
    {
        verificador=false;    
    }
    else if(annioActual - annioNacimiento >= 17)
    {
        if(mesActual > mesNacimiento)
        {
            verificador=true;
        }
        if(mesActual < mesNacimiento)
        {
            verificador = false;
        }
        else if(mesActual== mesNacimiento) 
        {
            if(diaActual > diaNacimiento) 
            {
                verificador = false;
            }
            else if(diaActual<=diaNacimiento)
            {
                verificador =true;
            }
        }
    }
}
if(verificador==true)
{
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine("Es menor de edad");
}
#endregion


