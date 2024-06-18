using glitcher.core;
using Servers = glitcher.core.Servers;

namespace WebSocketServerTester
{
    /// <summary>
    /// **WebSocket Server Tester**
    /// This application is to test a simple WebSocket server class for bigger projects.
    /// </summary>
    /// <remarks>
    /// Author: Marco Fernandez (marcofdz.com / glitcher.dev)<br/>
    /// Last modified: 2024.06.18 - June 18, 2024
    /// </remarks>
    public partial class Main : Form
    {
        private glitcher.core.Servers.WebSocketServer? _wsServer = null;

        public Main()
        {
            InitializeComponent();
            _wsServer = new Servers.WebSocketServer();
        }

        private void btn_ShowLogger_Click(object sender, EventArgs e)
        {
            LogViewer.GetInstance().Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (_wsServer != null)
            {
                int.TryParse(txt_Port.Text.Trim(), out int port);
                int.TryParse(txt_MaxConnections.Text.Trim(), out int maxConnections);
                string APIKey = txt_APIKey.Text.Trim();
                bool restartOnUpdate = chk_RestartOnUpdate.Checked;
                _wsServer.Update(port, maxConnections, APIKey, restartOnUpdate);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (_wsServer != null)
            {
                _wsServer.Start();
            }

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (_wsServer != null)
            {
                _wsServer.Stop();
            }
        }

        private void btn_OpenBrowser_Click(object sender, EventArgs e)
        {
            if (_wsServer != null)
            {
                if (_wsServer.endpoints != null)
                    if (_wsServer.endpoints.Count > 0)
                        Utils.OpenWebBrowser(_wsServer.endpoints[0]);
            }
        }

        private void btn_OpenAppDir_Click(object sender, EventArgs e)
        {
            Utils.OpenAppFolder();
        }
    }
}