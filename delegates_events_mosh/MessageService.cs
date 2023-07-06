using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        // Metoden under følger samme oppsett som "signaturen" til VideoEncoder klassen
        // "Egentlig" skal metoden sende tekstmelding
        // Vi simulerer ved å skrive til konsollen
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"MessageService: Sending a text message regarding {args.Video.Title}");
        }
    }
}