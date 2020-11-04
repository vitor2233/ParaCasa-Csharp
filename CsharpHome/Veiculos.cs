using System;

namespace CsharpHome
{
  public class Veiculo
  {
    protected string _cor;
    public string cor
    {
      get { return _cor; }
      set { _cor = value; }
    }
    public string marca { get; set; }
    
    public string placa { get; set; }

    protected bool verificaSituacaoVeiculo(string placa)
    {
        //Se a placa tiver 1, então a situação está boa!
        return placa.Contains("1");
    }
  }

}
