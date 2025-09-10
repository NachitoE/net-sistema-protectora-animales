using DTOs;
using Infrastructure.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.API
{
    public class UserDTOClient : BaseDTOClient<UserDTO>
    {
        protected override string _endpoint => "users";
        public UserDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient) { }
    }
}
