
namespace BoneMorphToTree
{
    partial class FormControl
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
            this.listBoxBoneMorph = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBoneMorph = new System.Windows.Forms.Label();
            this.labelParent = new System.Windows.Forms.Label();
            this.buttonParentAutoSelect = new System.Windows.Forms.Button();
            this.listBoxParentBone = new System.Windows.Forms.ListBox();
            this.checkBoxMove = new System.Windows.Forms.CheckBox();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelSetting = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxBoneMorph
            // 
            this.listBoxBoneMorph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBoneMorph.FormattingEnabled = true;
            this.listBoxBoneMorph.ItemHeight = 19;
            this.listBoxBoneMorph.Location = new System.Drawing.Point(4, 24);
            this.listBoxBoneMorph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxBoneMorph.Name = "listBoxBoneMorph";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxBoneMorph, 2);
            this.listBoxBoneMorph.Size = new System.Drawing.Size(256, 460);
            this.listBoxBoneMorph.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBoneMorph, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelParent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonParentAutoSelect, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxParentBone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxBoneMorph, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRun, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelSetting, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLog, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonReload, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 545);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelBoneMorph
            // 
            this.labelBoneMorph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBoneMorph.AutoSize = true;
            this.labelBoneMorph.Location = new System.Drawing.Point(3, 1);
            this.labelBoneMorph.Name = "labelBoneMorph";
            this.labelBoneMorph.Size = new System.Drawing.Size(99, 19);
            this.labelBoneMorph.TabIndex = 1;
            this.labelBoneMorph.Text = "ボーンモーフ";
            // 
            // labelParent
            // 
            this.labelParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelParent.AutoSize = true;
            this.labelParent.Location = new System.Drawing.Point(267, 1);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(69, 19);
            this.labelParent.TabIndex = 1;
            this.labelParent.Text = "親ボーン";
            // 
            // buttonParentAutoSelect
            // 
            this.buttonParentAutoSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParentAutoSelect.Location = new System.Drawing.Point(267, 23);
            this.buttonParentAutoSelect.Name = "buttonParentAutoSelect";
            this.buttonParentAutoSelect.Size = new System.Drawing.Size(258, 32);
            this.buttonParentAutoSelect.TabIndex = 2;
            this.buttonParentAutoSelect.Text = "自動で選択";
            this.buttonParentAutoSelect.UseVisualStyleBackColor = true;
            // 
            // listBoxParentBone
            // 
            this.listBoxParentBone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxParentBone.FormattingEnabled = true;
            this.listBoxParentBone.ItemHeight = 19;
            this.listBoxParentBone.Location = new System.Drawing.Point(268, 62);
            this.listBoxParentBone.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParentBone.Name = "listBoxParentBone";
            this.listBoxParentBone.Size = new System.Drawing.Size(256, 422);
            this.listBoxParentBone.TabIndex = 0;
            // 
            // checkBoxMove
            // 
            this.checkBoxMove.AutoSize = true;
            this.checkBoxMove.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMove.Name = "checkBoxMove";
            this.checkBoxMove.Size = new System.Drawing.Size(58, 23);
            this.checkBoxMove.TabIndex = 0;
            this.checkBoxMove.Text = "移動";
            this.checkBoxMove.UseVisualStyleBackColor = true;
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(67, 3);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(58, 23);
            this.checkBoxRotate.TabIndex = 0;
            this.checkBoxRotate.Text = "回転";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(531, 491);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(128, 51);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "実行";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // labelSetting
            // 
            this.labelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(531, 1);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(39, 19);
            this.labelSetting.TabIndex = 1;
            this.labelSetting.Text = "設定";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMove);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRotate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(531, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(531, 61);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(128, 424);
            this.textBoxLog.TabIndex = 5;
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.buttonReload, 2);
            this.buttonReload.Location = new System.Drawing.Point(3, 491);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(522, 51);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.Text = "再読込";
            this.buttonReload.UseVisualStyleBackColor = true;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("游ゴシック Medium", 11F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(702, 608);
            this.Name = "FormControl";
            this.Text = "BoneMorphToTree";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBoneMorph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBoneMorph;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Button buttonParentAutoSelect;
        private System.Windows.Forms.ListBox listBoxParentBone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxMove;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonReload;
    }
}