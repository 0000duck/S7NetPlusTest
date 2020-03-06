using S7.Net;
using S7.Net.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace S7NetPlusTest
{
    public partial class Form1 : Form
    {
        Plc _plc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {            
                if (string.IsNullOrEmpty(cb_ip.Text))
                {
                    lbMsg.Text = "请输入IP";
                    return;
                }

                lbMsg.Text = "连接中";
                _plc = new Plc(CpuType.S71200, cb_ip.Text, 0, 1);

                lbMsg.Text = "连接成功";
                
            }
            catch (PlcException ex)
            {
                lbMsg.Text = ex.Message;
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                if (_plc == null)
                {
                    lbMsg.Text = "请先连接";
                    return;
                }

                if (string.IsNullOrEmpty(cb_addr.Text))
                {
                    lbMsg.Text = "请输入地址";
                    return;
                }

                lbMsg.Text = "读取中";

                List<DataItem> dataItems = new List<DataItem>();
                var item = DataItem.FromAddress(cb_addr.Text);
                dataItems.Add(item);
                _plc.Open();
                _plc.ReadMultipleVars(dataItems);
                _plc.Close();
                var result = dataItems.First().Value.ToString();

                lbMsg.Text = result;
            }
            catch (PlcException ex)
            {
                lbMsg.Text = ex.Message;
            }

        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            try
            {
                if (_plc == null)
                {
                    lbMsg.Text = "请先连接";
                    return;
                }

                if (string.IsNullOrEmpty(cb_addr.Text))
                {
                    lbMsg.Text = "请输入地址";
                    return;
                }

                if (string.IsNullOrEmpty(txt_val.Text))
                {
                    lbMsg.Text = "请输入数据";
                    return;
                }

                lbMsg.Text = "写入中";

                List<DataItem> dataItems = new List<DataItem>();
                var item = DataItem.FromAddressAndValue(cb_addr.Text, txt_val.Text);

                dataItems.Add(item);
                _plc.Open();
                _plc.Write(dataItems.ToArray());
                _plc.Close();
                lbMsg.Text = "写入成功";
            }
            catch (PlcException ex)
            {
                lbMsg.Text = ex.Message;
            }

        }
    }
}
