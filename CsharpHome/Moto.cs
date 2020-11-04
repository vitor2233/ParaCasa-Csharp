using System;

namespace CsharpHome
{
  public class Moto : Veiculo
  {
    public Moto(string cor, string marca)
    {
      this.cor = cor;
      this.marca = marca;
    }

    private bool podeDarGrau(string marca)
    {
      return (marca == "Honda");
    }

    public string verificarGrau(string marca)
    {
      return this.podeDarGrau(marca) ? "Pode sim" : "Não pode";
    }
  }
}