using System;

namespace CsharpHome
{
  public class Carro : Veiculo
  {
    public Carro(string cor, string marca)
    {
      this.cor = cor;
      this.marca = marca;
    }
    
    public string mostrarSituacao(string placa)
    {
      return this.verificaSituacaoVeiculo(placa) ? "Veiculo OK" : "Veiculo não OK";
    }
  }
}