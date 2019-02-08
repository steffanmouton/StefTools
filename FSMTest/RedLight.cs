using System;
using System.Timers;

namespace FiniteStateMachine
{
    public class RedLight : State
    {
        public override void OnEnter(Context cur)
        {
            Console.WriteLine("The light is now RED\n");
        }

        public override void Update(Context cur)
        {
            //condition : User presses Enter
            Console.ReadLine();
            
            //transition
            cur.ChangeState(new GreenLight());
        }

        public override void OnExit(Context cur)
        {
            Console.WriteLine("The light is now changing...\n");
        }
    }
}