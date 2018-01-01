using MortalKombatConsoleGame.Classes;

namespace MortalKombatConsoleGame.Interfaces
{
    public interface IAttacker
    {
        void Punch(Player player);
        void Kick(Player player);
    }
}