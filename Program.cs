using System;


namespace internassignment
{
    public class OldShipException : Exception
    {
        public OldShipException(int year)
        : base(String.Format("The vessels year {0} is too old!", year))
        {

        }
    }

    public class Vessel
    {
        private int speed;
        private string name;
        
        private string yearBuilt;

        public Vessel(string Name, string Year, int Speed)
        {
            Console.WriteLine("im in vessel class\n");
            name = Name;
            yearBuilt = Year;
            speed = Speed;
            //addInfo = AddInfo;
        }

        public int GetSpeed
        {
            get{ return speed; }
            set{ speed = value; }
        }

        public string GetName
        {
            get { return name; }
            set{ name = value; }
        }

        public string GetYearBuilt
        {
            get { return yearBuilt; }
            set{ yearBuilt = value; }
        }

        public override string ToString()
        {
            return $"Vessel : Name of vessel: {name}, Year built: {yearBuilt}, Vessel speed: {speed}";
        }


        class Ferry : Vessel{
            private int passengers;

            public Ferry(string Name, string Year, int Speed, int Passengers) : base(Name, Year, Speed) => this.Passengers = Passengers;

            public int Passengers { get => passengers; set => passengers = value; }

            public override string ToString(){
                return $"Vessel : Name of vessel: {name}, Year built: {yearBuilt}, Vessel speed: {speed}, Amount of passengers: {passengers}";

            }
        }
        class Tugboat : Vessel{
            private int maxForce;

            public Tugboat(string Name, string Year, int Speed, int MaxForce) : base(Name, Year, Speed)
            {
            }

            public int MaxForce { get => maxForce; set => maxForce = value; }

            public override string ToString(){
                return $"Vessel : Name of vessel: {name}, Year built: {yearBuilt}, Vessel speed: {speed}, Vessels max force: {maxForce}";
            }
        }

        class Submarine : Vessel{
            private int maxDepth;

            public Submarine(string Name, string Year, int Speed, int MaxDepth ) : base(Name, Year, Speed)
            {
            }

            public int MaxDepth { get => maxDepth; set => maxDepth = value; }
            
            public override string ToString(){
                return $"Vessel : Name of vessel: {name}, Year built: {yearBuilt}, Vessel speed: {speed}, Vessels max depth: {maxDepth}";
            }
        }

        class Speed : IFormattable
        {
            public string ToString(string format, IFormatProvider formatProvider)
            {
                throw new NotImplementedException();
            }
        }

        void GetVesselInfo(){
            ToString();
        }

    static void Main(string[] args)
    {
        while(true){

            try
            {
                int currentYear = DateTime.Now.Year;

                Console.WriteLine("Enter vessel type: ");
                string type = Console.ReadLine();
                //TextInfo titleType = new typeInfo ToTitleCase(type);
                Console.WriteLine(type);
                Console.Write("Enter vessel name: ");
                string name = Console.ReadLine();
                
                Console.Write("Enter year built: ");
                string yearBuilt = Console.ReadLine();
                
                Console.Write("Enter speed of vessel in KN or MS: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                
                
                
            if(string.IsNullOrEmpty(name)){
                throw new InvalidOperationException("Name is null or blank");
            }

            if((currentYear - int.Parse(yearBuilt)) > 20 ){
                throw new OldShipException(int.Parse(yearBuilt));
            }
                if(type == "Ferry"){
                    Console.Write("Passengers: ");
                    int addInfo = Convert.ToInt32(Console.ReadLine());
                    Ferry myShip = new Ferry(name, yearBuilt, speed, addInfo);
                }else if(type == "Submarine"){
                    Console.Write("Submarines Max Depth: ");
                    int addInfo = Convert.ToInt32(Console.ReadLine());
                    Submarine mySub = new Submarine(name, yearBuilt, speed, addInfo);
                }else if(type == "Tugboat"){
                    Console.Write("Tugboats Max Force: ");
                    int addInfo = Convert.ToInt32(Console.ReadLine());
                    Tugboat myThugboat = new Tugboat(name,yearBuilt, speed, addInfo);
                    
                }else if(type == ""){
                    Vessel myVessel = new Vessel(name, yearBuilt, speed);
                }else if(type == "Info"){
                    Console.WriteLine("lotsa info");
                    //GetVesselInfo();
                }

                Console.WriteLine("Im running");
                //string info = myShip.ToString();
                //Console.WriteLine(info);
            }
            catch (OldShipException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        }

    }

}

     

