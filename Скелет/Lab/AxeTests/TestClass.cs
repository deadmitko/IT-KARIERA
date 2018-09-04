using NUnit.Framework;
using Skeleton.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(1, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }

        [Test]
        public void BrokenAxCantAttack()
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            //act
            axe.Attack(dummy);
            axe.Attack(dummy);

            //assert

            Assert.AreEqual(1, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }
    }
}
