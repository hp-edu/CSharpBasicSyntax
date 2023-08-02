using Pet;
using Biganimal;

int cat1PositionX = 10;
int cat1PositionY = 20;
System.Console.WriteLine($"Cat1's location x, y is {cat1PositionX}, {cat1PositionY}"); //String interpolcation

int cat2PositionX = 30;
int cat2PositionY = 50;
System.Console.WriteLine("Cat2's position x, y is "+cat2PositionX+", "+cat2PositionY); 




Cat cat1 = new (); // Object, Instance
cat1.positionX = 10;
cat1.positionY= 20;
cat1.name = "Cat1";
cat1.Print();

Cow cow = new ();

namespace Pet{
    public class Cat{
        public int positionX;
        public int positionY;
        public string name;
        public void Print(){
            System.Console.WriteLine($"PET: {name}'s position x, y is {positionX} , {positionY}");
        }
    }

        public class Dog{
        public int positionX;
        public int positionY;
        public string name;
        public void Print(){
            System.Console.WriteLine($"{name}'s position x, y is {positionX} , {positionY}");
        }
    }
}

namespace WildAnimal{
    public class Cat{
        public int positionX;
        public int positionY;
        public string name;
        public void Print(){
            System.Console.WriteLine($"WILD: {name}'s position x, y is {positionX} , {positionY}");
        }
    }

        public class Dog{
        public int positionX;
        public int positionY;
        public string name;
        public void Print(){
            System.Console.WriteLine($"{name}'s position x, y is {positionX} , {positionY}");
        }
    }
}