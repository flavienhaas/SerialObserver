using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Observer
{
    public partial class Form1 : Form
    {
        // Variables
        SerialPort serialPort;
        AddListItem myDelegate;

        // Methods
        public delegate void AddListItem(String myString);

        public Form1()
        {
            // Initialize
            InitializeComponent();
            InitializeComboBox();

            // Form size
            this.Size = new Size(670, 320);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            // Form options
            this.Text = "Serial Observer";

            // Buttons
            modifyButtonsAccess(true, false, false);
            button_setupForm.Enabled = false;
        }

        /***************************** Events *****************************/
        private void button_portConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Création d'un port avec les paramètres indiqués
                serialPort = new SerialPort(comboBox_portName.Items[comboBox_portName.SelectedIndex].ToString(), parsePortSpeed(comboBox_portSpeed.Items[comboBox_portSpeed.SelectedIndex].ToString()), parsePortParity(comboBox_portParity.Items[comboBox_portParity.SelectedIndex].ToString()),parsePortData(comboBox_portData.Items[comboBox_portData.SelectedIndex].ToString()),parsePortStop(comboBox_portStop.Items[comboBox_portStop.SelectedIndex].ToString()));
                
                // Ouverture du port créé
                serialPort.Open();

                // Evénement à la réception de données
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                // Modification des boutons de contrôle
                modifyButtonsAccess(false, true, true);

                // Effacement du logger
                listBox_portLogs.Items.Clear();

                // Confirmation de réussite
                MessageBox.Show("L'ouverture du port est un succès.", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentOutOfRangeException)
            {
                // Une des listes déroulantes est vide
                MessageBox.Show("Vous devez choisir une configuration !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_portDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                modifyButtonsAccess(true, false, false);
                MessageBox.Show("La fermeture du port est un succès.", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_portSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkBox_HexEntering.Checked)
                {
                    serialPort.Write(HexToString(textBox_textToSend.Text));
                }
                else
                {
                    serialPort.Write(textBox_textToSend.Text);
                }

                textBox_textToSend.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_setupForm_Click(object sender, EventArgs e)
        {
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();
                myDelegate = new AddListItem(AddListItemMethod);
                listBox_portLogs.Invoke(myDelegate, new Object[] { "[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] : " + indata });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_HexEntering_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_HexEntering.Checked == true)
            {
                MessageBox.Show(String.Format("Mode d'entrée hexadécimal actif ! \r\nSyntaxe : '68-65-6C-6C-6F' pour ecrire 'hello'."),"Changement de mode d'entrée",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        /************************* Private Methods Form1 *************************/
        private void InitializeComboBox()
        {
            // Port name
            comboBox_portName.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                comboBox_portName.Items.Add(port);
            }

            // Port speed
            comboBox_portSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            int[] speeds = {1200,2400,4800,9600,14400,19200,28800,38400,57600,115200,230400};
            foreach(int speed in speeds)
            {
                comboBox_portSpeed.Items.Add(speed);
            }

            // Port data
            comboBox_portData.DropDownStyle = ComboBoxStyle.DropDownList;
            int[] datas = {5,6,7,8};
            foreach(int data in datas)
            {
                comboBox_portData.Items.Add(data);
            }

            // Port parity
            comboBox_portParity.DropDownStyle = ComboBoxStyle.DropDownList;
            String[] parities = {Parity.None.ToString(),Parity.Even.ToString(),Parity.Odd.ToString(),Parity.Mark.ToString(),Parity.Space.ToString()};
            foreach(string parity in parities)
            {
                comboBox_portParity.Items.Add(parity);
            }

            // Port stop
            comboBox_portStop.DropDownStyle = ComboBoxStyle.DropDownList;
            String[] stops = {StopBits.None.ToString(),StopBits.One.ToString(),StopBits.OnePointFive.ToString(),StopBits.Two.ToString()};
            foreach(string stop in stops)
            {
                comboBox_portStop.Items.Add(stop);
            }
        }

        private int parsePortSpeed(string speed)
        {
            return (int.Parse(speed));
        }

        private Parity parsePortParity(string parity)
        {
            if(parity == "None")
            {
                return (Parity.None);
            }
            else if(parity == "Even")
            {
                return (Parity.Even);
            }
            else if(parity == "Odd")
            {
                return (Parity.Odd);
            }
            else if(parity == "Mark")
            {
                return (Parity.Mark);
            }
            else
            {
                return (Parity.Space);
            }
        }

        private int parsePortData(string data)
        {
            return (int.Parse(data));
        }

        private StopBits parsePortStop(string stop)
        {
            if (stop == "None")
            {
                return (StopBits.None);
            }
            else if (stop == "One")
            {
                return (StopBits.One);
            }
            else if (stop == "OnePointFive")
            {
                return (StopBits.OnePointFive);
            }
            else
            {
                return (StopBits.Two);
            }
        }

        private void modifyButtonsAccess(Boolean _buttonPortConnect, Boolean _buttonPortDisconnect, Boolean _buttonPortSend)
        {
            button_portConnect.Enabled = _buttonPortConnect;
            button_portDisconnect.Enabled = _buttonPortDisconnect;
            button_portSend.Enabled = _buttonPortSend;
        }

        private void AddListItemMethod(String myString)
        {
            listBox_portLogs.Items.Add(myString);
            listBoxGoToLastItem();
        }

        private string HexToString(string hexdata)
        {
            string[] hexDataSplit = hexdata.Split('-');

            for (int count = 0 ; count < hexDataSplit.Length ; count++)
            {
                hexDataSplit[count] = Char.ConvertFromUtf32(Convert.ToInt32(hexDataSplit[count], 16));
            }

            return (String.Join("", hexDataSplit));
        }

        private void listBoxGoToLastItem()
        {
            listBox_portLogs.TopIndex = listBox_portLogs.Items.Count - 1;
        }
    }
}
