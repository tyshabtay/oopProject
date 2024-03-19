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
            Cat cat1 = new Cat(true, true, 1);
            Cat cat2 = new Cat(true, true, 0);
            Dog dog1 = new Dog(true, true, 1);
            Dog dog2 = new Dog(true, true, 0);
            Frog frog1 = new Frog(false,false,0);
            Frog frog2 = new Frog(false,false ,1);
            Animal[] animals = { cat1, cat2,dog1,dog2,frog1,frog2 }; 
         //   foreach(Animal animal )

            
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
        public virtual void sayHello() { }//איך בד"כ מברכת לשלום
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
    public class Cat : Animal
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
