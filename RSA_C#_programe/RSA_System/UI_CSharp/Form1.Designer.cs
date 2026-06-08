using System;
using System.Drawing;
using System.Windows.Forms;

namespace RSA_Signature_App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblAppTitle = new Label();
            lblAppSubtitle = new Label();
            pnlHeaderAccent = new Panel();
            picLogo = new PictureBox();
            pnlStatusBar = new Panel();
            picStatusIcon = new PictureBox();
            lblStatusMessage = new Label();
            tlpMainLayout = new TableLayoutPanel();
            gbConfig = new GroupBox();
            pnlConfigInner = new Panel();
            pnlManualParams = new Panel();
            tlpManualFields = new TableLayoutPanel();
            lblP = new Label();
            txtParamP = new TextBox();
            btnSuggestP = new Button();
            lblQ = new Label();
            txtParamQ = new TextBox();
            btnSuggestQ = new Button();
            tlpRightGroup = new TableLayoutPanel();
            lblE = new Label();
            txtParamE = new TextBox();
            btnConfirmKey = new Button();
            chkManualKey = new CheckBox();
            pnlDivider = new Panel();
            pnlAutoConfig = new Panel();
            lblKeyLength = new Label();
            cbKeyLength = new ComboBox();
            btnAutoKey = new Button();
            gbKeyManagement = new GroupBox();
            tlpKeys = new TableLayoutPanel();
            pnlPublicKey = new Panel();
            rtbPublicKey = new RichTextBox();
            pnlPubKeyButtons = new Panel();
            btnImportPublicKey = new Button();
            btnExportPublicKey = new Button();
            lblPublicKey = new Label();
            pnlPrivateKey = new Panel();
            rtbPrivateKey = new RichTextBox();
            pnlPrivKeyButtons = new Panel();
            btnImportPrivateKey = new Button();
            btnExportPrivateKey = new Button();
            lblPrivateKey = new Label();
            tabControlProcess = new TabControl();
            tabText = new TabPage();
            tlpTextProcess = new TableLayoutPanel();
            pnlOriginalText = new Panel();
            txtInputText = new RichTextBox();
            btnSignText = new Button();
            lblOriginalText = new Label();
            pnlSignatureText = new Panel();
            rtbSignatureText = new RichTextBox();
            pnlTextSigButtons = new Panel();
            btnVerifyTextSignature = new Button();
            btnImportSignature = new Button();
            btnExportSignature = new Button();
            lblSignatureText = new Label();
            tabFile = new TabPage();
            pnlFileLayout = new Panel();
            pnlFileContent = new TableLayoutPanel();
            pnlFileLeft = new Panel();
            lblFileInfo = new Label();
            btnSignFile = new Button();
            pnlFileRight = new Panel();
            rtbFileSignature = new RichTextBox();
            pnlFileSigButtons = new Panel();
            btnVerifyFileSignature = new Button();
            btnImportFileSignature = new Button();
            btnExportFileSignature = new Button();
            lblFileSignature = new Label();
            pnlFileTop = new Panel();
            tlpFilePath = new TableLayoutPanel();
            lblFilePath = new Label();
            txtFilePath = new TextBox();
            btnChooseFile = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStatusIcon).BeginInit();
            tlpMainLayout.SuspendLayout();
            gbConfig.SuspendLayout();
            pnlConfigInner.SuspendLayout();
            pnlManualParams.SuspendLayout();
            tlpManualFields.SuspendLayout();
            tlpRightGroup.SuspendLayout();
            pnlAutoConfig.SuspendLayout();
            gbKeyManagement.SuspendLayout();
            tlpKeys.SuspendLayout();
            pnlPublicKey.SuspendLayout();
            pnlPubKeyButtons.SuspendLayout();
            pnlPrivateKey.SuspendLayout();
            pnlPrivKeyButtons.SuspendLayout();
            tabControlProcess.SuspendLayout();
            tabText.SuspendLayout();
            tlpTextProcess.SuspendLayout();
            pnlOriginalText.SuspendLayout();
            pnlSignatureText.SuspendLayout();
            pnlTextSigButtons.SuspendLayout();
            tabFile.SuspendLayout();
            pnlFileLayout.SuspendLayout();
            pnlFileContent.SuspendLayout();
            pnlFileLeft.SuspendLayout();
            pnlFileRight.SuspendLayout();
            pnlFileSigButtons.SuspendLayout();
            pnlFileTop.SuspendLayout();
            tlpFilePath.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(18, 24, 32);
            pnlHeader.Controls.Add(lblAppTitle);
            pnlHeader.Controls.Add(lblAppSubtitle);
            pnlHeader.Controls.Add(pnlHeaderAccent);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(18, 0, 18, 0);
            pnlHeader.Size = new Size(1152, 96);
            pnlHeader.TabIndex = 1;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Consolas", 15F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.FromArgb(0, 212, 170);
            lblAppTitle.Location = new Point(18, 16);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(405, 29);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "RSA DIGITAL SIGNATURE SYSTEM";
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.Font = new Font("Segoe UI", 9F);
            lblAppSubtitle.ForeColor = Color.FromArgb(139, 155, 175);
            lblAppSubtitle.Location = new Point(21, 59);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(496, 20);
            lblAppSubtitle.TabIndex = 1;
            lblAppSubtitle.Text = "Hệ thống Quản lý và Xác thực Chữ ký Điện tử  ·  RSA / SHA-256  ·  .NET C#";
            // 
            // pnlHeaderAccent
            // 
            pnlHeaderAccent.BackColor = Color.FromArgb(0, 212, 170);
            pnlHeaderAccent.Dock = DockStyle.Bottom;
            pnlHeaderAccent.Location = new Point(18, 93);
            pnlHeaderAccent.Margin = new Padding(3, 4, 3, 4);
            pnlHeaderAccent.Name = "pnlHeaderAccent";
            pnlHeaderAccent.Size = new Size(1116, 3);
            pnlHeaderAccent.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 50);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlStatusBar
            // 
            pnlStatusBar.BackColor = Color.FromArgb(16, 22, 30);
            pnlStatusBar.Controls.Add(picStatusIcon);
            pnlStatusBar.Controls.Add(lblStatusMessage);
            pnlStatusBar.Dock = DockStyle.Bottom;
            pnlStatusBar.Location = new Point(0, 932);
            pnlStatusBar.Margin = new Padding(3, 4, 3, 4);
            pnlStatusBar.Name = "pnlStatusBar";
            pnlStatusBar.Size = new Size(1152, 40);
            pnlStatusBar.TabIndex = 2;
            // 
            // picStatusIcon
            // 
            picStatusIcon.BackColor = Color.FromArgb(80, 100, 120);
            picStatusIcon.Location = new Point(14, 13);
            picStatusIcon.Margin = new Padding(3, 4, 3, 4);
            picStatusIcon.Name = "picStatusIcon";
            picStatusIcon.Size = new Size(11, 13);
            picStatusIcon.TabIndex = 0;
            picStatusIcon.TabStop = false;
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.Font = new Font("Consolas", 9F);
            lblStatusMessage.ForeColor = Color.FromArgb(139, 155, 175);
            lblStatusMessage.Location = new Point(32, 8);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(448, 18);
            lblStatusMessage.TabIndex = 1;
            lblStatusMessage.Text = "  Sẵn sàng — Chọn cấu hình và sinh cặp khóa để bắt đầu.";
            // 
            // tlpMainLayout
            // 
            tlpMainLayout.BackColor = Color.FromArgb(13, 17, 23);
            tlpMainLayout.ColumnCount = 1;
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainLayout.Controls.Add(gbConfig, 0, 0);
            tlpMainLayout.Controls.Add(gbKeyManagement, 0, 1);
            tlpMainLayout.Controls.Add(tabControlProcess, 0, 2);
            tlpMainLayout.Dock = DockStyle.Fill;
            tlpMainLayout.Location = new Point(0, 96);
            tlpMainLayout.Margin = new Padding(3, 4, 3, 4);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.Padding = new Padding(11);
            tlpMainLayout.RowCount = 3;
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 247F));
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpMainLayout.Size = new Size(1152, 836);
            tlpMainLayout.TabIndex = 0;
            // 
            // gbConfig
            // 
            gbConfig.BackColor = Color.FromArgb(22, 30, 40);
            gbConfig.Controls.Add(pnlConfigInner);
            gbConfig.Dock = DockStyle.Fill;
            gbConfig.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbConfig.ForeColor = Color.FromArgb(0, 212, 170);
            gbConfig.Location = new Point(14, 15);
            gbConfig.Margin = new Padding(3, 4, 3, 4);
            gbConfig.Name = "gbConfig";
            gbConfig.Padding = new Padding(11, 5, 11, 8);
            gbConfig.Size = new Size(1124, 239);
            gbConfig.TabIndex = 0;
            gbConfig.TabStop = false;
            gbConfig.Text = "  ⚙  CẤU HÌNH THUẬT TOÁN RSA";
            // 
            // pnlConfigInner
            // 
            pnlConfigInner.BackColor = Color.Transparent;
            pnlConfigInner.Controls.Add(pnlManualParams);
            pnlConfigInner.Controls.Add(chkManualKey);
            pnlConfigInner.Controls.Add(pnlDivider);
            pnlConfigInner.Controls.Add(pnlAutoConfig);
            pnlConfigInner.Dock = DockStyle.Fill;
            pnlConfigInner.Location = new Point(11, 28);
            pnlConfigInner.Margin = new Padding(3, 4, 3, 4);
            pnlConfigInner.Name = "pnlConfigInner";
            pnlConfigInner.Size = new Size(1102, 203);
            pnlConfigInner.TabIndex = 0;
            // 
            // pnlManualParams
            // 
            pnlManualParams.BackColor = Color.FromArgb(18, 26, 36);
            pnlManualParams.Controls.Add(tlpManualFields);
            pnlManualParams.Dock = DockStyle.Top;
            pnlManualParams.Location = new Point(0, 100);
            pnlManualParams.Margin = new Padding(3, 4, 3, 4);
            pnlManualParams.Name = "pnlManualParams";
            pnlManualParams.Padding = new Padding(7, 5, 7, 5);
            pnlManualParams.Size = new Size(1102, 67);
            pnlManualParams.TabIndex = 0;
            // 
            // tlpManualFields
            // 
            tlpManualFields.BackColor = Color.Transparent;
            tlpManualFields.ColumnCount = 7;
            tlpManualFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpManualFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpManualFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tlpManualFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tlpManualFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpManualFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tlpManualFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpManualFields.Controls.Add(lblP, 0, 0);
            tlpManualFields.Controls.Add(txtParamP, 1, 0);
            tlpManualFields.Controls.Add(btnSuggestP, 2, 0);
            tlpManualFields.Controls.Add(lblQ, 3, 0);
            tlpManualFields.Controls.Add(txtParamQ, 4, 0);
            tlpManualFields.Controls.Add(btnSuggestQ, 5, 0);
            tlpManualFields.Controls.Add(tlpRightGroup, 6, 0);
            tlpManualFields.Dock = DockStyle.Fill;
            tlpManualFields.Location = new Point(7, 5);
            tlpManualFields.Margin = new Padding(3, 4, 3, 4);
            tlpManualFields.Name = "tlpManualFields";
            tlpManualFields.RowCount = 1;
            tlpManualFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpManualFields.Size = new Size(1088, 57);
            tlpManualFields.TabIndex = 0;
            // 
            // lblP
            // 
            lblP.Dock = DockStyle.Fill;
            lblP.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblP.ForeColor = Color.FromArgb(56, 139, 253);
            lblP.Location = new Point(3, 0);
            lblP.Name = "lblP";
            lblP.Size = new Size(34, 57);
            lblP.TabIndex = 0;
            lblP.Text = "p:";
            lblP.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtParamP
            // 
            txtParamP.BackColor = Color.FromArgb(28, 38, 52);
            txtParamP.BorderStyle = BorderStyle.FixedSingle;
            txtParamP.Dock = DockStyle.Fill;
            txtParamP.Font = new Font("Consolas", 9F);
            txtParamP.ForeColor = Color.FromArgb(230, 237, 243);
            txtParamP.Location = new Point(42, 11);
            txtParamP.Margin = new Padding(2, 11, 2, 11);
            txtParamP.Name = "txtParamP";
            txtParamP.PlaceholderText = "Nhập số nguyên tố p...";
            txtParamP.Size = new Size(269, 25);
            txtParamP.TabIndex = 1;
            // 
            // btnSuggestP
            // 
            btnSuggestP.BackColor = Color.FromArgb(0, 180, 210);
            btnSuggestP.Cursor = Cursors.Hand;
            btnSuggestP.Dock = DockStyle.Fill;
            btnSuggestP.FlatAppearance.BorderSize = 0;
            btnSuggestP.FlatStyle = FlatStyle.Flat;
            btnSuggestP.Font = new Font("Segoe UI", 9F);
            btnSuggestP.ForeColor = Color.FromArgb(10, 20, 30);
            btnSuggestP.Location = new Point(315, 8);
            btnSuggestP.Margin = new Padding(2, 8, 2, 8);
            btnSuggestP.Name = "btnSuggestP";
            btnSuggestP.Size = new Size(82, 41);
            btnSuggestP.TabIndex = 2;
            btnSuggestP.Text = "🎲 Gợi ý";
            btnSuggestP.UseVisualStyleBackColor = false;
            // 
            // lblQ
            // 
            lblQ.Dock = DockStyle.Fill;
            lblQ.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblQ.ForeColor = Color.FromArgb(56, 139, 253);
            lblQ.Location = new Point(402, 0);
            lblQ.Name = "lblQ";
            lblQ.Size = new Size(40, 57);
            lblQ.TabIndex = 3;
            lblQ.Text = "q:";
            lblQ.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtParamQ
            // 
            txtParamQ.BackColor = Color.FromArgb(28, 38, 52);
            txtParamQ.BorderStyle = BorderStyle.FixedSingle;
            txtParamQ.Dock = DockStyle.Fill;
            txtParamQ.Font = new Font("Consolas", 9F);
            txtParamQ.ForeColor = Color.FromArgb(230, 237, 243);
            txtParamQ.Location = new Point(447, 11);
            txtParamQ.Margin = new Padding(2, 11, 2, 11);
            txtParamQ.Name = "txtParamQ";
            txtParamQ.PlaceholderText = "Nhập số nguyên tố q...";
            txtParamQ.Size = new Size(269, 25);
            txtParamQ.TabIndex = 4;
            // 
            // btnSuggestQ
            // 
            btnSuggestQ.BackColor = Color.FromArgb(0, 180, 210);
            btnSuggestQ.Cursor = Cursors.Hand;
            btnSuggestQ.Dock = DockStyle.Fill;
            btnSuggestQ.FlatAppearance.BorderSize = 0;
            btnSuggestQ.FlatStyle = FlatStyle.Flat;
            btnSuggestQ.Font = new Font("Segoe UI", 9F);
            btnSuggestQ.ForeColor = Color.FromArgb(10, 20, 30);
            btnSuggestQ.Location = new Point(720, 8);
            btnSuggestQ.Margin = new Padding(2, 8, 2, 8);
            btnSuggestQ.Name = "btnSuggestQ";
            btnSuggestQ.Size = new Size(82, 41);
            btnSuggestQ.TabIndex = 5;
            btnSuggestQ.Text = "🎲 Gợi ý";
            btnSuggestQ.UseVisualStyleBackColor = false;
            // 
            // tlpRightGroup
            // 
            tlpRightGroup.BackColor = Color.Transparent;
            tlpRightGroup.ColumnCount = 3;
            tlpRightGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpRightGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tlpRightGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRightGroup.Controls.Add(lblE, 0, 0);
            tlpRightGroup.Controls.Add(txtParamE, 1, 0);
            tlpRightGroup.Controls.Add(btnConfirmKey, 2, 0);
            tlpRightGroup.Dock = DockStyle.Fill;
            tlpRightGroup.Location = new Point(815, 0);
            tlpRightGroup.Margin = new Padding(11, 0, 0, 0);
            tlpRightGroup.Name = "tlpRightGroup";
            tlpRightGroup.RowCount = 1;
            tlpRightGroup.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRightGroup.Size = new Size(273, 57);
            tlpRightGroup.TabIndex = 6;
            // 
            // lblE
            // 
            lblE.Dock = DockStyle.Fill;
            lblE.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblE.ForeColor = Color.FromArgb(56, 139, 253);
            lblE.Location = new Point(3, 0);
            lblE.Name = "lblE";
            lblE.Size = new Size(34, 57);
            lblE.TabIndex = 0;
            lblE.Text = "e:";
            lblE.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtParamE
            // 
            txtParamE.BackColor = Color.FromArgb(28, 38, 52);
            txtParamE.BorderStyle = BorderStyle.FixedSingle;
            txtParamE.Dock = DockStyle.Fill;
            txtParamE.Font = new Font("Consolas", 9F);
            txtParamE.ForeColor = Color.FromArgb(230, 237, 243);
            txtParamE.Location = new Point(42, 11);
            txtParamE.Margin = new Padding(2, 11, 2, 11);
            txtParamE.Name = "txtParamE";
            txtParamE.Size = new Size(70, 25);
            txtParamE.TabIndex = 1;
            txtParamE.Text = "65537";
            // 
            // btnConfirmKey
            // 
            btnConfirmKey.BackColor = Color.FromArgb(255, 180, 0);
            btnConfirmKey.Cursor = Cursors.Hand;
            btnConfirmKey.Dock = DockStyle.Fill;
            btnConfirmKey.FlatAppearance.BorderSize = 0;
            btnConfirmKey.FlatStyle = FlatStyle.Flat;
            btnConfirmKey.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmKey.ForeColor = Color.FromArgb(13, 17, 23);
            btnConfirmKey.Location = new Point(121, 5);
            btnConfirmKey.Margin = new Padding(7, 5, 0, 5);
            btnConfirmKey.Name = "btnConfirmKey";
            btnConfirmKey.Size = new Size(152, 47);
            btnConfirmKey.TabIndex = 2;
            btnConfirmKey.Text = "✔  Xác Nhận Cấu Hình";
            btnConfirmKey.UseVisualStyleBackColor = false;
            // 
            // chkManualKey
            // 
            chkManualKey.BackColor = Color.Transparent;
            chkManualKey.Cursor = Cursors.Hand;
            chkManualKey.Dock = DockStyle.Top;
            chkManualKey.Font = new Font("Segoe UI", 9F);
            chkManualKey.ForeColor = Color.FromArgb(255, 180, 0);
            chkManualKey.Location = new Point(0, 57);
            chkManualKey.Margin = new Padding(3, 4, 3, 4);
            chkManualKey.Name = "chkManualKey";
            chkManualKey.Size = new Size(1102, 43);
            chkManualKey.TabIndex = 1;
            chkManualKey.Text = "   🔑  Kích hoạt sinh khóa thủ công (Nhập p, q, e)";
            chkManualKey.UseVisualStyleBackColor = false;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(48, 60, 76);
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(0, 56);
            pnlDivider.Margin = new Padding(3, 4, 3, 4);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(1102, 1);
            pnlDivider.TabIndex = 2;
            // 
            // pnlAutoConfig
            // 
            pnlAutoConfig.BackColor = Color.Transparent;
            pnlAutoConfig.Controls.Add(lblKeyLength);
            pnlAutoConfig.Controls.Add(cbKeyLength);
            pnlAutoConfig.Controls.Add(btnAutoKey);
            pnlAutoConfig.Dock = DockStyle.Top;
            pnlAutoConfig.Location = new Point(0, 0);
            pnlAutoConfig.Margin = new Padding(3, 4, 3, 4);
            pnlAutoConfig.Name = "pnlAutoConfig";
            pnlAutoConfig.Size = new Size(1102, 56);
            pnlAutoConfig.TabIndex = 3;
            // 
            // lblKeyLength
            // 
            lblKeyLength.AutoSize = true;
            lblKeyLength.Font = new Font("Segoe UI", 9F);
            lblKeyLength.ForeColor = Color.FromArgb(139, 155, 175);
            lblKeyLength.Location = new Point(0, 19);
            lblKeyLength.Name = "lblKeyLength";
            lblKeyLength.Size = new Size(93, 20);
            lblKeyLength.TabIndex = 0;
            lblKeyLength.Text = "Độ dài khóa:";
            // 
            // cbKeyLength
            // 
            cbKeyLength.BackColor = Color.FromArgb(28, 38, 52);
            cbKeyLength.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKeyLength.FlatStyle = FlatStyle.Flat;
            cbKeyLength.Font = new Font("Consolas", 9F);
            cbKeyLength.ForeColor = Color.FromArgb(230, 237, 243);
            cbKeyLength.Location = new Point(120, 13);
            cbKeyLength.Margin = new Padding(3, 4, 3, 4);
            cbKeyLength.Name = "cbKeyLength";
            cbKeyLength.Size = new Size(125, 26);
            cbKeyLength.TabIndex = 1;
            // 
            // btnAutoKey
            // 
            btnAutoKey.BackColor = Color.FromArgb(0, 212, 170);
            btnAutoKey.Cursor = Cursors.Hand;
            btnAutoKey.FlatAppearance.BorderSize = 0;
            btnAutoKey.FlatStyle = FlatStyle.Flat;
            btnAutoKey.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAutoKey.ForeColor = Color.FromArgb(13, 17, 23);
            btnAutoKey.Location = new Point(263, 8);
            btnAutoKey.Margin = new Padding(3, 4, 3, 4);
            btnAutoKey.Name = "btnAutoKey";
            btnAutoKey.Size = new Size(217, 43);
            btnAutoKey.TabIndex = 2;
            btnAutoKey.Text = "⚡  Sinh Khóa Tự Động";
            btnAutoKey.UseVisualStyleBackColor = false;
            // 
            // gbKeyManagement
            // 
            gbKeyManagement.BackColor = Color.FromArgb(22, 30, 40);
            gbKeyManagement.Controls.Add(tlpKeys);
            gbKeyManagement.Dock = DockStyle.Fill;
            gbKeyManagement.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbKeyManagement.ForeColor = Color.FromArgb(56, 139, 253);
            gbKeyManagement.Location = new Point(14, 262);
            gbKeyManagement.Margin = new Padding(3, 4, 3, 4);
            gbKeyManagement.Name = "gbKeyManagement";
            gbKeyManagement.Padding = new Padding(9, 5, 9, 8);
            gbKeyManagement.Size = new Size(1124, 218);
            gbKeyManagement.TabIndex = 1;
            gbKeyManagement.TabStop = false;
            gbKeyManagement.Text = "  🗝  QUẢN LÝ CẶP KHÓA  (XML Format)";
            // 
            // tlpKeys
            // 
            tlpKeys.BackColor = Color.Transparent;
            tlpKeys.ColumnCount = 2;
            tlpKeys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKeys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKeys.Controls.Add(pnlPublicKey, 0, 0);
            tlpKeys.Controls.Add(pnlPrivateKey, 1, 0);
            tlpKeys.Dock = DockStyle.Fill;
            tlpKeys.Location = new Point(9, 28);
            tlpKeys.Margin = new Padding(3, 4, 3, 4);
            tlpKeys.Name = "tlpKeys";
            tlpKeys.RowCount = 1;
            tlpKeys.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKeys.Size = new Size(1106, 182);
            tlpKeys.TabIndex = 0;
            // 
            // pnlPublicKey
            // 
            pnlPublicKey.BackColor = Color.FromArgb(13, 22, 32);
            pnlPublicKey.Controls.Add(rtbPublicKey);
            pnlPublicKey.Controls.Add(pnlPubKeyButtons);
            pnlPublicKey.Controls.Add(lblPublicKey);
            pnlPublicKey.Dock = DockStyle.Fill;
            pnlPublicKey.Location = new Point(0, 3);
            pnlPublicKey.Margin = new Padding(0, 3, 5, 3);
            pnlPublicKey.Name = "pnlPublicKey";
            pnlPublicKey.Padding = new Padding(9, 8, 9, 8);
            pnlPublicKey.Size = new Size(548, 176);
            pnlPublicKey.TabIndex = 0;
            // 
            // rtbPublicKey
            // 
            rtbPublicKey.BackColor = Color.FromArgb(10, 18, 26);
            rtbPublicKey.BorderStyle = BorderStyle.FixedSingle;
            rtbPublicKey.Dock = DockStyle.Fill;
            rtbPublicKey.Font = new Font("Consolas", 8F);
            rtbPublicKey.ForeColor = Color.FromArgb(100, 200, 255);
            rtbPublicKey.Location = new Point(9, 37);
            rtbPublicKey.Margin = new Padding(3, 4, 3, 4);
            rtbPublicKey.Name = "rtbPublicKey";
            rtbPublicKey.Size = new Size(530, 83);
            rtbPublicKey.TabIndex = 0;
            rtbPublicKey.Text = "";
            // 
            // pnlPubKeyButtons
            // 
            pnlPubKeyButtons.BackColor = Color.Transparent;
            pnlPubKeyButtons.Controls.Add(btnImportPublicKey);
            pnlPubKeyButtons.Controls.Add(btnExportPublicKey);
            pnlPubKeyButtons.Dock = DockStyle.Bottom;
            pnlPubKeyButtons.Location = new Point(9, 120);
            pnlPubKeyButtons.Margin = new Padding(3, 4, 3, 4);
            pnlPubKeyButtons.Name = "pnlPubKeyButtons";
            pnlPubKeyButtons.Size = new Size(530, 48);
            pnlPubKeyButtons.TabIndex = 1;
            // 
            // btnImportPublicKey
            // 
            btnImportPublicKey.BackColor = Color.FromArgb(28, 38, 52);
            btnImportPublicKey.Cursor = Cursors.Hand;
            btnImportPublicKey.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnImportPublicKey.FlatStyle = FlatStyle.Flat;
            btnImportPublicKey.Font = new Font("Segoe UI", 9F);
            btnImportPublicKey.ForeColor = Color.FromArgb(230, 237, 243);
            btnImportPublicKey.Location = new Point(0, 7);
            btnImportPublicKey.Margin = new Padding(3, 4, 3, 4);
            btnImportPublicKey.Name = "btnImportPublicKey";
            btnImportPublicKey.Size = new Size(137, 37);
            btnImportPublicKey.TabIndex = 0;
            btnImportPublicKey.Text = "⬆  Import Key";
            btnImportPublicKey.UseVisualStyleBackColor = false;
            // 
            // btnExportPublicKey
            // 
            btnExportPublicKey.BackColor = Color.FromArgb(28, 38, 52);
            btnExportPublicKey.Cursor = Cursors.Hand;
            btnExportPublicKey.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnExportPublicKey.FlatStyle = FlatStyle.Flat;
            btnExportPublicKey.Font = new Font("Segoe UI", 9F);
            btnExportPublicKey.ForeColor = Color.FromArgb(230, 237, 243);
            btnExportPublicKey.Location = new Point(144, 7);
            btnExportPublicKey.Margin = new Padding(3, 4, 3, 4);
            btnExportPublicKey.Name = "btnExportPublicKey";
            btnExportPublicKey.Size = new Size(137, 37);
            btnExportPublicKey.TabIndex = 1;
            btnExportPublicKey.Text = "⬇  Export Key";
            btnExportPublicKey.UseVisualStyleBackColor = false;
            // 
            // lblPublicKey
            // 
            lblPublicKey.Dock = DockStyle.Top;
            lblPublicKey.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblPublicKey.ForeColor = Color.FromArgb(56, 139, 253);
            lblPublicKey.Location = new Point(9, 8);
            lblPublicKey.Name = "lblPublicKey";
            lblPublicKey.Size = new Size(530, 29);
            lblPublicKey.TabIndex = 2;
            lblPublicKey.Text = "[ PUBLIC KEY ]  —  Khóa công khai (dùng để xác minh)";
            lblPublicKey.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPrivateKey
            // 
            pnlPrivateKey.BackColor = Color.FromArgb(22, 13, 18);
            pnlPrivateKey.Controls.Add(rtbPrivateKey);
            pnlPrivateKey.Controls.Add(pnlPrivKeyButtons);
            pnlPrivateKey.Controls.Add(lblPrivateKey);
            pnlPrivateKey.Dock = DockStyle.Fill;
            pnlPrivateKey.Location = new Point(558, 3);
            pnlPrivateKey.Margin = new Padding(5, 3, 0, 3);
            pnlPrivateKey.Name = "pnlPrivateKey";
            pnlPrivateKey.Padding = new Padding(9, 8, 9, 8);
            pnlPrivateKey.Size = new Size(548, 176);
            pnlPrivateKey.TabIndex = 1;
            // 
            // rtbPrivateKey
            // 
            rtbPrivateKey.BackColor = Color.FromArgb(20, 10, 14);
            rtbPrivateKey.BorderStyle = BorderStyle.FixedSingle;
            rtbPrivateKey.Dock = DockStyle.Fill;
            rtbPrivateKey.Font = new Font("Consolas", 8F);
            rtbPrivateKey.ForeColor = Color.FromArgb(255, 130, 130);
            rtbPrivateKey.Location = new Point(9, 37);
            rtbPrivateKey.Margin = new Padding(3, 4, 3, 4);
            rtbPrivateKey.Name = "rtbPrivateKey";
            rtbPrivateKey.Size = new Size(530, 83);
            rtbPrivateKey.TabIndex = 0;
            rtbPrivateKey.Text = "";
            // 
            // pnlPrivKeyButtons
            // 
            pnlPrivKeyButtons.BackColor = Color.Transparent;
            pnlPrivKeyButtons.Controls.Add(btnImportPrivateKey);
            pnlPrivKeyButtons.Controls.Add(btnExportPrivateKey);
            pnlPrivKeyButtons.Dock = DockStyle.Bottom;
            pnlPrivKeyButtons.Location = new Point(9, 120);
            pnlPrivKeyButtons.Margin = new Padding(3, 4, 3, 4);
            pnlPrivKeyButtons.Name = "pnlPrivKeyButtons";
            pnlPrivKeyButtons.Size = new Size(530, 48);
            pnlPrivKeyButtons.TabIndex = 1;
            // 
            // btnImportPrivateKey
            // 
            btnImportPrivateKey.BackColor = Color.FromArgb(28, 38, 52);
            btnImportPrivateKey.Cursor = Cursors.Hand;
            btnImportPrivateKey.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnImportPrivateKey.FlatStyle = FlatStyle.Flat;
            btnImportPrivateKey.Font = new Font("Segoe UI", 9F);
            btnImportPrivateKey.ForeColor = Color.FromArgb(230, 237, 243);
            btnImportPrivateKey.Location = new Point(0, 7);
            btnImportPrivateKey.Margin = new Padding(3, 4, 3, 4);
            btnImportPrivateKey.Name = "btnImportPrivateKey";
            btnImportPrivateKey.Size = new Size(137, 37);
            btnImportPrivateKey.TabIndex = 0;
            btnImportPrivateKey.Text = "⬆  Import Key";
            btnImportPrivateKey.UseVisualStyleBackColor = false;
            // 
            // btnExportPrivateKey
            // 
            btnExportPrivateKey.BackColor = Color.FromArgb(28, 38, 52);
            btnExportPrivateKey.Cursor = Cursors.Hand;
            btnExportPrivateKey.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnExportPrivateKey.FlatStyle = FlatStyle.Flat;
            btnExportPrivateKey.Font = new Font("Segoe UI", 9F);
            btnExportPrivateKey.ForeColor = Color.FromArgb(230, 237, 243);
            btnExportPrivateKey.Location = new Point(144, 7);
            btnExportPrivateKey.Margin = new Padding(3, 4, 3, 4);
            btnExportPrivateKey.Name = "btnExportPrivateKey";
            btnExportPrivateKey.Size = new Size(137, 37);
            btnExportPrivateKey.TabIndex = 1;
            btnExportPrivateKey.Text = "⬇  Export Key";
            btnExportPrivateKey.UseVisualStyleBackColor = false;
            // 
            // lblPrivateKey
            // 
            lblPrivateKey.Dock = DockStyle.Top;
            lblPrivateKey.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblPrivateKey.ForeColor = Color.FromArgb(255, 85, 85);
            lblPrivateKey.Location = new Point(9, 8);
            lblPrivateKey.Name = "lblPrivateKey";
            lblPrivateKey.Size = new Size(530, 29);
            lblPrivateKey.TabIndex = 2;
            lblPrivateKey.Text = "[ PRIVATE KEY ]  —  Khóa bí mật (dùng để ký, giữ kín tuyệt đối)";
            lblPrivateKey.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabControlProcess
            // 
            tabControlProcess.Controls.Add(tabText);
            tabControlProcess.Controls.Add(tabFile);
            tabControlProcess.Dock = DockStyle.Fill;
            tabControlProcess.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControlProcess.Location = new Point(14, 488);
            tabControlProcess.Margin = new Padding(3, 4, 3, 4);
            tabControlProcess.Name = "tabControlProcess";
            tabControlProcess.SelectedIndex = 0;
            tabControlProcess.Size = new Size(1124, 333);
            tabControlProcess.TabIndex = 2;
            // 
            // tabText
            // 
            tabText.BackColor = Color.FromArgb(22, 30, 40);
            tabText.Controls.Add(tlpTextProcess);
            tabText.Location = new Point(4, 32);
            tabText.Margin = new Padding(3, 4, 3, 4);
            tabText.Name = "tabText";
            tabText.Size = new Size(1116, 297);
            tabText.TabIndex = 0;
            tabText.Text = "  ✍  Xử lý Văn bản (Text)  ";
            // 
            // tlpTextProcess
            // 
            tlpTextProcess.ColumnCount = 2;
            tlpTextProcess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTextProcess.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTextProcess.Controls.Add(pnlOriginalText, 0, 0);
            tlpTextProcess.Controls.Add(pnlSignatureText, 1, 0);
            tlpTextProcess.Dock = DockStyle.Fill;
            tlpTextProcess.Location = new Point(0, 0);
            tlpTextProcess.Margin = new Padding(3, 4, 3, 4);
            tlpTextProcess.Name = "tlpTextProcess";
            tlpTextProcess.Padding = new Padding(7, 8, 7, 8);
            tlpTextProcess.RowCount = 1;
            tlpTextProcess.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTextProcess.Size = new Size(1116, 297);
            tlpTextProcess.TabIndex = 0;
            // 
            // pnlOriginalText
            // 
            pnlOriginalText.BackColor = Color.FromArgb(13, 20, 28);
            pnlOriginalText.Controls.Add(txtInputText);
            pnlOriginalText.Controls.Add(btnSignText);
            pnlOriginalText.Controls.Add(lblOriginalText);
            pnlOriginalText.Dock = DockStyle.Fill;
            pnlOriginalText.Location = new Point(7, 8);
            pnlOriginalText.Margin = new Padding(0, 0, 5, 0);
            pnlOriginalText.Name = "pnlOriginalText";
            pnlOriginalText.Padding = new Padding(9, 8, 9, 8);
            pnlOriginalText.Size = new Size(546, 281);
            pnlOriginalText.TabIndex = 0;
            // 
            // txtInputText
            // 
            txtInputText.BackColor = Color.FromArgb(10, 16, 22);
            txtInputText.BorderStyle = BorderStyle.FixedSingle;
            txtInputText.Dock = DockStyle.Fill;
            txtInputText.Font = new Font("Consolas", 9F);
            txtInputText.ForeColor = Color.FromArgb(230, 237, 243);
            txtInputText.Location = new Point(9, 37);
            txtInputText.Margin = new Padding(3, 4, 3, 4);
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(528, 188);
            txtInputText.TabIndex = 0;
            txtInputText.Text = "";
            // 
            // btnSignText
            // 
            btnSignText.BackColor = Color.FromArgb(200, 50, 80);
            btnSignText.Cursor = Cursors.Hand;
            btnSignText.Dock = DockStyle.Bottom;
            btnSignText.FlatAppearance.BorderSize = 0;
            btnSignText.FlatStyle = FlatStyle.Flat;
            btnSignText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignText.ForeColor = Color.White;
            btnSignText.Location = new Point(9, 225);
            btnSignText.Margin = new Padding(3, 4, 3, 4);
            btnSignText.Name = "btnSignText";
            btnSignText.Size = new Size(528, 48);
            btnSignText.TabIndex = 1;
            btnSignText.Text = "✍  Ký Văn Bản";
            btnSignText.UseVisualStyleBackColor = false;
            // 
            // lblOriginalText
            // 
            lblOriginalText.Dock = DockStyle.Top;
            lblOriginalText.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblOriginalText.ForeColor = Color.FromArgb(139, 155, 175);
            lblOriginalText.Location = new Point(9, 8);
            lblOriginalText.Name = "lblOriginalText";
            lblOriginalText.Size = new Size(528, 29);
            lblOriginalText.TabIndex = 2;
            lblOriginalText.Text = "[ INPUT ]  —  Nội dung văn bản gốc cần ký / xác minh";
            // 
            // pnlSignatureText
            // 
            pnlSignatureText.BackColor = Color.FromArgb(13, 22, 14);
            pnlSignatureText.Controls.Add(rtbSignatureText);
            pnlSignatureText.Controls.Add(pnlTextSigButtons);
            pnlSignatureText.Controls.Add(lblSignatureText);
            pnlSignatureText.Dock = DockStyle.Fill;
            pnlSignatureText.Location = new Point(563, 8);
            pnlSignatureText.Margin = new Padding(5, 0, 0, 0);
            pnlSignatureText.Name = "pnlSignatureText";
            pnlSignatureText.Padding = new Padding(9, 8, 9, 8);
            pnlSignatureText.Size = new Size(546, 281);
            pnlSignatureText.TabIndex = 1;
            // 
            // rtbSignatureText
            // 
            rtbSignatureText.BackColor = Color.FromArgb(8, 18, 10);
            rtbSignatureText.BorderStyle = BorderStyle.FixedSingle;
            rtbSignatureText.Dock = DockStyle.Fill;
            rtbSignatureText.Font = new Font("Consolas", 9F);
            rtbSignatureText.ForeColor = Color.FromArgb(80, 220, 120);
            rtbSignatureText.Location = new Point(9, 37);
            rtbSignatureText.Margin = new Padding(3, 4, 3, 4);
            rtbSignatureText.Name = "rtbSignatureText";
            rtbSignatureText.Size = new Size(528, 185);
            rtbSignatureText.TabIndex = 0;
            rtbSignatureText.Text = "";
            // 
            // pnlTextSigButtons
            // 
            pnlTextSigButtons.BackColor = Color.Transparent;
            pnlTextSigButtons.Controls.Add(btnVerifyTextSignature);
            pnlTextSigButtons.Controls.Add(btnImportSignature);
            pnlTextSigButtons.Controls.Add(btnExportSignature);
            pnlTextSigButtons.Dock = DockStyle.Bottom;
            pnlTextSigButtons.Location = new Point(9, 222);
            pnlTextSigButtons.Margin = new Padding(3, 4, 3, 4);
            pnlTextSigButtons.Name = "pnlTextSigButtons";
            pnlTextSigButtons.Size = new Size(528, 51);
            pnlTextSigButtons.TabIndex = 1;
            // 
            // btnVerifyTextSignature
            // 
            btnVerifyTextSignature.BackColor = Color.FromArgb(0, 212, 170);
            btnVerifyTextSignature.Cursor = Cursors.Hand;
            btnVerifyTextSignature.FlatStyle = FlatStyle.Flat;
            btnVerifyTextSignature.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerifyTextSignature.ForeColor = Color.FromArgb(10, 20, 15);
            btnVerifyTextSignature.Location = new Point(0, 5);
            btnVerifyTextSignature.Margin = new Padding(3, 4, 3, 4);
            btnVerifyTextSignature.Name = "btnVerifyTextSignature";
            btnVerifyTextSignature.Size = new Size(206, 43);
            btnVerifyTextSignature.TabIndex = 0;
            btnVerifyTextSignature.Text = "✔  Kiểm Tra Chữ Ký";
            btnVerifyTextSignature.UseVisualStyleBackColor = false;
            // 
            // btnImportSignature
            // 
            btnImportSignature.BackColor = Color.FromArgb(28, 38, 52);
            btnImportSignature.Cursor = Cursors.Hand;
            btnImportSignature.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnImportSignature.FlatStyle = FlatStyle.Flat;
            btnImportSignature.Font = new Font("Segoe UI", 9F);
            btnImportSignature.ForeColor = Color.FromArgb(230, 237, 243);
            btnImportSignature.Location = new Point(217, 7);
            btnImportSignature.Margin = new Padding(3, 4, 3, 4);
            btnImportSignature.Name = "btnImportSignature";
            btnImportSignature.Size = new Size(97, 37);
            btnImportSignature.TabIndex = 1;
            btnImportSignature.Text = "⬆ Nhập";
            btnImportSignature.UseVisualStyleBackColor = false;
            // 
            // btnExportSignature
            // 
            btnExportSignature.BackColor = Color.FromArgb(28, 38, 52);
            btnExportSignature.Cursor = Cursors.Hand;
            btnExportSignature.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnExportSignature.FlatStyle = FlatStyle.Flat;
            btnExportSignature.Font = new Font("Segoe UI", 9F);
            btnExportSignature.ForeColor = Color.FromArgb(230, 237, 243);
            btnExportSignature.Location = new Point(320, 7);
            btnExportSignature.Margin = new Padding(3, 4, 3, 4);
            btnExportSignature.Name = "btnExportSignature";
            btnExportSignature.Size = new Size(97, 37);
            btnExportSignature.TabIndex = 2;
            btnExportSignature.Text = "⬇ Xuất";
            btnExportSignature.UseVisualStyleBackColor = false;
            // 
            // lblSignatureText
            // 
            lblSignatureText.Dock = DockStyle.Top;
            lblSignatureText.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblSignatureText.ForeColor = Color.FromArgb(0, 212, 170);
            lblSignatureText.Location = new Point(9, 8);
            lblSignatureText.Name = "lblSignatureText";
            lblSignatureText.Size = new Size(528, 29);
            lblSignatureText.TabIndex = 2;
            lblSignatureText.Text = "[ SIGNATURE ]  —  Mã chữ ký số (Base64 encoded)";
            // 
            // tabFile
            // 
            tabFile.BackColor = Color.FromArgb(22, 30, 40);
            tabFile.Controls.Add(pnlFileLayout);
            tabFile.Location = new Point(4, 32);
            tabFile.Margin = new Padding(3, 4, 3, 4);
            tabFile.Name = "tabFile";
            tabFile.Size = new Size(1116, 297);
            tabFile.TabIndex = 1;
            tabFile.Text = "  📑  Xử lý Tệp tin (File)  ";
            // 
            // pnlFileLayout
            // 
            pnlFileLayout.Controls.Add(pnlFileContent);
            pnlFileLayout.Controls.Add(pnlFileTop);
            pnlFileLayout.Dock = DockStyle.Fill;
            pnlFileLayout.Location = new Point(0, 0);
            pnlFileLayout.Margin = new Padding(3, 4, 3, 4);
            pnlFileLayout.Name = "pnlFileLayout";
            pnlFileLayout.Padding = new Padding(7, 8, 7, 8);
            pnlFileLayout.Size = new Size(1116, 297);
            pnlFileLayout.TabIndex = 0;
            // 
            // pnlFileContent
            // 
            pnlFileContent.ColumnCount = 2;
            pnlFileContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            pnlFileContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFileContent.Controls.Add(pnlFileLeft, 0, 0);
            pnlFileContent.Controls.Add(pnlFileRight, 1, 0);
            pnlFileContent.Dock = DockStyle.Fill;
            pnlFileContent.Location = new Point(7, 67);
            pnlFileContent.Margin = new Padding(0, 8, 0, 0);
            pnlFileContent.Name = "pnlFileContent";
            pnlFileContent.RowCount = 1;
            pnlFileContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlFileContent.Size = new Size(1102, 222);
            pnlFileContent.TabIndex = 0;
            // 
            // pnlFileLeft
            // 
            pnlFileLeft.BackColor = Color.FromArgb(16, 22, 30);
            pnlFileLeft.Controls.Add(lblFileInfo);
            pnlFileLeft.Controls.Add(btnSignFile);
            pnlFileLeft.Dock = DockStyle.Fill;
            pnlFileLeft.Location = new Point(3, 4);
            pnlFileLeft.Margin = new Padding(3, 4, 3, 4);
            pnlFileLeft.Name = "pnlFileLeft";
            pnlFileLeft.Padding = new Padding(9, 16, 9, 11);
            pnlFileLeft.Size = new Size(211, 214);
            pnlFileLeft.TabIndex = 0;
            // 
            // lblFileInfo
            // 
            lblFileInfo.Dock = DockStyle.Top;
            lblFileInfo.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblFileInfo.ForeColor = Color.FromArgb(80, 100, 120);
            lblFileInfo.Location = new Point(9, 16);
            lblFileInfo.Name = "lblFileInfo";
            lblFileInfo.Size = new Size(193, 29);
            lblFileInfo.TabIndex = 0;
            lblFileInfo.Text = "THAO TÁC KÝ FILE";
            // 
            // btnSignFile
            // 
            btnSignFile.BackColor = Color.FromArgb(200, 50, 80);
            btnSignFile.Cursor = Cursors.Hand;
            btnSignFile.FlatStyle = FlatStyle.Flat;
            btnSignFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignFile.ForeColor = Color.White;
            btnSignFile.Location = new Point(9, 48);
            btnSignFile.Margin = new Padding(3, 4, 3, 4);
            btnSignFile.Name = "btnSignFile";
            btnSignFile.Size = new Size(199, 51);
            btnSignFile.TabIndex = 1;
            btnSignFile.Text = "📑  Ký File Dữ Liệu";
            btnSignFile.UseVisualStyleBackColor = false;
            // 
            // pnlFileRight
            // 
            pnlFileRight.BackColor = Color.FromArgb(13, 22, 14);
            pnlFileRight.Controls.Add(rtbFileSignature);
            pnlFileRight.Controls.Add(pnlFileSigButtons);
            pnlFileRight.Controls.Add(lblFileSignature);
            pnlFileRight.Dock = DockStyle.Fill;
            pnlFileRight.Location = new Point(224, 0);
            pnlFileRight.Margin = new Padding(7, 0, 0, 0);
            pnlFileRight.Name = "pnlFileRight";
            pnlFileRight.Padding = new Padding(9, 8, 9, 8);
            pnlFileRight.Size = new Size(878, 222);
            pnlFileRight.TabIndex = 1;
            // 
            // rtbFileSignature
            // 
            rtbFileSignature.BackColor = Color.FromArgb(8, 18, 10);
            rtbFileSignature.BorderStyle = BorderStyle.FixedSingle;
            rtbFileSignature.Dock = DockStyle.Fill;
            rtbFileSignature.Font = new Font("Consolas", 9F);
            rtbFileSignature.ForeColor = Color.FromArgb(80, 220, 120);
            rtbFileSignature.Location = new Point(9, 37);
            rtbFileSignature.Margin = new Padding(3, 4, 3, 4);
            rtbFileSignature.Name = "rtbFileSignature";
            rtbFileSignature.Size = new Size(860, 126);
            rtbFileSignature.TabIndex = 0;
            rtbFileSignature.Text = "";
            // 
            // pnlFileSigButtons
            // 
            pnlFileSigButtons.BackColor = Color.Transparent;
            pnlFileSigButtons.Controls.Add(btnVerifyFileSignature);
            pnlFileSigButtons.Controls.Add(btnImportFileSignature);
            pnlFileSigButtons.Controls.Add(btnExportFileSignature);
            pnlFileSigButtons.Dock = DockStyle.Bottom;
            pnlFileSigButtons.Location = new Point(9, 163);
            pnlFileSigButtons.Margin = new Padding(3, 4, 3, 4);
            pnlFileSigButtons.Name = "pnlFileSigButtons";
            pnlFileSigButtons.Size = new Size(860, 51);
            pnlFileSigButtons.TabIndex = 1;
            // 
            // btnVerifyFileSignature
            // 
            btnVerifyFileSignature.BackColor = Color.FromArgb(0, 212, 170);
            btnVerifyFileSignature.Cursor = Cursors.Hand;
            btnVerifyFileSignature.FlatStyle = FlatStyle.Flat;
            btnVerifyFileSignature.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerifyFileSignature.ForeColor = Color.FromArgb(10, 20, 15);
            btnVerifyFileSignature.Location = new Point(0, 5);
            btnVerifyFileSignature.Margin = new Padding(3, 4, 3, 4);
            btnVerifyFileSignature.Name = "btnVerifyFileSignature";
            btnVerifyFileSignature.Size = new Size(206, 43);
            btnVerifyFileSignature.TabIndex = 0;
            btnVerifyFileSignature.Text = "✔  Kiểm Tra Chữ Ký";
            btnVerifyFileSignature.UseVisualStyleBackColor = false;
            // 
            // btnImportFileSignature
            // 
            btnImportFileSignature.BackColor = Color.FromArgb(28, 38, 52);
            btnImportFileSignature.Cursor = Cursors.Hand;
            btnImportFileSignature.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnImportFileSignature.FlatStyle = FlatStyle.Flat;
            btnImportFileSignature.Font = new Font("Segoe UI", 9F);
            btnImportFileSignature.ForeColor = Color.FromArgb(230, 237, 243);
            btnImportFileSignature.Location = new Point(217, 7);
            btnImportFileSignature.Margin = new Padding(3, 4, 3, 4);
            btnImportFileSignature.Name = "btnImportFileSignature";
            btnImportFileSignature.Size = new Size(97, 37);
            btnImportFileSignature.TabIndex = 1;
            btnImportFileSignature.Text = "⬆ Nhập";
            btnImportFileSignature.UseVisualStyleBackColor = false;
            // 
            // btnExportFileSignature
            // 
            btnExportFileSignature.BackColor = Color.FromArgb(28, 38, 52);
            btnExportFileSignature.Cursor = Cursors.Hand;
            btnExportFileSignature.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnExportFileSignature.FlatStyle = FlatStyle.Flat;
            btnExportFileSignature.Font = new Font("Segoe UI", 9F);
            btnExportFileSignature.ForeColor = Color.FromArgb(230, 237, 243);
            btnExportFileSignature.Location = new Point(320, 7);
            btnExportFileSignature.Margin = new Padding(3, 4, 3, 4);
            btnExportFileSignature.Name = "btnExportFileSignature";
            btnExportFileSignature.Size = new Size(97, 37);
            btnExportFileSignature.TabIndex = 2;
            btnExportFileSignature.Text = "⬇ Xuất";
            btnExportFileSignature.UseVisualStyleBackColor = false;
            // 
            // lblFileSignature
            // 
            lblFileSignature.Dock = DockStyle.Top;
            lblFileSignature.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            lblFileSignature.ForeColor = Color.FromArgb(0, 212, 170);
            lblFileSignature.Location = new Point(9, 8);
            lblFileSignature.Name = "lblFileSignature";
            lblFileSignature.Size = new Size(860, 29);
            lblFileSignature.TabIndex = 2;
            lblFileSignature.Text = "[ FILE SIGNATURE ]  —  Chữ ký số của tệp tin (Base64 encoded)";
            // 
            // pnlFileTop
            // 
            pnlFileTop.BackColor = Color.FromArgb(18, 24, 32);
            pnlFileTop.Controls.Add(tlpFilePath);
            pnlFileTop.Dock = DockStyle.Top;
            pnlFileTop.Location = new Point(7, 8);
            pnlFileTop.Margin = new Padding(3, 4, 3, 4);
            pnlFileTop.Name = "pnlFileTop";
            pnlFileTop.Padding = new Padding(7, 8, 7, 8);
            pnlFileTop.Size = new Size(1102, 59);
            pnlFileTop.TabIndex = 1;
            // 
            // tlpFilePath
            // 
            tlpFilePath.ColumnCount = 3;
            tlpFilePath.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tlpFilePath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilePath.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tlpFilePath.Controls.Add(lblFilePath, 0, 0);
            tlpFilePath.Controls.Add(txtFilePath, 1, 0);
            tlpFilePath.Controls.Add(btnChooseFile, 2, 0);
            tlpFilePath.Dock = DockStyle.Fill;
            tlpFilePath.Location = new Point(7, 8);
            tlpFilePath.Margin = new Padding(3, 4, 3, 4);
            tlpFilePath.Name = "tlpFilePath";
            tlpFilePath.RowCount = 1;
            tlpFilePath.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilePath.Size = new Size(1088, 43);
            tlpFilePath.TabIndex = 0;
            // 
            // lblFilePath
            // 
            lblFilePath.Dock = DockStyle.Fill;
            lblFilePath.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblFilePath.ForeColor = Color.FromArgb(255, 180, 0);
            lblFilePath.Location = new Point(3, 0);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(57, 43);
            lblFilePath.TabIndex = 0;
            lblFilePath.Text = "FILE:";
            lblFilePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFilePath
            // 
            txtFilePath.BackColor = Color.FromArgb(10, 16, 22);
            txtFilePath.BorderStyle = BorderStyle.FixedSingle;
            txtFilePath.Dock = DockStyle.Fill;
            txtFilePath.Font = new Font("Consolas", 9F);
            txtFilePath.ForeColor = Color.FromArgb(230, 237, 243);
            txtFilePath.Location = new Point(63, 5);
            txtFilePath.Margin = new Padding(0, 5, 7, 5);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(892, 25);
            txtFilePath.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = Color.FromArgb(28, 38, 52);
            btnChooseFile.Cursor = Cursors.Hand;
            btnChooseFile.Dock = DockStyle.Fill;
            btnChooseFile.FlatAppearance.BorderColor = Color.FromArgb(48, 60, 76);
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Font = new Font("Segoe UI", 9F);
            btnChooseFile.ForeColor = Color.FromArgb(230, 237, 243);
            btnChooseFile.Location = new Point(965, 4);
            btnChooseFile.Margin = new Padding(3, 4, 3, 4);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(120, 35);
            btnChooseFile.TabIndex = 2;
            btnChooseFile.Text = "📂  Chọn File";
            btnChooseFile.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1152, 972);
            Controls.Add(tlpMainLayout);
            Controls.Add(pnlHeader);
            Controls.Add(pnlStatusBar);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1095, 838);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSA Digital Signature System";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlStatusBar.ResumeLayout(false);
            pnlStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStatusIcon).EndInit();
            tlpMainLayout.ResumeLayout(false);
            gbConfig.ResumeLayout(false);
            pnlConfigInner.ResumeLayout(false);
            pnlManualParams.ResumeLayout(false);
            tlpManualFields.ResumeLayout(false);
            tlpManualFields.PerformLayout();
            tlpRightGroup.ResumeLayout(false);
            tlpRightGroup.PerformLayout();
            pnlAutoConfig.ResumeLayout(false);
            pnlAutoConfig.PerformLayout();
            gbKeyManagement.ResumeLayout(false);
            tlpKeys.ResumeLayout(false);
            pnlPublicKey.ResumeLayout(false);
            pnlPubKeyButtons.ResumeLayout(false);
            pnlPrivateKey.ResumeLayout(false);
            pnlPrivKeyButtons.ResumeLayout(false);
            tabControlProcess.ResumeLayout(false);
            tabText.ResumeLayout(false);
            tlpTextProcess.ResumeLayout(false);
            pnlOriginalText.ResumeLayout(false);
            pnlSignatureText.ResumeLayout(false);
            pnlTextSigButtons.ResumeLayout(false);
            tabFile.ResumeLayout(false);
            pnlFileLayout.ResumeLayout(false);
            pnlFileContent.ResumeLayout(false);
            pnlFileLeft.ResumeLayout(false);
            pnlFileRight.ResumeLayout(false);
            pnlFileSigButtons.ResumeLayout(false);
            pnlFileTop.ResumeLayout(false);
            tlpFilePath.ResumeLayout(false);
            tlpFilePath.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Khai báo biến thành viên các Controls UI
        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblAppTitle;
        private Label lblAppSubtitle;
        private Panel pnlHeaderAccent;
        private Panel pnlStatusBar;
        private PictureBox picStatusIcon;
        private Label lblStatusMessage;
        private TableLayoutPanel tlpMainLayout;
        private GroupBox gbConfig;
        private Panel pnlConfigInner;
        private Panel pnlAutoConfig;
        private Label lblKeyLength;
        private ComboBox cbKeyLength;
        private Button btnAutoKey;
        private Panel pnlDivider;
        private CheckBox chkManualKey;
        private Panel pnlManualParams;
        private Label lblP;
        private TextBox txtParamP;
        private Button btnSuggestP;
        private Label lblQ;
        private TextBox txtParamQ;
        private Button btnSuggestQ;
        private Label lblE;
        private TextBox txtParamE;
        private Button btnConfirmKey;
        private GroupBox gbKeyManagement;
        private TableLayoutPanel tlpKeys;
        private Panel pnlPublicKey;
        private Label lblPublicKey;
        private RichTextBox rtbPublicKey;
        private Panel pnlPubKeyButtons;
        private Button btnImportPublicKey;
        private Button btnExportPublicKey;
        private Panel pnlPrivateKey;
        private Label lblPrivateKey;
        private RichTextBox rtbPrivateKey;
        private Panel pnlPrivKeyButtons;
        private Button btnImportPrivateKey;
        private Button btnExportPrivateKey;
        private TabControl tabControlProcess;
        private TabPage tabText;
        private TableLayoutPanel tlpTextProcess;
        private Panel pnlOriginalText;
        private Label lblOriginalText;
        private RichTextBox txtInputText;
        private Button btnSignText;
        private Panel pnlSignatureText;
        private Label lblSignatureText;
        private RichTextBox rtbSignatureText;
        private Panel pnlTextSigButtons;
        private Button btnVerifyTextSignature;
        private Button btnImportSignature;
        private Button btnExportSignature;
        private TabPage tabFile;
        private Panel pnlFileLayout;
        private Panel pnlFileTop;
        private Label lblFilePath;
        private TextBox txtFilePath;
        private Button btnChooseFile;
        private TableLayoutPanel pnlFileContent;
        private Panel pnlFileLeft;
        private Label lblFileInfo;
        private Button btnSignFile;
        private Panel pnlFileRight;
        private Label lblFileSignature;
        private RichTextBox rtbFileSignature;
        private Panel pnlFileSigButtons;
        private Button btnVerifyFileSignature;
        private Button btnImportFileSignature;
        private Button btnExportFileSignature;
        private TableLayoutPanel tlpManualFields;
        private TableLayoutPanel tlpRightGroup;
        private TableLayoutPanel tlpFilePath;
    }
}