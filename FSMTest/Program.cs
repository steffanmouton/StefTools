using FiniteStateMachine;

namespace FSMTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Game = new TrafficLight(new RedLight());
            bool Playing = true;

            while (Playing)
            {
                Game.Update();
            }
        }
    }
}