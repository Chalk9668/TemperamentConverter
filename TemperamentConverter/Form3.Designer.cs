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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleSetting));
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
            resources.ApplyResources(ScaleApply, "ScaleApply");
            ScaleApply.Name = "ScaleApply";
            ScaleApply.UseVisualStyleBackColor = true;
            ScaleApply.Click += ScaleApply_Click;
            // 
            // ScaleClose
            // 
            resources.ApplyResources(ScaleClose, "ScaleClose");
            ScaleClose.Name = "ScaleClose";
            ScaleClose.UseVisualStyleBackColor = true;
            ScaleClose.Click += ScaleClose_Click;
            // 
            // UserDifinePanel
            // 
            resources.ApplyResources(UserDifinePanel, "UserDifinePanel");
            UserDifinePanel.Controls.Add(label2);
            UserDifinePanel.Controls.Add(label1);
            UserDifinePanel.Controls.Add(UserDifineUpDown);
            UserDifinePanel.Controls.Add(UserDifineDirection);
            UserDifinePanel.Controls.Add(UserDifineScale);
            UserDifinePanel.Controls.Add(UserDifineScaleRabel);
            UserDifinePanel.Name = "UserDifinePanel";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // UserDifineUpDown
            // 
            resources.ApplyResources(UserDifineUpDown, "UserDifineUpDown");
            UserDifineUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            UserDifineUpDown.Minimum = new decimal(new int[] { 0, 1, 0, int.MinValue });
            UserDifineUpDown.Name = "UserDifineUpDown";
            UserDifineUpDown.ValueChanged += UserDifineUpDown_ValueChanged;
            // 
            // UserDifineDirection
            // 
            resources.ApplyResources(UserDifineDirection, "UserDifineDirection");
            UserDifineDirection.Name = "UserDifineDirection";
            // 
            // UserDifineScale
            // 
            resources.ApplyResources(UserDifineScale, "UserDifineScale");
            UserDifineScale.Name = "UserDifineScale";
            UserDifineScale.TextChanged += UserDifineScale_TextChanged;
            // 
            // UserDifineScaleRabel
            // 
            resources.ApplyResources(UserDifineScaleRabel, "UserDifineScaleRabel");
            UserDifineScaleRabel.Name = "UserDifineScaleRabel";
            // 
            // UserDifineScaleButton
            // 
            resources.ApplyResources(UserDifineScaleButton, "UserDifineScaleButton");
            UserDifineScaleButton.Name = "UserDifineScaleButton";
            UserDifineScaleButton.TabStop = true;
            UserDifineScaleButton.UseVisualStyleBackColor = true;
            UserDifineScaleButton.CheckedChanged += UserDifineScaleButton_CheckedChanged;
            // 
            // MosButton
            // 
            resources.ApplyResources(MosButton, "MosButton");
            MosButton.Name = "MosButton";
            MosButton.TabStop = true;
            MosButton.UseVisualStyleBackColor = true;
            MosButton.CheckedChanged += MosButton_CheckedChanged;
            // 
            // RandomButton
            // 
            resources.ApplyResources(RandomButton, "RandomButton");
            RandomButton.Name = "RandomButton";
            RandomButton.TabStop = true;
            RandomButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // ScaleSetting
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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