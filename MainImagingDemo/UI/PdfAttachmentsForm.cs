// *************************************************************
// Copyright (c) 1991-2020 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************

using Leadtools.Codecs;
using Leadtools.Demos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainDemo
{
   public partial class PdfAttachmentsForm : Form
   {
      public PdfAttachmentsForm()
      {
         InitializeComponent();
      }

      public string _fileName;
      public RasterCodecs _codecs;
      public MainForm _parent;

      struct AttachmentColumnHeader
      {
         public AttachmentColumnHeader(string columnName, int columnWidth)
         {
            _columnName = columnName;
            _columnWidth = columnWidth;
         }

         public string _columnName;
         public int _columnWidth;
      }

      AttachmentColumnHeader[] _attachmentColumnHeaders = {
         new AttachmentColumnHeader("Display Name", 300),
         new AttachmentColumnHeader("Sub Attachment", 100),
         new AttachmentColumnHeader("Date", 150),
         new AttachmentColumnHeader("Is Portfolio", 100),
         new AttachmentColumnHeader("Size", 100),
         new AttachmentColumnHeader("Description", 500)
      };

      public void InitDialog(string fileName, RasterCodecs codecs)
      {
         _lstAttachments.View = View.Details;
         _fileName = fileName;
         _codecs = codecs;

         foreach (AttachmentColumnHeader columnHeader in _attachmentColumnHeaders)
            _lstAttachments.Columns.Add(columnHeader._columnName, columnHeader._columnWidth, HorizontalAlignment.Left);

         CodecsAttachments attachments = codecs.ReadAttachments(fileName);
         int attachmentNumber = 0;
         foreach(CodecsAttachment attachment in attachments)
         {
            attachmentNumber++;
            double fileSize = attachment.FileLength / 1024.0;

            string tempPath = Path.GetTempPath();
            string tempAttachmentFile = Path.Combine(Path.GetTempPath(), string.Format("LT_CS_{0}.tmp", attachment.FileName));

            ExtractAttachmentFile(tempAttachmentFile, attachmentNumber);

            CodecsImageInfo info = null;
            try
            {
               info = codecs.GetInformation(tempAttachmentFile, true);
            }
            catch { }

            ListViewItem item = new ListViewItem(new[] { attachment.DisplayName, (info != null) ? ((info.AttachmentCount > 0) ? "Yes" : "No") : "No", attachment.TimeModified.ToString(), (info != null) ? info.IsPortfolio.ToString() : "No", fileSize.ToString("N") + " KB", attachment.Description });
            _lstAttachments.Items.Add(item);

            if (File.Exists(tempAttachmentFile))
               File.Delete(tempAttachmentFile);

            if (info != null)
               info.Dispose();
         }
      }

      private void _btnClose_Click(object sender, EventArgs e)
      {
         Close();
         DialogResult = DialogResult.Cancel;
      }

      private void _btnInfo_Click(object sender, EventArgs e)
      {
         if (_lstAttachments.SelectedItems.Count > 0)
         {
            int selectedIndex = _lstAttachments.SelectedIndices[0];
            AttachmentInfoDialog attachmentInfoDlg = new AttachmentInfoDialog();

            string attachmentFileName = _lstAttachments.Items[selectedIndex].Text;

            string tempPath = Path.GetTempPath();
            string tempAttachmentFile = Path.Combine(Path.GetTempPath(), string.Format("LT_CS_{0}.tmp", attachmentFileName));

            ExtractAttachmentFile(tempAttachmentFile, selectedIndex + 1);

            try
            {
               using (CodecsImageInfo info = _codecs.GetInformation(tempAttachmentFile, true))
               {
                  attachmentInfoDlg.InitDialog(attachmentFileName, info);
                  attachmentInfoDlg.ShowDialog(this);
               }
            }
            catch (Exception ex)
            {
               Messager.ShowError(this, ex);
            }

            if (File.Exists(tempAttachmentFile))
               File.Delete(tempAttachmentFile);
         }
         else
            Messager.ShowWarning(this, "No selected attachment!");
      }

      private bool ExtractAttachmentFile(string attachmentFileName, int attachmentNumber)
      {
         try
         {
            _codecs.ExtractAttachment(_fileName, attachmentNumber, attachmentFileName);
            return true;
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }

         return false;
      }

      private void _btnExtract_Click(object sender, EventArgs e)
      {
         if (_lstAttachments.SelectedItems.Count > 0)
         {
            int selectedIndex = _lstAttachments.SelectedIndices[0];
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = _lstAttachments.Items[selectedIndex].Text;

            string attachmentExt = Path.GetExtension(saveFileDialog.FileName);

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
               string extractedFileName = saveFileDialog.FileName;
               string ext = Path.GetExtension(extractedFileName);
               if (String.IsNullOrEmpty(ext))
                  extractedFileName = String.Format("{0}{1}", saveFileDialog.FileName , attachmentExt);

               if (ExtractAttachmentFile(extractedFileName, selectedIndex + 1))
                  Messager.ShowInformation(this, "The selected attachment extracted sucessfully");
            }
         }
         else
            Messager.ShowWarning(this, "No selected attachment!");
      }

      private void _lstAttachments_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         OpenSelectedAttachment();
      }

      private void OpenSelectedAttachment()
      {
         if (_lstAttachments.SelectedItems.Count > 0)
         {
            int selectedIndex = _lstAttachments.SelectedIndices[0];

            string attahmentFileName = _lstAttachments.Items[selectedIndex].Text;
            string tempPath = Path.GetTempPath();
            string tempAttachmentFile = Path.Combine(Path.GetTempPath(), string.Format("LT_CS_{0}.tmp", attahmentFileName));

            if (File.Exists(tempAttachmentFile))
               File.Delete(tempAttachmentFile);

            ExtractAttachmentFile(tempAttachmentFile, selectedIndex + 1);

            if (File.Exists(tempAttachmentFile))
            {
               try
               {
                  using (CodecsImageInfo info = _codecs.GetInformation(tempAttachmentFile, true))
                  {
                     if (info.AttachmentCount > 0)
                     {
                        if (info.IsPortfolio)
                        {
                           PortfolioMsgForm portfolioMsgFrm = new PortfolioMsgForm();
                           portfolioMsgFrm._fileName = tempAttachmentFile;
                           portfolioMsgFrm._codecs = _codecs;
                           portfolioMsgFrm._parentForm = _parent;
                           portfolioMsgFrm.ShowDialog(this);
                        }
                        else
                        {
                           AttachmentMsgForm attachmentMsgFrm = new AttachmentMsgForm();
                           attachmentMsgFrm._fileName = tempAttachmentFile;
                           attachmentMsgFrm._firstPage = 1;
                           attachmentMsgFrm._lastPage = info.TotalPages;
                           attachmentMsgFrm._codecs = _codecs;
                           attachmentMsgFrm._parentForm = _parent;

                           attachmentMsgFrm.ShowDialog(this);
                        }
                     }
                     else
                     {
                        _parent.LoadFile(tempAttachmentFile, 1, info.TotalPages, attahmentFileName);
                     }
                  }
               }
               catch (Exception ex)
               {
                  Messager.ShowError(this, ex);
               }

               File.Delete(tempAttachmentFile);
            }
         }
         else
            MessageBox.Show(this, "No selected attachment!", "Notice!");
      }

      private void _btnOpenAttachment_Click(object sender, EventArgs e)
      {
         OpenSelectedAttachment();
      }
   }
}
