namespace TemperamentConverter
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            CancelButton = new Button();
            Reconvert = new Button();
            ApplyTuning = new Button();
            SaveTuning = new Button();
            button1 = new Button();
            TuningText = new Label();
            BaseFreqText = new Label();
            ScaleText = new Label();
            InputBaseFreq = new TextBox();
            DoTuning = new Button();
            SamplerSelect = new ComboBox();
            SamplerText = new Label();
            DoScale = new Button();
            label3 = new Label();
            label1 = new Label();
            LanguageSettingComboBox = new ComboBox();
            LanguageSettingLabel = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            resources.ApplyResources(CancelButton, "CancelButton");
            CancelButton.Name = "CancelButton";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Reconvert
            // 
            Reconvert.ForeColor = Color.Red;
            resources.ApplyResources(Reconvert, "Reconvert");
            Reconvert.Name = "Reconvert";
            Reconvert.UseVisualStyleBackColor = true;
            Reconvert.Click += Reconvert_Click;
            // 
            // ApplyTuning
            // 
            resources.ApplyResources(ApplyTuning, "ApplyTuning");
            ApplyTuning.Name = "ApplyTuning";
            ApplyTuning.UseVisualStyleBackColor = true;
            ApplyTuning.Click += ApplyTuning_Click;
            // 
            // SaveTuning
            // 
            resources.ApplyResources(SaveTuning, "SaveTuning");
            SaveTuning.Name = "SaveTuning";
            SaveTuning.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TuningText
            // 
            resources.ApplyResources(TuningText, "TuningText");
            TuningText.Name = "TuningText";
            TuningText.Click += TuningText_Click;
            // 
            // BaseFreqText
            // 
            resources.ApplyResources(BaseFreqText, "BaseFreqText");
            BaseFreqText.Name = "BaseFreqText";
            BaseFreqText.Click += BaseFreq_Click;
            // 
            // ScaleText
            // 
            resources.ApplyResources(ScaleText, "ScaleText");
            ScaleText.Name = "ScaleText";
            // 
            // InputBaseFreq
            // 
            resources.ApplyResources(InputBaseFreq, "InputBaseFreq");
            InputBaseFreq.Name = "InputBaseFreq";
            InputBaseFreq.TextChanged += InputBaseFreq_TextChanged;
            // 
            // DoTuning
            // 
            resources.ApplyResources(DoTuning, "DoTuning");
            DoTuning.Name = "DoTuning";
            DoTuning.UseVisualStyleBackColor = true;
            DoTuning.Click += DoTuning_Click;
            // 
            // SamplerSelect
            // 
            SamplerSelect.FormattingEnabled = true;
            SamplerSelect.Items.AddRange(new object[] { resources.GetString("SamplerSelect.Items") });
            resources.ApplyResources(SamplerSelect, "SamplerSelect");
            SamplerSelect.Name = "SamplerSelect";
            SamplerSelect.SelectedIndexChanged += SamplerSelect_SelectedIndexChanged;
            // 
            // SamplerText
            // 
            resources.ApplyResources(SamplerText, "SamplerText");
            SamplerText.Name = "SamplerText";
            // 
            // DoScale
            // 
            resources.ApplyResources(DoScale, "DoScale");
            DoScale.Name = "DoScale";
            DoScale.UseVisualStyleBackColor = true;
            DoScale.Click += button2_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // LanguageSettingComboBox
            // 
            LanguageSettingComboBox.FormattingEnabled = true;
            LanguageSettingComboBox.Items.AddRange(new object[] { resources.GetString("LanguageSettingComboBox.Items"), resources.GetString("LanguageSettingComboBox.Items1") });
            resources.ApplyResources(LanguageSettingComboBox, "LanguageSettingComboBox");
            LanguageSettingComboBox.Name = "LanguageSettingComboBox";
            LanguageSettingComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LanguageSettingLabel
            // 
            resources.ApplyResources(LanguageSettingLabel, "LanguageSettingLabel");
            LanguageSettingLabel.Name = "LanguageSettingLabel";
            LanguageSettingLabel.Click += label2_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // Setting
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(LanguageSettingLabel);
            Controls.Add(LanguageSettingComboBox);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(DoScale);
            Controls.Add(SamplerText);
            Controls.Add(SamplerSelect);
            Controls.Add(DoTuning);
            Controls.Add(InputBaseFreq);
            Controls.Add(ScaleText);
            Controls.Add(BaseFreqText);
            Controls.Add(TuningText);
            Controls.Add(button1);
            Controls.Add(SaveTuning);
            Controls.Add(ApplyTuning);
            Controls.Add(Reconvert);
            Controls.Add(CancelButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Setting";
            Load += Setting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button Reconvert;
        private Button ApplyTuning;
        private Button SaveTuning;
        private Button button1;
        private Label TuningText;
        private Label BaseFreqText;
        private Label ScaleText;
        private TextBox InputBaseFreq;
        private Button DoTuning;
        private ComboBox SamplerSelect;
        private Label SamplerText;
        private Button DoScale;
        private Label label3;
        private Label label1;
        private ComboBox LanguageSettingComboBox;
        private Label LanguageSettingLabel;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
