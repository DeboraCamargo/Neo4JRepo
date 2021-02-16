using System;
using System.Collections.Generic;
using System.Text;

namespace PetAcademy.Models
{
    public class Animal
    {
        public string Name { get; set; }

        public string? Sex { get; set; }

        public string? Specie { get; set; }
        public string? Color { get; set; }
        public string? Breed { get; set; }

        public int? Age { get; set; }
    }
    public class Chair
    {
        public string Name { get; set; }
        public string Professor { get; set; }
    }

    public class PetChair
    {
        public Chair Chair { get; set; }
        public Animal Animal { get; set; }
    }
}
