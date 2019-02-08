using FiniteStateMachine;

namespace FSMTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Context tLight = new TrafficLight(new RedLight());
            bool Playing = true;

            while (Playing)
            {
                tLight.Update();
            }
        }
    }
}