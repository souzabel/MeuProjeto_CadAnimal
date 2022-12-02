using MeuProject.Models;
using MeuProject.Repository.Context;


namespace MeuProject.Repository

{
    public class AnimalRepository
    {
        public readonly DataBaseContext context;
        public AnimalRepository()
        {
            context = new DataBaseContext();
        }
        public IList<Animal> Listar()
        {
            return context.Animal.ToList();
        }
    }
}