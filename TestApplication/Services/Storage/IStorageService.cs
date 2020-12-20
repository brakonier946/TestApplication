using System.Threading.Tasks;

namespace TestApplication.Services.Storage
{
    public interface IStorageService
    {
        T Get<T>(string key, T defaultValue = default(T));

        void Set<T>(string key, T value);

        Task<T> GetSecureStorageAsync<T>(string key, T defaultValue = default(T));

        Task SetSecureStorageAsync<T>(string key, T value);
    }
}
