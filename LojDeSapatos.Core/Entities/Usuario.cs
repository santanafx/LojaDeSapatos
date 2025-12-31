namespace LojDeSapatos.Core.Entities
{
  public class Usuario
  {
    public Usuario(int id, string name, string cpf, DateTime dataDeNascimento, DateTime createdAt, DateTime updatedAt)
    {
      Id = id;
      this.name = name;
      Cpf = cpf;
      DataDeNascimento = dataDeNascimento;
      CreatedAt = createdAt;
      UpdatedAt = updatedAt;
    }

    public int Id { get; private set; }
    public string name { get; private set; }
    public string Cpf { get; private set; }
    public DateTime DataDeNascimento { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
  }
}