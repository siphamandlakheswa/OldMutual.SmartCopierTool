using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using OldMutual.SmartCopierTool.Authorization.Users;

namespace OldMutual.SmartCopierTool.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
