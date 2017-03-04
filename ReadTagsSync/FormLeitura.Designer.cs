using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Impinj.OctaneSdk;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ReadTagsSync
{
    partial class FormLeitura
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxLogomarca = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rTxtPorcen = new System.Windows.Forms.RichTextBox();
            this.rTxtLeituraObtida = new System.Windows.Forms.RichTextBox();
            this.rTxtLeituraEsperada = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto11 = new System.Windows.Forms.PictureBox();
            this.lblQtde11 = new System.Windows.Forms.Label();
            this.lblProduto11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto10 = new System.Windows.Forms.PictureBox();
            this.lblQtde10 = new System.Windows.Forms.Label();
            this.lblProduto10 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto9 = new System.Windows.Forms.PictureBox();
            this.lblQtde9 = new System.Windows.Forms.Label();
            this.lblProduto9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto8 = new System.Windows.Forms.PictureBox();
            this.lblQtde8 = new System.Windows.Forms.Label();
            this.lblProduto8 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto7 = new System.Windows.Forms.PictureBox();
            this.lblQtde7 = new System.Windows.Forms.Label();
            this.lblProduto7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto6 = new System.Windows.Forms.PictureBox();
            this.lblQtde6 = new System.Windows.Forms.Label();
            this.lblProduto6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto5 = new System.Windows.Forms.PictureBox();
            this.lblQtde5 = new System.Windows.Forms.Label();
            this.lblProduto5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto4 = new System.Windows.Forms.PictureBox();
            this.lblQtde4 = new System.Windows.Forms.Label();
            this.lblProduto4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto3 = new System.Windows.Forms.PictureBox();
            this.lblQtde3 = new System.Windows.Forms.Label();
            this.lblProduto3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto2 = new System.Windows.Forms.PictureBox();
            this.lblQtde2 = new System.Windows.Forms.Label();
            this.lblProduto2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto1 = new System.Windows.Forms.PictureBox();
            this.lblQtde1 = new System.Windows.Forms.Label();
            this.lblProduto1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogomarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelProdutos.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto11)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto10)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto9)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto8)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto7)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto6)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto5)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto4)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBoxLogomarca);
            this.panel3.Controls.Add(this.pictureBoxLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 93);
            this.panel3.TabIndex = 0;
            // 
            // pictureBoxLogomarca
            // 
            this.pictureBoxLogomarca.ImageLocation = "C:\\Users\\Luiz\\Documents\\Visual Studio 2010\\Projects\\Octane SDK Labs\\2_ReadTagsSyn" +
                "c\\ReadTagsSync\\img\\logomarca.png";
            this.pictureBoxLogomarca.Location = new System.Drawing.Point(166, 3);
            this.pictureBoxLogomarca.Name = "pictureBoxLogomarca";
            this.pictureBoxLogomarca.Size = new System.Drawing.Size(111, 87);
            this.pictureBoxLogomarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogomarca.TabIndex = 1;
            this.pictureBoxLogomarca.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.ImageLocation = "C:\\Users\\Luiz\\Documents\\Visual Studio 2010\\Projects\\Octane SDK Labs\\2_ReadTagsSyn" +
                "c\\ReadTagsSync\\img\\logo.png";
            this.pictureBoxLogo.Location = new System.Drawing.Point(50, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(110, 87);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 780);
            this.panel1.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.pictureBox3);
            this.panel16.Controls.Add(this.pictureBox2);
            this.panel16.Controls.Add(this.pictureBox1);
            this.panel16.Controls.Add(this.bunifuCustomLabel2);
            this.panel16.Controls.Add(this.rTxtPorcen);
            this.panel16.Controls.Add(this.rTxtLeituraObtida);
            this.panel16.Controls.Add(this.rTxtLeituraEsperada);
            this.panel16.Controls.Add(this.label1);
            this.panel16.Controls.Add(this.bunifuCustomLabel8);
            this.panel16.Controls.Add(this.bunifuCustomLabel4);
            this.panel16.Location = new System.Drawing.Point(62, 107);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(237, 552);
            this.panel16.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "C:\\Users\\Luiz\\Documents\\Visual Studio 2010\\Projects\\Octane SDK Labs\\2_ReadTagsSyn" +
                "c\\ReadTagsSync\\img\\porcentagem.png";
            this.pictureBox3.Location = new System.Drawing.Point(13, 435);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Users\\Luiz\\Documents\\Visual Studio 2010\\Projects\\Octane SDK Labs\\2_ReadTagsSyn" +
                "c\\ReadTagsSync\\img\\qtde.png";
            this.pictureBox2.Location = new System.Drawing.Point(13, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Luiz\\Documents\\Visual Studio 2010\\Projects\\Octane SDK Labs\\2_ReadTagsSyn" +
                "c\\ReadTagsSync\\img\\qtde.png";
            this.pictureBox1.Location = new System.Drawing.Point(13, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(27, 220);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(178, 18);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "N° de Leituras Obtidas";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTxtPorcen
            // 
            this.rTxtPorcen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtPorcen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rTxtPorcen.Location = new System.Drawing.Point(119, 435);
            this.rTxtPorcen.Name = "rTxtPorcen";
            this.rTxtPorcen.ReadOnly = true;
            this.rTxtPorcen.Size = new System.Drawing.Size(104, 71);
            this.rTxtPorcen.TabIndex = 21;
            this.rTxtPorcen.Text = "";
            // 
            // rTxtLeituraObtida
            // 
            this.rTxtLeituraObtida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtLeituraObtida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rTxtLeituraObtida.Location = new System.Drawing.Point(119, 247);
            this.rTxtLeituraObtida.Name = "rTxtLeituraObtida";
            this.rTxtLeituraObtida.ReadOnly = true;
            this.rTxtLeituraObtida.Size = new System.Drawing.Size(104, 72);
            this.rTxtLeituraObtida.TabIndex = 20;
            this.rTxtLeituraObtida.Text = "";
            // 
            // rTxtLeituraEsperada
            // 
            this.rTxtLeituraEsperada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtLeituraEsperada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rTxtLeituraEsperada.Location = new System.Drawing.Point(119, 36);
            this.rTxtLeituraEsperada.Name = "rTxtLeituraEsperada";
            this.rTxtLeituraEsperada.Size = new System.Drawing.Size(104, 71);
            this.rTxtLeituraEsperada.TabIndex = 1;
            this.rTxtLeituraEsperada.Text = "";
            this.rTxtLeituraEsperada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rTxtLeituraEsperada_KeyPress);
            this.rTxtLeituraEsperada.MouseEnter += new System.EventHandler(this.rTxtLeituraEsperada_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(49, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUANTIDADE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(49, 524);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(132, 16);
            this.bunifuCustomLabel8.TabIndex = 16;
            this.bunifuCustomLabel8.Text = "Total de Produtos";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(50, 15);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 18);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Leitura Esperada";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProdutos
            // 
            this.panelProdutos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panelProdutos.Controls.Add(this.panel14);
            this.panelProdutos.Controls.Add(this.panel4);
            this.panelProdutos.Controls.Add(this.panel17);
            this.panelProdutos.Controls.Add(this.panel13);
            this.panelProdutos.Controls.Add(this.panel12);
            this.panelProdutos.Controls.Add(this.panel11);
            this.panelProdutos.Controls.Add(this.panel10);
            this.panelProdutos.Controls.Add(this.panel9);
            this.panelProdutos.Controls.Add(this.panel8);
            this.panelProdutos.Controls.Add(this.panel7);
            this.panelProdutos.Controls.Add(this.panel6);
            this.panelProdutos.Controls.Add(this.panel5);
            this.panelProdutos.Location = new System.Drawing.Point(331, 74);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(926, 585);
            this.panelProdutos.TabIndex = 13;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.pictureBoxProduto11);
            this.panel14.Controls.Add(this.lblQtde11);
            this.panel14.Controls.Add(this.lblProduto11);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 540);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(926, 45);
            this.panel14.TabIndex = 6;
            // 
            // pictureBoxProduto11
            // 
            this.pictureBoxProduto11.ImageLocation = "";
            this.pictureBoxProduto11.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto11.Name = "pictureBoxProduto11";
            this.pictureBoxProduto11.Size = new System.Drawing.Size(100, 45);
            this.pictureBoxProduto11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto11.TabIndex = 33;
            this.pictureBoxProduto11.TabStop = false;
            // 
            // lblQtde11
            // 
            this.lblQtde11.AutoSize = true;
            this.lblQtde11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde11.Location = new System.Drawing.Point(631, 18);
            this.lblQtde11.Name = "lblQtde11";
            this.lblQtde11.Size = new System.Drawing.Size(0, 31);
            this.lblQtde11.TabIndex = 29;
            // 
            // lblProduto11
            // 
            this.lblProduto11.AutoSize = true;
            this.lblProduto11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto11.Location = new System.Drawing.Point(227, 18);
            this.lblProduto11.Name = "lblProduto11";
            this.lblProduto11.Size = new System.Drawing.Size(0, 31);
            this.lblProduto11.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxProduto10);
            this.panel4.Controls.Add(this.lblQtde10);
            this.panel4.Controls.Add(this.lblProduto10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(926, 49);
            this.panel4.TabIndex = 5;
            // 
            // pictureBoxProduto10
            // 
            this.pictureBoxProduto10.ImageLocation = "";
            this.pictureBoxProduto10.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto10.Name = "pictureBoxProduto10";
            this.pictureBoxProduto10.Size = new System.Drawing.Size(100, 49);
            this.pictureBoxProduto10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto10.TabIndex = 32;
            this.pictureBoxProduto10.TabStop = false;
            // 
            // lblQtde10
            // 
            this.lblQtde10.AutoSize = true;
            this.lblQtde10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde10.Location = new System.Drawing.Point(631, 18);
            this.lblQtde10.Name = "lblQtde10";
            this.lblQtde10.Size = new System.Drawing.Size(0, 31);
            this.lblQtde10.TabIndex = 29;
            // 
            // lblProduto10
            // 
            this.lblProduto10.AutoSize = true;
            this.lblProduto10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto10.Location = new System.Drawing.Point(227, 18);
            this.lblProduto10.Name = "lblProduto10";
            this.lblProduto10.Size = new System.Drawing.Size(0, 31);
            this.lblProduto10.TabIndex = 28;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.pictureBoxProduto9);
            this.panel17.Controls.Add(this.lblQtde9);
            this.panel17.Controls.Add(this.lblProduto9);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 442);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(926, 49);
            this.panel17.TabIndex = 4;
            // 
            // pictureBoxProduto9
            // 
            this.pictureBoxProduto9.ImageLocation = "";
            this.pictureBoxProduto9.Location = new System.Drawing.Point(31, 1);
            this.pictureBoxProduto9.Name = "pictureBoxProduto9";
            this.pictureBoxProduto9.Size = new System.Drawing.Size(100, 49);
            this.pictureBoxProduto9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto9.TabIndex = 31;
            this.pictureBoxProduto9.TabStop = false;
            // 
            // lblQtde9
            // 
            this.lblQtde9.AutoSize = true;
            this.lblQtde9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQtde9.Location = new System.Drawing.Point(631, 19);
            this.lblQtde9.Name = "lblQtde9";
            this.lblQtde9.Size = new System.Drawing.Size(0, 31);
            this.lblQtde9.TabIndex = 31;
            // 
            // lblProduto9
            // 
            this.lblProduto9.AutoSize = true;
            this.lblProduto9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto9.Location = new System.Drawing.Point(227, 19);
            this.lblProduto9.Name = "lblProduto9";
            this.lblProduto9.Size = new System.Drawing.Size(0, 31);
            this.lblProduto9.TabIndex = 30;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel13.Controls.Add(this.pictureBoxProduto8);
            this.panel13.Controls.Add(this.lblQtde8);
            this.panel13.Controls.Add(this.lblProduto8);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 393);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(926, 49);
            this.panel13.TabIndex = 1;
            // 
            // pictureBoxProduto8
            // 
            this.pictureBoxProduto8.ImageLocation = "";
            this.pictureBoxProduto8.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto8.Name = "pictureBoxProduto8";
            this.pictureBoxProduto8.Size = new System.Drawing.Size(100, 49);
            this.pictureBoxProduto8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto8.TabIndex = 30;
            this.pictureBoxProduto8.TabStop = false;
            // 
            // lblQtde8
            // 
            this.lblQtde8.AutoSize = true;
            this.lblQtde8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde8.Location = new System.Drawing.Point(631, 19);
            this.lblQtde8.Name = "lblQtde8";
            this.lblQtde8.Size = new System.Drawing.Size(0, 31);
            this.lblQtde8.TabIndex = 30;
            // 
            // lblProduto8
            // 
            this.lblProduto8.AutoSize = true;
            this.lblProduto8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto8.Location = new System.Drawing.Point(227, 19);
            this.lblProduto8.Name = "lblProduto8";
            this.lblProduto8.Size = new System.Drawing.Size(0, 31);
            this.lblProduto8.TabIndex = 29;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.pictureBoxProduto7);
            this.panel12.Controls.Add(this.lblQtde7);
            this.panel12.Controls.Add(this.lblProduto7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 344);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(926, 49);
            this.panel12.TabIndex = 1;
            // 
            // pictureBoxProduto7
            // 
            this.pictureBoxProduto7.ImageLocation = "";
            this.pictureBoxProduto7.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto7.Name = "pictureBoxProduto7";
            this.pictureBoxProduto7.Size = new System.Drawing.Size(100, 49);
            this.pictureBoxProduto7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto7.TabIndex = 29;
            this.pictureBoxProduto7.TabStop = false;
            // 
            // lblQtde7
            // 
            this.lblQtde7.AutoSize = true;
            this.lblQtde7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde7.Location = new System.Drawing.Point(631, 19);
            this.lblQtde7.Name = "lblQtde7";
            this.lblQtde7.Size = new System.Drawing.Size(0, 31);
            this.lblQtde7.TabIndex = 29;
            // 
            // lblProduto7
            // 
            this.lblProduto7.AutoSize = true;
            this.lblProduto7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto7.Location = new System.Drawing.Point(227, 19);
            this.lblProduto7.Name = "lblProduto7";
            this.lblProduto7.Size = new System.Drawing.Size(0, 31);
            this.lblProduto7.TabIndex = 28;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Controls.Add(this.pictureBoxProduto6);
            this.panel11.Controls.Add(this.lblQtde6);
            this.panel11.Controls.Add(this.lblProduto6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 295);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(926, 49);
            this.panel11.TabIndex = 1;
            // 
            // pictureBoxProduto6
            // 
            this.pictureBoxProduto6.ImageLocation = "";
            this.pictureBoxProduto6.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto6.Name = "pictureBoxProduto6";
            this.pictureBoxProduto6.Size = new System.Drawing.Size(100, 49);
            this.pictureBoxProduto6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto6.TabIndex = 28;
            this.pictureBoxProduto6.TabStop = false;
            // 
            // lblQtde6
            // 
            this.lblQtde6.AutoSize = true;
            this.lblQtde6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde6.Location = new System.Drawing.Point(631, 19);
            this.lblQtde6.Name = "lblQtde6";
            this.lblQtde6.Size = new System.Drawing.Size(0, 31);
            this.lblQtde6.TabIndex = 28;
            // 
            // lblProduto6
            // 
            this.lblProduto6.AutoSize = true;
            this.lblProduto6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto6.Location = new System.Drawing.Point(227, 19);
            this.lblProduto6.Name = "lblProduto6";
            this.lblProduto6.Size = new System.Drawing.Size(0, 31);
            this.lblProduto6.TabIndex = 27;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.pictureBoxProduto5);
            this.panel10.Controls.Add(this.lblQtde5);
            this.panel10.Controls.Add(this.lblProduto5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 246);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(926, 49);
            this.panel10.TabIndex = 2;
            // 
            // pictureBoxProduto5
            // 
            this.pictureBoxProduto5.ImageLocation = "";
            this.pictureBoxProduto5.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto5.Name = "pictureBoxProduto5";
            this.pictureBoxProduto5.Size = new System.Drawing.Size(100, 49);
            this.pictureBoxProduto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto5.TabIndex = 27;
            this.pictureBoxProduto5.TabStop = false;
            // 
            // lblQtde5
            // 
            this.lblQtde5.AutoSize = true;
            this.lblQtde5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde5.Location = new System.Drawing.Point(631, 19);
            this.lblQtde5.Name = "lblQtde5";
            this.lblQtde5.Size = new System.Drawing.Size(0, 31);
            this.lblQtde5.TabIndex = 27;
            // 
            // lblProduto5
            // 
            this.lblProduto5.AutoSize = true;
            this.lblProduto5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto5.Location = new System.Drawing.Point(227, 19);
            this.lblProduto5.Name = "lblProduto5";
            this.lblProduto5.Size = new System.Drawing.Size(0, 31);
            this.lblProduto5.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.pictureBoxProduto4);
            this.panel9.Controls.Add(this.lblQtde4);
            this.panel9.Controls.Add(this.lblProduto4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 197);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(926, 49);
            this.panel9.TabIndex = 1;
            // 
            // pictureBoxProduto4
            // 
            this.pictureBoxProduto4.ImageLocation = "";
            this.pictureBoxProduto4.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto4.Name = "pictureBoxProduto4";
            this.pictureBoxProduto4.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxProduto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto4.TabIndex = 25;
            this.pictureBoxProduto4.TabStop = false;
            // 
            // lblQtde4
            // 
            this.lblQtde4.AutoSize = true;
            this.lblQtde4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde4.Location = new System.Drawing.Point(631, 19);
            this.lblQtde4.Name = "lblQtde4";
            this.lblQtde4.Size = new System.Drawing.Size(0, 31);
            this.lblQtde4.TabIndex = 26;
            // 
            // lblProduto4
            // 
            this.lblProduto4.AutoSize = true;
            this.lblProduto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto4.Location = new System.Drawing.Point(227, 19);
            this.lblProduto4.Name = "lblProduto4";
            this.lblProduto4.Size = new System.Drawing.Size(0, 31);
            this.lblProduto4.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.pictureBoxProduto3);
            this.panel8.Controls.Add(this.lblQtde3);
            this.panel8.Controls.Add(this.lblProduto3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 148);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(926, 49);
            this.panel8.TabIndex = 1;
            // 
            // pictureBoxProduto3
            // 
            this.pictureBoxProduto3.ImageLocation = "";
            this.pictureBoxProduto3.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto3.Name = "pictureBoxProduto3";
            this.pictureBoxProduto3.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxProduto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto3.TabIndex = 24;
            this.pictureBoxProduto3.TabStop = false;
            // 
            // lblQtde3
            // 
            this.lblQtde3.AutoSize = true;
            this.lblQtde3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde3.Location = new System.Drawing.Point(631, 19);
            this.lblQtde3.Name = "lblQtde3";
            this.lblQtde3.Size = new System.Drawing.Size(0, 31);
            this.lblQtde3.TabIndex = 23;
            // 
            // lblProduto3
            // 
            this.lblProduto3.AutoSize = true;
            this.lblProduto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto3.Location = new System.Drawing.Point(215, 19);
            this.lblProduto3.Name = "lblProduto3";
            this.lblProduto3.Size = new System.Drawing.Size(0, 31);
            this.lblProduto3.TabIndex = 20;
            this.lblProduto3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.pictureBoxProduto2);
            this.panel7.Controls.Add(this.lblQtde2);
            this.panel7.Controls.Add(this.lblProduto2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(926, 49);
            this.panel7.TabIndex = 1;
            // 
            // pictureBoxProduto2
            // 
            this.pictureBoxProduto2.ImageLocation = "";
            this.pictureBoxProduto2.Location = new System.Drawing.Point(31, -1);
            this.pictureBoxProduto2.Name = "pictureBoxProduto2";
            this.pictureBoxProduto2.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxProduto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto2.TabIndex = 23;
            this.pictureBoxProduto2.TabStop = false;
            // 
            // lblQtde2
            // 
            this.lblQtde2.AutoSize = true;
            this.lblQtde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde2.Location = new System.Drawing.Point(631, 18);
            this.lblQtde2.Name = "lblQtde2";
            this.lblQtde2.Size = new System.Drawing.Size(0, 31);
            this.lblQtde2.TabIndex = 22;
            // 
            // lblProduto2
            // 
            this.lblProduto2.AutoSize = true;
            this.lblProduto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto2.Location = new System.Drawing.Point(221, 19);
            this.lblProduto2.Name = "lblProduto2";
            this.lblProduto2.Size = new System.Drawing.Size(0, 31);
            this.lblProduto2.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBoxProduto1);
            this.panel6.Controls.Add(this.lblQtde1);
            this.panel6.Controls.Add(this.lblProduto1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(926, 49);
            this.panel6.TabIndex = 1;
            // 
            // pictureBoxProduto1
            // 
            this.pictureBoxProduto1.ImageLocation = "";
            this.pictureBoxProduto1.Location = new System.Drawing.Point(31, 0);
            this.pictureBoxProduto1.Name = "pictureBoxProduto1";
            this.pictureBoxProduto1.Size = new System.Drawing.Size(100, 49);
            this.pictureBoxProduto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto1.TabIndex = 22;
            this.pictureBoxProduto1.TabStop = false;
            // 
            // lblQtde1
            // 
            this.lblQtde1.AutoSize = true;
            this.lblQtde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde1.Location = new System.Drawing.Point(631, 12);
            this.lblQtde1.Name = "lblQtde1";
            this.lblQtde1.Size = new System.Drawing.Size(0, 31);
            this.lblQtde1.TabIndex = 21;
            // 
            // lblProduto1
            // 
            this.lblProduto1.AutoSize = true;
            this.lblProduto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto1.Location = new System.Drawing.Point(215, 12);
            this.lblProduto1.Name = "lblProduto1";
            this.lblProduto1.Size = new System.Drawing.Size(0, 31);
            this.lblProduto1.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Controls.Add(this.bunifuCustomLabel14);
            this.panel5.Controls.Add(this.bunifuCustomLabel10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(926, 50);
            this.panel5.TabIndex = 0;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(581, 10);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(167, 33);
            this.bunifuCustomLabel14.TabIndex = 19;
            this.bunifuCustomLabel14.Text = "QUANTIDADE";
            this.bunifuCustomLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(299, 10);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(127, 33);
            this.bunifuCustomLabel10.TabIndex = 18;
            this.bunifuCustomLabel10.Text = "PRODUTO";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuCustomLabel13);
            this.panel2.Controls.Add(this.bunifuCustomLabel12);
            this.panel2.Location = new System.Drawing.Point(331, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 75);
            this.panel2.TabIndex = 12;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(879, 0);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(21, 25);
            this.bunifuCustomLabel13.TabIndex = 1;
            this.bunifuCustomLabel13.Text = "-";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(900, 0);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(26, 25);
            this.bunifuCustomLabel12.TabIndex = 0;
            this.bunifuCustomLabel12.Text = "X";
            this.bunifuCustomLabel12.Click += new System.EventHandler(this.bunifuCustomLabel12_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(1085, 707);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 61);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Gray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(896, 707);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(172, 61);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FormLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelProdutos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLeitura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLeitura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLeitura_Load);
            this.Shown += new System.EventHandler(this.FormLeitura_Shown);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogomarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelProdutos.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto11)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto10)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto9)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto8)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto7)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto6)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto5)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto4)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProduto3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.Label lblProduto1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProduto2;
        private System.Windows.Forms.Label lblProduto8;
        private System.Windows.Forms.Label lblProduto7;
        private System.Windows.Forms.Label lblProduto6;
        private System.Windows.Forms.Label lblProduto5;
        private System.Windows.Forms.Label lblProduto4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblQtde8;
        private System.Windows.Forms.Label lblQtde7;
        private System.Windows.Forms.Label lblQtde6;
        private System.Windows.Forms.Label lblQtde5;
        private System.Windows.Forms.Label lblQtde4;
        private System.Windows.Forms.Label lblQtde3;
        private System.Windows.Forms.Label lblQtde2;
        private System.Windows.Forms.Label lblQtde1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblQtde10;
        private System.Windows.Forms.Label lblProduto10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblQtde11;
        private System.Windows.Forms.Label lblProduto11;
        private System.Windows.Forms.Label lblQtde9;
        private System.Windows.Forms.Label lblProduto9;
        private System.Windows.Forms.RichTextBox rTxtLeituraEsperada;
        private System.Windows.Forms.RichTextBox rTxtLeituraObtida;
        private System.Windows.Forms.RichTextBox rTxtPorcen;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxLogomarca;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxProduto1;
        private PictureBox pictureBoxProduto11;
        private PictureBox pictureBoxProduto10;
        private PictureBox pictureBoxProduto9;
        private PictureBox pictureBoxProduto8;
        private PictureBox pictureBoxProduto7;
        private PictureBox pictureBoxProduto6;
        private PictureBox pictureBoxProduto5;
        private PictureBox pictureBoxProduto4;
        private PictureBox pictureBoxProduto3;
        private PictureBox pictureBoxProduto2;
    }
}