using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        // Metoden under følger samme oppsett som "signaturen" til VideoEncoder klassen
        // "Egentlig" skal metoden sende Epost
        // Vi simulerer ved å skrive til konsollen
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email regarding {e.Video.Title}");
        }
    }
}
