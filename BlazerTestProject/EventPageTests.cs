using Bunit;
using Xunit;
using System.Diagnostics.Metrics;
using AdvProProject.Components.Pages;
using AdvProProject.Data.Models;
using AdvProProject.Services;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BlazerTestProject
{
    public class EventPageTests : TestContext
    {
        [Fact]
        public void Expected_Title_Header()
        {
            var mockInterface = new Mock<IService<Events>>();
            Services.AddSingleton(mockInterface.Object);
            
            var renderComponent = RenderComponent<EventsView>();
            
            renderComponent.Find("h3").MarkupMatches("<h3>Events View</h3>");
            Assert.Empty(renderComponent.FindAll("h1"));
        }
       
        [Fact]
        public void UserInput_Binds_Correctly()
        {
            var mockInterface = new Mock<IService<Events>>();
            Services.AddSingleton(mockInterface.Object);

            var renderComponent = RenderComponent<EventsView>();
            



            var nameInput = renderComponent.Find("#NameInput");
            var descriptInput = renderComponent.Find("#DescriptInput");
            var datetimeInput = renderComponent.Find("#DateTimeInput");

            nameInput.Change("Blazer Test Event");
            descriptInput.Change("this is where the description is!");
            datetimeInput.Change("2024-12-25T15:30");

            var events = renderComponent.Instance.events;


            Assert.Equal("Blazer Test Event", events.Name);
            Assert.Equal("this is where the description is!", events.Description);
            Assert.Equal(DateTime.Parse("2024-12-25T15:30"), events.DateTime);
        }

        
    }
}
