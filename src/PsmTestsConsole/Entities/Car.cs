namespace PsmTestsConsole.Entities
{
    using PotatoStateMachine;

    public class Car : Entity
    {
        public Car()
        {
        }

        public string Brand { get; set; }

        public int Cost { get; set; }

        public bool FullClean { get; set; }
    }
}