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
            UserDifinePanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            UserDifineUpDown = new NumericUpDown();
            UserDifineDirection = new Label();
            UserDifineScale = new TextBox();
            UserDifineScaleRabel = new Label();
            UserDifineScaleButton = new RadioButton();
            MosButton = new RadioButton();
            RandomButton = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            UserDifinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDifineUpDown).BeginInit();
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
            ScaleApply.Click += ScaleApply_Click;
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
            // UserDifinePanel
            // 
            UserDifinePanel.Controls.Add(label2);
            UserDifinePanel.Controls.Add(label1);
            UserDifinePanel.Controls.Add(UserDifineUpDown);
            UserDifinePanel.Controls.Add(UserDifineDirection);
            UserDifinePanel.Controls.Add(UserDifineScale);
            UserDifinePanel.Controls.Add(UserDifineScaleRabel);
            UserDifinePanel.Location = new Point(66, 94);
            UserDifinePanel.Name = "UserDifinePanel";
            UserDifinePanel.Size = new Size(256, 297);
            UserDifinePanel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 100);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 7;
            label2.Text = "ユーザ定義音階";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 68);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 6;
            label1.Text = "相対ステップ";
            // 
            // UserDifineUpDown
            // 
            UserDifineUpDown.Location = new Point(133, 66);
            UserDifineUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            UserDifineUpDown.Minimum = new decimal(new int[] { 0, 1, 0, int.MinValue });
            UserDifineUpDown.Name = "UserDifineUpDown";
            UserDifineUpDown.Size = new Size(107, 31);
            UserDifineUpDown.TabIndex = 5;
            UserDifineUpDown.ValueChanged += UserDifineUpDown_ValueChanged;
            // 
            // UserDifineDirection
            // 
            UserDifineDirection.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserDifineDirection.Location = new Point(8, 170);
            UserDifineDirection.Name = "UserDifineDirection";
            UserDifineDirection.Size = new Size(245, 123);
            UserDifineDirection.TabIndex = 4;
            UserDifineDirection.Text = "カンマで区切って、生成した音律の各stepをUTAUの12音に当て嵌めます。[1,5,10...28]みたいな感じです。\r\n\r\n相対ステップにより、最初に設定したステップの最初からその音階内で幾tsstep上下するかを指定できます。";
            // 
            // UserDifineScale
            // 
            UserDifineScale.Location = new Point(3, 128);
            UserDifineScale.Name = "UserDifineScale";
            UserDifineScale.Size = new Size(250, 31);
            UserDifineScale.TabIndex = 3;
            UserDifineScale.TextChanged += UserDifineScale_TextChanged;
            // 
            // UserDifineScaleRabel
            // 
            UserDifineScaleRabel.AutoSize = true;
            UserDifineScaleRabel.Location = new Point(3, 21);
            UserDifineScaleRabel.Name = "UserDifineScaleRabel";
            UserDifineScaleRabel.Size = new Size(251, 25);
            UserDifineScaleRabel.TabIndex = 2;
            UserDifineScaleRabel.Text = "ユーザ定義音階 + 相対ステップ";
            // 
            // UserDifineScaleButton
            // 
            UserDifineScaleButton.AutoSize = true;
            UserDifineScaleButton.Location = new Point(50, 12);
            UserDifineScaleButton.Name = "UserDifineScaleButton";
            UserDifineScaleButton.Size = new Size(272, 29);
            UserDifineScaleButton.TabIndex = 11;
            UserDifineScaleButton.TabStop = true;
            UserDifineScaleButton.Text = "ユーザ定義音階 + 相対ステップ";
            UserDifineScaleButton.UseVisualStyleBackColor = true;
            UserDifineScaleButton.CheckedChanged += UserDifineScaleButton_CheckedChanged;
            // 
            // MosButton
            // 
            MosButton.AutoSize = true;
            MosButton.Location = new Point(26, 47);
            MosButton.Name = "MosButton";
            MosButton.Size = new Size(135, 29);
            MosButton.TabIndex = 12;
            MosButton.TabStop = true;
            MosButton.Text = "MOSスケール";
            MosButton.UseVisualStyleBackColor = true;
            MosButton.CheckedChanged += MosButton_CheckedChanged;
            // 
            // RandomButton
            // 
            RandomButton.AutoSize = true;
            RandomButton.Location = new Point(287, 47);
            RandomButton.Name = "RandomButton";
            RandomButton.Size = new Size(90, 29);
            RandomButton.TabIndex = 13;
            RandomButton.TabStop = true;
            RandomButton.Text = "ランダム";
            RandomButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.8F);
            label3.Location = new Point(66, 38);
            label3.Name = "label3";
            label3.Size = new Size(40, 38);
            label3.TabIndex = 11;
            label3.Text = "✘";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.8F);
            label4.Location = new Point(308, 47);
            label4.Name = "label4";
            label4.Size = new Size(40, 38);
            label4.TabIndex = 14;
            label4.Text = "✘";
            // 
            // ScaleSetting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 453);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RandomButton);
            Controls.Add(MosButton);
            Controls.Add(UserDifineScaleButton);
            Controls.Add(UserDifinePanel);
            Controls.Add(ScaleApply);
            Controls.Add(ScaleClose);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScaleSetting";
            Text = "音階設定";
            Load += ScaleSetting_Load;
            UserDifinePanel.ResumeLayout(false);
            UserDifinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDifineUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ScaleApply;
        private Button ScaleClose;
        private Panel UserDifinePanel;
        private Label UserDifineDirection;
        private TextBox UserDifineScale;
        private Label UserDifineScaleRabel;
        private Label label1;
        private NumericUpDown UserDifineUpDown;
        private Label label2;
        private RadioButton UserDifineScaleButton;
        private RadioButton MosButton;
        private RadioButton RandomButton;
        private Label label3;
        private Label label4;
    }
}