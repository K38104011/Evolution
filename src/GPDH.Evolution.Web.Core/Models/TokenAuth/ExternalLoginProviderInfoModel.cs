using Abp.AutoMapper;
using GPDH.Evolution.Authentication.External;

namespace GPDH.Evolution.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
