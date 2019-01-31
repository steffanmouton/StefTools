namespace FiniteStateMachine
{
    public class TrafficLight : Context
    {
        State Current = new GreenLight();
        public override void Update()
        {
            Current.Update(this);
        }
        public override void ChangeState(State s)
        {
            OnExit();
            Current = s;
            OnEnter();
        }
        public override void OnExit()
        {
            Current.OnExit(this);
        }
        public override void OnEnter()
        {
            Current.OnEnter(this);
        }
    }
}