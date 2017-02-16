using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using server_ui;

//Simple Chat Program - Karine Or
//The purpose of this class is to be the communication manager for the _client side. All logic from _client to server is implemented here.

namespace client_ui
{
   public class CommunicationManager
    {
        #region   Members

        //Variables related to networking
        private IPAddress m_ipAddr; //represents the ip address of the server
        private TcpClient m_client; // Creates TCP _client instance
        private int m_port = 4000;
        private NetworkStream m_networkStream; //Creates a NetworkSteam instance to send and receive the messages
        private FileStream m_fileStream;
        private bool m_IsConnected { get; set; }
    

        //Variables members related to Streaming and file R-W
        private BinaryReader m_readerr;
        private BinaryWriter m_writerr;

        //Variables members related to Threads
        private Thread m_messageThread; //Initialize the new thread to read messages sent by the server.
        public ServerCommunicationManager m_cmServer = new ServerCommunicationManager();

        //Variable members for reference to _client Gui
        ClientChatWindow m_frmClientChatWindow;

        //Variable member for closing event
        private ManualResetEvent m_eventClose;

        #endregion Members

        /// <summary>
        /// Ctor of the class to initiate a _client communication manager (_client business logic). Object contains event and Async thread mecanism to receive messages
        /// </summary>
        public CommunicationManager()
        {
            m_eventClose = new ManualResetEvent(false); //event that tells me if form was close
        }
        
        /// <summary>
        /// Sets the pointer to the GUI for the updates of text
        /// </summary>
        /// <param name="chat">Reference of GUI of _client</param>
        public void Set(ClientChatWindow chat)
        {
            m_frmClientChatWindow = chat;
        }

        /// <summary>
        /// This method connects the _client to the server and sends the userName 
        /// and timestamp's connection. Return true if connection succeds, otherwise false.
        /// </summary>
        /// <param name="clientIp"></param>
        /// <param name="userName"></param>
        /// <param name="client"></param>
        /// <param name="serverIp"></param>
        /// <returns>boolean true or false</returns>
        public bool InitializeConnection(string serverIp, string clientIp, string userName, TcpClient client)
        {
            try
            {
                m_messageThread = new Thread(ReceiveMessages);
                m_messageThread.Start();//Starts a thread that constantly listens to new messages
                m_ipAddr = IPAddress.Parse(serverIp); //Parse the IP address from the TextBox into an IPAddress object
                client.Connect(m_ipAddr.ToString(), m_port); //Connect to the server
                m_networkStream = client.GetStream(); //Creates the streaming channel to transfer the data
                
                m_writerr=new BinaryWriter(m_networkStream);//Creates a new B writter that will to write the streamed data
                m_writerr.Write(userName); //sends the _client _username in streaming channel
                m_writerr.Write(clientIp); //send sthe _client IPAddr in streaming channel

                return m_IsConnected = true;
            }
            catch (Exception ex) //If the connection fails, returns exception
            {
                MessageBox.Show(ex.Message);
                return m_IsConnected = false;
            }
        }

        /// <summary>
        /// Runs in loop until the program is closed and reads incoming messages
        /// </summary>
        private void ReceiveMessages()
        {
            while (!m_eventClose.WaitOne(10, false))
                //asks the event if it was set, meaning there was a click on the close of the form
            {
                try
                {
                    if (m_networkStream == null) continue;
                    
                    if (m_IsConnected && m_networkStream != null)
                    {
                            m_readerr = new BinaryReader(m_networkStream);//Creates a new reader to read the info from the stream channel
                            string message = m_readerr.ReadString();
                            PrintMessage(message);// Call Mth to push the msg to the Gui  
                    }
                    else
                    {
                        m_readerr.Close();
                    }
                }
                catch
                {
                    // ignored
                }
            }
        }

        /// <summary>
        /// Push the message to the gui
        /// </summary>
        /// <param name="messageWithUser"></param>
        private void PrintMessage(string messageWithUser)
        {
            m_frmClientChatWindow.UpdateChatListBox(messageWithUser);// Push the message to the gui
        }

        /// <summary>
        /// Send a message with the _username to the server  
        /// </summary>
        /// <param name="username">The _client's user name</param>
        /// <param name="message">The message</param>
        /// <returns></returns>
        public bool SendMessage(string message, string username)
        {
            bool msgStatus = false;
            try
            {
                if (message.Length > 0)
                {
                    m_writerr.Write(username + " says: " + message); //Sends the user message
                    msgStatus = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                m_networkStream.Flush();
            }
            return msgStatus;
        }
        
        /// <summary>
        /// Close all connections. 
        /// </summary>
        public bool CloseConnection(string username,TcpClient client, string clientStatus, bool isConnected)
        {
            if (username == null) throw new ArgumentNullException(nameof(username));
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (clientStatus == null) throw new ArgumentNullException(nameof(clientStatus));

            try
            {
                if (client.Connected)
                {
                    SendMessage(clientStatus, username);//send message "disconnected"
                    m_messageThread.Abort(); //Close the receiving message thread
                    client.Close(); //close TCP _client connection
                    m_networkStream.Close(); //Close the steaming channel
                    isConnected = false; 
                } 
            }
            catch (Exception)
            {
                m_messageThread.Abort();  
                client.Close(); 
                m_networkStream.Close(); 
            }
           return isConnected;
        }
        
        /// <summary>
        /// Signales that the _client was closed
        /// </summary>
        public void Close()
        {
            m_eventClose.Set();
            Application.Exit();
        }


        //TODO will be implemented later. 
        /// <summary>
        /// Sends a file to the stream
        /// </summary>
        /// <param name="fileToSend"></param>
        /// <param name="username"></param>
        /// <param name="ms">Memory stream the contains the original file contents</param>
        /// <param name="result">Whether sending was successful</param>
        /// <returns></returns>
        public void SendFile(string fileToSend, string username)
        {
            try
            {
                if (fileToSend.Length > 0)

                    m_writerr.Write(fileToSend);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());

            }
        }

    }
}
