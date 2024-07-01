namespace LiveSplit.UI.Components
{
    partial class MoreComparisonsSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableName = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.tableFinalTime = new System.Windows.Forms.TableLayoutPanel();
            this.labelFinalTime = new System.Windows.Forms.Label();
            this.textFinalTime = new System.Windows.Forms.TextBox();
            this.tableComparisonMethod = new System.Windows.Forms.TableLayoutPanel();
            this.dropDownMethod = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.tablePercent = new System.Windows.Forms.TableLayoutPanel();
            this.labelPercent = new System.Windows.Forms.Label();
            this.numericPercent = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelCompAlrExists = new System.Windows.Forms.Label();
            this.labelTimeFormat = new System.Windows.Forms.Label();
            this.topTableContainer.SuspendLayout();
            this.tableName.SuspendLayout();
            this.tableFinalTime.SuspendLayout();
            this.tableComparisonMethod.SuspendLayout();
            this.tablePercent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // topTableContainer
            // 
            this.topTableContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topTableContainer.ColumnCount = 1;
            this.topTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 346F));
            this.topTableContainer.Controls.Add(this.tableName, 0, 0);
            this.topTableContainer.Controls.Add(this.tableFinalTime, 0, 1);
            this.topTableContainer.Controls.Add(this.tableComparisonMethod, 0, 3);
            this.topTableContainer.Controls.Add(this.buttonGenerate, 0, 5);
            this.topTableContainer.Controls.Add(this.labelCompAlrExists, 0, 4);
            this.topTableContainer.Location = new System.Drawing.Point(0, 0);
            this.topTableContainer.Name = "topTableContainer";
            this.topTableContainer.RowCount = 6;
            this.topTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.42719F));
            this.topTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.57281F));
            this.topTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.topTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.topTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.topTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 448F));
            this.topTableContainer.Size = new System.Drawing.Size(331, 734);
            this.topTableContainer.TabIndex = 0;
            this.topTableContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.topTableContainer_Paint);
            // 
            // tableName
            // 
            this.tableName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableName.AutoScroll = true;
            this.tableName.AutoSize = true;
            this.tableName.ColumnCount = 2;
            this.tableName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53846F));
            this.tableName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.46154F));
            this.tableName.Controls.Add(this.labelName, 0, 0);
            this.tableName.Controls.Add(this.textName, 1, 0);
            this.tableName.Location = new System.Drawing.Point(3, 9);
            this.tableName.Name = "tableName";
            this.tableName.RowCount = 1;
            this.tableName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableName.Size = new System.Drawing.Size(325, 26);
            this.tableName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 26);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Comparison Name";
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textName.Location = new System.Drawing.Point(85, 3);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(159, 20);
            this.textName.TabIndex = 0;
            this.textName.Text = "New Comparison";
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // tableFinalTime
            // 
            this.tableFinalTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableFinalTime.ColumnCount = 3;
            this.tableFinalTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.45928F));
            this.tableFinalTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.54072F));
            this.tableFinalTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableFinalTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableFinalTime.Controls.Add(this.labelFinalTime, 0, 0);
            this.tableFinalTime.Controls.Add(this.textFinalTime, 1, 0);
            this.tableFinalTime.Controls.Add(this.labelTimeFormat, 2, 0);
            this.tableFinalTime.Location = new System.Drawing.Point(3, 47);
            this.tableFinalTime.Name = "tableFinalTime";
            this.tableFinalTime.RowCount = 1;
            this.tableFinalTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFinalTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFinalTime.Size = new System.Drawing.Size(325, 33);
            this.tableFinalTime.TabIndex = 3;
            this.tableFinalTime.Paint += new System.Windows.Forms.PaintEventHandler(this.tableFinalTime_Paint);
            // 
            // labelFinalTime
            // 
            this.labelFinalTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFinalTime.AutoSize = true;
            this.labelFinalTime.Location = new System.Drawing.Point(3, 3);
            this.labelFinalTime.Name = "labelFinalTime";
            this.labelFinalTime.Size = new System.Drawing.Size(55, 26);
            this.labelFinalTime.TabIndex = 0;
            this.labelFinalTime.Text = "Final Split Time";
            // 
            // textFinalTime
            // 
            this.textFinalTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textFinalTime.Location = new System.Drawing.Point(85, 6);
            this.textFinalTime.Name = "textFinalTime";
            this.textFinalTime.Size = new System.Drawing.Size(90, 20);
            this.textFinalTime.TabIndex = 4;
            this.textFinalTime.TextChanged += new System.EventHandler(this.textFinalTime_TextChanged);
            // 
            // tableComparisonMethod
            // 
            this.tableComparisonMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableComparisonMethod.ColumnCount = 3;
            this.tableComparisonMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.67442F));
            this.tableComparisonMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.32558F));
            this.tableComparisonMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableComparisonMethod.Controls.Add(this.dropDownMethod, 1, 0);
            this.tableComparisonMethod.Controls.Add(this.labelMethod, 0, 0);
            this.tableComparisonMethod.Controls.Add(this.tablePercent, 2, 0);
            this.tableComparisonMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableComparisonMethod.Location = new System.Drawing.Point(3, 94);
            this.tableComparisonMethod.Name = "tableComparisonMethod";
            this.tableComparisonMethod.RowCount = 1;
            this.tableComparisonMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableComparisonMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableComparisonMethod.Size = new System.Drawing.Size(325, 80);
            this.tableComparisonMethod.TabIndex = 6;
            // 
            // dropDownMethod
            // 
            this.dropDownMethod.AllowDrop = true;
            this.dropDownMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropDownMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownMethod.FormattingEnabled = true;
            this.dropDownMethod.Items.AddRange(new object[] {
            "Constant",
            "Length",
            "Random"});
            this.dropDownMethod.Location = new System.Drawing.Point(85, 29);
            this.dropDownMethod.Name = "dropDownMethod";
            this.dropDownMethod.Size = new System.Drawing.Size(84, 21);
            this.dropDownMethod.Sorted = true;
            this.dropDownMethod.TabIndex = 7;
            this.dropDownMethod.SelectedIndexChanged += new System.EventHandler(this.dropDownMethod_SelectedIndexChanged);
            // 
            // labelMethod
            // 
            this.labelMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(3, 27);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(59, 26);
            this.labelMethod.TabIndex = 6;
            this.labelMethod.Text = "Timesave Generation";
            this.labelMethod.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablePercent
            // 
            this.tablePercent.ColumnCount = 1;
            this.tablePercent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePercent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePercent.Controls.Add(this.labelPercent, 0, 0);
            this.tablePercent.Controls.Add(this.numericPercent, 0, 1);
            this.tablePercent.Location = new System.Drawing.Point(175, 3);
            this.tablePercent.Name = "tablePercent";
            this.tablePercent.RowCount = 2;
            this.tablePercent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePercent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePercent.Size = new System.Drawing.Size(147, 74);
            this.tablePercent.TabIndex = 8;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(3, 0);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(90, 26);
            this.labelPercent.TabIndex = 0;
            this.labelPercent.Text = "Timesave Spread\r\n(0-100)\r\n";
            this.labelPercent.Click += new System.EventHandler(this.labelPercent_Click);
            // 
            // numericPercent
            // 
            this.numericPercent.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPercent.Location = new System.Drawing.Point(3, 40);
            this.numericPercent.Name = "numericPercent";
            this.numericPercent.Size = new System.Drawing.Size(108, 20);
            this.numericPercent.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(3, 288);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(325, 90);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Add Comparison";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelCompAlrExists
            // 
            this.labelCompAlrExists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompAlrExists.AutoSize = true;
            this.labelCompAlrExists.Location = new System.Drawing.Point(3, 177);
            this.labelCompAlrExists.Name = "labelCompAlrExists";
            this.labelCompAlrExists.Size = new System.Drawing.Size(325, 13);
            this.labelCompAlrExists.TabIndex = 8;
            this.labelCompAlrExists.Text = "Warning: A comparison already exists with this name.";
            this.labelCompAlrExists.Click += new System.EventHandler(this.labelCompAlrExists_Click);
            // 
            // labelTimeFormat
            // 
            this.labelTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimeFormat.AutoSize = true;
            this.labelTimeFormat.Location = new System.Drawing.Point(222, 3);
            this.labelTimeFormat.Name = "labelTimeFormat";
            this.labelTimeFormat.Size = new System.Drawing.Size(73, 26);
            this.labelTimeFormat.TabIndex = 1;
            this.labelTimeFormat.Text = "(hh:mm:ss.ms)\r\n(Blank for PB)";
            // 
            // MoreComparisonsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.topTableContainer);
            this.Name = "MoreComparisonsSettings";
            this.Size = new System.Drawing.Size(590, 737);
            this.Load += new System.EventHandler(this.MoreComparisonsSettings_Load);
            this.topTableContainer.ResumeLayout(false);
            this.topTableContainer.PerformLayout();
            this.tableName.ResumeLayout(false);
            this.tableName.PerformLayout();
            this.tableFinalTime.ResumeLayout(false);
            this.tableFinalTime.PerformLayout();
            this.tableComparisonMethod.ResumeLayout(false);
            this.tableComparisonMethod.PerformLayout();
            this.tablePercent.ResumeLayout(false);
            this.tablePercent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topTableContainer;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TableLayoutPanel tableName;
        private System.Windows.Forms.TableLayoutPanel tableFinalTime;
        private System.Windows.Forms.Label labelFinalTime;
        private System.Windows.Forms.TextBox textFinalTime;
        private System.Windows.Forms.TableLayoutPanel tableComparisonMethod;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.ComboBox dropDownMethod;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelCompAlrExists;
        private System.Windows.Forms.TableLayoutPanel tablePercent;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.NumericUpDown numericPercent;
        private System.Windows.Forms.Label labelTimeFormat;
    }
}
