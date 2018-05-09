using Inspect.FireSafety.Business.OrganisationUnits;
using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.Equipment;
using Inspect.Framework.Hypermedia;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    [TestClass]
    public class OrganisationServiceTests
    {
        private Mock<IOrganisationUnitBusinessComponent> mBusinessComponentMock;

        private WebApiClient mClient;

        private IUnityContainer mContainer;

        private TestServer mTestServer;

        [TestCleanup]
        public void _Cleanup()
        {
            if (mTestServer != null)
            {
                mTestServer.Dispose();
                mTestServer = null;
            }

            mClient = null;
        }

        [TestInitialize]
        public void _Initialize()
        {
            mContainer = new UnityContainer();

            mBusinessComponentMock = new Mock<IOrganisationUnitBusinessComponent>();
            mContainer.RegisterInstance(mBusinessComponentMock.Object);

            OwinUnitTestConfiguration config = new OwinUnitTestConfiguration(mContainer);
            mTestServer = TestServer.Create(config.Configuration);
            mClient = new WebApiClient(mTestServer.HttpClient);
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitCollectionGet()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 2, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()))
                .Returns(1);

            mBusinessComponentMock.Setup(x => x.Get(It.IsAny<OrganisationUnitCollectionParametersQuery>()))
                .Returns(new List<OrganisationUnit>(new[] { organisationUnit }));

            var response = await mClient.GetEnsureAsync<CollectionRepresentation<OrganisationUnitRepresentation>>("fire-safety/organisation-units");

            mBusinessComponentMock.Verify(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()));
            mBusinessComponentMock.Verify(x => x.Get(It.IsAny<OrganisationUnitCollectionParametersQuery>()));

            Assert.AreEqual(1, response.TotalCount);
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitCollectionGet_EmbedLocation()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 2, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()))
                .Returns(1);

            mBusinessComponentMock.Setup(x => x.Get(It.IsAny<OrganisationUnitCollectionParametersQuery>()))
                .Returns(new List<OrganisationUnit>(new[] { organisationUnit }));

            var response = await mClient.GetEnsureAsync<CollectionRepresentation<OrganisationUnitRepresentation>>("fire-safety/organisation-units?embed-locations=true");

            mBusinessComponentMock.Verify(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()));
            mBusinessComponentMock.Verify(x => x.Get(It.Is<OrganisationUnitCollectionParametersQuery>(q => q.Parameters.EmbedLocations == true)));

            Assert.AreEqual(1, response.TotalCount);
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitCollectionGet_PageNumber()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 2, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()))
                .Returns(1);

            mBusinessComponentMock.Setup(x => x.Get(It.IsAny<OrganisationUnitCollectionParametersQuery>()))
                .Returns(new List<OrganisationUnit>(new[] { organisationUnit }));

            var response = await mClient.GetEnsureAsync<CollectionRepresentation<OrganisationUnitRepresentation>>("fire-safety/organisation-units?page-number=2");

            mBusinessComponentMock.Verify(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()));
            mBusinessComponentMock.Verify(x => x.Get(It.Is<OrganisationUnitCollectionParametersQuery>(q => q.Parameters.PageNumber == 2)));

            Assert.AreEqual(1, response.TotalCount);
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitCollectionGet_PageSize()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 2, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()))
                .Returns(1);

            mBusinessComponentMock.Setup(x => x.Get(It.IsAny<OrganisationUnitCollectionParametersQuery>()))
                .Returns(new List<OrganisationUnit>(new[] { organisationUnit }));

            var response = await mClient.GetEnsureAsync<CollectionRepresentation<OrganisationUnitRepresentation>>("fire-safety/organisation-units?page-size=2");

            mBusinessComponentMock.Verify(x => x.Count(It.IsAny<OrganisationUnitCollectionParametersSpecification>()));
            mBusinessComponentMock.Verify(x => x.Get(It.Is<OrganisationUnitCollectionParametersQuery>(q => q.Parameters.PageSize == 2)));

            Assert.AreEqual(1, response.TotalCount);
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitCollectionOptions()
        {
            var response = await mClient.OptionsEnsureAsync("fire-safety/organisation-units");

            Assert.IsTrue(response.Links.ContainsRelation("parameters"));
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitGetById_Existing()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 1, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.SingleOrDefault(It.IsAny<OrganisationUnitParametersQuery>()))
                .Returns(organisationUnit);

            var response = await mClient.GetEnsureAsync<OrganisationUnitRepresentation>("fire-safety/organisation-units/1");

            mBusinessComponentMock.Verify(x => x.SingleOrDefault(It.Is<OrganisationUnitParametersQuery>(q => q.OrganisationUnitId == 1)));
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitGetById_Existing_EmbedLocations()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 2, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.SingleOrDefault(It.IsAny<OrganisationUnitParametersQuery>()))
                .Returns(organisationUnit);

            var response = await mClient.GetEnsureAsync<OrganisationUnitRepresentation>("fire-safety/organisation-units/1?embed-locations=true");

            mBusinessComponentMock.Verify(x => x.SingleOrDefault(It.Is<OrganisationUnitParametersQuery>(q => q.OrganisationUnitId == 1 && q.Parameters.EmbedLocations == true)));
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [ExpectedException(typeof(WebApiException))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitGetById_Not_Existing()
        {
            mBusinessComponentMock.Setup(x => x.SingleOrDefault(It.IsAny<OrganisationUnitParametersQuery>()))
                .Returns(default(OrganisationUnit));

            var response = await mClient.GetEnsureAsync<OrganisationUnitRepresentation>("fire-safety/organisation-units/1");
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitOptionsById_Existing()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 2, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.SingleOrDefault<OrganisationUnit>(It.IsAny<OrganisationUnitIdSpecification>()))
                .Returns(organisationUnit);

            var response = await mClient.OptionsEnsureAsync("fire-safety/organisation-units/2");

            Assert.IsTrue(response.Links.ContainsRelation(HypermediaLinks.Locations));
        }

        [TestCategory("UnitTests"), TestCategory(nameof(FireSafety)), TestCategory(nameof(WebApi))]
        [ExpectedException(typeof(WebApiException))]
        [TestMethod]
        public async Task OrganisationUnitService_OrganisationUnitOptionsById_NotExisting()
        {
            var organisationUnit = new OrganisationUnit() { OrganisationUnitId = 2, Name = "Name" };

            mBusinessComponentMock.Setup(x => x.SingleOrDefault<OrganisationUnit>(It.IsAny<OrganisationUnitIdSpecification>()))
                .Returns(default(OrganisationUnit));

            var response = await mClient.OptionsEnsureAsync("fire-safety/organisation-units/2");
            Assert.Fail();
        }
    }
}