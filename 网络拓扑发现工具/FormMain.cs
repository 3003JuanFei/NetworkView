using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 网络拓扑发现工具.Forms;
using 网络拓扑发现工具.UserControls;

namespace 网络拓扑发现工具
{
    public partial class FormMain : Form
    {
        [DllImport("ws2_32.dll")]
        private static extern int inet_addr(string cp);
        [DllImport("IPHLPAPI.dll")]
        private static extern int SendARP(Int32 DestIP, Int32 SrcIP, ref Int64 pMacAddr, ref Int32 PhyAddrLen);

        public FormMain()
        {
            InitializeComponent();
        }

      
        private void btn_startscan_Click(object sender, EventArgs e)
        {
            
            this.flowLayoutPanel_1.Controls.Clear();
            this.cb_timerCheck.Checked = false;
            Task.Factory.StartNew(()=> {
                List<string> list = GetLiveIP(txt_ipstart.Text, txt_ipend.Text);


                LogMSG("需要检查的IP地址数量为：" + list.Count);
                this.Invoke(new MethodInvoker(() =>
                {
                    this.progressBar_01.Style = ProgressBarStyle.Marquee;
                    this.btn_startscan.Enabled = false;
                    
                }));
                bool flag1 = cb_ping.Checked;
                bool flag2 = cb_checkmac.Checked;
                bool flag3 = cb_checkhostname.Checked;

                List<Task> tasks=StartScan(list, new bool[] { flag1, flag2, flag3 }, new ScanCompleteCallBack((PingReply result, string ipaddress, string hostname, string macaddress) => {

                    if (result.Status == IPStatus.Success)
                    {
                        LogMSG(ipaddress + " - Alive");
                        this.Invoke(new MethodInvoker(() =>
                        {
                            DeviceItem di = new DeviceItem()
                            {
                                IPAddress = ipaddress,
                                DeviceStatus = DeviceStatus.Alive,
                                PCHostName = hostname,
                                DeviceMac = macaddress,
                                DeviceTypeName="PC"
                            };
                            ContextMenuStrip controlContextMenuStrip = new ContextMenuStrip();
                            controlContextMenuStrip.Items.Add("编辑", null, new EventHandler((object senders, EventArgs args) => {
                                FormEdit retform = new FormEdit(di.DeviceMac, di.DeviceTypeName, di.PCHostName);
                                retform.saveCallBack += new FormEdit.SaveCallBack((string mac, string devicetypename, string pchostname) => {
                                    di.DeviceMac = mac;
                                    di.DeviceTypeName = devicetypename;
                                    di.PCHostName = pchostname;
                                });
                                retform.ShowDialog();
                            }));
                            di.ContextMenuStrip = controlContextMenuStrip;
                            this.flowLayoutPanel_1.Controls.Add(di);
                      
                        }));
                    }
                    if (cb_showall.Checked)
                    {
                        if (result.Status!= IPStatus.Success)
                        {
                            this.Invoke(new MethodInvoker(() =>
                            {
                                DeviceItem di = new DeviceItem()
                                {
                                    IPAddress = ipaddress,
                                    DeviceStatus = DeviceStatus.Colsed,
                                    PCHostName = hostname,
                                    DeviceMac = macaddress,
                                    DeviceTypeName = "PC"
                                };

                                ContextMenuStrip controlContextMenuStrip = new ContextMenuStrip();
                                controlContextMenuStrip.Items.Add("编辑", null, new EventHandler((object senders,EventArgs args)=> {
                                    FormEdit retform = new FormEdit(di.DeviceMac, di.DeviceTypeName, di.PCHostName);
                                    retform.saveCallBack += new FormEdit.SaveCallBack((string mac, string devicetypename, string pchostname) => {
                                        di.DeviceMac = mac;
                                        di.DeviceTypeName=devicetypename;
                                        di.PCHostName = pchostname;
                                    });
                                    retform.ShowDialog();
                                }));

                                di.ContextMenuStrip = controlContextMenuStrip;

                                this.flowLayoutPanel_1.Controls.Add(di);

                            }));
                        }
                    }
                }));

                Task.Run(async () =>
                {
                    await Task.WhenAll(tasks);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        this.progressBar_01.Style = ProgressBarStyle.Blocks;
                        this.progressBar_01.Value = 100;
                        this.btn_startscan.Enabled = true;
                    }));
                    LogMSG("IP地址发现，已完成");
                    TongJi();
                });

            });

        }
        private delegate void ScanCompleteCallBack(PingReply result,string ipaddress,string hostname,string macaddress);
        private List<Task> StartScan(List<string> list, bool[] flags,ScanCompleteCallBack scanCompleteCallBack)
        {
            List<Task> tasks = new List<Task>();
            foreach (string ipstr in list)
            {
                Ping ping = new Ping();
                ping.PingCompleted += new PingCompletedEventHandler((object pingSender, PingCompletedEventArgs pingE) =>
                {
                    string hostname = "HostName 未获取";
                    string macaddress = "Mac Addr 未获取";
                    PingReply result = pingE.Reply;
                    if (result.Status == IPStatus.Success)
                    {
                        try
                        {
                            bool flag1 = flags[0];
                            bool flag2 = flags[1];
                            bool flag3 = flags[2];

                            if (flag2)
                            {
                                macaddress = GetMacAddress(ipstr);
                            }

                            if (flag3)
                            {
                                new System.Threading.Tasks.TaskFactory().StartNew(() => {
                                    hostname = System.Net.Dns.GetHostEntry(ipstr).HostName;
                                }).Wait(int.Parse(txt_dnstimeout.Text));
                            }

                        }
                        catch (Exception ex)
                        {
                            hostname = "未获取到";
                        }
                    }
                   
                    scanCompleteCallBack(result, ipstr, hostname,macaddress);
                });
                Task<PingReply> pr = ping.SendPingAsync(ipstr, int.Parse(txt_icmptimeout.Text));
                tasks.Add(pr);
            }
            
            return tasks;
        }

        public List<string> GetLiveIP(string startIP, string endIP)
        {
            List<string> result = new List<string>();
            var ipArray = startIP.Split('.');
            int A1 = int.Parse(ipArray[0]);
            int A2 = int.Parse(ipArray[1]);
            int A3 = int.Parse(ipArray[2]);
            int A4 = int.Parse(ipArray[3]);

            int i = 0;
            while (i == 0)
            {
                A4++;
                string item = string.Empty;
                if (A4 != 255)
                {
                    item = A1 + "." + A2 + "." + A3 + "." + A4;
                    result.Add(item);
                }

                if (A4 == 255)
                {
                    A3++;
                    A4 = 0;
                }
                else if (A3 == 255)
                {
                    A2++;
                    A3 = 0;
                }
                else if (A2 == 255)
                {
                    A1++;
                }

                if (item == endIP)
                {
                    i = 1;
                }
            }

            return result;
        }


        private string GetMacAddress(string hostip)//获取远程IP（不能跨网段）的MAC地址
        {
            string Mac = "";
            try
            {
                Int32 ldest = inet_addr(hostip); //将IP地址从 点数格式转换成无符号长整型
                Int64 macinfo = new Int64();
                Int32 len = 6;
                SendARP(ldest, 0, ref macinfo, ref len);
                string TmpMac = Convert.ToString(macinfo, 16).PadLeft(12, '0');//转换成16进制　　注意有些没有十二位
                Mac = TmpMac.Substring(0, 2).ToUpper();//
                for (int i = 2; i < TmpMac.Length; i = i + 2)
                {
                    Mac = TmpMac.Substring(i, 2).ToUpper() + "-" + Mac;
                }
            }
            catch (Exception Mye)
            {
                Mac = "获取远程主机的MAC错误：" + Mye.Message;
            }
            return Mac;
        }

        private void LogMSG(string msg)
        {
            this.rtb_log.Invoke(new MethodInvoker(() =>{
                if (rtb_log.Text.Length > 20000) { this.rtb_log.Text = ""; }
                this.rtb_log.Text = (DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+" "+msg+"\r\n")+ this.rtb_log.Text;
            }));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_timerCheck.Checked)
            {
                timer_ping.Interval = int.Parse(txt_xhinterval.Text);
                timer_ping.Enabled = true;
                timer_ping.Start();
            }
            else
            {
                timer_ping.Stop();
                timer_ping.Enabled = false;
            }
        }

        private void timer_ping_Tick(object sender, EventArgs e)
        {
            Dictionary<string, DeviceItem> dic_IP_Divices = new Dictionary<string, DeviceItem>();
            List<string> ipList = new List<string>();
           
            foreach(Control c in flowLayoutPanel_1.Controls)
            {
                if(c is DeviceItem)
                {
                    DeviceItem item = (c as DeviceItem);
                    dic_IP_Divices.Add(item.IPAddress,item);
                    ipList.Add(item.IPAddress);
                    item.DeviceStatus = DeviceStatus.UNKNOWN;

                }
            }

            List<Task> tasks = StartScan(ipList,new bool[] { true,cb_checkmac.Checked,cb_checkhostname.Checked}, new ScanCompleteCallBack((PingReply result, string ipaddress, string hostname, string macaddress) => {

                if (result.Status == IPStatus.Success)
                {
                    DeviceItem item = (dic_IP_Divices[ipaddress] as DeviceItem);
                    
                
                    item.DeviceStatus = DeviceStatus.Alive;
                    if (cb_checkmac.Checked)
                    {
                        item.DeviceMac = macaddress;
                    }

                    if (cb_checkhostname.Checked)
                    {
                        item.PCHostName = hostname;
                    }
                }
                else
                {
                    DeviceItem item = (dic_IP_Divices[ipaddress] as DeviceItem);
                    item.DeviceStatus = DeviceStatus.Colsed;
                }


            }));

            Task.Run(async () =>
            {
                await Task.WhenAll(tasks);
                TongJi();
            });
            
            
        }

        private void TongJi()
        {
            int lblgreen = 0;
            int lblred = 0;
            int lblyellow = 0;
            int lblsum = 0;

            foreach (Control c in flowLayoutPanel_1.Controls)
            {
                if (c is DeviceItem)
                {
                    DeviceItem item = (c as DeviceItem);

                    if (item.DeviceStatus == DeviceStatus.Alive)
                    {
                        lblgreen += 1;
                       
                    }
                    if (item.DeviceStatus == DeviceStatus.Colsed)
                    {
                        lblred += 1;
                        
                    }
                    if (item.DeviceStatus == DeviceStatus.UNKNOWN)
                    {
                        lblyellow += 1;
                        
                    }
                    lblsum += 1;
                    this.Invoke(new MethodInvoker(()=> {
                        lbl_yellow.Text = lblyellow + " 台";
                        lbl_red.Text = lblred + " 台";
                        lbl_green.Text = lblgreen + " 台";
                        lbl_sums.Text = lblsum + " 台";
                    }));
                    
                }
            }
        }

        private void 关于软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("基于Ping命令的工具，BY:柒月风华");
        }

        private void 保存当前拓扑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 另存为当前拓扑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFile = new SaveFileDialog();  //实例化保存文件对话框对象
            saveFile.Title = "请选择保存文件路径";
           

            saveFile.Filter = "NetworkView 文档(*.nwp)|*.nwp";
            saveFile.OverwritePrompt = true;  //是否覆盖当前文件
            saveFile.RestoreDirectory = true;  //还原目录
            if (saveFile.ShowDialog() != DialogResult.OK) { return; }

            string saveFileName = saveFile.FileName;
            

            DeviceSetting ds = new DeviceSetting();
            foreach (Control c in flowLayoutPanel_1.Controls)
            {
                if (c is DeviceItem)
                {
                    DeviceItem item = (c as DeviceItem);

                    DeviceItemModel model = new DeviceItemModel()
                    {
                        IPAddress = item.IPAddress,
                        DeviceMac = item.DeviceMac,
                        DeviceStatus = item.DeviceStatus,
                        PCHostName = item.PCHostName,
                        DeviceTypeName= item.DeviceTypeName
                    };
                    ds.list.Add(model);
                }
            }
            SerializeClassHelper.SerializeObject(saveFileName, ds);
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFile = new OpenFileDialog();
            saveFile.Title = "请选择保存文件路径";
            saveFile.Filter = "NetworkView 文档(*.nwp)|*.nwp";

            if (saveFile.ShowDialog() != DialogResult.OK) { return; }

            string path = saveFile.FileName;
            DeviceSetting ds = new DeviceSetting();
            ds=(DeviceSetting)SerializeClassHelper.DeserializeObject(path,ds);
            this.flowLayoutPanel_1.Controls.Clear();
            foreach (DeviceItemModel model in ds.list)
            {
                DeviceItem di = new DeviceItem()
                {
                    IPAddress = model.IPAddress,
                    DeviceStatus = DeviceStatus.NotMonitor,
                    PCHostName = model.PCHostName,
                    DeviceMac = model.DeviceMac,
                    DeviceTypeName=model.DeviceTypeName
                };
                ContextMenuStrip controlContextMenuStrip = new ContextMenuStrip();
                controlContextMenuStrip.Items.Add("编辑", null, new EventHandler((object senders, EventArgs args) => {
                    FormEdit retform = new FormEdit(di.DeviceMac, di.DeviceTypeName, di.PCHostName);
                    retform.saveCallBack += new FormEdit.SaveCallBack((string mac, string devicetypename, string pchostname) => {
                        di.DeviceMac = mac;
                        di.DeviceTypeName = devicetypename;
                        di.PCHostName = pchostname;
                    });
                    retform.ShowDialog();
                }));
                di.ContextMenuStrip = controlContextMenuStrip;
                this.flowLayoutPanel_1.Controls.Add(di);

            }
        }
    }
}
