using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Caching.Tests")]
namespace zozo.Infrastructure.Caching
{
    public interface IConverter<T>
    {
        string Serialize(object obj);

        T Deserialize(string value);
    }
}