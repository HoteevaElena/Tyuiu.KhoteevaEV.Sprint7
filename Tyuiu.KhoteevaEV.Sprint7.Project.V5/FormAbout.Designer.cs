namespace Tyuiu.KhoteevaEV.Sprint7.Project.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_HEV = new PictureBox();
            buttonOk_HEV = new Button();
            textBoxAboutProgam_HEV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_HEV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_HEV
            // 
            pictureBoxAvatar_HEV.Location = new Point(0, 0);
            pictureBoxAvatar_HEV.Name = "pictureBoxAvatar_HEV";
            pictureBoxAvatar_HEV.Size = new Size(151, 174);
            pictureBoxAvatar_HEV.TabIndex = 0;
            pictureBoxAvatar_HEV.TabStop = false;
            // 
            // buttonOk_HEV
            // 
            buttonOk_HEV.Location = new Point(638, 385);
            buttonOk_HEV.Name = "buttonOk_HEV";
            buttonOk_HEV.Size = new Size(112, 34);
            buttonOk_HEV.TabIndex = 1;
            buttonOk_HEV.Text = "Ok";
            buttonOk_HEV.UseVisualStyleBackColor = true;
            buttonOk_HEV.Click += buttonOk_HEV_Click;
            // 
            // textBoxAboutProgam_HEV
            // 
            textBoxAboutProgam_HEV.BorderStyle = BorderStyle.None;
            textBoxAboutProgam_HEV.Location = new Point(157, 12);
            textBoxAboutProgam_HEV.Multiline = true;
            textBoxAboutProgam_HEV.Name = "textBoxAboutProgam_HEV";
            textBoxAboutProgam_HEV.ReadOnly = true;
            textBoxAboutProgam_HEV.Size = new Size(612, 337);
            textBoxAboutProgam_HEV.TabIndex = 2;
            textBoxAboutProgam_HEV.Text = resources.GetString("textBoxAboutProgam_HEV.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAboutProgam_HEV);
            Controls.Add(buttonOk_HEV);
            Controls.Add(pictureBoxAvatar_HEV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(822, 506);
            MinimizeBox = false;
            MinimumSize = new Size(822, 506);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            TopMost = true;
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_HEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_HEV;
        private Button buttonOk_HEV;
        private TextBox textBoxAboutProgam_HEV;
    }
}