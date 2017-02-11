using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WebTool.V1.Model
{
    class PingerClass
    {
        public static bool PingVerification(string ip)
        {
            try
            {
                Ping pinger = new Ping();
                PingReply pingReply = pinger.Send(ip, 300);

                if (pingReply.Status == IPStatus.Success)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }
    }
}
