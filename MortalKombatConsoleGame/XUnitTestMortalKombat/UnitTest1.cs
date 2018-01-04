using System;
using System.Collections.Generic;
using MortalKombatConsoleGame.Classes;
using Xunit;

namespace XUnitTestMortalKombat
{
    public class UnitTest1
    {
        // Arrange
        public static IEnumerable<object[]> GetPlayers()
        {
            yield return new object[] { 40, new PlayerOne("Subzero", 10), new PlayerTwo("Sonya") };
            yield return new object[] { 42, new PlayerOne("Sindel", 8), new PlayerTwo("Kitana") };
        }

        [Theory]
        [MemberData(nameof(GetPlayers))]
        public void PlayerTwo_Health_Decrease_When_Kicked(int expectedHealth, PlayerOne pOne, PlayerTwo pTwo)
        {
            // Act
            pOne.Kick(pTwo);
            int resultAfterKick = pTwo.Health;
            pOne.Punch(pTwo);
            int resultAfterPunch = resultAfterKick - pOne.DamagePerAttack / 2;

            // Assert
            Assert.Equal(expectedHealth, resultAfterKick);
            Assert.True(resultAfterPunch < resultAfterKick);
        }
    }
}
