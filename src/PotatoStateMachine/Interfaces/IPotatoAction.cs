namespace PotatoStateMachine.Interfaces
{
    using System.Threading.Tasks;

    public interface IPotatoAction
    {
        Task ExecuteAsync();
    }
}