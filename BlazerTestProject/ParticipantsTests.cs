using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class ParticipantsTests : TestContext
    {
        [Fact]
        public void UserInput_Binds_Successfully()
        {
            var mockInterface = new Mock<IService<Participants>>();
            Services.AddSingleton(mockInterface.Object);

            var renderComponent = RenderComponent<ParticipantsView>();

            var nameInput = renderComponent.Find("#NameInput");
            var emailInput = renderComponent.Find("#EmailInput");
           

            nameInput.Change("Test Person");
            emailInput.Change("test@mail.com");


            var participants = renderComponent.Instance.participants;


            Assert.Equal("Test Person", participants.Name);
            Assert.Equal("test@mail.com", participants.Email);
        }
    }
}
