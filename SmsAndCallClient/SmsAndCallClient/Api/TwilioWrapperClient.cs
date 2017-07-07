using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MatthiWare.SmsAndCallClient.Api
{
    public class TwilioWrapperClient : IClient
    {
        /// <summary>
        /// the authentication items
        /// </summary>
        private readonly string m_sid, m_auth;

        public TwilioWrapperClient(string sid, string auth)
        {
            m_sid = sid;
            m_auth = auth;
        }

        public bool CanCall { get { return true; } }

        public bool CanSendSms { get { return true; } }

        public bool FromNumberRequired { get { return true; } }

        public bool IsInitialized { get; set; }

        public void Init()
        {
            TwilioClient.Init(m_sid, m_auth);

            IsInitialized = true;
        }

        public async Task<IResponse> CallAsync(string from, string to, string msg)
        {
            var pnFrom = new PhoneNumber(from);
            var pnTo = new PhoneNumber(to);

            var body = WebUtility.UrlEncode(msg);

            var call = await CallResource.CreateAsync(
                pnTo,
                pnFrom,
                url: new Uri($"https://handler.twilio.com/twiml/EH551ae48b51b996d131ebe9a19372ad6f?body={body}"));

            return new CallResponse(call);
        }

        public async Task<IResponse> SendSmsAsync(string form, string to, string msg)
        {
            var pnFrom = new PhoneNumber(form);
            var pnTo = new PhoneNumber(to);

            var text = await MessageResource.CreateAsync(
                pnTo,
                from: pnFrom,
                body: msg);

            return new TextResponse(text);
        }

        public override string ToString()
        {
            return "Twilio API";
        }

        public class CallResponse : IResponse
        {
            private string m_sid;

            public bool CanUpdate { get { return true; } }

            public string Status { get; set; }

            public CallResponse(CallResource call)
            {
                SetCall(call);
            }

            private void SetCall(CallResource call)
            {
                m_sid = call.Sid;
                Status = call.Status.ToString();
            }

            public async Task UpdateAsync()
            {
                var call = await CallResource.FetchAsync(m_sid);
                SetCall(call);
            }
        }

        public class TextResponse : IResponse
        {
            private string m_sid;

            public bool CanUpdate { get { return true; } }

            public string Status { get; set; }

            public TextResponse(MessageResource call)
            {
                SetMessage(call);
            }

            private void SetMessage(MessageResource call)
            {
                m_sid = call.Sid;
                Status = call.Status.ToString();
            }

            public async Task UpdateAsync()
            {
                var call = await MessageResource.FetchAsync(m_sid);

                SetMessage(call);
            }
        }
    }
}
