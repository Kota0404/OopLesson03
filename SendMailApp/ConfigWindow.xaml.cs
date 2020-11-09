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
using System.Windows.Shapes;

namespace SendMailApp {
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window {
        public ConfigWindow() {
            InitializeComponent();
        }

        private void btDefaultclic(object sender, RoutedEventArgs e) {
            Config config = (Config.GetInstance()).getConfig();
            //Config defaultData = config.getConfig();
            tbSmtp.Text = config.Smtp;
            tbUserName.Text = tbSender.Text = config.MailAddress;
            tbPort.Text = config.Port.ToString();
            tbPassWord.Password = config.PassWord;
            cbSsl.IsChecked = config.Ssl;
        }
        //適用更新
        private void btApplyCl(object sender, RoutedEventArgs e) {
           (Config.GetInstance()).UpdateStatus(
               tbSmtp.Text, 
                tbUserName.Text,
                tbPassWord.Password,
                int.Parse(tbPort.Text), 
                cbSsl.IsChecked ?? false);　//更新処理を呼びだす
        }
        //ロード時に一度だけ呼び出される
        private void ConfigWindow_Loaded(object sender, RoutedEventArgs e) {
            Config config = Config.GetInstance();
            tbSmtp.Text = config.Smtp;
            tbSender.Text = tbUserName.Text = config.MailAddress;
             tbPort.Text = config.Port.ToString();
            tbPassWord.Password = config.PassWord;
            cbSsl.IsChecked = config.Ssl;
        }
        //OKボタン
        private void btOkCl(object sender, RoutedEventArgs e) {
            btApplyCl(sender,e);
            this.Close();
        }
        //Cancelボタン
        private void btCancelCl(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
