namespace DangoProcessGuard
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btUnRegister = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.lbServiceStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txCommandLine = new System.Windows.Forms.TextBox();
            this.lbCommandLine = new System.Windows.Forms.Label();
            this.btShowFile = new System.Windows.Forms.Button();
            this.txFileName = new System.Windows.Forms.TextBox();
            this.lbFileName = new System.Windows.Forms.Label();
            this.tmRefreshStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txStartPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btStop);
            this.groupBox1.Controls.Add(this.btStart);
            this.groupBox1.Controls.Add(this.btUnRegister);
            this.groupBox1.Controls.Add(this.btRegister);
            this.groupBox1.Controls.Add(this.lbServiceStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开机启动服务";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(134, 77);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 9;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(134, 48);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btUnRegister
            // 
            this.btUnRegister.Location = new System.Drawing.Point(6, 77);
            this.btUnRegister.Name = "btUnRegister";
            this.btUnRegister.Size = new System.Drawing.Size(121, 23);
            this.btUnRegister.TabIndex = 7;
            this.btUnRegister.Text = "注销开机启动服务";
            this.btUnRegister.UseVisualStyleBackColor = true;
            this.btUnRegister.Click += new System.EventHandler(this.btUnRegister_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(6, 48);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(121, 23);
            this.btRegister.TabIndex = 6;
            this.btRegister.Text = "注册开机启动服务";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // lbServiceStatus
            // 
            this.lbServiceStatus.AutoSize = true;
            this.lbServiceStatus.Location = new System.Drawing.Point(78, 21);
            this.lbServiceStatus.Name = "lbServiceStatus";
            this.lbServiceStatus.Size = new System.Drawing.Size(41, 12);
            this.lbServiceStatus.TabIndex = 1;
            this.lbServiceStatus.Text = "未开启";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务状态：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txStartPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btCancel);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.txCommandLine);
            this.groupBox2.Controls.Add(this.lbCommandLine);
            this.groupBox2.Controls.Add(this.btShowFile);
            this.groupBox2.Controls.Add(this.txFileName);
            this.groupBox2.Controls.Add(this.lbFileName);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "启动信息";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(596, 186);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(514, 186);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txCommandLine
            // 
            this.txCommandLine.Location = new System.Drawing.Point(80, 72);
            this.txCommandLine.Name = "txCommandLine";
            this.txCommandLine.Size = new System.Drawing.Size(509, 21);
            this.txCommandLine.TabIndex = 2;
            this.txCommandLine.TextChanged += new System.EventHandler(this.txCommandLine_TextChanged);
            // 
            // lbCommandLine
            // 
            this.lbCommandLine.AutoSize = true;
            this.lbCommandLine.Location = new System.Drawing.Point(21, 75);
            this.lbCommandLine.Name = "lbCommandLine";
            this.lbCommandLine.Size = new System.Drawing.Size(53, 12);
            this.lbCommandLine.TabIndex = 3;
            this.lbCommandLine.Text = "命令行：";
            // 
            // btShowFile
            // 
            this.btShowFile.Location = new System.Drawing.Point(595, 36);
            this.btShowFile.Name = "btShowFile";
            this.btShowFile.Size = new System.Drawing.Size(75, 23);
            this.btShowFile.TabIndex = 5;
            this.btShowFile.Text = "浏览";
            this.btShowFile.UseVisualStyleBackColor = true;
            this.btShowFile.Click += new System.EventHandler(this.btShowFile_Click);
            // 
            // txFileName
            // 
            this.txFileName.Location = new System.Drawing.Point(80, 38);
            this.txFileName.Name = "txFileName";
            this.txFileName.Size = new System.Drawing.Size(509, 21);
            this.txFileName.TabIndex = 1;
            this.txFileName.TextChanged += new System.EventHandler(this.txFileName_TextChanged);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(9, 41);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(65, 12);
            this.lbFileName.TabIndex = 0;
            this.lbFileName.Text = "启动程序：";
            // 
            // tmRefreshStatusTimer
            // 
            this.tmRefreshStatusTimer.Enabled = true;
            this.tmRefreshStatusTimer.Interval = 1000;
            this.tmRefreshStatusTimer.Tick += new System.EventHandler(this.tmRefreshStatusTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "启动路径：";
            // 
            // txStartPath
            // 
            this.txStartPath.Location = new System.Drawing.Point(80, 106);
            this.txStartPath.Name = "txStartPath";
            this.txStartPath.Size = new System.Drawing.Size(509, 21);
            this.txStartPath.TabIndex = 7;
            this.txStartPath.TextChanged += new System.EventHandler(this.txStartPath_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btUnRegister;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label lbServiceStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txCommandLine;
        private System.Windows.Forms.Label lbCommandLine;
        private System.Windows.Forms.Button btShowFile;
        private System.Windows.Forms.TextBox txFileName;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Timer tmRefreshStatusTimer;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txStartPath;
        private System.Windows.Forms.Label label2;
    }
}

