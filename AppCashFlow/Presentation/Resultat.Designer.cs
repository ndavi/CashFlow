namespace AppCashFlow.Presentation
{
    partial class Resultat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tc_resultat = new System.Windows.Forms.TabControl();
            this.tp_cashflow = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amortissement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charges_anuelles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca_avant_is = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_is = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valeur_residuelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash_flow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cashFlowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tc_resultat.SuspendLayout();
            this.tp_cashflow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_resultat
            // 
            this.tc_resultat.Controls.Add(this.tp_cashflow);
            this.tc_resultat.Controls.Add(this.tabPage2);
            this.tc_resultat.Controls.Add(this.tabPage3);
            this.tc_resultat.Location = new System.Drawing.Point(1, 55);
            this.tc_resultat.Name = "tc_resultat";
            this.tc_resultat.SelectedIndex = 0;
            this.tc_resultat.Size = new System.Drawing.Size(840, 347);
            this.tc_resultat.TabIndex = 0;
            // 
            // tp_cashflow
            // 
            this.tp_cashflow.Controls.Add(this.dgv);
            this.tp_cashflow.Location = new System.Drawing.Point(4, 22);
            this.tp_cashflow.Name = "tp_cashflow";
            this.tp_cashflow.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cashflow.Size = new System.Drawing.Size(832, 321);
            this.tp_cashflow.TabIndex = 0;
            this.tp_cashflow.Text = "Cash-Flow";
            this.tp_cashflow.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ca,
            this.cv,
            this.cf,
            this.amortissement,
            this.charges_anuelles,
            this.ca_avant_is,
            this.montant_is,
            this.valeur_residuelle,
            this.cash_flow});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(826, 315);
            this.dgv.TabIndex = 0;
            // 
            // ca
            // 
            this.ca.HeaderText = "C.A";
            this.ca.Name = "ca";
            this.ca.ReadOnly = true;
            // 
            // cv
            // 
            this.cv.HeaderText = "C.V";
            this.cv.Name = "cv";
            this.cv.ReadOnly = true;
            // 
            // cf
            // 
            this.cf.HeaderText = "C.F";
            this.cf.Name = "cf";
            this.cf.ReadOnly = true;
            // 
            // amortissement
            // 
            this.amortissement.HeaderText = "Amortissement";
            this.amortissement.Name = "amortissement";
            this.amortissement.ReadOnly = true;
            // 
            // charges_anuelles
            // 
            this.charges_anuelles.HeaderText = "Charges Anuelles";
            this.charges_anuelles.Name = "charges_anuelles";
            this.charges_anuelles.ReadOnly = true;
            // 
            // ca_avant_is
            // 
            this.ca_avant_is.HeaderText = "Chiffre d\'affaires avant IS";
            this.ca_avant_is.Name = "ca_avant_is";
            this.ca_avant_is.ReadOnly = true;
            // 
            // montant_is
            // 
            this.montant_is.HeaderText = "Montant IS";
            this.montant_is.Name = "montant_is";
            this.montant_is.ReadOnly = true;
            // 
            // valeur_residuelle
            // 
            this.valeur_residuelle.HeaderText = "Valeur Résiduelle";
            this.valeur_residuelle.Name = "valeur_residuelle";
            this.valeur_residuelle.ReadOnly = true;
            // 
            // cash_flow
            // 
            this.cash_flow.HeaderText = "Cash Flow";
            this.cash_flow.Name = "cash_flow";
            this.cash_flow.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cash Flow Actualisé";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(672, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conclusion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cashFlowBindingSource
            // 
            this.cashFlowBindingSource.DataSource = typeof(Metier.CashFlow);
            // 
            // Resultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 394);
            this.Controls.Add(this.tc_resultat);
            this.Name = "Resultat";
            this.Text = "Resultat";
            this.tc_resultat.ResumeLayout(false);
            this.tp_cashflow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_resultat;
        private System.Windows.Forms.TabPage tp_cashflow;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf;
        private System.Windows.Forms.DataGridViewTextBoxColumn amortissement;
        private System.Windows.Forms.DataGridViewTextBoxColumn charges_anuelles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca_avant_is;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_is;
        private System.Windows.Forms.DataGridViewTextBoxColumn valeur_residuelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cash_flow;
        private System.Windows.Forms.BindingSource cashFlowBindingSource;
    }
}