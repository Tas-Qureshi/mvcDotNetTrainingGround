namespace webapiDotNetTrainingGround.Models;
public class Db
{
     public Db()
  {
    Developers = new List<Developer>() {
      new Developer() { Id = 1, Name = "Marcus", Email = "marcus@salt.dev" },
      new Developer() { Id = 2, Name = "Beatrice", Email = "bea@salt.dev" },
      new Developer() { Id = 3, Name = "Tas", Email = "tas@salt.dev" },
      new Developer() { Id = 4, Name = "Adam", Email = "adam@salt.dev" },
    };
  }
  public List<Developer> Developers { get; set; }
}