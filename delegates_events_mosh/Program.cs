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

            // Her ordner vi subscription for alle subscribers
            // format er publisher.event 
            // vi registerer en handler for the event
            // handleren er metoden OnVideoEncoded i klassen MailService
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    // under lager vi en del subscribere som følger med på endringer
    // i VideoEncoder klassen

    public class MailService
    {
        // Metoden under følger samme oppsett som "signaturen" til VideoEncoder klassen
        // "Egentlig" skal metoden sende Epost
        // Vi simulerer ved å skrive til konsollen
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}
