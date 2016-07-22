using System.Collections.Generic;

namespace Collection_Hierarchy.collections
{
    public abstract class Collection
    {
        List<string> elements = new List<string>();

        protected Collection()
        {
            this.Elements = elements;
        }

        public List<string> Elements
        {
            get
            {
                return elements;
            }

            set
            {
                elements = value;
            }
        }
    }
}
