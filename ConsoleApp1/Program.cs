
// Programa n1

using System.Collections.Generic;
using System.Linq;
using System.Text;
public class aprendiendo
{
static void Main(string[] args)
{
byte edad;
Console.WriteLine("Introduzca su edad");
edad = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Usted no aparenta " + edad + " años");
Console.WriteLine();
Console.ReadLine();
}
}

// Programa n2

Console.ReadLine();


Console.WriteLine("Introduzca 2 números:");
byte n1, n2;
Int32 mutiplicación1;

n1 = Convert.ToByte(Console.ReadLine());
n2 = Convert.ToByte(Console.ReadLine());

mutiplicación1 = Convert.ToInt16(n1) * Convert.ToInt16(n2);

Console.WriteLine("Su multiplicación es:  " + mutiplicación1);
Console.ReadLine();

// Programa n3

Console.WriteLine("Digite dos numeros largos\n");
Int64 N1, N2, multi, suma, resta;

N1 = Convert.ToInt64(Console.ReadLine());
N2 = Convert.ToInt64(Console.ReadLine());

multi = Convert.ToInt64(N1) * Convert.ToInt64(N2);
suma = Convert.ToInt64(N1) + Convert.ToInt64(N2);
resta = Convert.ToInt64(N1) - Convert.ToInt64(N2);

Console.WriteLine("\nLa suma es:" + suma);
Console.WriteLine("La resta es:" + resta);
Console.WriteLine("La multiplicación:" + multi);

Console.ReadLine();