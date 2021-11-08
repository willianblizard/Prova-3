sing System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String opcao1; //declare as suas variaveis
        String opcao2;
        String opcao3;

        opcao1 = Console.ReadLine(); //insira suas variaveis
        opcao2 = Console.ReadLine();
        opcao3 = Console.ReadLine();

      if ((opcao1 == "vertebrado") && (opcao2  == "ave")  && (opcao3 == "carnivoro")) {
      Console.WriteLine("aguia\n");
    }

     if ((opcao1  == "vertebrado") && (opcao2  == "ave")  && (opcao3 == "onivoro")) {
      Console.WriteLine("pomba\n");
    }

     if ((opcao1  == "vertebrado") && (opcao2  == "mamifero")  && (opcao3 == "onivoro")) {
      Console.WriteLine("homem\n");
    }

     if ((opcao1  == "vertebrado") && (opcao2  == "mamifero")  && (opcao3 == "herbivoro")) {
      Console.WriteLine("vaca\n");
    }

     if ((opcao1  == "invertebrado") && (opcao2  == "inseto")  && (opcao3 == "hematofago")) {
      Console.WriteLine("pulga\n");
    }

     if ((opcao1  == "invertebrado") && (opcao2  == "inseto")  && (opcao3 == "herbivoro")) {
      Console.WriteLine("lagarta\n");
    }

    if ((opcao1  == "invertebrado") && (opcao2  == "anelideo") && (opcao3 == "hematofago")) {
      Console.WriteLine("sanguessuga\n");
    }

    if ((opcao1  == "invertebrado") && (opcao2  == "anelideo") && (opcao3 == "onivoro")) {
      Console.WriteLine("minhoca\n");
    }

  }
}