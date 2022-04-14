using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_VP_Touch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // ToDo:
        // Implement ImageScalingSize - Scale all icons (use only hi res icons and scale them down like this)

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            //this.FormBorderStyle = FormBorderStyle.None;  // this will not allow border and resizing - maybe useful in a full screen application
            System.Uri uri = new System.Uri(Properties.Settings.Default.Address1);
            //System.Uri uri = new System.Uri("http://192.168.1.59/");
            webView1.Source = uri;

            toolStripTextBoxAddress.Text = Properties.Settings.Default.Address1;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState.Equals (FormWindowState.Normal))
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void toolStripButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            if (webView1 == null)
            {
                MessageBox.Show("Error: WebView1 is null");
                return;
            }
            if (webView1.CoreWebView2 == null)
            {
                MessageBox.Show("Error: webView1.CoreWebView2 is null");
                return;
            }

            try
            {
                webView1.CoreWebView2.Navigate(toolStripTextBoxAddress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the Web page: " + ex.ToString());
            }

        }
    }
}
