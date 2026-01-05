using LojDeSapatos.Application.InputModels;
using LojDeSapatos.Application.ViewModels;

namespace LojDeSapatos.Application.Service.Interface
{
  public interface ISapatoService
  {
    int Create(NewSapatoInputModel inputModel);
    SapatoViewModel? GetById(int id);
    List<SapatoViewModel> GetAll();
  }
}