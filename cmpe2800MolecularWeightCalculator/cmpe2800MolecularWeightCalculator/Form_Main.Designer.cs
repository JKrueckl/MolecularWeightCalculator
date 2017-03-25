namespace cmpe2800MolecularWeightCalculator
{
    partial class dlg_Main
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
            this.UI_DGV_ElementDisplay = new System.Windows.Forms.DataGridView();
            this.UI_LB_ChemForm = new System.Windows.Forms.Label();
            this.UI_TB_ChemForm = new System.Windows.Forms.TextBox();
            this.UI_TB_MolarMass = new System.Windows.Forms.TextBox();
            this.UI_LB_MolarMass = new System.Windows.Forms.Label();
            this.UI_Btn_SortByName = new System.Windows.Forms.Button();
            this.UI_Btn_SingleCharSymbols = new System.Windows.Forms.Button();
            this.UI_Btn_SortAtomicNum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGV_ElementDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_DGV_ElementDisplay
            // 
            this.UI_DGV_ElementDisplay.AllowUserToOrderColumns = true;
            this.UI_DGV_ElementDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_DGV_ElementDisplay.Location = new System.Drawing.Point(12, 12);
            this.UI_DGV_ElementDisplay.Name = "UI_DGV_ElementDisplay";
            this.UI_DGV_ElementDisplay.Size = new System.Drawing.Size(624, 413);
            this.UI_DGV_ElementDisplay.TabIndex = 0;
            // 
            // UI_LB_ChemForm
            // 
            this.UI_LB_ChemForm.AutoSize = true;
            this.UI_LB_ChemForm.Location = new System.Drawing.Point(12, 442);
            this.UI_LB_ChemForm.Name = "UI_LB_ChemForm";
            this.UI_LB_ChemForm.Size = new System.Drawing.Size(96, 13);
            this.UI_LB_ChemForm.TabIndex = 1;
            this.UI_LB_ChemForm.Text = "Chemical Formula: ";
            // 
            // UI_TB_ChemForm
            // 
            this.UI_TB_ChemForm.Location = new System.Drawing.Point(110, 439);
            this.UI_TB_ChemForm.Name = "UI_TB_ChemForm";
            this.UI_TB_ChemForm.Size = new System.Drawing.Size(357, 20);
            this.UI_TB_ChemForm.TabIndex = 2;
            this.UI_TB_ChemForm.TextChanged += new System.EventHandler(this.UI_TB_ChemForm_TextChanged);
            // 
            // UI_TB_MolarMass
            // 
            this.UI_TB_MolarMass.Location = new System.Drawing.Point(642, 439);
            this.UI_TB_MolarMass.Name = "UI_TB_MolarMass";
            this.UI_TB_MolarMass.Size = new System.Drawing.Size(162, 20);
            this.UI_TB_MolarMass.TabIndex = 3;
            // 
            // UI_LB_MolarMass
            // 
            this.UI_LB_MolarMass.AutoSize = true;
            this.UI_LB_MolarMass.Location = new System.Drawing.Point(530, 442);
            this.UI_LB_MolarMass.Name = "UI_LB_MolarMass";
            this.UI_LB_MolarMass.Size = new System.Drawing.Size(106, 13);
            this.UI_LB_MolarMass.TabIndex = 4;
            this.UI_LB_MolarMass.Text = "Approx. Molar Mass :";
            // 
            // UI_Btn_SortByName
            // 
            this.UI_Btn_SortByName.Location = new System.Drawing.Point(642, 12);
            this.UI_Btn_SortByName.Name = "UI_Btn_SortByName";
            this.UI_Btn_SortByName.Size = new System.Drawing.Size(162, 23);
            this.UI_Btn_SortByName.TabIndex = 5;
            this.UI_Btn_SortByName.Text = "Sort By Name";
            this.UI_Btn_SortByName.UseVisualStyleBackColor = true;
            this.UI_Btn_SortByName.Click += new System.EventHandler(this.UI_Btn_SortByName_Click);
            // 
            // UI_Btn_SingleCharSymbols
            // 
            this.UI_Btn_SingleCharSymbols.Location = new System.Drawing.Point(642, 41);
            this.UI_Btn_SingleCharSymbols.Name = "UI_Btn_SingleCharSymbols";
            this.UI_Btn_SingleCharSymbols.Size = new System.Drawing.Size(162, 23);
            this.UI_Btn_SingleCharSymbols.TabIndex = 6;
            this.UI_Btn_SingleCharSymbols.Text = "Single Character Symbols";
            this.UI_Btn_SingleCharSymbols.UseVisualStyleBackColor = true;
            this.UI_Btn_SingleCharSymbols.Click += new System.EventHandler(this.UI_Btn_SingleCharSymbols_Click);
            // 
            // UI_Btn_SortAtomicNum
            // 
            this.UI_Btn_SortAtomicNum.Location = new System.Drawing.Point(642, 70);
            this.UI_Btn_SortAtomicNum.Name = "UI_Btn_SortAtomicNum";
            this.UI_Btn_SortAtomicNum.Size = new System.Drawing.Size(162, 23);
            this.UI_Btn_SortAtomicNum.TabIndex = 7;
            this.UI_Btn_SortAtomicNum.Text = "Sort By Atomic #";
            this.UI_Btn_SortAtomicNum.UseVisualStyleBackColor = true;
            this.UI_Btn_SortAtomicNum.Click += new System.EventHandler(this.UI_Btn_SortAtomicNum_Click);
            // 
            // dlg_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 469);
            this.Controls.Add(this.UI_Btn_SortAtomicNum);
            this.Controls.Add(this.UI_Btn_SingleCharSymbols);
            this.Controls.Add(this.UI_Btn_SortByName);
            this.Controls.Add(this.UI_LB_MolarMass);
            this.Controls.Add(this.UI_TB_MolarMass);
            this.Controls.Add(this.UI_TB_ChemForm);
            this.Controls.Add(this.UI_LB_ChemForm);
            this.Controls.Add(this.UI_DGV_ElementDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "dlg_Main";
            this.Text = "LINQ ICA";
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGV_ElementDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UI_DGV_ElementDisplay;
        private System.Windows.Forms.Label UI_LB_ChemForm;
        private System.Windows.Forms.TextBox UI_TB_ChemForm;
        private System.Windows.Forms.TextBox UI_TB_MolarMass;
        private System.Windows.Forms.Label UI_LB_MolarMass;
        private System.Windows.Forms.Button UI_Btn_SortByName;
        private System.Windows.Forms.Button UI_Btn_SingleCharSymbols;
        private System.Windows.Forms.Button UI_Btn_SortAtomicNum;
    }
}

