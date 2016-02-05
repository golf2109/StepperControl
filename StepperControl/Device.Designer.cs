namespace StepperControl
{
    partial class Device
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
            this.DeviceBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DeviceBox
            // 
            this.DeviceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeviceBox.Location = new System.Drawing.Point(12, 12);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(296, 428);
            this.DeviceBox.TabIndex = 0;
            this.DeviceBox.Text = "";
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 451);
            this.Controls.Add(this.DeviceBox);
            this.Name = "Device";
            this.Text = "Device";
            this.Load += new System.EventHandler(this.Device_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DeviceBox;
    }
}