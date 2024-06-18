namespace WebSocketServerTester
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ShowLogger = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_Port = new TextBox();
            txt_MaxConnections = new TextBox();
            btn_OpenBrowser = new Button();
            btn_Update = new Button();
            btn_Start = new Button();
            btn_Stop = new Button();
            chk_RestartOnUpdate = new CheckBox();
            btn_OpenAppDir = new Button();
            txt_APIKey = new TextBox();
            lbl_APIKey = new Label();
            SuspendLayout();
            // 
            // btn_ShowLogger
            // 
            btn_ShowLogger.Location = new Point(412, 9);
            btn_ShowLogger.Margin = new Padding(3, 2, 3, 2);
            btn_ShowLogger.Name = "btn_ShowLogger";
            btn_ShowLogger.Size = new Size(132, 38);
            btn_ShowLogger.TabIndex = 0;
            btn_ShowLogger.Text = "Show Logger";
            btn_ShowLogger.UseVisualStyleBackColor = true;
            btn_ShowLogger.Click += btn_ShowLogger_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 14);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 47);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Max Connections";
            // 
            // txt_Port
            // 
            txt_Port.Location = new Point(132, 12);
            txt_Port.Margin = new Padding(3, 2, 3, 2);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(178, 23);
            txt_Port.TabIndex = 5;
            txt_Port.Text = "8080";
            // 
            // txt_MaxConnections
            // 
            txt_MaxConnections.Location = new Point(132, 39);
            txt_MaxConnections.Margin = new Padding(3, 2, 3, 2);
            txt_MaxConnections.Name = "txt_MaxConnections";
            txt_MaxConnections.Size = new Size(178, 23);
            txt_MaxConnections.TabIndex = 7;
            txt_MaxConnections.Text = "10";
            // 
            // btn_OpenBrowser
            // 
            btn_OpenBrowser.Location = new Point(412, 52);
            btn_OpenBrowser.Margin = new Padding(3, 2, 3, 2);
            btn_OpenBrowser.Name = "btn_OpenBrowser";
            btn_OpenBrowser.Size = new Size(132, 38);
            btn_OpenBrowser.TabIndex = 12;
            btn_OpenBrowser.Text = "Open Browser";
            btn_OpenBrowser.UseVisualStyleBackColor = true;
            btn_OpenBrowser.Click += btn_OpenBrowser_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(20, 158);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(132, 38);
            btn_Update.TabIndex = 13;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(158, 158);
            btn_Start.Margin = new Padding(3, 2, 3, 2);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(132, 38);
            btn_Start.TabIndex = 14;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Location = new Point(295, 158);
            btn_Stop.Margin = new Padding(3, 2, 3, 2);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(132, 38);
            btn_Stop.TabIndex = 15;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // chk_RestartOnUpdate
            // 
            chk_RestartOnUpdate.AutoSize = true;
            chk_RestartOnUpdate.Checked = true;
            chk_RestartOnUpdate.CheckState = CheckState.Checked;
            chk_RestartOnUpdate.Location = new Point(132, 94);
            chk_RestartOnUpdate.Margin = new Padding(3, 2, 3, 2);
            chk_RestartOnUpdate.Name = "chk_RestartOnUpdate";
            chk_RestartOnUpdate.Size = new Size(120, 19);
            chk_RestartOnUpdate.TabIndex = 16;
            chk_RestartOnUpdate.Text = "Restart on Update";
            chk_RestartOnUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_OpenAppDir
            // 
            btn_OpenAppDir.Location = new Point(412, 94);
            btn_OpenAppDir.Margin = new Padding(3, 2, 3, 2);
            btn_OpenAppDir.Name = "btn_OpenAppDir";
            btn_OpenAppDir.Size = new Size(132, 38);
            btn_OpenAppDir.TabIndex = 17;
            btn_OpenAppDir.Text = "Open App Directory";
            btn_OpenAppDir.UseVisualStyleBackColor = true;
            btn_OpenAppDir.Click += btn_OpenAppDir_Click;
            // 
            // txt_APIKey
            // 
            txt_APIKey.Location = new Point(132, 67);
            txt_APIKey.Margin = new Padding(3, 2, 3, 2);
            txt_APIKey.Name = "txt_APIKey";
            txt_APIKey.Size = new Size(178, 23);
            txt_APIKey.TabIndex = 18;
            // 
            // lbl_APIKey
            // 
            lbl_APIKey.AutoSize = true;
            lbl_APIKey.Location = new Point(78, 70);
            lbl_APIKey.Name = "lbl_APIKey";
            lbl_APIKey.Size = new Size(47, 15);
            lbl_APIKey.TabIndex = 19;
            lbl_APIKey.Text = "API Key";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 241);
            Controls.Add(lbl_APIKey);
            Controls.Add(txt_APIKey);
            Controls.Add(btn_OpenAppDir);
            Controls.Add(chk_RestartOnUpdate);
            Controls.Add(btn_Stop);
            Controls.Add(btn_Start);
            Controls.Add(btn_Update);
            Controls.Add(btn_OpenBrowser);
            Controls.Add(txt_MaxConnections);
            Controls.Add(txt_Port);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ShowLogger);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "WebSocket Server Tester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ShowLogger;
        private Label label1;
        private Label label2;
        private TextBox txt_Port;
        private TextBox txt_MaxConnections;
        private Button btn_OpenBrowser;
        private Button btn_Update;
        private Button btn_Start;
        private Button btn_Stop;
        private CheckBox chk_RestartOnUpdate;
        private Button btn_OpenAppDir;
        private TextBox txt_APIKey;
        private Label lbl_APIKey;
    }
}