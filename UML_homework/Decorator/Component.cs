using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FileDataSource:IDataSource
    {
        private string fileName;
        public FileDataSource(string filename)
        {
            this.fileName = filename;
        }

        public void readData()
        {
            
        }

        public void writeData(string data)
        {
        }
    }
}
