namespace Fredro
{
    partial class frmFredro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFredro));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnBindFile = new DevExpress.XtraEditors.SimpleButton();
            this.chcbeSelectedSymbols = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.sePeriod = new DevExpress.XtraEditors.SpinEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.meLog = new DevExpress.XtraEditors.MemoEdit();
            this.teCheckedUrl = new DevExpress.XtraEditors.TextEdit();
            this.teBaseUrl = new DevExpress.XtraEditors.TextEdit();
            this.teOutputFile = new DevExpress.XtraEditors.TextEdit();
            this.seExtraPartLength = new DevExpress.XtraEditors.SpinEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgHead = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBaseUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCheckedUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSelectedSymbols = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOutputFile = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBindFile = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciExtraPartLength = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCheckedInterval = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgLog = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLog = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chcbeSelectedSymbols.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCheckedUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBaseUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOutputFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seExtraPartLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBaseUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCheckedUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelectedSymbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOutputFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBindFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExtraPartLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCheckedInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Appearance.ControlDisabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.ControlDisabled.Options.UseFont = true;
            this.lcMain.Appearance.ControlReadOnly.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.ControlReadOnly.Options.UseFont = true;
            this.lcMain.Appearance.DisabledLayoutItem.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.Color.Black;
            this.lcMain.Appearance.DisabledLayoutItem.Options.UseFont = true;
            this.lcMain.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.lcMain.Controls.Add(this.btnBindFile);
            this.lcMain.Controls.Add(this.chcbeSelectedSymbols);
            this.lcMain.Controls.Add(this.sePeriod);
            this.lcMain.Controls.Add(this.btnCancel);
            this.lcMain.Controls.Add(this.btnStart);
            this.lcMain.Controls.Add(this.meLog);
            this.lcMain.Controls.Add(this.teCheckedUrl);
            this.lcMain.Controls.Add(this.teBaseUrl);
            this.lcMain.Controls.Add(this.teOutputFile);
            this.lcMain.Controls.Add(this.seExtraPartLength);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(542, 653);
            this.lcMain.TabIndex = 0;
            // 
            // btnBindFile
            // 
            this.btnBindFile.Image = ((System.Drawing.Image)(resources.GetObject("btnBindFile.Image")));
            this.btnBindFile.Location = new System.Drawing.Point(436, 195);
            this.btnBindFile.Name = "btnBindFile";
            this.btnBindFile.Size = new System.Drawing.Size(96, 28);
            this.btnBindFile.StyleController = this.lcMain;
            this.btnBindFile.TabIndex = 12;
            this.btnBindFile.Text = "Выбрать";
            this.btnBindFile.Click += new System.EventHandler(this.btnBindFile_Click);
            // 
            // chcbeSelectedSymbols
            // 
            this.chcbeSelectedSymbols.EditValue = "";
            this.chcbeSelectedSymbols.Location = new System.Drawing.Point(187, 164);
            this.chcbeSelectedSymbols.Name = "chcbeSelectedSymbols";
            this.chcbeSelectedSymbols.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chcbeSelectedSymbols.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(1)), "Цифры, буквы (оба регистра)"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(2)), "Цифры, буквы (нижний регистр)"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(((short)(3)), "Цифры")});
            this.chcbeSelectedSymbols.Properties.SelectAllItemVisible = false;
            this.chcbeSelectedSymbols.Size = new System.Drawing.Size(345, 28);
            this.chcbeSelectedSymbols.StyleController = this.lcMain;
            this.chcbeSelectedSymbols.TabIndex = 11;
            // 
            // sePeriod
            // 
            this.sePeriod.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePeriod.Location = new System.Drawing.Point(187, 100);
            this.sePeriod.Name = "sePeriod";
            this.sePeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePeriod.Properties.IsFloatValue = false;
            this.sePeriod.Properties.Mask.EditMask = "N00";
            this.sePeriod.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sePeriod.Size = new System.Drawing.Size(345, 28);
            this.sePeriod.StyleController = this.lcMain;
            this.sePeriod.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(267, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(268, 44);
            this.btnCancel.StyleController = this.lcMain;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = " ЧСВ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(7, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(256, 44);
            this.btnStart.StyleController = this.lcMain;
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Сбайтить флекс";
            this.btnStart.Click += new System.EventHandler(this.OnBtnStartClickAsync);
            // 
            // meLog
            // 
            this.meLog.Location = new System.Drawing.Point(10, 308);
            this.meLog.Name = "meLog";
            this.meLog.Size = new System.Drawing.Size(522, 335);
            this.meLog.StyleController = this.lcMain;
            this.meLog.TabIndex = 6;
            // 
            // teCheckedUrl
            // 
            this.teCheckedUrl.Location = new System.Drawing.Point(187, 68);
            this.teCheckedUrl.Name = "teCheckedUrl";
            this.teCheckedUrl.Size = new System.Drawing.Size(345, 28);
            this.teCheckedUrl.StyleController = this.lcMain;
            this.teCheckedUrl.TabIndex = 5;
            // 
            // teBaseUrl
            // 
            this.teBaseUrl.Location = new System.Drawing.Point(187, 36);
            this.teBaseUrl.Name = "teBaseUrl";
            this.teBaseUrl.Size = new System.Drawing.Size(345, 28);
            this.teBaseUrl.StyleController = this.lcMain;
            this.teBaseUrl.TabIndex = 4;
            // 
            // teOutputFile
            // 
            this.teOutputFile.Location = new System.Drawing.Point(187, 196);
            this.teOutputFile.Name = "teOutputFile";
            this.teOutputFile.Properties.AllowFocused = false;
            this.teOutputFile.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.teOutputFile.Properties.Appearance.Options.UseForeColor = true;
            this.teOutputFile.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.teOutputFile.Properties.AppearanceDisabled.Options.UseFont = true;
            this.teOutputFile.Properties.ReadOnly = true;
            this.teOutputFile.Size = new System.Drawing.Size(245, 28);
            this.teOutputFile.StyleController = this.lcMain;
            this.teOutputFile.TabIndex = 4;
            // 
            // seExtraPartLength
            // 
            this.seExtraPartLength.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seExtraPartLength.Location = new System.Drawing.Point(187, 132);
            this.seExtraPartLength.Name = "seExtraPartLength";
            this.seExtraPartLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seExtraPartLength.Properties.IsFloatValue = false;
            this.seExtraPartLength.Properties.Mask.EditMask = "N00";
            this.seExtraPartLength.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seExtraPartLength.Size = new System.Drawing.Size(345, 28);
            this.seExtraPartLength.StyleController = this.lcMain;
            this.seExtraPartLength.TabIndex = 10;
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMain.AppearanceGroup.Options.UseFont = true;
            this.lcgMain.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMain.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgHead,
            this.lciStart,
            this.lciCancel,
            this.lcgLog});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMain.Size = new System.Drawing.Size(542, 653);
            this.lcgMain.TextVisible = false;
            // 
            // lcgHead
            // 
            this.lcgHead.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBaseUrl,
            this.lciCheckedUrl,
            this.lciSelectedSymbols,
            this.lciOutputFile,
            this.lciBindFile,
            this.lciExtraPartLength,
            this.lciCheckedInterval});
            this.lcgHead.Location = new System.Drawing.Point(0, 0);
            this.lcgHead.Name = "lcgHead";
            this.lcgHead.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgHead.Size = new System.Drawing.Size(532, 224);
            this.lcgHead.Text = "Входные данные";
            // 
            // lciBaseUrl
            // 
            this.lciBaseUrl.Control = this.teBaseUrl;
            this.lciBaseUrl.CustomizationFormText = " Базовая часть адреса";
            this.lciBaseUrl.Location = new System.Drawing.Point(0, 0);
            this.lciBaseUrl.Name = "lciBaseUrl";
            this.lciBaseUrl.Size = new System.Drawing.Size(526, 32);
            this.lciBaseUrl.Text = " Базовая часть адреса";
            this.lciBaseUrl.TextSize = new System.Drawing.Size(174, 21);
            // 
            // lciCheckedUrl
            // 
            this.lciCheckedUrl.Control = this.teCheckedUrl;
            this.lciCheckedUrl.CustomizationFormText = " Проверочный адрес";
            this.lciCheckedUrl.Location = new System.Drawing.Point(0, 32);
            this.lciCheckedUrl.Name = "lciCheckedUrl";
            this.lciCheckedUrl.Size = new System.Drawing.Size(526, 32);
            this.lciCheckedUrl.Text = " Проверочный адрес";
            this.lciCheckedUrl.TextSize = new System.Drawing.Size(174, 21);
            // 
            // lciSelectedSymbols
            // 
            this.lciSelectedSymbols.Control = this.chcbeSelectedSymbols;
            this.lciSelectedSymbols.Location = new System.Drawing.Point(0, 128);
            this.lciSelectedSymbols.Name = "lciSelectedSymbols";
            this.lciSelectedSymbols.Size = new System.Drawing.Size(526, 32);
            this.lciSelectedSymbols.Text = " Тип символов";
            this.lciSelectedSymbols.TextSize = new System.Drawing.Size(174, 21);
            // 
            // lciOutputFile
            // 
            this.lciOutputFile.Control = this.teOutputFile;
            this.lciOutputFile.CustomizationFormText = "Базовая часть адреса:";
            this.lciOutputFile.Location = new System.Drawing.Point(0, 160);
            this.lciOutputFile.Name = "lciOutputFile";
            this.lciOutputFile.Size = new System.Drawing.Size(426, 32);
            this.lciOutputFile.Text = " Файл для сохранения";
            this.lciOutputFile.TextSize = new System.Drawing.Size(174, 21);
            // 
            // lciBindFile
            // 
            this.lciBindFile.Control = this.btnBindFile;
            this.lciBindFile.Location = new System.Drawing.Point(426, 160);
            this.lciBindFile.Name = "lciBindFile";
            this.lciBindFile.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 1, 3);
            this.lciBindFile.Size = new System.Drawing.Size(100, 32);
            this.lciBindFile.TextSize = new System.Drawing.Size(0, 0);
            this.lciBindFile.TextVisible = false;
            // 
            // lciExtraPartLength
            // 
            this.lciExtraPartLength.Control = this.seExtraPartLength;
            this.lciExtraPartLength.CustomizationFormText = "Период проверки:";
            this.lciExtraPartLength.Location = new System.Drawing.Point(0, 96);
            this.lciExtraPartLength.Name = "lciExtraPartLength";
            this.lciExtraPartLength.Size = new System.Drawing.Size(526, 32);
            this.lciExtraPartLength.Text = " Кол-во символов";
            this.lciExtraPartLength.TextSize = new System.Drawing.Size(174, 21);
            // 
            // lciCheckedInterval
            // 
            this.lciCheckedInterval.Control = this.sePeriod;
            this.lciCheckedInterval.Location = new System.Drawing.Point(0, 64);
            this.lciCheckedInterval.Name = "lciCheckedInterval";
            this.lciCheckedInterval.Size = new System.Drawing.Size(526, 32);
            this.lciCheckedInterval.Text = " Период проверки";
            this.lciCheckedInterval.TextSize = new System.Drawing.Size(174, 21);
            // 
            // lciStart
            // 
            this.lciStart.Control = this.btnStart;
            this.lciStart.Location = new System.Drawing.Point(0, 224);
            this.lciStart.MaxSize = new System.Drawing.Size(0, 48);
            this.lciStart.MinSize = new System.Drawing.Size(121, 48);
            this.lciStart.Name = "lciStart";
            this.lciStart.Size = new System.Drawing.Size(260, 48);
            this.lciStart.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciStart.TextSize = new System.Drawing.Size(0, 0);
            this.lciStart.TextVisible = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnCancel;
            this.lciCancel.Location = new System.Drawing.Point(260, 224);
            this.lciCancel.MaxSize = new System.Drawing.Size(0, 48);
            this.lciCancel.MinSize = new System.Drawing.Size(121, 48);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(272, 48);
            this.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // lcgLog
            // 
            this.lcgLog.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLog});
            this.lcgLog.Location = new System.Drawing.Point(0, 272);
            this.lcgLog.Name = "lcgLog";
            this.lcgLog.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgLog.Size = new System.Drawing.Size(532, 371);
            this.lcgLog.Text = "Выходные данные";
            // 
            // lciLog
            // 
            this.lciLog.Control = this.meLog;
            this.lciLog.Location = new System.Drawing.Point(0, 0);
            this.lciLog.Name = "lciLog";
            this.lciLog.Size = new System.Drawing.Size(526, 339);
            this.lciLog.TextSize = new System.Drawing.Size(0, 0);
            this.lciLog.TextVisible = false;
            // 
            // frmFredro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 653);
            this.Controls.Add(this.lcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFredro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фрэд сегодня будет флексить...";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chcbeSelectedSymbols.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCheckedUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBaseUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOutputFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seExtraPartLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBaseUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCheckedUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSelectedSymbols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOutputFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBindFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExtraPartLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCheckedInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.TextEdit teCheckedUrl;
        private DevExpress.XtraEditors.TextEdit teBaseUrl;
        private DevExpress.XtraLayout.LayoutControlItem lciBaseUrl;
        private DevExpress.XtraLayout.LayoutControlItem lciCheckedUrl;
        private DevExpress.XtraEditors.MemoEdit meLog;
        private DevExpress.XtraLayout.LayoutControlItem lciLog;
        private DevExpress.XtraLayout.LayoutControlGroup lcgHead;
        private DevExpress.XtraLayout.LayoutControlGroup lcgLog;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraLayout.LayoutControlItem lciStart;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraEditors.SpinEdit sePeriod;
        private DevExpress.XtraLayout.LayoutControlItem lciCheckedInterval;
        private DevExpress.XtraEditors.CheckedComboBoxEdit chcbeSelectedSymbols;
        private DevExpress.XtraLayout.LayoutControlItem lciSelectedSymbols;
        private DevExpress.XtraEditors.SimpleButton btnBindFile;
        private DevExpress.XtraLayout.LayoutControlItem lciBindFile;
        private DevExpress.XtraEditors.TextEdit teOutputFile;
        private DevExpress.XtraLayout.LayoutControlItem lciOutputFile;
        private DevExpress.XtraEditors.SpinEdit seExtraPartLength;
        private DevExpress.XtraLayout.LayoutControlItem lciExtraPartLength;
    }
}

