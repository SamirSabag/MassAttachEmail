﻿namespace MassAttachEmail
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabFormat = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectSignature = new System.Windows.Forms.ComboBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.wbSignDisplay = new System.Windows.Forms.WebBrowser();
            this.tabMapping = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadMappingTable = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveEmails = new System.Windows.Forms.Button();
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.lblEmailBody = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLoggText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabFormat.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabMapping.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.895735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.10426F));
            this.tableLayoutPanel1.Controls.Add(this.tabPage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabFormat);
            this.tabPage.Controls.Add(this.tabMapping);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Font = new System.Drawing.Font("HP Simplified", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.Location = new System.Drawing.Point(17, 3);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(724, 534);
            this.tabPage.TabIndex = 0;
            // 
            // tabFormat
            // 
            this.tabFormat.Controls.Add(this.tableLayoutPanel3);
            this.tabFormat.Location = new System.Drawing.Point(4, 29);
            this.tabFormat.Name = "tabFormat";
            this.tabFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormat.Size = new System.Drawing.Size(716, 501);
            this.tabFormat.TabIndex = 0;
            this.tabFormat.Text = "Format";
            this.tabFormat.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.23588F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.76412F));
            this.tableLayoutPanel3.Controls.Add(this.tbSubject, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblEmailBody, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSubject, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtLoggText, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.wbSignDisplay, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.677525F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.45277F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.72881F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.234637F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.27374F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(710, 495);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tbSubject
            // 
            this.tbSubject.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSubject.Location = new System.Drawing.Point(210, 3);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(350, 26);
            this.tbSubject.TabIndex = 9;
            this.tbSubject.Visible = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("HP Simplified", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(3, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(79, 16);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Email subject";
            this.lblSubject.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbSelectSignature, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSignature, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(201, 168);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select signature";
            // 
            // cbSelectSignature
            // 
            this.cbSelectSignature.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbSelectSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSelectSignature.FormattingEnabled = true;
            this.cbSelectSignature.Location = new System.Drawing.Point(3, 115);
            this.cbSelectSignature.Name = "cbSelectSignature";
            this.cbSelectSignature.Size = new System.Drawing.Size(195, 28);
            this.cbSelectSignature.TabIndex = 3;
            this.cbSelectSignature.SelectedIndexChanged += new System.EventHandler(this.CbSelectSignature_SelectedIndexChanged);
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("HP Simplified", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(3, 0);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(92, 16);
            this.lblSignature.TabIndex = 0;
            this.lblSignature.Text = "Email signature";
            // 
            // wbSignDisplay
            // 
            this.wbSignDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbSignDisplay.Location = new System.Drawing.Point(210, 110);
            this.wbSignDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSignDisplay.Name = "wbSignDisplay";
            this.wbSignDisplay.Size = new System.Drawing.Size(497, 168);
            this.wbSignDisplay.TabIndex = 13;
            // 
            // tabMapping
            // 
            this.tabMapping.Controls.Add(this.tableLayoutPanel2);
            this.tabMapping.Location = new System.Drawing.Point(4, 29);
            this.tabMapping.Name = "tabMapping";
            this.tabMapping.Padding = new System.Windows.Forms.Padding(3);
            this.tabMapping.Size = new System.Drawing.Size(608, 501);
            this.tabMapping.TabIndex = 1;
            this.tabMapping.Text = "Mapping";
            this.tabMapping.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnLoadMappingTable, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvDisplay, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 495);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnLoadMappingTable
            // 
            this.btnLoadMappingTable.Font = new System.Drawing.Font("HP Simplified", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadMappingTable.Location = new System.Drawing.Point(3, 374);
            this.btnLoadMappingTable.Name = "btnLoadMappingTable";
            this.btnLoadMappingTable.Size = new System.Drawing.Size(166, 33);
            this.btnLoadMappingTable.TabIndex = 6;
            this.btnLoadMappingTable.Text = "Load mapping table";
            this.btnLoadMappingTable.UseVisualStyleBackColor = true;
            this.btnLoadMappingTable.Click += new System.EventHandler(this.BtnLoadMappingTable_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplay.Location = new System.Drawing.Point(3, 3);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(596, 365);
            this.dgvDisplay.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnSaveEmails, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSendEmails, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(17, 543);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(724, 54);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnSaveEmails
            // 
            this.btnSaveEmails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveEmails.Enabled = false;
            this.btnSaveEmails.Font = new System.Drawing.Font("HP Simplified", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmails.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaveEmails.Location = new System.Drawing.Point(435, 3);
            this.btnSaveEmails.Name = "btnSaveEmails";
            this.btnSaveEmails.Size = new System.Drawing.Size(95, 37);
            this.btnSaveEmails.TabIndex = 19;
            this.btnSaveEmails.Text = "Save emails";
            this.btnSaveEmails.UseVisualStyleBackColor = false;
            this.btnSaveEmails.Click += new System.EventHandler(this.BtnSaveEmails_Click);
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSendEmails.Enabled = false;
            this.btnSendEmails.Font = new System.Drawing.Font("HP Simplified", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmails.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSendEmails.Location = new System.Drawing.Point(579, 3);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(99, 37);
            this.btnSendEmails.TabIndex = 14;
            this.btnSendEmails.Text = "Send emails";
            this.btnSendEmails.UseVisualStyleBackColor = false;
            this.btnSendEmails.Click += new System.EventHandler(this.BtnSendEmails_Click);
            // 
            // lblEmailBody
            // 
            this.lblEmailBody.AutoSize = true;
            this.lblEmailBody.Font = new System.Drawing.Font("HP Simplified", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailBody.Location = new System.Drawing.Point(3, 23);
            this.lblEmailBody.Name = "lblEmailBody";
            this.lblEmailBody.Size = new System.Drawing.Size(65, 16);
            this.lblEmailBody.TabIndex = 5;
            this.lblEmailBody.Text = "Email body";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(210, 26);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(497, 78);
            this.richTextBox1.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel3.SetColumnSpan(this.btnUpdate, 2);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(3, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 38);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtLoggText
            // 
            this.txtLoggText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel3.SetColumnSpan(this.txtLoggText, 2);
            this.txtLoggText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoggText.Font = new System.Drawing.Font("HP Simplified Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoggText.Location = new System.Drawing.Point(3, 361);
            this.txtLoggText.Multiline = true;
            this.txtLoggText.Name = "txtLoggText";
            this.txtLoggText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoggText.Size = new System.Drawing.Size(704, 131);
            this.txtLoggText.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(744, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("HP Simplified", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mass Attachments";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabFormat.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabMapping.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabFormat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabMapping;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectSignature;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.WebBrowser wbSignDisplay;
        private System.Windows.Forms.Button btnLoadMappingTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.Button btnSaveEmails;
        private System.Windows.Forms.Label lblEmailBody;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLoggText;
    }
}

