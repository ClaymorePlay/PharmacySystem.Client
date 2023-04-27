using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsModels.Enums;

namespace WsModels.WsResponse
{
    public class GetCurrentUserResponse
    {
        public string Email { get; set; }

        public long UserId { get; set; }

        public string UserName { get; set; }

        public RoleEnum Role { get; set; }
    }
}
