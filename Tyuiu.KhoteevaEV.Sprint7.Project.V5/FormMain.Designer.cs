namespace Tyuiu.KhoteevaEV.Sprint7.Project.V5
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            panelUp_HEV = new Panel();
            buttonInfo_HEV = new Button();
            buttonSearch_HEV = new Button();
            buttonSort_HEV = new Button();
            buttonSave_HEV = new Button();
            buttonOpen_HEV = new Button();
            buttonDeleteRow_HEV = new Button();
            buttonAddRow_HEV = new Button();
            groupBoxStatistics_HEV = new GroupBox();
            textBoxMinCostUnitText_HEV = new TextBox();
            textBoxMinCostUnit_HEV = new TextBox();
            textBoxAverageCostText_HEV = new TextBox();
            textBoxAverageCost_HEV = new TextBox();
            textBoxMaxCostUnitText_HEV = new TextBox();
            textBoxCostAllProductsText_HEV = new TextBox();
            textBoxMaxCostUnit_HEV = new TextBox();
            textBoxCostAllProducts_HEV = new TextBox();
            textBoxAmountProductText_HEV = new TextBox();
            textBoxAmountProducts_HEV = new TextBox();
            toolTipMain = new ToolTip(components);
            panelLeft_HEV = new Panel();
            groupBoxTextData_HEV = new GroupBox();
            dataGridViewBase_HEV = new DataGridView();
            splitter1 = new Splitter();
            splitContainerStatistics_HEV = new SplitContainer();
            groupBoxDiagramData_HEV = new GroupBox();
            chartCostData_HEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_HEV.SuspendLayout();
            groupBoxStatistics_HEV.SuspendLayout();
            panelLeft_HEV.SuspendLayout();
            groupBoxTextData_HEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_HEV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerStatistics_HEV).BeginInit();
            splitContainerStatistics_HEV.Panel1.SuspendLayout();
            splitContainerStatistics_HEV.Panel2.SuspendLayout();
            splitContainerStatistics_HEV.SuspendLayout();
            groupBoxDiagramData_HEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCostData_HEV).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "saveFileDialog";
            // 
            // panelUp_HEV
            // 
            panelUp_HEV.Controls.Add(buttonInfo_HEV);
            panelUp_HEV.Controls.Add(buttonSearch_HEV);
            panelUp_HEV.Controls.Add(buttonSort_HEV);
            panelUp_HEV.Controls.Add(buttonSave_HEV);
            panelUp_HEV.Controls.Add(buttonOpen_HEV);
            panelUp_HEV.Dock = DockStyle.Top;
            panelUp_HEV.Location = new Point(0, 0);
            panelUp_HEV.Name = "panelUp_HEV";
            panelUp_HEV.Size = new Size(1713, 147);
            panelUp_HEV.TabIndex = 0;
            // 
            // buttonInfo_HEV
            // 
            buttonInfo_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonInfo_HEV.FlatStyle = FlatStyle.Flat;
            buttonInfo_HEV.Image = (Image)resources.GetObject("buttonInfo_HEV.Image");
            buttonInfo_HEV.Location = new Point(1591, 33);
            buttonInfo_HEV.Name = "buttonInfo_HEV";
            buttonInfo_HEV.Size = new Size(110, 90);
            buttonInfo_HEV.TabIndex = 4;
            toolTipMain.SetToolTip(buttonInfo_HEV, "Информация о программе");
            buttonInfo_HEV.UseVisualStyleBackColor = false;
            buttonInfo_HEV.Click += buttonInfo_HEV_Click;
            // 
            // buttonSearch_HEV
            // 
            buttonSearch_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonSearch_HEV.Enabled = false;
            buttonSearch_HEV.FlatStyle = FlatStyle.Flat;
            buttonSearch_HEV.Image = (Image)resources.GetObject("buttonSearch_HEV.Image");
            buttonSearch_HEV.Location = new Point(275, 12);
            buttonSearch_HEV.Name = "buttonSearch_HEV";
            buttonSearch_HEV.Size = new Size(110, 90);
            buttonSearch_HEV.TabIndex = 18;
            toolTipMain.SetToolTip(buttonSearch_HEV, "Поиск характеристик товара по коду");
            buttonSearch_HEV.UseVisualStyleBackColor = false;
            buttonSearch_HEV.Click += buttonSearch_HEV_Click;
            // 
            // buttonSort_HEV
            // 
            buttonSort_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonSort_HEV.Location = new Point(563, 12);
            buttonSort_HEV.Name = "buttonSort_HEV";
            buttonSort_HEV.Size = new Size(131, 90);
            buttonSort_HEV.TabIndex = 17;
            buttonSort_HEV.Text = "Sort NameProduct";
            buttonSort_HEV.UseVisualStyleBackColor = false;
            buttonSort_HEV.Click += buttonSort_HEV_Click;
            // 
            // buttonSave_HEV
            // 
            buttonSave_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonSave_HEV.Enabled = false;
            buttonSave_HEV.FlatStyle = FlatStyle.Flat;
            buttonSave_HEV.Image = (Image)resources.GetObject("buttonSave_HEV.Image");
            buttonSave_HEV.Location = new Point(142, 12);
            buttonSave_HEV.Name = "buttonSave_HEV";
            buttonSave_HEV.Size = new Size(110, 90);
            buttonSave_HEV.TabIndex = 0;
            toolTipMain.SetToolTip(buttonSave_HEV, "Сохранить файл");
            buttonSave_HEV.UseVisualStyleBackColor = false;
            buttonSave_HEV.Click += buttonSave_HEV_Click;
            // 
            // buttonOpen_HEV
            // 
            buttonOpen_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonOpen_HEV.FlatStyle = FlatStyle.Flat;
            buttonOpen_HEV.Image = (Image)resources.GetObject("buttonOpen_HEV.Image");
            buttonOpen_HEV.Location = new Point(12, 12);
            buttonOpen_HEV.Name = "buttonOpen_HEV";
            buttonOpen_HEV.Size = new Size(110, 90);
            buttonOpen_HEV.TabIndex = 0;
            toolTipMain.SetToolTip(buttonOpen_HEV, "Открыть файл");
            buttonOpen_HEV.UseVisualStyleBackColor = false;
            buttonOpen_HEV.Click += buttonOpen_HEV_Click;
            // 
            // buttonDeleteRow_HEV
            // 
            buttonDeleteRow_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonDeleteRow_HEV.Enabled = false;
            buttonDeleteRow_HEV.Location = new Point(593, 29);
            buttonDeleteRow_HEV.Name = "buttonDeleteRow_HEV";
            buttonDeleteRow_HEV.Size = new Size(40, 40);
            buttonDeleteRow_HEV.TabIndex = 18;
            buttonDeleteRow_HEV.Text = "-";
            buttonDeleteRow_HEV.UseVisualStyleBackColor = false;
            buttonDeleteRow_HEV.Click += buttonDeleteRow_HEV_Click;
            // 
            // buttonAddRow_HEV
            // 
            buttonAddRow_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonAddRow_HEV.Enabled = false;
            buttonAddRow_HEV.Location = new Point(547, 29);
            buttonAddRow_HEV.Name = "buttonAddRow_HEV";
            buttonAddRow_HEV.Size = new Size(40, 40);
            buttonAddRow_HEV.TabIndex = 4;
            buttonAddRow_HEV.Text = "+";
            buttonAddRow_HEV.UseVisualStyleBackColor = false;
            buttonAddRow_HEV.Click += buttonAddRow_HEV_Click;
            // 
            // groupBoxStatistics_HEV
            // 
            groupBoxStatistics_HEV.Controls.Add(textBoxMinCostUnitText_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxMinCostUnit_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxAverageCostText_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxAverageCost_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxMaxCostUnitText_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxCostAllProductsText_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxMaxCostUnit_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxCostAllProducts_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxAmountProductText_HEV);
            groupBoxStatistics_HEV.Controls.Add(textBoxAmountProducts_HEV);
            groupBoxStatistics_HEV.Dock = DockStyle.Fill;
            groupBoxStatistics_HEV.Location = new Point(5, 5);
            groupBoxStatistics_HEV.Name = "groupBoxStatistics_HEV";
            groupBoxStatistics_HEV.Size = new Size(323, 583);
            groupBoxStatistics_HEV.TabIndex = 7;
            groupBoxStatistics_HEV.TabStop = false;
            groupBoxStatistics_HEV.Text = "Статистика";
            // 
            // textBoxMinCostUnitText_HEV
            // 
            textBoxMinCostUnitText_HEV.BackColor = SystemColors.Control;
            textBoxMinCostUnitText_HEV.BorderStyle = BorderStyle.None;
            textBoxMinCostUnitText_HEV.Location = new Point(6, 333);
            textBoxMinCostUnitText_HEV.Multiline = true;
            textBoxMinCostUnitText_HEV.Name = "textBoxMinCostUnitText_HEV";
            textBoxMinCostUnitText_HEV.ReadOnly = true;
            textBoxMinCostUnitText_HEV.Size = new Size(180, 91);
            textBoxMinCostUnitText_HEV.TabIndex = 16;
            textBoxMinCostUnitText_HEV.Text = "Минимальная стоимость единицы товара:\r\n";
            // 
            // textBoxMinCostUnit_HEV
            // 
            textBoxMinCostUnit_HEV.BackColor = SystemColors.ControlLightLight;
            textBoxMinCostUnit_HEV.Location = new Point(186, 356);
            textBoxMinCostUnit_HEV.Name = "textBoxMinCostUnit_HEV";
            textBoxMinCostUnit_HEV.ReadOnly = true;
            textBoxMinCostUnit_HEV.Size = new Size(110, 31);
            textBoxMinCostUnit_HEV.TabIndex = 15;
            // 
            // textBoxAverageCostText_HEV
            // 
            textBoxAverageCostText_HEV.BackColor = SystemColors.Control;
            textBoxAverageCostText_HEV.BorderStyle = BorderStyle.None;
            textBoxAverageCostText_HEV.Location = new Point(6, 172);
            textBoxAverageCostText_HEV.Multiline = true;
            textBoxAverageCostText_HEV.Name = "textBoxAverageCostText_HEV";
            textBoxAverageCostText_HEV.ReadOnly = true;
            textBoxAverageCostText_HEV.Size = new Size(180, 61);
            textBoxAverageCostText_HEV.TabIndex = 12;
            textBoxAverageCostText_HEV.Text = "Средняя стоимость товаров на складе:";
            // 
            // textBoxAverageCost_HEV
            // 
            textBoxAverageCost_HEV.BackColor = SystemColors.ControlLightLight;
            textBoxAverageCost_HEV.Location = new Point(186, 188);
            textBoxAverageCost_HEV.Name = "textBoxAverageCost_HEV";
            textBoxAverageCost_HEV.ReadOnly = true;
            textBoxAverageCost_HEV.Size = new Size(110, 31);
            textBoxAverageCost_HEV.TabIndex = 11;
            // 
            // textBoxMaxCostUnitText_HEV
            // 
            textBoxMaxCostUnitText_HEV.BackColor = SystemColors.Control;
            textBoxMaxCostUnitText_HEV.BorderStyle = BorderStyle.None;
            textBoxMaxCostUnitText_HEV.Location = new Point(6, 255);
            textBoxMaxCostUnitText_HEV.Multiline = true;
            textBoxMaxCostUnitText_HEV.Name = "textBoxMaxCostUnitText_HEV";
            textBoxMaxCostUnitText_HEV.ReadOnly = true;
            textBoxMaxCostUnitText_HEV.Size = new Size(180, 84);
            textBoxMaxCostUnitText_HEV.TabIndex = 14;
            textBoxMaxCostUnitText_HEV.Text = "Максимальная стоимость единицы товара:\r\n";
            // 
            // textBoxCostAllProductsText_HEV
            // 
            textBoxCostAllProductsText_HEV.BackColor = SystemColors.Control;
            textBoxCostAllProductsText_HEV.BorderStyle = BorderStyle.None;
            textBoxCostAllProductsText_HEV.Location = new Point(6, 96);
            textBoxCostAllProductsText_HEV.Multiline = true;
            textBoxCostAllProductsText_HEV.Name = "textBoxCostAllProductsText_HEV";
            textBoxCostAllProductsText_HEV.ReadOnly = true;
            textBoxCostAllProductsText_HEV.Size = new Size(169, 61);
            textBoxCostAllProductsText_HEV.TabIndex = 10;
            textBoxCostAllProductsText_HEV.Text = "Общая стоимость товаров:\r\n";
            // 
            // textBoxMaxCostUnit_HEV
            // 
            textBoxMaxCostUnit_HEV.BackColor = SystemColors.ControlLightLight;
            textBoxMaxCostUnit_HEV.Location = new Point(186, 282);
            textBoxMaxCostUnit_HEV.Name = "textBoxMaxCostUnit_HEV";
            textBoxMaxCostUnit_HEV.ReadOnly = true;
            textBoxMaxCostUnit_HEV.Size = new Size(110, 31);
            textBoxMaxCostUnit_HEV.TabIndex = 13;
            // 
            // textBoxCostAllProducts_HEV
            // 
            textBoxCostAllProducts_HEV.BackColor = SystemColors.ControlLightLight;
            textBoxCostAllProducts_HEV.Location = new Point(186, 109);
            textBoxCostAllProducts_HEV.Name = "textBoxCostAllProducts_HEV";
            textBoxCostAllProducts_HEV.ReadOnly = true;
            textBoxCostAllProducts_HEV.Size = new Size(110, 31);
            textBoxCostAllProducts_HEV.TabIndex = 8;
            // 
            // textBoxAmountProductText_HEV
            // 
            textBoxAmountProductText_HEV.BackColor = SystemColors.Control;
            textBoxAmountProductText_HEV.BorderStyle = BorderStyle.None;
            textBoxAmountProductText_HEV.Location = new Point(6, 29);
            textBoxAmountProductText_HEV.Multiline = true;
            textBoxAmountProductText_HEV.Name = "textBoxAmountProductText_HEV";
            textBoxAmountProductText_HEV.ReadOnly = true;
            textBoxAmountProductText_HEV.Size = new Size(180, 61);
            textBoxAmountProductText_HEV.TabIndex = 9;
            textBoxAmountProductText_HEV.Text = "Общее количество товаров на складе:";
            // 
            // textBoxAmountProducts_HEV
            // 
            textBoxAmountProducts_HEV.BackColor = SystemColors.ControlLightLight;
            textBoxAmountProducts_HEV.Location = new Point(186, 45);
            textBoxAmountProducts_HEV.Name = "textBoxAmountProducts_HEV";
            textBoxAmountProducts_HEV.ReadOnly = true;
            textBoxAmountProducts_HEV.Size = new Size(110, 31);
            textBoxAmountProducts_HEV.TabIndex = 7;
            // 
            // toolTipMain
            // 
            toolTipMain.ToolTipIcon = ToolTipIcon.Info;
            toolTipMain.ToolTipTitle = "Подсказка";
            // 
            // panelLeft_HEV
            // 
            panelLeft_HEV.BackColor = SystemColors.Control;
            panelLeft_HEV.Controls.Add(groupBoxTextData_HEV);
            panelLeft_HEV.Dock = DockStyle.Left;
            panelLeft_HEV.Location = new Point(0, 147);
            panelLeft_HEV.MinimumSize = new Size(350, 557);
            panelLeft_HEV.Name = "panelLeft_HEV";
            panelLeft_HEV.Padding = new Padding(5);
            panelLeft_HEV.Size = new Size(649, 593);
            panelLeft_HEV.TabIndex = 1;
            // 
            // groupBoxTextData_HEV
            // 
            groupBoxTextData_HEV.Controls.Add(buttonAddRow_HEV);
            groupBoxTextData_HEV.Controls.Add(buttonDeleteRow_HEV);
            groupBoxTextData_HEV.Controls.Add(dataGridViewBase_HEV);
            groupBoxTextData_HEV.Dock = DockStyle.Fill;
            groupBoxTextData_HEV.Location = new Point(5, 5);
            groupBoxTextData_HEV.Name = "groupBoxTextData_HEV";
            groupBoxTextData_HEV.Padding = new Padding(3, 50, 3, 3);
            groupBoxTextData_HEV.Size = new Size(639, 583);
            groupBoxTextData_HEV.TabIndex = 3;
            groupBoxTextData_HEV.TabStop = false;
            groupBoxTextData_HEV.Text = "Текстовые данные:";
            // 
            // dataGridViewBase_HEV
            // 
            dataGridViewBase_HEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_HEV.Dock = DockStyle.Fill;
            dataGridViewBase_HEV.Location = new Point(3, 74);
            dataGridViewBase_HEV.Name = "dataGridViewBase_HEV";
            dataGridViewBase_HEV.RowHeadersVisible = false;
            dataGridViewBase_HEV.RowHeadersWidth = 62;
            dataGridViewBase_HEV.Size = new Size(633, 506);
            dataGridViewBase_HEV.TabIndex = 0;
            dataGridViewBase_HEV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(649, 147);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 593);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += splitter1_SplitterMoved;
            // 
            // splitContainerStatistics_HEV
            // 
            splitContainerStatistics_HEV.Dock = DockStyle.Fill;
            splitContainerStatistics_HEV.Location = new Point(653, 147);
            splitContainerStatistics_HEV.MinimumSize = new Size(1060, 557);
            splitContainerStatistics_HEV.Name = "splitContainerStatistics_HEV";
            // 
            // splitContainerStatistics_HEV.Panel1
            // 
            splitContainerStatistics_HEV.Panel1.BackColor = SystemColors.Control;
            splitContainerStatistics_HEV.Panel1.Controls.Add(groupBoxDiagramData_HEV);
            splitContainerStatistics_HEV.Panel1.Padding = new Padding(5);
            splitContainerStatistics_HEV.Panel1MinSize = 400;
            // 
            // splitContainerStatistics_HEV.Panel2
            // 
            splitContainerStatistics_HEV.Panel2.Controls.Add(groupBoxStatistics_HEV);
            splitContainerStatistics_HEV.Panel2.Padding = new Padding(5);
            splitContainerStatistics_HEV.Panel2MinSize = 300;
            splitContainerStatistics_HEV.Size = new Size(1060, 593);
            splitContainerStatistics_HEV.SplitterDistance = 723;
            splitContainerStatistics_HEV.TabIndex = 3;
            // 
            // groupBoxDiagramData_HEV
            // 
            groupBoxDiagramData_HEV.Controls.Add(chartCostData_HEV);
            groupBoxDiagramData_HEV.Dock = DockStyle.Fill;
            groupBoxDiagramData_HEV.Location = new Point(5, 5);
            groupBoxDiagramData_HEV.Name = "groupBoxDiagramData_HEV";
            groupBoxDiagramData_HEV.Size = new Size(713, 583);
            groupBoxDiagramData_HEV.TabIndex = 1;
            groupBoxDiagramData_HEV.TabStop = false;
            groupBoxDiagramData_HEV.Text = "Диаграмма";
            // 
            // chartCostData_HEV
            // 
            chartArea1.Name = "ChartArea1";
            chartCostData_HEV.ChartAreas.Add(chartArea1);
            chartCostData_HEV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartCostData_HEV.Legends.Add(legend1);
            chartCostData_HEV.Location = new Point(3, 27);
            chartCostData_HEV.Name = "chartCostData_HEV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCostData_HEV.Series.Add(series1);
            chartCostData_HEV.Size = new Size(707, 553);
            chartCostData_HEV.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 740);
            Controls.Add(splitContainerStatistics_HEV);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_HEV);
            Controls.Add(panelUp_HEV);
            MinimumSize = new Size(1735, 796);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оптовая база";
            Load += FormMain_Load;
            panelUp_HEV.ResumeLayout(false);
            groupBoxStatistics_HEV.ResumeLayout(false);
            groupBoxStatistics_HEV.PerformLayout();
            panelLeft_HEV.ResumeLayout(false);
            groupBoxTextData_HEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_HEV).EndInit();
            splitContainerStatistics_HEV.Panel1.ResumeLayout(false);
            splitContainerStatistics_HEV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerStatistics_HEV).EndInit();
            splitContainerStatistics_HEV.ResumeLayout(false);
            groupBoxDiagramData_HEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartCostData_HEV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Panel panelUp_HEV;
        private ToolTip toolTipMain;
        private Panel panelLeft_HEV;
        private Splitter splitter1;
        private Button buttonSave_HEV;
        private Button buttonOpen_HEV;
        private GroupBox groupBoxTextData_HEV;
        private DataGridView dataGridViewBase_HEV;
        private GroupBox groupBoxStatistics_HEV;
        private TextBox textBoxCostAllProducts_HEV;
        private TextBox textBoxAmountProductText_HEV;
        private TextBox textBoxAmountProducts_HEV;
        private TextBox textBoxCostAllProductsText_HEV;
        private TextBox textBoxMinCostUnitText_HEV;
        private TextBox textBoxMinCostUnit_HEV;
        private TextBox textBoxMaxCostUnitText_HEV;
        private TextBox textBoxMaxCostUnit_HEV;
        private TextBox textBoxAverageCostText_HEV;
        private TextBox textBoxAverageCost_HEV;
        private Button buttonSort_HEV;
        private SplitContainer splitContainerStatistics_HEV;
        private GroupBox groupBoxDiagramData_HEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCostData_HEV;
        private Button buttonAddRow_HEV;
        private Button buttonDeleteRow_HEV;
        private Button buttonSearch_HEV;
        private Button buttonInfo_HEV;
    }
}
