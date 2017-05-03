namespace InteratorPattern
{
    public interface IIterator
    {
        object Next();
        bool HasNext();
        object Current();
    }
}
