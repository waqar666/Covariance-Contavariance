// // See https://aka.ms/new-console-template for more information
// using Main;
// //covariance and contavariance using generic interfaces
// IAnimalShelter<Animal> animalShelter = new DogShelter();
// Animal animal = animalShelter.GetAnimal();
// Console.WriteLine($"dog name is {animal.Name}");
// IAnimalProcessor<Animal> dogprocessor = new AnimalProcessor();
// dogprocessor.ProcessAnimal(new Dog() { Name = "hunny", Breed = "alsation"});

// namespace Main
// {
//     public class Animal { public string? Name { get; set; } }
//     public class Dog : Animal { public string? Breed { get; set; } }
// // Covariant interface with 'out' keyword
//     interface IAnimalShelter<out T> where T : class { T GetAnimal(); }
//     public class DogShelter : IAnimalShelter<Dog>
//     {
//         public Dog GetAnimal()
//         {
//             return new Dog { Name = "Buddy", Breed = "Bulldog" };
//         }
//     }
// // Contravariant interface with 'in' keyword
//     interface IAnimalProcessor<in T> where T: class 
//     {
//        void  ProcessAnimal(T animal);
//     }
//     public class AnimalProcessor: IAnimalProcessor<Animal>
//     {
//         public void ProcessAnimal(Animal animal)
//         {
//             Console.WriteLine($"Animal processed {animal.Name}");
//         }
//     }   
    
// }

