﻿namespace ISET_2020_Découverte_WinForm
{
    partial class EcranPhilosophes
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
            this.SuspendLayout();
            // 
            // EcranPhilosophes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 441);
            this.Name = "EcranPhilosophes";
            this.Text = "Dîner des philosophes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranPhilosophes_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranDinerPhilosophes_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}