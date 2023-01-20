namespace MegaDesk_Dias.Resources
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.drawerInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(74, 9);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(246, 20);
            this.nameInput.TabIndex = 0;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(49, 51);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(156, 20);
            this.widthInput.TabIndex = 1;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth";
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(48, 95);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(156, 20);
            this.depthInput.TabIndex = 4;
            this.depthInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.depthInput_KeyUp);
            // 
            // drawerInput
            // 
            this.drawerInput.Location = new System.Drawing.Point(117, 138);
            this.drawerInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerInput.Name = "drawerInput";
            this.drawerInput.Size = new System.Drawing.Size(91, 20);
            this.drawerInput.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of Drawers";
            // 
            // materialInput
            // 
            this.materialInput.DisplayMember = "a";
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialInput.Location = new System.Drawing.Point(105, 181);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(91, 21);
            this.materialInput.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Surface Material";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Production time";
            // 
            // rushInput
            // 
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "Default (14 days)"});
            this.rushInput.Location = new System.Drawing.Point(105, 224);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(104, 21);
            this.rushInput.TabIndex = 12;
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Location = new System.Drawing.Point(12, 262);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(308, 50);
            this.addQuoteBtn.TabIndex = 14;
            this.addQuoteBtn.Text = "Add Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 327);
            this.Controls.Add(this.addQuoteBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drawerInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.nameInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.NumericUpDown drawerInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}