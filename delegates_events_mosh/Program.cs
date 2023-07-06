using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Gladiatoren" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            // Her ordner vi subscription for alle subscribers
            // format er publisher.event 
            // vi registerer en handler for the event
            // handleren er metoden OnVideoEncoded i klassen MailService
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // dette er en pointer
                                                                    // det pekes til mailService.OnVideoEncoded methoden
                                                                    // dette er ikke et funksjonskall, kun en pointer
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    // under lager vi en del subscribere som følger med på endringer
    // i VideoEncoder klassen
    // ble flyttet til egne filer, se:
    // MailService.cs
    // MessageService.cs

}
