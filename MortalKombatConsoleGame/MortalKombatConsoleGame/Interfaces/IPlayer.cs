namespace MortalKombatConsoleGame.Interfaces
{
    public interface IPlayer
    {
        void Walk();
        void Run();
        void Jump();
        int Eat(int food);
    }
}