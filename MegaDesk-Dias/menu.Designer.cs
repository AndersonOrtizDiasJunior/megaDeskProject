namespace MegaDesk_Dias
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.quoteBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_Dias.Properties.Resources.mega_desk_icon;
            this.pictureBox1.Location = new System.Drawing.Point(149, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 191);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 36);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 136);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(122, 36);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search Quotes";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // quoteBtn
            // 
            this.quoteBtn.Location = new System.Drawing.Point(12, 26);
            this.quoteBtn.Name = "quoteBtn";
            this.quoteBtn.Size = new System.Drawing.Size(122, 36);
            this.quoteBtn.TabIndex = 6;
            this.quoteBtn.Text = "Add New Quote";
            this.quoteBtn.UseVisualStyleBackColor = true;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(12, 81);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(122, 36);
            this.viewBtn.TabIndex = 7;
            this.viewBtn.Text = "View Quotes";
            this.viewBtn.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.quoteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button quoteBtn;
        private System.Windows.Forms.Button viewBtn;
    }
}

