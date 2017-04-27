namespace PotatoStateMachine.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPotatoEntity
    {
        string State { get; }

        int Action { get; }

        List<History> StateHistory { get; }

        List<Transition> Transations { get; }

        bool HasParent { get; }

        Task NextAsync(string action);
    }
}