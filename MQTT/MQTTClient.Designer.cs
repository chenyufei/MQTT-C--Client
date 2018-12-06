namespace MQTT
{
    partial class MQTTClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Subscribe = new System.Windows.Forms.TextBox();
            this.button_Subscribe = new System.Windows.Forms.Button();
            this.richTextBox_Subscribe = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Release = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Release = new System.Windows.Forms.TextBox();
            this.button_Release = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_UnSubscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订阅主题：";
            // 
            // textBox_Subscribe
            // 
            this.textBox_Subscribe.Location = new System.Drawing.Point(87, 15);
            this.textBox_Subscribe.Name = "textBox_Subscribe";
            this.textBox_Subscribe.Size = new System.Drawing.Size(301, 21);
            this.textBox_Subscribe.TabIndex = 1;
            // 
            // button_Subscribe
            // 
            this.button_Subscribe.Location = new System.Drawing.Point(394, 14);
            this.button_Subscribe.Name = "button_Subscribe";
            this.button_Subscribe.Size = new System.Drawing.Size(84, 23);
            this.button_Subscribe.TabIndex = 2;
            this.button_Subscribe.Text = "订阅";
            this.button_Subscribe.UseVisualStyleBackColor = true;
            this.button_Subscribe.Click += new System.EventHandler(this.button_Subscribe_Click);
            // 
            // richTextBox_Subscribe
            // 
            this.richTextBox_Subscribe.Location = new System.Drawing.Point(25, 56);
            this.richTextBox_Subscribe.Name = "richTextBox_Subscribe";
            this.richTextBox_Subscribe.Size = new System.Drawing.Size(453, 127);
            this.richTextBox_Subscribe.TabIndex = 3;
            this.richTextBox_Subscribe.Text = "";
            // 
            // richTextBox_Release
            // 
            this.richTextBox_Release.Location = new System.Drawing.Point(25, 240);
            this.richTextBox_Release.Name = "richTextBox_Release";
            this.richTextBox_Release.Size = new System.Drawing.Size(453, 116);
            this.richTextBox_Release.TabIndex = 4;
            this.richTextBox_Release.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "发布主题：";
            // 
            // textBox_Release
            // 
            this.textBox_Release.Location = new System.Drawing.Point(87, 205);
            this.textBox_Release.Name = "textBox_Release";
            this.textBox_Release.Size = new System.Drawing.Size(391, 21);
            this.textBox_Release.TabIndex = 6;
            // 
            // button_Release
            // 
            this.button_Release.Location = new System.Drawing.Point(209, 362);
            this.button_Release.Name = "button_Release";
            this.button_Release.Size = new System.Drawing.Size(86, 33);
            this.button_Release.TabIndex = 7;
            this.button_Release.Text = "发布";
            this.button_Release.UseVisualStyleBackColor = true;
            this.button_Release.Click += new System.EventHandler(this.button_Release_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(510, 56);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(84, 23);
            this.button_Connect.TabIndex = 8;
            this.button_Connect.Text = "连接";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(510, 160);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(84, 23);
            this.button_Disconnect.TabIndex = 9;
            this.button_Disconnect.Text = "断开";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_UnSubscribe
            // 
            this.button_UnSubscribe.Location = new System.Drawing.Point(510, 14);
            this.button_UnSubscribe.Name = "button_UnSubscribe";
            this.button_UnSubscribe.Size = new System.Drawing.Size(84, 23);
            this.button_UnSubscribe.TabIndex = 10;
            this.button_UnSubscribe.Text = "取消订阅";
            this.button_UnSubscribe.UseVisualStyleBackColor = true;
            this.button_UnSubscribe.Click += new System.EventHandler(this.button_UnSubscribe_Click);
            // 
            // MQTTClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 402);
            this.Controls.Add(this.button_UnSubscribe);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_Release);
            this.Controls.Add(this.textBox_Release);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_Release);
            this.Controls.Add(this.richTextBox_Subscribe);
            this.Controls.Add(this.button_Subscribe);
            this.Controls.Add(this.textBox_Subscribe);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MQTTClient";
            this.Text = "MQTT订阅及发布客户端";
            this.Load += new System.EventHandler(this.MQTTClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Subscribe;
        private System.Windows.Forms.Button button_Subscribe;
        private System.Windows.Forms.RichTextBox richTextBox_Subscribe;
        private System.Windows.Forms.RichTextBox richTextBox_Release;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Release;
        private System.Windows.Forms.Button button_Release;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_UnSubscribe;
    }
}

