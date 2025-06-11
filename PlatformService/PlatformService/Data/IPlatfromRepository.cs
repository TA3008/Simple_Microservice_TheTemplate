using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatfromRepository
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatfroms();
        Platform GetPlatfromById(int id);
        void CreatePlatform(Platform plat);
    }
}
