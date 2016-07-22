using Collection_Hierarchy.interfaces;

namespace Collection_Hierarchy.collections
{
    public class AddRemoveCollection : Collection , IAddable, IRemovable
    {
        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string element = base.Elements[Elements.Count - 1];
            base.Elements.RemoveAt(base.Elements.Count - 1);
            return element;
        }
    }
}
