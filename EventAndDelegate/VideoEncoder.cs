using System;
using System.Threading;

namespace EventAndDelegate
{
    public class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object src, VideoEventArgs e);// 1. Define a delegate

        //public event VideoEncoderEventHandler VideoEncoded;// 2. Define an event

        public event EventHandler<VideoEventArgs> VideoEncoded;

        // 3. Raise the event

        // EventHandler
        // EventHandler<TEventArgs>

        public void Encode(Video v)
        {
            Console.WriteLine("Encoding video ....");
            Thread.Sleep(3000);

            OnVideoEncoded(v);
        }

        protected virtual void OnVideoEncoded(Video v)
        {
            // The old way
            //if (VideoEncoded != null)
            //{
            //    VideoEncoded(this, new VideoEventArgs() { video = v });
            //}
            VideoEncoded?.Invoke(this, new VideoEventArgs() { video = v });
        }
    }
}
