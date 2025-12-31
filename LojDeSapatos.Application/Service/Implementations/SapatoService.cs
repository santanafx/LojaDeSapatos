

using LojDeSapatos.Application.InputModels;
using LojDeSapatos.Core.Entities;
using LojDeSapatos.Infrastructure.Persistence;

namespace LojDeSapatos.Application.Service.Implementations
{
  public class SapatoService
  {
    private readonly LojaDeSapatosDbContext _dbContext;
    public SapatoService(LojaDeSapatosDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public string Create(NewSapatoInputModel inputModel)
    {
      var id = System.Random.Shared.Next(1, int.MaxValue);
      var sapato = new Sapato(id, inputModel.Tipo, inputModel.Preco, inputModel.Tamanho, inputModel.QuantidadeNoEstoque, inputModel.CreatedAt, inputModel.UpdatedAt);
      _dbContext.Sapatos.Add(sapato);

      return "Sapato criado com sucesso!";
    }
  }
}