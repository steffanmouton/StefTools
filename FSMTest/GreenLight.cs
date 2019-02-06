using System;
using System.Timers;

namespace FiniteStateMachine
{
    public class GreenLight : State
    {
        public override void OnEnter(Context cur)
        {
            Console.WriteLine("The light is now GREEN\n");
        }
        public override void Update(Context cur)
        {
            Console.ReadLine();
            cur.ChangeState(new YellowLight());
        }
        public override void OnExit(Context cur)
        {
            Console.WriteLine("The light is now changing...\n");
        }
    }
}