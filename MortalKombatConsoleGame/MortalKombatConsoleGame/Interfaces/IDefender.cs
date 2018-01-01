namespace MortalKombatConsoleGame.Interfaces
{
    public interface IDefender
    {
        bool TakeCover();
        void Hurt(int attackType);
    }
}