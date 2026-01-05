namespace LojDeSapatos.Application.ViewModels
{
  public class SapatoViewModel
  {
    public SapatoViewModel(int id, string tipo, decimal preco, int tamanho, int quantidadeNoEstoque)
    {
      Id = id;
      Tipo = tipo;
      Preco = preco;
      Tamanho = tamanho;
      QuantidadeNoEstoque = quantidadeNoEstoque;
    }

    public int Id { get; set; }
    public string Tipo { get; set; }
    public decimal Preco { get; set; }
    public int Tamanho { get; set; }
    public int QuantidadeNoEstoque { get; set; }
  }
}