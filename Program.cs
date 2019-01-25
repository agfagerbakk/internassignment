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
        private string name;
        private string yearBuilt;

        public Vessel(string Name, string Year)
        {
            Name = name;
            Year = yearBuilt;
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
            return $"Vessel : {name}, {yearBuilt}";
        }


        class Ferry : Vessel{
            private int passengers;

            public Ferry(string Name, string Year, int Passengers) : base(Name, Year) => this.Passengers = Passengers;

            public int Passengers { get => passengers; set => passengers = value; }

            public override string ToString(){
                return $"Vessel : {name}, {yearBuilt}, {passengers}";

            }
        }
        class Tugboat : Vessel{
            private int maxForce;

            public Tugboat(string Name, string Year) : base(Name, Year)
            {
            }

            public int MaxForce { get => maxForce; set => maxForce = value; }

            public override string ToString(){
                return $"Vessel : {name}, {yearBuilt}, {maxForce}";

            }
        }

        class Submarine : Vessel{
            private int maxDepth;

            public Submarine(string Name, string Year) : base(Name, Year)
            {
            }

            public int MaxDepth { get => maxDepth; set => maxDepth = value; }
            
            public override string ToString(){
                return $"Vessel : {name}, {yearBuilt}, {maxDepth}";

            }
        }

        void GetVesselInfo(string vessel){
            ToString();
        }

    static void Main(string[] args)
    {
        while(true){
            try
            {
                int currentYear = DateTime.Now.Year;
                
                Console.Write("Enter vessel name: ");
                string name = Console.ReadLine();
                Console.Write("Enter year built: ");
                string yearBuilt = Console.ReadLine();
                Console.Write("Additional info: ");
                int addInfo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(name + yearBuilt + addInfo + currentYear);
                    
            if(string.IsNullOrEmpty(name)){
                throw new InvalidOperationException("Name is null or blank");
            }

            if((currentYear - int.Parse(yearBuilt)) > 20 ){
                throw new OldShipException(int.Parse(yearBuilt));
            }
                Vessel myShip = new Ferry(name, yearBuilt, addInfo);
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
     

