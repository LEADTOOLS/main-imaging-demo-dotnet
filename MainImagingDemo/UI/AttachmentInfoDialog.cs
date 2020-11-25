// *************************************************************
// Copyright (c) 1991-2020 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Leadtools.Codecs;

namespace MainDemo
{
   public partial class AttachmentInfoDialog : Form
   {
      public AttachmentInfoDialog()
      {
         InitializeComponent();
      }

      public void InitDialog(string fileName, CodecsImageInfo codecs)
      {
         _lstInfo.Columns.Add("Item", 100, HorizontalAlignment.Left);
         _lstInfo.Columns.Add("Value", 100, HorizontalAlignment.Left);

         ListViewItem item = new ListViewItem(new[] { "Format", codecs.Format.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Name", fileName });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Width", codecs.Width.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Height", codecs.Height.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Bits Per Pixel", codecs.BitsPerPixel.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Compression", codecs.Compression });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Total Pages", codecs.TotalPages.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "XResolution(DPI)", codecs.XResolution.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "YResolution(DPI)", codecs.YResolution.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Is Portfolio", codecs.IsPortfolio.ToString() });
         _lstInfo.Items.Add(item);

         item = new ListViewItem(new[] { "Attachments Count", codecs.AttachmentCount.ToString() });
         _lstInfo.Items.Add(item);
      }

      private void _btnOk_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
