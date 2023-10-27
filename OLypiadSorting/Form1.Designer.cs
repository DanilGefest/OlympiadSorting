namespace OLypiadSorting
{
    partial class SortingApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingApp));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationCountBox = new System.Windows.Forms.ToolStripTextBox();
            this.минимальноеЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minValueBox = new System.Windows.Forms.ToolStripTextBox();
            this.максимальноеЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxValueBox = new System.Windows.Forms.ToolStripTextBox();
            this.generateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BubbleBox = new System.Windows.Forms.CheckBox();
            this.InsertBox = new System.Windows.Forms.CheckBox();
            this.ShakerBox = new System.Windows.Forms.CheckBox();
            this.qickSort = new System.Windows.Forms.CheckBox();
            this.BOGOSort = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertTime = new System.Windows.Forms.Label();
            this.shakerTime = new System.Windows.Forms.Label();
            this.quickTime = new System.Windows.Forms.Label();
            this.bogoTime = new System.Windows.Forms.Label();
            this.bubbleTime = new System.Windows.Forms.Label();
            this.bubbleIterations = new System.Windows.Forms.Label();
            this.bogoIterations = new System.Windows.Forms.Label();
            this.quickIterations = new System.Windows.Forms.Label();
            this.shakerIterations = new System.Windows.Forms.Label();
            this.insertIterations = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ascendingBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(297, 714);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.startToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.GenerateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // GenerateToolStripMenuItem
            // 
            this.GenerateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колвоЭлементовToolStripMenuItem,
            this.минимальноеЗначениеToolStripMenuItem,
            this.максимальноеЗначениеToolStripMenuItem,
            this.generateButton});
            this.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem";
            this.GenerateToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.GenerateToolStripMenuItem.Text = "Сгенерировать ";
            // 
            // колвоЭлементовToolStripMenuItem
            // 
            this.колвоЭлементовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generationCountBox});
            this.колвоЭлементовToolStripMenuItem.Name = "колвоЭлементовToolStripMenuItem";
            this.колвоЭлементовToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.колвоЭлементовToolStripMenuItem.Text = "Кол-во Элементов";
            // 
            // generationCountBox
            // 
            this.generationCountBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generationCountBox.Name = "generationCountBox";
            this.generationCountBox.Size = new System.Drawing.Size(100, 31);
            // 
            // минимальноеЗначениеToolStripMenuItem
            // 
            this.минимальноеЗначениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minValueBox});
            this.минимальноеЗначениеToolStripMenuItem.Name = "минимальноеЗначениеToolStripMenuItem";
            this.минимальноеЗначениеToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.минимальноеЗначениеToolStripMenuItem.Text = "Минимальное значение";
            // 
            // minValueBox
            // 
            this.minValueBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minValueBox.Name = "minValueBox";
            this.minValueBox.Size = new System.Drawing.Size(100, 31);
            // 
            // максимальноеЗначениеToolStripMenuItem
            // 
            this.максимальноеЗначениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxValueBox});
            this.максимальноеЗначениеToolStripMenuItem.Name = "максимальноеЗначениеToolStripMenuItem";
            this.максимальноеЗначениеToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.максимальноеЗначениеToolStripMenuItem.Text = "Максимальное значение";
            // 
            // maxValueBox
            // 
            this.maxValueBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maxValueBox.Name = "maxValueBox";
            this.maxValueBox.Size = new System.Drawing.Size(100, 31);
            // 
            // generateButton
            // 
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(316, 34);
            this.generateButton.Text = "Применить";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(332, 305);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Bubble";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Insert";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Shaker";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Quick";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "BOGO";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1133, 506);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BubbleBox
            // 
            this.BubbleBox.AutoSize = true;
            this.BubbleBox.Location = new System.Drawing.Point(470, 119);
            this.BubbleBox.Name = "BubbleBox";
            this.BubbleBox.Size = new System.Drawing.Size(115, 24);
            this.BubbleBox.TabIndex = 3;
            this.BubbleBox.Text = "BubbleSort";
            this.BubbleBox.UseVisualStyleBackColor = true;
            // 
            // InsertBox
            // 
            this.InsertBox.AutoSize = true;
            this.InsertBox.Location = new System.Drawing.Point(470, 149);
            this.InsertBox.Name = "InsertBox";
            this.InsertBox.Size = new System.Drawing.Size(106, 24);
            this.InsertBox.TabIndex = 4;
            this.InsertBox.Text = "InsertSort";
            this.InsertBox.UseVisualStyleBackColor = true;
            // 
            // ShakerBox
            // 
            this.ShakerBox.AutoSize = true;
            this.ShakerBox.Location = new System.Drawing.Point(470, 179);
            this.ShakerBox.Name = "ShakerBox";
            this.ShakerBox.Size = new System.Drawing.Size(116, 24);
            this.ShakerBox.TabIndex = 5;
            this.ShakerBox.Text = "ShakerSort";
            this.ShakerBox.UseVisualStyleBackColor = true;
            // 
            // qickSort
            // 
            this.qickSort.AutoSize = true;
            this.qickSort.Location = new System.Drawing.Point(470, 208);
            this.qickSort.Name = "qickSort";
            this.qickSort.Size = new System.Drawing.Size(105, 24);
            this.qickSort.TabIndex = 6;
            this.qickSort.Text = "QuickSort";
            this.qickSort.UseVisualStyleBackColor = true;
            // 
            // BOGOSort
            // 
            this.BOGOSort.AutoSize = true;
            this.BOGOSort.Location = new System.Drawing.Point(470, 238);
            this.BOGOSort.Name = "BOGOSort";
            this.BOGOSort.Size = new System.Drawing.Size(113, 24);
            this.BOGOSort.TabIndex = 7;
            this.BOGOSort.Text = "BOGOSort";
            this.BOGOSort.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1477, 33);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 28);
            this.toolStripLabel1.Text = "Лист";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(240, 33);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Время выполнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кол-во итераций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // insertTime
            // 
            this.insertTime.Location = new System.Drawing.Point(644, 148);
            this.insertTime.Name = "insertTime";
            this.insertTime.Size = new System.Drawing.Size(72, 20);
            this.insertTime.TabIndex = 12;
            this.insertTime.Text = "_______";
            this.insertTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shakerTime
            // 
            this.shakerTime.Location = new System.Drawing.Point(644, 177);
            this.shakerTime.Name = "shakerTime";
            this.shakerTime.Size = new System.Drawing.Size(72, 20);
            this.shakerTime.TabIndex = 13;
            this.shakerTime.Text = "_______";
            this.shakerTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quickTime
            // 
            this.quickTime.Location = new System.Drawing.Point(644, 207);
            this.quickTime.Name = "quickTime";
            this.quickTime.Size = new System.Drawing.Size(72, 20);
            this.quickTime.TabIndex = 14;
            this.quickTime.Text = "_______";
            this.quickTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bogoTime
            // 
            this.bogoTime.Location = new System.Drawing.Point(644, 237);
            this.bogoTime.Name = "bogoTime";
            this.bogoTime.Size = new System.Drawing.Size(72, 20);
            this.bogoTime.TabIndex = 15;
            this.bogoTime.Text = "_______";
            this.bogoTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bubbleTime
            // 
            this.bubbleTime.Location = new System.Drawing.Point(644, 118);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(72, 20);
            this.bubbleTime.TabIndex = 17;
            this.bubbleTime.Text = "_______";
            this.bubbleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bubbleIterations
            // 
            this.bubbleIterations.Location = new System.Drawing.Point(811, 118);
            this.bubbleIterations.Name = "bubbleIterations";
            this.bubbleIterations.Size = new System.Drawing.Size(72, 20);
            this.bubbleIterations.TabIndex = 22;
            this.bubbleIterations.Text = "_______";
            this.bubbleIterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bogoIterations
            // 
            this.bogoIterations.Location = new System.Drawing.Point(811, 237);
            this.bogoIterations.Name = "bogoIterations";
            this.bogoIterations.Size = new System.Drawing.Size(72, 20);
            this.bogoIterations.TabIndex = 21;
            this.bogoIterations.Text = "_______";
            this.bogoIterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quickIterations
            // 
            this.quickIterations.Location = new System.Drawing.Point(811, 207);
            this.quickIterations.Name = "quickIterations";
            this.quickIterations.Size = new System.Drawing.Size(72, 20);
            this.quickIterations.TabIndex = 20;
            this.quickIterations.Text = "_______";
            this.quickIterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shakerIterations
            // 
            this.shakerIterations.Location = new System.Drawing.Point(811, 177);
            this.shakerIterations.Name = "shakerIterations";
            this.shakerIterations.Size = new System.Drawing.Size(72, 20);
            this.shakerIterations.TabIndex = 19;
            this.shakerIterations.Text = "_______";
            this.shakerIterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertIterations
            // 
            this.insertIterations.Location = new System.Drawing.Point(811, 148);
            this.insertIterations.Name = "insertIterations";
            this.insertIterations.Size = new System.Drawing.Size(72, 20);
            this.insertIterations.TabIndex = 18;
            this.insertIterations.Text = "_______";
            this.insertIterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(970, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // ascendingBox
            // 
            this.ascendingBox.AutoSize = true;
            this.ascendingBox.Checked = true;
            this.ascendingBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ascendingBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ascendingBox.Location = new System.Drawing.Point(633, 289);
            this.ascendingBox.Name = "ascendingBox";
            this.ascendingBox.Size = new System.Drawing.Size(162, 24);
            this.ascendingBox.TabIndex = 24;
            this.ascendingBox.Text = "Прямой порядок";
            this.ascendingBox.UseVisualStyleBackColor = true;
            // 
            // SortingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1477, 840);
            this.Controls.Add(this.ascendingBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bubbleIterations);
            this.Controls.Add(this.bogoIterations);
            this.Controls.Add(this.quickIterations);
            this.Controls.Add(this.shakerIterations);
            this.Controls.Add(this.insertIterations);
            this.Controls.Add(this.bubbleTime);
            this.Controls.Add(this.bogoTime);
            this.Controls.Add(this.quickTime);
            this.Controls.Add(this.shakerTime);
            this.Controls.Add(this.insertTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BOGOSort);
            this.Controls.Add(this.qickSort);
            this.Controls.Add(this.ShakerBox);
            this.Controls.Add(this.InsertBox);
            this.Controls.Add(this.BubbleBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SortingApp";
            this.Text = "Sorting";
            this.Load += new System.EventHandler(this.SortingApp_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox BubbleBox;
        private System.Windows.Forms.CheckBox InsertBox;
        private System.Windows.Forms.CheckBox ShakerBox;
        private System.Windows.Forms.CheckBox qickSort;
        private System.Windows.Forms.CheckBox BOGOSort;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label insertTime;
        private System.Windows.Forms.Label shakerTime;
        private System.Windows.Forms.Label quickTime;
        private System.Windows.Forms.Label bogoTime;
        private System.Windows.Forms.Label bubbleTime;
        private System.Windows.Forms.Label bubbleIterations;
        private System.Windows.Forms.Label bogoIterations;
        private System.Windows.Forms.Label quickIterations;
        private System.Windows.Forms.Label shakerIterations;
        private System.Windows.Forms.Label insertIterations;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem GenerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоЭлементовToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox generationCountBox;
        private System.Windows.Forms.ToolStripMenuItem минимальноеЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox minValueBox;
        private System.Windows.Forms.ToolStripMenuItem максимальноеЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox maxValueBox;
        private System.Windows.Forms.ToolStripMenuItem generateButton;
        private System.Windows.Forms.CheckBox ascendingBox;
    }
}

