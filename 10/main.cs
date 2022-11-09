using System;
using System.Text.RegularExpressions;
class HelloWorld {
  static void Main() {
    string alumno;
    bool noteConfirm = false;
    int nota, count = 0;
    do
    {
        Console.WriteLine("Ingrese el nombre y apellido del alumno");
        alumno = Console.ReadLine();
        Regex reg = new Regex(@"[a-zA-Z] ");
        if (reg.IsMatch(alumno) == true)
        {
            while (noteConfirm == false)
            {
                Console.WriteLine("Ingrese la nota del alumno");
                if (int.TryParse(Console.ReadLine(), out nota) == true)
                {
                    Console.WriteLine("El alumno: "+ alumno +" tiene una nota de " + nota);
                    count++;
                    noteConfirm = true;
                }
                else 
                {
                    Console.WriteLine("***Error!, la nota debe ser un número entero");
                }
            }
            noteConfirm = false;
        }
        else
        {
            Console.WriteLine("***Error!, el sistema requiere un nombre y apellido");
        }
    }
    while(count < 24);
  }
}
