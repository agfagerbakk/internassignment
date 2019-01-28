using System;

namespace internassignment
{
    public class OldShipException : Exception { }

    class Vessel
    {
        int overTwentyYears = (DateTime.Now.Year - 20);
        public readonly Speed speed;
        private string name;
        private string yearBuilt;

        public Vessel(string Name, string Year, string Speed)
        {

            if(!int.TryParse(Year, out int year)){
                throw new ArgumentException(nameof(Year));
            }  

            if(overTwentyYears > year){
                throw new OldShipException();
            } 

            if(string.IsNullOrEmpty(Name)){
                throw new ArgumentNullException(nameof(Name));
            }

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

        public override string ToString()
        {
            return $"Vessel: Vessel name: {name}, Year built: {yearBuilt}";
        }
    }


    class Ferry : Vessel
    {
        public int Passengers { get; set; }

        public Ferry(string Name, string Year, string Speed, int Passengers) : base(Name, Year, Speed) => this.Passengers = Passengers;


        public override string ToString()
        {
            return $"{base.ToString()}, Amount of passengers: {Passengers}";

        }
    }
    class Tugboat : Vessel
    {
        public int MaxForce { get; set; }

        public Tugboat(string Name, string Year, string Speed, int MaxForce) : base(Name, Year, Speed) => this.MaxForce = MaxForce;


        public override string ToString()
        {
            return $" {base.ToString()}, Vessels max force: {MaxForce}";
        }
    }

    class Submarine : Vessel
    {
        public int MaxDepth { get; set; }

        public Submarine(string Name, string Year, string Speed, int MaxDepth) : base(Name, Year, Speed) => this.MaxDepth = MaxDepth;


        public override string ToString()
        {
            return $"{base.ToString()}, Vessels max depth: {MaxDepth}";
        }
    }
}




