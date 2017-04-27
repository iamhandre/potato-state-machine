using PotatoStateMachine.Interfaces;

namespace PotatoStateMachine
{
    public sealed class Transition
    {
        public Transition(string startState, string endState, IPotatoAction action, bool triggerContinue = false)
        {
            StartState = startState;
            Action = action;
            EndState = endState;
            Continue = triggerContinue;
        }

        // Os estados podem evoluir para objectos
        public string StartState { get; private set; }

        public string EndState { get; private set; }

        public IPotatoAction Action { get; private set; }

        public string Name
        {
            get
            {
                return this.Action.GetType().Name;
            }
        }

        // to set this transiction a caller of the parent
        public bool Continue { get; private set; }
    }
}