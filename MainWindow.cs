using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mastodot;
using Mastodot.Enums;
using Mastodot.Utils;
using Mastodot.Entities;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {
        static Oauth form2 =   new Oauth();
        public static Mastodot.Entities.RegisteredApp registeredApp;
        private static string host;
        private static string AccessToken;
        public static  string [] TodoList;
        public static MainWindow main = new MainWindow();
        private string UserName;

        public MainWindow()
        {

            //var p = new Form1();
            InitializeComponent();
            Toot_Mode.Items.Add("公開");
            Toot_Mode.Items.Add("非公開");
            Toot_Mode.Items.Add("フォローのみ");

            FontSize.Items.Add("小");
            FontSize.Items.Add("中");
            FontSize.Items.Add("大");

            this.Toot_Mode.SelectedIndex = 0;
            this.FontSize.SelectedIndex = 1;
            this.TopMost = true;


        }


        public void OAuth(string a)
        {
            this.TopMost = false;
            try
            {
                //"C:\test\1.txt"をShift-JISコードとして開く
                Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Extreme_Simple_Tooter\sub", false);
                //内容を一行ずつ読み込む
                AccessToken = (string)regkey.GetValue("AccessToken");
                host = (string)regkey.GetValue("hostname");
                Toot(Toot_Mode.SelectedItem.ToString());
            }
            catch (NullReferenceException)
            {
                    form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
                    try
                    {
                        form2.ShowDialog();
                    }
                    catch (Exception)
                    {
                        form2.Visible = false;
                    }
            }
            this.TopMost = true;
        }



        public void Form2_FormClosed(object sender, FormClosedEventArgs e) {


            Oauth f2 = (Oauth)sender;
            this.TopMost = true;
            //main.OAuth();
        }

        public void Toot(string mode) {
            registeredApp = ApplicaionManager.RegistApp(host, "ExtremeSimpleTooter", Scope.Read | Scope.Write | Scope.Follow).Result;
            var client = new MastodonClient(host, AccessToken);

            UserName = HashTagOption.Text;
            string TootMessage = Toot_Input.Text;
            if (TootMessage == "") {
                return;
            }
            if (mode == "公開")
            {
                client.PostNewStatus(status: TootMessage +  Environment.NewLine + "#" + UserName+ "_On_Extreme_Simple_Tooter", visibility: Mastodot.Enums.Visibility.Public);
            }
            else if (mode == "非公開")
            {
                client.PostNewStatus(status: TootMessage + Environment.NewLine + "#" + UserName + "_On_Extreme_Simple_Tooter", visibility: Mastodot.Enums.Visibility.Unlisted);
            }
            else {
                client.PostNewStatus(status: TootMessage  + Environment.NewLine + "#" + UserName +  "_On_Extreme_Simple_Tooter", visibility: Mastodot.Enums.Visibility.Private);
            }

            Toot_Input.Clear();
        }
        


        private void Toot_button_Click(object sender, EventArgs e)
        {
            //form2.Show();
            OAuth(Toot_Mode.SelectedItem.ToString());

        }

        private void Toot_Input_TextChanged(object sender, EventArgs e)
        {
            LastTextNumber.Text = (500 - Toot_Input.Text.Length).ToString();
            if (int.Parse(LastTextNumber.Text)<0) {
                LastTextNumber.ForeColor = Color.Red;
            }
        }

        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontSize.SelectedItem.ToString() == "小")
            {
                Toot_Input.SelectAll();
                Toot_Input.SelectionFont = new Font("MS UI Gothic", 7);
            }
            else if (FontSize.SelectedItem.ToString() == "中")
            {
                Toot_Input.SelectAll();
                Toot_Input.SelectionFont = new Font("MS UI Gothic", 9);
            }
            else {
                Toot_Input.SelectAll();
                Toot_Input.SelectionFont = new Font("MS UI Gothic", 12);
            }
        }

        private void Toot_Input_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control == true)
            {
                OAuth(Toot_Mode.SelectedItem.ToString());
            }
        }
    }
}
