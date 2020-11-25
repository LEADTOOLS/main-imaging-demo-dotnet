namespace MainDemo
{
   partial class AttachmentInfoDialog
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
         this._lstInfo = new System.Windows.Forms.ListView();
         this._btnOk = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // _lstInfo
         // 
         this._lstInfo.HideSelection = false;
         this._lstInfo.Location = new System.Drawing.Point(12, 12);
         this._lstInfo.Name = "_lstInfo";
         this._lstInfo.Size = new System.Drawing.Size(293, 329);
         this._lstInfo.TabIndex = 0;
         this._lstInfo.UseCompatibleStateImageBehavior = false;
         this._lstInfo.View = System.Windows.Forms.View.Details;
         // 
         // _btnOk
         // 
         this._btnOk.Location = new System.Drawing.Point(121, 347);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(75, 23);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // AttachmentInfoDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(316, 375);
         this.Controls.Add(this._btnOk);
         this.Controls.Add(this._lstInfo);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AttachmentInfoDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Attachment Information";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListView _lstInfo;
      private System.Windows.Forms.Button _btnOk;
   }
}