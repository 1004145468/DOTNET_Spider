﻿using System.Windows.Forms;

namespace NetSpider
{
    partial class MainForm
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
            this.HtmlInputView = new System.Windows.Forms.TextBox();
            this.HtmlAnalysisBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HtmlTreeView = new System.Windows.Forms.TreeView();
            this.filter_groupbox = new System.Windows.Forms.GroupBox();
            this.filter_name_input = new System.Windows.Forms.TextBox();
            this.filter_class_input = new System.Windows.Forms.TextBox();
            this.filter_name = new System.Windows.Forms.CheckBox();
            this.filter_class = new System.Windows.Forms.CheckBox();
            this.filter_id_input = new System.Windows.Forms.TextBox();
            this.filter_id = new System.Windows.Forms.CheckBox();
            this.result_groupbox = new System.Windows.Forms.GroupBox();
            this.result_href = new System.Windows.Forms.RadioButton();
            this.result_text = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filter_listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startBtn = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.needDeepGet = new System.Windows.Forms.CheckBox();
            this.filter_href = new System.Windows.Forms.CheckBox();
            this.filter_href_input = new System.Windows.Forms.TextBox();
            this.needdeepget_input = new System.Windows.Forms.TextBox();
            this.filter_groupbox.SuspendLayout();
            this.result_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HtmlInputView
            // 
            this.HtmlInputView.Location = new System.Drawing.Point(27, 27);
            this.HtmlInputView.Name = "HtmlInputView";
            this.HtmlInputView.Size = new System.Drawing.Size(951, 21);
            this.HtmlInputView.TabIndex = 0;
            this.HtmlInputView.Text = "https://www.baidu.com/";
            // 
            // HtmlAnalysisBtn
            // 
            this.HtmlAnalysisBtn.Location = new System.Drawing.Point(996, 18);
            this.HtmlAnalysisBtn.Name = "HtmlAnalysisBtn";
            this.HtmlAnalysisBtn.Size = new System.Drawing.Size(122, 36);
            this.HtmlAnalysisBtn.TabIndex = 1;
            this.HtmlAnalysisBtn.Text = "生成树";
            this.HtmlAnalysisBtn.UseVisualStyleBackColor = true;
            this.HtmlAnalysisBtn.Click += new System.EventHandler(this.HtmlAnalysisBtn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1175, 2);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // HtmlTreeView
            // 
            this.HtmlTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.HtmlTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HtmlTreeView.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HtmlTreeView.Location = new System.Drawing.Point(30, 75);
            this.HtmlTreeView.Name = "HtmlTreeView";
            this.HtmlTreeView.Size = new System.Drawing.Size(593, 718);
            this.HtmlTreeView.TabIndex = 3;
            this.HtmlTreeView.DoubleClick += new System.EventHandler(this.NodeItemSelectListener);
            // 
            // filter_groupbox
            // 
            this.filter_groupbox.Controls.Add(this.filter_href_input);
            this.filter_groupbox.Controls.Add(this.filter_href);
            this.filter_groupbox.Controls.Add(this.filter_name_input);
            this.filter_groupbox.Controls.Add(this.filter_class_input);
            this.filter_groupbox.Controls.Add(this.filter_name);
            this.filter_groupbox.Controls.Add(this.filter_class);
            this.filter_groupbox.Controls.Add(this.filter_id_input);
            this.filter_groupbox.Controls.Add(this.filter_id);
            this.filter_groupbox.Location = new System.Drawing.Point(641, 77);
            this.filter_groupbox.Name = "filter_groupbox";
            this.filter_groupbox.Size = new System.Drawing.Size(483, 145);
            this.filter_groupbox.TabIndex = 4;
            this.filter_groupbox.TabStop = false;
            this.filter_groupbox.Text = "标签提取规则";
            // 
            // filter_name_input
            // 
            this.filter_name_input.Location = new System.Drawing.Point(131, 85);
            this.filter_name_input.Name = "filter_name_input";
            this.filter_name_input.Size = new System.Drawing.Size(302, 21);
            this.filter_name_input.TabIndex = 5;
            // 
            // filter_class_input
            // 
            this.filter_class_input.Location = new System.Drawing.Point(131, 57);
            this.filter_class_input.Name = "filter_class_input";
            this.filter_class_input.Size = new System.Drawing.Size(302, 21);
            this.filter_class_input.TabIndex = 4;
            // 
            // filter_name
            // 
            this.filter_name.AutoSize = true;
            this.filter_name.Location = new System.Drawing.Point(71, 85);
            this.filter_name.Name = "filter_name";
            this.filter_name.Size = new System.Drawing.Size(48, 16);
            this.filter_name.TabIndex = 3;
            this.filter_name.Text = "Name";
            this.filter_name.UseVisualStyleBackColor = true;
            // 
            // filter_class
            // 
            this.filter_class.AutoSize = true;
            this.filter_class.Location = new System.Drawing.Point(71, 57);
            this.filter_class.Name = "filter_class";
            this.filter_class.Size = new System.Drawing.Size(54, 16);
            this.filter_class.TabIndex = 2;
            this.filter_class.Text = "Class";
            this.filter_class.UseVisualStyleBackColor = true;
            // 
            // filter_id_input
            // 
            this.filter_id_input.Location = new System.Drawing.Point(131, 29);
            this.filter_id_input.Name = "filter_id_input";
            this.filter_id_input.Size = new System.Drawing.Size(302, 21);
            this.filter_id_input.TabIndex = 1;
            // 
            // filter_id
            // 
            this.filter_id.AutoSize = true;
            this.filter_id.Location = new System.Drawing.Point(71, 29);
            this.filter_id.Name = "filter_id";
            this.filter_id.Size = new System.Drawing.Size(36, 16);
            this.filter_id.TabIndex = 0;
            this.filter_id.Text = "ID";
            this.filter_id.UseVisualStyleBackColor = true;
            // 
            // result_groupbox
            // 
            this.result_groupbox.Controls.Add(this.result_href);
            this.result_groupbox.Controls.Add(this.result_text);
            this.result_groupbox.Location = new System.Drawing.Point(642, 238);
            this.result_groupbox.Name = "result_groupbox";
            this.result_groupbox.Size = new System.Drawing.Size(482, 77);
            this.result_groupbox.TabIndex = 5;
            this.result_groupbox.TabStop = false;
            this.result_groupbox.Text = "提取标签的内容";
            // 
            // result_href
            // 
            this.result_href.AutoSize = true;
            this.result_href.Location = new System.Drawing.Point(246, 37);
            this.result_href.Name = "result_href";
            this.result_href.Size = new System.Drawing.Size(119, 16);
            this.result_href.TabIndex = 10;
            this.result_href.Text = "图片资源（href）";
            this.result_href.UseVisualStyleBackColor = true;
            // 
            // result_text
            // 
            this.result_text.AutoSize = true;
            this.result_text.Checked = true;
            this.result_text.Location = new System.Drawing.Point(47, 37);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(131, 16);
            this.result_text.TabIndex = 9;
            this.result_text.TabStop = true;
            this.result_text.Text = "标签内文字（Text）";
            this.result_text.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1045, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addFilterBtn_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filter_listview);
            this.groupBox1.Location = new System.Drawing.Point(642, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成过滤器列表";
            // 
            // filter_listview
            // 
            this.filter_listview.BackColor = System.Drawing.SystemColors.Control;
            this.filter_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filter_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.filter_listview.FullRowSelect = true;
            this.filter_listview.Location = new System.Drawing.Point(6, 37);
            this.filter_listview.Name = "filter_listview";
            this.filter_listview.Size = new System.Drawing.Size(470, 277);
            this.filter_listview.TabIndex = 0;
            this.filter_listview.UseCompatibleStateImageBehavior = false;
            this.filter_listview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "规则";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "内容";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(641, 740);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(482, 38);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "开始提取";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(27, 86);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(20, 20);
            this.webBrowser.TabIndex = 9;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // needDeepGet
            // 
            this.needDeepGet.AutoSize = true;
            this.needDeepGet.Location = new System.Drawing.Point(643, 698);
            this.needDeepGet.Name = "needDeepGet";
            this.needDeepGet.Size = new System.Drawing.Size(72, 16);
            this.needDeepGet.TabIndex = 10;
            this.needDeepGet.Text = "深度扒取";
            this.needDeepGet.UseVisualStyleBackColor = true;
            // 
            // filter_href
            // 
            this.filter_href.AutoSize = true;
            this.filter_href.Location = new System.Drawing.Point(71, 113);
            this.filter_href.Name = "filter_href";
            this.filter_href.Size = new System.Drawing.Size(48, 16);
            this.filter_href.TabIndex = 6;
            this.filter_href.Text = "href";
            this.filter_href.UseVisualStyleBackColor = true;
            // 
            // filter_href_input
            // 
            this.filter_href_input.Location = new System.Drawing.Point(131, 113);
            this.filter_href_input.Name = "filter_href_input";
            this.filter_href_input.Size = new System.Drawing.Size(302, 21);
            this.filter_href_input.TabIndex = 7;
            // 
            // needdeepget_input
            // 
            this.needdeepget_input.Location = new System.Drawing.Point(721, 698);
            this.needdeepget_input.Name = "needdeepget_input";
            this.needdeepget_input.Size = new System.Drawing.Size(397, 21);
            this.needdeepget_input.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 799);
            this.Controls.Add(this.needdeepget_input);
            this.Controls.Add(this.needDeepGet);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result_groupbox);
            this.Controls.Add(this.filter_groupbox);
            this.Controls.Add(this.HtmlTreeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HtmlAnalysisBtn);
            this.Controls.Add(this.HtmlInputView);
            this.Controls.Add(this.webBrowser);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "万能网页爬虫器";
            this.filter_groupbox.ResumeLayout(false);
            this.filter_groupbox.PerformLayout();
            this.result_groupbox.ResumeLayout(false);
            this.result_groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HtmlInputView;
        private System.Windows.Forms.Button HtmlAnalysisBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView HtmlTreeView;
        private System.Windows.Forms.GroupBox filter_groupbox;
        private System.Windows.Forms.TextBox filter_name_input;
        private System.Windows.Forms.TextBox filter_class_input;
        private System.Windows.Forms.CheckBox filter_name;
        private System.Windows.Forms.CheckBox filter_class;
        private System.Windows.Forms.TextBox filter_id_input;
        private System.Windows.Forms.CheckBox filter_id;
        private System.Windows.Forms.GroupBox result_groupbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView filter_listview;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RadioButton result_href;
        private System.Windows.Forms.RadioButton result_text;
        private System.Windows.Forms.WebBrowser webBrowser;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private CheckBox needDeepGet;
        private TextBox filter_href_input;
        private CheckBox filter_href;
        private TextBox needdeepget_input;
    }
}

