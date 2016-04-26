using System.Threading.Tasks;
using Abp.Authorization;
using Wu.MyProject.Users.Dto;

namespace Wu.MyProject.Users
{
    /* THIS IS JUST A SAMPLE. */
    public class UserAppService : MyProjectAppServiceBase, IUserAppService
    {
        private readonly UserManager _userManager;
        private readonly IPermissionManager _permissionManager;

        public UserAppService(UserManager userManager, IPermissionManager permissionManager)
        {
            _userManager = userManager;
            _permissionManager = permissionManager;
        }

        public async System.Threading.Tasks.Task ProhibitPermission(ProhibitPermissionInput input)
        {
            var user = await _userManager.GetUserByIdAsync(input.UserId);
            var permission = _permissionManager.GetPermission(input.PermissionName);

            await _userManager.ProhibitPermissionAsync(user, permission);
        }

        //Example for primitive method parameters.
        public async System.Threading.Tasks.Task RemoveFromRole(long userId, string roleName)
        {
            CheckErrors(await _userManager.RemoveFromRoleAsync(userId, roleName));
        }
    }
}