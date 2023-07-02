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
        public abstract string Eat();
        public abstract string Sleep();
        public abstract string Move();

    }
    public abstract class Mammals : Animal
    {
        protected abstract int OffspringNum { get; set; }
        protected abstract string FurColor { get; set; }
        protected abstract int Gestation { get; set; }
        public virtual string Nurse()
        {
            return ("The mammal is nursing its young.");
        }

        public virtual string Groom()
        {
            return ("The mammal is grooming itself.");
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
        public override string Eat()
        {
            return ("The lion is eating meat.");
        }

        public override string Sleep()
        {
            return ("The lion sleeps 18-20 hours a day");
        }

        public override string Move()
        {
            return ("The lion runs at a top speed of 80 km/h .");
        }

        public string Roar()
        {
            return ("The lion is ROAAARING");
        }

        public string Play()
        {
            return ("the lions play really rough");
        }

        public override string Nurse()
        {
            return ("The lion is nursing its young.");
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
        public override string Eat()
        {
            return ("The tiger is eating meat.");
        }

        public override string Sleep()
        {
            return ("The tiger sleeps 18-20 hours a day");
        }

        public override string Move()
        {
            return ("The lion runs at a top speed of 65 km/h .");
        }

        public string Roar()
        {
            return ("The tiger is ROAAARING");
        }

        public string Play()
        {
            return ("the tiger sneaks really well. LOOK BEHIND YOU!!");
        }

        public override string Groom()
        {
            return ("The mammal is grooming itself.");
        }
    }
    public abstract class Reptiles : Animal
    {
        protected virtual string ScaleColor { get; set; }
        protected virtual string EggType { get; set; }
        protected virtual int NumOfLegs { get; set; }

        public abstract string LayEggs();
        public abstract string Swim();
    }
    public class Crocodile : Reptiles
    {
        protected override string ScaleColor { get; set; } = "Olive green";
        protected override string EggType { get; set; } = "Hard-shelled";
        protected override int NumOfLegs { get; set; } = 4;
        protected override string Species { get; set; } = "Crocodylus niloticus";
        protected override string Habitat { get; set; } = "Freshwater";
        protected override string Diet { get; set; } = "Carnivore";

        public override string LayEggs()
        {
            return ("The crocodile is laying eggs.");
        }

        public override string Swim()
        {
            return ("The crocodile is swimming.");
        }

        public override string Eat()
        {
            return ("The crocodile is eating meat.");
        }

        public override string Sleep()
        {
            return ("The crocodile sleeps with one eye open.");
        }

        public override string Move()
        {
            return ("The crocodile walks on four legs and can run up to 17 km/h on land.");
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

        public override string LayEggs()
        {
            return ("The python is laying eggs.");
        }

        public override string Swim()
        {
            return ("The python is swimming.");
        }

        public override string Eat()
        {
            return ("The python is eating meat.");
        }

        public override string Sleep()
        {
            return ("Fun fact: Most ball pythons sleep during the day in their hide.");
        }

        public override string Move()
        {
            return ("The python slithers on its belly.");
        }
    }
    public abstract class Arachnida : Animal
    {
        protected virtual int NumOfLegs { get; set; }
        protected virtual string VenomType { get; set; }
        protected virtual string BodyColor { get; set; }

        public virtual string SpinWeb()
        {
            return ("The arachnid is spinning a web.");
        }

        public virtual string InjectVenom()
        {
            return ("The arachnid is injecting venom.");
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

        public override string SpinWeb()
        {
            return ("The spider is spinning a web.");
        }

        public override string InjectVenom()
        {
            return ("The spider is injecting venom.");
        }

        public override string Eat()
        {
            return ("The spider is eating an insect.");
        }

        public override string Sleep()
        {
            return ("The spider sleeps during the day.");
        }

        public override string Move()
        {
            return ("The spider crawls on its eight legs.");
        }
    }
}