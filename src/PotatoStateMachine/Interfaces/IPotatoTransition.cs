namespace PotatoStateMachine.Interfaces
{
    public interface IPotatoTransition<TObject>
    {
        string Name { get; set; }
    }
}