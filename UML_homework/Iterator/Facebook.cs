using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Facebook : SocialNetwork
    {
        public IProfileIterator CreateCoworkersIterator(string profileId)
        {
            return new FacebookIterator();
        }

        public IProfileIterator createFriendsIterator(int profileId)
        {
            return new FacebookIterator();
        }
    }
}
