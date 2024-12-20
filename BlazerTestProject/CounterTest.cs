using Bunit;
using Xunit;
using System.Diagnostics.Metrics;
using AdvProProject.Components.Pages;

namespace BlazerTestProject
{
    public class CounterTest : TestContext
    {
        [Fact]
        public void Counter_Should_Count_Up()
        {
            var renderedComponent = RenderComponent<Counter>();

            renderedComponent.Find("button").Click();

            renderedComponent.Find("p").MarkupMatches("<p role=\"status\">Current count: 1 </p>");
        }
    }
}