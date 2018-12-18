using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object src, VideoEventArgs eas)
        {
            Console.WriteLine("Mail Service sending an email ..." + eas.video.Title);
        }
    }
}
