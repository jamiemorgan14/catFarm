using System.ComponentModel.DataAnnotations;

namespace catFarm.Models
{
  public class Cat
  {
    [Required] public int Id { get; set; }
    [Required] public string Name { get; set; }
    [Required] public int Age { get; set; }
    [Required] public bool Friendly { get; set; }
    public bool BetterThanDog { get; set; } = false;

    public Cat(int id, string name, int age, bool friendly)
    {
      Id = id;
      Name = name;
      Age = age;
      Friendly = friendly;
    }
  }
}