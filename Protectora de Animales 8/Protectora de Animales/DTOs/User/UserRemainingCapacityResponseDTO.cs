using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.User
{
    public class UserRemainingCapacityResponseDTO : BaseResponse
    {
        public UserDTO User { get; set; }
        public int RemainingCapacity { get; set; }
    }
}
