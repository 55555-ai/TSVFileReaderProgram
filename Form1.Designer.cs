namespace TSVFileReaderProgram
{
    partial class frmTSVFile
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsWord = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwWord = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ssrWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsWord.SuspendLayout();
            this.ssrWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsWord
            // 
            this.mnsWord.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsWord.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.mnsWord.Location = new System.Drawing.Point(0, 0);
            this.mnsWord.Name = "mnsWord";
            this.mnsWord.Size = new System.Drawing.Size(800, 42);
            this.mnsWord.TabIndex = 0;
            this.mnsWord.Text = "menuStrip1";
            this.mnsWord.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsWord_ItemClicked);
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(81, 38);
            this.tsmiFile.Text = "檔案";
            this.tsmiFile.Click += new System.EventHandler(this.檔案ToolStripMenuItem_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(193, 44);
            this.tsmiOpen.Text = "開啟";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(193, 44);
            this.tsmiExit.Text = "結束";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(81, 38);
            this.tsmiHelp.Text = "說明";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(359, 44);
            this.tsmiAbout.Text = "關於";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // lvwWord
            // 
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.FullRowSelect = true;
            this.lvwWord.HideSelection = false;
            this.lvwWord.Location = new System.Drawing.Point(0, 42);
            this.lvwWord.Name = "lvwWord";
            this.lvwWord.Size = new System.Drawing.Size(800, 408);
            this.lvwWord.TabIndex = 1;
            this.lvwWord.UseCompatibleStateImageBehavior = false;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            this.lvwWord.SelectedIndexChanged += new System.EventHandler(this.lvwWord_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ssrWord
            // 
            this.ssrWord.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ssrWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssrWord.Location = new System.Drawing.Point(0, 410);
            this.ssrWord.Name = "ssrWord";
            this.ssrWord.Size = new System.Drawing.Size(800, 40);
            this.ssrWord.TabIndex = 2;
            this.ssrWord.Text = "statusStrip1";
            this.ssrWord.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssrWord_ItemClicked);
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(242, 30);
            this.tsslMessage.Text = "toolStripStatusLabel";
            this.tsslMessage.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // frmTSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssrWord);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.mnsWord);
            this.MainMenuStrip = this.mnsWord;
            this.Name = "frmTSVFile";
            this.Text = "TSV資料檔讀取";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTSVFile_FormClosing);
            this.Load += new System.EventHandler(this.frmTSVFile_Load);
            this.mnsWord.ResumeLayout(false);
            this.mnsWord.PerformLayout();
            this.ssrWord.ResumeLayout(false);
            this.ssrWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsWord;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ListView lvwWord;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip ssrWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
    }
}

