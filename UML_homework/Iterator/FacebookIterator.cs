using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class FacebookIterator : IProfileIterator
    {
        private Facebook facebook;
        private string profileId;
        private string currentPosition;
        private List<Profile> prifile;
        private void lazyInit() { }
        public Profile getNext()
        {
            throw new NotImplementedException();
        }

        public bool hasMore()
        {
            throw new NotImplementedException();
        }
    
    public FacebookIterator(Facebook facebook)
        {

        }
    
    }
}
