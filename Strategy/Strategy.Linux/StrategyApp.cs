using SiliconStudio.Xenko.Engine;

namespace Strategy
{
    class StrategyApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
