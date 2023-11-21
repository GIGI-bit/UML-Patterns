using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_homework
{
    public class FamilyHouseBuilder : IBuilder
    {
        private FamilyHouse house;
        public void buildGate()
        {}

        public void buildPool()
        {
            house.Pool = true;
        }

        public void buildWall()
        {
            house.wallCount++;
        }

        public void buildWindow()
        {
            house.windowCount++;
        }

        public void reset()
        {
            house = new FamilyHouse();
        }
        public FamilyHouse getHouse() { return  house; }
    }
}
