namespace Lab06_Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lion ammar = new Lion();
            ammar.Roar();
        }
    }
    public abstract class Animal
    {
        protected abstract string Species { get; set; }
        protected abstract string Habitat { get; set; }
        protected abstract string Diet { get; set; }
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Move();

    }
    public abstract class Mammals : Animal
    {
        protected abstract int OffspringNum { get; set; }
        protected abstract string FurColor { get; set; }
        protected abstract int Gestation { get; set; }
        public virtual void Nurse()
        {
            Console.WriteLine("The mammal is nursing its young.");
        }

        public virtual void Groom()
        {
            Console.WriteLine("The mammal is grooming itself.");
        }

    }
    public class Lion : Mammals
    {
        protected int EatsEvery { get; set; } = 72;
        protected string ManeColor { get; set; } = "brown";
        protected int PrideSize { get; set; } = 15;
        protected override string FurColor { get; set; } = "Golden yellow";
        protected override int Gestation { get; set; } = 110;
        protected override int OffspringNum { get; set; } = 3;
        protected override string Species { get; set; } = "Panthera leo";
        protected override string Habitat { get; set; } = "Savannah";
        protected override string Diet { get; set; } = "Carnivoure";
        public override void Eat()
        {
            Console.WriteLine("The lion is eating meat.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The lion sleeps 18-20 hours a day");
        }

        public override void Move()
        {
            Console.WriteLine("The lion runs at a top speed of 80 km/h .");
        }

        public void Roar()
        {
            Console.WriteLine("The lion is ROAAARING");
        }

        public void Play()
        {
            Console.WriteLine("the lions play really rough");
        }

        public override void Nurse()
        {
            Console.WriteLine("The lion is nursing its young.");
        }
    }
    public class Tiger : Mammals
    {
        protected int EatsEvery { get; set; } = 2;
        protected string StripePattern { get; set; } = "vertical";
        protected int Territory { get; set; } = 60;
        protected override string FurColor { get; set; } = "orange";
        protected override int Gestation { get; set; } = 104;
        protected override int OffspringNum { get; set; } = 3;
        protected override string Species { get; set; } = "Panthera tigris";
        protected override string Habitat { get; set; } = "forest";
        protected override string Diet { get; set; } = "Carnivoure";
        public override void Eat()
        {
            Console.WriteLine("The tiger is eating meat.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The tiger sleeps 18-20 hours a day");
        }

        public override void Move()
        {
            Console.WriteLine("The lion runs at a top speed of 65 km/h .");
        }

        public void Roar()
        {
            Console.WriteLine("The tiger is ROAAARING");
        }

        public void Play()
        {
            Console.WriteLine("the tiger sneaks really well. LOOK BEHIND YOU!!");
        }

        public override void Groom()
        {
            Console.WriteLine("The mammal is grooming itself.");
        }
    }
    public abstract class Reptiles : Animal
    {
        protected virtual string ScaleColor { get; set; }
        protected virtual string EggType { get; set; }
        protected virtual int NumOfLegs { get; set; }

        public abstract void LayEggs();
        public abstract void Swim();
    }
    public class Crocodile : Reptiles
    {
        protected override string ScaleColor { get; set; } = "Olive green";
        protected override string EggType { get; set; } = "Hard-shelled";
        protected override int NumOfLegs { get; set; } = 4;
        protected override string Species { get; set; } = "Crocodylus niloticus";
        protected override string Habitat { get; set; } = "Freshwater";
        protected override string Diet { get; set; } = "Carnivore";

        public override void LayEggs()
        {
            Console.WriteLine("The crocodile is laying eggs.");
        }

        public override void Swim()
        {
            Console.WriteLine("The crocodile is swimming.");
        }

        public override void Eat()
        {
            Console.WriteLine("The crocodile is eating meat.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The crocodile sleeps with one eye open.");
        }

        public override void Move()
        {
            Console.WriteLine("The crocodile walks on four legs and can run up to 17 km/h on land.");
        }
    }
    public class Python : Reptiles
    {
        protected override string ScaleColor { get; set; } = "Green";
        protected override string EggType { get; set; } = "Leathery";
        protected override int NumOfLegs { get; set; } = 0;
        protected override string Species { get; set; } = "Pythonidae";
        protected override string Habitat { get; set; } = "Tropical";
        protected override string Diet { get; set; } = "Carnivore";

        public override void LayEggs()
        {
            Console.WriteLine("The python is laying eggs.");
        }

        public override void Swim()
        {
            Console.WriteLine("The python is swimming.");
        }

        public override void Eat()
        {
            Console.WriteLine("The python is eating meat.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Fun fact: Most ball pythons sleep during the day in their hide.");
        }

        public override void Move()
        {
            Console.WriteLine("The python slithers on its belly.");
        }
    }
    public abstract class Arachnida : Animal
    {
        protected virtual int NumOfLegs { get; set; }
        protected virtual string VenomType { get; set; }
        protected virtual string BodyColor { get; set; }

        public virtual void SpinWeb()
        {
            Console.WriteLine("The arachnid is spinning a web.");
        }

        public virtual void InjectVenom()
        {
            Console.WriteLine("The arachnid is injecting venom.");
        }
    }
    public class Spider : Arachnida
    {
        protected override int NumOfLegs { get; set; } = 8;
        protected override string VenomType { get; set; } = "Neurotoxic";
        protected override string BodyColor { get; set; } = "Black";
        protected override string Species { get; set; } = "Araneae";
        protected override string Habitat { get; set; } = "Cosmopolitan";
        protected override string Diet { get; set; } = "Carnivore";

        public override void SpinWeb()
        {
            Console.WriteLine("The spider is spinning a web.");
        }

        public override void InjectVenom()
        {
            Console.WriteLine("The spider is injecting venom.");
        }

        public override void Eat()
        {
            Console.WriteLine("The spider is eating an insect.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The spider sleeps during the day.");
        }

        public override void Move()
        {
            Console.WriteLine("The spider crawls on its eight legs.");
        }
    }
}