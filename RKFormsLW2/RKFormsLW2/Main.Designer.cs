namespace RKFormsLW2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.readfileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filenameL = new System.Windows.Forms.Label();
            this.filetypeL = new System.Windows.Forms.Label();
            this.functionL = new System.Windows.Forms.Label();
            this.drawfuncBtn = new System.Windows.Forms.Button();
            this.xyDGV = new System.Windows.Forms.DataGridView();
            this.xy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xy7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.savepointsBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.xyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // readfileBtn
            // 
            this.readfileBtn.Location = new System.Drawing.Point(17, 30);
            this.readfileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readfileBtn.Name = "readfileBtn";
            this.readfileBtn.Size = new System.Drawing.Size(140, 59);
            this.readfileBtn.TabIndex = 0;
            this.readfileBtn.Text = "Прочитать файл";
            this.readfileBtn.UseVisualStyleBackColor = true;
            this.readfileBtn.Click += new System.EventHandler(this.readfileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt";
            // 
            // filenameL
            // 
            this.filenameL.AutoSize = true;
            this.filenameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameL.Location = new System.Drawing.Point(177, 15);
            this.filenameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filenameL.Name = "filenameL";
            this.filenameL.Size = new System.Drawing.Size(132, 25);
            this.filenameL.TabIndex = 1;
            this.filenameL.Text = "Имя файла: ";
            // 
            // filetypeL
            // 
            this.filetypeL.AutoSize = true;
            this.filetypeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filetypeL.Location = new System.Drawing.Point(184, 47);
            this.filetypeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filetypeL.Name = "filetypeL";
            this.filetypeL.Size = new System.Drawing.Size(144, 25);
            this.filetypeL.TabIndex = 2;
            this.filetypeL.Text = "Тип файла: txt";
            // 
            // functionL
            // 
            this.functionL.AutoSize = true;
            this.functionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionL.Location = new System.Drawing.Point(207, 78);
            this.functionL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.functionL.Name = "functionL";
            this.functionL.Size = new System.Drawing.Size(101, 25);
            this.functionL.TabIndex = 3;
            this.functionL.Text = "Функция:";
            // 
            // drawfuncBtn
            // 
            this.drawfuncBtn.Location = new System.Drawing.Point(429, 182);
            this.drawfuncBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawfuncBtn.Name = "drawfuncBtn";
            this.drawfuncBtn.Size = new System.Drawing.Size(296, 30);
            this.drawfuncBtn.TabIndex = 4;
            this.drawfuncBtn.Text = "Построить график функции";
            this.drawfuncBtn.UseVisualStyleBackColor = true;
            this.drawfuncBtn.Click += new System.EventHandler(this.drawfuncBtn_Click);
            // 
            // xyDGV
            // 
            this.xyDGV.AllowUserToResizeColumns = false;
            this.xyDGV.AllowUserToResizeRows = false;
            this.xyDGV.BackgroundColor = System.Drawing.Color.White;
            this.xyDGV.ColumnHeadersHeight = 29;
            this.xyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.xyDGV.ColumnHeadersVisible = false;
            this.xyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xy,
            this.xy1,
            this.xy2,
            this.xy3,
            this.xy4,
            this.xy5,
            this.xy6,
            this.xy7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xyDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.xyDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.xyDGV.Location = new System.Drawing.Point(16, 117);
            this.xyDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xyDGV.Name = "xyDGV";
            this.xyDGV.RowHeadersVisible = false;
            this.xyDGV.RowHeadersWidth = 51;
            this.xyDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.xyDGV.ShowEditingIcon = false;
            this.xyDGV.Size = new System.Drawing.Size(771, 58);
            this.xyDGV.TabIndex = 5;
            // 
            // xy
            // 
            this.xy.HeaderText = "";
            this.xy.MinimumWidth = 6;
            this.xy.Name = "xy";
            this.xy.Width = 50;
            // 
            // xy1
            // 
            this.xy1.HeaderText = "1";
            this.xy1.MinimumWidth = 6;
            this.xy1.Name = "xy1";
            this.xy1.Width = 75;
            // 
            // xy2
            // 
            this.xy2.HeaderText = "2";
            this.xy2.MinimumWidth = 6;
            this.xy2.Name = "xy2";
            this.xy2.Width = 75;
            // 
            // xy3
            // 
            this.xy3.HeaderText = "3";
            this.xy3.MinimumWidth = 6;
            this.xy3.Name = "xy3";
            this.xy3.Width = 75;
            // 
            // xy4
            // 
            this.xy4.HeaderText = "4";
            this.xy4.MinimumWidth = 6;
            this.xy4.Name = "xy4";
            this.xy4.Width = 75;
            // 
            // xy5
            // 
            this.xy5.HeaderText = "5";
            this.xy5.MinimumWidth = 6;
            this.xy5.Name = "xy5";
            this.xy5.Width = 75;
            // 
            // xy6
            // 
            this.xy6.HeaderText = "6";
            this.xy6.MinimumWidth = 6;
            this.xy6.Name = "xy6";
            this.xy6.Width = 75;
            // 
            // xy7
            // 
            this.xy7.HeaderText = "7";
            this.xy7.MinimumWidth = 6;
            this.xy7.Name = "xy7";
            this.xy7.Width = 75;
            // 
            // MainChart
            // 
            chartArea1.Name = "MainChartArea";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(17, 219);
            this.MainChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "MainChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend";
            series1.Name = "Series";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(1100, 388);
            this.MainChart.TabIndex = 6;
            this.MainChart.Text = "graphic";
            // 
            // savepointsBtn
            // 
            this.savepointsBtn.Location = new System.Drawing.Point(456, 614);
            this.savepointsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savepointsBtn.Name = "savepointsBtn";
            this.savepointsBtn.Size = new System.Drawing.Size(219, 57);
            this.savepointsBtn.TabIndex = 7;
            this.savepointsBtn.Text = "Сохранить точки в файл";
            this.savepointsBtn.UseVisualStyleBackColor = true;
            this.savepointsBtn.Click += new System.EventHandler(this.savepointsBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.Maroon;
            this.clearBtn.Location = new System.Drawing.Point(280, 182);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(141, 30);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 682);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.savepointsBtn);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.xyDGV);
            this.Controls.Add(this.drawfuncBtn);
            this.Controls.Add(this.functionL);
            this.Controls.Add(this.filetypeL);
            this.Controls.Add(this.filenameL);
            this.Controls.Add(this.readfileBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Графики";
            ((System.ComponentModel.ISupportInitialize)(this.xyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readfileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label filenameL;
        private System.Windows.Forms.Label filetypeL;
        private System.Windows.Forms.Label functionL;
        private System.Windows.Forms.Button drawfuncBtn;
        private System.Windows.Forms.DataGridView xyDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy3;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy4;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy5;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy6;
        private System.Windows.Forms.DataGridViewTextBoxColumn xy7;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button savepointsBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

