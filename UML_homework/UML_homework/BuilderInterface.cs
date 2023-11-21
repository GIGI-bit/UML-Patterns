using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_homework
{
    public interface IBuilder
    {
        public void reset();
        public void buildWall();
        public void buildWindow();
        public void buildGate();
        public void buildPool();
    }
}
