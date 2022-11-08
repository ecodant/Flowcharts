using System;
using System.Text.RegularExpressions;
class HelloWorld {
  static void Main() {
    string alumno;
    int nota, count = 0;
    do
    {
        Console.WriteLine("Ingrese el nombre y apellido del usuario del alumno");
        alumno = Console.ReadLine();
        Regex reg = new Regex(@"[a-zA-Z] ");
        if (reg.IsMatch(alumno) == true)
        {
            Console.WriteLine("Ingrese la nota del alumno");
            nota = int.Parse(Console.ReadLine());
            count++;
            Console.WriteLine("El alumno: "+ alumno +" tiene una nota de " + nota);
        }
        else
        {
            Console.WriteLine("***Porfavor escriba un nombre y apellido");
        }
    }
    while(count < 24);
  }
}