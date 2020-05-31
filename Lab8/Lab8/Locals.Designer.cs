namespace Lab8
{
    partial class Locals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locals));
            this.AllPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImageAllPanel = new System.Windows.Forms.Panel();
            this.AllTextBox = new System.Windows.Forms.RichTextBox();
            this.AllPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPanel
            // 
            this.AllPanel.BackColor = System.Drawing.Color.Black;
            this.AllPanel.ColumnCount = 3;
            this.AllPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AllPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.AllPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AllPanel.Controls.Add(this.ImageAllPanel, 1, 0);
            this.AllPanel.Controls.Add(this.AllTextBox, 1, 1);
            this.AllPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPanel.Location = new System.Drawing.Point(0, 0);
            this.AllPanel.Name = "AllPanel";
            this.AllPanel.RowCount = 3;
            this.AllPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.44444F));
            this.AllPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.55556F));
            this.AllPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AllPanel.Size = new System.Drawing.Size(800, 450);
            this.AllPanel.TabIndex = 4;
            this.AllPanel.Visible = false;
            // 
            // ImageAllPanel
            // 
            this.ImageAllPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageAllPanel.BackgroundImage")));
            this.ImageAllPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageAllPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageAllPanel.Location = new System.Drawing.Point(123, 3);
            this.ImageAllPanel.Name = "ImageAllPanel";
            this.ImageAllPanel.Size = new System.Drawing.Size(554, 90);
            this.ImageAllPanel.TabIndex = 1;
            // 
            // AllTextBox
            // 
            this.AllTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AllTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTextBox.Location = new System.Drawing.Point(123, 99);
            this.AllTextBox.Name = "AllTextBox";
            this.AllTextBox.ReadOnly = true;
            this.AllTextBox.Size = new System.Drawing.Size(554, 327);
            this.AllTextBox.TabIndex = 3;
            this.AllTextBox.Text = "";
            // 
            // Locals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Locals";
            this.Text = "Todos los locales";
            this.Load += new System.EventHandler(this.Locals_Load);
            this.AllPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AllPanel;
        private System.Windows.Forms.Panel ImageAllPanel;
        private System.Windows.Forms.RichTextBox AllTextBox;
    }
}