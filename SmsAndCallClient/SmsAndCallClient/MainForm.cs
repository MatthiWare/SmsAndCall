using SmsAndCallClient.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsAndCallClient
{
    public partial class MainForm : Form
    {
        private IClient m_currentApi;
        private IResponse m_lastResponse;

        public MainForm()
        {
            InitializeComponent();
            LoadAPIs();
        }

        private void LoadAPIs()
        {
            //cbApis.Items.Add(new ClickatellWrapperClient(Credentials.CLICKATELL_API_KEY));
            //cbApis.Items.Add(new TwilioWrapperClient(Credentials.TWILIO_ACC_SID, Credentials.TWILIO_AUTH_TOKEN));
        }

        private void cbApis_SelectedValueChanged(object sender, EventArgs e)
        {
            m_currentApi = cbApis.SelectedItem as IClient;

            if (m_currentApi == null)
                return;

            if (!m_currentApi.IsInitialized)
                m_currentApi.Init();

            cbCall.Checked = m_currentApi.CanCall;
            cbSms.Checked = m_currentApi.CanSendSms;

            btnCall.Enabled = m_currentApi.CanCall;
            btnText.Enabled = m_currentApi.CanSendSms;

            txtFrom.Enabled = m_currentApi.FromNumberRequired;
        }

        private async void btnText_Click(object sender, EventArgs e)
        {
            btnText.Enabled = false;

            string from = txtFrom.Text;
            string to = txtTo.Text;
            string body = txtBody.Text;

            SetStatus("Sending...");

            m_lastResponse = await m_currentApi.SendSmsAsync(from, to, body);


            btnText.Enabled = true;
            SetStatus();
        }

        private async void btnCall_Click(object sender, EventArgs e)
        {
            btnCall.Enabled = false;

            string from = txtFrom.Text;
            string to = txtTo.Text;
            string body = txtBody.Text;

            SetStatus("Sending...");

            m_lastResponse = await m_currentApi.CallAsync(from, to, body);

            btnCall.Enabled = true;
            SetStatus();
        }

        private void SetStatus()
        {
            if (m_lastResponse == null)
                return;

            SetStatus(m_lastResponse.Status);
        }

        private void SetStatus(string value)
        {
            lblStatus.Text = $"Status: {value}";
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (m_lastResponse == null || !m_lastResponse.CanUpdate)
                return;

            await m_lastResponse.UpdateAsync();

            SetStatus();
        }
    }
}
