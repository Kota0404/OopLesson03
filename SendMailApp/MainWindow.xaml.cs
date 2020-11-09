﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMailApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        Config config = Config.GetInstance();
        SmtpClient sc = new SmtpClient();

        public MainWindow() {
            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;
        }
        //送信完了イベント
        private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            if (e.Cancelled) {
                MessageBox.Show("送信はキャンセルされました");
            } else {
                MessageBox.Show(e.Error?.Message ?? "送信完了");
            }
        }

        //メールの送信処理
        private void  sousin_Click(object sender, RoutedEventArgs e) {
            try { 
            MailMessage msg = new MailMessage("ojsinfosys01 @gmail.com", tbTo.Text);
                
                msg.Subject = tbTitle.Text;//件名
            msg.Body = tbhonbun.Text;//本文
                if (tbCC.Text != "") {
                    string[] msgs = tbCC.Text.Split(',');
                    foreach (var item in msgs) {
                        msg.CC.Add(item);
                    }
                }
                    if (tbBcc.Text != "") {
                        string[] msgs = tbBcc.Text.Split(',');
                        foreach (var item in msgs) {
                            msg.Bcc.Add(item);
                        }
                    }

           
            sc.Host = config.Smtp;//smtpサーバーの設定
            sc.Port = config.Port;
            sc.EnableSsl = config.Ssl;
            sc.Credentials = new NetworkCredential(config.MailAddress, "ojsInfosys2020");
                
                //sc.Send(msg); //送信
                sc.SendMailAsync(msg);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //送信キャンセル処理
        private void Cancel_Click(object sender, RoutedEventArgs e) {
            sc.SendAsyncCancel();
        }
        //設定画面表示
        private void btConfig_Click(object sender, RoutedEventArgs e) {
            ConfigWindow configWindow = new ConfigWindow();//設定画面のインスタンスを生成
            configWindow.ShowDialog();//表示
        }
        //メインウィンドウがロードされるタイミングで呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e) {

        }
    }
}
