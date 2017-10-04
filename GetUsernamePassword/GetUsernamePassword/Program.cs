using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsAccount {
    public partial class Form1 : Form {

        [DllImport("advapi32.dll",SetLastError = true)]
        public static extern bool LogonUser (string lpszUsername,
            string lpszDomain,
            string lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            out IntPtr phToken
            );

        [DllImport("kernel32.dll")]
        public static extern int FormatMessage (int dwFlags,ref IntPtr lpSource,int dwMessageId,int dwLanguageId,ref String lpBuffer,int nSize,ref IntPtr Arguments);

        [DllImport("kernel32.dll",SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle (IntPtr hObject);


        public static string GetErrorMessage (int errorCode) {
            int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x100;
            int FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;
            int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;

            int msgSize = 255;
            string lpMsgBuf = null;
            int dwFlags = FORMAT_MESSAGE_ALLOCATE_BUFFER | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS;

            IntPtr lpSource = IntPtr.Zero;
            IntPtr lpArguments = IntPtr.Zero;
            int returnVal = FormatMessage(dwFlags,ref lpSource,errorCode,0,ref lpMsgBuf,msgSize,ref lpArguments);

            if (returnVal == 0) {
                throw new Exception("Failed to format message for error code " + errorCode.ToString() + ". ");
            }
            return lpMsgBuf;

        }


        public Form1 () {
            InitializeComponent();
        }

        private void btnLogin_Click (object sender,EventArgs e) {
            IntPtr tokenHandle = new IntPtr(0);

            try {
                string UserName = null;
                string MachineName = null;
                string Pwd = null;

                //The MachineName property gets the name of your computer.
                MachineName = System.Environment.MachineName;
                UserName = txtUser.Text;
                Pwd = txtPass.Text;

                const int LOGON32_PROVIDER_DEFAULT = 0;
                const int LOGON32_LOGON_INTERACTIVE = 2;
                tokenHandle = IntPtr.Zero;

                //Call the LogonUser function to obtain a handle to an access token.
                bool returnValue = LogonUser(UserName,MachineName,Pwd,LOGON32_LOGON_INTERACTIVE,LOGON32_PROVIDER_DEFAULT,out tokenHandle);

                if (returnValue == false) {
                    //This function returns the error code that the last unmanaged function returned.
                    int ret = Marshal.GetLastWin32Error();
                    string errmsg = GetErrorMessage(ret);
                    MessageBox.Show(errmsg);
                } else {
                    //Create the WindowsIdentity object for the Windows user account that is
                    //represented by the tokenHandle token.

                    WindowsIdentity newId = new WindowsIdentity(tokenHandle);
                    WindowsPrincipal userperm = new WindowsPrincipal(newId);

                    //Verify whether the Windows user has administrative credentials.
                    if (userperm.IsInRole(WindowsBuiltInRole.Administrator)) {
                        MessageBox.Show("Access Granted. User is admin");
                    } else {
                        MessageBox.Show("Access Granted. User is not admin");
                    }
                }

                CloseHandle(tokenHandle);
            } catch (Exception ex) {
                MessageBox.Show("Exception occurred. " + ex.Message);
            }

        }
    }
}