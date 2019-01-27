using System;

namespace internassignment
{
    public class OldShipException : Exception
    {
        public OldShipException(int year)
        : base(String.Format("The vessels year {0} is too old!", year))
        { }
    }

    public class Vessel
    {
        private readonly Speed speed;
        private string name;
        private string yearBuilt;

        public Vessel(string Name, string Year, string Speed)
        {
            name = Name;
            yearBuilt = Year;
            speed = new Speed(Speed);
        }

        public string GetName
        {
            get { return name; }
        }


        public string GetYearBuilt
        {
            get { return yearBuilt; }
        }

        internal Speed Speed => speed;

        public override string ToString()
        {
            return $"Vessel: Vessel name: {name}, Year built: {yearBuilt}";
        }


        class Ferry : Vessel
        {
            private int passengers;

            public Ferry(string Name, string Year, string Speed, int Passengers) : base(Name, Year, Speed) => this.Passengers = Passengers;

            public int Passengers { get => passengers; set => passengers = value; }

            public override string ToString()
            {
                return $"{base.ToString()} Amount of passengers: {passengers}";

            }
        }
        class Tugboat : Vessel
        {
            private int maxForce;

            public Tugboat(string Name, string Year, string Speed, int MaxForce) : base(Name, Year, Speed) { }

            public int MaxForce { get => maxForce; set => maxForce = value; }

            public override string ToString()
            {
                return $" {base.ToString()} Vessels max force: {maxForce}";
            }
        }

        class Submarine : Vessel
        {
            private int maxDepth;

            public Submarine(string Name, string Year, string Speed, int MaxDepth) : base(Name, Year, Speed) { }

            public int MaxDepth { get => maxDepth; set => maxDepth = value; }

            public override string ToString()
            {
                return $"{base.ToString()} Vessels max depth: {maxDepth}";
            }
        }

        static void Main(string[] args)
        {   

            
            // while(true){

            //     try
            //     {
            //         int currentYear = DateTime.Now.Year;

            //         //List<Vessel> vesselList = new List<Vessel>();

            //         Console.WriteLine("Enter vessel type(Ferry/Tugboat/Submarine): ");
            //         string type = Console.ReadLine();
            //         type = type.ToLower();

            //         Console.Write("Enter vessel name: ");
            //         string name = Console.ReadLine();

            //         Console.Write("Enter year built: ");
            //         string yearBuilt = Console.ReadLine();

            //         Console.Write("Enter speed of vessel in KN or MS: ");
            //         //string speed = Convert.ToInt32(Console.ReadLine());



            //     if(string.IsNullOrEmpty(name)){
            //         throw new InvalidOperationException("Name is null or blank");
            //     }

            //     if((currentYear - int.TryParse(yearBuilt)) > 20 ){
            //         throw new OldShipException(int.TryParse(yearBuilt));
            //     }   
            //         if( type == "ferry" || type == "submarine" || type == "tugboat" || type == "")
            //         {
            //             throw new ArgumentException("Wrong type entered");                    
            //         }
            //         if(type == "ferry"){

            //             Console.Write("Passengers: ");
            //             int addInfo = Convert.ToInt32(Console.ReadLine());
            //             Ferry myShip = new Ferry(name, yearBuilt, speed, addInfo);
            //             vesselList.Add(myShip);

            //         }else if(type == "submarine"){

            //             Console.Write("Submarines Max Depth: ");
            //             int addInfo = Convert.ToInt32(Console.ReadLine());
            //             Submarine mySub = new Submarine(name, yearBuilt, speed, addInfo);
            //             vesselList.Add(mySub);

            //         }else if(type == "tugboat"){

            //             Console.Write("Tugboats Max Force: ");
            //             int addInfo = Convert.ToInt32(Console.ReadLine());
            //             Tugboat myThugboat = new Tugboat(name,yearBuilt, speed, addInfo);
            //             vesselList.Add(myThugboat);

            //         }else if(type == ""){

            //             Vessel myVessel = new Vessel(name, yearBuilt, speed);
            //             vesselList.Add(myVessel);
            //         }

            //     }
            //     catch (OldShipException e)
            //     {
            //         Console.WriteLine(e.Message);
            //     }
            //     catch(InvalidOperationException e)
            //     {
            //         Console.WriteLine(e.Message);
            //     }
            //     catch(ArgumentException e)
            //     {
            //         Console.WriteLine(e.Message);    
            //     }
            // }

        }

    }

}



