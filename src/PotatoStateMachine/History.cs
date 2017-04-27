namespace PotatoStateMachine
{
    using System;

    public class History
    {
        public History(string state)
        {
            this.State = state;
            this.ChangeDate = DateTime.UtcNow;
        }

        public History(string state, string message)
            : this(state)
        {
            this.Message = message;
        }

        public string State { get; private set; }

        public string Message { get; private set; }

        public DateTime ChangeDate { get; private set; }
    }
}