using Neo4jClient;
using System;
using System.Threading.Tasks;
using PetAcademy.Models;

namespace PetAcademy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Crud crud = new Crud();
            await crud.CleanDatabase();
            await crud.SavePet(new Animal { Name= "Happy Tails1", Sex = "Female", Specie= "Dog", Color= "White", Breed= "Lhasa Apso", Age= 13 });
        }
    }

}
