using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UserRegisterResponseDTO : BaseResponse
    {
        public string? UserId { get; set; }
        public string? UserType { get; set; }
    }
}
