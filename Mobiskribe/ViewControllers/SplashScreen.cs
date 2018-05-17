using System;
using System.Threading.Tasks;
using Foundation;
using Mobiskribe.Utils;
using Mobiskribe.Views;
using UIKit;

namespace Mobiskribe.ViewControllers
{
    public partial class SplashScreen : UIViewController
    {
        public SplashScreen() : base("SplashScreen", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            StartTimer();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public async void StartTimer()
        {
            await Task.Delay(3000);
            UIStoryboard board = UIStoryboard.FromName(Constants.StoryBoardFile.LOGIN_VIEW, NSBundle.MainBundle);
            LoginViewController loginView = board.InstantiateViewController(Constants.StoryBoardID.LOGINVIEWCONTROLLER) as LoginViewController;
            PresentViewController(loginView, true,null);
        }
    }
}

