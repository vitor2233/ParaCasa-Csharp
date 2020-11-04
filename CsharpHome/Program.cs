using System;

namespace CsharpHome
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("|--CARRO--|");
      Carro car = new Carro("prata", "Fiat");
      Console.WriteLine("Carro da cor " + car.cor + " e marca: " + car.marca);
      Console.WriteLine(car.mostrarSituacao("23344571"));

      Console.WriteLine("|--MOTO--|");
      Moto moto = new Moto("vermelha", "Honda");
      Console.WriteLine("Moto da cor " + moto.cor + " e marca: " + moto.marca);
      Console.WriteLine(moto.verificarGrau("Honda"));

      Console.WriteLine("|--CAMINHÃO--|");
      Caminhao caminhao = new Caminhao("Azul", "Volvo");
      Console.WriteLine("Caminhão da cor " + caminhao.cor + " e marca: " + caminhao.marca);
      Console.WriteLine(caminhao.verificarCargaMaxima("Volvo"));
    }
  }
}
