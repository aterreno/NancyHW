using Nancy;
using Nancy.Testing;
using Nancy.ViewEngines.Razor;
using NancyApplication1;
using Xunit;

namespace UnitTestProject1
{    
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            // Given            
            var browser = new Browser(with => with.Module<IndexModule>());

            // When
            var response = browser.Get("/");

            // Then
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
