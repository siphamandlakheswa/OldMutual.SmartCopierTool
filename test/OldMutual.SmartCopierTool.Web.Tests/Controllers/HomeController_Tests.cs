using System.Threading.Tasks;
using OldMutual.SmartCopierTool.Models.TokenAuth;
using OldMutual.SmartCopierTool.Web.Controllers;
using Shouldly;
using Xunit;

namespace OldMutual.SmartCopierTool.Web.Tests.Controllers
{
    public class HomeController_Tests: SmartCopierToolWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}