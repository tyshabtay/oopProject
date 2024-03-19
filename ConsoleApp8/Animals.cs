using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TestAnimal
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(true, true, 1);
            Dog dog = new Dog(true, true, 1);
            Frog frog = new Frog(false,false,0);
            Animal[] animalsArr = { cat,dog,frog };
            List<Animal> animals = new List<Animal>();
            animals.AddRange(animalsArr);
            foreach (Animal animal in animals )
            {
                Console.WriteLine("Hello this is the " + (animal is Water  ? "Frog !" :( animal is Dog) ? "dog !" : "Cat !"));
                Console.WriteLine("is it carnivorous? "+animal.isCarnivorous().ToString());
                Console.WriteLine("is it Mammals? " + animal.isMammals().ToString());
                if (animal is Land land)
                {                  
                    Console.WriteLine("How many legs it has? " + land.getNumberOfLegs());
                }
                Console.WriteLine("How it communicates when it is afraid? ");
                animal.sayHello(0);
                Console.Write("and when it is in a good mood? ");
                animal.sayHello(1);
                Console.Write("How it is used to saying goodbye to people? ");
                animal.sayHello();
                if(animal is Water water)
                {
                   Console.WriteLine("is it hasLaysEggs? " + water.hasLaysEggs());
                   Console.WriteLine("is it hasGills? " + water.hasGills());
                }

                Console.ReadLine();
            }

            
        }
    }
    public interface Land
    {
      int  getNumberOfLegs();
    }
    public interface Water
    {
        Boolean hasGills(); //האם יש זימים 
        Boolean hasLaysEggs();//האם מטיל בייצים
    }
    public abstract class Animal
    {     
        bool mammals;//יונקת;
        bool carnivorous;//טורפת 
        public abstract int MOOD_HAPPY { get; }//כשהחיה במצב רוח טוב
        public abstract int MOOD_SCARE { get; }//כשהחיה מפוחדת
        public int mood;//מצב רוח נוכחי
        public Animal(bool Mammals, bool Cornivorous ,int Mood )
        {
            this.mammals = Mammals;
            this.carnivorous = Cornivorous;
            this.mood = Mood;

        }
        public abstract void sayHello(int mood);//איך מברכת אנשים לשלום במצב רוח מסוים
        public virtual void sayHello() {
            Console.WriteLine("it isnt used to saying goodbye to people.");
        }//איך בד"כ מברכת לשלום
        public bool isMammals() { return mammals; } 
        public void setMammals(Boolean mammals) { this.mammals = mammals; }
        public bool isCarnivorous() { return carnivorous; }
        public void setCarnivorous(Boolean carnivorous) { this.carnivorous = carnivorous; }
        
    }
    public class Dog : Animal ,Land
    {
        int numberOfLegs=4;
        public override int MOOD_HAPPY => 1;
        public override int MOOD_SCARE => 0;
       public Dog(bool Mammals, bool Cornivorous, int Mood) : base(Mammals, Cornivorous, Mood)
        {

        }
        public override void sayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
                Console.WriteLine("it will bark loudly");
            else
                Console.WriteLine("it will make whooping sound");
        }
        public override void sayHello()
        {
            Console.WriteLine("waggings his tail");
        }
        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
    public class Cat : Animal,Land
    {
        int numberOfLegs=4;
        public override int MOOD_HAPPY => 1;
        public override int MOOD_SCARE => 0;
       public Cat(bool Mammals, bool Cornivorous, int Mood) : base(Mammals, Cornivorous,Mood)
        {

        }
        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }
        public override void sayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
                Console.WriteLine("it will make purr, purr sound");
            else
                Console.WriteLine("it will make hiss sound");
        }
        public override void sayHello()
        {
            Console.WriteLine("it will make meow~ sound");
        }
    }
    public class Frog : Animal,Land,Water
    {
        int numberOfLegs=2;
        public bool IsOviparous() { return oviparous; }
        bool oviparous = true; //שחלתית
        public override int MOOD_HAPPY => 1;

        public override int MOOD_SCARE => 0;
       
        public override void sayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
                Console.WriteLine("it will sing quack quack quack");
            else
                Console.WriteLine("it will plop into the water");
        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }

        public bool hasGills()
        {
            return false;
        }

        public bool hasLaysEggs()
        {
            return true;
        }

        public Frog(bool Mammals, bool Cornivorous, int Mood) : base(Mammals, Cornivorous, Mood)
        {

        }

    }


}
