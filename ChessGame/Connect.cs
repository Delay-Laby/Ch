﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class Connect : Form
    {   public string ip;
        public int port;
        public Connect()
        {
            InitializeComponent();
        }

        private void create(object sender, EventArgs e)
        {//создает сеть или создает саму игру? 
            
            Chess ch = new Chess();
            ch.Show();
            ch.createServer(port);
            // Chess ch = new Chess();
            
            Close();
        }

        private void Connection(object sender, EventArgs e)
        {//Проверят подключение? 
            
            Chess ch = new Chess();
            ch.Show();
            ch.connectServer(ip, port);
            // Chess ch = new Chess();
            
            Close();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            ip = textBox1.Text;
        }

        private void TextChanged2(object sender, EventArgs e)
        {
            port = int.Parse(textBox2.Text);
        }
    }
}
