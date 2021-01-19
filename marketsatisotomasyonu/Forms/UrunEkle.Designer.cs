
namespace marketsatisotomasyonu.Forms
{
    partial class UrunEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guncelleButton = new FontAwesome.Sharp.IconButton();
            this.ekleButton = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adiText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guncelleButton);
            this.panel1.Controls.Add(this.ekleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 100);
            this.panel1.TabIndex = 0;
            // 
            // guncelleButton
            // 
            this.guncelleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.guncelleButton.FlatAppearance.BorderSize = 0;
            this.guncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.guncelleButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButton.ForeColor = System.Drawing.Color.White;
            this.guncelleButton.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.guncelleButton.IconColor = System.Drawing.Color.White;
            this.guncelleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guncelleButton.IconSize = 60;
            this.guncelleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelleButton.Location = new System.Drawing.Point(172, 0);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.guncelleButton.Size = new System.Drawing.Size(181, 100);
            this.guncelleButton.TabIndex = 27;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // ekleButton
            // 
            this.ekleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ekleButton.FlatAppearance.BorderSize = 0;
            this.ekleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.ForeColor = System.Drawing.Color.White;
            this.ekleButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ekleButton.IconColor = System.Drawing.Color.White;
            this.ekleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ekleButton.IconSize = 60;
            this.ekleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleButton.Location = new System.Drawing.Point(0, 0);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ekleButton.Size = new System.Drawing.Size(172, 100);
            this.ekleButton.TabIndex = 25;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click_1);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(300, 280);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adiText
            // 
            this.adiText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adiText.Location = new System.Drawing.Point(0, 59);
            this.adiText.Name = "adiText";
            this.adiText.Size = new System.Drawing.Size(362, 20);
            this.adiText.TabIndex = 2;
            // 
            // idText
            // 
            this.idText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.idText.Location = new System.Drawing.Point(0, 39);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(362, 20);
            this.idText.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.idText);
            this.panel2.Controls.Add(this.adiText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 79);
            this.panel2.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButton1.FlatAppearance.BorderSize = 2;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(81, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 27);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kategoriler";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.radioButton2.FlatAppearance.BorderSize = 2;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(209, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 27);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Markalar";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 280);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(62, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 280);
            this.panel4.TabIndex = 8;
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(362, 459);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ekleButton;
        private FontAwesome.Sharp.IconButton guncelleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox adiText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}