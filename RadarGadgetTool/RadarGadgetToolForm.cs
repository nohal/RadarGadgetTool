using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace RadarGadgetTool
{
    public partial class RadarGadgetToolForm : Form
    {
        // The main control for communicating through the RS-232 port
        private SerialPort comport = new SerialPort();

        public RadarGadgetToolForm()
        {
            InitializeComponent();
        }

        private string[] OrderedPortNames()
        {
            // Just a placeholder for a successful parsing of a string to an integer
            int num;

            // Order the serial port names in numberic order (if possible)
            return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out num) ? num : 0).ToArray();
        }

        private void RefreshComPortList()
        {
            // Determain if the list of com port names has changed since last checked
            string selected = RefreshComPortList(cbPorts.Items.Cast<string>(), cbPorts.SelectedItem as string, comport.IsOpen);

            // If there was an update, then update the control showing the user the list of port names
            if (!String.IsNullOrEmpty(selected))
            {
                cbPorts.Items.Clear();
                cbPorts.Items.AddRange(OrderedPortNames());
                cbPorts.SelectedItem = selected;
            }
        }

        private string RefreshComPortList(IEnumerable<string> PreviousPortNames, string CurrentSelection, bool PortOpen)
        {
            // Create a new return report to populate
            string selected = null;

            // Retrieve the list of ports currently mounted by the operating system (sorted by name)
            string[] ports = SerialPort.GetPortNames();

            // First determain if there was a change (any additions or removals)
            bool updated = PreviousPortNames.Except(ports).Count() > 0 || ports.Except(PreviousPortNames).Count() > 0;

            // If there was a change, then select an appropriate default port
            if (updated)
            {
                // Use the correctly ordered set of port names
                ports = OrderedPortNames();

                // Find newest port if one or more were added
                string newest = SerialPort.GetPortNames().Except(PreviousPortNames).OrderBy(a => a).LastOrDefault();

                // If the port was already open... (see logic notes and reasoning in Notes.txt)
                if (PortOpen)
                {
                    if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                    else if (!String.IsNullOrEmpty(newest)) selected = newest;
                    else selected = ports.LastOrDefault();
                }
                else
                {
                    if (!String.IsNullOrEmpty(newest)) selected = newest;
                    else if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                    else selected = ports.LastOrDefault();
                }
            }

            // If there was a change to the port list, return the recommended default selection
            return selected;
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            bool error = false;

            // If the port is open, close it.
            if (comport.IsOpen) comport.Close();
            else
            {
                // Set the port's settings
                comport.BaudRate = 38400;
                comport.DataBits = 8;
                comport.StopBits = StopBits.One;
                comport.Parity = Parity.None;
                comport.PortName = cbPorts.Text;

                try
                {
                    // Open the port
                    comport.Open();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    // TODO: read status?
                }
            }

            // TODO: Change the state of the form's controls
            EnableControls();
        }

        private void EnableControls()
        {
            if (comport.IsOpen)
            {
                cbPorts.Enabled = false;
                btnReadSettings.Enabled = true;
                btnOpenPort.Text = "Close";
                gbMode.Enabled = true;
                gbDemod.Enabled = true;
            }
            else
            {
                cbPorts.Enabled = true;
                btnReadSettings.Enabled = false;
                btnOpenPort.Text = "Open";
                gbMode.Enabled = false;
                gbDemod.Enabled = false;
            }
        }

        private void RadarGadgetToolForm_Load(object sender, EventArgs e)
        {
            // When data is recieved through the port, call this method
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            RefreshComPortList();
            EnableControls();
        }

        private void SendData(string msg)
        {
            comport.Write(msg);
            tbCom.AppendText(msg);
        }

        private void btnReadSettings_Click(object sender, EventArgs e)
        {
            SendData("RADC");
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!comport.IsOpen) return;

            // This method will be called when there is data waiting in the port's buffer

            // Read all the data waiting in the buffer
            string data = comport.ReadExisting();

            // Display the text to the user in the terminal
            Log(data);
            //TODO: parse what we received
        }

        private void Log(string msg)
        {
            tbCom.Invoke(new EventHandler(delegate
                        {
                            tbCom.AppendText(msg);
                            tbCom.AppendText(Environment.NewLine);
                        }));
        }

        private void btnSetMode_Click(object sender, EventArgs e)
        {
            if (rbModeA.Checked)
                SendData("RADFA");
            else if (rbModeB.Checked)
                SendData("RADFB");
            else if (rbModeC10.Checked)
                SendData("RADF1");
            else if (rbModeC20.Checked)
                SendData("RADF2");
            else if (rbModeC30.Checked)
                SendData("RADF3");
            else if (rbModeC40.Checked)
                SendData("RADF4");
            else if (rbModeC50.Checked)
                SendData("RADF5");
            SendData("RADC"); //Read the current status
        }

        private void btnSetDemod_Click(object sender, EventArgs e)
        {
            if (rbDemodW.Checked)
                SendData("RADFW");
            else if (rbDemodX.Checked)
                SendData("RADFX");
            else if (rbDemodY.Checked)
                SendData("RADFY");
            else if (rbDemodZ.Checked)
                SendData("RADFZ");
            SendData("RADC"); //Read the current status
        }

    }
}
