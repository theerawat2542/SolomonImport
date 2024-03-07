namespace SolomonImport
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
            this.components = new System.ComponentModel.Container();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ccodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wipidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procLineDecrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blankTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAPTagListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUEApplicationDataSet = new SolomonImport.SUEApplicationDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.CboSheet = new System.Windows.Forms.ComboBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.sAP_TagListTableAdapter = new SolomonImport.SUEApplicationDataSetTableAdapters.SAP_TagListTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWipid = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPTagListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUEApplicationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBrowse.Location = new System.Drawing.Point(714, 384);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccodeDataGridViewTextBoxColumn,
            this.stationDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn,
            this.tagnumberDataGridViewTextBoxColumn,
            this.wipidDataGridViewTextBoxColumn,
            this.countdateDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.itemdescrDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.jobnumberDataGridViewTextBoxColumn,
            this.productiondateDataGridViewTextBoxColumn,
            this.procLineDecrDataGridViewTextBoxColumn,
            this.blankTagDataGridViewTextBoxColumn,
            this.invtTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sAPTagListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 303);
            this.dataGridView1.TabIndex = 1;
            // 
            // ccodeDataGridViewTextBoxColumn
            // 
            this.ccodeDataGridViewTextBoxColumn.DataPropertyName = "Ccode";
            this.ccodeDataGridViewTextBoxColumn.HeaderText = "Ccode";
            this.ccodeDataGridViewTextBoxColumn.Name = "ccodeDataGridViewTextBoxColumn";
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "station";
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "line";
            this.lineDataGridViewTextBoxColumn.HeaderText = "line";
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            // 
            // tagnumberDataGridViewTextBoxColumn
            // 
            this.tagnumberDataGridViewTextBoxColumn.DataPropertyName = "tagnumber";
            this.tagnumberDataGridViewTextBoxColumn.HeaderText = "tagnumber";
            this.tagnumberDataGridViewTextBoxColumn.Name = "tagnumberDataGridViewTextBoxColumn";
            // 
            // wipidDataGridViewTextBoxColumn
            // 
            this.wipidDataGridViewTextBoxColumn.DataPropertyName = "wipid";
            this.wipidDataGridViewTextBoxColumn.HeaderText = "wipid";
            this.wipidDataGridViewTextBoxColumn.Name = "wipidDataGridViewTextBoxColumn";
            // 
            // countdateDataGridViewTextBoxColumn
            // 
            this.countdateDataGridViewTextBoxColumn.DataPropertyName = "countdate";
            this.countdateDataGridViewTextBoxColumn.HeaderText = "countdate";
            this.countdateDataGridViewTextBoxColumn.Name = "countdateDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // itemdescrDataGridViewTextBoxColumn
            // 
            this.itemdescrDataGridViewTextBoxColumn.DataPropertyName = "itemdescr";
            this.itemdescrDataGridViewTextBoxColumn.HeaderText = "itemdescr";
            this.itemdescrDataGridViewTextBoxColumn.Name = "itemdescrDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // jobnumberDataGridViewTextBoxColumn
            // 
            this.jobnumberDataGridViewTextBoxColumn.DataPropertyName = "jobnumber";
            this.jobnumberDataGridViewTextBoxColumn.HeaderText = "jobnumber";
            this.jobnumberDataGridViewTextBoxColumn.Name = "jobnumberDataGridViewTextBoxColumn";
            // 
            // productiondateDataGridViewTextBoxColumn
            // 
            this.productiondateDataGridViewTextBoxColumn.DataPropertyName = "productiondate";
            this.productiondateDataGridViewTextBoxColumn.HeaderText = "productiondate";
            this.productiondateDataGridViewTextBoxColumn.Name = "productiondateDataGridViewTextBoxColumn";
            // 
            // procLineDecrDataGridViewTextBoxColumn
            // 
            this.procLineDecrDataGridViewTextBoxColumn.DataPropertyName = "ProcLineDecr";
            this.procLineDecrDataGridViewTextBoxColumn.HeaderText = "ProcLineDecr";
            this.procLineDecrDataGridViewTextBoxColumn.Name = "procLineDecrDataGridViewTextBoxColumn";
            // 
            // blankTagDataGridViewTextBoxColumn
            // 
            this.blankTagDataGridViewTextBoxColumn.DataPropertyName = "BlankTag";
            this.blankTagDataGridViewTextBoxColumn.HeaderText = "BlankTag";
            this.blankTagDataGridViewTextBoxColumn.Name = "blankTagDataGridViewTextBoxColumn";
            // 
            // invtTypeDataGridViewTextBoxColumn
            // 
            this.invtTypeDataGridViewTextBoxColumn.DataPropertyName = "InvtType";
            this.invtTypeDataGridViewTextBoxColumn.HeaderText = "InvtType";
            this.invtTypeDataGridViewTextBoxColumn.Name = "invtTypeDataGridViewTextBoxColumn";
            // 
            // sAPTagListBindingSource
            // 
            this.sAPTagListBindingSource.DataMember = "SAP_TagList";
            this.sAPTagListBindingSource.DataSource = this.sUEApplicationDataSet;
            // 
            // sUEApplicationDataSet
            // 
            this.sUEApplicationDataSet.DataSetName = "SUEApplicationDataSet";
            this.sUEApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(13, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            // 
            // CboSheet
            // 
            this.CboSheet.FormattingEnabled = true;
            this.CboSheet.Location = new System.Drawing.Point(71, 421);
            this.CboSheet.Name = "CboSheet";
            this.CboSheet.Size = new System.Drawing.Size(121, 21);
            this.CboSheet.TabIndex = 3;
            this.CboSheet.SelectedIndexChanged += new System.EventHandler(this.CboSheet_SelectedIndexChanged);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(71, 386);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(637, 20);
            this.txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.LightGreen;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Location = new System.Drawing.Point(198, 421);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(69, 21);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // sAP_TagListTableAdapter
            // 
            this.sAP_TagListTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Import data ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delete data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "wipid";
            // 
            // txtWipid
            // 
            this.txtWipid.Location = new System.Drawing.Point(71, 491);
            this.txtWipid.Name = "txtWipid";
            this.txtWipid.Size = new System.Drawing.Size(121, 20);
            this.txtWipid.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(198, 489);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "ตรวจสอบข้อมูลในตารางก่อนทำการ Import ทุกครั้ง";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtWipid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.CboSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read excel *.xls or *.xlsx";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAPTagListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUEApplicationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboSheet;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private SUEApplicationDataSet sUEApplicationDataSet;
        private System.Windows.Forms.BindingSource sAPTagListBindingSource;
        private SUEApplicationDataSetTableAdapters.SAP_TagListTableAdapter sAP_TagListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wipidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procLineDecrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blankTagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWipid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
    }
}

