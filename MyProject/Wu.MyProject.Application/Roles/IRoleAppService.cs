using System.Threading.Tasks;
using Abp.Application.Services;
using Wu.MyProject.Roles.Dto;


namespace Wu.MyProject.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        System.Threading.Tasks.Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
