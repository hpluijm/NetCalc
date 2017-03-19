using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NetCalc
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		#region Declarations
		protected IPTool ip = null;
		protected bool fill = false; // lock events wenn updating
		protected bool isIP = false;
		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox ipAddress;
		private System.Windows.Forms.ComboBox netClassComboBox;
		private System.Windows.Forms.Label noticeLabel;
		private System.Windows.Forms.Button calcButt;
		private System.Windows.Forms.ComboBox prefixComboBox;
		private System.Windows.Forms.ComboBox netMaskComboBox;
		private System.Windows.Forms.CheckBox firstBitCheckBox;
		private System.Windows.Forms.TextBox maxCountHosts;
		private System.Windows.Forms.TextBox calcNetwork;
		private System.Windows.Forms.Button nextSubnetButt;
		private System.Windows.Forms.TextBox calcBroadcast;
		private System.Windows.Forms.TextBox calcIPRange;
		private System.Windows.Forms.TextBox clacMaxNetCount;
		private System.Windows.Forms.TextBox nextNumOfHosts;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calcButt = new System.Windows.Forms.Button();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.netClassComboBox = new System.Windows.Forms.ComboBox();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nextNumOfHosts = new System.Windows.Forms.TextBox();
            this.clacMaxNetCount = new System.Windows.Forms.TextBox();
            this.calcIPRange = new System.Windows.Forms.TextBox();
            this.calcBroadcast = new System.Windows.Forms.TextBox();
            this.calcNetwork = new System.Windows.Forms.TextBox();
            this.maxCountHosts = new System.Windows.Forms.TextBox();
            this.nextSubnetButt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstBitCheckBox = new System.Windows.Forms.CheckBox();
            this.netMaskComboBox = new System.Windows.Forms.ComboBox();
            this.prefixComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcButt);
            this.groupBox1.Controls.Add(this.noticeLabel);
            this.groupBox1.Controls.Add(this.netClassComboBox);
            this.groupBox1.Controls.Add(this.ipAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP \\ Network Type";
            // 
            // calcButt
            // 
            this.calcButt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calcButt.Location = new System.Drawing.Point(432, 72);
            this.calcButt.Name = "calcButt";
            this.calcButt.Size = new System.Drawing.Size(40, 24);
            this.calcButt.TabIndex = 5;
            this.calcButt.Text = "Calc";
            this.calcButt.Click += new System.EventHandler(this.calcButt_Click);
            // 
            // noticeLabel
            // 
            this.noticeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noticeLabel.Location = new System.Drawing.Point(8, 56);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(424, 40);
            this.noticeLabel.TabIndex = 4;
            this.noticeLabel.Text = "Info stuff: >>MicuRadu";
            // 
            // netClassComboBox
            // 
            this.netClassComboBox.Items.AddRange(new object[] {
            "Class A: 0.0.0.0-127.255.255.255",
            "Class B: 128.0.0.0-191.255.255.255",
            "Class C: 192.0.0.0-223.255.255.255",
            "Class D: 224.0.0.0-239.255.255.255",
            "Class E: 240.0.0.0-254.255.255.255"});
            this.netClassComboBox.Location = new System.Drawing.Point(248, 24);
            this.netClassComboBox.Name = "netClassComboBox";
            this.netClassComboBox.Size = new System.Drawing.Size(208, 21);
            this.netClassComboBox.TabIndex = 3;
            this.netClassComboBox.Text = "Class A: 0.0.0.0-127.255.255.255";
            this.netClassComboBox.SelectedIndexChanged += new System.EventHandler(this.netClassComboBox_SelectedIndexChanged);
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(24, 24);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(136, 20);
            this.ipAddress.TabIndex = 2;
            this.ipAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ipAddress_KeyDown);
            this.ipAddress.Leave += new System.EventHandler(this.ipAddress_Leave);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Network type:";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nextNumOfHosts);
            this.groupBox2.Controls.Add(this.clacMaxNetCount);
            this.groupBox2.Controls.Add(this.calcIPRange);
            this.groupBox2.Controls.Add(this.calcBroadcast);
            this.groupBox2.Controls.Add(this.calcNetwork);
            this.groupBox2.Controls.Add(this.maxCountHosts);
            this.groupBox2.Controls.Add(this.nextSubnetButt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.firstBitCheckBox);
            this.groupBox2.Controls.Add(this.netMaskComboBox);
            this.groupBox2.Controls.Add(this.prefixComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results \\ Options";
            // 
            // nextNumOfHosts
            // 
            this.nextNumOfHosts.Location = new System.Drawing.Point(152, 224);
            this.nextNumOfHosts.Name = "nextNumOfHosts";
            this.nextNumOfHosts.Size = new System.Drawing.Size(80, 20);
            this.nextNumOfHosts.TabIndex = 17;
            // 
            // clacMaxNetCount
            // 
            this.clacMaxNetCount.Location = new System.Drawing.Point(152, 192);
            this.clacMaxNetCount.Name = "clacMaxNetCount";
            this.clacMaxNetCount.Size = new System.Drawing.Size(320, 20);
            this.clacMaxNetCount.TabIndex = 16;
            // 
            // calcIPRange
            // 
            this.calcIPRange.Location = new System.Drawing.Point(152, 160);
            this.calcIPRange.Name = "calcIPRange";
            this.calcIPRange.Size = new System.Drawing.Size(320, 20);
            this.calcIPRange.TabIndex = 15;
            // 
            // calcBroadcast
            // 
            this.calcBroadcast.Location = new System.Drawing.Point(152, 128);
            this.calcBroadcast.Name = "calcBroadcast";
            this.calcBroadcast.Size = new System.Drawing.Size(320, 20);
            this.calcBroadcast.TabIndex = 14;
            // 
            // calcNetwork
            // 
            this.calcNetwork.Location = new System.Drawing.Point(152, 96);
            this.calcNetwork.Name = "calcNetwork";
            this.calcNetwork.Size = new System.Drawing.Size(320, 20);
            this.calcNetwork.TabIndex = 13;
            // 
            // maxCountHosts
            // 
            this.maxCountHosts.Location = new System.Drawing.Point(152, 64);
            this.maxCountHosts.Name = "maxCountHosts";
            this.maxCountHosts.Size = new System.Drawing.Size(320, 20);
            this.maxCountHosts.TabIndex = 12;
            // 
            // nextSubnetButt
            // 
            this.nextSubnetButt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextSubnetButt.Location = new System.Drawing.Point(240, 224);
            this.nextSubnetButt.Name = "nextSubnetButt";
            this.nextSubnetButt.Size = new System.Drawing.Size(232, 23);
            this.nextSubnetButt.TabIndex = 11;
            this.nextSubnetButt.Text = "Show next subnet with this number of hosts";
            this.nextSubnetButt.Click += new System.EventHandler(this.nextSubnetButt_Click);
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Location = new System.Drawing.Point(8, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Wanted number of hosts:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(8, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Maximum number of subnets:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(8, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "IP - range:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(8, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Broadcast:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(8, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Network:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstBitCheckBox
            // 
            this.firstBitCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.firstBitCheckBox.Location = new System.Drawing.Point(352, 24);
            this.firstBitCheckBox.Name = "firstBitCheckBox";
            this.firstBitCheckBox.Size = new System.Drawing.Size(120, 24);
            this.firstBitCheckBox.TabIndex = 5;
            this.firstBitCheckBox.Text = "Allow 1st subnet-BIT";
            this.firstBitCheckBox.CheckedChanged += new System.EventHandler(this.firstBitCheckBox_CheckedChanged);
            // 
            // netMaskComboBox
            // 
            this.netMaskComboBox.Location = new System.Drawing.Point(152, 24);
            this.netMaskComboBox.Name = "netMaskComboBox";
            this.netMaskComboBox.Size = new System.Drawing.Size(121, 21);
            this.netMaskComboBox.TabIndex = 4;
            this.netMaskComboBox.SelectedIndexChanged += new System.EventHandler(this.netMaskComboBox_SelectedIndexChanged);
            // 
            // prefixComboBox
            // 
            this.prefixComboBox.Location = new System.Drawing.Point(40, 24);
            this.prefixComboBox.Name = "prefixComboBox";
            this.prefixComboBox.Size = new System.Drawing.Size(48, 21);
            this.prefixComboBox.TabIndex = 3;
            this.prefixComboBox.SelectedIndexChanged += new System.EventHandler(this.prefixComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Maximum number of Hosts:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(96, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Net-Mask:";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prefix:";
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitBtn.Location = new System.Drawing.Point(462, 368);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 16);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(496, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-- Petisys Subnet Calculator --";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles() ;
			Application.DoEvents();
			Application.Run(new MainForm());
		}

		#region Events
		private void ipAddress_Leave(object sender, System.EventArgs e)
		{
			newIP();
		}

		private void ipAddress_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.Enter )
			{
				newIP();			
			}
		}

		private void prefixComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ip == null || ip.getIp() == null || fill) return;
			if (ip.getNetworkClassPrefix() == -1) return;
				
			int prefix = Int32.Parse((string)prefixComboBox.SelectedItem);
			ip.setNetworkPrefix(prefix);

			fillIPCalc();
		}

		private void netMaskComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ip == null || ip.getIp() == null || fill) return;
			if (ip.getNetworkClassPrefix() == -1) return;
				
			int select = netMaskComboBox.SelectedIndex;
			int prefix = select + ip.getNetworkClassPrefix();
			if (select != 0 && !ip.isFirstSubNetBit()) prefix++; 
			//int prefix = Integer.parseInt((String)main.getJcb_Calc_NetworkMask().getSelectedItem());
			ip.setNetworkPrefix(prefix);

			fillIPCalc();
		}

		private void netClassComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (fill) return;
			switch (netClassComboBox.SelectedIndex)
			{
				case 0: ipAddress.Text = "1.0.0.1";
					break;				
				case 1: ipAddress.Text = "128.0.0.1";
					break;
				case 2: ipAddress.Text = "192.0.0.1";
					break;
				case 3: ipAddress.Text = "224.0.0.1";
					break;
				case 4: ipAddress.Text = "240.0.0.1";
					break;
			}
				
			newIP ();
		}

		private void firstBitCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (ip == null || ip.getIp() == null || fill) return;
				
			ip.setFirstSubNetBit(firstBitCheckBox.Checked);
			fillIPCalc();
		}

		private void nextSubnetButt_Click(object sender, System.EventArgs e)
		{
			if (ip == null || ip.getIp() == null || fill) return;
			nextNumOfHosts.BackColor = Color.White;
				
			try 
			{
				int hosts = Int32.Parse(nextNumOfHosts.Text);
				
				IPTool newIp = ip.getNextSubNet(hosts);
				if (newIp == null)
				{
					//ToManyHosts
					noticeLabel.Text = "Info stuff: Number of hosts in this network-class not possible!";
					return;
				}
				ip = newIp;
				ipAddress.Text = ip.getIp();
			} 			
			catch (System.FormatException)
			{
				nextNumOfHosts.BackColor = Color.Red;
				return;
			}
			catch(Exception e1)
			{
				MessageBox.Show(e1.StackTrace);
				return;
			}
				
			fillIPCalc();
		}

		private void calcButt_Click(object sender, System.EventArgs e)
		{
			newIP();
		}
		#endregion

		#region Methods Used
		protected void newIP()
		{
			try 
			{
				ip = new IPTool (ipAddress.Text);
				ipAddress.BackColor = Color.White;
				fillIPCalc();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.StackTrace);
			}
			//catch (UnknownHostException e) 
			//{
			//	main.getJp_Calc().getJtf_IP_Calc().setBackground(java.awt.Color.red);
			//}
		}

		protected void fillIPCalc()
		{
			if (ip == null || ip.getIp() == null) return;
			this.fill = true;
		
			this.fillComboBox_Prefix();
			this.fillComboBox_NetworkMask();
		
			// Prefix
			int prefix = ip.getNetworkPrefix();
			if (prefix >= 8 && prefix <= 30) 
			{
				if (prefix != ip.getNetworkClassPrefix() && !ip.isFirstSubNetBit()) prefix--;
				prefix = prefix - ip.getNetworkClassPrefix(); 
			} 
			else prefix = -1;
			prefixComboBox.SelectedIndex = prefix;
			// NetMask
			netMaskComboBox.SelectedIndex = prefix;
		
			// folgendes nur wenn Netzwerkmaske vorhanden
			// nicht der Fall bei Class-D oder E
			if (prefix != -1)
			{
				// max Net Hosts
				maxCountHosts.Text = ip.getMaxNetworkHosts()+"";
				// Net Class    
				calcNetwork.Text = ip.getNetworkClassName();
				// Broadcast
				calcBroadcast.Text = ip.getBroadCast();
				//	Network
				calcNetwork.Text = ip.getNetwork();
				//	Net-Class
				netClassComboBox.SelectedIndex = ip.getNetworkClass();
				// IP-Range
				string [] ipRange = ip.getNetworkIPRange();
				calcIPRange.Text = ipRange[0]+" - "+ipRange[1];
				// max Sub-Nets
				clacMaxNetCount.Text = ip.getMaxSubNets()+"";
			}
			else // Anzeige löschen
			{
				// max Net Hosts
				maxCountHosts.Text = "";
				// Net Class    
				calcNetwork.Text = "";
				// Broadcast
				calcBroadcast.Text = "";
				//	Network
				calcNetwork.Text = "";
				// IP-Range
				calcIPRange.Text = "";
				// max Sub-Nets
				clacMaxNetCount.Text = "";
			}
			// Description
			string desc = "";  
			if (ip.get1Byte() >= (byte)64 && ip.getNetworkClass() == (byte)0)	// 64. 
				desc = "reserved for future use";
			if (ip.get1Byte() == (byte)127)	// localhost 
				desc = "localhost and loopback-Device - your one computer";
			if (ip.get1Byte() == (byte)10) 	// private 10.0.0.0
				desc = "private net - for internal use only, would not be routed in internet";
			if (ip.get1Byte() == (byte)192 && ip.get2Byte() == (byte)168)  // private 192. - 168. 
				desc = "private net - for internal use only, would not be routed in internet";
			if (ip.get1Byte() == (byte)172 && (ip.get2Byte() >= (byte)16 && ip.get2Byte() <= (byte)31))		//private 172.16 - 172.31 
				desc = "private net - for internal use only, would not be routed in internet";
			if ((ip.get1Byte() == (byte)169) && (ip.get2Byte() == (byte)254))		// 169.254. 
				desc = "APIPA Automatic Private IP Addressing";
			if (ip.get1Byte() == (byte)0) 	// 0.
				desc = "0.0.0.0 = default route";
			if (ip.getNetworkClass() == (byte)4) // Class-E 
				desc = "reserved for future use";
			if (ip.getNetworkClass() == (byte)3) // Class-D 
				desc = "used for multicast";

			noticeLabel.Text = "Info stuff: "+desc;
			this.fill = false;
		}

		protected void fillComboBox_Prefix ()
		{
			if (ip == null || ip.getIp() == null) return;
		
			prefixComboBox.Items.Clear();
		
			if (ip.getNetworkClassPrefix() == -1) 
			{
				prefixComboBox.Items.Add("");
				return;
			} 

			int startPrefix = ip.getNetworkClassPrefix();
			// first is Networkclass
			prefixComboBox.Items.Add(startPrefix+"");
			startPrefix++;
			if (!ip.isFirstSubNetBit()) startPrefix++;
		
			for (int i=startPrefix; i<=30; i++) 
				prefixComboBox.Items.Add(i+"");
		}
		protected void fillComboBox_NetworkMask ()
		{
			if (ip == null || ip.getIp() == null) return;
		
			netMaskComboBox.Items.Clear();
		
			if (ip.getNetworkClassPrefix() == -1) 
			{
				netMaskComboBox.Items.Add("");
				return;
			} 
		 
			int startPrefix = ip.getNetworkClassPrefix();
			// first is Networkclass
			netMaskComboBox.Items.Add(ip.getNetworkMaskByPrefix(startPrefix));
			startPrefix++;
			if (!ip.isFirstSubNetBit()) startPrefix++;
		
			for (int i=startPrefix; i<=30; i++) 
				netMaskComboBox.Items.Add(ip.getNetworkMaskByPrefix(i));
		}
		#endregion

		private void exitBtn_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
