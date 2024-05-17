using System;

Console.WriteLine("\n programa para mostrar los dias de la semana \n");
Console.WriteLine("\n ingrese el dia de la semana \n");

int seleccion = int.Parse(Console.ReadLine());

switch (seleccion)
{

    case 1:
        Console.WriteLine("hoy es lunes");
        break;
    case 2:
        Console.WriteLine("hoy es martes");
        break;
    case 3:
        Console.WriteLine("hoy es miercoles");
        break;
    case 4:
        Console.WriteLine("hoy es jueves");
        break;
    case 5:
        Console.WriteLine("hoy es vienes");
        break;
    case 6:
        Console.WriteLine("hoy es sabado");
        break;
    case 7:
        Console.WriteLine("hoy es domingo");
        break;
    default: // se usa para que no de error para que se evite el cracheo
        Console.WriteLine("no fue ingresada ningun dia existente");
        break;

}
