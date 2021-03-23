namespace Bloss_GameOfLife
{
    partial class Bloss_GOL
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
            this.createGrid = new System.Windows.Forms.Button();
            this.radInfinite = new System.Windows.Forms.RadioButton();
            this.radPulsar = new System.Windows.Forms.RadioButton();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblGenerationNum = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.btnSingleGen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.grpBoxCellInfo = new System.Windows.Forms.GroupBox();
            this.lblRedCell = new System.Windows.Forms.Label();
            this.lblMagentaCell = new System.Windows.Forms.Label();
            this.lblBlueCell = new System.Windows.Forms.Label();
            this.lblGreenCell = new System.Windows.Forms.Label();
            this.lblYellowCell = new System.Windows.Forms.Label();
            this.lblDeadCell = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblMagenta = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblWhite = new System.Windows.Forms.Label();
            this.runGenerations = new System.Windows.Forms.Button();
            this.grpGenBox = new System.Windows.Forms.GroupBox();
            this.radOF = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.radBeacon = new System.Windows.Forms.RadioButton();
            this.radRandom = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBox.SuspendLayout();
            this.grpBoxCellInfo.SuspendLayout();
            this.grpGenBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGrid
            // 
            this.createGrid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createGrid.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGrid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createGrid.Location = new System.Drawing.Point(6, 393);
            this.createGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createGrid.Name = "createGrid";
            this.createGrid.Size = new System.Drawing.Size(101, 64);
            this.createGrid.TabIndex = 0;
            this.createGrid.Text = "Generate Grid";
            this.createGrid.UseVisualStyleBackColor = false;
            this.createGrid.Click += new System.EventHandler(this.createGrid_Click);
            // 
            // radInfinite
            // 
            this.radInfinite.AutoSize = true;
            this.radInfinite.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radInfinite.Location = new System.Drawing.Point(104, 37);
            this.radInfinite.Name = "radInfinite";
            this.radInfinite.Size = new System.Drawing.Size(70, 20);
            this.radInfinite.TabIndex = 1;
            this.radInfinite.TabStop = true;
            this.radInfinite.Text = "Infinite";
            this.radInfinite.UseVisualStyleBackColor = false;
            // 
            // radPulsar
            // 
            this.radPulsar.AutoSize = true;
            this.radPulsar.Location = new System.Drawing.Point(8, 63);
            this.radPulsar.Name = "radPulsar";
            this.radPulsar.Size = new System.Drawing.Size(65, 20);
            this.radPulsar.TabIndex = 2;
            this.radPulsar.TabStop = true;
            this.radPulsar.Text = "Pulsar";
            this.radPulsar.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpBox.Controls.Add(this.lblGenerationNum);
            this.grpBox.Controls.Add(this.lblGen);
            this.grpBox.Controls.Add(this.btnSingleGen);
            this.grpBox.Controls.Add(this.btnSave);
            this.grpBox.Controls.Add(this.txtGenerations);
            this.grpBox.Controls.Add(this.lblPrompt);
            this.grpBox.Controls.Add(this.grpBoxCellInfo);
            this.grpBox.Controls.Add(this.runGenerations);
            this.grpBox.Controls.Add(this.createGrid);
            this.grpBox.Controls.Add(this.grpGenBox);
            this.grpBox.Location = new System.Drawing.Point(653, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(314, 561);
            this.grpBox.TabIndex = 5;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Menu";
            // 
            // lblGenerationNum
            // 
            this.lblGenerationNum.AutoSize = true;
            this.lblGenerationNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerationNum.Location = new System.Drawing.Point(216, 18);
            this.lblGenerationNum.Name = "lblGenerationNum";
            this.lblGenerationNum.Size = new System.Drawing.Size(19, 20);
            this.lblGenerationNum.TabIndex = 12;
            this.lblGenerationNum.Text = "0";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.ForeColor = System.Drawing.Color.Black;
            this.lblGen.Location = new System.Drawing.Point(100, 18);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(117, 20);
            this.lblGen.TabIndex = 12;
            this.lblGen.Text = "GENERATION";
            // 
            // btnSingleGen
            // 
            this.btnSingleGen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSingleGen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleGen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSingleGen.Location = new System.Drawing.Point(65, 499);
            this.btnSingleGen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSingleGen.Name = "btnSingleGen";
            this.btnSingleGen.Size = new System.Drawing.Size(197, 55);
            this.btnSingleGen.TabIndex = 15;
            this.btnSingleGen.Text = "Single Step Generation";
            this.btnSingleGen.UseVisualStyleBackColor = false;
            this.btnSingleGen.Click += new System.EventHandler(this.btnSingleGen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(223, 393);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 64);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Grid";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGenerations
            // 
            this.txtGenerations.Location = new System.Drawing.Point(209, 464);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(91, 22);
            this.txtGenerations.TabIndex = 8;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(6, 467);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(197, 16);
            this.lblPrompt.TabIndex = 7;
            this.lblPrompt.Text = "Enter Number of Generations:";
            // 
            // grpBoxCellInfo
            // 
            this.grpBoxCellInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxCellInfo.Controls.Add(this.lblRedCell);
            this.grpBoxCellInfo.Controls.Add(this.lblMagentaCell);
            this.grpBoxCellInfo.Controls.Add(this.lblBlueCell);
            this.grpBoxCellInfo.Controls.Add(this.lblGreenCell);
            this.grpBoxCellInfo.Controls.Add(this.lblYellowCell);
            this.grpBoxCellInfo.Controls.Add(this.lblDeadCell);
            this.grpBoxCellInfo.Controls.Add(this.lblRed);
            this.grpBoxCellInfo.Controls.Add(this.lblMagenta);
            this.grpBoxCellInfo.Controls.Add(this.lblBlue);
            this.grpBoxCellInfo.Controls.Add(this.lblGreen);
            this.grpBoxCellInfo.Controls.Add(this.lblYellow);
            this.grpBoxCellInfo.Controls.Add(this.lblWhite);
            this.grpBoxCellInfo.ForeColor = System.Drawing.Color.White;
            this.grpBoxCellInfo.Location = new System.Drawing.Point(6, 47);
            this.grpBoxCellInfo.Name = "grpBoxCellInfo";
            this.grpBoxCellInfo.Size = new System.Drawing.Size(302, 222);
            this.grpBoxCellInfo.TabIndex = 6;
            this.grpBoxCellInfo.TabStop = false;
            this.grpBoxCellInfo.Text = "Cell Color and Age Key";
            // 
            // lblRedCell
            // 
            this.lblRedCell.AutoSize = true;
            this.lblRedCell.ForeColor = System.Drawing.Color.Red;
            this.lblRedCell.Location = new System.Drawing.Point(253, 182);
            this.lblRedCell.Name = "lblRedCell";
            this.lblRedCell.Size = new System.Drawing.Size(16, 16);
            this.lblRedCell.TabIndex = 11;
            this.lblRedCell.Text = "0";
            // 
            // lblMagentaCell
            // 
            this.lblMagentaCell.AutoSize = true;
            this.lblMagentaCell.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMagentaCell.Location = new System.Drawing.Point(253, 151);
            this.lblMagentaCell.Name = "lblMagentaCell";
            this.lblMagentaCell.Size = new System.Drawing.Size(16, 16);
            this.lblMagentaCell.TabIndex = 10;
            this.lblMagentaCell.Text = "0";
            // 
            // lblBlueCell
            // 
            this.lblBlueCell.AutoSize = true;
            this.lblBlueCell.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBlueCell.Location = new System.Drawing.Point(253, 121);
            this.lblBlueCell.Name = "lblBlueCell";
            this.lblBlueCell.Size = new System.Drawing.Size(16, 16);
            this.lblBlueCell.TabIndex = 9;
            this.lblBlueCell.Text = "0";
            // 
            // lblGreenCell
            // 
            this.lblGreenCell.AutoSize = true;
            this.lblGreenCell.ForeColor = System.Drawing.Color.Lime;
            this.lblGreenCell.Location = new System.Drawing.Point(253, 90);
            this.lblGreenCell.Name = "lblGreenCell";
            this.lblGreenCell.Size = new System.Drawing.Size(16, 16);
            this.lblGreenCell.TabIndex = 8;
            this.lblGreenCell.Text = "0";
            // 
            // lblYellowCell
            // 
            this.lblYellowCell.AutoSize = true;
            this.lblYellowCell.ForeColor = System.Drawing.Color.Yellow;
            this.lblYellowCell.Location = new System.Drawing.Point(253, 59);
            this.lblYellowCell.Name = "lblYellowCell";
            this.lblYellowCell.Size = new System.Drawing.Size(16, 16);
            this.lblYellowCell.TabIndex = 7;
            this.lblYellowCell.Text = "0";
            // 
            // lblDeadCell
            // 
            this.lblDeadCell.AutoSize = true;
            this.lblDeadCell.Location = new System.Drawing.Point(253, 28);
            this.lblDeadCell.Name = "lblDeadCell";
            this.lblDeadCell.Size = new System.Drawing.Size(16, 16);
            this.lblDeadCell.TabIndex = 6;
            this.lblDeadCell.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(10, 182);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(142, 16);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "Red (4+ years old) = ";
            // 
            // lblMagenta
            // 
            this.lblMagenta.AutoSize = true;
            this.lblMagenta.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMagenta.Location = new System.Drawing.Point(10, 151);
            this.lblMagenta.Name = "lblMagenta";
            this.lblMagenta.Size = new System.Drawing.Size(164, 16);
            this.lblMagenta.TabIndex = 4;
            this.lblMagenta.Text = "Magenta (3 years old) = ";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBlue.Location = new System.Drawing.Point(10, 121);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(136, 16);
            this.lblBlue.TabIndex = 3;
            this.lblBlue.Text = "Blue (2 years old) = ";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.Color.Lime;
            this.lblGreen.Location = new System.Drawing.Point(8, 90);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(147, 16);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Green (1 years old) = ";
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.ForeColor = System.Drawing.Color.Yellow;
            this.lblYellow.Location = new System.Drawing.Point(8, 59);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(149, 16);
            this.lblYellow.TabIndex = 1;
            this.lblYellow.Text = "Yellow (0 years old) = ";
            // 
            // lblWhite
            // 
            this.lblWhite.AutoSize = true;
            this.lblWhite.Location = new System.Drawing.Point(8, 28);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(109, 16);
            this.lblWhite.TabIndex = 0;
            this.lblWhite.Text = "White (Dead) = ";
            // 
            // runGenerations
            // 
            this.runGenerations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runGenerations.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runGenerations.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.runGenerations.Location = new System.Drawing.Point(113, 393);
            this.runGenerations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.runGenerations.Name = "runGenerations";
            this.runGenerations.Size = new System.Drawing.Size(104, 64);
            this.runGenerations.TabIndex = 5;
            this.runGenerations.Text = "Run Generations";
            this.runGenerations.UseVisualStyleBackColor = false;
            this.runGenerations.Click += new System.EventHandler(this.runGenerations_Click);
            // 
            // grpGenBox
            // 
            this.grpGenBox.Controls.Add(this.radOF);
            this.grpGenBox.Controls.Add(this.txtPath);
            this.grpGenBox.Controls.Add(this.btnOpenFile);
            this.grpGenBox.Controls.Add(this.radPulsar);
            this.grpGenBox.Controls.Add(this.radBeacon);
            this.grpGenBox.Controls.Add(this.radRandom);
            this.grpGenBox.Controls.Add(this.radInfinite);
            this.grpGenBox.Location = new System.Drawing.Point(9, 275);
            this.grpGenBox.Name = "grpGenBox";
            this.grpGenBox.Size = new System.Drawing.Size(299, 117);
            this.grpGenBox.TabIndex = 6;
            this.grpGenBox.TabStop = false;
            this.grpGenBox.Text = "Type of Generation";
            // 
            // radOF
            // 
            this.radOF.AutoSize = true;
            this.radOF.Location = new System.Drawing.Point(200, 63);
            this.radOF.Name = "radOF";
            this.radOF.Size = new System.Drawing.Size(85, 20);
            this.radOF.TabIndex = 17;
            this.radOF.TabStop = true;
            this.radOF.Text = "Open File";
            this.radOF.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 89);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(208, 22);
            this.txtPath.TabIndex = 13;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenFile.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenFile.Location = new System.Drawing.Point(220, 87);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(73, 26);
            this.btnOpenFile.TabIndex = 12;
            this.btnOpenFile.Text = "Browse";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // radBeacon
            // 
            this.radBeacon.AutoSize = true;
            this.radBeacon.Location = new System.Drawing.Point(8, 37);
            this.radBeacon.Name = "radBeacon";
            this.radBeacon.Size = new System.Drawing.Size(72, 20);
            this.radBeacon.TabIndex = 3;
            this.radBeacon.TabStop = true;
            this.radBeacon.Text = "Beacon";
            this.radBeacon.UseVisualStyleBackColor = true;
            // 
            // radRandom
            // 
            this.radRandom.AutoSize = true;
            this.radRandom.Location = new System.Drawing.Point(104, 63);
            this.radRandom.Name = "radRandom";
            this.radRandom.Size = new System.Drawing.Size(77, 20);
            this.radRandom.TabIndex = 4;
            this.radRandom.TabStop = true;
            this.radRandom.Text = "Random";
            this.radRandom.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Format|*.txt";
            // 
            // Bloss_GOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 585);
            this.Controls.Add(this.grpBox);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bloss_GOL";
            this.Text = "Game Of Life";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.grpBoxCellInfo.ResumeLayout(false);
            this.grpBoxCellInfo.PerformLayout();
            this.grpGenBox.ResumeLayout(false);
            this.grpGenBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createGrid;
        private System.Windows.Forms.RadioButton radInfinite;
        private System.Windows.Forms.RadioButton radPulsar;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button runGenerations;
        private System.Windows.Forms.RadioButton radRandom;
        private System.Windows.Forms.RadioButton radBeacon;
        private System.Windows.Forms.GroupBox grpBoxCellInfo;
        private System.Windows.Forms.Label lblRedCell;
        private System.Windows.Forms.Label lblMagentaCell;
        private System.Windows.Forms.Label lblBlueCell;
        private System.Windows.Forms.Label lblGreenCell;
        private System.Windows.Forms.Label lblYellowCell;
        private System.Windows.Forms.Label lblDeadCell;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblMagenta;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSingleGen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.GroupBox grpGenBox;
        private System.Windows.Forms.RadioButton radOF;
        private System.Windows.Forms.Label lblGenerationNum;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

