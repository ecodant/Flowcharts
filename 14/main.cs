
using System;
class Flowcharts14 {
  static void Main() {
    int suma= 0, promedio, valor, count = 0;
    do
    {
        Console.WriteLine("Ingrese los valores");
        string inputUsuario = Console.ReadLine();
        if (int.TryParse(inputUsuario, out valor) == true)
        {
            suma += valor;
            count++;
        } else
        {
        Console.WriteLine("**Error!, por favor ingrese valores enteros");
        }
    }
    while(count < 6);
    promedio = suma / 6;
    Console.WriteLine("La suma total de los valores es : " + suma + "\nEl promedio de los valores es: " + promedio);
  }
}
