using MvvmCross;
using TestApplication.Services.Storage;

namespace TestApplication.Managers
{
    public class BaseManager
    {
        protected readonly IStorageService _storageService;

        public BaseManager()
        {
            _storageService = Mvx.IoCProvider.Resolve<IStorageService>();
        }

        protected void SaveData<T>(string key, T data)
        {
            _storageService.Set(key, data);
        }

        protected T GetData<T>(string key)
        {
            return _storageService.Get<T>(key);
        }
    }
}
