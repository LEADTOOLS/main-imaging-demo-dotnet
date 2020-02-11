namespace MainDemo
{
   partial class ZoomDialog
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomDialog));
         this._btnCancel = new System.Windows.Forms.Button();
         this._btnOk = new System.Windows.Forms.Button();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._tbZoom = new System.Windows.Forms.TrackBar();
         this._tbPercentage = new System.Windows.Forms.TextBox();
         this._lblZoom = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._tbZoom)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         resources.ApplyResources(this._btnCancel, "_btnCancel");
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.UseVisualStyleBackColor = true;
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         resources.ApplyResources(this._btnOk, "_btnOk");
         this._btnOk.Name = "_btnOk";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._tbZoom);
         this._gbOptions.Controls.Add(this._tbPercentage);
         this._gbOptions.Controls.Add(this._lblZoom);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         resources.ApplyResources(this._gbOptions, "_gbOptions");
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.TabStop = false;
         // 
         // _tbZoom
         // 
         resources.ApplyResources(this._tbZoom, "_tbZoom");
         this._tbZoom.Maximum = 30000;
         this._tbZoom.Minimum = 5;
         this._tbZoom.Name = "_tbZoom";
         this._tbZoom.TickStyle = System.Windows.Forms.TickStyle.None;
         this._tbZoom.Value = 5;
         this._tbZoom.Scroll += new System.EventHandler(this._tbZoom_Scroll);
         // 
         // _tbPercentage
         // 
         resources.ApplyResources(this._tbPercentage, "_tbPercentage");
         this._tbPercentage.Name = "_tbPercentage";
         this._tbPercentage.TextChanged += new System.EventHandler(this._tbPercentage_TextChanged);
         this._tbPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbPercentage_KeyPress);
         // 
         // _lblZoom
         // 
         this._lblZoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
         resources.ApplyResources(this._lblZoom, "_lblZoom");
         this._lblZoom.Name = "_lblZoom";
         // 
         // ZoomDialog
         // 
         this.AcceptButton = this._btnOk;
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ZoomDialog";
         this.ShowInTaskbar = false;
         this.Load += new System.EventHandler(this.ZoomDialog_Load);
         this._gbOptions.ResumeLayout(false);
         this._gbOptions.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this._tbZoom)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.TrackBar _tbZoom;
      private System.Windows.Forms.TextBox _tbPercentage;
      private System.Windows.Forms.Label _lblZoom;
   }
}