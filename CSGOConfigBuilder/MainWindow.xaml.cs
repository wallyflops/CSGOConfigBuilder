using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CSGOConfigBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isJumpThrowChecked { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewConfig_Click(object sender, RoutedEventArgs e)
        {
            string configFile = txtConfigDir.Text;
            string keyToBind = txtJumpThrowKeyToBind.Text;

            CreateNewTextFile autoexec = new CreateNewTextFile();
            autoexec.WriteText(configFile, keyToBind, isJumpThrowChecked);

            MessageBox.Show("Done");

        }

        private void FindConfig_Click(object sender, RoutedEventArgs e)
        {

            string installpath = getCSInstallPath();

            OpenFileDialog openAeDialog = new OpenFileDialog();
            openAeDialog.Filter = "Config Files|*.cfg";
            openAeDialog.InitialDirectory = installpath;

            if (openAeDialog.ShowDialog() == true)
            {
                txtConfigDir.Text = openAeDialog.FileName;
            }

 
        }

        private string getCSInstallPath()
        {
            //returns string "installpath"
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");
            string installpath = "";
            if (regKey != null)
            {
                installpath = regKey.GetValue("ModInstallPath").ToString();
                installpath = installpath.Replace("Half-Life", "Counter-Strike Global Offensive");
                installpath += "\\csgo\\cfg";
            }
            return installpath;
        }

        private void chkJumpThrow_Checked(object sender, RoutedEventArgs e)
        {
            isJumpThrowChecked = chkJumpThrow.IsChecked.Value;
        }
    }
}
