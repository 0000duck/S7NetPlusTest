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
                if (_plc == null)
                {
                    lbMsg.Text = "连接中";
                    _plc = new Plc(CpuType.S71200, txtIp.Text, 0, 1);
                    _plc.Open();
                    lbMsg.Text = "连接成功";
                }
                else
                {
                    lbMsg.Text = "断开中";
                    _plc.Close();
                    _plc = null;
                    lbMsg.Text = "断开成功";
                }
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
                lbMsg.Text = "读取中";

                List<DataItem> dataItems = new List<DataItem>();
                var item = DataItem.FromAddress(txt_addr.Text);
                dataItems.Add(item);

                _plc.ReadMultipleVars(dataItems);

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
                lbMsg.Text = "写入中";

                List<DataItem> dataItems = new List<DataItem>();
                var item = DataItem.FromAddressAndValue<string>(txt_addr.Text, txt_val.Text);
                dataItems.Add(item);

                _plc.Write(dataItems.ToArray());

                lbMsg.Text = "写入成功";
            }
            catch (PlcException ex)
            {
                lbMsg.Text = ex.Message;
            }

        }
    }
}
