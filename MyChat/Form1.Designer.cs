namespace MyChat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOwnIP = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxRO_IP = new System.Windows.Forms.TextBox();
            this.textBoxRO_Port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOwnIP
            // 
            this.labelOwnIP.AutoSize = true;
            this.labelOwnIP.Location = new System.Drawing.Point(12, 15);
            this.labelOwnIP.Name = "labelOwnIP";
            this.labelOwnIP.Size = new System.Drawing.Size(44, 15);
            this.labelOwnIP.TabIndex = 1;
            this.labelOwnIP.Text = "This IP:";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(12, 105);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(297, 23);
            this.textBoxIp.TabIndex = 2;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(12, 193);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(297, 128);
            this.richTextBoxMessage.TabIndex = 3;
            this.richTextBoxMessage.Text = "";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(12, 149);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(297, 23);
            this.textBoxPort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input message";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.Location = new System.Drawing.Point(12, 327);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(297, 111);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(315, 12);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(344, 426);
            this.richTextBoxOutput.TabIndex = 9;
            this.richTextBoxOutput.Text = "";
            // 
            // textBoxRO_IP
            // 
            this.textBoxRO_IP.Location = new System.Drawing.Point(74, 12);
            this.textBoxRO_IP.Name = "textBoxRO_IP";
            this.textBoxRO_IP.ReadOnly = true;
            this.textBoxRO_IP.Size = new System.Drawing.Size(235, 23);
            this.textBoxRO_IP.TabIndex = 10;
            // 
            // textBoxRO_Port
            // 
            this.textBoxRO_Port.Location = new System.Drawing.Point(74, 40);
            this.textBoxRO_Port.Name = "textBoxRO_Port";
            this.textBoxRO_Port.ReadOnly = true;
            this.textBoxRO_Port.Size = new System.Drawing.Size(235, 23);
            this.textBoxRO_Port.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "This Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.textBoxRO_Port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRO_IP);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.labelOwnIP);
            this.MaximumSize = new System.Drawing.Size(687, 489);
            this.MinimumSize = new System.Drawing.Size(687, 489);
            this.Name = "Form1";
            this.Text = "Chat 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelOwnIP;
        private TextBox textBoxIp;
        private RichTextBox richTextBoxMessage;
        private TextBox textBoxPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSend;
        private RichTextBox richTextBoxOutput;
        private TextBox textBoxRO_IP;
        private TextBox textBoxRO_Port;
        private Label label4;
    }
}