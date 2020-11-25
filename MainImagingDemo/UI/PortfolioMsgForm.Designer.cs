namespace MainDemo
{
   partial class PortfolioMsgForm
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
         this._grpPortfolioMsg = new System.Windows.Forms.GroupBox();
         this._lblPortfolioMsg = new System.Windows.Forms.Label();
         this._btnOk = new System.Windows.Forms.Button();
         this._btnCancel = new System.Windows.Forms.Button();
         this._grpPortfolioMsg.SuspendLayout();
         this.SuspendLayout();
         // 
         // _grpPortfolioMsg
         // 
         this._grpPortfolioMsg.Controls.Add(this._lblPortfolioMsg);
         this._grpPortfolioMsg.Location = new System.Drawing.Point(15, 12);
         this._grpPortfolioMsg.Name = "_grpPortfolioMsg";
         this._grpPortfolioMsg.Size = new System.Drawing.Size(239, 92);
         this._grpPortfolioMsg.TabIndex = 0;
         this._grpPortfolioMsg.TabStop = false;
         // 
         // _lblPortfolioMsg
         // 
         this._lblPortfolioMsg.AutoSize = true;
         this._lblPortfolioMsg.Location = new System.Drawing.Point(16, 22);
         this._lblPortfolioMsg.Name = "_lblPortfolioMsg";
         this._lblPortfolioMsg.Size = new System.Drawing.Size(206, 52);
         this._lblPortfolioMsg.TabIndex = 0;
         this._lblPortfolioMsg.Text = "The selected file is portfolio file,\r\nThis file has attachments,\r\n\r\nDo you want t" +
    "o open these attachments?";
         // 
         // _btnOk
         // 
         this._btnOk.Location = new System.Drawing.Point(56, 112);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(75, 23);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.Location = new System.Drawing.Point(137, 112);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(75, 23);
         this._btnCancel.TabIndex = 2;
         this._btnCancel.Text = "Cancel";
         this._btnCancel.UseVisualStyleBackColor = true;
         this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
         // 
         // PortfolioMsgForm
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(269, 144);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.Controls.Add(this._grpPortfolioMsg);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PortfolioMsgForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Open Portfolio";
         this._grpPortfolioMsg.ResumeLayout(false);
         this._grpPortfolioMsg.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox _grpPortfolioMsg;
      private System.Windows.Forms.Label _lblPortfolioMsg;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.Button _btnCancel;
   }
}