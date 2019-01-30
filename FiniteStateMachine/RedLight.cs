using System;
using System.Timers;

namespace FiniteStateMachine.Properties
{
    public class RedLight : State
    {
        
        public override void OnEnter(Context cur)
        {
            Console.WriteLine("The light is now RED\n");
        }

        public override void Update(Context cur)
        {
            Console.ReadLine();
            cur.ChangeState(new GreenLight());
        }

        public override void OnExit(Context cur)
        {
            Console.WriteLine("The light is now changing...\n");
        }
    }
}