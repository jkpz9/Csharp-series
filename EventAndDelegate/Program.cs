using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Video v = new Video() { Title = "Video 1" };
            VideoEncoder videoEncoder = new VideoEncoder();// Publisher
            MailService mailService = new MailService();// Subscriber
            MessageService messageService = new MessageService(); // Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(v);
        }
    }
}
