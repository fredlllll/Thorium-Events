namespace Thorium.Events
{
    public interface IEventQueueProvider
    {
        IEventQueue GetQueue(string name);
    }
}
