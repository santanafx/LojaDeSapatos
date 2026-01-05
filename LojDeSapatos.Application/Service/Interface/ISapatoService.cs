using LojDeSapatos.Application.InputModels;

namespace LojDeSapatos.Application.Service.Interface
{
  public interface ISapatoService
  {
    string Create(NewSapatoInputModel inputModel);
  }
}