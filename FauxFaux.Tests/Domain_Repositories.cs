using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FauxFaux.Domain;
using FauxFaux.Domain.Repositories;

namespace FauxFaux.Tests
{
    [TestClass]
    public class Domain_Repositories
    {
        [TestMethod]
        public void Characteristics()
        {
            var repo = new Models(isMock:true);

            var query = repo.First(r => r.Name == "Seamus, The Mad Hatter");

            Assert.IsNotNull(query);

            var weapons = new Weapons(isMock: true);
        }
    }
}
