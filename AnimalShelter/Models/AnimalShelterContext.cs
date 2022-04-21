using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Emily", Type = "Dog", Age = 2, Sex ="Female", Description = "A young German Shepherd who loves playing frisbee."},
        new Animal { AnimalId = 2, Name = "Benjie", Type = "Dog", Age = 4, Sex ="Male", Description = "A sweet, mixed breed dog that is always happy to sit on a lap."},
        new Animal { AnimalId = 3, Name = "Sasha", Type = "Cat", Age = 3, Sex ="Female", Description = "A playful black cat without a care in the world."},
        new Animal { AnimalId = 4, Name = "O'Bryan", Type = "Cat", Age = 1, Sex ="Male", Description = "An excitable tabby who loves to lay in the sun."},
        new Animal { AnimalId = 5, Name = "Gertrude", Type = "Cat", Age = 7, Sex ="Female", Description = "A confident hairless cat that knows every last detail of her environment."}
      );
    }
  }
}