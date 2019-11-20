namespace PrimeNTSC_1_02_ScanDashPatch
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.copyProgressBar = new System.Windows.Forms.ProgressBar();
            this.Patch_btn = new System.Windows.Forms.Button();
            this.SourceISO_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SourceISO_btn = new System.Windows.Forms.Button();
            this.SourceISO_txtBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.copyProgressBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Patch_btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SourceISO_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 112);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyProgressBar.Location = new System.Drawing.Point(3, 59);
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(576, 18);
            this.copyProgressBar.TabIndex = 5;
            this.copyProgressBar.Visible = false;
            // 
            // Patch_btn
            // 
            this.Patch_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Patch_btn.Location = new System.Drawing.Point(3, 83);
            this.Patch_btn.Name = "Patch_btn";
            this.Patch_btn.Size = new System.Drawing.Size(576, 26);
            this.Patch_btn.TabIndex = 4;
            this.Patch_btn.Text = "Patch";
            this.Patch_btn.UseVisualStyleBackColor = true;
            this.Patch_btn.Click += new System.EventHandler(this.Patch_btn_Click);
            // 
            // SourceISO_lbl
            // 
            this.SourceISO_lbl.AutoSize = true;
            this.SourceISO_lbl.Location = new System.Drawing.Point(3, 3);
            this.SourceISO_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.SourceISO_lbl.Name = "SourceISO_lbl";
            this.SourceISO_lbl.Size = new System.Drawing.Size(88, 17);
            this.SourceISO_lbl.TabIndex = 3;
            this.SourceISO_lbl.Text = "Source ISO :";
            this.toolTip1.SetToolTip(this.SourceISO_lbl, resources.GetString("SourceISO_lbl.ToolTip"));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.SourceISO_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SourceISO_txtBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // SourceISO_btn
            // 
            this.SourceISO_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceISO_btn.Location = new System.Drawing.Point(542, 6);
            this.SourceISO_btn.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.SourceISO_btn.Name = "SourceISO_btn";
            this.SourceISO_btn.Size = new System.Drawing.Size(40, 26);
            this.SourceISO_btn.TabIndex = 0;
            this.SourceISO_btn.Text = "...";
            this.SourceISO_btn.UseVisualStyleBackColor = true;
            this.SourceISO_btn.Click += new System.EventHandler(this.SourceISO_btn_Click);
            // 
            // SourceISO_txtBox
            // 
            this.SourceISO_txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceISO_txtBox.Location = new System.Drawing.Point(3, 6);
            this.SourceISO_txtBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.SourceISO_txtBox.Name = "SourceISO_txtBox";
            this.SourceISO_txtBox.Size = new System.Drawing.Size(536, 22);
            this.SourceISO_txtBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 112);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 159);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 159);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Prime PAL Scan Dash Patch";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SourceISO_btn;
        private System.Windows.Forms.TextBox SourceISO_txtBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label SourceISO_lbl;
        private System.Windows.Forms.Button Patch_btn;
        private System.Windows.Forms.ProgressBar copyProgressBar;
    }
}

