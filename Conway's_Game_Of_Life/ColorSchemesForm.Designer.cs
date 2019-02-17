﻿namespace Conway_s_Game_Of_Life
{
    partial class ColorSchemesForm
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
            if (disposing && (components != null)) {
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
            this.picbPreview = new System.Windows.Forms.PictureBox();
            this.gbGrid = new System.Windows.Forms.GroupBox();
            this.rbGridOn = new System.Windows.Forms.RadioButton();
            this.rbGridOff = new System.Windows.Forms.RadioButton();
            this.colbGridColor = new Conway_s_Game_Of_Life.ColorBox();
            this.pbOk = new System.Windows.Forms.Button();
            this.pbCancel = new System.Windows.Forms.Button();
            this.pbGetDefoult = new System.Windows.Forms.Button();
            this.cbUseStyleAsDefault = new System.Windows.Forms.CheckBox();
            this.colbDeadCellsColor = new Conway_s_Game_Of_Life.ColorBox();
            this.colbAliveCellsColor = new Conway_s_Game_Of_Life.ColorBox();
            this.lbGrid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).BeginInit();
            this.gbGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbPreview
            // 
            this.picbPreview.Location = new System.Drawing.Point(12, 12);
            this.picbPreview.Name = "picbPreview";
            this.picbPreview.Size = new System.Drawing.Size(195, 195);
            this.picbPreview.TabIndex = 0;
            this.picbPreview.TabStop = false;
            this.picbPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.picbPreview_Paint);
            // 
            // gbGrid
            // 
            this.gbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGrid.Controls.Add(this.lbGrid);
            this.gbGrid.Controls.Add(this.rbGridOn);
            this.gbGrid.Controls.Add(this.rbGridOff);
            this.gbGrid.Controls.Add(this.colbGridColor);
            this.gbGrid.Location = new System.Drawing.Point(213, 114);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(255, 93);
            this.gbGrid.TabIndex = 3;
            this.gbGrid.TabStop = false;
            this.gbGrid.Text = "Настройки сетки и рамки";
            // 
            // rbGridOn
            // 
            this.rbGridOn.AutoSize = true;
            this.rbGridOn.Location = new System.Drawing.Point(90, 26);
            this.rbGridOn.Name = "rbGridOn";
            this.rbGridOn.Size = new System.Drawing.Size(44, 17);
            this.rbGridOn.TabIndex = 2;
            this.rbGridOn.Text = "Вкл";
            this.rbGridOn.UseVisualStyleBackColor = true;
            this.rbGridOn.CheckedChanged += new System.EventHandler(this.rbGridOn_CheckedChanged);
            // 
            // rbGridOff
            // 
            this.rbGridOff.AutoSize = true;
            this.rbGridOff.Checked = true;
            this.rbGridOff.Location = new System.Drawing.Point(176, 26);
            this.rbGridOff.Name = "rbGridOff";
            this.rbGridOff.Size = new System.Drawing.Size(55, 17);
            this.rbGridOff.TabIndex = 1;
            this.rbGridOff.TabStop = true;
            this.rbGridOff.Text = "Выкл.";
            this.rbGridOff.UseVisualStyleBackColor = true;
            this.rbGridOff.CheckedChanged += new System.EventHandler(this.rbGridOn_CheckedChanged);
            // 
            // colbGridColor
            // 
            this.colbGridColor.Color = System.Drawing.Color.Empty;
            this.colbGridColor.Labeled = false;
            this.colbGridColor.LabelText = "";
            this.colbGridColor.Location = new System.Drawing.Point(6, 49);
            this.colbGridColor.MaximumSize = new System.Drawing.Size(300, 27);
            this.colbGridColor.MinimumSize = new System.Drawing.Size(210, 27);
            this.colbGridColor.Name = "colbGridColor";
            this.colbGridColor.Size = new System.Drawing.Size(235, 27);
            this.colbGridColor.TabIndex = 0;
            this.colbGridColor.ColorChenged += new System.EventHandler<Conway_s_Game_Of_Life.ColorBox.ColorChengedEventArgs>(this.colbGridColor_ColorChenged);
            // 
            // pbOk
            // 
            this.pbOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOk.Location = new System.Drawing.Point(305, 238);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(78, 23);
            this.pbOk.TabIndex = 4;
            this.pbOk.Text = "OK";
            this.pbOk.UseVisualStyleBackColor = true;
            this.pbOk.Click += new System.EventHandler(this.pbOk_Click);
            // 
            // pbCancel
            // 
            this.pbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCancel.Location = new System.Drawing.Point(389, 238);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(79, 23);
            this.pbCancel.TabIndex = 4;
            this.pbCancel.Text = "Отмена";
            this.pbCancel.UseVisualStyleBackColor = true;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // pbGetDefoult
            // 
            this.pbGetDefoult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbGetDefoult.Enabled = false;
            this.pbGetDefoult.Location = new System.Drawing.Point(146, 238);
            this.pbGetDefoult.Name = "pbGetDefoult";
            this.pbGetDefoult.Size = new System.Drawing.Size(110, 23);
            this.pbGetDefoult.TabIndex = 5;
            this.pbGetDefoult.Text = "По умолчанию...";
            this.pbGetDefoult.UseVisualStyleBackColor = true;
            this.pbGetDefoult.Click += new System.EventHandler(this.pbGetDefoult_Click);
            // 
            // cbUseStyleAsDefault
            // 
            this.cbUseStyleAsDefault.AutoSize = true;
            this.cbUseStyleAsDefault.Location = new System.Drawing.Point(213, 213);
            this.cbUseStyleAsDefault.Name = "cbUseStyleAsDefault";
            this.cbUseStyleAsDefault.Size = new System.Drawing.Size(246, 17);
            this.cbUseStyleAsDefault.TabIndex = 6;
            this.cbUseStyleAsDefault.Text = "Использовать данный стиль по умолчанию";
            this.cbUseStyleAsDefault.UseVisualStyleBackColor = true;
            // 
            // colbDeadCellsColor
            // 
            this.colbDeadCellsColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colbDeadCellsColor.Color = System.Drawing.Color.Empty;
            this.colbDeadCellsColor.Labeled = true;
            this.colbDeadCellsColor.LabelText = "Цвет мертвых клеток:";
            this.colbDeadCellsColor.Location = new System.Drawing.Point(213, 63);
            this.colbDeadCellsColor.MaximumSize = new System.Drawing.Size(300, 45);
            this.colbDeadCellsColor.MinimumSize = new System.Drawing.Size(210, 45);
            this.colbDeadCellsColor.Name = "colbDeadCellsColor";
            this.colbDeadCellsColor.Size = new System.Drawing.Size(255, 45);
            this.colbDeadCellsColor.TabIndex = 2;
            this.colbDeadCellsColor.ColorChenged += new System.EventHandler<Conway_s_Game_Of_Life.ColorBox.ColorChengedEventArgs>(this.colbDeadCellsColor_ColorChenged);
            // 
            // colbAliveCellsColor
            // 
            this.colbAliveCellsColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colbAliveCellsColor.Color = System.Drawing.Color.Empty;
            this.colbAliveCellsColor.Labeled = true;
            this.colbAliveCellsColor.LabelText = "Цвет живых клеток:";
            this.colbAliveCellsColor.Location = new System.Drawing.Point(213, 12);
            this.colbAliveCellsColor.MaximumSize = new System.Drawing.Size(300, 45);
            this.colbAliveCellsColor.MinimumSize = new System.Drawing.Size(210, 45);
            this.colbAliveCellsColor.Name = "colbAliveCellsColor";
            this.colbAliveCellsColor.Size = new System.Drawing.Size(255, 45);
            this.colbAliveCellsColor.TabIndex = 1;
            this.colbAliveCellsColor.ColorChenged += new System.EventHandler<Conway_s_Game_Of_Life.ColorBox.ColorChengedEventArgs>(this.colbAliveCellsColor_ColorChenged);
            // 
            // lbGrid
            // 
            this.lbGrid.AutoSize = true;
            this.lbGrid.Location = new System.Drawing.Point(23, 28);
            this.lbGrid.Name = "lbGrid";
            this.lbGrid.Size = new System.Drawing.Size(40, 13);
            this.lbGrid.TabIndex = 3;
            this.lbGrid.Text = "Сетка:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Загрузить...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ColorSchemesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbUseStyleAsDefault);
            this.Controls.Add(this.pbGetDefoult);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbOk);
            this.Controls.Add(this.gbGrid);
            this.Controls.Add(this.colbDeadCellsColor);
            this.Controls.Add(this.colbAliveCellsColor);
            this.Controls.Add(this.picbPreview);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(494, 311);
            this.MinimumSize = new System.Drawing.Size(494, 311);
            this.Name = "ColorSchemesForm";
            this.Text = "Цветовые схемы";
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).EndInit();
            this.gbGrid.ResumeLayout(false);
            this.gbGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPreview;
        private ColorBox colbAliveCellsColor;
        private ColorBox colbDeadCellsColor;
        private System.Windows.Forms.GroupBox gbGrid;
        private System.Windows.Forms.RadioButton rbGridOn;
        private System.Windows.Forms.RadioButton rbGridOff;
        private ColorBox colbGridColor;
        private System.Windows.Forms.Button pbOk;
        private System.Windows.Forms.Button pbCancel;
        private System.Windows.Forms.Button pbGetDefoult;
        private System.Windows.Forms.CheckBox cbUseStyleAsDefault;
        private System.Windows.Forms.Label lbGrid;
        private System.Windows.Forms.Button button1;
    }
}