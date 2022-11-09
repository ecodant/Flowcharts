using System;
class Flowcharts13 {
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
        Console.WriteLine("**Error!, por favor ingrese un número entero para realizar la suma");
        }
    }
    while(count < 10);
    Console.WriteLine("La suma de los respectivos valores que proporcionó es: " + suma);
  }
}
