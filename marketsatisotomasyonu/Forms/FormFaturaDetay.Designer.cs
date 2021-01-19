
namespace marketsatisotomasyonu.Forms
{
    partial class FormFaturaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturaDetay));
            this.panel2 = new System.Windows.Forms.Panel();
            this.kasaLabel = new System.Windows.Forms.Label();
            this.fisnoLabel = new System.Windows.Forms.Label();
            this.tarihLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tutarLabel = new System.Windows.Forms.Label();
            this.yazdirButton = new FontAwesome.Sharp.IconButton();
            this.pdPrint = new System.Drawing.Printing.PrintDocument();
            this.ppDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kasaLabel);
            this.panel2.Controls.Add(this.fisnoLabel);
            this.panel2.Controls.Add(this.tarihLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 44);
            this.panel2.TabIndex = 29;
            // 
            // kasaLabel
            // 
            this.kasaLabel.AutoSize = true;
            this.kasaLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasaLabel.ForeColor = System.Drawing.Color.White;
            this.kasaLabel.Location = new System.Drawing.Point(693, 15);
            this.kasaLabel.Name = "kasaLabel";
            this.kasaLabel.Size = new System.Drawing.Size(46, 16);
            this.kasaLabel.TabIndex = 27;
            this.kasaLabel.Text = "label1";
            // 
            // fisnoLabel
            // 
            this.fisnoLabel.AutoSize = true;
            this.fisnoLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fisnoLabel.ForeColor = System.Drawing.Color.White;
            this.fisnoLabel.Location = new System.Drawing.Point(573, 15);
            this.fisnoLabel.Name = "fisnoLabel";
            this.fisnoLabel.Size = new System.Drawing.Size(49, 16);
            this.fisnoLabel.TabIndex = 1;
            this.fisnoLabel.Text = "Fiş No:";
            // 
            // tarihLabel
            // 
            this.tarihLabel.AutoSize = true;
            this.tarihLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihLabel.ForeColor = System.Drawing.Color.White;
            this.tarihLabel.Location = new System.Drawing.Point(301, 15);
            this.tarihLabel.Name = "tarihLabel";
            this.tarihLabel.Size = new System.Drawing.Size(39, 16);
            this.tarihLabel.TabIndex = 0;
            this.tarihLabel.Text = "tarih";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 406);
            this.panel3.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(841, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tutarLabel);
            this.panel1.Controls.Add(this.yazdirButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 80);
            this.panel1.TabIndex = 31;
            // 
            // tutarLabel
            // 
            this.tutarLabel.AutoSize = true;
            this.tutarLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutarLabel.ForeColor = System.Drawing.Color.White;
            this.tutarLabel.Location = new System.Drawing.Point(677, 34);
            this.tutarLabel.Name = "tutarLabel";
            this.tutarLabel.Size = new System.Drawing.Size(90, 16);
            this.tutarLabel.TabIndex = 26;
            this.tutarLabel.Text = "toplam tutar";
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
            // pdPrint
            // 
            this.pdPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrint_PrintPage);
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
            // FormFaturaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormFaturaDetay";
            this.Text = "FormFaturaDetay";
            this.Load += new System.EventHandler(this.FormFaturaDetay_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton yazdirButton;
        private System.Windows.Forms.Label kasaLabel;
        private System.Windows.Forms.Label tutarLabel;
        private System.Windows.Forms.Label fisnoLabel;
        private System.Windows.Forms.Label tarihLabel;
        private System.Drawing.Printing.PrintDocument pdPrint;
        private System.Windows.Forms.PrintPreviewDialog ppDialog;
    }
}