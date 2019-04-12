﻿namespace Binxelview
{
    partial class BinxelviewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinxelviewForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetStripMenuDash = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.groupPacking = new System.Windows.Forms.GroupBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.checkAutoNext = new System.Windows.Forms.CheckBox();
            this.checkAutoRow = new System.Windows.Forms.CheckBox();
            this.checkAutoPixel = new System.Windows.Forms.CheckBox();
            this.buttonSavePreset = new System.Windows.Forms.Button();
            this.buttonLoadPreset = new System.Windows.Forms.Button();
            this.buttonDefaultPreset = new System.Windows.Forms.Button();
            this.numericRowStrideBit = new System.Windows.Forms.NumericUpDown();
            this.numericNextStrideBit = new System.Windows.Forms.NumericUpDown();
            this.numericPixelStrideBit = new System.Windows.Forms.NumericUpDown();
            this.numericRowStrideByte = new System.Windows.Forms.NumericUpDown();
            this.numericNextStrideByte = new System.Windows.Forms.NumericUpDown();
            this.labelWStride = new System.Windows.Forms.Label();
            this.labelPStride = new System.Windows.Forms.Label();
            this.numericPixelStrideByte = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelBPP = new System.Windows.Forms.Label();
            this.numericBPP = new System.Windows.Forms.NumericUpDown();
            this.checkChunky = new System.Windows.Forms.CheckBox();
            this.checkEndian = new System.Windows.Forms.CheckBox();
            this.dataGridPixel = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPalette = new System.Windows.Forms.GroupBox();
            this.buttonGrey = new System.Windows.Forms.Button();
            this.labelInfoPal = new System.Windows.Forms.Label();
            this.buttonSavePal = new System.Windows.Forms.Button();
            this.buttonLoadPal = new System.Windows.Forms.Button();
            this.buttonRGBPal = new System.Windows.Forms.Button();
            this.buttonRandomPal = new System.Windows.Forms.Button();
            this.bgLabel = new System.Windows.Forms.Label();
            this.bgBox = new System.Windows.Forms.PictureBox();
            this.paletteBox = new System.Windows.Forms.PictureBox();
            this.tablePosPlane = new System.Windows.Forms.TableLayoutPanel();
            this.groupPosition = new System.Windows.Forms.GroupBox();
            this.buttonBytePos = new System.Windows.Forms.Button();
            this.labelZoom = new System.Windows.Forms.Label();
            this.numericZoom = new System.Windows.Forms.NumericUpDown();
            this.labelInfoPixel = new System.Windows.Forms.Label();
            this.labelPosBit = new System.Windows.Forms.Label();
            this.numericPosBit = new System.Windows.Forms.NumericUpDown();
            this.numericPosByte = new System.Windows.Forms.NumericUpDown();
            this.groupPlane = new System.Windows.Forms.GroupBox();
            this.labelPlaneStride = new System.Windows.Forms.Label();
            this.labelPlaneGroup = new System.Windows.Forms.Label();
            this.labelPlaneY = new System.Windows.Forms.Label();
            this.numericPlaneGroupY = new System.Windows.Forms.NumericUpDown();
            this.numericPlaneShiftBitY = new System.Windows.Forms.NumericUpDown();
            this.numericPlaneShiftByteY = new System.Windows.Forms.NumericUpDown();
            this.labelPlaneX = new System.Windows.Forms.Label();
            this.numericPlaneGroupX = new System.Windows.Forms.NumericUpDown();
            this.numericPlaneShiftBitX = new System.Windows.Forms.NumericUpDown();
            this.numericPlaneShiftByteX = new System.Windows.Forms.NumericUpDown();
            this.tableBase = new System.Windows.Forms.TableLayoutPanel();
            this.tableBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pixelBox = new System.Windows.Forms.PictureBox();
            this.contextMenuPixel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelScroll = new System.Windows.Forms.VScrollBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripMain.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.groupPacking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRowStrideBit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNextStrideBit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPixelStrideBit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRowStrideByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNextStrideByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPixelStrideByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPixel)).BeginInit();
            this.groupPalette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletteBox)).BeginInit();
            this.tablePosPlane.SuspendLayout();
            this.groupPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPosBit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPosByte)).BeginInit();
            this.groupPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneGroupY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftBitY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftByteY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneGroupX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftBitX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftByteX)).BeginInit();
            this.tableBase.SuspendLayout();
            this.tableBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixelBox)).BeginInit();
            this.contextMenuPixel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.presetToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(808, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAllVisibleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAllVisibleToolStripMenuItem
            // 
            this.saveAllVisibleToolStripMenuItem.Name = "saveAllVisibleToolStripMenuItem";
            this.saveAllVisibleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAllVisibleToolStripMenuItem.Text = "&Save &All Visible";
            this.saveAllVisibleToolStripMenuItem.Click += new System.EventHandler(this.saveAllVisibleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // presetToolStripMenuItem
            // 
            this.presetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.presetStripMenuDash});
            this.presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            this.presetToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.presetToolStripMenuItem.Text = "&Preset";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // presetStripMenuDash
            // 
            this.presetStripMenuDash.Name = "presetStripMenuDash";
            this.presetStripMenuDash.Size = new System.Drawing.Size(177, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decimalPositionToolStripMenuItem,
            this.hexadecimalPositionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // decimalPositionToolStripMenuItem
            // 
            this.decimalPositionToolStripMenuItem.Name = "decimalPositionToolStripMenuItem";
            this.decimalPositionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.decimalPositionToolStripMenuItem.Text = "&Decimal Position";
            this.decimalPositionToolStripMenuItem.Click += new System.EventHandler(this.decimalPositionToolStripMenuItem_Click);
            // 
            // hexadecimalPositionToolStripMenuItem
            // 
            this.hexadecimalPositionToolStripMenuItem.Checked = true;
            this.hexadecimalPositionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexadecimalPositionToolStripMenuItem.Name = "hexadecimalPositionToolStripMenuItem";
            this.hexadecimalPositionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.hexadecimalPositionToolStripMenuItem.Text = "&Hexadecimal Position";
            this.hexadecimalPositionToolStripMenuItem.Click += new System.EventHandler(this.hexadecimalPositionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableTop
            // 
            this.tableTop.AutoSize = true;
            this.tableTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableTop.ColumnCount = 3;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableTop.Controls.Add(this.groupPacking, 1, 0);
            this.tableTop.Controls.Add(this.groupPalette, 2, 0);
            this.tableTop.Controls.Add(this.tablePosPlane, 0, 0);
            this.tableTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTop.Location = new System.Drawing.Point(0, 0);
            this.tableTop.Margin = new System.Windows.Forms.Padding(0);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 1;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(808, 233);
            this.tableTop.TabIndex = 0;
            // 
            // groupPacking
            // 
            this.groupPacking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPacking.Controls.Add(this.buttonNext);
            this.groupPacking.Controls.Add(this.checkAutoNext);
            this.groupPacking.Controls.Add(this.checkAutoRow);
            this.groupPacking.Controls.Add(this.checkAutoPixel);
            this.groupPacking.Controls.Add(this.buttonSavePreset);
            this.groupPacking.Controls.Add(this.buttonLoadPreset);
            this.groupPacking.Controls.Add(this.buttonDefaultPreset);
            this.groupPacking.Controls.Add(this.numericRowStrideBit);
            this.groupPacking.Controls.Add(this.numericNextStrideBit);
            this.groupPacking.Controls.Add(this.numericPixelStrideBit);
            this.groupPacking.Controls.Add(this.numericRowStrideByte);
            this.groupPacking.Controls.Add(this.numericNextStrideByte);
            this.groupPacking.Controls.Add(this.labelWStride);
            this.groupPacking.Controls.Add(this.labelPStride);
            this.groupPacking.Controls.Add(this.numericPixelStrideByte);
            this.groupPacking.Controls.Add(this.numericWidth);
            this.groupPacking.Controls.Add(this.numericHeight);
            this.groupPacking.Controls.Add(this.labelHeight);
            this.groupPacking.Controls.Add(this.labelWidth);
            this.groupPacking.Controls.Add(this.labelBPP);
            this.groupPacking.Controls.Add(this.numericBPP);
            this.groupPacking.Controls.Add(this.checkChunky);
            this.groupPacking.Controls.Add(this.checkEndian);
            this.groupPacking.Controls.Add(this.dataGridPixel);
            this.groupPacking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPacking.Location = new System.Drawing.Point(172, 3);
            this.groupPacking.Name = "groupPacking";
            this.groupPacking.Size = new System.Drawing.Size(332, 227);
            this.groupPacking.TabIndex = 0;
            this.groupPacking.TabStop = false;
            this.groupPacking.Text = "Packing";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(122, 89);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(51, 24);
            this.buttonNext.TabIndex = 22;
            this.buttonNext.Text = "&Next";
            this.toolTip.SetToolTip(this.buttonNext, "Left click to advance\r\nRight/shift click to retreat");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNext_MouseDown);
            // 
            // checkAutoNext
            // 
            this.checkAutoNext.AutoSize = true;
            this.checkAutoNext.Checked = true;
            this.checkAutoNext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoNext.Location = new System.Drawing.Point(122, 168);
            this.checkAutoNext.Name = "checkAutoNext";
            this.checkAutoNext.Size = new System.Drawing.Size(48, 17);
            this.checkAutoNext.TabIndex = 21;
            this.checkAutoNext.Text = "Auto";
            this.checkAutoNext.UseVisualStyleBackColor = true;
            this.checkAutoNext.CheckedChanged += new System.EventHandler(this.checkAutoNext_CheckedChanged);
            // 
            // checkAutoRow
            // 
            this.checkAutoRow.AutoSize = true;
            this.checkAutoRow.Checked = true;
            this.checkAutoRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoRow.Location = new System.Drawing.Point(65, 168);
            this.checkAutoRow.Name = "checkAutoRow";
            this.checkAutoRow.Size = new System.Drawing.Size(48, 17);
            this.checkAutoRow.TabIndex = 20;
            this.checkAutoRow.Text = "Auto";
            this.checkAutoRow.UseVisualStyleBackColor = true;
            this.checkAutoRow.CheckedChanged += new System.EventHandler(this.checkAutoRow_CheckedChanged);
            // 
            // checkAutoPixel
            // 
            this.checkAutoPixel.AutoSize = true;
            this.checkAutoPixel.Checked = true;
            this.checkAutoPixel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoPixel.Location = new System.Drawing.Point(9, 168);
            this.checkAutoPixel.Name = "checkAutoPixel";
            this.checkAutoPixel.Size = new System.Drawing.Size(48, 17);
            this.checkAutoPixel.TabIndex = 19;
            this.checkAutoPixel.Text = "Auto";
            this.checkAutoPixel.UseVisualStyleBackColor = true;
            this.checkAutoPixel.CheckedChanged += new System.EventHandler(this.checkAutoPixel_CheckedChanged);
            // 
            // buttonSavePreset
            // 
            this.buttonSavePreset.Location = new System.Drawing.Point(122, 191);
            this.buttonSavePreset.Name = "buttonSavePreset";
            this.buttonSavePreset.Size = new System.Drawing.Size(51, 24);
            this.buttonSavePreset.TabIndex = 18;
            this.buttonSavePreset.Text = "Save...";
            this.buttonSavePreset.UseVisualStyleBackColor = true;
            this.buttonSavePreset.Click += new System.EventHandler(this.buttonSavePreset_Click);
            // 
            // buttonLoadPreset
            // 
            this.buttonLoadPreset.Location = new System.Drawing.Point(65, 191);
            this.buttonLoadPreset.Name = "buttonLoadPreset";
            this.buttonLoadPreset.Size = new System.Drawing.Size(51, 24);
            this.buttonLoadPreset.TabIndex = 9;
            this.buttonLoadPreset.Text = "Load...";
            this.buttonLoadPreset.UseVisualStyleBackColor = true;
            this.buttonLoadPreset.Click += new System.EventHandler(this.buttonLoadPreset_Click);
            // 
            // buttonDefaultPreset
            // 
            this.buttonDefaultPreset.Location = new System.Drawing.Point(7, 191);
            this.buttonDefaultPreset.Name = "buttonDefaultPreset";
            this.buttonDefaultPreset.Size = new System.Drawing.Size(51, 24);
            this.buttonDefaultPreset.TabIndex = 9;
            this.buttonDefaultPreset.Text = "Default";
            this.buttonDefaultPreset.UseVisualStyleBackColor = true;
            this.buttonDefaultPreset.Click += new System.EventHandler(this.buttonDefaultPreset_Click);
            // 
            // numericRowStrideBit
            // 
            this.numericRowStrideBit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericRowStrideBit.Location = new System.Drawing.Point(65, 142);
            this.numericRowStrideBit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericRowStrideBit.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericRowStrideBit.Name = "numericRowStrideBit";
            this.numericRowStrideBit.Size = new System.Drawing.Size(51, 20);
            this.numericRowStrideBit.TabIndex = 17;
            this.numericRowStrideBit.ValueChanged += new System.EventHandler(this.numericRowStrideBit_ValueChanged);
            // 
            // numericNextStrideBit
            // 
            this.numericNextStrideBit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericNextStrideBit.Location = new System.Drawing.Point(122, 142);
            this.numericNextStrideBit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericNextStrideBit.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericNextStrideBit.Name = "numericNextStrideBit";
            this.numericNextStrideBit.Size = new System.Drawing.Size(51, 20);
            this.numericNextStrideBit.TabIndex = 16;
            this.numericNextStrideBit.ValueChanged += new System.EventHandler(this.numericNextStrideBit_ValueChanged);
            // 
            // numericPixelStrideBit
            // 
            this.numericPixelStrideBit.BackColor = System.Drawing.SystemColors.Window;
            this.numericPixelStrideBit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericPixelStrideBit.Location = new System.Drawing.Point(7, 142);
            this.numericPixelStrideBit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPixelStrideBit.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericPixelStrideBit.Name = "numericPixelStrideBit";
            this.numericPixelStrideBit.Size = new System.Drawing.Size(51, 20);
            this.numericPixelStrideBit.TabIndex = 15;
            this.numericPixelStrideBit.ValueChanged += new System.EventHandler(this.numericPixelStrideBit_ValueChanged);
            // 
            // numericRowStrideByte
            // 
            this.numericRowStrideByte.Location = new System.Drawing.Point(65, 116);
            this.numericRowStrideByte.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericRowStrideByte.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericRowStrideByte.Name = "numericRowStrideByte";
            this.numericRowStrideByte.Size = new System.Drawing.Size(51, 20);
            this.numericRowStrideByte.TabIndex = 14;
            this.numericRowStrideByte.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericRowStrideByte.ValueChanged += new System.EventHandler(this.numericRowStrideByte_ValueChanged);
            // 
            // numericNextStrideByte
            // 
            this.numericNextStrideByte.Location = new System.Drawing.Point(122, 116);
            this.numericNextStrideByte.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericNextStrideByte.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericNextStrideByte.Name = "numericNextStrideByte";
            this.numericNextStrideByte.Size = new System.Drawing.Size(51, 20);
            this.numericNextStrideByte.TabIndex = 13;
            this.numericNextStrideByte.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericNextStrideByte.ValueChanged += new System.EventHandler(this.numericNextStrideByte_ValueChanged);
            // 
            // labelWStride
            // 
            this.labelWStride.Location = new System.Drawing.Point(65, 89);
            this.labelWStride.Name = "labelWStride";
            this.labelWStride.Size = new System.Drawing.Size(51, 24);
            this.labelWStride.TabIndex = 11;
            this.labelWStride.Text = "Row";
            this.labelWStride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPStride
            // 
            this.labelPStride.Location = new System.Drawing.Point(6, 89);
            this.labelPStride.Name = "labelPStride";
            this.labelPStride.Size = new System.Drawing.Size(51, 24);
            this.labelPStride.TabIndex = 10;
            this.labelPStride.Text = "Stride";
            this.labelPStride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericPixelStrideByte
            // 
            this.numericPixelStrideByte.Location = new System.Drawing.Point(7, 116);
            this.numericPixelStrideByte.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPixelStrideByte.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericPixelStrideByte.Name = "numericPixelStrideByte";
            this.numericPixelStrideByte.Size = new System.Drawing.Size(51, 20);
            this.numericPixelStrideByte.TabIndex = 9;
            this.numericPixelStrideByte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPixelStrideByte.ValueChanged += new System.EventHandler(this.numericPixelStrideByte_ValueChanged);
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(65, 66);
            this.numericWidth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(51, 20);
            this.numericWidth.TabIndex = 8;
            this.numericWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(122, 66);
            this.numericHeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(51, 20);
            this.numericHeight.TabIndex = 7;
            this.numericHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.ValueChanged += new System.EventHandler(this.numericHeight_ValueChanged);
            // 
            // labelHeight
            // 
            this.labelHeight.Location = new System.Drawing.Point(122, 39);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(51, 24);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWidth
            // 
            this.labelWidth.Location = new System.Drawing.Point(65, 39);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(51, 24);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "Width";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBPP
            // 
            this.labelBPP.Location = new System.Drawing.Point(6, 39);
            this.labelBPP.Name = "labelBPP";
            this.labelBPP.Size = new System.Drawing.Size(51, 24);
            this.labelBPP.TabIndex = 4;
            this.labelBPP.Text = "BPP";
            this.labelBPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericBPP
            // 
            this.numericBPP.Location = new System.Drawing.Point(7, 66);
            this.numericBPP.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericBPP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBPP.Name = "numericBPP";
            this.numericBPP.Size = new System.Drawing.Size(51, 20);
            this.numericBPP.TabIndex = 3;
            this.numericBPP.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericBPP.ValueChanged += new System.EventHandler(this.numericBPP_ValueChanged);
            // 
            // checkChunky
            // 
            this.checkChunky.AutoSize = true;
            this.checkChunky.Checked = true;
            this.checkChunky.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkChunky.Location = new System.Drawing.Point(98, 19);
            this.checkChunky.Name = "checkChunky";
            this.checkChunky.Size = new System.Drawing.Size(62, 17);
            this.checkChunky.TabIndex = 2;
            this.checkChunky.Text = "Chunky";
            this.checkChunky.UseVisualStyleBackColor = true;
            this.checkChunky.CheckedChanged += new System.EventHandler(this.checkChunky_CheckedChanged);
            // 
            // checkEndian
            // 
            this.checkEndian.AutoSize = true;
            this.checkEndian.Checked = true;
            this.checkEndian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEndian.Location = new System.Drawing.Point(7, 19);
            this.checkEndian.Name = "checkEndian";
            this.checkEndian.Size = new System.Drawing.Size(84, 17);
            this.checkEndian.TabIndex = 1;
            this.checkEndian.Text = "Little Endian";
            this.checkEndian.UseVisualStyleBackColor = true;
            this.checkEndian.CheckedChanged += new System.EventHandler(this.checkEndian_CheckedChanged);
            // 
            // dataGridPixel
            // 
            this.dataGridPixel.AllowUserToAddRows = false;
            this.dataGridPixel.AllowUserToDeleteRows = false;
            this.dataGridPixel.AllowUserToResizeColumns = false;
            this.dataGridPixel.AllowUserToResizeRows = false;
            this.dataGridPixel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPixel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.offByte,
            this.offBit});
            this.dataGridPixel.Enabled = false;
            this.dataGridPixel.Location = new System.Drawing.Point(179, 19);
            this.dataGridPixel.MultiSelect = false;
            this.dataGridPixel.Name = "dataGridPixel";
            this.dataGridPixel.RowHeadersVisible = false;
            this.dataGridPixel.Size = new System.Drawing.Size(147, 196);
            this.dataGridPixel.TabIndex = 0;
            this.dataGridPixel.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridPixel_CellValidating);
            this.dataGridPixel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPixel_CellValueChanged);
            // 
            // order
            // 
            this.order.HeaderText = "Order";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order.Width = 42;
            // 
            // offByte
            // 
            this.offByte.HeaderText = "Byte";
            this.offByte.Name = "offByte";
            this.offByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.offByte.Width = 42;
            // 
            // offBit
            // 
            this.offBit.HeaderText = "Bit";
            this.offBit.Name = "offBit";
            this.offBit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.offBit.Width = 42;
            // 
            // groupPalette
            // 
            this.groupPalette.AutoSize = true;
            this.groupPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPalette.Controls.Add(this.buttonGrey);
            this.groupPalette.Controls.Add(this.labelInfoPal);
            this.groupPalette.Controls.Add(this.buttonSavePal);
            this.groupPalette.Controls.Add(this.buttonLoadPal);
            this.groupPalette.Controls.Add(this.buttonRGBPal);
            this.groupPalette.Controls.Add(this.buttonRandomPal);
            this.groupPalette.Controls.Add(this.bgLabel);
            this.groupPalette.Controls.Add(this.bgBox);
            this.groupPalette.Controls.Add(this.paletteBox);
            this.groupPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPalette.Location = new System.Drawing.Point(510, 3);
            this.groupPalette.Name = "groupPalette";
            this.groupPalette.Size = new System.Drawing.Size(295, 227);
            this.groupPalette.TabIndex = 1;
            this.groupPalette.TabStop = false;
            this.groupPalette.Text = "Palette";
            // 
            // buttonGrey
            // 
            this.buttonGrey.Location = new System.Drawing.Point(238, 57);
            this.buttonGrey.Name = "buttonGrey";
            this.buttonGrey.Size = new System.Drawing.Size(39, 24);
            this.buttonGrey.TabIndex = 8;
            this.buttonGrey.Text = "Grey";
            this.buttonGrey.UseVisualStyleBackColor = true;
            this.buttonGrey.Click += new System.EventHandler(this.buttonGrey_Click);
            // 
            // labelInfoPal
            // 
            this.labelInfoPal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelInfoPal.Location = new System.Drawing.Point(6, 152);
            this.labelInfoPal.Name = "labelInfoPal";
            this.labelInfoPal.Size = new System.Drawing.Size(271, 43);
            this.labelInfoPal.TabIndex = 7;
            this.labelInfoPal.Text = "(Palette Info)";
            this.labelInfoPal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSavePal
            // 
            this.buttonSavePal.Location = new System.Drawing.Point(213, 87);
            this.buttonSavePal.Name = "buttonSavePal";
            this.buttonSavePal.Size = new System.Drawing.Size(64, 24);
            this.buttonSavePal.TabIndex = 6;
            this.buttonSavePal.Text = "Save...";
            this.buttonSavePal.UseVisualStyleBackColor = true;
            this.buttonSavePal.Click += new System.EventHandler(this.buttonSavePal_Click);
            // 
            // buttonLoadPal
            // 
            this.buttonLoadPal.Location = new System.Drawing.Point(143, 87);
            this.buttonLoadPal.Name = "buttonLoadPal";
            this.buttonLoadPal.Size = new System.Drawing.Size(64, 24);
            this.buttonLoadPal.TabIndex = 5;
            this.buttonLoadPal.Text = "Load...";
            this.buttonLoadPal.UseVisualStyleBackColor = true;
            this.buttonLoadPal.Click += new System.EventHandler(this.buttonLoadPal_Click);
            // 
            // buttonRGBPal
            // 
            this.buttonRGBPal.Location = new System.Drawing.Point(192, 57);
            this.buttonRGBPal.Name = "buttonRGBPal";
            this.buttonRGBPal.Size = new System.Drawing.Size(40, 24);
            this.buttonRGBPal.TabIndex = 4;
            this.buttonRGBPal.Text = "RGB";
            this.buttonRGBPal.UseVisualStyleBackColor = true;
            this.buttonRGBPal.Click += new System.EventHandler(this.buttonRGBPal_Click);
            // 
            // buttonRandomPal
            // 
            this.buttonRandomPal.Location = new System.Drawing.Point(143, 57);
            this.buttonRandomPal.Name = "buttonRandomPal";
            this.buttonRandomPal.Size = new System.Drawing.Size(43, 24);
            this.buttonRandomPal.TabIndex = 3;
            this.buttonRandomPal.Text = "Rand";
            this.buttonRandomPal.UseVisualStyleBackColor = true;
            this.buttonRandomPal.Click += new System.EventHandler(this.buttonRandomPal_Click);
            // 
            // bgLabel
            // 
            this.bgLabel.Location = new System.Drawing.Point(181, 19);
            this.bgLabel.Name = "bgLabel";
            this.bgLabel.Size = new System.Drawing.Size(96, 32);
            this.bgLabel.TabIndex = 2;
            this.bgLabel.Text = "Background";
            this.bgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bgBox
            // 
            this.bgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bgBox.Location = new System.Drawing.Point(143, 19);
            this.bgBox.Name = "bgBox";
            this.bgBox.Size = new System.Drawing.Size(32, 32);
            this.bgBox.TabIndex = 1;
            this.bgBox.TabStop = false;
            this.bgBox.Click += new System.EventHandler(this.bgBox_Click);
            // 
            // paletteBox
            // 
            this.paletteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paletteBox.Location = new System.Drawing.Point(6, 19);
            this.paletteBox.Name = "paletteBox";
            this.paletteBox.Size = new System.Drawing.Size(130, 130);
            this.paletteBox.TabIndex = 0;
            this.paletteBox.TabStop = false;
            this.paletteBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteBox_MouseClick);
            this.paletteBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paletteBox_MouseMove);
            // 
            // tablePosPlane
            // 
            this.tablePosPlane.AutoSize = true;
            this.tablePosPlane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePosPlane.ColumnCount = 1;
            this.tablePosPlane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePosPlane.Controls.Add(this.groupPosition, 0, 0);
            this.tablePosPlane.Controls.Add(this.groupPlane, 0, 1);
            this.tablePosPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePosPlane.Location = new System.Drawing.Point(0, 0);
            this.tablePosPlane.Margin = new System.Windows.Forms.Padding(0);
            this.tablePosPlane.Name = "tablePosPlane";
            this.tablePosPlane.RowCount = 2;
            this.tablePosPlane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePosPlane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePosPlane.Size = new System.Drawing.Size(169, 233);
            this.tablePosPlane.TabIndex = 3;
            // 
            // groupPosition
            // 
            this.groupPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPosition.Controls.Add(this.buttonBytePos);
            this.groupPosition.Controls.Add(this.labelZoom);
            this.groupPosition.Controls.Add(this.numericZoom);
            this.groupPosition.Controls.Add(this.labelInfoPixel);
            this.groupPosition.Controls.Add(this.labelPosBit);
            this.groupPosition.Controls.Add(this.numericPosBit);
            this.groupPosition.Controls.Add(this.numericPosByte);
            this.groupPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosition.Location = new System.Drawing.Point(3, 3);
            this.groupPosition.Name = "groupPosition";
            this.groupPosition.Size = new System.Drawing.Size(163, 105);
            this.groupPosition.TabIndex = 2;
            this.groupPosition.TabStop = false;
            this.groupPosition.Text = "Position";
            // 
            // buttonBytePos
            // 
            this.buttonBytePos.Location = new System.Drawing.Point(6, 18);
            this.buttonBytePos.Name = "buttonBytePos";
            this.buttonBytePos.Size = new System.Drawing.Size(36, 22);
            this.buttonBytePos.TabIndex = 7;
            this.buttonBytePos.Text = "&Byte";
            this.toolTip.SetToolTip(this.buttonBytePos, "Reset position to 0");
            this.buttonBytePos.UseVisualStyleBackColor = true;
            this.buttonBytePos.Click += new System.EventHandler(this.buttonBytePos_Click);
            // 
            // labelZoom
            // 
            this.labelZoom.Location = new System.Drawing.Point(115, 20);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(42, 20);
            this.labelZoom.TabIndex = 6;
            this.labelZoom.Text = "Zoom";
            this.labelZoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numericZoom
            // 
            this.numericZoom.Location = new System.Drawing.Point(115, 43);
            this.numericZoom.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericZoom.Name = "numericZoom";
            this.numericZoom.Size = new System.Drawing.Size(42, 20);
            this.numericZoom.TabIndex = 5;
            this.numericZoom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericZoom.ValueChanged += new System.EventHandler(this.numericZoom_ValueChanged);
            // 
            // labelInfoPixel
            // 
            this.labelInfoPixel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelInfoPixel.Location = new System.Drawing.Point(6, 68);
            this.labelInfoPixel.Name = "labelInfoPixel";
            this.labelInfoPixel.Size = new System.Drawing.Size(151, 32);
            this.labelInfoPixel.TabIndex = 4;
            this.labelInfoPixel.Text = "(Pixel Info)";
            this.labelInfoPixel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPosBit
            // 
            this.labelPosBit.Location = new System.Drawing.Point(9, 43);
            this.labelPosBit.Name = "labelPosBit";
            this.labelPosBit.Size = new System.Drawing.Size(26, 20);
            this.labelPosBit.TabIndex = 3;
            this.labelPosBit.Text = "Bit";
            this.labelPosBit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericPosBit
            // 
            this.numericPosBit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericPosBit.Location = new System.Drawing.Point(42, 43);
            this.numericPosBit.Maximum = new decimal(new int[] {
            2147438647,
            0,
            0,
            0});
            this.numericPosBit.Minimum = new decimal(new int[] {
            2147438648,
            0,
            0,
            -2147483648});
            this.numericPosBit.Name = "numericPosBit";
            this.numericPosBit.Size = new System.Drawing.Size(70, 20);
            this.numericPosBit.TabIndex = 2;
            this.numericPosBit.ValueChanged += new System.EventHandler(this.numericPosBit_ValueChanged);
            // 
            // numericPosByte
            // 
            this.numericPosByte.Hexadecimal = true;
            this.numericPosByte.Location = new System.Drawing.Point(42, 19);
            this.numericPosByte.Maximum = new decimal(new int[] {
            2147438647,
            0,
            0,
            0});
            this.numericPosByte.Minimum = new decimal(new int[] {
            2147438648,
            0,
            0,
            -2147483648});
            this.numericPosByte.Name = "numericPosByte";
            this.numericPosByte.Size = new System.Drawing.Size(70, 20);
            this.numericPosByte.TabIndex = 0;
            this.numericPosByte.ValueChanged += new System.EventHandler(this.numericPosByte_ValueChanged);
            // 
            // groupPlane
            // 
            this.groupPlane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPlane.Controls.Add(this.labelPlaneStride);
            this.groupPlane.Controls.Add(this.labelPlaneGroup);
            this.groupPlane.Controls.Add(this.labelPlaneY);
            this.groupPlane.Controls.Add(this.numericPlaneGroupY);
            this.groupPlane.Controls.Add(this.numericPlaneShiftBitY);
            this.groupPlane.Controls.Add(this.numericPlaneShiftByteY);
            this.groupPlane.Controls.Add(this.labelPlaneX);
            this.groupPlane.Controls.Add(this.numericPlaneGroupX);
            this.groupPlane.Controls.Add(this.numericPlaneShiftBitX);
            this.groupPlane.Controls.Add(this.numericPlaneShiftByteX);
            this.groupPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPlane.Location = new System.Drawing.Point(3, 114);
            this.groupPlane.Name = "groupPlane";
            this.groupPlane.Size = new System.Drawing.Size(163, 116);
            this.groupPlane.TabIndex = 3;
            this.groupPlane.TabStop = false;
            this.groupPlane.Text = "Plane Tiling";
            // 
            // labelPlaneStride
            // 
            this.labelPlaneStride.Location = new System.Drawing.Point(3, 57);
            this.labelPlaneStride.Name = "labelPlaneStride";
            this.labelPlaneStride.Size = new System.Drawing.Size(45, 43);
            this.labelPlaneStride.TabIndex = 27;
            this.labelPlaneStride.Text = "Shift";
            this.labelPlaneStride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlaneGroup
            // 
            this.labelPlaneGroup.Location = new System.Drawing.Point(3, 34);
            this.labelPlaneGroup.Name = "labelPlaneGroup";
            this.labelPlaneGroup.Size = new System.Drawing.Size(45, 20);
            this.labelPlaneGroup.TabIndex = 26;
            this.labelPlaneGroup.Text = "Group";
            this.labelPlaneGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlaneY
            // 
            this.labelPlaneY.Location = new System.Drawing.Point(106, 16);
            this.labelPlaneY.Name = "labelPlaneY";
            this.labelPlaneY.Size = new System.Drawing.Size(51, 15);
            this.labelPlaneY.TabIndex = 25;
            this.labelPlaneY.Text = "Y";
            this.labelPlaneY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericPlaneGroupY
            // 
            this.numericPlaneGroupY.Location = new System.Drawing.Point(106, 34);
            this.numericPlaneGroupY.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPlaneGroupY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPlaneGroupY.Name = "numericPlaneGroupY";
            this.numericPlaneGroupY.Size = new System.Drawing.Size(51, 20);
            this.numericPlaneGroupY.TabIndex = 24;
            this.numericPlaneGroupY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPlaneGroupY.ValueChanged += new System.EventHandler(this.numericPlaneGroupY_ValueChanged);
            // 
            // numericPlaneShiftBitY
            // 
            this.numericPlaneShiftBitY.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericPlaneShiftBitY.Location = new System.Drawing.Point(106, 80);
            this.numericPlaneShiftBitY.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPlaneShiftBitY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericPlaneShiftBitY.Name = "numericPlaneShiftBitY";
            this.numericPlaneShiftBitY.Size = new System.Drawing.Size(51, 20);
            this.numericPlaneShiftBitY.TabIndex = 23;
            this.numericPlaneShiftBitY.ValueChanged += new System.EventHandler(this.numericPlaneStrideBitY_ValueChanged);
            // 
            // numericPlaneShiftByteY
            // 
            this.numericPlaneShiftByteY.Location = new System.Drawing.Point(106, 57);
            this.numericPlaneShiftByteY.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPlaneShiftByteY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericPlaneShiftByteY.Name = "numericPlaneShiftByteY";
            this.numericPlaneShiftByteY.Size = new System.Drawing.Size(51, 20);
            this.numericPlaneShiftByteY.TabIndex = 22;
            this.numericPlaneShiftByteY.ValueChanged += new System.EventHandler(this.numericPlaneStrideByteY_ValueChanged);
            // 
            // labelPlaneX
            // 
            this.labelPlaneX.Location = new System.Drawing.Point(49, 16);
            this.labelPlaneX.Name = "labelPlaneX";
            this.labelPlaneX.Size = new System.Drawing.Size(51, 15);
            this.labelPlaneX.TabIndex = 21;
            this.labelPlaneX.Text = "X";
            this.labelPlaneX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericPlaneGroupX
            // 
            this.numericPlaneGroupX.Location = new System.Drawing.Point(49, 34);
            this.numericPlaneGroupX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPlaneGroupX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPlaneGroupX.Name = "numericPlaneGroupX";
            this.numericPlaneGroupX.Size = new System.Drawing.Size(51, 20);
            this.numericPlaneGroupX.TabIndex = 20;
            this.numericPlaneGroupX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPlaneGroupX.ValueChanged += new System.EventHandler(this.numericPlaneGroupX_ValueChanged);
            // 
            // numericPlaneShiftBitX
            // 
            this.numericPlaneShiftBitX.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericPlaneShiftBitX.Location = new System.Drawing.Point(49, 80);
            this.numericPlaneShiftBitX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPlaneShiftBitX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericPlaneShiftBitX.Name = "numericPlaneShiftBitX";
            this.numericPlaneShiftBitX.Size = new System.Drawing.Size(51, 20);
            this.numericPlaneShiftBitX.TabIndex = 19;
            this.numericPlaneShiftBitX.ValueChanged += new System.EventHandler(this.numericPlaneStrideBitX_ValueChanged);
            // 
            // numericPlaneShiftByteX
            // 
            this.numericPlaneShiftByteX.Location = new System.Drawing.Point(49, 57);
            this.numericPlaneShiftByteX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericPlaneShiftByteX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericPlaneShiftByteX.Name = "numericPlaneShiftByteX";
            this.numericPlaneShiftByteX.Size = new System.Drawing.Size(51, 20);
            this.numericPlaneShiftByteX.TabIndex = 18;
            this.numericPlaneShiftByteX.ValueChanged += new System.EventHandler(this.numericPlaneStrideByteX_ValueChanged);
            // 
            // tableBase
            // 
            this.tableBase.AutoSize = true;
            this.tableBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableBase.ColumnCount = 1;
            this.tableBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBase.Controls.Add(this.tableTop, 0, 0);
            this.tableBase.Controls.Add(this.tableBottom, 0, 1);
            this.tableBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBase.Location = new System.Drawing.Point(0, 24);
            this.tableBase.Margin = new System.Windows.Forms.Padding(0);
            this.tableBase.Name = "tableBase";
            this.tableBase.RowCount = 2;
            this.tableBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBase.Size = new System.Drawing.Size(808, 626);
            this.tableBase.TabIndex = 1;
            // 
            // tableBottom
            // 
            this.tableBottom.ColumnCount = 2;
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableBottom.Controls.Add(this.pixelBox, 0, 0);
            this.tableBottom.Controls.Add(this.pixelScroll, 1, 0);
            this.tableBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBottom.Location = new System.Drawing.Point(0, 233);
            this.tableBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tableBottom.Name = "tableBottom";
            this.tableBottom.RowCount = 1;
            this.tableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom.Size = new System.Drawing.Size(808, 393);
            this.tableBottom.TabIndex = 1;
            // 
            // pixelBox
            // 
            this.pixelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pixelBox.ContextMenuStrip = this.contextMenuPixel;
            this.pixelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pixelBox.Location = new System.Drawing.Point(3, 3);
            this.pixelBox.Name = "pixelBox";
            this.pixelBox.Size = new System.Drawing.Size(778, 387);
            this.pixelBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pixelBox.TabIndex = 0;
            this.pixelBox.TabStop = false;
            this.pixelBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pixelBox_MouseMove);
            this.pixelBox.Resize += new System.EventHandler(this.pixelBox_Resize);
            // 
            // contextMenuPixel
            // 
            this.contextMenuPixel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.saveAllToolStripMenuItem});
            this.contextMenuPixel.Name = "contextMenuPixel";
            this.contextMenuPixel.Size = new System.Drawing.Size(153, 48);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Enabled = false;
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveImageToolStripMenuItem.Text = "&Save &Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageContextItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAllToolStripMenuItem.Text = "Save &All Visible";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllVisibleContextItem_Click);
            // 
            // pixelScroll
            // 
            this.pixelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pixelScroll.LargeChange = 1;
            this.pixelScroll.Location = new System.Drawing.Point(784, 0);
            this.pixelScroll.Maximum = 0;
            this.pixelScroll.Name = "pixelScroll";
            this.pixelScroll.Size = new System.Drawing.Size(24, 393);
            this.pixelScroll.TabIndex = 1;
            this.pixelScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pixelScroll_Scroll);
            // 
            // BinxelviewForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 650);
            this.Controls.Add(this.tableBase);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "BinxelviewForm";
            this.Text = "Binxelview";
            this.Load += new System.EventHandler(this.BinxelviewForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.BinxelviewForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.BinxelviewForm_DragEnter);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableTop.ResumeLayout(false);
            this.tableTop.PerformLayout();
            this.groupPacking.ResumeLayout(false);
            this.groupPacking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRowStrideBit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNextStrideBit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPixelStrideBit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRowStrideByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNextStrideByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPixelStrideByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPixel)).EndInit();
            this.groupPalette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletteBox)).EndInit();
            this.tablePosPlane.ResumeLayout(false);
            this.groupPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPosBit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPosByte)).EndInit();
            this.groupPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneGroupY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftBitY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftByteY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneGroupX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftBitX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneShiftByteX)).EndInit();
            this.tableBase.ResumeLayout(false);
            this.tableBase.PerformLayout();
            this.tableBottom.ResumeLayout(false);
            this.tableBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixelBox)).EndInit();
            this.contextMenuPixel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.GroupBox groupPacking;
        private System.Windows.Forms.GroupBox groupPalette;
        private System.Windows.Forms.TableLayoutPanel tableBase;
        private System.Windows.Forms.TableLayoutPanel tableBottom;
        private System.Windows.Forms.PictureBox pixelBox;
        private System.Windows.Forms.VScrollBar pixelScroll;
        private System.Windows.Forms.PictureBox paletteBox;
        private System.Windows.Forms.Button buttonSavePal;
        private System.Windows.Forms.Button buttonLoadPal;
        private System.Windows.Forms.Button buttonRGBPal;
        private System.Windows.Forms.Button buttonRandomPal;
        private System.Windows.Forms.Label bgLabel;
        private System.Windows.Forms.PictureBox bgBox;
        private System.Windows.Forms.Label labelInfoPal;
        private System.Windows.Forms.Button buttonGrey;
        private System.Windows.Forms.GroupBox groupPosition;
        private System.Windows.Forms.DataGridView dataGridPixel;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelBPP;
        private System.Windows.Forms.NumericUpDown numericBPP;
        private System.Windows.Forms.CheckBox checkChunky;
        private System.Windows.Forms.CheckBox checkEndian;
        private System.Windows.Forms.NumericUpDown numericRowStrideBit;
        private System.Windows.Forms.NumericUpDown numericNextStrideBit;
        private System.Windows.Forms.NumericUpDown numericPixelStrideBit;
        private System.Windows.Forms.NumericUpDown numericRowStrideByte;
        private System.Windows.Forms.NumericUpDown numericNextStrideByte;
        private System.Windows.Forms.Label labelWStride;
        private System.Windows.Forms.Label labelPStride;
        private System.Windows.Forms.NumericUpDown numericPixelStrideByte;
        private System.Windows.Forms.Button buttonSavePreset;
        private System.Windows.Forms.Button buttonLoadPreset;
        private System.Windows.Forms.Button buttonDefaultPreset;
        private System.Windows.Forms.ToolStripMenuItem presetToolStripMenuItem;
        private System.Windows.Forms.Label labelInfoPixel;
        private System.Windows.Forms.Label labelPosBit;
        private System.Windows.Forms.NumericUpDown numericPosBit;
        private System.Windows.Forms.NumericUpDown numericPosByte;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.NumericUpDown numericZoom;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator presetStripMenuDash;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn offByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn offBit;
        private System.Windows.Forms.ContextMenuStrip contextMenuPixel;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllVisibleToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkAutoNext;
        private System.Windows.Forms.CheckBox checkAutoRow;
        private System.Windows.Forms.CheckBox checkAutoPixel;
        private System.Windows.Forms.TableLayoutPanel tablePosPlane;
        private System.Windows.Forms.GroupBox groupPlane;
        private System.Windows.Forms.Label labelPlaneY;
        private System.Windows.Forms.NumericUpDown numericPlaneGroupY;
        private System.Windows.Forms.NumericUpDown numericPlaneShiftBitY;
        private System.Windows.Forms.NumericUpDown numericPlaneShiftByteY;
        private System.Windows.Forms.Label labelPlaneX;
        private System.Windows.Forms.NumericUpDown numericPlaneGroupX;
        private System.Windows.Forms.NumericUpDown numericPlaneShiftBitX;
        private System.Windows.Forms.NumericUpDown numericPlaneShiftByteX;
        private System.Windows.Forms.Label labelPlaneStride;
        private System.Windows.Forms.Label labelPlaneGroup;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexadecimalPositionToolStripMenuItem;
        private System.Windows.Forms.Button buttonBytePos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonNext;
    }
}

