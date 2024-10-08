﻿namespace Acquaint.Integrators.Api.Tests
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRun = new Button();
            txtApiResponse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSelectedAPIUrl = new TextBox();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            txtAPIKey = new TextBox();
            label8 = new Label();
            label7 = new Label();
            comboBoxUrls = new ComboBox();
            treeViewApis = new TreeView();
            txtAPIRequestBody = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            txtAuthRequestBody = new RichTextBox();
            txtSitePrefix = new TextBox();
            label4 = new Label();
            progressBarLoading = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.Font = new Font("Segoe UI", 10F);
            buttonRun.Location = new Point(392, 767);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(104, 28);
            buttonRun.TabIndex = 1;
            buttonRun.Text = "Run API";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // txtApiResponse
            // 
            txtApiResponse.Location = new Point(3, 36);
            txtApiResponse.Multiline = true;
            txtApiResponse.Name = "txtApiResponse";
            txtApiResponse.ReadOnly = true;
            txtApiResponse.ScrollBars = ScrollBars.Both;
            txtApiResponse.Size = new Size(555, 759);
            txtApiResponse.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 193);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "APIs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Results";
            // 
            // txtSelectedAPIUrl
            // 
            txtSelectedAPIUrl.Font = new Font("Segoe UI", 9F);
            txtSelectedAPIUrl.Location = new Point(6, 526);
            txtSelectedAPIUrl.Name = "txtSelectedAPIUrl";
            txtSelectedAPIUrl.Size = new Size(490, 23);
            txtSelectedAPIUrl.TabIndex = 5;
            txtSelectedAPIUrl.KeyDown += txtSelectedAPIUrl_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 508);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Selected API Url";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtAPIKey);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(comboBoxUrls);
            splitContainer1.Panel1.Controls.Add(treeViewApis);
            splitContainer1.Panel1.Controls.Add(txtAPIRequestBody);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(buttonRun);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(txtAuthRequestBody);
            splitContainer1.Panel1.Controls.Add(txtSitePrefix);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtSelectedAPIUrl);
            splitContainer1.Panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(progressBarLoading);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(txtApiResponse);
            splitContainer1.Size = new Size(1068, 802);
            splitContainer1.SplitterDistance = 503;
            splitContainer1.TabIndex = 7;
            // 
            // txtAPIKey
            // 
            txtAPIKey.Font = new Font("Segoe UI", 9F);
            txtAPIKey.Location = new Point(89, 58);
            txtAPIKey.Name = "txtAPIKey";
            txtAPIKey.Size = new Size(381, 23);
            txtAPIKey.TabIndex = 16;
            txtAPIKey.Leave += txtAPIKey_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 61);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 15;
            label8.Text = "API Key";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 36);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 14;
            label7.Text = "Site Prefix";
            // 
            // comboBoxUrls
            // 
            comboBoxUrls.Font = new Font("Segoe UI", 9F);
            comboBoxUrls.FormattingEnabled = true;
            comboBoxUrls.Items.AddRange(new object[] { "https://api.integrators.acquaintcrm.co.uk/", "https://localhost:44324" });
            comboBoxUrls.Location = new Point(89, 7);
            comboBoxUrls.Name = "comboBoxUrls";
            comboBoxUrls.Size = new Size(381, 23);
            comboBoxUrls.TabIndex = 13;
            comboBoxUrls.SelectedValueChanged += comboBoxUrls_SelectedValueChanged;
            // 
            // treeViewApis
            // 
            treeViewApis.Font = new Font("Segoe UI", 9F);
            treeViewApis.Location = new Point(6, 211);
            treeViewApis.Name = "treeViewApis";
            treeViewApis.Size = new Size(490, 294);
            treeViewApis.TabIndex = 5;
            treeViewApis.BeforeExpand += treeViewApis_BeforeExpand;
            treeViewApis.AfterSelect += treeViewApis_AfterSelect;
            // 
            // txtAPIRequestBody
            // 
            txtAPIRequestBody.Font = new Font("Segoe UI", 9F);
            txtAPIRequestBody.Location = new Point(7, 569);
            txtAPIRequestBody.Name = "txtAPIRequestBody";
            txtAPIRequestBody.Size = new Size(489, 192);
            txtAPIRequestBody.TabIndex = 12;
            txtAPIRequestBody.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 551);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 11;
            label6.Text = "API Request";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 97);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 10;
            label5.Text = "Auth Body";
            // 
            // txtAuthRequestBody
            // 
            txtAuthRequestBody.Font = new Font("Segoe UI", 9F);
            txtAuthRequestBody.Location = new Point(6, 115);
            txtAuthRequestBody.Name = "txtAuthRequestBody";
            txtAuthRequestBody.Size = new Size(490, 75);
            txtAuthRequestBody.TabIndex = 9;
            txtAuthRequestBody.Text = "";
            // 
            // txtSitePrefix
            // 
            txtSitePrefix.Font = new Font("Segoe UI", 9F);
            txtSitePrefix.Location = new Point(89, 33);
            txtSitePrefix.Name = "txtSitePrefix";
            txtSitePrefix.Size = new Size(381, 23);
            txtSitePrefix.TabIndex = 8;
            txtSitePrefix.Leave += txtSitePrefix_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 13);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Base Url";
            // 
            // progressBarLoading
            // 
            progressBarLoading.Location = new Point(407, 7);
            progressBarLoading.Name = "progressBarLoading";
            progressBarLoading.Size = new Size(142, 23);
            progressBarLoading.Style = ProgressBarStyle.Marquee;
            progressBarLoading.TabIndex = 5;
            progressBarLoading.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 802);
            Controls.Add(splitContainer1);
            Name = "frmMain";
            Text = "Acquaint Integrators API Tests";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonRun;
        private TextBox txtApiResponse;
        private Label label1;
        private Label label2;
        private TextBox txtSelectedAPIUrl;
        private Label label3;
        private SplitContainer splitContainer1;
        private Label label4;
        private TextBox txtSitePrefix;
        private RichTextBox txtAuthRequestBody;
        private Label label5;
        private RichTextBox txtAPIRequestBody;
        private Label label6;
        private TreeView treeViewApis;
        private ProgressBar progressBarLoading;
        private ComboBox comboBoxUrls;
        private Label label7;
        private TextBox txtAPIKey;
        private Label label8;
    }
}
