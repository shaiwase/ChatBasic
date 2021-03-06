﻿using System;
using System.Windows.Forms;


//The purpose of this class is to implement the server Gui side

namespace server_ui
{
    //Delegates
    public delegate void UpdateChatLogMessages(string txt);
    public delegate void UpdateUserNameListBox(string value, bool isRemove);
    public delegate void UpdateUserIpAndTimeListBox(string value, string time, bool isRemove);

    public partial class ServerGUI : Form
    {

        #region Member variables

        private ServerCommunicationManager _communicationManager;//Declares an instance of ServerCommunication manager.

        #endregion

        /// <summary>
        /// ServerGui ctor initializer
        /// </summary>
        public ServerGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update the listbox with users messages
        /// </summary>
        /// <param name="msg"></param>
        public void UpdateTxtBoxMsgs(string msg)
        {
            if (txtBoxMsgLog.InvokeRequired)
            {
                Invoke(new UpdateChatLogMessages(UpdateTxtBoxMsgs), msg);
            }
            else
            {
                txtBoxMsgLog.Text += ("\r\n" + msg);
            }
        }

        /// <summary>
        /// Update the listbox with the clients nicknames
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isRemove"></param>
        public void UpdateUserLogListBox(string value, bool isRemove)
        {
            if (listBox1.InvokeRequired)
            {
                Invoke(new UpdateUserNameListBox(UpdateUserLogListBox), value, isRemove);
            }
            else
            {
                if (isRemove) //if isRemove is true
                {
                    listBox1.Items.Remove(value);
                }
                else
                {
                    listBox1.Items.Add(value);
                }
                
            }
        }

        /// <summary>
        /// Update the listbox with the clients IP and time of connection
        /// </summary>
        /// <param name="value"></param>
        /// <param name="time"></param>
        /// <param name="isRemove"></param>
        public void UpdateUserIpAndTimeLogListBox(string value, string time, bool isRemove)
        {
            if (listBox1.InvokeRequired)
            {
                Invoke(new UpdateUserIpAndTimeListBox(UpdateUserIpAndTimeLogListBox), value, time, isRemove);
            }
            else
            {
                if (isRemove) //if isRemove is true
                {
                    listBox2.Items.Remove(value);
                }
                else
                {
                    listBox2.Items.Add("from :" + value + " at : " + time);
                }
            }
        }

        /// <summary>
        /// Stops all threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
           Environment.Exit(Environment.ExitCode);
        }


        //The bellow methods are for future use. Still not implemented. //TODO

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendPrivateChat_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_broadcast_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
