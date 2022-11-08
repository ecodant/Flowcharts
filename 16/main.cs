using System;
using System.Text.RegularExpressions;
class HelloWorld {
  static void Main() {
    int count = 0, valor, promedio,valoresPromedio = 0;
    int suma = 0;
    do
    {
        Console.WriteLine("Ingrese un número");
        string inputUsuario = Console.ReadLine();
        if (int.TryParse(inputUsuario, out valor) == true)
        {
           if (valor >= 5 && valor <= 2500)
           {
               suma += valor;
               valoresPromedio += 1;
           }
           count++;
        } 
        else
        {
            Console.WriteLine("***Porfavor ingrese un número entero");
        }
    }
    while(count < 10);
    promedio = suma / valoresPromedio;
    Console.WriteLine("El promedio de los valores entre 5 y 2500, que usted proporcionó es: " + promedio);
  }
}
