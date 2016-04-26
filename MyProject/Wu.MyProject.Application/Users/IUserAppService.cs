using System.Threading.Tasks;
using Abp.Application.Services;
using Wu.MyProject.Users.Dto;

namespace Wu.MyProject.Users
{
    public interface IUserAppService : IApplicationService
    {
        System.Threading.Tasks.Task ProhibitPermission(ProhibitPermissionInput input);

        System.Threading.Tasks.Task RemoveFromRole(long userId, string roleName);
    }
}