using PlatformService.Models;

namespace PlatformService.Data
{
  interface IPlatformRepo
  {
    bool SaveChanges();
    IEnumerable<Platform> GetAllPlatforms();
    Platform GetPlatformById(int id);
    void CreatePlatform(Platform platform);
  }
}