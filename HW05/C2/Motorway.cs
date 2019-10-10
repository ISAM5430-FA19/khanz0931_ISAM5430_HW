using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Motorway
    {
        public string Name, TypeOfRoad, Direction, SurfaceType, TollOrNoToll, Party;
        public int NumOfLanes { get; set; }

        public Motorway()
        {
            Name = "Holly Hall Street";
            TypeOfRoad = "Street";
            Direction = "West/East";
            SurfaceType = "Concrete";
            TollOrNoToll = "Not Toll";
            Party = "Harris County";
            NumOfLanes = 4;
        }


        public override string ToString() 
        {
            return "Name: " + Name + "\nType: " + TypeOfRoad + "\nDirection: " + Direction + "\nSurface Type: " + SurfaceType + "\nToll or No Toll: " + TollOrNoToll 
                + "\nParty: " + Party +  "\nNumber of Lanes: " + NumOfLanes;
        }

        public string NameAndToll()
        {
            return "Name: " + Name + "\nToll or No Toll: " + TollOrNoToll;
        }

        public string NameAndLane()
        {
            return "Name: " + Name + "\nNumber of Lanes: " + NumOfLanes;
        }
    }
}
