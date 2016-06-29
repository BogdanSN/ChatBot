using BotSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;


namespace ChatBot
{
    public partial class ChatBot : Form
    {
        public ChatBot()
        {
            InitializeComponent();
            GetBotsFromAssembly();
        }

        List<IBot> netBot = new List<IBot>();

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            
            if (MessageTextBox.Text != "")
            {
                ChatListBox.Items.Add(Environment.UserName + ": " + MessageTextBox.Text);
                
              
                    string botAnswer = ReciveAnswer(MessageTextBox.Text);
                    if (botAnswer != null)
                    {
                        ChatListBox.Items.Add(botAnswer + "\r\n");
                    }
              
               
            }
            else
                MessageBox.Show("Please enter something", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageTextBox.Text = "";
        }

        private string ReciveAnswer(string message)
        {
            foreach (IBot bot in netBot)
            {
                string botAnswer = bot.Answer(message);
                if (botAnswer != null)
                {
                    return bot.Name + ": " + botAnswer;
                }
            }
            return null;
        }

        private void GetBotsFromAssembly()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo targetDir = new DirectoryInfo(path);

                try
                {
                    foreach (FileInfo file in targetDir.GetFiles("*.dll"))
                    {
                        string assemblyString = Path.Combine(path, file.Name);
                        Assembly asm = Assembly.LoadFrom(assemblyString);
                        foreach (Type type in asm.GetTypes())
                        {
                            if (type.GetInterface("IBot") != null && type.IsClass)
                            {
                                IBot newBot = (IBot)Activator.CreateInstance(type);
                                netBot.Add(newBot);
                                                                
                            }
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("No Bots in folder","Missing Bots", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }
    }

