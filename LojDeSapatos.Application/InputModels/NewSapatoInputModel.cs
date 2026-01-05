using System.ComponentModel.DataAnnotations;

namespace LojDeSapatos.Application.InputModels
{
  public class NewSapatoInputModel
  {
    public int Id { get; private set; }

    [Required]
    public string Tipo { get; set; } = string.Empty;

    public decimal Preco { get; set; }
    public int Tamanho { get; set; }
    public int QuantidadeNoEstoque { get; set; }

    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
  }
}