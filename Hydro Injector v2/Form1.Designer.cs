namespace Hydro_Injector_v2
{
    partial class Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.pbxDragBar = new System.Windows.Forms.PictureBox();
            this.pbxUsernameGrad = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbxTitleImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbxInjectGrad = new System.Windows.Forms.PictureBox();
            this.btnInject = new System.Windows.Forms.Button();
            this.ChbRemember = new System.Windows.Forms.CheckBox();
            this.lblLoaderVersion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnKeybinds = new System.Windows.Forms.Button();
            this.btnJoinDiscord = new System.Windows.Forms.Button();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.ChkTester = new System.Windows.Forms.CheckBox();
            this.TimerCheckAccount = new System.Windows.Forms.Timer(this.components);
            this.injection_worker_thread = new System.ComponentModel.BackgroundWorker();
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.ShutdownTimer = new System.Windows.Forms.Timer(this.components);
            this.txtError = new System.Windows.Forms.Label();
            this.update_error_message = new System.Windows.Forms.Timer(this.components);
            this.tester_updater = new System.Windows.Forms.Timer(this.components);
            this.testPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pbxLoadingGif = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.animationCheck = new System.Windows.Forms.Timer(this.components);
            this.pnlInjectSuccess = new System.Windows.Forms.Panel();
            this.lblLoaderClosing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EndscreenTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pbxLoadingAnim1 = new System.Windows.Forms.PictureBox();
            this.pbxLoadingAnim2 = new System.Windows.Forms.PictureBox();
            this.LoadingBarAnimTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDragBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsernameGrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInjectGrad)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingGif)).BeginInit();
            this.pnlInjectSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingAnim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingAnim2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDragBar
            // 
            this.pbxDragBar.BackColor = System.Drawing.Color.Transparent;
            this.pbxDragBar.ErrorImage = null;
            this.pbxDragBar.InitialImage = null;
            this.pbxDragBar.Location = new System.Drawing.Point(0, 0);
            this.pbxDragBar.Name = "pbxDragBar";
            this.pbxDragBar.Size = new System.Drawing.Size(450, 25);
            this.pbxDragBar.TabIndex = 12;
            this.pbxDragBar.TabStop = false;
            this.pbxDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxDragBar_MouseDown);
            // 
            // pbxUsernameGrad
            // 
            this.pbxUsernameGrad.BackColor = System.Drawing.Color.Aqua;
            this.pbxUsernameGrad.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsernameGrad.Image")));
            this.pbxUsernameGrad.Location = new System.Drawing.Point(16, 111);
            this.pbxUsernameGrad.Name = "pbxUsernameGrad";
            this.pbxUsernameGrad.Size = new System.Drawing.Size(200, 2);
            this.pbxUsernameGrad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsernameGrad.TabIndex = 15;
            this.pbxUsernameGrad.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(16, 93);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 15);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Enter username here";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(16, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 19);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pbxTitleImage
            // 
            this.pbxTitleImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbxTitleImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxTitleImage.BackgroundImage")));
            this.pbxTitleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxTitleImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbxTitleImage.Location = new System.Drawing.Point(0, 7);
            this.pbxTitleImage.Name = "pbxTitleImage";
            this.pbxTitleImage.Size = new System.Drawing.Size(111, 56);
            this.pbxTitleImage.TabIndex = 20;
            this.pbxTitleImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 19);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 2);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(16, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 15);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Enter password here";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pbxInjectGrad
            // 
            this.pbxInjectGrad.BackColor = System.Drawing.Color.Aqua;
            this.pbxInjectGrad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxInjectGrad.BackgroundImage")));
            this.pbxInjectGrad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxInjectGrad.Location = new System.Drawing.Point(291, 214);
            this.pbxInjectGrad.Name = "pbxInjectGrad";
            this.pbxInjectGrad.Size = new System.Drawing.Size(125, 2);
            this.pbxInjectGrad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInjectGrad.TabIndex = 25;
            this.pbxInjectGrad.TabStop = false;
            this.pbxInjectGrad.Click += new System.EventHandler(this.pbxInjectGrad_Click);
            // 
            // btnInject
            // 
            this.btnInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInject.FlatAppearance.BorderSize = 0;
            this.btnInject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInject.Location = new System.Drawing.Point(291, 176);
            this.btnInject.Margin = new System.Windows.Forms.Padding(0);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(125, 40);
            this.btnInject.TabIndex = 0;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = false;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // ChbRemember
            // 
            this.ChbRemember.AutoSize = true;
            this.ChbRemember.BackColor = System.Drawing.Color.Transparent;
            this.ChbRemember.Checked = true;
            this.ChbRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbRemember.ForeColor = System.Drawing.Color.Gainsboro;
            this.ChbRemember.Location = new System.Drawing.Point(16, 175);
            this.ChbRemember.Name = "ChbRemember";
            this.ChbRemember.Size = new System.Drawing.Size(95, 17);
            this.ChbRemember.TabIndex = 3;
            this.ChbRemember.Text = "Remember Me";
            this.ChbRemember.UseVisualStyleBackColor = false;
            // 
            // lblLoaderVersion
            // 
            this.lblLoaderVersion.AutoSize = true;
            this.lblLoaderVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaderVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaderVersion.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoaderVersion.Location = new System.Drawing.Point(14, 198);
            this.lblLoaderVersion.Name = "lblLoaderVersion";
            this.lblLoaderVersion.Size = new System.Drawing.Size(67, 9);
            this.lblLoaderVersion.TabIndex = 28;
            this.lblLoaderVersion.Text = "Hydrogen Loader: ";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.LightGray;
            this.lblVersion.Location = new System.Drawing.Point(14, 208);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 9);
            this.lblVersion.TabIndex = 27;
            this.lblVersion.Text = "Hydrogen Menu:";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Location = new System.Drawing.Point(350, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 25);
            this.btnMinimize.TabIndex = 29;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(387, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 25);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackgroundImage = global::Hydro_Injector_v2.Properties.Resources.Gear;
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Location = new System.Drawing.Point(398, 31);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(20, 20);
            this.btnOptions.TabIndex = 31;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseEnter += new System.EventHandler(this.btnOptions_MouseEnter);
            this.btnOptions.MouseLeave += new System.EventHandler(this.btnOptions_MouseLeave);
            this.btnOptions.MouseHover += new System.EventHandler(this.btnOptions_MouseHover);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.btnKeybinds);
            this.pnlOptions.Controls.Add(this.btnJoinDiscord);
            this.pnlOptions.Controls.Add(this.btnOpenLog);
            this.pnlOptions.Controls.Add(this.ChkTester);
            this.pnlOptions.Location = new System.Drawing.Point(234, 57);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(184, 103);
            this.pnlOptions.TabIndex = 32;
            this.pnlOptions.Visible = false;
            this.pnlOptions.Leave += new System.EventHandler(this.pnlOptions_Leave);
            // 
            // btnKeybinds
            // 
            this.btnKeybinds.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnKeybinds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeybinds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKeybinds.Location = new System.Drawing.Point(15, 6);
            this.btnKeybinds.Name = "btnKeybinds";
            this.btnKeybinds.Size = new System.Drawing.Size(153, 23);
            this.btnKeybinds.TabIndex = 25;
            this.btnKeybinds.Text = "Edit Keybinds";
            this.btnKeybinds.UseVisualStyleBackColor = true;
            this.btnKeybinds.Visible = false;
            this.btnKeybinds.Click += new System.EventHandler(this.btnKeybinds_Click);
            // 
            // btnJoinDiscord
            // 
            this.btnJoinDiscord.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnJoinDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinDiscord.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJoinDiscord.Location = new System.Drawing.Point(15, 64);
            this.btnJoinDiscord.Name = "btnJoinDiscord";
            this.btnJoinDiscord.Size = new System.Drawing.Size(75, 23);
            this.btnJoinDiscord.TabIndex = 24;
            this.btnJoinDiscord.Text = "Join Discord";
            this.btnJoinDiscord.UseVisualStyleBackColor = true;
            this.btnJoinDiscord.Click += new System.EventHandler(this.btnJoinDiscord_Click);
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpenLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenLog.Location = new System.Drawing.Point(15, 35);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLog.TabIndex = 23;
            this.btnOpenLog.Text = "Open Log";
            this.btnOpenLog.UseVisualStyleBackColor = true;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // ChkTester
            // 
            this.ChkTester.AutoSize = true;
            this.ChkTester.BackColor = System.Drawing.Color.Transparent;
            this.ChkTester.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChkTester.Location = new System.Drawing.Point(117, 79);
            this.ChkTester.Name = "ChkTester";
            this.ChkTester.Size = new System.Drawing.Size(62, 17);
            this.ChkTester.TabIndex = 21;
            this.ChkTester.Text = "Tester?";
            this.ChkTester.UseVisualStyleBackColor = false;
            this.ChkTester.Visible = false;
            // 
            // TimerCheckAccount
            // 
            this.TimerCheckAccount.Enabled = true;
            this.TimerCheckAccount.Interval = 1000;
            this.TimerCheckAccount.Tick += new System.EventHandler(this.TimerCheckAccount_Tick_1);
            // 
            // MessageTimer
            // 
            this.MessageTimer.Enabled = true;
            this.MessageTimer.Interval = 500;
            this.MessageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // ShutdownTimer
            // 
            this.ShutdownTimer.Interval = 1000;
            this.ShutdownTimer.Tick += new System.EventHandler(this.ShutdownTimer_Tick);
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(232, 158);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(68, 15);
            this.txtError.TabIndex = 33;
            this.txtError.Text = "Error Label";
            // 
            // update_error_message
            // 
            this.update_error_message.Enabled = true;
            this.update_error_message.Interval = 5;
            this.update_error_message.Tick += new System.EventHandler(this.update_error_message_Tick_1);
            // 
            // tester_updater
            // 
            this.tester_updater.Enabled = true;
            this.tester_updater.Interval = 500;
            this.tester_updater.Tick += new System.EventHandler(this.tester_updater_Tick);
            // 
            // testPanel
            // 
            this.testPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.testPanel.Controls.Add(this.pictureBox5);
            this.testPanel.Controls.Add(this.lblLoading);
            this.testPanel.Controls.Add(this.pbxLoadingGif);
            this.testPanel.Location = new System.Drawing.Point(476, 0);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(425, 225);
            this.testPanel.TabIndex = 34;
            this.testPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.testPanel_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(156, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoading.Location = new System.Drawing.Point(161, 177);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(101, 25);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading..";
            // 
            // pbxLoadingGif
            // 
            this.pbxLoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoadingGif.Image")));
            this.pbxLoadingGif.Location = new System.Drawing.Point(196, 137);
            this.pbxLoadingGif.Name = "pbxLoadingGif";
            this.pbxLoadingGif.Size = new System.Drawing.Size(32, 32);
            this.pbxLoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLoadingGif.TabIndex = 0;
            this.pbxLoadingGif.TabStop = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // animationCheck
            // 
            this.animationCheck.Enabled = true;
            this.animationCheck.Interval = 200;
            this.animationCheck.Tick += new System.EventHandler(this.animationCheck_Tick);
            // 
            // pnlInjectSuccess
            // 
            this.pnlInjectSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlInjectSuccess.Controls.Add(this.lblLoaderClosing);
            this.pnlInjectSuccess.Controls.Add(this.label2);
            this.pnlInjectSuccess.Controls.Add(this.pictureBox3);
            this.pnlInjectSuccess.Location = new System.Drawing.Point(12, 232);
            this.pnlInjectSuccess.Name = "pnlInjectSuccess";
            this.pnlInjectSuccess.Size = new System.Drawing.Size(425, 225);
            this.pnlInjectSuccess.TabIndex = 35;
            // 
            // lblLoaderClosing
            // 
            this.lblLoaderClosing.AutoSize = true;
            this.lblLoaderClosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaderClosing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoaderClosing.Location = new System.Drawing.Point(145, 178);
            this.lblLoaderClosing.Name = "lblLoaderClosing";
            this.lblLoaderClosing.Size = new System.Drawing.Size(134, 16);
            this.lblLoaderClosing.TabIndex = 5;
            this.lblLoaderClosing.Text = "Loader will close in: 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(122, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Injection Successful!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(156, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // EndscreenTimer
            // 
            this.EndscreenTimer.Interval = 1;
            this.EndscreenTimer.Tick += new System.EventHandler(this.EndscreenTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(349, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Options:";
            // 
            // pbxLoadingAnim1
            // 
            this.pbxLoadingAnim1.BackColor = System.Drawing.Color.Aqua;
            this.pbxLoadingAnim1.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoadingAnim1.Image")));
            this.pbxLoadingAnim1.Location = new System.Drawing.Point(-1, 226);
            this.pbxLoadingAnim1.Name = "pbxLoadingAnim1";
            this.pbxLoadingAnim1.Size = new System.Drawing.Size(440, 3);
            this.pbxLoadingAnim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLoadingAnim1.TabIndex = 37;
            this.pbxLoadingAnim1.TabStop = false;
            // 
            // pbxLoadingAnim2
            // 
            this.pbxLoadingAnim2.BackColor = System.Drawing.Color.Aqua;
            this.pbxLoadingAnim2.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoadingAnim2.Image")));
            this.pbxLoadingAnim2.Location = new System.Drawing.Point(-1, 232);
            this.pbxLoadingAnim2.Name = "pbxLoadingAnim2";
            this.pbxLoadingAnim2.Size = new System.Drawing.Size(440, 3);
            this.pbxLoadingAnim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLoadingAnim2.TabIndex = 38;
            this.pbxLoadingAnim2.TabStop = false;
            // 
            // LoadingBarAnimTimer
            // 
            this.LoadingBarAnimTimer.Interval = 1;
            this.LoadingBarAnimTimer.Tick += new System.EventHandler(this.LoadingBarAnimTimer_Tick);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(425, 225);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pbxLoadingAnim2);
            this.Controls.Add(this.pbxLoadingAnim1);
            this.Controls.Add(this.pnlInjectSuccess);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.pbxTitleImage);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblLoaderVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.ChbRemember);
            this.Controls.Add(this.pbxInjectGrad);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pbxUsernameGrad);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbxDragBar);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydro Loader";
            this.Load += new System.EventHandler(this.Loader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDragBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsernameGrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInjectGrad)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.testPanel.ResumeLayout(false);
            this.testPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingGif)).EndInit();
            this.pnlInjectSuccess.ResumeLayout(false);
            this.pnlInjectSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingAnim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingAnim2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDragBar;
        private System.Windows.Forms.PictureBox pbxUsernameGrad;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbxTitleImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbxInjectGrad;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.CheckBox ChbRemember;
        private System.Windows.Forms.Label lblLoaderVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.CheckBox ChkTester;
        private System.Windows.Forms.Timer TimerCheckAccount;
        private System.ComponentModel.BackgroundWorker injection_worker_thread;
        private System.Windows.Forms.Timer MessageTimer;
        private System.Windows.Forms.Timer ShutdownTimer;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Timer update_error_message;
        private System.Windows.Forms.Timer tester_updater;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.PictureBox pbxLoadingGif;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer animationCheck;
        private System.Windows.Forms.Panel pnlInjectSuccess;
        private System.Windows.Forms.Label lblLoaderClosing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer EndscreenTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenLog;
        private System.Windows.Forms.PictureBox pbxLoadingAnim1;
        private System.Windows.Forms.PictureBox pbxLoadingAnim2;
        private System.Windows.Forms.Timer LoadingBarAnimTimer;
        private System.Windows.Forms.Button btnJoinDiscord;
        private System.Windows.Forms.Button btnKeybinds;
    }
}

