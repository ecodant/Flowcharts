using System;
using System.Text.RegularExpressions;
class HelloWorld {
  static void Main() {
    int suma= 0, valor, count = 0;
    do
    {
        Console.WriteLine("Ingrese el valor a sumar");
        string inputUsuario = Console.ReadLine();
        if (int.TryParse(inputUsuario, out valor) == true)
        {
            suma += valor;
            count++;
        } else
        {
        Console.WriteLine("***Porfavor ingrese un número entero");
        }
    }
    while(count < 10);
    Console.WriteLine("El resultado de sus respectivos valores es: " + suma);
  }
}