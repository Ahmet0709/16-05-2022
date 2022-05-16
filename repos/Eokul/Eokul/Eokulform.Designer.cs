namespace Eokul
{
    partial class Eokulform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabctrleokul = new System.Windows.Forms.TabControl();
            this.tabana = new System.Windows.Forms.TabPage();
            this.tabogrenci = new System.Windows.Forms.TabPage();
            this.tabnot = new System.Windows.Forms.TabPage();
            this.tabders = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabctrleokul.SuspendLayout();
            this.tabana.SuspendLayout();
            this.tabogrenci.SuspendLayout();
            this.tabnot.SuspendLayout();
            this.tabders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrleokul
            // 
            this.tabctrleokul.Controls.Add(this.tabana);
            this.tabctrleokul.Controls.Add(this.tabogrenci);
            this.tabctrleokul.Controls.Add(this.tabnot);
            this.tabctrleokul.Controls.Add(this.tabders);
            this.tabctrleokul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrleokul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabctrleokul.Location = new System.Drawing.Point(0, 0);
            this.tabctrleokul.Name = "tabctrleokul";
            this.tabctrleokul.SelectedIndex = 0;
            this.tabctrleokul.Size = new System.Drawing.Size(789, 278);
            this.tabctrleokul.TabIndex = 0;
            this.tabctrleokul.SelectedIndexChanged += new System.EventHandler(this.tabctrleokul_SelectedIndexChanged);
            // 
            // tabana
            // 
            this.tabana.Controls.Add(this.dataGridView1);
            this.tabana.Location = new System.Drawing.Point(4, 34);
            this.tabana.Name = "tabana";
            this.tabana.Padding = new System.Windows.Forms.Padding(3);
            this.tabana.Size = new System.Drawing.Size(781, 240);
            this.tabana.TabIndex = 0;
            this.tabana.Text = "Ana sayfa";
            this.tabana.UseVisualStyleBackColor = true;
            // 
            // tabogrenci
            // 
            this.tabogrenci.Controls.Add(this.dataGridView2);
            this.tabogrenci.Location = new System.Drawing.Point(4, 34);
            this.tabogrenci.Name = "tabogrenci";
            this.tabogrenci.Padding = new System.Windows.Forms.Padding(3);
            this.tabogrenci.Size = new System.Drawing.Size(781, 240);
            this.tabogrenci.TabIndex = 1;
            this.tabogrenci.Text = "Öğrenci işlemleri";
            this.tabogrenci.UseVisualStyleBackColor = true;
            // 
            // tabnot
            // 
            this.tabnot.Controls.Add(this.dataGridView3);
            this.tabnot.Location = new System.Drawing.Point(4, 34);
            this.tabnot.Name = "tabnot";
            this.tabnot.Size = new System.Drawing.Size(781, 240);
            this.tabnot.TabIndex = 2;
            this.tabnot.Text = "Not işlemleri";
            this.tabnot.UseVisualStyleBackColor = true;
            // 
            // tabders
            // 
            this.tabders.Controls.Add(this.dataGridView4);
            this.tabders.Location = new System.Drawing.Point(4, 34);
            this.tabders.Name = "tabders";
            this.tabders.Size = new System.Drawing.Size(781, 240);
            this.tabders.TabIndex = 3;
            this.tabders.Text = "Ders işlemleri";
            this.tabders.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.Location = new System.Drawing.Point(8, 3);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView4.Location = new System.Drawing.Point(8, 3);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(240, 150);
            this.dataGridView4.TabIndex = 2;
            // 
            // Eokulform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 278);
            this.Controls.Add(this.tabctrleokul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Eokulform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Okul Programı";
            this.tabctrleokul.ResumeLayout(false);
            this.tabana.ResumeLayout(false);
            this.tabogrenci.ResumeLayout(false);
            this.tabnot.ResumeLayout(false);
            this.tabders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrleokul;
        private System.Windows.Forms.TabPage tabana;
        private System.Windows.Forms.TabPage tabogrenci;
        private System.Windows.Forms.TabPage tabnot;
        private System.Windows.Forms.TabPage tabders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

