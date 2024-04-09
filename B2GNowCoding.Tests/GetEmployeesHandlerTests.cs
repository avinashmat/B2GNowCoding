using B2GNowCoding.Core.Employee.Handler;
using B2GNowCoding.Core.Extensions;
using B2GNowCoding.Db;
using B2GNowCoding.Db.Interface;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Security.Authentication.ExtendedProtection;

namespace B2GNowCoding.Tests
{
    [TestClass]
    public class GetEmployeesHandlerTests
    {
        [TestMethod]
        public async Task GetEmployees_ShouldReturnsAllEmployees()
        {
            //Arrange
            var service = new ServiceCollection();
            var mediator = SetupHandlerAndReturnMediator(service);
            var query = new GetEmployeesQuery();
            var mockRepository = new Mock<IGetEmployees>();
            mockRepository.Setup(repo => repo.GetAll()).Returns(new List<Employee>());
            service.AddScoped(_ => mockRepository.Object);
            //Act
            var response = await mediator.Send(query);

            //Assert
            Assert.IsNotNull(response);
        }

        private static IMediator SetupHandlerAndReturnMediator(ServiceCollection service)
        {
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(MediatorServiceCollectionExtensions).Assembly));
            var serviceProvider = service.BuildServiceProvider();
            return serviceProvider.GetRequiredService<IMediator>();

        }
    }
}