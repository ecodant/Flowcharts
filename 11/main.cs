using System;
using System.Text.RegularExpressions;
class HelloWorld {
  static void Main() {
    int count = 0, valor;
    do
    {
        Console.WriteLine("Ingrese un número");
        string inputUsuario = Console.ReadLine();
        if (int.TryParse(inputUsuario, out valor) == true)
        {
            if (valor >= 10)
            {
                if (valor <= 100) 
                {
                    Console.WriteLine("El valor: "+ valor + " esta comprendido entre 10 y 100");
                }
                else
                {
                    Console.WriteLine("El valor: "+ valor + " es mayor a 100");
                }
            }
            else
            {
                Console.WriteLine("El valor: "+ valor + " es menor a 10");
            }
            count++;
        } else
        {
            Console.WriteLine("***Porfavor ingrese un número entero");
        }
    }
    while(count < 10);
  }
}