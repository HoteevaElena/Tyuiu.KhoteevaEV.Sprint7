namespace Tyuiu.KhoteevaEV.Sprint7.Project.V5
{
    partial class FormSearch
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            buttonClose_HEV = new Button();
            buttonSearch_HEV = new Button();
            textBoxTextFind_HEV = new TextBox();
            textBoxFind_HEV = new TextBox();
            textBoxNameProduct_HEV = new TextBox();
            textBoxAbout_HEV = new TextBox();
            textBoxCost_HEV = new TextBox();
            textBoxAmount_HEV = new TextBox();
            textBoxAboutText_HEV = new TextBox();
            textBoxCostText_HEV = new TextBox();
            textBoxNameProductText_HEV = new TextBox();
            textBoxAmountText_HEV = new TextBox();
            buttonOpen_HEV = new Button();
            openFileDialogSearch = new OpenFileDialog();
            toolTipSearch = new ToolTip(components);
            SuspendLayout();
            // 
            // buttonClose_HEV
            // 
            buttonClose_HEV.Location = new Point(641, 392);
            buttonClose_HEV.Name = "buttonClose_HEV";
            buttonClose_HEV.Size = new Size(112, 34);
            buttonClose_HEV.TabIndex = 0;
            buttonClose_HEV.Text = "Ok";
            buttonClose_HEV.UseVisualStyleBackColor = true;
            buttonClose_HEV.Click += buttonClose_HEV_Click;
            // 
            // buttonSearch_HEV
            // 
            buttonSearch_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonSearch_HEV.Enabled = false;
            buttonSearch_HEV.FlatStyle = FlatStyle.Flat;
            buttonSearch_HEV.Image = (Image)resources.GetObject("buttonSearch_HEV.Image");
            buttonSearch_HEV.Location = new Point(422, 18);
            buttonSearch_HEV.Name = "buttonSearch_HEV";
            buttonSearch_HEV.Size = new Size(80, 60);
            buttonSearch_HEV.TabIndex = 1;
            toolTipSearch.SetToolTip(buttonSearch_HEV, "Поиск информации о товаре по коду\r\n");
            buttonSearch_HEV.UseVisualStyleBackColor = false;
            buttonSearch_HEV.Click += buttonSearch_HEV_Click;
            // 
            // textBoxTextFind_HEV
            // 
            textBoxTextFind_HEV.BackColor = SystemColors.Control;
            textBoxTextFind_HEV.BorderStyle = BorderStyle.None;
            textBoxTextFind_HEV.Location = new Point(154, 28);
            textBoxTextFind_HEV.Name = "textBoxTextFind_HEV";
            textBoxTextFind_HEV.ReadOnly = true;
            textBoxTextFind_HEV.Size = new Size(68, 24);
            textBoxTextFind_HEV.TabIndex = 2;
            textBoxTextFind_HEV.Text = "Найти:";
            // 
            // textBoxFind_HEV
            // 
            textBoxFind_HEV.Location = new Point(219, 28);
            textBoxFind_HEV.Name = "textBoxFind_HEV";
            textBoxFind_HEV.Size = new Size(150, 31);
            textBoxFind_HEV.TabIndex = 3;
            // 
            // textBoxNameProduct_HEV
            // 
            textBoxNameProduct_HEV.BackColor = SystemColors.ControlLight;
            textBoxNameProduct_HEV.Location = new Point(204, 103);
            textBoxNameProduct_HEV.Name = "textBoxNameProduct_HEV";
            textBoxNameProduct_HEV.ReadOnly = true;
            textBoxNameProduct_HEV.Size = new Size(232, 31);
            textBoxNameProduct_HEV.TabIndex = 4;
            // 
            // textBoxAbout_HEV
            // 
            textBoxAbout_HEV.BackColor = SystemColors.ControlLight;
            textBoxAbout_HEV.Location = new Point(204, 305);
            textBoxAbout_HEV.Multiline = true;
            textBoxAbout_HEV.Name = "textBoxAbout_HEV";
            textBoxAbout_HEV.ReadOnly = true;
            textBoxAbout_HEV.Size = new Size(290, 100);
            textBoxAbout_HEV.TabIndex = 5;
            // 
            // textBoxCost_HEV
            // 
            textBoxCost_HEV.BackColor = SystemColors.ControlLight;
            textBoxCost_HEV.Location = new Point(204, 235);
            textBoxCost_HEV.Name = "textBoxCost_HEV";
            textBoxCost_HEV.ReadOnly = true;
            textBoxCost_HEV.Size = new Size(150, 31);
            textBoxCost_HEV.TabIndex = 6;
            // 
            // textBoxAmount_HEV
            // 
            textBoxAmount_HEV.BackColor = SystemColors.ControlLight;
            textBoxAmount_HEV.Location = new Point(204, 167);
            textBoxAmount_HEV.Name = "textBoxAmount_HEV";
            textBoxAmount_HEV.ReadOnly = true;
            textBoxAmount_HEV.Size = new Size(150, 31);
            textBoxAmount_HEV.TabIndex = 7;
            // 
            // textBoxAboutText_HEV
            // 
            textBoxAboutText_HEV.BackColor = SystemColors.Control;
            textBoxAboutText_HEV.BorderStyle = BorderStyle.None;
            textBoxAboutText_HEV.Location = new Point(12, 308);
            textBoxAboutText_HEV.Name = "textBoxAboutText_HEV";
            textBoxAboutText_HEV.ReadOnly = true;
            textBoxAboutText_HEV.Size = new Size(150, 24);
            textBoxAboutText_HEV.TabIndex = 8;
            textBoxAboutText_HEV.Text = "Примечание:";
            // 
            // textBoxCostText_HEV
            // 
            textBoxCostText_HEV.BorderStyle = BorderStyle.None;
            textBoxCostText_HEV.Location = new Point(12, 219);
            textBoxCostText_HEV.Multiline = true;
            textBoxCostText_HEV.Name = "textBoxCostText_HEV";
            textBoxCostText_HEV.ReadOnly = true;
            textBoxCostText_HEV.Size = new Size(150, 65);
            textBoxCostText_HEV.TabIndex = 9;
            textBoxCostText_HEV.Text = "Стоимость \r\nединицы товара:";
            // 
            // textBoxNameProductText_HEV
            // 
            textBoxNameProductText_HEV.BackColor = SystemColors.Control;
            textBoxNameProductText_HEV.BorderStyle = BorderStyle.None;
            textBoxNameProductText_HEV.Location = new Point(12, 103);
            textBoxNameProductText_HEV.Name = "textBoxNameProductText_HEV";
            textBoxNameProductText_HEV.ReadOnly = true;
            textBoxNameProductText_HEV.Size = new Size(170, 24);
            textBoxNameProductText_HEV.TabIndex = 10;
            textBoxNameProductText_HEV.Text = "Название товара:";
            // 
            // textBoxAmountText_HEV
            // 
            textBoxAmountText_HEV.BackColor = SystemColors.Control;
            textBoxAmountText_HEV.BorderStyle = BorderStyle.None;
            textBoxAmountText_HEV.Location = new Point(12, 167);
            textBoxAmountText_HEV.Name = "textBoxAmountText_HEV";
            textBoxAmountText_HEV.ReadOnly = true;
            textBoxAmountText_HEV.Size = new Size(150, 24);
            textBoxAmountText_HEV.TabIndex = 11;
            textBoxAmountText_HEV.Text = "Количество:";
            // 
            // buttonOpen_HEV
            // 
            buttonOpen_HEV.BackColor = SystemColors.ButtonHighlight;
            buttonOpen_HEV.FlatStyle = FlatStyle.Flat;
            buttonOpen_HEV.Image = (Image)resources.GetObject("buttonOpen_HEV.Image");
            buttonOpen_HEV.Location = new Point(24, 13);
            buttonOpen_HEV.Name = "buttonOpen_HEV";
            buttonOpen_HEV.Size = new Size(80, 60);
            buttonOpen_HEV.TabIndex = 12;
            toolTipSearch.SetToolTip(buttonOpen_HEV, "Открыть файл для поиска\r\n");
            buttonOpen_HEV.UseVisualStyleBackColor = false;
            buttonOpen_HEV.Click += buttonOpen_HEV_Click;
            // 
            // openFileDialogSearch
            // 
            openFileDialogSearch.FileName = "openFileDialogSearch";
            // 
            // toolTipSearch
            // 
            toolTipSearch.ToolTipIcon = ToolTipIcon.Info;
            toolTipSearch.ToolTipTitle = "Подсказка";
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpen_HEV);
            Controls.Add(textBoxAmountText_HEV);
            Controls.Add(textBoxNameProductText_HEV);
            Controls.Add(textBoxCostText_HEV);
            Controls.Add(textBoxAboutText_HEV);
            Controls.Add(textBoxAmount_HEV);
            Controls.Add(textBoxCost_HEV);
            Controls.Add(textBoxAbout_HEV);
            Controls.Add(textBoxNameProduct_HEV);
            Controls.Add(textBoxFind_HEV);
            Controls.Add(textBoxTextFind_HEV);
            Controls.Add(buttonSearch_HEV);
            Controls.Add(buttonClose_HEV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(822, 506);
            MinimumSize = new Size(822, 506);
            Name = "FormSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск";
            Load += FormSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose_HEV;
        private Button buttonSearch_HEV;
        private TextBox textBoxTextFind_HEV;
        private TextBox textBoxFind_HEV;
        private TextBox textBoxNameProduct_HEV;
        private TextBox textBoxAbout_HEV;
        private TextBox textBoxCost_HEV;
        private TextBox textBoxAmount_HEV;
        private TextBox textBoxAboutText_HEV;
        private TextBox textBoxCostText_HEV;
        private TextBox textBoxNameProductText_HEV;
        private TextBox textBoxAmountText_HEV;
        private Button buttonOpen_HEV;
        private OpenFileDialog openFileDialogSearch;
        private ToolTip toolTipSearch;
    }
}