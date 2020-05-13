using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpIoAngular.Pages
{
    public class Index_Tests : AbpIoAngularWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
