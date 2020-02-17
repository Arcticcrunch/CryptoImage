namespace CryptoImage
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenImageButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripMainText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.EncryptTextButton = new System.Windows.Forms.Button();
            this.EncryptImageButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AvalableMemoryTitle = new System.Windows.Forms.Label();
            this.AvalableMemoryLabel = new System.Windows.Forms.Label();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearMainImageButton = new System.Windows.Forms.Button();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AvalableMemoryTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenImageButton
            // 
            this.OpenImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenImageButton.Location = new System.Drawing.Point(19, 19);
            this.OpenImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.OpenImageButton.Name = "OpenImageButton";
            this.OpenImageButton.Size = new System.Drawing.Size(170, 82);
            this.OpenImageButton.TabIndex = 0;
            this.OpenImageButton.Text = "Открыть .BMP";
            this.OpenImageButton.UseVisualStyleBackColor = true;
            this.OpenImageButton.Click += new System.EventHandler(this.OpenImageButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusProgressBar,
            this.StatusStripMainText});
            this.StatusStrip.Location = new System.Drawing.Point(0, 612);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1000, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "Status strip";
            // 
            // StatusStripMainText
            // 
            this.StatusStripMainText.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStripMainText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusStripMainText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusStripMainText.Name = "StatusStripMainText";
            this.StatusStripMainText.Size = new System.Drawing.Size(88, 17);
            this.StatusStripMainText.Text = "Status strip text";
            // 
            // ImagePreview
            // 
            this.ImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePreview.Location = new System.Drawing.Point(3, 3);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(494, 362);
            this.ImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreview.TabIndex = 2;
            this.ImagePreview.TabStop = false;
            // 
            // EncryptTextButton
            // 
            this.EncryptTextButton.Enabled = false;
            this.EncryptTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptTextButton.Location = new System.Drawing.Point(19, 137);
            this.EncryptTextButton.Margin = new System.Windows.Forms.Padding(10);
            this.EncryptTextButton.Name = "EncryptTextButton";
            this.EncryptTextButton.Size = new System.Drawing.Size(170, 60);
            this.EncryptTextButton.TabIndex = 3;
            this.EncryptTextButton.Text = "Зашифровать текст";
            this.EncryptTextButton.UseVisualStyleBackColor = true;
            // 
            // EncryptImageButton
            // 
            this.EncryptImageButton.Enabled = false;
            this.EncryptImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptImageButton.Location = new System.Drawing.Point(19, 208);
            this.EncryptImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.EncryptImageButton.Name = "EncryptImageButton";
            this.EncryptImageButton.Size = new System.Drawing.Size(170, 60);
            this.EncryptImageButton.TabIndex = 4;
            this.EncryptImageButton.Text = "Зашифровать изображение";
            this.EncryptImageButton.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AvalableMemoryTitle);
            this.MainPanel.Controls.Add(this.AvalableMemoryLabel);
            this.MainPanel.Controls.Add(this.OpenImageButton);
            this.MainPanel.Controls.Add(this.EncryptTextButton);
            this.MainPanel.Controls.Add(this.EncryptImageButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(212, 612);
            this.MainPanel.TabIndex = 6;
            // 
            // AvalableMemoryTitle
            // 
            this.AvalableMemoryTitle.AutoSize = true;
            this.AvalableMemoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvalableMemoryTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.AvalableMemoryTitle.Location = new System.Drawing.Point(16, 368);
            this.AvalableMemoryTitle.Name = "AvalableMemoryTitle";
            this.AvalableMemoryTitle.Size = new System.Drawing.Size(173, 40);
            this.AvalableMemoryTitle.TabIndex = 6;
            this.AvalableMemoryTitle.Text = "Доступная в \r\nизображении память:";
            this.AvalableMemoryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AvalableMemoryLabel
            // 
            this.AvalableMemoryLabel.AutoSize = true;
            this.AvalableMemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvalableMemoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AvalableMemoryLabel.Location = new System.Drawing.Point(44, 427);
            this.AvalableMemoryLabel.Name = "AvalableMemoryLabel";
            this.AvalableMemoryLabel.Size = new System.Drawing.Size(117, 24);
            this.AvalableMemoryLabel.TabIndex = 5;
            this.AvalableMemoryLabel.Text = "102400 байт";
            this.AvalableMemoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Controls.Add(this.panel2);
            this.BackgroundPanel.Controls.Add(this.panel1);
            this.BackgroundPanel.Controls.Add(this.TextPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(212, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(788, 612);
            this.BackgroundPanel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TableLayout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 368);
            this.panel2.TabIndex = 4;
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.57868F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.42132F));
            this.TableLayout.Controls.Add(this.ImagePreview, 0, 0);
            this.TableLayout.Controls.Add(this.pictureBox1, 1, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.75F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.25F));
            this.TableLayout.Size = new System.Drawing.Size(788, 368);
            this.TableLayout.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(503, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 362);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 64);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.57868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.42132F));
            this.tableLayoutPanel1.Controls.Add(this.ClearMainImageButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClearMainImageButton
            // 
            this.ClearMainImageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearMainImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearMainImageButton.Location = new System.Drawing.Point(117, 10);
            this.ClearMainImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.ClearMainImageButton.Name = "ClearMainImageButton";
            this.ClearMainImageButton.Size = new System.Drawing.Size(265, 44);
            this.ClearMainImageButton.TabIndex = 5;
            this.ClearMainImageButton.Text = "Очистить главное изображение";
            this.ClearMainImageButton.UseVisualStyleBackColor = true;
            this.ClearMainImageButton.Click += new System.EventHandler(this.ClearMainImageButton_Click);
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.panel4);
            this.TextPanel.Controls.Add(this.panel3);
            this.TextPanel.Controls.Add(this.richTextBox1);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextPanel.Location = new System.Drawing.Point(0, 432);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(788, 180);
            this.TextPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.vScrollBar1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(748, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 151);
            this.panel4.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 151);
            this.vScrollBar1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 29);
            this.panel3.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(788, 180);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // AvalableMemoryTooltip
            // 
            this.AvalableMemoryTooltip.ToolTipTitle = "Доступно памяти для записи в изображение (зависит от размера главного изображения" +
    ")";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusProgressBar.Size = new System.Drawing.Size(210, 16);
            this.StatusProgressBar.Value = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1000, 634);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Image";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.BackgroundPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TextPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenImageButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.PictureBox ImagePreview;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripMainText;
        private System.Windows.Forms.Button EncryptTextButton;
        private System.Windows.Forms.Button EncryptImageButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Button ClearMainImageButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AvalableMemoryTitle;
        private System.Windows.Forms.Label AvalableMemoryLabel;
        private System.Windows.Forms.ToolTip AvalableMemoryTooltip;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
    }
}

