using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AnimalLibrary
{
    public class Hamster
    {
        public string Name { get; set; }
        public bool IsPet { get; set; }
        public Enum HamsterSpecie { get; set; }

        public List<string> LikesFood { get; set; }


        public Hamster(string name, bool isPet, HamsterSpecie specie)
        {
            Name = name;
            IsPet = isPet;
            HamsterSpecie = specie;
            LikesFood = new List<string>();
        }

        public string Greet()
        {
            return $"{Name} is a {(IsPet == true ? "pet" : "wild")} {HamsterSpecie} hamster.";
            //"Nemo is a pet Roborovski hamster."
            //"Kernel is a wild Syrian hamster."
        }

        public string Description()
        {
            if (LikesFood.Count == 0)
            {
                return $"{Name} is a {(IsPet == true ? "pet" : "wild")} {HamsterSpecie} hamster. {Name} doesn't like any food.";
            }
            else
            {
                return $"{Name} is a {(IsPet == true ? "pet" : "wild")} {HamsterSpecie} hamster. {Name} likes {LikesFood.Count} {(LikesFood.Count == 1 ? "type" : "types")} of food.";
            }




            //Assert.Equal("Goldilocks is a wild WinterWhite hamster. Goldilocks likes 1 type of food.", result);
            //Assert.Equal("Chiquita is a pet Roborovski hamster. Chiquita likes 2 types of food.", result);
            //Assert.Equal("Maximilian is a pet Campbell hamster. Maximilian doesn't like any food.", result);
        }
    }
}
