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
            TuningClose = new Button();
            TuningApply = new Button();
            nEDORadio = new RadioButton();
            MeantoneRadio = new RadioButton();
            JIRadio = new RadioButton();
            UserDifineRadio = new RadioButton();
            EDOPanel = new Panel();
            IndicateEDO1step = new Label();
            EDODirection = new Label();
            nEDOselect = new NumericUpDown();
            SayEDOn = new Label();
            MeantonePanel = new Panel();
            MeantoneOnnsuuUpDown = new NumericUpDown();
            MeantoneOnsuu = new Label();
            MeantoneDirection = new Label();
            SizeOf5th = new Label();
            Meantone5thUpDown = new NumericUpDown();
            JIPanel = new Panel();
            JIDirection = new Label();
            textBox1 = new TextBox();
            JIIndicate = new Label();
            JIonsuuUpDown = new NumericUpDown();
            onnsuu = new Label();
            UserDifinePanel = new Panel();
            UserDifineDirection = new Label();
            UserDifinePitches = new TextBox();
            UserDifineCents = new Label();
            UserDifineUpDown = new NumericUpDown();
            UserDifineOnnsuu = new Label();
            EDOPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nEDOselect).BeginInit();
            MeantonePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MeantoneOnnsuuUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Meantone5thUpDown).BeginInit();
            JIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JIonsuuUpDown).BeginInit();
            UserDifinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDifineUpDown).BeginInit();
            SuspendLayout();
            // 
            // TuningClose
            // 
            TuningClose.Location = new Point(299, 409);
            TuningClose.Name = "TuningClose";
            TuningClose.Size = new Size(94, 29);
            TuningClose.TabIndex = 0;
            TuningClose.Text = "閉じる";
            TuningClose.UseVisualStyleBackColor = true;
            TuningClose.Click += TuningClose_Click;
            // 
            // TuningApply
            // 
            TuningApply.Location = new Point(199, 409);
            TuningApply.Name = "TuningApply";
            TuningApply.Size = new Size(94, 29);
            TuningApply.TabIndex = 1;
            TuningApply.Text = "適用";
            TuningApply.UseVisualStyleBackColor = true;
            // 
            // nEDORadio
            // 
            nEDORadio.AutoSize = true;
            nEDORadio.Location = new Point(12, 12);
            nEDORadio.Name = "nEDORadio";
            nEDORadio.Size = new Size(100, 29);
            nEDORadio.TabIndex = 2;
            nEDORadio.TabStop = true;
            nEDORadio.Text = "n平均律";
            nEDORadio.UseVisualStyleBackColor = true;
            nEDORadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // MeantoneRadio
            // 
            MeantoneRadio.AutoSize = true;
            MeantoneRadio.Location = new Point(156, 12);
            MeantoneRadio.Name = "MeantoneRadio";
            MeantoneRadio.Size = new Size(109, 29);
            MeantoneRadio.TabIndex = 3;
            MeantoneRadio.TabStop = true;
            MeantoneRadio.Text = "中全音律";
            MeantoneRadio.UseVisualStyleBackColor = true;
            MeantoneRadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // JIRadio
            // 
            JIRadio.AutoSize = true;
            JIRadio.Location = new Point(12, 47);
            JIRadio.Name = "JIRadio";
            JIRadio.Size = new Size(90, 29);
            JIRadio.TabIndex = 4;
            JIRadio.TabStop = true;
            JIRadio.Text = "純正律";
            JIRadio.UseVisualStyleBackColor = true;
            JIRadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // UserDifineRadio
            // 
            UserDifineRadio.AutoSize = true;
            UserDifineRadio.Location = new Point(156, 47);
            UserDifineRadio.Name = "UserDifineRadio";
            UserDifineRadio.Size = new Size(176, 29);
            UserDifineRadio.TabIndex = 5;
            UserDifineRadio.TabStop = true;
            UserDifineRadio.Text = "ユーザ定義分割法";
            UserDifineRadio.UseVisualStyleBackColor = true;
            UserDifineRadio.CheckedChanged += WholeRadioButton_CheckedChanged;
            // 
            // EDOPanel
            // 
            EDOPanel.Controls.Add(IndicateEDO1step);
            EDOPanel.Controls.Add(EDODirection);
            EDOPanel.Controls.Add(nEDOselect);
            EDOPanel.Controls.Add(SayEDOn);
            EDOPanel.Location = new Point(64, 128);
            EDOPanel.Name = "EDOPanel";
            EDOPanel.Size = new Size(256, 256);
            EDOPanel.TabIndex = 6;
            EDOPanel.Paint += EDOPanel_Paint;
            // 
            // IndicateEDO1step
            // 
            IndicateEDO1step.AutoSize = true;
            IndicateEDO1step.Location = new Point(32, 71);
            IndicateEDO1step.Name = "IndicateEDO1step";
            IndicateEDO1step.Size = new Size(59, 25);
            IndicateEDO1step.TabIndex = 3;
            IndicateEDO1step.Text = "label1";
            // 
            // EDODirection
            // 
            EDODirection.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EDODirection.Location = new Point(12, 133);
            EDODirection.Name = "EDODirection";
            EDODirection.Size = new Size(231, 112);
            EDODirection.TabIndex = 2;
            EDODirection.Text = "nの横のフィールドに何平均律か入れてください。19EDOなら19を、7EDOなら7を入れてください。その下に、その平均律の時1stepあたり何centか示されます。実際は違う可能性があります。参考値程度に。\r\n";
            EDODirection.Click += label1_Click;
            // 
            // nEDOselect
            // 
            nEDOselect.Location = new Point(77, 26);
            nEDOselect.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            nEDOselect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nEDOselect.Name = "nEDOselect";
            nEDOselect.Size = new Size(150, 31);
            nEDOselect.TabIndex = 1;
            nEDOselect.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // SayEDOn
            // 
            SayEDOn.AutoSize = true;
            SayEDOn.Location = new Point(32, 28);
            SayEDOn.Name = "SayEDOn";
            SayEDOn.Size = new Size(39, 25);
            SayEDOn.TabIndex = 0;
            SayEDOn.Text = "n =";
            // 
            // MeantonePanel
            // 
            MeantonePanel.Controls.Add(MeantoneOnnsuuUpDown);
            MeantonePanel.Controls.Add(MeantoneOnsuu);
            MeantonePanel.Controls.Add(MeantoneDirection);
            MeantonePanel.Controls.Add(SizeOf5th);
            MeantonePanel.Controls.Add(Meantone5thUpDown);
            MeantonePanel.Location = new Point(64, 128);
            MeantonePanel.Name = "MeantonePanel";
            MeantonePanel.Size = new Size(256, 256);
            MeantonePanel.TabIndex = 7;
            // 
            // MeantoneOnnsuuUpDown
            // 
            MeantoneOnnsuuUpDown.Location = new Point(94, 22);
            MeantoneOnnsuuUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            MeantoneOnnsuuUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MeantoneOnnsuuUpDown.Name = "MeantoneOnnsuuUpDown";
            MeantoneOnnsuuUpDown.Size = new Size(150, 31);
            MeantoneOnnsuuUpDown.TabIndex = 5;
            MeantoneOnnsuuUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // MeantoneOnsuu
            // 
            MeantoneOnsuu.AutoSize = true;
            MeantoneOnsuu.Location = new Point(28, 24);
            MeantoneOnsuu.Name = "MeantoneOnsuu";
            MeantoneOnsuu.Size = new Size(50, 25);
            MeantoneOnsuu.TabIndex = 4;
            MeantoneOnsuu.Text = "音数";
            // 
            // MeantoneDirection
            // 
            MeantoneDirection.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MeantoneDirection.Location = new Point(12, 133);
            MeantoneDirection.Name = "MeantoneDirection";
            MeantoneDirection.Size = new Size(231, 112);
            MeantoneDirection.TabIndex = 4;
            MeantoneDirection.Text = "音数を決め、五度の大きさを指定してください。701.96centから何cent引くか足すかを決めます。1/4コンマ中全音律なら-5.37を、1/3コンマ中全音律なら-7.18を入力します。\r\n";
            MeantoneDirection.Click += label1_Click_1;
            // 
            // SizeOf5th
            // 
            SizeOf5th.AutoSize = true;
            SizeOf5th.Location = new Point(68, 71);
            SizeOf5th.Name = "SizeOf5th";
            SizeOf5th.Size = new Size(112, 25);
            SizeOf5th.TabIndex = 1;
            SizeOf5th.Text = "五度の大きさ";
            // 
            // Meantone5thUpDown
            // 
            Meantone5thUpDown.DecimalPlaces = 2;
            Meantone5thUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Meantone5thUpDown.Location = new Point(51, 99);
            Meantone5thUpDown.Maximum = new decimal(new int[] { 1200, 0, 0, 0 });
            Meantone5thUpDown.Minimum = new decimal(new int[] { 1200, 0, 0, int.MinValue });
            Meantone5thUpDown.Name = "Meantone5thUpDown";
            Meantone5thUpDown.Size = new Size(150, 31);
            Meantone5thUpDown.TabIndex = 0;
            Meantone5thUpDown.Value = new decimal(new int[] { 537, 0, 0, -2147352576 });
            // 
            // JIPanel
            // 
            JIPanel.Controls.Add(JIDirection);
            JIPanel.Controls.Add(textBox1);
            JIPanel.Controls.Add(JIIndicate);
            JIPanel.Controls.Add(JIonsuuUpDown);
            JIPanel.Controls.Add(onnsuu);
            JIPanel.Location = new Point(64, 128);
            JIPanel.Name = "JIPanel";
            JIPanel.Size = new Size(256, 256);
            JIPanel.TabIndex = 8;
            // 
            // JIDirection
            // 
            JIDirection.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JIDirection.Location = new Point(11, 129);
            JIDirection.Name = "JIDirection";
            JIDirection.Size = new Size(231, 123);
            JIDirection.TabIndex = 4;
            JIDirection.Text = "音数を決め、各step毎の純正比を入力してください。必ず音数と純正比の数を合わせてください。[ignore]が入ったstepはt0として書き出します。5-limit JIだったら、[1/1, 16/15, 9/8, 6/5, 5/4, 4/3, ignore, 3/2, 8/5, 5/3, 9/5, 15/8]のように書きます。\r\n\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 31);
            textBox1.TabIndex = 3;
            // 
            // JIIndicate
            // 
            JIIndicate.AutoSize = true;
            JIIndicate.Location = new Point(92, 65);
            JIIndicate.Name = "JIIndicate";
            JIIndicate.Size = new Size(69, 25);
            JIIndicate.TabIndex = 2;
            JIIndicate.Text = "純正比";
            // 
            // JIonsuuUpDown
            // 
            JIonsuuUpDown.Location = new Point(92, 24);
            JIonsuuUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            JIonsuuUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            JIonsuuUpDown.Name = "JIonsuuUpDown";
            JIonsuuUpDown.Size = new Size(150, 31);
            JIonsuuUpDown.TabIndex = 1;
            JIonsuuUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // onnsuu
            // 
            onnsuu.AutoSize = true;
            onnsuu.Location = new Point(26, 26);
            onnsuu.Name = "onnsuu";
            onnsuu.Size = new Size(50, 25);
            onnsuu.TabIndex = 0;
            onnsuu.Text = "音数";
            // 
            // UserDifinePanel
            // 
            UserDifinePanel.Controls.Add(UserDifineDirection);
            UserDifinePanel.Controls.Add(UserDifinePitches);
            UserDifinePanel.Controls.Add(UserDifineCents);
            UserDifinePanel.Controls.Add(UserDifineUpDown);
            UserDifinePanel.Controls.Add(UserDifineOnnsuu);
            UserDifinePanel.Location = new Point(64, 128);
            UserDifinePanel.Name = "UserDifinePanel";
            UserDifinePanel.Size = new Size(256, 256);
            UserDifinePanel.TabIndex = 9;
            // 
            // UserDifineDirection
            // 
            UserDifineDirection.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserDifineDirection.Location = new Point(11, 129);
            UserDifineDirection.Name = "UserDifineDirection";
            UserDifineDirection.Size = new Size(231, 123);
            UserDifineDirection.TabIndex = 4;
            UserDifineDirection.Text = "音数を決め、各step毎の純正比を入力してください。必ず音数と純正比の数を合わせてください。[ignore]が入ったstepはt0として書き出します。5-limit JIだったら、[1/1, 16/15, 9/8, 6/5, 5/4, 4/3, ignore, 3/2, 8/5, 5/3, 9/5, 15/8]のように書きます。\r\n\r\n";
            // 
            // UserDifinePitches
            // 
            UserDifinePitches.Location = new Point(3, 95);
            UserDifinePitches.Name = "UserDifinePitches";
            UserDifinePitches.Size = new Size(250, 31);
            UserDifinePitches.TabIndex = 3;
            // 
            // UserDifineCents
            // 
            UserDifineCents.AutoSize = true;
            UserDifineCents.Location = new Point(65, 65);
            UserDifineCents.Name = "UserDifineCents";
            UserDifineCents.Size = new Size(136, 25);
            UserDifineCents.TabIndex = 2;
            UserDifineCents.Text = "ユーザ定義分割";
            // 
            // UserDifineUpDown
            // 
            UserDifineUpDown.Location = new Point(92, 24);
            UserDifineUpDown.Maximum = new decimal(new int[] { 0, 1, 0, 0 });
            UserDifineUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UserDifineUpDown.Name = "UserDifineUpDown";
            UserDifineUpDown.Size = new Size(150, 31);
            UserDifineUpDown.TabIndex = 1;
            UserDifineUpDown.Value = new decimal(new int[] { 0, 1, 0, 0 });
            // 
            // UserDifineOnnsuu
            // 
            UserDifineOnnsuu.AutoSize = true;
            UserDifineOnnsuu.Location = new Point(26, 26);
            UserDifineOnnsuu.Name = "UserDifineOnnsuu";
            UserDifineOnnsuu.Size = new Size(50, 25);
            UserDifineOnnsuu.TabIndex = 0;
            UserDifineOnnsuu.Text = "音数";
            // 
            // DivitionSetting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 453);
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
            Text = "分割設定";
            Load += TuningSetting_Load;
            EDOPanel.ResumeLayout(false);
            EDOPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nEDOselect).EndInit();
            MeantonePanel.ResumeLayout(false);
            MeantonePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MeantoneOnnsuuUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Meantone5thUpDown).EndInit();
            JIPanel.ResumeLayout(false);
            JIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JIonsuuUpDown).EndInit();
            UserDifinePanel.ResumeLayout(false);
            UserDifinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDifineUpDown).EndInit();
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
    }
}