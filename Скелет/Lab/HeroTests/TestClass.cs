using NUnit.Framework;
using Skeleton.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Skeleton;
using System.Text;
using System.Threading.Tasks;
using Skeleton.entities;

namespace HeroTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void HeroGainsExperinceAfterAttacksIfTargetDies()
        {
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeweapon = new FakeWeapon();

            Hero hero = new Hero("pesho", fakeweapon);

            hero.Attack(fakeTarget);

            Assert.AreEqual(20, hero.Experience, "Hero doesnt gain experience after attack if target dies");
        }
    }
}
