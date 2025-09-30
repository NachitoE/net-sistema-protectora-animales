using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UserLoginResponseDTO : BaseResponse
    {
        public string? Token { get; set; }
        public UserDTO? User { get; set; }
    }
}
