namespace LojDeSapatos.Core.Entities
{
  public class Sapato
  {
    public Sapato(int id, string tipo, decimal preco, int tamanho, int quantidadeNoEstoque, DateTime createdAt, DateTime updatedAt)
    {
      Id = id;
      Tipo = tipo;
      Preco = preco;
      Tamanho = tamanho;
      QuantidadeNoEstoque = quantidadeNoEstoque;
      CreatedAt = createdAt;
      UpdatedAt = updatedAt;
    }

    public int Id { get; private set; }
    public string Tipo { get; private set; }
    public decimal Preco { get; private set; }
    public int Tamanho { get; private set; }
    public int QuantidadeNoEstoque { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
  }
}