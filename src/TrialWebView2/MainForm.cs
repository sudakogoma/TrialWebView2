using System;
using System.Windows.Forms;

namespace TrialWebView2
{
    /// <summary>
    /// WewView2 お試し
    /// 
    /// WebView2 Runtime が必要
    /// https://docs.microsoft.com/ja-jp/microsoft-edge/webview2/concepts/distribution
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.webView.Source = new Uri("http://acid3.acidtests.org/");
        }

        private void webView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            this.webView.Visible = false;
            this.progressBar1.Visible = true;
        }

        private void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            this.progressBar1.Visible = false;
            this.webView.Visible = true;
        }
    }
}
