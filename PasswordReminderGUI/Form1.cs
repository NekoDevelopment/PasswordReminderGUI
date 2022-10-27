using System.DirectoryServices.ActiveDirectory;
namespace PasswordReminderGUI
{
    public partial class passwordForm : Form
    {
        public passwordForm()
        {
            if (userNeedsRemind())
            {
                InitializeComponent();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remindText.Text = remindText.Text.Replace("{username}", Environment.UserName);
            remindText.Text = remindText.Text.Replace("{days}", GetPasswordExpirationDate().Days.ToString());
        }

        private bool userNeedsRemind()
        {
            int days = GetPasswordExpirationDate().Days;
            if(days == 0 || days == 1 || days == 2 || days == 3 || days == 5 || days == 10)
            {
                return true;
            } else
            {
                return false;
            }
        }
        private TimeSpan GetPasswordExpirationDate()
        {
            using (var userEntry = new System.DirectoryServices.DirectoryEntry(string.Format("WinNT://{0}/{1},user", Environment.UserDomainName, Environment.UserName)))
            {
                var maxPasswordAge = (int)userEntry.Properties.Cast<System.DirectoryServices.PropertyValueCollection>().First(p => p.PropertyName == "MaxPasswordAge").Value;
                var passwordAge = (int)userEntry.Properties.Cast<System.DirectoryServices.PropertyValueCollection>().First(p => p.PropertyName == "PasswordAge").Value;
                return TimeSpan.FromSeconds(maxPasswordAge) - TimeSpan.FromSeconds(passwordAge);
            }
        }



        private void remindText_Click(object sender, EventArgs e)
        {

        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }
    }
}