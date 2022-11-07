using System.Collections.Generic;
using TradingCompany.DTO;

namespace DAL.Interfaces
{
    public interface IRoleDal
    {
        List<RoleDto> GetAllRoles();
        RoleDto CreateRole(RoleDto role);
        RoleDto GetRoleById(int id);
        RoleDto GetRoleByName(string role);
        void UpdateRole(RoleDto role);
        void DeleteRole(int id);
    }
}
