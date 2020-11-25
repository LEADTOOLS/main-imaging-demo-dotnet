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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainDemo
{
   public partial class AttachmentMsgForm : Form
   {
      public AttachmentMsgForm()
      {
         InitializeComponent();
      }

      public string _fileName;
      public int _firstPage;
      public int _lastPage;
      public RasterCodecs _codecs;
      public MainForm _parentForm;

      private void _btnCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         Close();
      }

      private void _btnOpenAttachment_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.OK;
         Close();
         Dispose();

         _parentForm.ShowPdfAttachmentsDialog(_fileName, _codecs);
      }

      private void _btnOpenFile_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.OK;
         Close();

         _parentForm.LoadFile(_fileName, _firstPage, _lastPage, string.Empty);
      }
   }
}
