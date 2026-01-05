using LojDeSapatos.Application.InputModels;
using LojDeSapatos.Application.Service.Interface;
using LojDeSapatos.Application.ViewModels;
using LojDeSapatos.Core.Entities;
using LojDeSapatos.Infrastructure.Persistence;

namespace LojDeSapatos.Application.Service.Implementations
{
  public class SapatoService : ISapatoService
  {
    private readonly LojaDeSapatosDbContext _dbContext;
    public SapatoService(LojaDeSapatosDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public int Create(NewSapatoInputModel inputModel)
    {
      var id = System.Random.Shared.Next(1, int.MaxValue);

      var createdAt = inputModel.CreatedAt == default ? DateTime.Now : inputModel.CreatedAt;
      var updatedAt = inputModel.UpdatedAt == default ? DateTime.Now : inputModel.UpdatedAt;

      var sapato = new Sapato(
        id,
        inputModel.Tipo,
        inputModel.Preco,
        inputModel.Tamanho,
        inputModel.QuantidadeNoEstoque,
        createdAt,
        updatedAt
      );
      _dbContext.Sapatos.Add(sapato);

      return id;
    }

    public SapatoViewModel? GetById(int id)
    {
      var sapato = _dbContext.Sapatos.SingleOrDefault(p => p.Id == id);

      if (sapato == null)
      {
        return null;
      }

      var sapatoViewModel = new SapatoViewModel(
        sapato.Id,
        sapato.Tipo,
        sapato.Preco,
        sapato.Tamanho,
        sapato.QuantidadeNoEstoque
      );

      return sapatoViewModel;
    }

    public List<SapatoViewModel> GetAll()
    {
      var sapatos = _dbContext.Sapatos
        .Select(s => new SapatoViewModel(
          s.Id,
          s.Tipo,
          s.Preco,
          s.Tamanho,
          s.QuantidadeNoEstoque
        ))
        .ToList();

      return sapatos;
    }
  }
}