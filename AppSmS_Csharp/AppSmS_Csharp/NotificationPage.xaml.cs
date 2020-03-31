using AppSmS_Csharp.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace AppSmS_Csharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();


            ListItemSourceNotification.ItemsSource = new List<NotificationData> {
            new NotificationData{ ImageSource="Person", MsgNew="Le nouveau message est", OldMsg="L'ancien est alomsg"},
            new NotificationData{ ImageSource="ProtectHomm", MsgNew="Le nouveau message est", OldMsg="L'ancien est alomsg"},
            new NotificationData{ ImageSource="Smmurai", MsgNew="Le nouveau message est", OldMsg="L'ancien est alomsg"},
            new NotificationData{ ImageSource="ClotcheMan", MsgNew="Le nouveau message est", OldMsg="L'ancien est alomsg"}
             };

        }
    }
}