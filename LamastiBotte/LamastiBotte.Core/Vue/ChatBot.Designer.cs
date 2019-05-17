namespace LamastiBotte.Core.Vue
{
    partial class chatBotVue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatBotVue));
            this.tbConversation = new System.Windows.Forms.RichTextBox();
            this.btnEnvoiMessage = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbConversation
            // 
            this.tbConversation.Location = new System.Drawing.Point(31, 31);
            this.tbConversation.Name = "tbConversation";
            this.tbConversation.ReadOnly = true;
            this.tbConversation.Size = new System.Drawing.Size(626, 259);
            this.tbConversation.TabIndex = 1;
            this.tbConversation.Text = "";
            this.tbConversation.TextChanged += new System.EventHandler(this.tbConversation_TextChanged);
            // 
            // btnEnvoiMessage
            // 
            this.btnEnvoiMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnvoiMessage.Location = new System.Drawing.Point(546, 311);
            this.btnEnvoiMessage.Name = "btnEnvoiMessage";
            this.btnEnvoiMessage.Size = new System.Drawing.Size(111, 30);
            this.btnEnvoiMessage.TabIndex = 2;
            this.btnEnvoiMessage.Text = "Envoyer";
            this.btnEnvoiMessage.UseVisualStyleBackColor = false;
            this.btnEnvoiMessage.Click += new System.EventHandler(this.btnEnvoiMessage_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(31, 315);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(495, 22);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // chatBotVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(691, 384);
            this.Controls.Add(this.btnEnvoiMessage);
            this.Controls.Add(this.tbConversation);
            this.Controls.Add(this.tbMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(709, 431);
            this.MinimumSize = new System.Drawing.Size(709, 431);
            this.Name = "chatBotVue";
            this.Text = "LAMASTIBOTTE";
            this.Load += new System.EventHandler(this.chatBotVue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbConversation;
        private System.Windows.Forms.Button btnEnvoiMessage;
        private System.Windows.Forms.TextBox tbMessage;
    }
}