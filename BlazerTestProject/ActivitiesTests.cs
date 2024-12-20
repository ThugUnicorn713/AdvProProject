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
using Moq;
using AdvProProject.Services;
using Microsoft.Extensions.DependencyInjection;


namespace BlazerTestProject
{
    public class ActivitiesTests : TestContext
    {
        [Fact]
        public void Search_Functions_Successfully()
        {
            var mockInterface = new Mock<IService<Activities>>();


            var activitiesList = new List<Activities>
            {
                new Activities { Id = 1, Game = "Game 1", Talk = "Talk 1", Workshop = "Workshop 1", Description = "Description 1" },
                new Activities { Id = 2, Game = "Game 2", Talk = "Talk 2", Workshop = "Workshop 2", Description = "Description 2" },
                new Activities { Id = 3, Game = "Game 3", Talk = "Talk 3", Workshop = "Workshop 3", Description = "Description 3" },
            };

            // Mock the method that gets filtered activities
            mockInterface.Setup(s => s.GetFilteredList(It.IsAny<string>())).Returns((string searchText) =>
            {
                return activitiesList.FindAll(a => a.Description.Contains(searchText));
            });

            mockInterface.Setup(s => s.GetAll()).Returns(activitiesList);

            Services.AddSingleton(mockInterface.Object);

            var renderedComponent = RenderComponent<ActivitiesList>();

            var searchInput = renderedComponent.Find("input");
            var searchButton = renderedComponent.Find("button");

            searchInput.Change("Description 1");
            searchButton.Click();

            var renderRows = renderedComponent.FindAll("tbody tr");
            Assert.Single(renderRows);

            var firstRow = renderRows[0];
            Assert.Contains("Description 1", firstRow.InnerHtml);




        }

    }
}
