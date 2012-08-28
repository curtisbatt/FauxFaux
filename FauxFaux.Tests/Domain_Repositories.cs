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
        public void Test1()
        {
            var modelName = "Seamus, The Mad Hatter";
            var weaponName = "Bag O'Tools";
            var weaponNewName = "Bag O'Tools Modified";

            var ctx = new Context(isMock: true);

            var model = ctx.Models.First(m => m.Name == modelName);
            Assert.IsNotNull(model);
            Assert.AreEqual(weaponName, model.Weapons[0].Name);

            var weapon = ctx.Weapons.First(w => w.Name == weaponName);
            Assert.IsNotNull(weapon);

            weapon.Name = weaponNewName;
            Assert.AreEqual(weaponNewName, model.Weapons[0].Name);
        }
    }
}
