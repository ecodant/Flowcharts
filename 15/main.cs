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
            if (valor > 0 && valor < 10)
            {
                Console.WriteLine("El valor: " + valor + " es mayor a 0");
                Console.WriteLine("El valor: " + valor + " es menor a 10");
            }
            else if (valor <= 0)
            {
                Console.WriteLine("El valor: " + valor + " es negativo");
                if (valor == 0) 
                {
                    Console.WriteLine("El valor: " + valor + " es 0");
                }
            }
            
             if (valor >= 10 && valor <= 100)
            {
                Console.WriteLine("El valor: " + valor + " está comprendido entre 10 y 100");
            }
            else if (valor > 100){
                Console.WriteLine("El valor: " + valor + " es mayor a 100");
            }

            count++;
        } else
        {
            Console.WriteLine("***Porfavor ingrese un número entero");
        }
    }
    while(count < 100);
  }
}