
namespace Cinema_Application
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxBusy = new System.Windows.Forms.ListBox();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.NumericBusy = new System.Windows.Forms.NumericUpDown();
            this.NumericSold = new System.Windows.Forms.NumericUpDown();
            this.NumericEmpty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBusy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(882, 496);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listBoxBusy
            // 
            this.listBoxBusy.FormattingEnabled = true;
            this.listBoxBusy.ItemHeight = 20;
            this.listBoxBusy.Location = new System.Drawing.Point(889, 12);
            this.listBoxBusy.Name = "listBoxBusy";
            this.listBoxBusy.Size = new System.Drawing.Size(281, 164);
            this.listBoxBusy.TabIndex = 1;
            // 
            // BtnBuy
            // 
            this.BtnBuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuy.Location = new System.Drawing.Point(889, 182);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(135, 85);
            this.BtnBuy.TabIndex = 2;
            this.BtnBuy.Text = "Buy";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.Location = new System.Drawing.Point(1035, 182);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(135, 85);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // NumericBusy
            // 
            this.NumericBusy.Enabled = false;
            this.NumericBusy.Location = new System.Drawing.Point(1020, 342);
            this.NumericBusy.Name = "NumericBusy";
            this.NumericBusy.Size = new System.Drawing.Size(150, 27);
            this.NumericBusy.TabIndex = 4;
            // 
            // NumericSold
            // 
            this.NumericSold.Enabled = false;
            this.NumericSold.Location = new System.Drawing.Point(1020, 375);
            this.NumericSold.Name = "NumericSold";
            this.NumericSold.Size = new System.Drawing.Size(150, 27);
            this.NumericSold.TabIndex = 5;
            // 
            // NumericEmpty
            // 
            this.NumericEmpty.Enabled = false;
            this.NumericEmpty.Location = new System.Drawing.Point(1020, 408);
            this.NumericEmpty.Name = "NumericEmpty";
            this.NumericEmpty.Size = new System.Drawing.Size(150, 27);
            this.NumericEmpty.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(919, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(953, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(938, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Empty:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericEmpty);
            this.Controls.Add(this.NumericSold);
            this.Controls.Add(this.NumericBusy);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.listBoxBusy);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To Cinema Application";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.NumericBusy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxBusy;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.NumericUpDown NumericBusy;
        private System.Windows.Forms.NumericUpDown NumericSold;
        private System.Windows.Forms.NumericUpDown NumericEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

