
namespace marketsatisotomasyonu.Forms
{
    partial class FormSatisRapor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detayButton = new FontAwesome.Sharp.IconButton();
            this.seciliButton = new FontAwesome.Sharp.IconButton();
            this.haftaButton = new FontAwesome.Sharp.IconButton();
            this.dunButton = new FontAwesome.Sharp.IconButton();
            this.bugunButton = new FontAwesome.Sharp.IconButton();
            this.raporButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.raporButton);
            this.panel1.Controls.Add(this.detayButton);
            this.panel1.Controls.Add(this.seciliButton);
            this.panel1.Controls.Add(this.haftaButton);
            this.panel1.Controls.Add(this.dunButton);
            this.panel1.Controls.Add(this.bugunButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 80);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 44);
            this.panel2.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(275, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 326);
            this.panel3.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // detayButton
            // 
            this.detayButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.detayButton.FlatAppearance.BorderSize = 0;
            this.detayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detayButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.detayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detayButton.ForeColor = System.Drawing.Color.White;
            this.detayButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.detayButton.IconColor = System.Drawing.Color.White;
            this.detayButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detayButton.IconSize = 60;
            this.detayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detayButton.Location = new System.Drawing.Point(660, 0);
            this.detayButton.Name = "detayButton";
            this.detayButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.detayButton.Size = new System.Drawing.Size(194, 80);
            this.detayButton.TabIndex = 27;
            this.detayButton.Text = "Fatura Detay";
            this.detayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detayButton.UseVisualStyleBackColor = true;
            this.detayButton.Click += new System.EventHandler(this.detayButton_Click);
            // 
            // seciliButton
            // 
            this.seciliButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.seciliButton.FlatAppearance.BorderSize = 0;
            this.seciliButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seciliButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.seciliButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seciliButton.ForeColor = System.Drawing.Color.White;
            this.seciliButton.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
            this.seciliButton.IconColor = System.Drawing.Color.White;
            this.seciliButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.seciliButton.IconSize = 60;
            this.seciliButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seciliButton.Location = new System.Drawing.Point(482, 0);
            this.seciliButton.Name = "seciliButton";
            this.seciliButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.seciliButton.Size = new System.Drawing.Size(178, 80);
            this.seciliButton.TabIndex = 26;
            this.seciliButton.Text = "Seçili Tarihler Arası";
            this.seciliButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.seciliButton.UseVisualStyleBackColor = true;
            this.seciliButton.Click += new System.EventHandler(this.seciliButton_Click);
            // 
            // haftaButton
            // 
            this.haftaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.haftaButton.FlatAppearance.BorderSize = 0;
            this.haftaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.haftaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.haftaButton.ForeColor = System.Drawing.Color.White;
            this.haftaButton.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.haftaButton.IconColor = System.Drawing.Color.White;
            this.haftaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.haftaButton.IconSize = 60;
            this.haftaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.haftaButton.Location = new System.Drawing.Point(325, 0);
            this.haftaButton.Name = "haftaButton";
            this.haftaButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.haftaButton.Size = new System.Drawing.Size(157, 80);
            this.haftaButton.TabIndex = 25;
            this.haftaButton.Text = "Son hafta";
            this.haftaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.haftaButton.UseVisualStyleBackColor = true;
            this.haftaButton.Click += new System.EventHandler(this.haftaButton_Click);
            // 
            // dunButton
            // 
            this.dunButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.dunButton.FlatAppearance.BorderSize = 0;
            this.dunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dunButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dunButton.ForeColor = System.Drawing.Color.White;
            this.dunButton.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.dunButton.IconColor = System.Drawing.Color.White;
            this.dunButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dunButton.IconSize = 60;
            this.dunButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dunButton.Location = new System.Drawing.Point(160, 0);
            this.dunButton.Name = "dunButton";
            this.dunButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dunButton.Size = new System.Drawing.Size(165, 80);
            this.dunButton.TabIndex = 24;
            this.dunButton.Text = "Önceki Gün";
            this.dunButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dunButton.UseVisualStyleBackColor = true;
            this.dunButton.Click += new System.EventHandler(this.dunButton_Click);
            // 
            // bugunButton
            // 
            this.bugunButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.bugunButton.FlatAppearance.BorderSize = 0;
            this.bugunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bugunButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bugunButton.ForeColor = System.Drawing.Color.White;
            this.bugunButton.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.bugunButton.IconColor = System.Drawing.Color.White;
            this.bugunButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bugunButton.IconSize = 60;
            this.bugunButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bugunButton.Location = new System.Drawing.Point(0, 0);
            this.bugunButton.Name = "bugunButton";
            this.bugunButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bugunButton.Size = new System.Drawing.Size(160, 80);
            this.bugunButton.TabIndex = 23;
            this.bugunButton.Text = "Bugün";
            this.bugunButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bugunButton.UseVisualStyleBackColor = true;
            this.bugunButton.Click += new System.EventHandler(this.bugunButton_Click);
            // 
            // raporButton
            // 
            this.raporButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.raporButton.FlatAppearance.BorderSize = 0;
            this.raporButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raporButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.raporButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporButton.ForeColor = System.Drawing.Color.White;
            this.raporButton.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.raporButton.IconColor = System.Drawing.Color.White;
            this.raporButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.raporButton.IconSize = 60;
            this.raporButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raporButton.Location = new System.Drawing.Point(854, 0);
            this.raporButton.Name = "raporButton";
            this.raporButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.raporButton.Size = new System.Drawing.Size(159, 80);
            this.raporButton.TabIndex = 28;
            this.raporButton.Text = "Rapor";
            this.raporButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.raporButton.UseVisualStyleBackColor = true;
            this.raporButton.Click += new System.EventHandler(this.raporButton_Click);
            // 
            // FormSatisRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSatisRapor";
            this.Text = "FormSatisRapor";
            this.Load += new System.EventHandler(this.FormSatisRapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton detayButton;
        private FontAwesome.Sharp.IconButton seciliButton;
        private FontAwesome.Sharp.IconButton haftaButton;
        private FontAwesome.Sharp.IconButton dunButton;
        private FontAwesome.Sharp.IconButton bugunButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton raporButton;
    }
}