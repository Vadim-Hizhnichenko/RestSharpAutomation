using NUnit.Framework;
using RestSharp;
using RestSharpBasic.Enum;
using RestSharpBasic.Page;
using System;

namespace RestSharpBasic
{
    public class RequestsTest
    {
        

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [Category("Pets/Methods/Get")]
        public void FindPetsByAvailableStatus()
        {

            var pets = new PetsPage();
            var status = pets.GetStatusUrlForPets(EnumStatus.Available);
            var response = pets.GetMethodFindByStatus(status);
            Assert.AreEqual("available", response.Status);

        }

        [Test]
        [Category("Pets/Methods/Get")]
        public void FindPetsByPendingStatus()
        {
            var pets = new PetsPage();
            var status = pets.GetStatusUrlForPets(EnumStatus.Pending);
            var response = pets.GetMethodFindByStatus(status);
            Assert.AreEqual("pending", response.Status);
        }

        [Test]
        [Category("Pets/Methods/Get")]
        public void FindPetsBySoldStatus()
        {
            var pets = new PetsPage();
            var status = pets.GetStatusUrlForPets(EnumStatus.Sold);
            var response = pets.GetMethodFindByStatus(status);
            Assert.AreEqual("sold", response.Status);
        }

        [Test]
        [Category("Pets/Methods/Get")]
        public void FindPetsById()
        {
            var pets = new PetsPage();
            var result = pets.GetMethodFindById().Id;
            Assert.AreEqual(9223372016854902000, result);
        }

        [Test]
        [Category("Pets/Method/Post")]
        public void MethodPost()
        {

        }
    }
}