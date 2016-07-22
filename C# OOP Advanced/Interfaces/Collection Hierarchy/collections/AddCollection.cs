using Collection_Hierarchy.interfaces;

namespace Collection_Hierarchy.collections
{
    public class AddCollection : Collection, IAddable
    {
        public int Add(string item)
        {
            Elements.Add(item);
            return base.Elements.Count - 1;
        }
    }
}
