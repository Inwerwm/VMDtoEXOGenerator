namespace VMDtoEXOGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenVMD = new System.Windows.Forms.Button();
            this.labelObject = new System.Windows.Forms.Label();
            this.listBoxSetee = new System.Windows.Forms.ListBox();
            this.checkedListBoxKey = new System.Windows.Forms.CheckedListBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelFPS = new System.Windows.Forms.Label();
            this.numericFPS = new System.Windows.Forms.NumericUpDown();
            this.groupBoxExoHeader = new System.Windows.Forms.GroupBox();
            this.groupBoxRandomAudio = new System.Windows.Forms.GroupBox();
            this.labelRandomAudio = new System.Windows.Forms.Label();
            this.checkBoxRandomAudio = new System.Windows.Forms.CheckBox();
            this.labelHeaderNote = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelAudioRate = new System.Windows.Forms.Label();
            this.labelAudioCh = new System.Windows.Forms.Label();
            this.numericAudioCh = new System.Windows.Forms.NumericUpDown();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxAudioRate = new System.Windows.Forms.TextBox();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.tabControlProperty = new System.Windows.Forms.TabControl();
            this.tabPageDefault = new System.Windows.Forms.TabPage();
            this.labelObj = new System.Windows.Forms.Label();
            this.tabPageAudio = new System.Windows.Forms.TabPage();
            this.buttonAPlay = new System.Windows.Forms.Button();
            this.labelAPath = new System.Windows.Forms.Label();
            this.numericAVolume = new System.Windows.Forms.NumericUpDown();
            this.numericAPlaySpeed = new System.Windows.Forms.NumericUpDown();
            this.numericAPan = new System.Windows.Forms.NumericUpDown();
            this.numericAPlayPos = new System.Windows.Forms.NumericUpDown();
            this.labelVolume = new System.Windows.Forms.Label();
            this.numericAStartOffset = new System.Windows.Forms.NumericUpDown();
            this.labelAPan = new System.Windows.Forms.Label();
            this.labelAPlaySpeed = new System.Windows.Forms.Label();
            this.labelAPlayPos = new System.Windows.Forms.Label();
            this.labelAStartOffset = new System.Windows.Forms.Label();
            this.textBoxAFilePath = new System.Windows.Forms.TextBox();
            this.tabPageAliasM = new System.Windows.Forms.TabPage();
            this.dataGridMedia = new System.Windows.Forms.DataGridView();
            this.tabPageAliasF = new System.Windows.Forms.TabPage();
            this.dataGridViewFilter = new System.Windows.Forms.DataGridView();
            this.buttonGen = new System.Windows.Forms.Button();
            this.labelUsage = new System.Windows.Forms.Label();
            this.groupBoxUsage = new System.Windows.Forms.GroupBox();
            this.labelHeaderDesc = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonAllF = new System.Windows.Forms.Button();
            this.buttonAllInv = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericFPS)).BeginInit();
            this.groupBoxExoHeader.SuspendLayout();
            this.groupBoxRandomAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAudioCh)).BeginInit();
            this.tabControlProperty.SuspendLayout();
            this.tabPageDefault.SuspendLayout();
            this.tabPageAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAPlaySpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAPlayPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAStartOffset)).BeginInit();
            this.tabPageAliasM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedia)).BeginInit();
            this.tabPageAliasF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilter)).BeginInit();
            this.groupBoxUsage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenVMD
            // 
            this.buttonOpenVMD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenVMD.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonOpenVMD.Location = new System.Drawing.Point(16, 180);
            this.buttonOpenVMD.Name = "buttonOpenVMD";
            this.buttonOpenVMD.Size = new System.Drawing.Size(858, 61);
            this.buttonOpenVMD.TabIndex = 1;
            this.buttonOpenVMD.Text = "VMDを開く";
            this.buttonOpenVMD.UseVisualStyleBackColor = true;
            this.buttonOpenVMD.Click += new System.EventHandler(this.buttonOpenVMD_Click);
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new System.Drawing.Point(3, 0);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(112, 21);
            this.labelObject.TabIndex = 3;
            this.labelObject.Text = "設置オブジェクト";
            // 
            // listBoxSetee
            // 
            this.listBoxSetee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSetee.FormattingEnabled = true;
            this.listBoxSetee.ItemHeight = 21;
            this.listBoxSetee.Location = new System.Drawing.Point(3, 70);
            this.listBoxSetee.Name = "listBoxSetee";
            this.listBoxSetee.Size = new System.Drawing.Size(253, 319);
            this.listBoxSetee.TabIndex = 4;
            this.listBoxSetee.SelectedIndexChanged += new System.EventHandler(this.listBoxSetee_SelectedIndexChanged);
            // 
            // checkedListBoxKey
            // 
            this.checkedListBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxKey.CheckOnClick = true;
            this.tableLayoutPanel2.SetColumnSpan(this.checkedListBoxKey, 2);
            this.checkedListBoxKey.FormattingEnabled = true;
            this.checkedListBoxKey.Location = new System.Drawing.Point(3, 72);
            this.checkedListBoxKey.Name = "checkedListBoxKey";
            this.checkedListBoxKey.Size = new System.Drawing.Size(254, 316);
            this.checkedListBoxKey.TabIndex = 5;
            this.checkedListBoxKey.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxKey_ItemCheck);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(3, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(108, 21);
            this.labelKey.TabIndex = 6;
            this.labelKey.Text = "割当キーフレーム";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(6, 24);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(68, 21);
            this.labelFPS.TabIndex = 7;
            this.labelFPS.Text = "動画FPS";
            // 
            // numericFPS
            // 
            this.numericFPS.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericFPS.Location = new System.Drawing.Point(10, 49);
            this.numericFPS.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFPS.Name = "numericFPS";
            this.numericFPS.Size = new System.Drawing.Size(120, 29);
            this.numericFPS.TabIndex = 8;
            this.numericFPS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // groupBoxExoHeader
            // 
            this.groupBoxExoHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExoHeader.Controls.Add(this.groupBoxRandomAudio);
            this.groupBoxExoHeader.Controls.Add(this.checkBoxRandomAudio);
            this.groupBoxExoHeader.Controls.Add(this.labelHeaderNote);
            this.groupBoxExoHeader.Controls.Add(this.labelWidth);
            this.groupBoxExoHeader.Controls.Add(this.labelHeight);
            this.groupBoxExoHeader.Controls.Add(this.labelAudioRate);
            this.groupBoxExoHeader.Controls.Add(this.labelAudioCh);
            this.groupBoxExoHeader.Controls.Add(this.numericAudioCh);
            this.groupBoxExoHeader.Controls.Add(this.textBoxWidth);
            this.groupBoxExoHeader.Controls.Add(this.labelFPS);
            this.groupBoxExoHeader.Controls.Add(this.textBoxHeight);
            this.groupBoxExoHeader.Controls.Add(this.numericFPS);
            this.groupBoxExoHeader.Controls.Add(this.textBoxAudioRate);
            this.groupBoxExoHeader.Location = new System.Drawing.Point(16, 247);
            this.groupBoxExoHeader.Name = "groupBoxExoHeader";
            this.groupBoxExoHeader.Size = new System.Drawing.Size(858, 141);
            this.groupBoxExoHeader.TabIndex = 9;
            this.groupBoxExoHeader.TabStop = false;
            this.groupBoxExoHeader.Text = "設定";
            // 
            // groupBoxRandomAudio
            // 
            this.groupBoxRandomAudio.Controls.Add(this.labelRandomAudio);
            this.groupBoxRandomAudio.Location = new System.Drawing.Point(303, 19);
            this.groupBoxRandomAudio.Name = "groupBoxRandomAudio";
            this.groupBoxRandomAudio.Size = new System.Drawing.Size(368, 122);
            this.groupBoxRandomAudio.TabIndex = 13;
            this.groupBoxRandomAudio.TabStop = false;
            this.groupBoxRandomAudio.Text = "同キー音声ランダムについて";
            // 
            // labelRandomAudio
            // 
            this.labelRandomAudio.AutoSize = true;
            this.labelRandomAudio.Location = new System.Drawing.Point(6, 25);
            this.labelRandomAudio.Name = "labelRandomAudio";
            this.labelRandomAudio.Size = new System.Drawing.Size(357, 84);
            this.labelRandomAudio.TabIndex = 0;
            this.labelRandomAudio.Text = "同じキーフレームに複数の音声が割り当てられていた場合\r\n設置毎にランダムに選んだ1つだけを設置する\r\nOFFの場合は割り当てられている全ての音声が設置され\r\n一斉" +
    "に再生されることになる";
            // 
            // checkBoxRandomAudio
            // 
            this.checkBoxRandomAudio.AutoSize = true;
            this.checkBoxRandomAudio.Checked = true;
            this.checkBoxRandomAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandomAudio.Location = new System.Drawing.Point(150, 51);
            this.checkBoxRandomAudio.Name = "checkBoxRandomAudio";
            this.checkBoxRandomAudio.Size = new System.Drawing.Size(147, 25);
            this.checkBoxRandomAudio.TabIndex = 14;
            this.checkBoxRandomAudio.Text = "同キー音声ランダム";
            this.checkBoxRandomAudio.UseVisualStyleBackColor = true;
            // 
            // labelHeaderNote
            // 
            this.labelHeaderNote.AutoSize = true;
            this.labelHeaderNote.Location = new System.Drawing.Point(6, 89);
            this.labelHeaderNote.Name = "labelHeaderNote";
            this.labelHeaderNote.Size = new System.Drawing.Size(220, 42);
            this.labelHeaderNote.TabIndex = 9;
            this.labelHeaderNote.Text = "合わせたい動画のFPSを設定する\r\n設置フレーム計算に必要";
            // 
            // labelWidth
            // 
            this.labelWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(739, 26);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(26, 21);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "幅";
            // 
            // labelHeight
            // 
            this.labelHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(826, 26);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(26, 21);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "高";
            // 
            // labelAudioRate
            // 
            this.labelAudioRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAudioRate.AutoSize = true;
            this.labelAudioRate.Location = new System.Drawing.Point(679, 80);
            this.labelAudioRate.Name = "labelAudioRate";
            this.labelAudioRate.Size = new System.Drawing.Size(107, 21);
            this.labelAudioRate.TabIndex = 7;
            this.labelAudioRate.Text = "音声ビットレート";
            // 
            // labelAudioCh
            // 
            this.labelAudioCh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAudioCh.AutoSize = true;
            this.labelAudioCh.Location = new System.Drawing.Point(788, 80);
            this.labelAudioCh.Name = "labelAudioCh";
            this.labelAudioCh.Size = new System.Drawing.Size(58, 21);
            this.labelAudioCh.TabIndex = 7;
            this.labelAudioCh.Text = "音声ch";
            // 
            // numericAudioCh
            // 
            this.numericAudioCh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericAudioCh.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericAudioCh.Location = new System.Drawing.Point(792, 102);
            this.numericAudioCh.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericAudioCh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAudioCh.Name = "numericAudioCh";
            this.numericAudioCh.Size = new System.Drawing.Size(60, 29);
            this.numericAudioCh.TabIndex = 8;
            this.numericAudioCh.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidth.Location = new System.Drawing.Point(683, 50);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(82, 29);
            this.textBoxWidth.TabIndex = 0;
            this.textBoxWidth.Text = "1920";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeight.Location = new System.Drawing.Point(770, 49);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(82, 29);
            this.textBoxHeight.TabIndex = 0;
            this.textBoxHeight.Text = "1080";
            // 
            // textBoxAudioRate
            // 
            this.textBoxAudioRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAudioRate.Location = new System.Drawing.Point(683, 102);
            this.textBoxAudioRate.Name = "textBoxAudioRate";
            this.textBoxAudioRate.Size = new System.Drawing.Size(103, 29);
            this.textBoxAudioRate.TabIndex = 0;
            this.textBoxAudioRate.Text = "44100";
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddObject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddObject.Location = new System.Drawing.Point(3, 24);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(253, 40);
            this.buttonAddObject.TabIndex = 1;
            this.buttonAddObject.Text = "追加";
            this.buttonAddObject.UseVisualStyleBackColor = true;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // tabControlProperty
            // 
            this.tabControlProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlProperty.Controls.Add(this.tabPageDefault);
            this.tabControlProperty.Controls.Add(this.tabPageAudio);
            this.tabControlProperty.Controls.Add(this.tabPageAliasM);
            this.tabControlProperty.Controls.Add(this.tabPageAliasF);
            this.tabControlProperty.Location = new System.Drawing.Point(268, 3);
            this.tabControlProperty.Name = "tabControlProperty";
            this.tabControlProperty.SelectedIndex = 0;
            this.tabControlProperty.Size = new System.Drawing.Size(321, 393);
            this.tabControlProperty.TabIndex = 0;
            this.tabControlProperty.TabStop = false;
            this.tabControlProperty.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlProperty_Selecting);
            // 
            // tabPageDefault
            // 
            this.tabPageDefault.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDefault.Controls.Add(this.labelObj);
            this.tabPageDefault.Location = new System.Drawing.Point(4, 30);
            this.tabPageDefault.Name = "tabPageDefault";
            this.tabPageDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDefault.Size = new System.Drawing.Size(313, 359);
            this.tabPageDefault.TabIndex = 3;
            // 
            // labelObj
            // 
            this.labelObj.AutoSize = true;
            this.labelObj.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelObj.Location = new System.Drawing.Point(6, 3);
            this.labelObj.Name = "labelObj";
            this.labelObj.Size = new System.Drawing.Size(289, 259);
            this.labelObj.TabIndex = 0;
            this.labelObj.Text = "対応\r\n・ 音声(wav)\r\n・ 音声(mp3)\r\n\r\n未対応\r\n・ メディアオブジェクト(exa)\r\n・ フィルタオブジェクト(exa)";
            // 
            // tabPageAudio
            // 
            this.tabPageAudio.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAudio.Controls.Add(this.buttonAPlay);
            this.tabPageAudio.Controls.Add(this.labelAPath);
            this.tabPageAudio.Controls.Add(this.numericAVolume);
            this.tabPageAudio.Controls.Add(this.numericAPlaySpeed);
            this.tabPageAudio.Controls.Add(this.numericAPan);
            this.tabPageAudio.Controls.Add(this.numericAPlayPos);
            this.tabPageAudio.Controls.Add(this.labelVolume);
            this.tabPageAudio.Controls.Add(this.numericAStartOffset);
            this.tabPageAudio.Controls.Add(this.labelAPan);
            this.tabPageAudio.Controls.Add(this.labelAPlaySpeed);
            this.tabPageAudio.Controls.Add(this.labelAPlayPos);
            this.tabPageAudio.Controls.Add(this.labelAStartOffset);
            this.tabPageAudio.Controls.Add(this.textBoxAFilePath);
            this.tabPageAudio.Location = new System.Drawing.Point(4, 30);
            this.tabPageAudio.Name = "tabPageAudio";
            this.tabPageAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAudio.Size = new System.Drawing.Size(313, 359);
            this.tabPageAudio.TabIndex = 0;
            this.tabPageAudio.Text = "音声";
            // 
            // buttonAPlay
            // 
            this.buttonAPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAPlay.Location = new System.Drawing.Point(10, 325);
            this.buttonAPlay.Name = "buttonAPlay";
            this.buttonAPlay.Size = new System.Drawing.Size(293, 34);
            this.buttonAPlay.TabIndex = 3;
            this.buttonAPlay.Text = "▶ 再生";
            this.buttonAPlay.UseVisualStyleBackColor = true;
            this.buttonAPlay.Click += new System.EventHandler(this.buttonAPlay_Click);
            // 
            // labelAPath
            // 
            this.labelAPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAPath.AutoSize = true;
            this.labelAPath.Location = new System.Drawing.Point(6, 3);
            this.labelAPath.Name = "labelAPath";
            this.labelAPath.Size = new System.Drawing.Size(80, 21);
            this.labelAPath.TabIndex = 2;
            this.labelAPath.Text = "ファイルパス";
            // 
            // numericAVolume
            // 
            this.numericAVolume.DecimalPlaces = 1;
            this.numericAVolume.Location = new System.Drawing.Point(10, 195);
            this.numericAVolume.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericAVolume.Name = "numericAVolume";
            this.numericAVolume.Size = new System.Drawing.Size(140, 29);
            this.numericAVolume.TabIndex = 1;
            this.numericAVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericAVolume.ValueChanged += new System.EventHandler(this.numericAVolume_ValueChanged);
            // 
            // numericAPlaySpeed
            // 
            this.numericAPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericAPlaySpeed.DecimalPlaces = 1;
            this.numericAPlaySpeed.Location = new System.Drawing.Point(167, 139);
            this.numericAPlaySpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericAPlaySpeed.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericAPlaySpeed.Name = "numericAPlaySpeed";
            this.numericAPlaySpeed.Size = new System.Drawing.Size(140, 29);
            this.numericAPlaySpeed.TabIndex = 1;
            this.numericAPlaySpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericAPlaySpeed.ValueChanged += new System.EventHandler(this.numericAPlaySpeed_ValueChanged);
            // 
            // numericAPan
            // 
            this.numericAPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericAPan.DecimalPlaces = 2;
            this.numericAPan.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericAPan.Location = new System.Drawing.Point(167, 195);
            this.numericAPan.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericAPan.Name = "numericAPan";
            this.numericAPan.Size = new System.Drawing.Size(140, 29);
            this.numericAPan.TabIndex = 1;
            this.numericAPan.ValueChanged += new System.EventHandler(this.numericAPan_ValueChanged);
            // 
            // numericAPlayPos
            // 
            this.numericAPlayPos.DecimalPlaces = 2;
            this.numericAPlayPos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericAPlayPos.Location = new System.Drawing.Point(10, 139);
            this.numericAPlayPos.Name = "numericAPlayPos";
            this.numericAPlayPos.Size = new System.Drawing.Size(140, 29);
            this.numericAPlayPos.TabIndex = 1;
            this.numericAPlayPos.ValueChanged += new System.EventHandler(this.numericAPlayPos_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(6, 171);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 21);
            this.labelVolume.TabIndex = 0;
            this.labelVolume.Text = "音量";
            // 
            // numericAStartOffset
            // 
            this.numericAStartOffset.Location = new System.Drawing.Point(10, 83);
            this.numericAStartOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericAStartOffset.Name = "numericAStartOffset";
            this.numericAStartOffset.Size = new System.Drawing.Size(140, 29);
            this.numericAStartOffset.TabIndex = 1;
            this.numericAStartOffset.ValueChanged += new System.EventHandler(this.numericAStartOffset_ValueChanged);
            // 
            // labelAPan
            // 
            this.labelAPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAPan.AutoSize = true;
            this.labelAPan.Location = new System.Drawing.Point(163, 171);
            this.labelAPan.Name = "labelAPan";
            this.labelAPan.Size = new System.Drawing.Size(42, 21);
            this.labelAPan.TabIndex = 0;
            this.labelAPan.Text = "左右";
            // 
            // labelAPlaySpeed
            // 
            this.labelAPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAPlaySpeed.AutoSize = true;
            this.labelAPlaySpeed.Location = new System.Drawing.Point(163, 115);
            this.labelAPlaySpeed.Name = "labelAPlaySpeed";
            this.labelAPlaySpeed.Size = new System.Drawing.Size(74, 21);
            this.labelAPlaySpeed.TabIndex = 0;
            this.labelAPlaySpeed.Text = "再生速度";
            // 
            // labelAPlayPos
            // 
            this.labelAPlayPos.AutoSize = true;
            this.labelAPlayPos.Location = new System.Drawing.Point(6, 115);
            this.labelAPlayPos.Name = "labelAPlayPos";
            this.labelAPlayPos.Size = new System.Drawing.Size(74, 21);
            this.labelAPlayPos.TabIndex = 0;
            this.labelAPlayPos.Text = "再生位置";
            // 
            // labelAStartOffset
            // 
            this.labelAStartOffset.AutoSize = true;
            this.labelAStartOffset.Location = new System.Drawing.Point(6, 59);
            this.labelAStartOffset.Name = "labelAStartOffset";
            this.labelAStartOffset.Size = new System.Drawing.Size(144, 21);
            this.labelAStartOffset.TabIndex = 0;
            this.labelAStartOffset.Text = "設置フレームオフセット";
            // 
            // textBoxAFilePath
            // 
            this.textBoxAFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAFilePath.Location = new System.Drawing.Point(6, 27);
            this.textBoxAFilePath.Name = "textBoxAFilePath";
            this.textBoxAFilePath.ReadOnly = true;
            this.textBoxAFilePath.Size = new System.Drawing.Size(301, 29);
            this.textBoxAFilePath.TabIndex = 0;
            // 
            // tabPageAliasM
            // 
            this.tabPageAliasM.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAliasM.Controls.Add(this.dataGridMedia);
            this.tabPageAliasM.Location = new System.Drawing.Point(4, 30);
            this.tabPageAliasM.Name = "tabPageAliasM";
            this.tabPageAliasM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAliasM.Size = new System.Drawing.Size(313, 359);
            this.tabPageAliasM.TabIndex = 1;
            this.tabPageAliasM.Text = "メディア";
            // 
            // dataGridMedia
            // 
            this.dataGridMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedia.Location = new System.Drawing.Point(0, 0);
            this.dataGridMedia.Name = "dataGridMedia";
            this.dataGridMedia.RowTemplate.Height = 21;
            this.dataGridMedia.Size = new System.Drawing.Size(314, 407);
            this.dataGridMedia.TabIndex = 0;
            // 
            // tabPageAliasF
            // 
            this.tabPageAliasF.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAliasF.Controls.Add(this.dataGridViewFilter);
            this.tabPageAliasF.Location = new System.Drawing.Point(4, 30);
            this.tabPageAliasF.Name = "tabPageAliasF";
            this.tabPageAliasF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAliasF.Size = new System.Drawing.Size(313, 359);
            this.tabPageAliasF.TabIndex = 2;
            this.tabPageAliasF.Text = "フィルタ";
            // 
            // dataGridViewFilter
            // 
            this.dataGridViewFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFilter.Name = "dataGridViewFilter";
            this.dataGridViewFilter.RowTemplate.Height = 21;
            this.dataGridViewFilter.Size = new System.Drawing.Size(321, 551);
            this.dataGridViewFilter.TabIndex = 1;
            // 
            // buttonGen
            // 
            this.buttonGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGen.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGen.Location = new System.Drawing.Point(16, 800);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(858, 57);
            this.buttonGen.TabIndex = 10;
            this.buttonGen.Text = "EXOを生成";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // labelUsage
            // 
            this.labelUsage.AutoSize = true;
            this.labelUsage.Location = new System.Drawing.Point(6, 25);
            this.labelUsage.Name = "labelUsage";
            this.labelUsage.Size = new System.Drawing.Size(297, 126);
            this.labelUsage.TabIndex = 11;
            this.labelUsage.Text = "VMDを開く（複数読込可能）\r\nEXOヘッダのFPSを出力動画のFPSと合わせる\r\n設置オブジェクトそれぞれに対し\r\n・ 各種数値を設定\r\n・ ボーン名・モーフ名" +
    "を割当キーフレームから選択\r\nEXOを生成する";
            // 
            // groupBoxUsage
            // 
            this.groupBoxUsage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUsage.Controls.Add(this.labelHeaderDesc);
            this.groupBoxUsage.Controls.Add(this.labelVersion);
            this.groupBoxUsage.Controls.Add(this.labelUsage);
            this.groupBoxUsage.Location = new System.Drawing.Point(16, 12);
            this.groupBoxUsage.Name = "groupBoxUsage";
            this.groupBoxUsage.Size = new System.Drawing.Size(858, 153);
            this.groupBoxUsage.TabIndex = 12;
            this.groupBoxUsage.TabStop = false;
            this.groupBoxUsage.Text = "使い方";
            // 
            // labelHeaderDesc
            // 
            this.labelHeaderDesc.AutoSize = true;
            this.labelHeaderDesc.Location = new System.Drawing.Point(322, 25);
            this.labelHeaderDesc.Name = "labelHeaderDesc";
            this.labelHeaderDesc.Size = new System.Drawing.Size(292, 84);
            this.labelHeaderDesc.TabIndex = 13;
            this.labelHeaderDesc.Text = "幅・高・音声ビットレート・音声チャンネルは\r\nAviutlの初期読み込みが\r\n生成されたexoファイルの場合のみ意味がある\r\n先にプロジェクトが存在した場合は無視" +
    "される";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(765, 129);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(87, 21);
            this.labelVersion.TabIndex = 12;
            this.labelVersion.Text = "Version 0.0";
            // 
            // buttonAllF
            // 
            this.buttonAllF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAllF.Location = new System.Drawing.Point(3, 26);
            this.buttonAllF.Name = "buttonAllF";
            this.buttonAllF.Size = new System.Drawing.Size(124, 40);
            this.buttonAllF.TabIndex = 13;
            this.buttonAllF.Text = "全非選";
            this.buttonAllF.UseVisualStyleBackColor = true;
            this.buttonAllF.Click += new System.EventHandler(this.buttonAllF_Click);
            // 
            // buttonAllInv
            // 
            this.buttonAllInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllInv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAllInv.Location = new System.Drawing.Point(133, 26);
            this.buttonAllInv.Name = "buttonAllInv";
            this.buttonAllInv.Size = new System.Drawing.Size(124, 40);
            this.buttonAllInv.TabIndex = 13;
            this.buttonAllInv.Text = "選反転";
            this.buttonAllInv.UseVisualStyleBackColor = true;
            this.buttonAllInv.Click += new System.EventHandler(this.buttonAllInv_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControlProperty, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 394);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 399);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelKey, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkedListBoxKey, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonAllF, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonAllInv, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(595, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 393);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.buttonAddObject, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.listBoxSetee, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelObject, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(259, 393);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 869);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBoxUsage);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.groupBoxExoHeader);
            this.Controls.Add(this.buttonOpenVMD);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(899, 898);
            this.Name = "MainForm";
            this.Text = "VMD to EXO Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericFPS)).EndInit();
            this.groupBoxExoHeader.ResumeLayout(false);
            this.groupBoxExoHeader.PerformLayout();
            this.groupBoxRandomAudio.ResumeLayout(false);
            this.groupBoxRandomAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAudioCh)).EndInit();
            this.tabControlProperty.ResumeLayout(false);
            this.tabPageDefault.ResumeLayout(false);
            this.tabPageDefault.PerformLayout();
            this.tabPageAudio.ResumeLayout(false);
            this.tabPageAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAPlaySpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAPlayPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAStartOffset)).EndInit();
            this.tabPageAliasM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedia)).EndInit();
            this.tabPageAliasF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilter)).EndInit();
            this.groupBoxUsage.ResumeLayout(false);
            this.groupBoxUsage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenVMD;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.ListBox listBoxSetee;
        private System.Windows.Forms.CheckedListBox checkedListBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.NumericUpDown numericFPS;
        private System.Windows.Forms.GroupBox groupBoxExoHeader;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelAudioRate;
        private System.Windows.Forms.Label labelAudioCh;
        private System.Windows.Forms.NumericUpDown numericAudioCh;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxAudioRate;
        private System.Windows.Forms.Label labelHeaderNote;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.TabControl tabControlProperty;
        private System.Windows.Forms.TabPage tabPageAudio;
        private System.Windows.Forms.TabPage tabPageAliasM;
        private System.Windows.Forms.TabPage tabPageAliasF;
        private System.Windows.Forms.Label labelAPath;
        private System.Windows.Forms.NumericUpDown numericAVolume;
        private System.Windows.Forms.NumericUpDown numericAPlaySpeed;
        private System.Windows.Forms.NumericUpDown numericAPan;
        private System.Windows.Forms.NumericUpDown numericAPlayPos;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.NumericUpDown numericAStartOffset;
        private System.Windows.Forms.Label labelAPan;
        private System.Windows.Forms.Label labelAPlaySpeed;
        private System.Windows.Forms.Label labelAPlayPos;
        private System.Windows.Forms.Label labelAStartOffset;
        private System.Windows.Forms.TextBox textBoxAFilePath;
        private System.Windows.Forms.DataGridView dataGridMedia;
        private System.Windows.Forms.DataGridView dataGridViewFilter;
        private System.Windows.Forms.TabPage tabPageDefault;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Label labelObj;
        private System.Windows.Forms.Label labelUsage;
        private System.Windows.Forms.GroupBox groupBoxUsage;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonAllF;
        private System.Windows.Forms.Button buttonAllInv;
        private System.Windows.Forms.Button buttonAPlay;
        private System.Windows.Forms.CheckBox checkBoxRandomAudio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBoxRandomAudio;
        private System.Windows.Forms.Label labelRandomAudio;
        private System.Windows.Forms.Label labelHeaderDesc;
    }
}

