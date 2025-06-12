using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepository
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatfroms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}
