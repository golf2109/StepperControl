using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace StepperControl
{
    public partial class Stepper_Control : Form
    {
        public short STEP = 0;          //default number of step
        public byte DIRECTION = 0;      //default DIRECTION 1-forward 0-back
        //public byte[] buffer = { 0 };
        public delegate void SetTextCallback(byte[] buffer, int offset,int count);
        public delegate void SetTextADCCallback(byte dataADC);

        public Stepper_Control()
        {
            InitializeComponent();
            GetPortsNames();
            //set font for direction button
            BACK.Font = new Font(BACK.Font.Name, BACK.Font.Size, FontStyle.Bold);
            FORWARD.Font = new Font(FORWARD.Font.Name, FORWARD.Font.Size, FontStyle.Regular);
            Set_ADC_Delay.SelectionAlignment = HorizontalAlignment.Center;
            Number_of_step.SelectionAlignment = HorizontalAlignment.Center;
        }
        public void GetPortsNames()
        {
            String[] ports = SerialPort.GetPortNames();
            Select_COM_Port_Motor.Items.AddRange(ports);    //set list of COM Port for motor combo box
            Select_COM_Port_ADC.Items.AddRange(ports);      //set list of COM Port for ADC combo box
        }
        //=================================================================================================
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.

        private void serialPort_stepper_DataReceived(object sender_stepper, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[serialPort_stepper.BytesToRead];
            serialPort_stepper.Read(buffer, 0, buffer.Length);
            //SetText(buffer, 0, buffer.Length);
            SetText(buffer, 0, buffer.Length);
        }
        private void SetText(byte[] buffer, int offset, int count)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InSerial.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { buffer, offset, count });
            }
            else
            {
                //Input Bytes in box Resived Bytes
                InSerial.Clear();
                for (int i = 0; i < buffer.Length; i++)
                {
                    InSerial.Text += (buffer[i].ToString("X2") + "  ");
                }
            }
        }
        //************************************************************************
        private void serialPort_ADC_DataReceived(object sender_ADC, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SetTextADC((byte)serialPort_ADC.ReadByte());
        }


        private void SetTextADC(byte dataADC)
        {
            if (ADC_Input.InvokeRequired)
            {
                SetTextADCCallback d1 = new SetTextADCCallback(SetTextADC);
                this.Invoke(d1, new object[] { dataADC });
            }
            else
            {
                //Input Byte in box Resived Bytes
                ADC_Input.Clear();
                ADC_Input.SelectionAlignment = HorizontalAlignment.Center;
                ADC_Input.Text += (dataADC.ToString("X2"));
            }
        }
        //==================================================================================================

        //Press to OPEN ? CLOSE COM Port Stepper Motor
        private void OPEN_COM_Port_Motor_Click(object sender, EventArgs e)
        {

                if (Select_COM_Port_Motor.Text == "Select COM Port")
                {
                    Select_COM_Port_Motor.ForeColor = Color.Red;        //color of text combo box
                    Select_COM_Port_Motor.Text = "Select COM Port";
                }
                else
                {
                    if (!serialPort_stepper.IsOpen)
                    {
                        Select_COM_Port_Motor.ForeColor = Color.Black;
                        serialPort_stepper.PortName = Select_COM_Port_Motor.Text;        /// "COM37";
                        serialPort_stepper.BaudRate = Convert.ToInt32(Baudrate_Select.Text);
                        serialPort_stepper.Parity = System.IO.Ports.Parity.Mark;
                        //                serialPort1.WriteTimeout = 500;
                        serialPort_stepper.Open();
                        OPEN_COM_Port_Motor.ForeColor = Color.Red;        //color of text on botton
                        OPEN_COM_Port_Motor.Text = "CLOSE COM Port";
                    }
                    else
                    {
                        OPEN_COM_Port_Motor.ForeColor = Color.Green;      //color of text on botton
                        OPEN_COM_Port_Motor.Text = "OPEN COM Port";
                        serialPort_stepper.Close();
                    }
                }
        }

        // Exit from programm
        private void Stepper_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort_stepper.IsOpen)
            {
                StopMotor();
                serialPort_stepper.Close();
            }
            else
            {
                serialPort_stepper.Open();
                StopMotor();
                serialPort_stepper.Close();
            }
        }

        // Command START Motor
        private void StartMotor()
        {
            byte[] send00 = { 0x10, 0x00 };
            byte[] send00end = { 0x01, 0x01, 0x12 };
            if (serialPort_stepper.IsOpen)
            {
                //Out byte in Serial Port
                serialPort_stepper.Close();                             
                serialPort_stepper.Parity = System.IO.Ports.Parity.Mark;
                serialPort_stepper.Open();
                serialPort_stepper.Write(send00, 0, 2);
                serialPort_stepper.Close();
                serialPort_stepper.Parity = System.IO.Ports.Parity.Space;
                serialPort_stepper.Open();
                serialPort_stepper.Write(send00end, 0, 3);
                //Out byte in box Send Bytes
                OutSerial.Clear();
                OutSerial.Text += (send00[0].ToString("X2") + "  ");
                OutSerial.Text += (send00[1].ToString("X2") + "  ");
                OutSerial.Text += (send00end[0].ToString("X2") + "  ");
                OutSerial.Text += (send00end[1].ToString("X2") + "  ");
                OutSerial.Text += (send00end[2].ToString("X2") + "  ");
                //OutSerial.Text += ("\r\n");
                //OutSerial.SelectionStart = OutSerial.Text.Length;
                //OutSerial.ScrollToCaret();
                serialPort_stepper.DiscardInBuffer();
            }
        }

        //Command Stop Motor
        private void StopMotor()
        {
            byte[] send01 = { 0x10, 0x01 };
            byte[] send01end = { 0x01, 0x01, 0x13 };

            if (serialPort_stepper.IsOpen)
            {
                //Out byte in Serial Port
                serialPort_stepper.Close();
                serialPort_stepper.Parity = System.IO.Ports.Parity.Mark;
                serialPort_stepper.Open();
                serialPort_stepper.Write(send01, 0, 2);
                serialPort_stepper.Close();
                serialPort_stepper.Parity = System.IO.Ports.Parity.Space;
                serialPort_stepper.Open();
                serialPort_stepper.Write(send01end, 0, 3);
                //Out byte in box Send Bytes
                OutSerial.Clear();
                OutSerial.Text += (send01[0].ToString("X2") + "  ");
                OutSerial.Text += (send01[1].ToString("X2") + "  ");
                OutSerial.Text += (send01end[0].ToString("X2") + "  ");
                OutSerial.Text += (send01end[1].ToString("X2") + "  ");
                OutSerial.Text += (send01end[2].ToString("X2") + "  ");
                //OutSerial.Text += ("\r\n");
                //OutSerial.SelectionStart = OutSerial.Text.Length;
                //OutSerial.ScrollToCaret();
            }
        }

        //Command set rotation  mode
        private void Set_rotation_mode(ushort step, byte mode)
        {
            byte[] send02 = { 0x10, 0x02 };                            //adress module & command code
            byte[] send02end = new byte[6];
            send02end[0] = 0x04;                                       //number byte in command
            send02end[1] = 0x01;                                       //motor number
            send02end[2] = mode;                                       //00 - forward until STOP   01 - forward step number (80,81 - back)  
            send02end[3] = (byte)step;                                 //low byte
            send02end[4] = (byte)(step >> 4);                          //high byte
            send02end[5] = (byte)(send02[0]+send02[1]+send02end[0] + send02end[1] + send02end[2] + send02end[3] + send02end[4]); //check sum
            serialPort_stepper.Close();
            serialPort_stepper.Parity = System.IO.Ports.Parity.Mark;
            serialPort_stepper.Open();
            serialPort_stepper.Write(send02, 0, 2);
            serialPort_stepper.Close();
            serialPort_stepper.Parity = System.IO.Ports.Parity.Space;
            serialPort_stepper.Open();
            serialPort_stepper.Write(send02end, 0, 6);

            OutSerial.Clear();
            OutSerial.Text += (send02[0].ToString("X2") + "  ");
            OutSerial.Text += (send02[1].ToString("X2") + "  ");
            OutSerial.Text += (send02end[0].ToString("X2") + "  ");
            OutSerial.Text += (send02end[1].ToString("X2") + "  ");
            OutSerial.Text += (send02end[2].ToString("X2") + "  ");
            OutSerial.Text += (send02end[3].ToString("X2") + "  ");
            OutSerial.Text += (send02end[4].ToString("X2") + "  ");
            OutSerial.Text += (send02end[5].ToString("X2") + "  ");

            serialPort_stepper.WriteTimeout = 500;
        }

        //Command set perametrs of Motor
        private void Set_step_parameters()
        {
            byte[] send07 = { 0x10, 0x07 };                             //adress module & command code
            byte[] send07end = { 0x03, 0x01, 0x04, 0x00, 0x1F };
            //Out byte in Serial Port
            serialPort_stepper.Close();                                //  Set step parameters
            serialPort_stepper.Parity = System.IO.Ports.Parity.Mark;
            serialPort_stepper.Open();
            serialPort_stepper.Write(send07, 0, 2);
            serialPort_stepper.Close();
            serialPort_stepper.Parity = System.IO.Ports.Parity.Space;
            serialPort_stepper.Open();
            serialPort_stepper.Write(send07end, 0, 5);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopMotor();
            serialPort_stepper.Close();
            Application.Exit();
        }
        
        //Press START Morot
        private void START_Motor_Click(object sender, EventArgs e)
        {
            if (serialPort_stepper.IsOpen)
            {
                Set_step_parameters();
                StartMotor();
            }
        }

        //Press STOP Morot
        private void STOP_Motor_Click_1(object sender, EventArgs e)
        {
            StopMotor();
        }

        private void START_ADC_Click(object sender, EventArgs e)
        {

        }

        private void STOP_ADC_Click(object sender, EventArgs e)
        {

        }

        private void OPEN_ADC_COM_Port_Click(object sender, EventArgs e)
        {
            if (Select_COM_Port_ADC.Text == "Select COM Port")
            {
                Select_COM_Port_ADC.ForeColor = Color.Red;        //color of text combo box
                Select_COM_Port_ADC.Text = "Select COM Port";
            }
            else
            {
                if (!serialPort_ADC.IsOpen)
                {
                    Select_COM_Port_ADC.ForeColor = Color.Black;
                    serialPort_ADC.PortName = Select_COM_Port_ADC.Text;        /// "COM37";
//                    serialPort_ADC.BaudRate = Convert.ToInt32(Baudrate_Select.Text);
//                    serialPort_ADC.Parity = System.IO.Ports.Parity.Mark;
                    //                serialPort1.WriteTimeout = 500;
                    serialPort_ADC.Open();
                    OPEN_ADC_COM_Port.ForeColor = Color.Red;        //color of text on botton
                    OPEN_ADC_COM_Port.Text = "CLOSE COM Port";
                }
                else
                {
                    OPEN_ADC_COM_Port.ForeColor = Color.Green;      //color of text on botton
                    OPEN_ADC_COM_Port.Text = "OPEN COM Port";
                    serialPort_ADC.Close();
                }
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            UInt16 step;
            Byte mode;
            BACK.Font = new Font(BACK.Font.Name, BACK.Font.Size, FontStyle.Bold);
            FORWARD.Font = new Font(FORWARD.Font.Name, FORWARD.Font.Size, FontStyle.Regular);
            step = Convert.ToUInt16(Number_of_step.Text);
            if (step == 0)
            {
                mode = 0;
                DIRECTION = 0;
            }
            else
            {
                mode = 1;
                DIRECTION = 0;
            }
            Set_rotation_mode(step,mode);
        }

        private void FORWARD_Click(object sender, EventArgs e)
        {
            UInt16 step;
            Byte mode;
            BACK.Font = new Font(BACK.Font.Name, BACK.Font.Size, FontStyle.Regular);
            FORWARD.Font = new Font(FORWARD.Font.Name, FORWARD.Font.Size, FontStyle.Bold);
            step = Convert.ToUInt16(Number_of_step.Text);
            if (step == 0)
            {
                mode = 0x80;
                DIRECTION = 1;
            }
            else
            {
                mode = 0x81;
                DIRECTION = 1;
            }
            Set_rotation_mode(step,mode);
        }
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info Autor = new Info();
            Autor.ShowDialog();
        }
        private void Device_InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Device All_serial_port = new Device();
            All_serial_port.ShowDialog();
        }

    }
}
