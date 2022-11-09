using System;
class Flowcharts12 {
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
        Console.WriteLine("**Error!, por favor ingrese un número entero");
        }
    }
    Console.WriteLine("La suma ha finalizado, el resultado de sus respectivos valores es: " + suma);
  }
}
