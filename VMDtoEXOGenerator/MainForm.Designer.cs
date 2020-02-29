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
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
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
            this.labelAPath = new System.Windows.Forms.Label();
            this.numericALayer = new System.Windows.Forms.NumericUpDown();
            this.labelALayer = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageAliasM = new System.Windows.Forms.TabPage();
            this.dataGridMedia = new System.Windows.Forms.DataGridView();
            this.tabPageAliasF = new System.Windows.Forms.TabPage();
            this.dataGridViewFilter = new System.Windows.Forms.DataGridView();
            this.buttonGen = new System.Windows.Forms.Button();
            this.labelUsage = new System.Windows.Forms.Label();
            this.groupBoxUsage = new System.Windows.Forms.GroupBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonAllF = new System.Windows.Forms.Button();
            this.buttonAllInv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericFPS)).BeginInit();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAudioCh)).BeginInit();
            this.tabControlProperty.SuspendLayout();
            this.tabPageDefault.SuspendLayout();
            this.tabPageAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericALayer)).BeginInit();
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
            this.SuspendLayout();
            // 
            // buttonOpenVMD
            // 
            this.buttonOpenVMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenVMD.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonOpenVMD.Location = new System.Drawing.Point(16, 180);
            this.buttonOpenVMD.Name = "buttonOpenVMD";
            this.buttonOpenVMD.Size = new System.Drawing.Size(690, 61);
            this.buttonOpenVMD.TabIndex = 1;
            this.buttonOpenVMD.Text = "VMDを開く";
            this.buttonOpenVMD.UseVisualStyleBackColor = true;
            this.buttonOpenVMD.Click += new System.EventHandler(this.buttonOpenVMD_Click);
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new System.Drawing.Point(12, 399);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(112, 21);
            this.labelObject.TabIndex = 3;
            this.labelObject.Text = "設置オブジェクト";
            // 
            // listBoxSetee
            // 
            this.listBoxSetee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxSetee.FormattingEnabled = true;
            this.listBoxSetee.ItemHeight = 21;
            this.listBoxSetee.Location = new System.Drawing.Point(16, 471);
            this.listBoxSetee.Name = "listBoxSetee";
            this.listBoxSetee.Size = new System.Drawing.Size(155, 361);
            this.listBoxSetee.TabIndex = 4;
            // 
            // checkedListBoxKey
            // 
            this.checkedListBoxKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBoxKey.CheckOnClick = true;
            this.checkedListBoxKey.FormattingEnabled = true;
            this.checkedListBoxKey.Location = new System.Drawing.Point(493, 471);
            this.checkedListBoxKey.Name = "checkedListBoxKey";
            this.checkedListBoxKey.Size = new System.Drawing.Size(213, 364);
            this.checkedListBoxKey.TabIndex = 5;
            // 
            // labelKey
            // 
            this.labelKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(494, 399);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(108, 21);
            this.labelKey.TabIndex = 6;
            this.labelKey.Text = "割当キーフレーム";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(6, 79);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(68, 21);
            this.labelFPS.TabIndex = 7;
            this.labelFPS.Text = "動画FPS";
            // 
            // numericFPS
            // 
            this.numericFPS.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericFPS.Location = new System.Drawing.Point(10, 104);
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
            // groupBoxHeader
            // 
            this.groupBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHeader.Controls.Add(this.labelHeaderNote);
            this.groupBoxHeader.Controls.Add(this.labelWidth);
            this.groupBoxHeader.Controls.Add(this.labelHeight);
            this.groupBoxHeader.Controls.Add(this.labelAudioRate);
            this.groupBoxHeader.Controls.Add(this.labelAudioCh);
            this.groupBoxHeader.Controls.Add(this.numericAudioCh);
            this.groupBoxHeader.Controls.Add(this.textBoxWidth);
            this.groupBoxHeader.Controls.Add(this.labelFPS);
            this.groupBoxHeader.Controls.Add(this.textBoxHeight);
            this.groupBoxHeader.Controls.Add(this.numericFPS);
            this.groupBoxHeader.Controls.Add(this.textBoxAudioRate);
            this.groupBoxHeader.Location = new System.Drawing.Point(16, 247);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(690, 141);
            this.groupBoxHeader.TabIndex = 9;
            this.groupBoxHeader.TabStop = false;
            this.groupBoxHeader.Text = "EXOヘッダ";
            // 
            // labelHeaderNote
            // 
            this.labelHeaderNote.AutoSize = true;
            this.labelHeaderNote.Location = new System.Drawing.Point(6, 26);
            this.labelHeaderNote.Name = "labelHeaderNote";
            this.labelHeaderNote.Size = new System.Drawing.Size(291, 42);
            this.labelHeaderNote.TabIndex = 9;
            this.labelHeaderNote.Text = "動画FPSは設置フレーム計算のため必須\r\nそれ以外は新規読み込み時以外無視される";
            // 
            // labelWidth
            // 
            this.labelWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(459, 27);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(26, 21);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "幅";
            // 
            // labelHeight
            // 
            this.labelHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(560, 27);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(26, 21);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "高";
            // 
            // labelAudioRate
            // 
            this.labelAudioRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAudioRate.AutoSize = true;
            this.labelAudioRate.Location = new System.Drawing.Point(459, 81);
            this.labelAudioRate.Name = "labelAudioRate";
            this.labelAudioRate.Size = new System.Drawing.Size(107, 21);
            this.labelAudioRate.TabIndex = 7;
            this.labelAudioRate.Text = "音声ビットレート";
            // 
            // labelAudioCh
            // 
            this.labelAudioCh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAudioCh.AutoSize = true;
            this.labelAudioCh.Location = new System.Drawing.Point(560, 81);
            this.labelAudioCh.Name = "labelAudioCh";
            this.labelAudioCh.Size = new System.Drawing.Size(103, 21);
            this.labelAudioCh.TabIndex = 7;
            this.labelAudioCh.Text = "音声チャンネル";
            // 
            // numericAudioCh
            // 
            this.numericAudioCh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericAudioCh.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericAudioCh.Location = new System.Drawing.Point(564, 104);
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
            this.numericAudioCh.Size = new System.Drawing.Size(120, 29);
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
            this.textBoxWidth.Location = new System.Drawing.Point(463, 49);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(95, 29);
            this.textBoxWidth.TabIndex = 0;
            this.textBoxWidth.Text = "1920";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeight.Location = new System.Drawing.Point(564, 49);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(104, 29);
            this.textBoxHeight.TabIndex = 0;
            this.textBoxHeight.Text = "1080";
            // 
            // textBoxAudioRate
            // 
            this.textBoxAudioRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAudioRate.Location = new System.Drawing.Point(463, 104);
            this.textBoxAudioRate.Name = "textBoxAudioRate";
            this.textBoxAudioRate.Size = new System.Drawing.Size(95, 29);
            this.textBoxAudioRate.TabIndex = 0;
            this.textBoxAudioRate.Text = "44100";
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddObject.Location = new System.Drawing.Point(16, 423);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(155, 46);
            this.buttonAddObject.TabIndex = 1;
            this.buttonAddObject.Text = "追加";
            this.buttonAddObject.UseVisualStyleBackColor = true;
            // 
            // tabControlProperty
            // 
            this.tabControlProperty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlProperty.Controls.Add(this.tabPageDefault);
            this.tabControlProperty.Controls.Add(this.tabPageAudio);
            this.tabControlProperty.Controls.Add(this.tabPageAliasM);
            this.tabControlProperty.Controls.Add(this.tabPageAliasF);
            this.tabControlProperty.Location = new System.Drawing.Point(171, 394);
            this.tabControlProperty.Name = "tabControlProperty";
            this.tabControlProperty.SelectedIndex = 0;
            this.tabControlProperty.Size = new System.Drawing.Size(322, 441);
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
            this.tabPageDefault.Size = new System.Drawing.Size(314, 407);
            this.tabPageDefault.TabIndex = 3;
            // 
            // labelObj
            // 
            this.labelObj.AutoSize = true;
            this.labelObj.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelObj.Location = new System.Drawing.Point(6, 3);
            this.labelObj.Name = "labelObj";
            this.labelObj.Size = new System.Drawing.Size(289, 222);
            this.labelObj.TabIndex = 0;
            this.labelObj.Text = "対応形式\r\n・ 音声(wav)\r\n\r\n未対応\r\n・ メディアオブジェクト(exa)\r\n・ フィルタオブジェクト(exa)";
            // 
            // tabPageAudio
            // 
            this.tabPageAudio.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAudio.Controls.Add(this.labelAPath);
            this.tabPageAudio.Controls.Add(this.numericALayer);
            this.tabPageAudio.Controls.Add(this.labelALayer);
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
            this.tabPageAudio.Controls.Add(this.textBox1);
            this.tabPageAudio.Location = new System.Drawing.Point(4, 30);
            this.tabPageAudio.Name = "tabPageAudio";
            this.tabPageAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAudio.Size = new System.Drawing.Size(314, 407);
            this.tabPageAudio.TabIndex = 0;
            this.tabPageAudio.Text = "音声";
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
            // numericALayer
            // 
            this.numericALayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericALayer.Location = new System.Drawing.Point(163, 83);
            this.numericALayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericALayer.Name = "numericALayer";
            this.numericALayer.Size = new System.Drawing.Size(140, 29);
            this.numericALayer.TabIndex = 1;
            this.numericALayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelALayer
            // 
            this.labelALayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelALayer.AutoSize = true;
            this.labelALayer.Location = new System.Drawing.Point(159, 59);
            this.labelALayer.Name = "labelALayer";
            this.labelALayer.Size = new System.Drawing.Size(55, 21);
            this.labelALayer.TabIndex = 0;
            this.labelALayer.Text = "レイヤー";
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
            // 
            // numericAPlaySpeed
            // 
            this.numericAPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericAPlaySpeed.DecimalPlaces = 1;
            this.numericAPlaySpeed.Location = new System.Drawing.Point(163, 139);
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
            this.numericAPan.Location = new System.Drawing.Point(163, 195);
            this.numericAPan.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericAPan.Name = "numericAPan";
            this.numericAPan.Size = new System.Drawing.Size(140, 29);
            this.numericAPan.TabIndex = 1;
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
            // 
            // labelAPan
            // 
            this.labelAPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAPan.AutoSize = true;
            this.labelAPan.Location = new System.Drawing.Point(159, 171);
            this.labelAPan.Name = "labelAPan";
            this.labelAPan.Size = new System.Drawing.Size(42, 21);
            this.labelAPan.TabIndex = 0;
            this.labelAPan.Text = "左右";
            // 
            // labelAPlaySpeed
            // 
            this.labelAPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAPlaySpeed.AutoSize = true;
            this.labelAPlaySpeed.Location = new System.Drawing.Point(159, 115);
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 29);
            this.textBox1.TabIndex = 0;
            // 
            // tabPageAliasM
            // 
            this.tabPageAliasM.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAliasM.Controls.Add(this.dataGridMedia);
            this.tabPageAliasM.Location = new System.Drawing.Point(4, 30);
            this.tabPageAliasM.Name = "tabPageAliasM";
            this.tabPageAliasM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAliasM.Size = new System.Drawing.Size(314, 407);
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
            this.tabPageAliasF.Size = new System.Drawing.Size(314, 407);
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
            this.buttonGen.Location = new System.Drawing.Point(16, 942);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(690, 57);
            this.buttonGen.TabIndex = 10;
            this.buttonGen.Text = "EXOを生成";
            this.buttonGen.UseVisualStyleBackColor = true;
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
            this.groupBoxUsage.Controls.Add(this.labelVersion);
            this.groupBoxUsage.Controls.Add(this.labelUsage);
            this.groupBoxUsage.Location = new System.Drawing.Point(16, 12);
            this.groupBoxUsage.Name = "groupBoxUsage";
            this.groupBoxUsage.Size = new System.Drawing.Size(690, 153);
            this.groupBoxUsage.TabIndex = 12;
            this.groupBoxUsage.TabStop = false;
            this.groupBoxUsage.Text = "使い方";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(597, 129);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(87, 21);
            this.labelVersion.TabIndex = 12;
            this.labelVersion.Text = "Version 0.0";
            // 
            // buttonAllF
            // 
            this.buttonAllF.Location = new System.Drawing.Point(495, 423);
            this.buttonAllF.Name = "buttonAllF";
            this.buttonAllF.Size = new System.Drawing.Size(75, 42);
            this.buttonAllF.TabIndex = 13;
            this.buttonAllF.Text = "全非選";
            this.buttonAllF.UseVisualStyleBackColor = true;
            this.buttonAllF.Click += new System.EventHandler(this.buttonAllF_Click);
            // 
            // buttonAllInv
            // 
            this.buttonAllInv.Location = new System.Drawing.Point(631, 425);
            this.buttonAllInv.Name = "buttonAllInv";
            this.buttonAllInv.Size = new System.Drawing.Size(75, 42);
            this.buttonAllInv.TabIndex = 13;
            this.buttonAllInv.Text = "選反転";
            this.buttonAllInv.UseVisualStyleBackColor = true;
            this.buttonAllInv.Click += new System.EventHandler(this.buttonAllInv_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 1003);
            this.Controls.Add(this.buttonAllInv);
            this.Controls.Add(this.buttonAllF);
            this.Controls.Add(this.groupBoxUsage);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.tabControlProperty);
            this.Controls.Add(this.groupBoxHeader);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.checkedListBoxKey);
            this.Controls.Add(this.listBoxSetee);
            this.Controls.Add(this.labelObject);
            this.Controls.Add(this.buttonAddObject);
            this.Controls.Add(this.buttonOpenVMD);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(732, 574);
            this.Name = "MainForm";
            this.Text = "VMD to EXO Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericFPS)).EndInit();
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAudioCh)).EndInit();
            this.tabControlProperty.ResumeLayout(false);
            this.tabPageDefault.ResumeLayout(false);
            this.tabPageDefault.PerformLayout();
            this.tabPageAudio.ResumeLayout(false);
            this.tabPageAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericALayer)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenVMD;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.ListBox listBoxSetee;
        private System.Windows.Forms.CheckedListBox checkedListBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.NumericUpDown numericFPS;
        private System.Windows.Forms.GroupBox groupBoxHeader;
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
        private System.Windows.Forms.NumericUpDown numericALayer;
        private System.Windows.Forms.Label labelALayer;
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

