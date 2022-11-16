using System;
using System.Collections.Generic;

namespace TradingCompany.DTO
{
    public class UserDto
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public System.Guid Salt { get; set; }

        public DateTime RowInsertTime { get; set; }
        public List<RoleDto> Roles { get; set; }
    }
}
