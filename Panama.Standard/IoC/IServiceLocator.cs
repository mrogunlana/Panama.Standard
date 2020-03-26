namespace Panama.Standard.IoC
{
    public interface IServiceLocator
    {
        T Resolve<T>();
        T Resolve<T>(string name);
    }
}
