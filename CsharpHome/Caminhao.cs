using System;

namespace CsharpHome
{
  public class Caminhao : Veiculo
  {
    public Caminhao(string cor, string marca)
    {
      this.cor = cor;
      this.marca = marca;
    }

    private int cargaMaxima(string marca)
    {
      switch (marca)
      {
          case "Volvo":
              return 2500;
          case "Mercedes":
              return 1000;
          default:
              return 100;
      }
    }
    public string verificarCargaMaxima(string marca)
    {
      return ("O seu caminhão da marca "+marca+" pode carregar até "+ this.cargaMaxima(marca) + " toneladas.");
    }
  }
}