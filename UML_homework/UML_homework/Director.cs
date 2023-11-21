using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_homework
{
    public class Director
    {
        private IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder=builder;
        }
        public void ChangeBuilder(IBuilder newBuilder)
        {
            builder = newBuilder;
        }

        public void make(string type)
        {
            builder.reset();
            if(type=="Family House")
            {
                builder.buildPool();
                builder.buildWindow();
                builder.buildWall();
            }
            else
            {
                builder.buildWindow();
                builder.buildWall();
                builder.buildGate();
            }
        }

    }
}
