#region Copyright (c) IFS Research & Development
//
//                 IFS Research & Development
//
//  This program is protected by copyright law and by international
//  conventions. All licensing, renting, lending or copying (including
//  for private use), and all other use of the program, which is not
//  explicitly permitted by IFS, is a violation of the rights
//  of IFS. Such violations will be reported to the
//  appropriate authorities.
//
//  VIOLATIONS OF ANY COPYRIGHT IS PUNISHABLE BY LAW AND CAN LEAD
//  TO UP TO TWO YEARS OF IMPRISONMENT AND LIABILITY TO PAY DAMAGES.
#endregion
#region History
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ifs.Fnd.ApplicationForms;
using PPJ.Runtime;
using PPJ.Runtime.Windows;

namespace Ifs.Application.TestOne
{

    public partial class frm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dfsOrderNo = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelOrderNo = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfsVendorNo = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelVendorNo = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfsContract = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelContract = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.cChildTable1 = new Ifs.Fnd.ApplicationForms.cChildTable();
            this.SuspendLayout();
            // 
            // dfsOrderNo
            // 
            this.dfsOrderNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dfsOrderNo.Location = new System.Drawing.Point(28, 45);
            this.dfsOrderNo.MaxLength = 12;
            this.dfsOrderNo.Name = "dfsOrderNo";
            this.dfsOrderNo.NamedProperties.Put("EnumerateMethod", "");
            this.dfsOrderNo.NamedProperties.Put("FieldFlags", "162");
            this.dfsOrderNo.NamedProperties.Put("LovReference", "");
            this.dfsOrderNo.NamedProperties.Put("SqlColumn", "ORDER_NO");
            this.dfsOrderNo.Size = new System.Drawing.Size(134, 21);
            this.dfsOrderNo.TabIndex = 1;
            // 
            // labelOrderNo
            // 
            this.labelOrderNo.AutoSize = true;
            this.labelOrderNo.Location = new System.Drawing.Point(25, 29);
            this.labelOrderNo.Name = "labelOrderNo";
            this.labelOrderNo.Size = new System.Drawing.Size(55, 13);
            this.labelOrderNo.TabIndex = 0;
            this.labelOrderNo.Text = "Order No:";
            // 
            // dfsVendorNo
            // 
            this.dfsVendorNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dfsVendorNo.Location = new System.Drawing.Point(199, 45);
            this.dfsVendorNo.MaxLength = 20;
            this.dfsVendorNo.Name = "dfsVendorNo";
            this.dfsVendorNo.NamedProperties.Put("EnumerateMethod", "");
            this.dfsVendorNo.NamedProperties.Put("FieldFlags", "295");
            this.dfsVendorNo.NamedProperties.Put("LovReference", "SUPPLIER");
            this.dfsVendorNo.NamedProperties.Put("SqlColumn", "VENDOR_NO");
            this.dfsVendorNo.Size = new System.Drawing.Size(134, 21);
            this.dfsVendorNo.TabIndex = 3;
            // 
            // labelVendorNo
            // 
            this.labelVendorNo.AutoSize = true;
            this.labelVendorNo.Location = new System.Drawing.Point(196, 29);
            this.labelVendorNo.Name = "labelVendorNo";
            this.labelVendorNo.Size = new System.Drawing.Size(49, 13);
            this.labelVendorNo.TabIndex = 2;
            this.labelVendorNo.Text = "Supplier:";
            // 
            // dfsContract
            // 
            this.dfsContract.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dfsContract.Location = new System.Drawing.Point(373, 45);
            this.dfsContract.MaxLength = 5;
            this.dfsContract.Name = "dfsContract";
            this.dfsContract.NamedProperties.Put("EnumerateMethod", "");
            this.dfsContract.NamedProperties.Put("FieldFlags", "291");
            this.dfsContract.NamedProperties.Put("LovReference", "SITE");
            this.dfsContract.NamedProperties.Put("SqlColumn", "CONTRACT");
            this.dfsContract.Size = new System.Drawing.Size(134, 21);
            this.dfsContract.TabIndex = 5;
            // 
            // labelContract
            // 
            this.labelContract.AutoSize = true;
            this.labelContract.Location = new System.Drawing.Point(370, 29);
            this.labelContract.Name = "labelContract";
            this.labelContract.Size = new System.Drawing.Size(29, 13);
            this.labelContract.TabIndex = 4;
            this.labelContract.Text = "Site:";
            // 
            // cChildTable1
            // 
            this.cChildTable1.Location = new System.Drawing.Point(28, 94);
            this.cChildTable1.Name = "cChildTable1";
            this.cChildTable1.NamedProperties.Put("LogicalUnit", "PurchaseOrderLinePart");
            this.cChildTable1.NamedProperties.Put("PackageName", "PURCHASE_ORDER_LINE_PART_API");
            this.cChildTable1.NamedProperties.Put("ViewName", "PURCHASE_ORDER_LINE_PART");
            this.cChildTable1.Size = new System.Drawing.Size(1069, 508);
            this.cChildTable1.TabIndex = 6;
            // 
            // frm
            // 
            this.ClientSize = new System.Drawing.Size(1126, 627);
            this.Controls.Add(this.cChildTable1);
            this.Controls.Add(this.dfsContract);
            this.Controls.Add(this.labelContract);
            this.Controls.Add(this.dfsVendorNo);
            this.Controls.Add(this.labelVendorNo);
            this.Controls.Add(this.dfsOrderNo);
            this.Controls.Add(this.labelOrderNo);
            this.Name = "frm";
            this.NamedProperties.Put("LogicalUnit", "PurchaseOrder");
            this.NamedProperties.Put("PackageName", "PURCHASE_ORDER_API");
            this.NamedProperties.Put("ViewName", "PURCHASE_ORDER");
            this.Text = "Orden de venta Personalizada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region System Methods/Properties

        /// <summary>
        /// Release global reference.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        protected cDataField dfsOrderNo;
        protected cBackgroundText labelOrderNo;
        protected cDataField dfsVendorNo;
        protected cBackgroundText labelVendorNo;
        protected cDataField dfsContract;
        protected cBackgroundText labelContract;
        private cChildTable cChildTable1;

    }
}
