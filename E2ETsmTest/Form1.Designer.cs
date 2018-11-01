namespace E2ETsmTest
{
    partial class TsmTest
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
            this.SpTsmPartner = new System.Windows.Forms.TabControl();
            this.SeAgentMng = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SeTsmUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RsaPubkExp = new System.Windows.Forms.TextBox();
            this.SaveInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RsaModules = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RsaPrvtExp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PartnerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InitCommu = new System.Windows.Forms.TabControl();
            this.InitCommune = new System.Windows.Forms.TabPage();
            this.EncKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MacKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInitCommune = new System.Windows.Forms.Button();
            this.SeIssuance = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SeId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSeIssuance = new System.Windows.Forms.Button();
            this.SeCheck = new System.Windows.Forms.Button();
            this.TBSpTsmPartner = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProcLogText = new System.Windows.Forms.TextBox();
            this.InitComReqSeq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InitDateTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InitComRspSeq = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.InitTimeStamp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnClearLog = new System.Windows.Forms.Button();
            this.SeProduct = new System.Windows.Forms.TabPage();
            this.SpTsmPartner.SuspendLayout();
            this.SeAgentMng.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.InitCommu.SuspendLayout();
            this.InitCommune.SuspendLayout();
            this.SeIssuance.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpTsmPartner
            // 
            this.SpTsmPartner.Controls.Add(this.SeAgentMng);
            this.SpTsmPartner.Controls.Add(this.TBSpTsmPartner);
            this.SpTsmPartner.Controls.Add(this.tabPage1);
            this.SpTsmPartner.Controls.Add(this.tabPage2);
            this.SpTsmPartner.Controls.Add(this.tabPage3);
            this.SpTsmPartner.Controls.Add(this.SeProduct);
            this.SpTsmPartner.Location = new System.Drawing.Point(6, 2);
            this.SpTsmPartner.Name = "SpTsmPartner";
            this.SpTsmPartner.SelectedIndex = 0;
            this.SpTsmPartner.Size = new System.Drawing.Size(932, 543);
            this.SpTsmPartner.TabIndex = 0;
            // 
            // SeAgentMng
            // 
            this.SeAgentMng.Controls.Add(this.groupBox1);
            this.SeAgentMng.Controls.Add(this.groupBox2);
            this.SeAgentMng.Location = new System.Drawing.Point(4, 22);
            this.SeAgentMng.Name = "SeAgentMng";
            this.SeAgentMng.Padding = new System.Windows.Forms.Padding(3);
            this.SeAgentMng.Size = new System.Drawing.Size(924, 517);
            this.SeAgentMng.TabIndex = 0;
            this.SeAgentMng.Text = "SE代理管理方";
            this.SeAgentMng.UseVisualStyleBackColor = true;
            this.SeAgentMng.Click += new System.EventHandler(this.SeAgentMng_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeTsmUrl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RsaPubkExp);
            this.groupBox1.Controls.Add(this.SaveInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RsaModules);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RsaPrvtExp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PartnerId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合作方信息";
            // 
            // SeTsmUrl
            // 
            this.SeTsmUrl.Location = new System.Drawing.Point(97, 23);
            this.SeTsmUrl.MaxLength = 2048;
            this.SeTsmUrl.Name = "SeTsmUrl";
            this.SeTsmUrl.Size = new System.Drawing.Size(800, 21);
            this.SeTsmUrl.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "SE TSM URL:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RsaPubkExp
            // 
            this.RsaPubkExp.Location = new System.Drawing.Point(97, 82);
            this.RsaPubkExp.MaxLength = 6;
            this.RsaPubkExp.Name = "RsaPubkExp";
            this.RsaPubkExp.Size = new System.Drawing.Size(100, 21);
            this.RsaPubkExp.TabIndex = 8;
            // 
            // SaveInfo
            // 
            this.SaveInfo.Location = new System.Drawing.Point(97, 171);
            this.SaveInfo.Name = "SaveInfo";
            this.SaveInfo.Size = new System.Drawing.Size(75, 23);
            this.SaveInfo.TabIndex = 6;
            this.SaveInfo.Text = "保存";
            this.SaveInfo.UseVisualStyleBackColor = true;
            this.SaveInfo.Click += new System.EventHandler(this.SaveInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "RSA公钥指数:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RsaModules
            // 
            this.RsaModules.Location = new System.Drawing.Point(97, 140);
            this.RsaModules.MaxLength = 512;
            this.RsaModules.Name = "RsaModules";
            this.RsaModules.Size = new System.Drawing.Size(804, 21);
            this.RsaModules.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "RSA公私钥模:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RsaPrvtExp
            // 
            this.RsaPrvtExp.Location = new System.Drawing.Point(97, 111);
            this.RsaPrvtExp.MaxLength = 512;
            this.RsaPrvtExp.Name = "RsaPrvtExp";
            this.RsaPrvtExp.Size = new System.Drawing.Size(804, 21);
            this.RsaPrvtExp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "RSA私钥指数:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartnerId
            // 
            this.PartnerId.Location = new System.Drawing.Point(97, 53);
            this.PartnerId.MaxLength = 8;
            this.PartnerId.Name = "PartnerId";
            this.PartnerId.Size = new System.Drawing.Size(100, 21);
            this.PartnerId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "合作方ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InitCommu);
            this.groupBox2.Location = new System.Drawing.Point(7, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 289);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作 ";
            // 
            // InitCommu
            // 
            this.InitCommu.Controls.Add(this.InitCommune);
            this.InitCommu.Controls.Add(this.SeIssuance);
            this.InitCommu.Location = new System.Drawing.Point(12, 20);
            this.InitCommu.Name = "InitCommu";
            this.InitCommu.SelectedIndex = 0;
            this.InitCommu.Size = new System.Drawing.Size(889, 263);
            this.InitCommu.TabIndex = 10;
            // 
            // InitCommune
            // 
            this.InitCommune.Controls.Add(this.InitTimeStamp);
            this.InitCommune.Controls.Add(this.label13);
            this.InitCommune.Controls.Add(this.InitComRspSeq);
            this.InitCommune.Controls.Add(this.label12);
            this.InitCommune.Controls.Add(this.InitComReqSeq);
            this.InitCommune.Controls.Add(this.label10);
            this.InitCommune.Controls.Add(this.InitDateTime);
            this.InitCommune.Controls.Add(this.label11);
            this.InitCommune.Controls.Add(this.EncKey);
            this.InitCommune.Controls.Add(this.label6);
            this.InitCommune.Controls.Add(this.MacKey);
            this.InitCommune.Controls.Add(this.label5);
            this.InitCommune.Controls.Add(this.btnInitCommune);
            this.InitCommune.Location = new System.Drawing.Point(4, 22);
            this.InitCommune.Name = "InitCommune";
            this.InitCommune.Padding = new System.Windows.Forms.Padding(3);
            this.InitCommune.Size = new System.Drawing.Size(881, 237);
            this.InitCommune.TabIndex = 0;
            this.InitCommune.Text = "初始化通讯";
            this.InitCommune.UseVisualStyleBackColor = true;
            // 
            // EncKey
            // 
            this.EncKey.Location = new System.Drawing.Point(452, 90);
            this.EncKey.MaxLength = 32;
            this.EncKey.Name = "EncKey";
            this.EncKey.Size = new System.Drawing.Size(275, 21);
            this.EncKey.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "ENC密钥:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MacKey
            // 
            this.MacKey.Location = new System.Drawing.Point(452, 57);
            this.MacKey.MaxLength = 32;
            this.MacKey.Name = "MacKey";
            this.MacKey.Size = new System.Drawing.Size(275, 21);
            this.MacKey.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "MAC密钥:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInitCommune
            // 
            this.btnInitCommune.Location = new System.Drawing.Point(14, 19);
            this.btnInitCommune.Name = "btnInitCommune";
            this.btnInitCommune.Size = new System.Drawing.Size(75, 23);
            this.btnInitCommune.TabIndex = 9;
            this.btnInitCommune.Text = "初始化通讯";
            this.btnInitCommune.UseVisualStyleBackColor = true;
            this.btnInitCommune.Click += new System.EventHandler(this.btnInitCommune_Click);
            // 
            // SeIssuance
            // 
            this.SeIssuance.Controls.Add(this.textBox1);
            this.SeIssuance.Controls.Add(this.label8);
            this.SeIssuance.Controls.Add(this.SeId);
            this.SeIssuance.Controls.Add(this.label7);
            this.SeIssuance.Controls.Add(this.BtnSeIssuance);
            this.SeIssuance.Controls.Add(this.SeCheck);
            this.SeIssuance.Location = new System.Drawing.Point(4, 22);
            this.SeIssuance.Name = "SeIssuance";
            this.SeIssuance.Padding = new System.Windows.Forms.Padding(3);
            this.SeIssuance.Size = new System.Drawing.Size(881, 227);
            this.SeIssuance.TabIndex = 1;
            this.SeIssuance.Text = "SE发行";
            this.SeIssuance.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 66);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "批次ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SeId
            // 
            this.SeId.Location = new System.Drawing.Point(81, 93);
            this.SeId.MaxLength = 8;
            this.SeId.Name = "SeId";
            this.SeId.Size = new System.Drawing.Size(100, 21);
            this.SeId.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "SE ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSeIssuance
            // 
            this.BtnSeIssuance.Location = new System.Drawing.Point(95, 19);
            this.BtnSeIssuance.Name = "BtnSeIssuance";
            this.BtnSeIssuance.Size = new System.Drawing.Size(75, 23);
            this.BtnSeIssuance.TabIndex = 1;
            this.BtnSeIssuance.Text = "SE发行";
            this.BtnSeIssuance.UseVisualStyleBackColor = true;
            // 
            // SeCheck
            // 
            this.SeCheck.Location = new System.Drawing.Point(14, 19);
            this.SeCheck.Name = "SeCheck";
            this.SeCheck.Size = new System.Drawing.Size(75, 23);
            this.SeCheck.TabIndex = 0;
            this.SeCheck.Text = "SE有效性检查";
            this.SeCheck.UseVisualStyleBackColor = true;
            // 
            // TBSpTsmPartner
            // 
            this.TBSpTsmPartner.Location = new System.Drawing.Point(4, 22);
            this.TBSpTsmPartner.Name = "TBSpTsmPartner";
            this.TBSpTsmPartner.Padding = new System.Windows.Forms.Padding(3);
            this.TBSpTsmPartner.Size = new System.Drawing.Size(924, 507);
            this.TBSpTsmPartner.TabIndex = 1;
            this.TBSpTsmPartner.Text = "SP TSM合作方";
            this.TBSpTsmPartner.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(924, 507);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "服务提供方";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(924, 507);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "SEI TSM合作方";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(924, 507);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "应用代理管理方";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnClearLog);
            this.groupBox3.Controls.Add(this.ProcLogText);
            this.groupBox3.Location = new System.Drawing.Point(941, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(462, 533);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "过程日志";
            // 
            // ProcLogText
            // 
            this.ProcLogText.Location = new System.Drawing.Point(10, 50);
            this.ProcLogText.Margin = new System.Windows.Forms.Padding(0);
            this.ProcLogText.Multiline = true;
            this.ProcLogText.Name = "ProcLogText";
            this.ProcLogText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ProcLogText.Size = new System.Drawing.Size(443, 472);
            this.ProcLogText.TabIndex = 0;
            // 
            // InitComReqSeq
            // 
            this.InitComReqSeq.Location = new System.Drawing.Point(81, 124);
            this.InitComReqSeq.MaxLength = 32;
            this.InitComReqSeq.Name = "InitComReqSeq";
            this.InitComReqSeq.Size = new System.Drawing.Size(275, 21);
            this.InitComReqSeq.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "请求流水:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InitDateTime
            // 
            this.InitDateTime.Location = new System.Drawing.Point(81, 57);
            this.InitDateTime.MaxLength = 32;
            this.InitDateTime.Name = "InitDateTime";
            this.InitDateTime.Size = new System.Drawing.Size(275, 21);
            this.InitDateTime.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "日期时间:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InitComRspSeq
            // 
            this.InitComRspSeq.Location = new System.Drawing.Point(81, 158);
            this.InitComRspSeq.MaxLength = 32;
            this.InitComRspSeq.Name = "InitComRspSeq";
            this.InitComRspSeq.Size = new System.Drawing.Size(275, 21);
            this.InitComRspSeq.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "响应流水:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InitTimeStamp
            // 
            this.InitTimeStamp.Location = new System.Drawing.Point(81, 90);
            this.InitTimeStamp.MaxLength = 32;
            this.InitTimeStamp.Name = "InitTimeStamp";
            this.InitTimeStamp.Size = new System.Drawing.Size(275, 21);
            this.InitTimeStamp.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "时间戳:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnClearLog
            // 
            this.BtnClearLog.Location = new System.Drawing.Point(10, 18);
            this.BtnClearLog.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearLog.Name = "BtnClearLog";
            this.BtnClearLog.Size = new System.Drawing.Size(75, 23);
            this.BtnClearLog.TabIndex = 1;
            this.BtnClearLog.Text = "清空";
            this.BtnClearLog.UseVisualStyleBackColor = true;
            this.BtnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // SeProduct
            // 
            this.SeProduct.Location = new System.Drawing.Point(4, 22);
            this.SeProduct.Name = "SeProduct";
            this.SeProduct.Size = new System.Drawing.Size(924, 507);
            this.SeProduct.TabIndex = 5;
            this.SeProduct.Text = "SE生产";
            this.SeProduct.UseVisualStyleBackColor = true;
            // 
            // TsmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SpTsmPartner);
            this.Name = "TsmTest";
            this.Text = "TsmTest";
            this.Load += new System.EventHandler(this.TsmTest_Load);
            this.SpTsmPartner.ResumeLayout(false);
            this.SeAgentMng.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.InitCommu.ResumeLayout(false);
            this.InitCommune.ResumeLayout(false);
            this.InitCommune.PerformLayout();
            this.SeIssuance.ResumeLayout(false);
            this.SeIssuance.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SpTsmPartner;
        private System.Windows.Forms.TabPage SeAgentMng;
        private System.Windows.Forms.TabPage TBSpTsmPartner;
        private System.Windows.Forms.TextBox RsaPrvtExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartnerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RsaModules;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveInfo;
        private System.Windows.Forms.TextBox RsaPubkExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInitCommune;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl InitCommu;
        private System.Windows.Forms.TabPage InitCommune;
        private System.Windows.Forms.TextBox EncKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MacKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage SeIssuance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SeId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSeIssuance;
        private System.Windows.Forms.Button SeCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ProcLogText;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox SeTsmUrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox InitTimeStamp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox InitComRspSeq;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox InitComReqSeq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox InitDateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnClearLog;
        private System.Windows.Forms.TabPage SeProduct;
    }
}

