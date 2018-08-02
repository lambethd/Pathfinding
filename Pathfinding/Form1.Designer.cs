namespace Pathfinding
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pctMaze = new System.Windows.Forms.PictureBox();
            this.BtnSingleStep = new System.Windows.Forms.Button();
            this.BtnStepByStep = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.cmbPathFindingType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaze)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pctMaze);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnSingleStep);
            this.splitContainer1.Panel2.Controls.Add(this.BtnStepByStep);
            this.splitContainer1.Panel2.Controls.Add(this.btnBegin);
            this.splitContainer1.Panel2.Controls.Add(this.cmbPathFindingType);
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 0;
            // 
            // pctMaze
            // 
            this.pctMaze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctMaze.Location = new System.Drawing.Point(0, 0);
            this.pctMaze.Name = "pctMaze";
            this.pctMaze.Size = new System.Drawing.Size(800, 393);
            this.pctMaze.TabIndex = 0;
            this.pctMaze.TabStop = false;
            // 
            // BtnSingleStep
            // 
            this.BtnSingleStep.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSingleStep.Location = new System.Drawing.Point(517, 0);
            this.BtnSingleStep.Name = "BtnSingleStep";
            this.BtnSingleStep.Size = new System.Drawing.Size(96, 25);
            this.BtnSingleStep.TabIndex = 3;
            this.BtnSingleStep.Text = "Single Step";
            this.BtnSingleStep.UseVisualStyleBackColor = true;
            this.BtnSingleStep.Click += new System.EventHandler(this.BtnSingleStep_Click);
            // 
            // BtnStepByStep
            // 
            this.BtnStepByStep.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnStepByStep.Location = new System.Drawing.Point(613, 0);
            this.BtnStepByStep.Name = "BtnStepByStep";
            this.BtnStepByStep.Size = new System.Drawing.Size(102, 25);
            this.BtnStepByStep.TabIndex = 2;
            this.BtnStepByStep.Text = "Step-by-Step";
            this.BtnStepByStep.UseVisualStyleBackColor = true;
            this.BtnStepByStep.Click += new System.EventHandler(this.BtnStepByStep_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBegin.Location = new System.Drawing.Point(715, 0);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(85, 25);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Complete";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // cmbPathFindingType
            // 
            this.cmbPathFindingType.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbPathFindingType.FormattingEnabled = true;
            this.cmbPathFindingType.Location = new System.Drawing.Point(0, 0);
            this.cmbPathFindingType.Name = "cmbPathFindingType";
            this.cmbPathFindingType.Size = new System.Drawing.Size(238, 24);
            this.cmbPathFindingType.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // stepTimer
            // 
            this.stepTimer.Interval = 250;
            this.stepTimer.Tick += new System.EventHandler(this.stepTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pathfinding";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMaze)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pctMaze;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.ComboBox cmbPathFindingType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button BtnSingleStep;
        private System.Windows.Forms.Button BtnStepByStep;
        private System.Windows.Forms.Timer stepTimer;
    }
}

