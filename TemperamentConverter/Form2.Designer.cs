namespace TemperamentConverter
{
    partial class DivitionSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivitionSetting));
            TuningClose = new Button();
            TuningApply = new Button();
            nEDORadio = new RadioButton();
            MeantoneRadio = new RadioButton();
            JIRadio = new RadioButton();
            UserDifineRadio = new RadioButton();
            EDOPanel = new Panel();
            EDODirection = new Label();
            IndicateEDO1step = new Label();
            nEDOselect = new NumericUpDown();
            SayEDOn = new Label();
            MeantonePanel = new Panel();
            MeantoneOnnsuuUpDown = new NumericUpDown();
            MeantoneOnsuu = new Label();
            MeantoneDirection = new Label();
            SizeOf5th = new Label();
            Meantone5thUpDown = new NumericUpDown();
            UserDifinePanel = new Panel();
            UserDifineDirection = new Label();
            UserDifinePitches = new TextBox();
            UserDifineCents = new Label();
            UserDifineUpDown = new NumericUpDown();
            UserDifineOnnsuu = new Label();
            JIPanel = new Panel();
            JIDirection = new Label();
            textBox1 = new TextBox();
            JIIndicate = new Label();
            JIonsuuUpDown = new NumericUpDown();
            onnsuu = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EDOPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nEDOselect).BeginInit();
            MeantonePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MeantoneOnnsuuUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Meantone5thUpDown).BeginInit();
            UserDifinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDifineUpDown).BeginInit();
            JIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JIonsuuUpDown).BeginInit();
            SuspendLayout();
            // 
            // TuningClose
            // 
            resources.ApplyResources(TuningClose, "TuningClose");
            TuningClose.Name = "TuningClose";
            TuningClose.UseVisualStyleBackColor = true;
            TuningClose.Click += TuningClose_Click;
            // 
            // TuningApply
            // 
            resources.ApplyResources(TuningApply, "TuningApply");
            TuningApply.Name = "TuningApply";
            TuningApply.UseVisualStyleBackColor = true;
            TuningApply.Click += TuningApply_Click;
            // 
            // nEDORadio
            // 
            resources.ApplyResources(nEDORadio, "nEDORadio");
            nEDORadio.Name = "nEDORadio";
            nEDORadio.TabStop = true;
            nEDORadio.UseVisualStyleBackColor = true;
            nEDORadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // MeantoneRadio
            // 
            resources.ApplyResources(MeantoneRadio, "MeantoneRadio");
            MeantoneRadio.Name = "MeantoneRadio";
            MeantoneRadio.TabStop = true;
            MeantoneRadio.UseVisualStyleBackColor = true;
            MeantoneRadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // JIRadio
            // 
            resources.ApplyResources(JIRadio, "JIRadio");
            JIRadio.Name = "JIRadio";
            JIRadio.TabStop = true;
            JIRadio.UseVisualStyleBackColor = true;
            JIRadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // UserDifineRadio
            // 
            resources.ApplyResources(UserDifineRadio, "UserDifineRadio");
            UserDifineRadio.Name = "UserDifineRadio";
            UserDifineRadio.TabStop = true;
            UserDifineRadio.UseVisualStyleBackColor = true;
            UserDifineRadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // EDOPanel
            // 
            resources.ApplyResources(EDOPanel, "EDOPanel");
            EDOPanel.Controls.Add(EDODirection);
            EDOPanel.Controls.Add(IndicateEDO1step);
            EDOPanel.Controls.Add(nEDOselect);
            EDOPanel.Controls.Add(SayEDOn);
            EDOPanel.Name = "EDOPanel";
            EDOPanel.Paint += EDOPanel_Paint;
            // 
            // EDODirection
            // 
            resources.ApplyResources(EDODirection, "EDODirection");
            EDODirection.Name = "EDODirection";
            EDODirection.Click += label1_Click;
            // 
            // IndicateEDO1step
            // 
            resources.ApplyResources(IndicateEDO1step, "IndicateEDO1step");
            IndicateEDO1step.Name = "IndicateEDO1step";
            IndicateEDO1step.Click += IndicateEDO1step_Click;
            // 
            // nEDOselect
            // 
            resources.ApplyResources(nEDOselect, "nEDOselect");
            nEDOselect.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            nEDOselect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nEDOselect.Name = "nEDOselect";
            nEDOselect.Value = new decimal(new int[] { 31, 0, 0, 0 });
            nEDOselect.ValueChanged += nEDOselect_ValueChanged;
            // 
            // SayEDOn
            // 
            resources.ApplyResources(SayEDOn, "SayEDOn");
            SayEDOn.Name = "SayEDOn";
            // 
            // MeantonePanel
            // 
            resources.ApplyResources(MeantonePanel, "MeantonePanel");
            MeantonePanel.Controls.Add(MeantoneOnnsuuUpDown);
            MeantonePanel.Controls.Add(MeantoneOnsuu);
            MeantonePanel.Controls.Add(MeantoneDirection);
            MeantonePanel.Controls.Add(SizeOf5th);
            MeantonePanel.Controls.Add(Meantone5thUpDown);
            MeantonePanel.Name = "MeantonePanel";
            // 
            // MeantoneOnnsuuUpDown
            // 
            resources.ApplyResources(MeantoneOnnsuuUpDown, "MeantoneOnnsuuUpDown");
            MeantoneOnnsuuUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            MeantoneOnnsuuUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MeantoneOnnsuuUpDown.Name = "MeantoneOnnsuuUpDown";
            MeantoneOnnsuuUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // MeantoneOnsuu
            // 
            resources.ApplyResources(MeantoneOnsuu, "MeantoneOnsuu");
            MeantoneOnsuu.Name = "MeantoneOnsuu";
            // 
            // MeantoneDirection
            // 
            resources.ApplyResources(MeantoneDirection, "MeantoneDirection");
            MeantoneDirection.Name = "MeantoneDirection";
            MeantoneDirection.Click += label1_Click_1;
            // 
            // SizeOf5th
            // 
            resources.ApplyResources(SizeOf5th, "SizeOf5th");
            SizeOf5th.Name = "SizeOf5th";
            // 
            // Meantone5thUpDown
            // 
            resources.ApplyResources(Meantone5thUpDown, "Meantone5thUpDown");
            Meantone5thUpDown.DecimalPlaces = 2;
            Meantone5thUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Meantone5thUpDown.Maximum = new decimal(new int[] { 1200, 0, 0, 0 });
            Meantone5thUpDown.Minimum = new decimal(new int[] { 1200, 0, 0, int.MinValue });
            Meantone5thUpDown.Name = "Meantone5thUpDown";
            Meantone5thUpDown.Value = new decimal(new int[] { 537, 0, 0, -2147352576 });
            // 
            // UserDifinePanel
            // 
            resources.ApplyResources(UserDifinePanel, "UserDifinePanel");
            UserDifinePanel.Controls.Add(UserDifineDirection);
            UserDifinePanel.Controls.Add(UserDifinePitches);
            UserDifinePanel.Controls.Add(UserDifineCents);
            UserDifinePanel.Controls.Add(UserDifineUpDown);
            UserDifinePanel.Controls.Add(UserDifineOnnsuu);
            UserDifinePanel.Name = "UserDifinePanel";
            // 
            // UserDifineDirection
            // 
            resources.ApplyResources(UserDifineDirection, "UserDifineDirection");
            UserDifineDirection.Name = "UserDifineDirection";
            // 
            // UserDifinePitches
            // 
            resources.ApplyResources(UserDifinePitches, "UserDifinePitches");
            UserDifinePitches.Name = "UserDifinePitches";
            UserDifinePitches.TextChanged += UserDifinePitches_TextChanged;
            // 
            // UserDifineCents
            // 
            resources.ApplyResources(UserDifineCents, "UserDifineCents");
            UserDifineCents.Name = "UserDifineCents";
            // 
            // UserDifineUpDown
            // 
            resources.ApplyResources(UserDifineUpDown, "UserDifineUpDown");
            UserDifineUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            UserDifineUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UserDifineUpDown.Name = "UserDifineUpDown";
            UserDifineUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            UserDifineUpDown.ValueChanged += UserDifineUpDown_ValueChanged;
            // 
            // UserDifineOnnsuu
            // 
            resources.ApplyResources(UserDifineOnnsuu, "UserDifineOnnsuu");
            UserDifineOnnsuu.Name = "UserDifineOnnsuu";
            // 
            // JIPanel
            // 
            resources.ApplyResources(JIPanel, "JIPanel");
            JIPanel.Controls.Add(JIDirection);
            JIPanel.Controls.Add(textBox1);
            JIPanel.Controls.Add(JIIndicate);
            JIPanel.Controls.Add(JIonsuuUpDown);
            JIPanel.Controls.Add(onnsuu);
            JIPanel.Name = "JIPanel";
            // 
            // JIDirection
            // 
            resources.ApplyResources(JIDirection, "JIDirection");
            JIDirection.Name = "JIDirection";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // JIIndicate
            // 
            resources.ApplyResources(JIIndicate, "JIIndicate");
            JIIndicate.Name = "JIIndicate";
            // 
            // JIonsuuUpDown
            // 
            resources.ApplyResources(JIonsuuUpDown, "JIonsuuUpDown");
            JIonsuuUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            JIonsuuUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            JIonsuuUpDown.Name = "JIonsuuUpDown";
            JIonsuuUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // onnsuu
            // 
            resources.ApplyResources(onnsuu, "onnsuu");
            onnsuu.Name = "onnsuu";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // DivitionSetting
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserDifinePanel);
            Controls.Add(JIPanel);
            Controls.Add(MeantonePanel);
            Controls.Add(EDOPanel);
            Controls.Add(UserDifineRadio);
            Controls.Add(JIRadio);
            Controls.Add(MeantoneRadio);
            Controls.Add(nEDORadio);
            Controls.Add(TuningApply);
            Controls.Add(TuningClose);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DivitionSetting";
            Load += TuningSetting_Load;
            EDOPanel.ResumeLayout(false);
            EDOPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nEDOselect).EndInit();
            MeantonePanel.ResumeLayout(false);
            MeantonePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MeantoneOnnsuuUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Meantone5thUpDown).EndInit();
            UserDifinePanel.ResumeLayout(false);
            UserDifinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDifineUpDown).EndInit();
            JIPanel.ResumeLayout(false);
            JIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JIonsuuUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TuningClose;
        private Button TuningApply;
        private RadioButton nEDORadio;
        private RadioButton MeantoneRadio;
        private RadioButton JIRadio;
        private RadioButton UserDifineRadio;
        private Panel EDOPanel;
        private Label SayEDOn;
        private NumericUpDown nEDOselect;
        private Label IndicateEDO1step;
        private Panel MeantonePanel;
        private Label SizeOf5th;
        private NumericUpDown Meantone5thUpDown;
        private Label EDODirection;
        private Label MeantoneDirection;
        private Panel JIPanel;
        private NumericUpDown JIonsuuUpDown;
        private Label onnsuu;
        private TextBox textBox1;
        private Label JIIndicate;
        private NumericUpDown MeantoneOnnsuuUpDown;
        private Label MeantoneOnsuu;
        private Label JIDirection;
        private Panel UserDifinePanel;
        private Label UserDifineDirection;
        private TextBox UserDifinePitches;
        private Label UserDifineCents;
        private NumericUpDown UserDifineUpDown;
        private Label UserDifineOnnsuu;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}