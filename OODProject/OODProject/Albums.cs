using System.Collections.Generic;

namespace OODProject
{
    class Albums : Songs
    {
        public List<Albums> albums { get; set; }

        public Albums(string album)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
