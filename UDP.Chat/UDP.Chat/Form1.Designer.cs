
namespace UDP.Chat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ім’я";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(156, 22);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(228, 22);
            this.userNameTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(416, 11);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(96, 33);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вхід";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.Location = new System.Drawing.Point(416, 50);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(96, 33);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Вихід";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(12, 97);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatTextBox.Size = new System.Drawing.Size(500, 310);
            this.chatTextBox.TabIndex = 4;
            this.chatTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 440);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(355, 58);
            this.messageTextBox.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(389, 440);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(145, 58);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Відправити";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 521);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
    }
}

