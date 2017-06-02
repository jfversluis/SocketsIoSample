namespace SocketsIoSample.Interfaces
{
    public interface ISocketIOClient
    {
        void Init(string address, string ns = "/");

        void DoSomething(string message);
    }
}