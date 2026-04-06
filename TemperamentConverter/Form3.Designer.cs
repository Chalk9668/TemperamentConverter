namespace TemperamentConverter
{
    partial class ScaleSetting
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
            ScaleApply = new Button();
            ScaleClose = new Button();
            SuspendLayout();
            // 
            // ScaleApply
            // 
            ScaleApply.Location = new Point(196, 412);
            ScaleApply.Name = "ScaleApply";
            ScaleApply.Size = new Size(94, 29);
            ScaleApply.TabIndex = 3;
            ScaleApply.Text = "適用";
            ScaleApply.UseVisualStyleBackColor = true;
            // 
            // ScaleClose
            // 
            ScaleClose.Location = new Point(296, 412);
            ScaleClose.Name = "ScaleClose";
            ScaleClose.Size = new Size(94, 29);
            ScaleClose.TabIndex = 2;
            ScaleClose.Text = "閉じる";
            ScaleClose.UseVisualStyleBackColor = true;
            ScaleClose.Click += ScaleClose_Click;
            // 
            // ScaleSetting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 453);
            Controls.Add(ScaleApply);
            Controls.Add(ScaleClose);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScaleSetting";
            Text = "音階設定";
            ResumeLayout(false);
        }

        #endregion

        private Button ScaleApply;
        private Button ScaleClose;
    }
}