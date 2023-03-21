namespace Pizzatilaus
{
    partial class Form1
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tilausTAB = new System.Windows.Forms.TabPage();
            this.vahvistaTAB = new System.Windows.Forms.TabPage();
            this.maksuTAB = new System.Windows.Forms.TabPage();
            this.tabcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tilausTAB);
            this.tabcontrol.Controls.Add(this.vahvistaTAB);
            this.tabcontrol.Controls.Add(this.maksuTAB);
            this.tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol.Location = new System.Drawing.Point(12, 162);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1137, 507);
            this.tabcontrol.TabIndex = 0;
            // 
            // tilausTAB
            // 
            this.tilausTAB.Location = new System.Drawing.Point(4, 33);
            this.tilausTAB.Name = "tilausTAB";
            this.tilausTAB.Padding = new System.Windows.Forms.Padding(3);
            this.tilausTAB.Size = new System.Drawing.Size(1129, 470);
            this.tilausTAB.TabIndex = 0;
            this.tilausTAB.Text = "Tilaus";
            this.tilausTAB.UseVisualStyleBackColor = true;
            // 
            // vahvistaTAB
            // 
            this.vahvistaTAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vahvistaTAB.Location = new System.Drawing.Point(4, 33);
            this.vahvistaTAB.Name = "vahvistaTAB";
            this.vahvistaTAB.Padding = new System.Windows.Forms.Padding(3);
            this.vahvistaTAB.Size = new System.Drawing.Size(1129, 436);
            this.vahvistaTAB.TabIndex = 1;
            this.vahvistaTAB.Text = "Vahvista";
            this.vahvistaTAB.UseVisualStyleBackColor = true;
            // 
            // maksuTAB
            // 
            this.maksuTAB.Location = new System.Drawing.Point(4, 33);
            this.maksuTAB.Name = "maksuTAB";
            this.maksuTAB.Padding = new System.Windows.Forms.Padding(3);
            this.maksuTAB.Size = new System.Drawing.Size(1129, 436);
            this.maksuTAB.TabIndex = 2;
            this.maksuTAB.Text = "Maksu";
            this.maksuTAB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 681);
            this.Controls.Add(this.tabcontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabcontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tilausTAB;
        private System.Windows.Forms.TabPage vahvistaTAB;
        private System.Windows.Forms.TabPage maksuTAB;
    }
}

