
namespace Restorant_Uygulamasi
{
    partial class Onerileri_Goruntule_Admin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restorantDataSet1 = new Restorant_Uygulamasi.RestorantDataSet1();
            this.onerilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onerilerTableAdapter = new Restorant_Uygulamasi.RestorantDataSet1TableAdapters.OnerilerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onerilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button2.Location = new System.Drawing.Point(3, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(403, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(394, 53);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(403, 62);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(394, 53);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.konuDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.onerilerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 134);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // restorantDataSet1
            // 
            this.restorantDataSet1.DataSetName = "RestorantDataSet1";
            this.restorantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onerilerBindingSource
            // 
            this.onerilerBindingSource.DataMember = "Oneriler";
            this.onerilerBindingSource.DataSource = this.restorantDataSet1;
            // 
            // onerilerTableAdapter
            // 
            this.onerilerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "Konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "Konu";
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(12, 124);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(776, 232);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            // 
            // Onerileri_Goruntule_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Onerileri_Goruntule_Admin";
            this.Text = "Onerileri_Goruntule_Admin";
            this.Load += new System.EventHandler(this.Onerileri_Goruntule_Admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onerilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestorantDataSet1 restorantDataSet1;
        private System.Windows.Forms.BindingSource onerilerBindingSource;
        private RestorantDataSet1TableAdapters.OnerilerTableAdapter onerilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}