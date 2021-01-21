
namespace marketsatisotomasyonu.Forms
{
    partial class FormRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRapor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.yazdirButton = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.karLabel = new System.Windows.Forms.Label();
            this.ppDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdPrint = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.karLabel);
            this.panel1.Controls.Add(this.yazdirButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 34;
            // 
            // yazdirButton
            // 
            this.yazdirButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.yazdirButton.FlatAppearance.BorderSize = 0;
            this.yazdirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yazdirButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazdirButton.ForeColor = System.Drawing.Color.White;
            this.yazdirButton.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.yazdirButton.IconColor = System.Drawing.Color.White;
            this.yazdirButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yazdirButton.IconSize = 60;
            this.yazdirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yazdirButton.Location = new System.Drawing.Point(0, 0);
            this.yazdirButton.Name = "yazdirButton";
            this.yazdirButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.yazdirButton.Size = new System.Drawing.Size(160, 80);
            this.yazdirButton.TabIndex = 23;
            this.yazdirButton.Text = "Yazdır";
            this.yazdirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yazdirButton.UseVisualStyleBackColor = true;
            this.yazdirButton.Click += new System.EventHandler(this.yazdirButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 406);
            this.dataGridView1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 44);
            this.panel2.TabIndex = 33;
            // 
            // karLabel
            // 
            this.karLabel.AutoSize = true;
            this.karLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karLabel.ForeColor = System.Drawing.Color.White;
            this.karLabel.Location = new System.Drawing.Point(364, 26);
            this.karLabel.Name = "karLabel";
            this.karLabel.Size = new System.Drawing.Size(141, 25);
            this.karLabel.TabIndex = 24;
            this.karLabel.Text = "Toplam Kar:";
            // 
            // ppDialog
            // 
            this.ppDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDialog.Document = this.pdPrint;
            this.ppDialog.Enabled = true;
            this.ppDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDialog.Icon")));
            this.ppDialog.Name = "ppDialog";
            this.ppDialog.Visible = false;
            // 
            // pdPrint
            // 
            this.pdPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrint_PrintPage);
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "FormRapor";
            this.Text = "FormRapor";
            this.Load += new System.EventHandler(this.FormRapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton yazdirButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label karLabel;
        private System.Windows.Forms.PrintPreviewDialog ppDialog;
        private System.Drawing.Printing.PrintDocument pdPrint;
    }
}