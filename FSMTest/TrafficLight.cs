using System.Runtime.CompilerServices;

namespace FiniteStateMachine
{
    public class TrafficLight : Context
    {
        public TrafficLight(State start)
        {
            Current = start;
        }
        public override void Update()
        {
            Current.Update(this);
        }
        public override void ChangeState(State s)
        {
            Current.OnExit(this);
            Current = s;
            Current.OnEnter(this);
        }
        public override void OnExit()
        {
            
        }
        public override void OnEnter()
        {
            
        }
    }
}