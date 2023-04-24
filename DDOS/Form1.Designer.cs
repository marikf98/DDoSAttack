namespace DDOS
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
            this.AttackWith = new System.Windows.Forms.Label();
            this.numOfBrowsers = new System.Windows.Forms.TextBox();
            this.browsers = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.targetUrl = new System.Windows.Forms.TextBox();
            this.startAttack = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.attackText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AttackWith
            // 
            this.AttackWith.Location = new System.Drawing.Point(0, 0);
            this.AttackWith.Name = "AttackWith";
            this.AttackWith.Size = new System.Drawing.Size(100, 23);
            this.AttackWith.TabIndex = 7;
            // 
            // numOfBrowsers
            // 
            this.numOfBrowsers.Location = new System.Drawing.Point(85, 27);
            this.numOfBrowsers.Name = "numOfBrowsers";
            this.numOfBrowsers.Size = new System.Drawing.Size(81, 20);
            this.numOfBrowsers.TabIndex = 1;
            this.numOfBrowsers.TextChanged += new System.EventHandler(this.numOfBrowsers_TextChanged);
            // 
            // browsers
            // 
            this.browsers.Location = new System.Drawing.Point(172, 28);
            this.browsers.Name = "browsers";
            this.browsers.Size = new System.Drawing.Size(63, 18);
            this.browsers.TabIndex = 2;
            this.browsers.Text = "browsers";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(15, 64);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(70, 16);
            this.url.TabIndex = 3;
            this.url.Text = "Target URL:";
            // 
            // targetUrl
            // 
            this.targetUrl.Location = new System.Drawing.Point(85, 60);
            this.targetUrl.Name = "targetUrl";
            this.targetUrl.Size = new System.Drawing.Size(243, 20);
            this.targetUrl.TabIndex = 4;
            this.targetUrl.TextChanged += new System.EventHandler(this.targetUrl_TextChanged);
            // 
            // startAttack
            // 
            this.startAttack.Location = new System.Drawing.Point(15, 104);
            this.startAttack.Name = "startAttack";
            this.startAttack.Size = new System.Drawing.Size(321, 27);
            this.startAttack.TabIndex = 5;
            this.startAttack.Text = "Start DDoS Attack";
            this.startAttack.UseVisualStyleBackColor = true;
            this.startAttack.Click += new System.EventHandler(this.startAttack_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(15, 137);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(321, 23);
            this.close.TabIndex = 6;
            this.close.Text = "Close All";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // attackText
            // 
            this.attackText.Location = new System.Drawing.Point(15, 27);
            this.attackText.Name = "attackText";
            this.attackText.Size = new System.Drawing.Size(69, 19);
            this.attackText.TabIndex = 8;
            this.attackText.Text = "Attack With:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(485, 264);
            this.Controls.Add(this.attackText);
            this.Controls.Add(this.close);
            this.Controls.Add(this.startAttack);
            this.Controls.Add(this.targetUrl);
            this.Controls.Add(this.url);
            this.Controls.Add(this.browsers);
            this.Controls.Add(this.numOfBrowsers);
            this.Controls.Add(this.AttackWith);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label attackText;

        private System.Windows.Forms.Label url;
        private System.Windows.Forms.TextBox targetUrl;
        private System.Windows.Forms.Button startAttack;
        private System.Windows.Forms.Button close;

        private System.Windows.Forms.TextBox numOfBrowsers;
        private System.Windows.Forms.Label browsers;

        private System.Windows.Forms.Label AttackWith;

        #endregion
    }
}