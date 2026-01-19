namespace AV.EssentialState.Runtime
{
    public interface IEssentialState<in TEvent>
    {
        public void Start();
        public void DispatchEvent(TEvent eventId);
    }
}