﻿namespace MuleSoft.RAML.Tools.CustomEditor
{
    partial class MyEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxCtrl = new MuleSoft.RAML.Tools.CustomEditor.EditorTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // richTextBoxCtrl
            // 
            this.richTextBoxCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCtrl.FilterMouseClickMessages = false;
            this.richTextBoxCtrl.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCtrl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.richTextBoxCtrl.Name = "richTextBoxCtrl";
            this.richTextBoxCtrl.Size = new System.Drawing.Size(393, 352);
            this.richTextBoxCtrl.TabIndex = 0;
            this.richTextBoxCtrl.Text = "";
            this.richTextBoxCtrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxCtrl_KeyDown);
            this.richTextBoxCtrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxCtrl_KeyPress);
            this.richTextBoxCtrl.MouseEnter += new System.EventHandler(this.richTextBoxCtrl_MouseEnter);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-123, -62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(3458, 1734);
            this.webBrowser1.TabIndex = 1;
            // 
            // MyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.richTextBoxCtrl);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MyEditor";
            this.Size = new System.Drawing.Size(400, 358);
            this.ResumeLayout(false);

        }

        #endregion

        private EditorTextBox richTextBoxCtrl;
        private System.Windows.Forms.WebBrowser webBrowser1;


    }
}