namespace LojDeSapatos.Application.InputModels
{
  public class NewSapatoInputModel
  {
    public int Id { get; private set; }
    public string Tipo { get; private set; }
    public decimal Preco { get; private set; }
    public int Tamanho { get; private set; }
    public int QuantidadeNoEstoque { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
  }
}