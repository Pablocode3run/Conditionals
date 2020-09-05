using System;

class MainClass {
  public static void Main (string[] args) {
    double notaquiz;
    double notataller;
    double notaparticipacion;
    double promedio;
    Console.WriteLine("Digite la nota del quiz ");
    notaquiz = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite la nota del taller ");
    notataller = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite la nota de participación en clase ");
    notaparticipacion = double.Parse(Console.ReadLine());

    promedio = (notaquiz + notataller + notaparticipacion) / 3;

    if (promedio>=3.0){ 
      Console.WriteLine("Va ganado mpp eso es todo, su nota es: "+ promedio);
    }
    else{
      Console.WriteLine("Va perdiendo mpp lo veo mal, su nota es: "+ promedio);
    }
    
    
  }
}