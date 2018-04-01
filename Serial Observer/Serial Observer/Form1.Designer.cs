namespace Serial_Observer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_portLogs = new System.Windows.Forms.ListBox();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.comboBox_portSpeed = new System.Windows.Forms.ComboBox();
            this.comboBox_portParity = new System.Windows.Forms.ComboBox();
            this.comboBox_portData = new System.Windows.Forms.ComboBox();
            this.comboBox_portStop = new System.Windows.Forms.ComboBox();
            this.button_portConnect = new System.Windows.Forms.Button();
            this.button_portDisconnect = new System.Windows.Forms.Button();
            this.button_portSend = new System.Windows.Forms.Button();
            this.textBox_textToSend = new System.Windows.Forms.TextBox();
            this.checkBox_HexEntering = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox_portLogs
            // 
            this.listBox_portLogs.FormattingEnabled = true;
            this.listBox_portLogs.Location = new System.Drawing.Point(12, 39);
            this.listBox_portLogs.Name = "listBox_portLogs";
            this.listBox_portLogs.Size = new System.Drawing.Size(629, 147);
            this.listBox_portLogs.TabIndex = 0;
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(12, 12);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_portName.TabIndex = 1;
            // 
            // comboBox_portSpeed
            // 
            this.comboBox_portSpeed.FormattingEnabled = true;
            this.comboBox_portSpeed.Location = new System.Drawing.Point(139, 12);
            this.comboBox_portSpeed.Name = "comboBox_portSpeed";
            this.comboBox_portSpeed.Size = new System.Drawing.Size(121, 21);
            this.comboBox_portSpeed.TabIndex = 2;
            // 
            // comboBox_portParity
            // 
            this.comboBox_portParity.FormattingEnabled = true;
            this.comboBox_portParity.Location = new System.Drawing.Point(393, 12);
            this.comboBox_portParity.Name = "comboBox_portParity";
            this.comboBox_portParity.Size = new System.Drawing.Size(121, 21);
            this.comboBox_portParity.TabIndex = 3;
            // 
            // comboBox_portData
            // 
            this.comboBox_portData.FormattingEnabled = true;
            this.comboBox_portData.Location = new System.Drawing.Point(266, 12);
            this.comboBox_portData.Name = "comboBox_portData";
            this.comboBox_portData.Size = new System.Drawing.Size(121, 21);
            this.comboBox_portData.TabIndex = 4;
            // 
            // comboBox_portStop
            // 
            this.comboBox_portStop.FormattingEnabled = true;
            this.comboBox_portStop.Location = new System.Drawing.Point(520, 12);
            this.comboBox_portStop.Name = "comboBox_portStop";
            this.comboBox_portStop.Size = new System.Drawing.Size(121, 21);
            this.comboBox_portStop.TabIndex = 5;
            // 
            // button_portConnect
            // 
            this.button_portConnect.Location = new System.Drawing.Point(12, 219);
            this.button_portConnect.Name = "button_portConnect";
            this.button_portConnect.Size = new System.Drawing.Size(248, 23);
            this.button_portConnect.TabIndex = 6;
            this.button_portConnect.Text = "Connecter";
            this.button_portConnect.UseVisualStyleBackColor = true;
            this.button_portConnect.Click += new System.EventHandler(this.button_portConnect_Click);
            // 
            // button_portDisconnect
            // 
            this.button_portDisconnect.Location = new System.Drawing.Point(266, 219);
            this.button_portDisconnect.Name = "button_portDisconnect";
            this.button_portDisconnect.Size = new System.Drawing.Size(248, 23);
            this.button_portDisconnect.TabIndex = 7;
            this.button_portDisconnect.Text = "Déconnecter";
            this.button_portDisconnect.UseVisualStyleBackColor = true;
            this.button_portDisconnect.Click += new System.EventHandler(this.button_portDisconnect_Click);
            // 
            // button_portSend
            // 
            this.button_portSend.Location = new System.Drawing.Point(520, 219);
            this.button_portSend.Name = "button_portSend";
            this.button_portSend.Size = new System.Drawing.Size(121, 23);
            this.button_portSend.TabIndex = 8;
            this.button_portSend.Text = "Envoyer";
            this.button_portSend.UseVisualStyleBackColor = true;
            this.button_portSend.Click += new System.EventHandler(this.button_portSend_Click);
            // 
            // textBox_textToSend
            // 
            this.textBox_textToSend.Location = new System.Drawing.Point(13, 193);
            this.textBox_textToSend.Name = "textBox_textToSend";
            this.textBox_textToSend.Size = new System.Drawing.Size(628, 20);
            this.textBox_textToSend.TabIndex = 9;
            // 
            // checkBox_HexEntering
            // 
            this.checkBox_HexEntering.AutoSize = true;
            this.checkBox_HexEntering.Location = new System.Drawing.Point(13, 248);
            this.checkBox_HexEntering.Name = "checkBox_HexEntering";
            this.checkBox_HexEntering.Size = new System.Drawing.Size(156, 17);
            this.checkBox_HexEntering.TabIndex = 10;
            this.checkBox_HexEntering.Text = "Mode d\'entrée hexadécimal";
            this.checkBox_HexEntering.UseVisualStyleBackColor = true;
            this.checkBox_HexEntering.CheckedChanged += new System.EventHandler(this.checkBox_HexEntering_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_HexEntering);
            this.Controls.Add(this.textBox_textToSend);
            this.Controls.Add(this.button_portSend);
            this.Controls.Add(this.button_portDisconnect);
            this.Controls.Add(this.button_portConnect);
            this.Controls.Add(this.comboBox_portStop);
            this.Controls.Add(this.comboBox_portData);
            this.Controls.Add(this.comboBox_portParity);
            this.Controls.Add(this.comboBox_portSpeed);
            this.Controls.Add(this.comboBox_portName);
            this.Controls.Add(this.listBox_portLogs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_portLogs;
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.ComboBox comboBox_portSpeed;
        private System.Windows.Forms.ComboBox comboBox_portParity;
        private System.Windows.Forms.ComboBox comboBox_portData;
        private System.Windows.Forms.ComboBox comboBox_portStop;
        private System.Windows.Forms.Button button_portConnect;
        private System.Windows.Forms.Button button_portDisconnect;
        private System.Windows.Forms.Button button_portSend;
        private System.Windows.Forms.TextBox textBox_textToSend;
        private System.Windows.Forms.CheckBox checkBox_HexEntering;
    }
}

