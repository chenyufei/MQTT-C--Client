using MQTTnet;
using MQTTnet.Core;
using MQTTnet.Core.Client;
using MQTTnet.Core.Packets;
using MQTTnet.Core.Protocol;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTT
{
    public partial class MQTTClient : Form
    {
        private bool isReconnect = true;
        private MqttClient mqttClient = null;
        private string strIP = string.Empty;
        private string strPort = string.Empty;
        public MQTTClient()
        {
            InitializeComponent();
        }
        private async Task ConnectMqttServerAsync()
        {
            if (mqttClient == null)
            {
                mqttClient = new MqttClientFactory().CreateMqttClient() as MqttClient;
                mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;
                mqttClient.Connected += MqttClient_Connected;
                mqttClient.Disconnected += MqttClient_Disconnected;
            }

            try
            {
                var options = new MqttClientTcpOptions
                {
                    Server = "10.204.138.7",
                    Port = 1883,
                    ClientId = "claa_001",// Guid.NewGuid().ToString().Substring(0, 5),
                    UserName = "user_001",
                    Password = "pass_001",
                    CleanSession = true
                };

                await mqttClient.ConnectAsync(options);
            }
            catch (Exception ex)
            {
                Invoke((new Action(() =>
                {
                    richTextBox_Subscribe.AppendText($"连接到MQTT服务器失败！" + Environment.NewLine + ex.Message + Environment.NewLine);
                })));
            }
        }

        private void MqttClient_Connected(object sender, EventArgs e)
        {
            Invoke((new Action(() =>
            {
                richTextBox_Subscribe.AppendText("已连接到MQTT服务器！" + Environment.NewLine);
            })));
        }

        private void MqttClient_Disconnected(object sender, EventArgs e)
        {
            Invoke((new Action(() =>
            {
                richTextBox_Subscribe.AppendText("已断开MQTT连接！" + Environment.NewLine);
            })));

            //Reconnecting
            if (isReconnect)
            {
                Invoke((new Action(() =>
                {
                    richTextBox_Subscribe.AppendText("正在尝试重新连接" + Environment.NewLine);
                })));

                var options = new MqttClientTcpOptions
                {
                    Server = "10.204.138.7",
                    Port = 1883,
                    ClientId = "claa_001",// Guid.NewGuid().ToString().Substring(0, 5),
                    UserName = "user_001",
                    Password = "pass_001",
                    CleanSession = true
                };
                Invoke((new Action(async () =>
                {
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    try
                    {
                        await mqttClient.ConnectAsync(options);
                    }
                    catch
                    {
                        richTextBox_Subscribe.AppendText("### RECONNECTING FAILED ###" + Environment.NewLine);
                    }
                })));
            }
            else
            {
                Invoke((new Action(() =>
                {
                    richTextBox_Subscribe.AppendText("已下线！" + Environment.NewLine);
                })));
            }
        }

        private void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            Invoke((new Action(() =>
            {
                richTextBox_Subscribe.AppendText($">> {e.ApplicationMessage.Topic}{Environment.NewLine}");
                richTextBox_Subscribe.AppendText($">> {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}{Environment.NewLine}");
                richTextBox_Subscribe.ScrollToCaret();
            })));
        }

        private void button_Release_Click(object sender, EventArgs e)
        {
            string topic = textBox_Release.Text.Trim();

            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("发布主题不能为空！");
                return;
            }

            string inputString = richTextBox_Release.Text.Trim();
            var appMsg = new MqttApplicationMessage(topic, Encoding.UTF8.GetBytes(inputString), MqttQualityOfServiceLevel.AtMostOnce, false);
            mqttClient.PublishAsync(appMsg);
        }

        private void button_Subscribe_Click(object sender, EventArgs e)
        {
            string topic = textBox_Subscribe.Text.Trim();

            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("订阅主题不能为空！");
                return;
            }

            if (!mqttClient.IsConnected)
            {
                MessageBox.Show("MQTT客户端尚未连接！");
                return;
            }

            mqttClient.SubscribeAsync(new List<TopicFilter> {
                new TopicFilter(topic, MqttQualityOfServiceLevel.AtMostOnce)
            });

            richTextBox_Subscribe.AppendText($"已订阅[{topic}]主题" + Environment.NewLine);
            //textBox_Subscribe.Enabled = false;
            //button_Subscribe.Enabled = false;

        }

        private void MQTTClient_Load(object sender, EventArgs e)
        {

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            isReconnect = true;
            Task.Run(async () => { await ConnectMqttServerAsync(); });
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            isReconnect = false;
            Task.Run(async () => { await mqttClient.DisconnectAsync(); });
        }

        private void button_UnSubscribe_Click(object sender, EventArgs e)
        {
            string topic = textBox_Subscribe.Text.Trim();

            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("取消订阅主题不能为空！");
                return;
            }

            if (!mqttClient.IsConnected)
            {
                MessageBox.Show("MQTT客户端尚未连接！");
                return;
            }

            mqttClient.UnsubscribeAsync(topic);
            richTextBox_Subscribe.Clear();
            richTextBox_Subscribe.AppendText($"已取消订阅[{topic}]主题" + Environment.NewLine);
        }
    }
}
