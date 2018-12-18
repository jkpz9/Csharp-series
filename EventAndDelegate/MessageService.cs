using System;

namespace EventAndDelegate
{
    public class MessageService
    {
        public void OnVideoEncoded(object src, VideoEventArgs eas)
        {
            Console.WriteLine("Message Service sending a TEXT ..." + eas.video.Title);
        }
    }
}
