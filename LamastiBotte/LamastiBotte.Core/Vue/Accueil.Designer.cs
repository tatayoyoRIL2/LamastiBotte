namespace LamastiBotte.Core.Vue
{
    partial class accueilVue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accueilVue));
            this.lbTitre = new System.Windows.Forms.Label();
            this.lbSlogan = new System.Windows.Forms.Label();
            this.logoBotte = new System.Windows.Forms.PictureBox();
            this.btnBegin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBotte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.White;
            this.lbTitre.Location = new System.Drawing.Point(333, 78);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(243, 36);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "LAMASTIBOTTE";
            this.lbTitre.Click += new System.EventHandler(this.lbTitre_Click);
            // 
            // lbSlogan
            // 
            this.lbSlogan.AutoSize = true;
            this.lbSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlogan.ForeColor = System.Drawing.Color.White;
            this.lbSlogan.Location = new System.Drawing.Point(281, 113);
            this.lbSlogan.Name = "lbSlogan";
            this.lbSlogan.Size = new System.Drawing.Size(343, 25);
            this.lbSlogan.TabIndex = 1;
            this.lbSlogan.Text = "Un lama comme guide ça vous botte ?";
            this.lbSlogan.Click += new System.EventHandler(this.lbSlogan_Click);
            // 
            // logoBotte
            // 
            this.logoBotte.Image = global::LamastiBotte.Core.Properties.Resources.LamastiBotte_Logo;
            this.logoBotte.Location = new System.Drawing.Point(39, 78);
            this.logoBotte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoBotte.Name = "logoBotte";
            this.logoBotte.Size = new System.Drawing.Size(155, 202);
            this.logoBotte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoBotte.TabIndex = 2;
            this.logoBotte.TabStop = false;
            this.logoBotte.Click += new System.EventHandler(this.logoBotte_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(340, 209);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(237, 62);
            this.btnBegin.TabIndex = 3;
            this.btnBegin.Text = "Commencez maintenant !";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // accueilVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(691, 384);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.logoBotte);
            this.Controls.Add(this.lbSlogan);
            this.Controls.Add(this.lbTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(709, 431);
            this.MinimumSize = new System.Drawing.Size(709, 431);
            this.Name = "accueilVue";
            this.Text = "LAMASTIBOTTE";
            this.Load += new System.EventHandler(this.Vue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBotte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Label lbSlogan;
        private System.Windows.Forms.PictureBox logoBotte;
        private System.Windows.Forms.Button btnBegin;
    }
}