using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.API.DTOs_CRUDs
{
    public class MedicalCheckUpDTOClient : BaseDTOClient<MedicalCheckUpDTO>
    {
        protected override string _endpoint => "medical-checkups";
        public MedicalCheckUpDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
        public async Task<ApiResult<MedicalCheckUpDTO>> PostAsync(MedicalCheckUpRegisterDTO data)
        {
            var res = await _apiHttpClient.PostAsync<MedicalCheckUpDTO>($"{_endpoint}", data);
            return res;
        }
    }
}
