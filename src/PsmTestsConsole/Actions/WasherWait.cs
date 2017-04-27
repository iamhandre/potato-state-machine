namespace PsmTestsConsole.Actions
{
    using PotatoStateMachine.Interfaces;
    using System;
    using System.Threading.Tasks;

    public class WasherWait : IPotatoAction
    {
        public async Task ExecuteAsync()
        {
            Console.WriteLine("WasherWait");
        }
    }
}