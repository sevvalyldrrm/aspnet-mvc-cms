using Cms.Data.Entity;

namespace Cms.WebAPI.Services.Abstract
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateToken(AppUser user);
    }
}
