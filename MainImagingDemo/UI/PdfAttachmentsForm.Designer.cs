namespace MainDemo
{
   partial class PdfAttachmentsForm
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
         this._lstAttachments = new System.Windows.Forms.ListView();
         this._btnInfo = new System.Windows.Forms.Button();
         this._btnExtract = new System.Windows.Forms.Button();
         this._btnClose = new System.Windows.Forms.Button();
         this._btnOpenAttachment = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // _lstAttachments
         // 
         this._lstAttachments.HideSelection = false;
         this._lstAttachments.Location = new System.Drawing.Point(13, 12);
         this._lstAttachments.MultiSelect = false;
         this._lstAttachments.Name = "_lstAttachments";
         this._lstAttachments.Size = new System.Drawing.Size(740, 223);
         this._lstAttachments.TabIndex = 0;
         this._lstAttachments.UseCompatibleStateImageBehavior = false;
         this._lstAttachments.View = System.Windows.Forms.View.Details;
         this._lstAttachments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lstAttachments_MouseDoubleClick);
         // 
         // _btnInfo
         // 
         this._btnInfo.Location = new System.Drawing.Point(89, 244);
         this._btnInfo.Name = "_btnInfo";
         this._btnInfo.Size = new System.Drawing.Size(136, 23);
         this._btnInfo.TabIndex = 1;
         this._btnInfo.Text = "Attachment Info...";
         this._btnInfo.UseVisualStyleBackColor = true;
         this._btnInfo.Click += new System.EventHandler(this._btnInfo_Click);
         // 
         // _btnExtract
         // 
         this._btnExtract.Location = new System.Drawing.Point(391, 244);
         this._btnExtract.Name = "_btnExtract";
         this._btnExtract.Size = new System.Drawing.Size(136, 23);
         this._btnExtract.TabIndex = 2;
         this._btnExtract.Text = "Extract Attachment...";
         this._btnExtract.UseVisualStyleBackColor = true;
         this._btnExtract.Click += new System.EventHandler(this._btnExtract_Click);
         // 
         // _btnClose
         // 
         this._btnClose.Location = new System.Drawing.Point(542, 244);
         this._btnClose.Name = "_btnClose";
         this._btnClose.Size = new System.Drawing.Size(136, 23);
         this._btnClose.TabIndex = 3;
         this._btnClose.Text = "Close";
         this._btnClose.UseVisualStyleBackColor = true;
         this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
         // 
         // _btnOpenAttachment
         // 
         this._btnOpenAttachment.Location = new System.Drawing.Point(240, 244);
         this._btnOpenAttachment.Name = "_btnOpenAttachment";
         this._btnOpenAttachment.Size = new System.Drawing.Size(136, 23);
         this._btnOpenAttachment.TabIndex = 4;
         this._btnOpenAttachment.Text = "Open Attachment";
         this._btnOpenAttachment.UseVisualStyleBackColor = true;
         this._btnOpenAttachment.Click += new System.EventHandler(this._btnOpenAttachment_Click);
         // 
         // PdfAttachmentsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(766, 276);
         this.Controls.Add(this._btnOpenAttachment);
         this.Controls.Add(this._btnClose);
         this.Controls.Add(this._btnExtract);
         this.Controls.Add(this._btnInfo);
         this.Controls.Add(this._lstAttachments);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PdfAttachmentsForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "PDF Attachments";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListView _lstAttachments;
      private System.Windows.Forms.Button _btnInfo;
      private System.Windows.Forms.Button _btnExtract;
      private System.Windows.Forms.Button _btnClose;
      private System.Windows.Forms.Button _btnOpenAttachment;
   }
}