using System;
using SocketsIoSample.Interfaces;
using Xamarin.Forms;

namespace SocketsIoSample
{
    public partial class SocketsIoSamplePage : ContentPage
    {
        private readonly ISocketIOClient _socketClient;

        public SocketsIoSamplePage()
        {
            InitializeComponent();

            _socketClient = DependencyService.Get<ISocketIOClient>();

            if (_socketClient == null)
                throw new Exception("Something went wrong, forgot to register dependency?");

            _socketClient.Init("http://myclient.com");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _socketClient.DoSomething("Ping!");
        }
    }
}