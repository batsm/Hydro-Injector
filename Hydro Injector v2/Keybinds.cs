using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydro_Injector_v2
{
    public partial class Keybinds : Form
    {

        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        internal enum WindowCompositionAttribute
        {
            // ...
            WCA_ACCENT_POLICY = 19
            // ...
        }

        internal enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_INVALID_STATE = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParms = base.CreateParams;
                return cParms;
            }
        }

        public Keybinds()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Keybinds_Load(object sender, EventArgs e)
        {
            //(new LayeredWindowHelper(this)).BackColor = Color.FromArgb(128, Win7Style.GetThemeColor());
            IntPtr myHandle = this.Handle;
            //EnableBlur(myHandle);
        }

        public static void EnableBlur(IntPtr HWnd, bool hasFrame = true)
        {

            AccentPolicy accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
            if (hasFrame)
                accent.AccentFlags = 0x20 | 0x40 | 0x80 | 0x100;

            int accentStructSize = Marshal.SizeOf(accent);

            IntPtr accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            WindowCompositionAttributeData data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(HWnd, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        private void btnOpenM1_Click(object sender, EventArgs e)
        {
            KeyConformation showConformation = new KeyConformation(this.Top, this.Left);
            showConformation.Show();
        }
    }
}
