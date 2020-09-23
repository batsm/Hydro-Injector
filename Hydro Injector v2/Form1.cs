using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Principal;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Hydro_Injector_v2
{
    public partial class Loader : Form
    {
        // Hydrogen Loader Info
        string loader_version = "6.5";
        string newDllLocation = "";
        bool tester = false;
        bool username_changed = false;
        string Username;
        string Password;
        bool loadingError = false;
        bool injectSuccess = false;

        // For animations
        Panel selectedPanel;
        Form selectedForum;
        bool animateInBool;
        int width;
        int height;
        int stepSize = 25;
        int loadingMessageStep = 0;
        int shutdownTime = 5;

        // Error
        string error_message = "";
        System.Drawing.Color colour = System.Drawing.Color.Red;

        // HTTPS Info
        string domain = "https://www.domain.co.uk/";

        //Stores the mod version it'll inject
        string hydrogen_version = "";
        string hydrogen_loader_version = "";

        // Dll Info
        string DllLocation;
        string DllName = "Test.Test2";

        bool IsAdmin;
        bool IsLoginValid = false;

        string log_file = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        string hydro_log_file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        // Threads
        System.Threading.Thread auto_update_thread;
        System.Threading.Thread auth_thread;
        System.Threading.Thread injection_thread;

        //Draggable Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            // Should help smooth out animations
            DoubleBuffered = true;

            //Create Auto Update Thread
            //auto_update_thread = new System.Threading.Thread(new System.Threading.ThreadStart(auto_update_thread_func));
            //auto_update_thread.Start();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string exe_directory_file = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string exe_directory_folder = Path.GetDirectoryName(exe_directory_file);

            // Create Directories
            string dll_location = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            dll_location += "\\HydrogenDL";
            Directory.CreateDirectory(dll_location);
            string folder_directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            folder_directory += "\\Hydrogen";
            Directory.CreateDirectory(folder_directory);

            // Clear Old Dll's
            System.IO.DirectoryInfo di = new DirectoryInfo(dll_location);
            foreach (FileInfo file in di.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch
                {
                    MessageBox.Show("Menu already injected");
                    this.Close();
                }
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            //Read Username and Password from the save file 
            string remember_me_location = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            remember_me_location += "\\Hydrogen\\RememberMeDetails.txt";

            //Read Save File - Username, Password and Mod Type 
            if (File.Exists(remember_me_location))
            {
                int line_count = 0;
                string current_line_string;

                StreamReader file = new StreamReader(remember_me_location);
                while ((current_line_string = file.ReadLine()) != null)
                {
                    if (line_count == 0)
                        if (current_line_string != "")
                            txtUsername.Text = current_line_string;
                    if (line_count == 1)
                        if (current_line_string != "")
                            txtPassword.Text = current_line_string;
                    line_count++;
                }
                file.Close();

                txtPassword.PasswordChar = '*';
                ChbRemember.Checked = true;
            }

            //Show link for discord server when server when down
            string Hydro_Down_Notice_Location = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            Hydro_Down_Notice_Location += "\\Hydrogen\\HydroDiscord.dat";

            if (!File.Exists((Hydro_Down_Notice_Location)))
            {
                //HydroDownForm DownForm = new HydroDownForm();
                //DownForm.Show();
            }

            // Get Version
            //WebClient client = new WebClient();
            //hydrogen_version = client.DownloadString(domain + "Authentication/Detection/CheckVersion.php?Type=2");
            //lblVersion.Text = "Hydrogen Menu " + hydrogen_version;
            //lblLoaderVersion.Text = lblLoaderVersion.Text + loader_version;
        }

        private void auto_update_thread_func()
        {
            try
            {
                // Get Newest Hydrogen Version
                string hydrogen_newest_version;
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    client.UseDefaultCredentials = true;
                    client.Credentials = new NetworkCredential("Username", "Password");
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                    client.Headers.Add("Cache-Control", "no-cache");

                    hydrogen_newest_version = client.UploadString(new Uri(domain + "hydro_auth/auth.php"), "POST", data: "get_loader_version=1");
                    if (hydrogen_newest_version == loader_version)
                        return;
                }

                // Get Current Directory
                string exe_directory_file = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string exe_directory_folder = Path.GetDirectoryName(exe_directory_file);

                // Delete Old Loader
                if (File.Exists(exe_directory_folder + "/" + (Convert.ToDouble(loader_version) - 0.1f).ToString() + ".exe"))
                {
                    File.Delete(exe_directory_folder + "/" + (Convert.ToDouble(loader_version) - 0.1f).ToString() + ".exe");
                }

                // Update Loader
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(domain + "Loader/" + hydrogen_newest_version + ".exe"), fileName: exe_directory_folder + "/" + hydrogen_newest_version + ".exe");
                }

                // Run The Newly Downloaded Loader
                if (File.Exists(exe_directory_folder + "/" + hydrogen_newest_version + ".exe"))
                {
                    Process.Start(exe_directory_folder + "/" + hydrogen_newest_version + ".exe");
                }
            }
            catch
            {
                // Exit
                Application.Exit();
                MessageBox.Show("Unable to auto update injector, please download the newest version from our website");
                System.Diagnostics.Process.Start("https://www.urlHere.co.uk/");
                Application.Exit();
            }
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            pnlOptions.Hide();

            // Clientsided Validation
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                txtError.Text = "Please enter a Username or Password!";
                loadingError = true;
                return;
            }

            Username = txtUsername.Text;
            Password = txtPassword.Text;

            //Show loading screen
            animateIn(testPanel, this);
            ShowLoadingBar();

            //Create Auth Thread
            auth_thread = new System.Threading.Thread(new System.Threading.ThreadStart(auth_thread_func));
            auth_thread.Start();

        }

        private void auth_thread_func()
        {
            System.Threading.Thread.Sleep(250);
            // Validate Account
            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("Username", "Password");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                client.Headers.Add("Cache-Control", "no-cache");

                string hydrogen_auth_result = client.UploadString(new Uri(domain + "hydro_auth/auth.php"), "POST", data: "username=" + txtUsername.Text + "&password=" + txtPassword.Text + "&hwid=yeet&tester=" + (tester ? "1" : "0") + "& version=500&hwid_needed=1");
                if (hydrogen_auth_result != "Successful")
                {
                    if (hydrogen_auth_result == "ID:Public Version is down for updates!" || hydrogen_auth_result == "ID:Tester Version is down for updates!")
                    {
                        colour = System.Drawing.Color.Orange;
                        error_message = "Menu is down for updates.";
                        loadingError = true;
                        //MenuDown MenuDownForm = new MenuDown(this.Top, this.Left);
                        //MenuDownForm.Show();
                        return;
                    }
                    colour = System.Drawing.Color.Red;
                    error_message = "Invalid Username or Password!";
                    loadingError = true;
                    return;
                }
                colour = System.Drawing.Color.LimeGreen;
                error_message = "Successfully Logged In!";
            }

            //Look for the GTA Process 
            Process[] pname = Process.GetProcessesByName("GTA5");
            if (pname.Length == 0)
            {
                colour = System.Drawing.Color.Red;
                error_message = "GTA 5 Is Not Open";
                loadingError = true;
                return;
            }

            using (WebClient client = new WebClient())
            {
                string texture_location = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                texture_location += "\\HydrogenDL\\test_texture.ytd";
                client.DownloadFile(domain + "Authentication/Downloads/test_texture.ytd", texture_location);
                while (!File.Exists(texture_location))
                {
                    System.Threading.Thread.Sleep(50);
                }
            }

            // Download Hydrogen DLL
            string DllLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            DllLocation += "\\Hydrogen\\Hydrogen.vat";
            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("Username", "Password");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                client.Headers.Add("Cache-Control", "no-cache");

                string hydrogen_newest_version = client.UploadString(new Uri(domain + "hydro_auth/auth.php"), data: "get_mod_version=1");
                if (tester && ChkTester.Checked)
                    client.DownloadFile(new Uri(domain + "Authentication/Downloads/a" + hydrogen_newest_version + ".vat"), fileName: DllLocation);
                else
                {
                    client.DownloadFile(new Uri(domain + "Authentication/Downloads/" + hydrogen_newest_version + ".vat"), fileName: DllLocation);
                }
            }

            // Generate File Name
            string dll_start = get_random_string(8);
            string dll_end = get_random_string(3);

            DllName = dll_start + "." + dll_end;

            // Rename File
            newDllLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            newDllLocation += "\\HydrogenDL\\" + DllName;
            File.Move(DllLocation, newDllLocation);
            MessageBox.Show("Error downloading hydrogen");
            loadingError = true;

            // Create Injection Thread
            injection_thread = new System.Threading.Thread(new System.Threading.ThreadStart(injection_thread_func));
            injection_thread.Start();
        }

        // Injection stuffs
        [DllImport("kernel32")]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, UIntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, Int32 dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern UIntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, string lpBuffer, UIntPtr nSize, out IntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("kernel32", SetLastError = true, ExactSpelling = true)]
        internal static extern Int32 WaitForSingleObject(IntPtr handle, Int32 milliseconds);


        //Get Process ID
        public Int32 GetProcessId(String proc)
        {
            Process[] ProcList;
            ProcList = Process.GetProcessesByName(proc);
            return ProcList[0].Id;
        }

        //Injection
        public bool InjectDLL(IntPtr hProcess, String strDLLName)
        {

            Int32 LenWrite = strDLLName.Length + 1;
            IntPtr AllocMem = VirtualAllocEx(hProcess, (IntPtr)null, (uint)LenWrite, 0x1000, 0x40);
            WriteProcessMemory(hProcess, AllocMem, strDLLName, (UIntPtr)LenWrite, out IntPtr bytesout);
            UIntPtr Injector = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            IntPtr hThread = CreateRemoteThread(hProcess, (IntPtr)null, 0, Injector, AllocMem, 0, out bytesout);
            if (hThread == null)
                return false;

            int Result = WaitForSingleObject(hThread, 10 * 1000);
#pragma warning disable CS0652 // Comparison to integral constant is useless; the constant is outside the range of the type
            if (Result == 0x00000080L || Result == 0x00000102L || Result == 0xFFFFFFFF)
#pragma warning restore CS0652 // Comparison to integral constant is useless; the constant is outside the range of the type
            {
                if (hThread != null)
                    CloseHandle(hThread);
                return false;
            }

            System.Threading.Thread.Sleep(1000);
            VirtualFreeEx(hProcess, AllocMem, (UIntPtr)0, 0x8000);

            if (hThread != null)
                CloseHandle(hThread);
            MessageBox.Show("Error with injecting DLL");
            return true;
        }

        public void injection_thread_func()
        {
            //creating information files
            string RememberLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            RememberLocation += "\\Hydrogen\\information2.err";
            if (ChbRemember.Checked == true)
            {
                if (File.Exists(RememberLocation))
                {
                    File.Delete(RememberLocation);
                }

                if (!File.Exists(RememberLocation))
                {
                    File.Create(RememberLocation).Close();

                    TextWriter tw = new StreamWriter(RememberLocation);
                    tw.WriteLine(txtUsername.ToString(), '-');
                    tw.WriteLine(txtPassword.ToString(), '-');
                    tw.Close();
                }
            }
            else
            {
                if (File.Exists(RememberLocation))
                {
                    File.Delete(RememberLocation);
                }
            }


            // Create Save File
            string SaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            SaveLocation += "\\Hydrogen\\information_1.err";

            if (File.Exists(SaveLocation))
            {
                File.Delete(SaveLocation);
            }
            if (!File.Exists(SaveLocation))
            {
                File.Create(SaveLocation).Close();
                TextWriter tw = new StreamWriter(SaveLocation);
                tw.WriteLine(Username, '-');
                tw.Close();
            }

            SaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            SaveLocation += "\\Hydrogen\\information_2.err"; 

            if (File.Exists(SaveLocation))
            {
                File.Delete(SaveLocation);
            }
            if (!File.Exists(SaveLocation))
            {
                File.Create(SaveLocation).Close();
                TextWriter tw = new StreamWriter(SaveLocation);
                tw.WriteLine(Password, '-');
                tw.Close();
            }

            //Look for the GTA Process 
            Process[] pname = Process.GetProcessesByName("GTA5");
            if (pname.Length == 0)
            {
                colour = System.Drawing.Color.Red;
                error_message = "GTA 5 Is Not Open";
                loadingError = true;
                return;
            }

            //Get DLL Location
            String strProcessName = "GTA5";
            DllLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            DllLocation += "\\HydrogenDL\\" + DllName;


            RememberLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            RememberLocation += "\\Hydrogen\\RememberMeDetails.txt";
            if (ChbRemember.Checked == true)
            {
                if (File.Exists(RememberLocation))
                {
                    File.Delete(RememberLocation);
                }

                if (!File.Exists(RememberLocation))
                {
                    File.Create(RememberLocation).Close();

                    TextWriter tw = new StreamWriter(RememberLocation);
                    tw.WriteLine(Username);
                    tw.WriteLine(Password);
                    tw.Close();
                }
            }
            else
            {
                if (File.Exists(RememberLocation))
                {
                    File.Delete(RememberLocation);
                }
            }

            // Inject
            Int32 ProcID = GetProcessId(strProcessName);
            if (ProcID >= 0)
            {
                IntPtr hProcess = (IntPtr)OpenProcess(0x1F0FFF, 1, ProcID);
                if (hProcess == null)
                {
                    colour = System.Drawing.Color.Red;
                    error_message = "Error: Finding Process";
                    loadingError = true;
                    return;
                }
                else
                {
                    while (!File.Exists(DllLocation))
                        System.Threading.Thread.Sleep(50);
                    if (InjectDLL(hProcess, DllLocation))
                    {
                        colour = System.Drawing.Color.LimeGreen;
                        error_message = "Inject Succesful!";
                        injectSuccess = true;
                    }
                    else
                    {
                        colour = System.Drawing.Color.Red;
                        error_message = "Inject Failed!";
                        loadingError = true;
                    }
                }
            }
        }

        private void tester_updater_Tick(object sender, EventArgs e)
        {
            // Check if a user is a tester or not
            if (username_changed)
            {
                string hydrogen_auth_result;
                using (WebClient client = new WebClient())
                {
                    hydrogen_auth_result = client.DownloadString(new Uri(domain + "Authentication/is_tester.php?username=" + txtUsername.Text));
                }
                if (hydrogen_auth_result == "0")
                    tester = false;
                else
                    tester = true;

                ChkTester.Visible = tester;
                ChkTester.Checked = tester;
                username_changed = false;
            }
        }

        string get_random_string(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];

            var finalString = new String(stringChars);
            return finalString;
        }

        private void animateIn(Panel e, Form f)
        {
            width = f.Width;
            height = f.Height;
            // set panel into start position
            e.Left = width;
            e.Top = 0;
            selectedPanel = e;
            selectedForum = f;
            animateInBool = true;
            animationTimer.Enabled = true;
        }

        private void animateOut(Panel e, Form f)
        {
            width = f.Width;
            height = f.Height;
            selectedPanel = e;
            selectedForum = f;
            animateInBool = false;
            animationTimer.Enabled = true;
            pbxDragBar.SendToBack();
        }

        private void pbxDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Only Check if a User is Tester when this is true
            username_changed = true;
        }

        private void update_error_message_Tick_1(object sender, EventArgs e)
        {
            txtError.ForeColor = colour;
            txtError.Text = error_message;
        }

        //Close injector
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Miinimize injector
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Show options menu
        private void btnOptions_Click(object sender, EventArgs e)
        {
            if (pnlOptions.Visible == false)
                pnlOptions.Visible = true;
            else
                pnlOptions.Visible = false;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username here")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter username here";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter password here")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter password here";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0';
            }
        }

        //For settings button
        private void btnOptions_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            btnOptions.BackgroundImage = Properties.Resources.Gear;
            GC.Collect(); //Triggers garbage collection
        }

        private void pbxTitleImage_Click(object sender, EventArgs e)
        {
            Process.Start(domain);
        }

        //Validate Account
        bool username_or_password_changed = false;
        string login_username = "";
        string login_password = "";
        private void TimerCheckAccount_Tick(object sender, EventArgs e)
        {
            if (login_username != txtUsername.Text)
                username_or_password_changed = true;
            if (login_password != txtPassword.Text)
                username_or_password_changed = true;

            if (!username_or_password_changed)
                return;

            login_username = txtUsername.Text;
            login_password = txtPassword.Text;
            username_or_password_changed = false;

            if (login_username == "")
                return;
            if (login_password == "")
                return;

            WebClient web_tester_check = new WebClient();
            web_tester_check.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_web_tester_check);
            web_tester_check.DownloadStringAsync(new Uri(domain + "Authentication/ChkTest.php?username=" + login_username));

            WebClient web_login_check = new WebClient();
            web_login_check.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_web_login_check);
            web_login_check.DownloadStringAsync(new Uri(domain + "CheckLogin.php?username=" + login_username + "&password=" + login_password));
        }

        //HTTP Request Callback
        void wc_web_tester_check(object sender, DownloadStringCompletedEventArgs e)
        {
            string Login = e.Result;
            if (Login == "0")
            {
                IsLoginValid = false;
                return;
            }

            IsLoginValid = true;
        }

        //HTTP Request Callback
        void wc_web_login_check(object sender, DownloadStringCompletedEventArgs e)
        {
            string Login = e.Result;
            if (Login == "Unsuccessful")
            {
                ChkTester.Checked = false;
                ChkTester.Visible = false;
                return;
            }
            if (IsLoginValid == true)
            {
                ChkTester.Visible = true;
            }
        }

        private void btnOptions_MouseEnter(object sender, EventArgs e)
        {
            btnOptions.BackgroundImage = Properties.Resources.Gear_Light;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animateInBool == true)
            {
                selectedPanel.Left -= stepSize;
                if (selectedPanel.Left <= 0) //stepSize)
                {
                    selectedPanel.Left = 0;
                    stepSize = 25;
                    animationTimer.Enabled = false;
                    pbxDragBar.BringToFront();
                }
            }

            if (animateInBool == false)
            {
                selectedPanel.Left += stepSize;

                if (selectedPanel.Left >= selectedForum.Width)
                {
                    animationTimer.Enabled = false;
                    loadingError = false;
                    stepSize = 25;
                }
            }
        }

        private void testPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessageTimer_Tick(object sender, EventArgs e)
        {

            switch (loadingMessageStep)
            {
                case 0:
                    lblLoading.Text = "Loading";
                    loadingMessageStep++;
                    break;
                case 1:
                    lblLoading.Text = "Loading.";
                    loadingMessageStep++;
                    break;
                case 2:
                    lblLoading.Text = "Loading..";
                    loadingMessageStep++;
                    break;
                case 3:
                    lblLoading.Text = "Loading...";
                    loadingMessageStep = 0;
                    break;
            }
        }

        private void animationCheck_Tick(object sender, EventArgs e)
        {
            if (loadingError == true)
            {
                animateOut(testPanel, this);
                HideLoadingBar();
            }

            if (injectSuccess == true)
            {
                animateIn(pnlInjectSuccess, this);
                ShutdownTimer.Enabled = true;
                animationCheck.Enabled = false;
            }
        }

        private void ShutdownTimer_Tick(object sender, EventArgs e)
        {
            shutdownTime--;
            lblLoaderClosing.Text = "Loader will close in: " + shutdownTime;

            if (shutdownTime <= 0)
            {
                //Read Username and Password from the save file 
                string Information_err_Location = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                //Information_err_Location += "\\Hydrogen\\information_1.err";

                if (File.Exists(Information_err_Location + "\\Hydrogen\\information_1.err"))
                    File.Delete(Information_err_Location + "\\Hydrogen\\information_1.err");

                if (File.Exists(Information_err_Location + "\\Hydrogen\\information_2.err"))
                    File.Delete(Information_err_Location + "\\Hydrogen\\information_2.err");

                Close();
            }
        }

        private void EndscreenTimer_Tick(object sender, EventArgs e)
        {
            //unused
        }

        private void TimerCheckAccount_Tick_1(object sender, EventArgs e)
        {

        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            Process.Start((hydro_log_file + "\\Hydro"));
        }

        private void LoadingBarAnimTimer_Tick(object sender, EventArgs e)
        {
            pbxLoadingAnim1.Left = pbxLoadingAnim1.Left + 4;
            pbxLoadingAnim2.Left = pbxLoadingAnim2.Left + 4;

            if (pbxLoadingAnim1.Left >= (this.Width))
            {
                pbxLoadingAnim1.Left = (0 - pbxLoadingAnim1.Width);
            }

            if (pbxLoadingAnim2.Left >= (this.Width))
            {
                pbxLoadingAnim2.Left = (0 - pbxLoadingAnim2.Width);
            }
        }

        private void ShowLoadingBar()
        {
            pbxLoadingAnim1.Left = -3;
            pbxLoadingAnim2.Left = (pbxLoadingAnim2.Width * -1);

            pbxLoadingAnim1.Top = (this.height - pbxLoadingAnim1.Height);
            pbxLoadingAnim2.Top = (this.height - pbxLoadingAnim2.Height);
            pbxLoadingAnim1.BringToFront();
            pbxLoadingAnim2.BringToFront();
            LoadingBarAnimTimer.Enabled = true;
        }

        private void HideLoadingBar()
        {
            LoadingBarAnimTimer.Enabled = false;
            pbxLoadingAnim1.Top = 998;
            pbxLoadingAnim2.Top = 1000;
        }

        private void btnJoinDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/");
        }

        private void pbxInjectGrad_Click(object sender, EventArgs e)
        {

        }

        private void btnKeybinds_Click(object sender, EventArgs e)
        {
            Keybinds KeybindsForm = new Keybinds();
            KeybindsForm.Show();
            KeybindsForm.Top = this.Top;
            KeybindsForm.Left = this.Left;
        }

        private void pnlOptions_Leave(object sender, EventArgs e)
        {

        }
    }
}