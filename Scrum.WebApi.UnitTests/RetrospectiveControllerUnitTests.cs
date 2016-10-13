using System;
using NUnit.Framework;
using Moq;
using Scrum.WebApi;
using Scrum.WebApi.Controllers;
using Scrum.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Scrum.WebApi.UnitTests
{
    [TestFixture]
    public class RetrospectiveControllerUnitTests
    {
        #region Fields

        private Mock<Scrum.WebApi.Models.IRetrospectiveRepository> _fakeRetrospectiveRepository;
        private RetrospectivesController _controller;
        
        #endregion

        #region SetUp and TearDown

        [SetUp]
        public void Setup()
        {
            _fakeRetrospectiveRepository = new Mock<Models.IRetrospectiveRepository>();
            _controller = new RetrospectivesController(_fakeRetrospectiveRepository.Object);
        }

        [TearDown]
        public void TearDown()
        {
        }
        #endregion

        #region Tests
        
        [Test]
        public void Get_return_all_retrospectives()
        {
            // Arrange
            var retrospective = new Retrospective("dsfd", "dfdfdfd", DateTime.Now);
            
            var expected = new List<Retrospective>
            {
                retrospective
                , new Retrospective("wewefff", "dfdfdfdhhhh", DateTime.Now)
                , new Retrospective("ere", "fff", DateTime.Now)
                , new Retrospective("ttt", "ffdd", DateTime.Now)
            };

            _fakeRetrospectiveRepository.Setup(x => x.GetAll()).Returns(expected);
            
            // Act
            IEnumerable<Retrospective> actual = _controller.Get();

            // Assert
            bool hasThisValue = actual.Contains(retrospective);
            Assert.IsTrue(hasThisValue);
        }

        #endregion
    }
}
