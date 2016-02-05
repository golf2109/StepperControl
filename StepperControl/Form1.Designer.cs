using System;

namespace StepperControl
{
    partial class Stepper_Control
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OutSerial = new System.Windows.Forms.RichTextBox();
            this.InSerial = new System.Windows.Forms.RichTextBox();
            this.OPEN_COM_Port_Motor = new System.Windows.Forms.Button();
            this.serialPort_stepper = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_COM_Port_Motor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Baudrate_Select = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ADC_Input = new System.Windows.Forms.RichTextBox();
            this.COM_Port_ADC = new System.Windows.Forms.Label();
            this.Select_COM_Port_ADC = new System.Windows.Forms.ComboBox();
            this.START_ADC = new System.Windows.Forms.Button();
            this.STOP_ADC = new System.Windows.Forms.Button();
            this.START_Motor = new System.Windows.Forms.Button();
            this.STOP_Motor = new System.Windows.Forms.Button();
            this.OPEN_ADC_COM_Port = new System.Windows.Forms.Button();
            this.serialPort_ADC = new System.IO.Ports.SerialPort(this.components);
            this.Number_of_step = new System.Windows.Forms.RichTextBox();
            this.BACK = new System.Windows.Forms.Button();
            this.FORWARD = new System.Windows.Forms.Button();
            this.Step_BACK = new System.Windows.Forms.Button();
            this.Step_Forward = new System.Windows.Forms.Button();
            this.Set_ADC_Delay = new System.Windows.Forms.RichTextBox();
            this.ADC_Delay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutSerial
            // 
            this.OutSerial.Location = new System.Drawing.Point(202, 417);
            this.OutSerial.Name = "OutSerial";
            this.OutSerial.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OutSerial.Size = new System.Drawing.Size(184, 18);
            this.OutSerial.TabIndex = 0;
            this.OutSerial.Text = "";
            // 
            // InSerial
            // 
            this.InSerial.Location = new System.Drawing.Point(202, 447);
            this.InSerial.Name = "InSerial";
            this.InSerial.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InSerial.Size = new System.Drawing.Size(184, 18);
            this.InSerial.TabIndex = 1;
            this.InSerial.Text = "";
            // 
            // OPEN_COM_Port_Motor
            // 
            this.OPEN_COM_Port_Motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPEN_COM_Port_Motor.ForeColor = System.Drawing.Color.Green;
            this.OPEN_COM_Port_Motor.Location = new System.Drawing.Point(298, 485);
            this.OPEN_COM_Port_Motor.Name = "OPEN_COM_Port_Motor";
            this.OPEN_COM_Port_Motor.Size = new System.Drawing.Size(143, 23);
            this.OPEN_COM_Port_Motor.TabIndex = 4;
            this.OPEN_COM_Port_Motor.Text = "OPEN Motor COM Port";
            this.OPEN_COM_Port_Motor.UseVisualStyleBackColor = true;
            this.OPEN_COM_Port_Motor.Click += new System.EventHandler(this.OPEN_COM_Port_Motor_Click);
            // 
            // serialPort_stepper
            // 
            this.serialPort_stepper.BaudRate = 19200;
            this.serialPort_stepper.PortName = "COM37";
            this.serialPort_stepper.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_stepper_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Send Bytes Stepper Motor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resived Bytes Stepper Motor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.SettingToolStripMenuItem.Text = "Device";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.Device_InfoToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.InfoToolStripMenuItem.Text = "Info";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // Select_COM_Port_Motor
            // 
            this.Select_COM_Port_Motor.FormattingEnabled = true;
            this.Select_COM_Port_Motor.Location = new System.Drawing.Point(18, 369);
            this.Select_COM_Port_Motor.Name = "Select_COM_Port_Motor";
            this.Select_COM_Port_Motor.Size = new System.Drawing.Size(121, 21);
            this.Select_COM_Port_Motor.TabIndex = 8;
            this.Select_COM_Port_Motor.Text = "Select COM Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "COM Port Stepper Motor";
            // 
            // Baudrate_Select
            // 
            this.Baudrate_Select.FormattingEnabled = true;
            this.Baudrate_Select.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.Baudrate_Select.Location = new System.Drawing.Point(320, 369);
            this.Baudrate_Select.Name = "Baudrate_Select";
            this.Baudrate_Select.Size = new System.Drawing.Size(121, 21);
            this.Baudrate_Select.TabIndex = 10;
            this.Baudrate_Select.Text = "19200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Baudrate Stepper Motor";
            // 
            // ADC_Input
            // 
            this.ADC_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADC_Input.Location = new System.Drawing.Point(18, 64);
            this.ADC_Input.Multiline = false;
            this.ADC_Input.Name = "ADC_Input";
            this.ADC_Input.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ADC_Input.Size = new System.Drawing.Size(239, 71);
            this.ADC_Input.TabIndex = 12;
            this.ADC_Input.Text = "";
            // 
            // COM_Port_ADC
            // 
            this.COM_Port_ADC.AutoSize = true;
            this.COM_Port_ADC.Location = new System.Drawing.Point(299, 64);
            this.COM_Port_ADC.Name = "COM_Port_ADC";
            this.COM_Port_ADC.Size = new System.Drawing.Size(78, 13);
            this.COM_Port_ADC.TabIndex = 13;
            this.COM_Port_ADC.Text = "COM Port ADC";
            // 
            // Select_COM_Port_ADC
            // 
            this.Select_COM_Port_ADC.FormattingEnabled = true;
            this.Select_COM_Port_ADC.Location = new System.Drawing.Point(302, 80);
            this.Select_COM_Port_ADC.Name = "Select_COM_Port_ADC";
            this.Select_COM_Port_ADC.Size = new System.Drawing.Size(121, 21);
            this.Select_COM_Port_ADC.TabIndex = 14;
            this.Select_COM_Port_ADC.Text = "Select COM Port";
            // 
            // START_ADC
            // 
            this.START_ADC.ForeColor = System.Drawing.Color.Green;
            this.START_ADC.Location = new System.Drawing.Point(164, 166);
            this.START_ADC.Name = "START_ADC";
            this.START_ADC.Size = new System.Drawing.Size(93, 23);
            this.START_ADC.TabIndex = 15;
            this.START_ADC.Text = "START ADC";
            this.START_ADC.UseVisualStyleBackColor = true;
            this.START_ADC.Click += new System.EventHandler(this.START_ADC_Click);
            // 
            // STOP_ADC
            // 
            this.STOP_ADC.ForeColor = System.Drawing.Color.Red;
            this.STOP_ADC.Location = new System.Drawing.Point(319, 166);
            this.STOP_ADC.Name = "STOP_ADC";
            this.STOP_ADC.Size = new System.Drawing.Size(93, 23);
            this.STOP_ADC.TabIndex = 16;
            this.STOP_ADC.Text = "STOP ADC";
            this.STOP_ADC.UseVisualStyleBackColor = true;
            this.STOP_ADC.Click += new System.EventHandler(this.STOP_ADC_Click);
            // 
            // START_Motor
            // 
            this.START_Motor.ForeColor = System.Drawing.Color.Green;
            this.START_Motor.Location = new System.Drawing.Point(18, 485);
            this.START_Motor.Name = "START_Motor";
            this.START_Motor.Size = new System.Drawing.Size(110, 23);
            this.START_Motor.TabIndex = 17;
            this.START_Motor.Text = "START Motor";
            this.START_Motor.UseVisualStyleBackColor = true;
            this.START_Motor.Click += new System.EventHandler(this.START_Motor_Click);
            // 
            // STOP_Motor
            // 
            this.STOP_Motor.ForeColor = System.Drawing.Color.Red;
            this.STOP_Motor.Location = new System.Drawing.Point(164, 485);
            this.STOP_Motor.Name = "STOP_Motor";
            this.STOP_Motor.Size = new System.Drawing.Size(93, 23);
            this.STOP_Motor.TabIndex = 18;
            this.STOP_Motor.Text = "STOP Motor";
            this.STOP_Motor.UseVisualStyleBackColor = true;
            this.STOP_Motor.Click += new System.EventHandler(this.STOP_Motor_Click_1);
            // 
            // OPEN_ADC_COM_Port
            // 
            this.OPEN_ADC_COM_Port.ForeColor = System.Drawing.Color.Green;
            this.OPEN_ADC_COM_Port.Location = new System.Drawing.Point(302, 112);
            this.OPEN_ADC_COM_Port.Name = "OPEN_ADC_COM_Port";
            this.OPEN_ADC_COM_Port.Size = new System.Drawing.Size(121, 23);
            this.OPEN_ADC_COM_Port.TabIndex = 19;
            this.OPEN_ADC_COM_Port.Text = "OPEN ADC COM Port";
            this.OPEN_ADC_COM_Port.UseVisualStyleBackColor = true;
            this.OPEN_ADC_COM_Port.Click += new System.EventHandler(this.OPEN_ADC_COM_Port_Click);
            // 
            // serialPort_ADC
            // 
            this.serialPort_ADC.PortName = "COM4";
            this.serialPort_ADC.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_ADC_DataReceived);
            // 
            // Number_of_step
            // 
            this.Number_of_step.Location = new System.Drawing.Point(19, 266);
            this.Number_of_step.Name = "Number_of_step";
            this.Number_of_step.Size = new System.Drawing.Size(110, 21);
            this.Number_of_step.TabIndex = 20;
            this.Number_of_step.Text = "0";
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(164, 308);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(93, 23);
            this.BACK.TabIndex = 22;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // FORWARD
            // 
            this.FORWARD.Location = new System.Drawing.Point(313, 308);
            this.FORWARD.Name = "FORWARD";
            this.FORWARD.Size = new System.Drawing.Size(99, 23);
            this.FORWARD.TabIndex = 23;
            this.FORWARD.Text = "FORWARD";
            this.FORWARD.UseVisualStyleBackColor = true;
            this.FORWARD.Click += new System.EventHandler(this.FORWARD_Click);
            // 
            // Step_BACK
            // 
            this.Step_BACK.Location = new System.Drawing.Point(164, 264);
            this.Step_BACK.Name = "Step_BACK";
            this.Step_BACK.Size = new System.Drawing.Size(93, 23);
            this.Step_BACK.TabIndex = 24;
            this.Step_BACK.Text = "Step BACK";
            this.Step_BACK.UseVisualStyleBackColor = true;
            // 
            // Step_Forward
            // 
            this.Step_Forward.Location = new System.Drawing.Point(313, 264);
            this.Step_Forward.Name = "Step_Forward";
            this.Step_Forward.Size = new System.Drawing.Size(97, 23);
            this.Step_Forward.TabIndex = 25;
            this.Step_Forward.Text = "Step FORWARD";
            this.Step_Forward.UseVisualStyleBackColor = true;
            // 
            // Set_ADC_Delay
            // 
            this.Set_ADC_Delay.Location = new System.Drawing.Point(18, 166);
            this.Set_ADC_Delay.Multiline = false;
            this.Set_ADC_Delay.Name = "Set_ADC_Delay";
            this.Set_ADC_Delay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Set_ADC_Delay.Size = new System.Drawing.Size(110, 23);
            this.Set_ADC_Delay.TabIndex = 26;
            this.Set_ADC_Delay.Text = "100";
            // 
            // ADC_Delay
            // 
            this.ADC_Delay.AutoSize = true;
            this.ADC_Delay.Location = new System.Drawing.Point(15, 150);
            this.ADC_Delay.Name = "ADC_Delay";
            this.ADC_Delay.Size = new System.Drawing.Size(59, 13);
            this.ADC_Delay.TabIndex = 27;
            this.ADC_Delay.Text = "ADC Delay";
            // 
            // Stepper_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 549);
            this.Controls.Add(this.ADC_Delay);
            this.Controls.Add(this.Set_ADC_Delay);
            this.Controls.Add(this.Step_Forward);
            this.Controls.Add(this.Step_BACK);
            this.Controls.Add(this.FORWARD);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.Number_of_step);
            this.Controls.Add(this.OPEN_ADC_COM_Port);
            this.Controls.Add(this.STOP_Motor);
            this.Controls.Add(this.START_Motor);
            this.Controls.Add(this.STOP_ADC);
            this.Controls.Add(this.START_ADC);
            this.Controls.Add(this.Select_COM_Port_ADC);
            this.Controls.Add(this.COM_Port_ADC);
            this.Controls.Add(this.ADC_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Baudrate_Select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Select_COM_Port_Motor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OPEN_COM_Port_Motor);
            this.Controls.Add(this.InSerial);
            this.Controls.Add(this.OutSerial);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Stepper_Control";
            this.Text = "Stepper Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stepper_Control_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutSerial;
        private System.Windows.Forms.RichTextBox InSerial;
        private System.Windows.Forms.Button OPEN_COM_Port_Motor;
        private System.IO.Ports.SerialPort serialPort_stepper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox Select_COM_Port_Motor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Baudrate_Select;
        private System.Windows.Forms.Label label4;
        private EventHandler helpToolStripMenuItem_Click;
        private System.Windows.Forms.Label COM_Port_ADC;
        private System.Windows.Forms.ComboBox Select_COM_Port_ADC;
        private System.Windows.Forms.Button STOP_ADC;
        private System.Windows.Forms.Button START_ADC;
        private System.Windows.Forms.Button STOP_Motor;
        private System.Windows.Forms.Button START_Motor;
        private System.Windows.Forms.Button OPEN_ADC_COM_Port;
        private System.IO.Ports.SerialPort serialPort_ADC;
        public System.Windows.Forms.RichTextBox ADC_Input;
        private System.Windows.Forms.RichTextBox Number_of_step;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button FORWARD;
        private System.Windows.Forms.Button Step_BACK;
        private System.Windows.Forms.Button Step_Forward;
        public System.Windows.Forms.RichTextBox Set_ADC_Delay;
        private System.Windows.Forms.Label ADC_Delay;

        public EventHandler Select_COM_Port_SelectedIndexChanged { get; private set; }
    }
}

