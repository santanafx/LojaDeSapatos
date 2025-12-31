using LojDeSapatos.Core.Entities;

namespace LojDeSapatos.Infrastructure.Persistence
{
  public class LojaDeSapatosDbContext
  {
    public LojaDeSapatosDbContext()
    {
      Sapatos = new List<Sapato>
      {
        new Sapato(1, "Casual", 200.00m, 40, 100, DateTime.Now, DateTime.Now),
        new Sapato(2, "Esportivo", 250.00m, 39, 80, DateTime.Now, DateTime.Now),
        new Sapato(3, "Social", 300.00m, 38, 90, DateTime.Now, DateTime.Now),
      };

      Usuarios = new List<Usuario>
      {
        new Usuario(10,"Lucas","10416965660",new DateTime(1988,10,07),DateTime.Now,DateTime.Now)
      };
    }
    public List<Sapato> Sapatos { get; set; }
    public List<Usuario> Usuarios { get; set; }
  }
}