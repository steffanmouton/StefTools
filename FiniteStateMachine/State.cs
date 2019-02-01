using System.Timers;
using System;

namespace FiniteStateMachine
{
    public abstract class State
    {
        public abstract void OnEnter(Context cur);
        public abstract void Update(Context cur);
        public abstract void OnExit(Context cur);
    }
}