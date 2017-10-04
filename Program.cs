using System;
using Newtonsoft.Json;

namespace yello
{

    class Animal {
        public string type;
        public string name;

        public void setType(string newType){
            type = newType;
        }

        public void setName(string newName){
            name = newName;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            animal.setType("Pedobear");
            animal.setName("Jorma");

            var animalJson = JsonConvert.SerializeObject(animal);

            Console.WriteLine(animalJson);
        }
    }
}
