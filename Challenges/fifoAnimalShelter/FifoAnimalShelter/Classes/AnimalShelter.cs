using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace FifoAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Dog Dog { get; set; }
        public Cat Cat { get; set; }
        public Queue Shelter { get; set; }
        
        public AnimalShelter()
        {
            Dog = new Dog();
            Cat = new Cat();
            Shelter = new Queue();
        }


    }
}
