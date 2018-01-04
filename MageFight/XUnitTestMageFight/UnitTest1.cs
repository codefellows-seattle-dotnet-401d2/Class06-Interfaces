using System;
using Xunit;
using MageFight.Classes;

namespace XUnitTestMageFight
{
    public class UnitTest1
    {
        [Fact]
        public void Test_WhiteMage()
        {
            WhiteMage whiteMage = new WhiteMage();
            WhiteMage enemy = new WhiteMage();
            enemy.CastCure();
            enemy.CastCure();
            Assert.True(whiteMage.W_Attack(enemy));
            Assert.True(whiteMage.M_Attack(2, enemy));
            Assert.True(whiteMage.M_Attack(3, enemy));
            Assert.True(whiteMage.M_Attack(4, enemy));
        }

        [Fact]
        public void Test_BlackMage()
        {
            BlackMage blackMage = new BlackMage();
            WhiteMage enemy = new WhiteMage();
            enemy.CastCure();
            enemy.CastCure();
            Assert.True(blackMage.W_Attack(enemy));
            Assert.True(blackMage.M_Attack(2, enemy));
            Assert.True(blackMage.M_Attack(3, enemy));
            Assert.True(blackMage.M_Attack(4, enemy));
        }

        [Fact]
        public void Test_RedMage()
        {
            RedMage redMage = new RedMage();
            WhiteMage enemy = new WhiteMage();
            enemy.CastCure();
            enemy.CastCure();
            Assert.True(redMage.W_Attack(enemy));
            Assert.True(redMage.M_Attack(2, enemy));
            Assert.True(redMage.M_Attack(3, enemy));
            Assert.True(redMage.M_Attack(4, enemy));
            Assert.True(redMage.M_Attack(5, enemy));
            Assert.True(redMage.M_Attack(6, enemy));
            Assert.True(redMage.M_Attack(7, enemy));
        }
    }
}
