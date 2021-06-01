
namespace SyncfusionCharts
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
            this.button1 = new System.Windows.Forms.Button();
            this.cChartData_GRID = new System.Windows.Forms.DataGridView();
            this.cColLabel_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValueCol_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChartType_CB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cChartData_GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1097, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cChartData_GRID
            // 
            this.cChartData_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cChartData_GRID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cColLabel_COL,
            this.cValueCol_COL});
            this.cChartData_GRID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cChartData_GRID.Location = new System.Drawing.Point(0, 28);
            this.cChartData_GRID.Name = "cChartData_GRID";
            this.cChartData_GRID.RowHeadersWidth = 51;
            this.cChartData_GRID.RowTemplate.Height = 29;
            this.cChartData_GRID.Size = new System.Drawing.Size(1097, 551);
            this.cChartData_GRID.TabIndex = 1;
            // 
            // cColLabel_COL
            // 
            this.cColLabel_COL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cColLabel_COL.HeaderText = "Label";
            this.cColLabel_COL.MinimumWidth = 6;
            this.cColLabel_COL.Name = "cColLabel_COL";
            // 
            // cValueCol_COL
            // 
            this.cValueCol_COL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cValueCol_COL.HeaderText = "Value";
            this.cValueCol_COL.MinimumWidth = 6;
            this.cValueCol_COL.Name = "cValueCol_COL";
            // 
            // cChartType_CB
            // 
            this.cChartType_CB.Dock = System.Windows.Forms.DockStyle.Top;
            this.cChartType_CB.FormattingEnabled = true;
            this.cChartType_CB.Items.AddRange(new object[] {
            "Line",
            "Bar_Clustered",
            "Pie"});
            this.cChartType_CB.Location = new System.Drawing.Point(0, 0);
            this.cChartType_CB.Name = "cChartType_CB";
            this.cChartType_CB.Size = new System.Drawing.Size(1097, 28);
            this.cChartType_CB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 628);
            this.Controls.Add(this.cChartData_GRID);
            this.Controls.Add(this.cChartType_CB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cChartData_GRID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cChartData_GRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColLabel_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValueCol_COL;
        private System.Windows.Forms.ComboBox cChartType_CB;
    }
}

