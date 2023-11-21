using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DataSourceDecorator:IDataSource
    {
        private IDataSource wrappee;

        public DataSourceDecorator(IDataSource source)
        {
            wrappee = source;
        }

        public void readData()
        {
            
        }

        public void writeData(string data)
        {  
        }
    }
}
