namespace Collection_Hierarchy.interfaces
{
    interface ICountable : IAddable, IRemovable
    {
        int Used { get; }
    }
}
