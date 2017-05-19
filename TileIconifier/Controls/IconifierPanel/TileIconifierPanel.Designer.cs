using TileIconifier.Controls.IconifierPanel.PictureBox;

namespace TileIconifier.Controls.IconifierPanel
{
    partial class TileIconifierPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileIconifierPanel));
            this.pnlImages = new System.Windows.Forms.Panel();
            this.lblUnsaved = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmsPicBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiChangeImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCentreImage = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pannablePictureBox1 = new TileIconifier.Controls.IconifierPanel.PictureBox.PannablePictureBox();
            this.btnReset = new TileIconifier.Controls.SkinnableButton();
            this.colorPanel = new TileIconifier.Controls.IconifierPanel.ColorPanel();
            this.pannablePictureBoxControlPanelSmall = new TileIconifier.Controls.IconifierPanel.PictureBox.PannablePictureBoxControlPanel();
            this.chkUseSameImg = new TileIconifier.Controls.SkinnableCheckBox();
            this.pannablePictureBoxControlPanelMedium = new TileIconifier.Controls.IconifierPanel.PictureBox.PannablePictureBoxControlPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.cmsPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImages
            // 
            resources.ApplyResources(this.pnlImages, "pnlImages");
            this.pnlImages.Name = "pnlImages";
            // 
            // lblUnsaved
            // 
            resources.ApplyResources(this.lblUnsaved, "lblUnsaved");
            this.lblUnsaved.Name = "lblUnsaved";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.colorPanel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblUnsaved, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pannablePictureBoxControlPanelSmall, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkUseSameImg, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pannablePictureBoxControlPanelMedium, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // cmsPicBox
            // 
            this.cmsPicBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiChangeImage,
            this.tmiCentreImage});
            this.cmsPicBox.Name = "cmsPicBox";
            resources.ApplyResources(this.cmsPicBox, "cmsPicBox");
            // 
            // tmiChangeImage
            // 
            this.tmiChangeImage.Name = "tmiChangeImage";
            resources.ApplyResources(this.tmiChangeImage, "tmiChangeImage");
            this.tmiChangeImage.Click += new System.EventHandler(this.tmiChangeImage_Click);
            // 
            // tmiCentreImage
            // 
            this.tmiCentreImage.Name = "tmiCentreImage";
            resources.ApplyResources(this.tmiCentreImage, "tmiCentreImage");
            this.tmiCentreImage.Click += new System.EventHandler(this.tmiCentreImage_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TileIconifier.Properties.Resources.QuestionMark;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pannablePictureBox1
            // 
            resources.ApplyResources(this.pannablePictureBox1, "pannablePictureBox1");
            this.pannablePictureBox1.Name = "pannablePictureBox1";
            this.pannablePictureBox1.OutputSize = new System.Drawing.Size(90, 90);
            this.pannablePictureBox1.TextOverlayLocation = new System.Drawing.Point(0, 0);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // colorPanel
            // 
            resources.ApplyResources(this.colorPanel, "colorPanel");
            this.tableLayoutPanel2.SetColumnSpan(this.colorPanel, 3);
            this.colorPanel.Name = "colorPanel";
            // 
            // pannablePictureBoxControlPanelSmall
            // 
            resources.ApplyResources(this.pannablePictureBoxControlPanelSmall, "pannablePictureBoxControlPanelSmall");
            this.tableLayoutPanel2.SetColumnSpan(this.pannablePictureBoxControlPanelSmall, 2);
            this.pannablePictureBoxControlPanelSmall.ImageOutputSize = new System.Drawing.Size(50, 50);
            this.pannablePictureBoxControlPanelSmall.Name = "pannablePictureBoxControlPanelSmall";
            // 
            // chkUseSameImg
            // 
            resources.ApplyResources(this.chkUseSameImg, "chkUseSameImg");
            this.chkUseSameImg.Checked = true;
            this.chkUseSameImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.chkUseSameImg, 3);
            this.chkUseSameImg.Name = "chkUseSameImg";
            this.chkUseSameImg.UseVisualStyleBackColor = true;
            // 
            // pannablePictureBoxControlPanelMedium
            // 
            resources.ApplyResources(this.pannablePictureBoxControlPanelMedium, "pannablePictureBoxControlPanelMedium");
            this.pannablePictureBoxControlPanelMedium.ImageOutputSize = new System.Drawing.Size(100, 100);
            this.pannablePictureBoxControlPanelMedium.Name = "pannablePictureBoxControlPanelMedium";
            // 
            // TileIconifierPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pannablePictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pnlImages);
            this.Name = "TileIconifierPanel";
            this.Load += new System.EventHandler(this.TileIconifierPanel_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.cmsPicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImages;
        private SkinnableCheckBox chkUseSameImg;
        private PannablePictureBoxControlPanel pannablePictureBoxControlPanelMedium;
        private PannablePictureBoxControlPanel pannablePictureBoxControlPanelSmall;
        private TileIconifier.Controls.SkinnableButton btnReset;
        private System.Windows.Forms.Label lblUnsaved;
        private ColorPanel colorPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip cmsPicBox;
        private System.Windows.Forms.ToolStripMenuItem tmiChangeImage;
        private System.Windows.Forms.ToolStripMenuItem tmiCentreImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PannablePictureBox pannablePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
