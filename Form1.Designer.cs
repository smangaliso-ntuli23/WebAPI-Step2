
namespace WebAPI
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
            this.dgvPayout = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblOdds = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblPayout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bet Amount";
            // 
            // dgvPayout
            // 
            this.dgvPayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayout.Location = new System.Drawing.Point(406, 69);
            this.dgvPayout.Name = "dgvPayout";
            this.dgvPayout.Size = new System.Drawing.Size(240, 150);
            this.dgvPayout.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(406, 225);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(199, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = true;
            this.lblOdds.Location = new System.Drawing.Point(136, 119);
            this.lblOdds.Name = "lblOdds";
            this.lblOdds.Size = new System.Drawing.Size(93, 13);
            this.lblOdds.TabIndex = 8;
            this.lblOdds.Text = "Waiting for odds...";
            this.lblOdds.Click += new System.EventHandler(this.lblCountUp_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(189, 77);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 9;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblPayout
            // 
            this.lblPayout.AutoSize = true;
            this.lblPayout.Location = new System.Drawing.Point(136, 206);
            this.lblPayout.Name = "lblPayout";
            this.lblPayout.Size = new System.Drawing.Size(102, 13);
            this.lblPayout.TabIndex = 10;
            this.lblPayout.Text = "Waiting for payout...";
            this.lblPayout.Click += new System.EventHandler(this.lblCountDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 407);
            this.Controls.Add(this.lblPayout);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOdds);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvPayout);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPayout;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblOdds;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblPayout;
    }
}

