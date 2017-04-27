namespace PotatoStateMachine
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public abstract class Entity : IPotatoEntity
    {
        public string State { get; private set; }

        public int Action { get; private set; }

        public DateTime ChangeDate { get; private set; }

        public List<History> StateHistory { get; private set; }

        public List<Transition> Transations { get; private set; }

        public bool HasParent { get; private set; }

        public async Task NextAsync(string action)
        {
            // TODO => passar a usar o nome na transaction e não na
            var currentTransition = this.Transations.FirstOrDefault(t => t.Name == action);
            if (currentTransition != null)
            {
                await currentTransition.Action.ExecuteAsync();
            }

            AddState(currentTransition.StartState);
            this.State = currentTransition.EndState;
        }

        public bool AddTransition(string startState, string endState, IPotatoAction action)
        {
            if (this.Transations == null)
            {
                this.Transations = new List<Transition>();
            }

            // TODO => falta validar os repetidos
            this.Transations.Add(new Transition(startState, endState, action));

            return true;
        }

        private void AddState(string state)
        {
            if (this.StateHistory == null)
            {
                this.StateHistory = new List<History>();
            }

            StateHistory.Add(new History(state));
        }
    }
}