using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_homework
{
    public class CastleBuilder:IBuilder
    {
        private Castle castle;

        public CastleBuilder()
        {
        }

        public void buildGate()
        {
            castle.Gate = true;
        }

        public void buildPool(){}

        public void buildWall()
        {
            castle.wallCount++;
        }

        public void buildWindow()
        {
            castle.windowCount++;
        }
        public Castle getResult() => castle;

        public void reset()
        {
            castle=new Castle();
        }
    }
}
