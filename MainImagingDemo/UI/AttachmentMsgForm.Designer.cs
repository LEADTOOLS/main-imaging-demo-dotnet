namespace MainDemo
{
   partial class AttachmentMsgForm
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
         this._grpAttachmentMsg = new System.Windows.Forms.GroupBox();
         this._lblAttachmentMsg = new System.Windows.Forms.Label();
         this._btnOpenAttachment = new System.Windows.Forms.Button();
         this._btnOpenFile = new System.Windows.Forms.Button();
         this._btnCancel = new System.Windows.Forms.Button();
         this._grpAttachmentMsg.SuspendLayout();
         this.SuspendLayout();
         // 
         // _grpAttachmentMsg
         // 
         this._grpAttachmentMsg.Controls.Add(this._lblAttachmentMsg);
         this._grpAttachmentMsg.Location = new System.Drawing.Point(12, 14);
         this._grpAttachmentMsg.Name = "_grpAttachmentMsg";
         this._grpAttachmentMsg.Size = new System.Drawing.Size(251, 96);
         this._grpAttachmentMsg.TabIndex = 0;
         this._grpAttachmentMsg.TabStop = false;
         // 
         // _lblAttachmentMsg
         // 
         this._lblAttachmentMsg.AutoSize = true;
         this._lblAttachmentMsg.Location = new System.Drawing.Point(11, 24);
         this._lblAttachmentMsg.Name = "_lblAttachmentMsg";
         this._lblAttachmentMsg.Size = new System.Drawing.Size(206, 52);
         this._lblAttachmentMsg.TabIndex = 0;
         this._lblAttachmentMsg.Text = "The selected file has attachments,\r\n\r\nDo you want to open these attachments?\r\nOr " +
    "do you want to open original file?";
         // 
         // _btnOpenAttachment
         // 
         this._btnOpenAttachment.Location = new System.Drawing.Point(275, 22);
         this._btnOpenAttachment.Name = "_btnOpenAttachment";
         this._btnOpenAttachment.Size = new System.Drawing.Size(158, 23);
         this._btnOpenAttachment.TabIndex = 1;
         this._btnOpenAttachment.Text = "Open Attachments...";
         this._btnOpenAttachment.UseVisualStyleBackColor = true;
         this._btnOpenAttachment.Click += new System.EventHandler(this._btnOpenAttachment_Click);
         // 
         // _btnOpenFile
         // 
         this._btnOpenFile.Location = new System.Drawing.Point(275, 51);
         this._btnOpenFile.Name = "_btnOpenFile";
         this._btnOpenFile.Size = new System.Drawing.Size(158, 23);
         this._btnOpenFile.TabIndex = 2;
         this._btnOpenFile.Text = "Open File";
         this._btnOpenFile.UseVisualStyleBackColor = true;
         this._btnOpenFile.Click += new System.EventHandler(this._btnOpenFile_Click);
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.Location = new System.Drawing.Point(275, 80);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(158, 23);
         this._btnCancel.TabIndex = 3;
         this._btnCancel.Text = "Cancel";
         this._btnCancel.UseVisualStyleBackColor = true;
         this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
         // 
         // AttachmentMsgForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(446, 121);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOpenFile);
         this.Controls.Add(this._btnOpenAttachment);
         this.Controls.Add(this._grpAttachmentMsg);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AttachmentMsgForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Open Attachments";
         this._grpAttachmentMsg.ResumeLayout(false);
         this._grpAttachmentMsg.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox _grpAttachmentMsg;
      private System.Windows.Forms.Label _lblAttachmentMsg;
      private System.Windows.Forms.Button _btnOpenAttachment;
      private System.Windows.Forms.Button _btnOpenFile;
      private System.Windows.Forms.Button _btnCancel;
   }
}