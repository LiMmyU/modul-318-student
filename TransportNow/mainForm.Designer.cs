namespace TransportNow
{
    partial class mainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.dtpickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblZielort = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.dgviewAbfahrtsplan = new System.Windows.Forms.DataGridView();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewAbfahrtsplan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.7F);
            this.btnSearch.Location = new System.Drawing.Point(352, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 78);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(103, 65);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(243, 22);
            this.txtDestination.TabIndex = 2;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(103, 37);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(243, 22);
            this.txtDeparture.TabIndex = 1;
            // 
            // dtpickerDate
            // 
            this.dtpickerDate.Location = new System.Drawing.Point(103, 93);
            this.dtpickerDate.Name = "dtpickerDate";
            this.dtpickerDate.Size = new System.Drawing.Size(243, 22);
            this.dtpickerDate.TabIndex = 3;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(15, 40);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(82, 17);
            this.lblDeparture.TabIndex = 5;
            this.lblDeparture.Text = "Abfahrtsort:";
            // 
            // lblZielort
            // 
            this.lblZielort.AutoSize = true;
            this.lblZielort.Location = new System.Drawing.Point(45, 68);
            this.lblZielort.Name = "lblZielort";
            this.lblZielort.Size = new System.Drawing.Size(52, 17);
            this.lblZielort.TabIndex = 6;
            this.lblZielort.Text = "Zielort:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(297, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 39);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "TransportNow";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtDeparture);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblZielort);
            this.grpSearch.Controls.Add(this.txtDestination);
            this.grpSearch.Controls.Add(this.lblDeparture);
            this.grpSearch.Controls.Add(this.dtpickerDate);
            this.grpSearch.Location = new System.Drawing.Point(201, 102);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(466, 138);
            this.grpSearch.TabIndex = 8;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Verbindungssuche";
            // 
            // dgviewAbfahrtsplan
            // 
            this.dgviewAbfahrtsplan.AllowUserToAddRows = false;
            this.dgviewAbfahrtsplan.AllowUserToDeleteRows = false;
            this.dgviewAbfahrtsplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewAbfahrtsplan.Location = new System.Drawing.Point(68, 246);
            this.dgviewAbfahrtsplan.Name = "dgviewAbfahrtsplan";
            this.dgviewAbfahrtsplan.ReadOnly = true;
            this.dgviewAbfahrtsplan.RowTemplate.Height = 24;
            this.dgviewAbfahrtsplan.Size = new System.Drawing.Size(745, 215);
            this.dgviewAbfahrtsplan.TabIndex = 10;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 504);
            this.Controls.Add(this.dgviewAbfahrtsplan);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(546, 551);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewAbfahrtsplan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.DateTimePicker dtpickerDate;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblZielort;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView dgviewAbfahrtsplan;
    }
}

