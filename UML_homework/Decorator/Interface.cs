using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IDataSource
    {
        public void writeData(string data);
        public void readData();

    }
}
