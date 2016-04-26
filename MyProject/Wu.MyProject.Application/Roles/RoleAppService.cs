﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Wu.MyProject.Authorization.Roles;
using Wu.MyProject.Roles.Dto;

namespace Wu.MyProject.Roles
{
    /* THIS IS JUST A SAMPLE. */
    public class RoleAppService : MyProjectAppServiceBase,IRoleAppService
    {
        private readonly RoleManager _roleManager;
        private readonly IPermissionManager _permissionManager;

        public RoleAppService(RoleManager roleManager, IPermissionManager permissionManager)
        {
            _roleManager = roleManager;
            _permissionManager = permissionManager;
        }

        public async System.Threading.Tasks.Task UpdateRolePermissions(UpdateRolePermissionsInput input)
        {
            var role = await _roleManager.GetRoleByIdAsync(input.RoleId);
            var grantedPermissions = _permissionManager
                .GetAllPermissions()
                .Where(p => input.GrantedPermissionNames.Contains(p.Name))
                .ToList();

            await _roleManager.SetGrantedPermissionsAsync(role, grantedPermissions);
        }
    }
}