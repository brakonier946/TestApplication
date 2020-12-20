using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace TestApplication.Services.Storage
{
    public class StorageService : IStorageService
    {
        public T Get<T>(string key, T defaultValue = default)
        {
            var savedValue = Preferences.Get(key, string.Empty);
            if (savedValue == string.Empty)
            {
                return defaultValue;
            }

            return JsonConvert.DeserializeObject<T>(savedValue);
        }

        public void Set<T>(string key, T value)
        {
            var serializedData = value != null ? JsonConvert.SerializeObject(value) : null;
            Preferences.Set(key, serializedData);
        }

        public async Task<T> GetSecureStorageAsync<T>(string key, T defaultValue)
        {
            var savedValue = await SecureStorage.GetAsync(key);
            if (string.IsNullOrWhiteSpace(savedValue))
            {
                return defaultValue;
            }

            return JsonConvert.DeserializeObject<T>(savedValue);
        }

        public Task SetSecureStorageAsync<T>(string key, T value)
        {
            return SecureStorage.SetAsync(key, JsonConvert.SerializeObject(value));
        }
    }
}
