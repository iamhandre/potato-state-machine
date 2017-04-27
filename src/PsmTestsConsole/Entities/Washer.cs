namespace PsmTestsConsole.Entities
{
    using Actions;
    using PotatoStateMachine;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class Washer : Entity
    {
        public Washer()
        {
            this.InitializeTransactions();
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Car> CurrentCars { get; set; }

        public async Task Execute(string action)
        {
            await base.NextAsync(action);
        }

        private void InitializeTransactions()
        {
            base.AddTransition("Wait", "Start", new WasherStart());
            base.AddTransition("Start", "Running", new WasherWait());
        }
    }
}