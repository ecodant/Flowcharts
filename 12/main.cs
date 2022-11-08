using System;
using System.Text.RegularExpressions;
class HelloWorld {
  static void Main() {
    int suma= 0, valor;
    while(suma <= 78500)
    {
        Console.WriteLine("Ingrese el valor a sumar");
        string inputUsuario = Console.ReadLine();
        if (int.TryParse(inputUsuario, out valor) == true)
        {
            suma += valor;
        } else
        {
        Console.WriteLine("***Porfavor ingrese un número entero");
        }
    }
    Console.WriteLine("El resultado de sus respectivos valores es: " + suma);
  }
}