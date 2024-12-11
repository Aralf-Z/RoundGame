
namespace ZToolKit
{
    public interface IFactory<out T>
    {
        T Create();
        
        T Create(string name);
    }
}