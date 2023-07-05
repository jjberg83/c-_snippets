using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 3 steg
        // 1 - Definer en delegate (kontrakt mellom avsender, altså denne klassen
        // , og alle subscribere som lytter til endringer i denne klassen )
        // 2 - Definer en event basert på delegaten over
        // 3 - Raise/publish the event, dvs lag method som publiserer endringer
        // og kall denne funksjonen

        // Steg 1
        // Parameteren objekt er en instans av VideoEncoder klassen
        // Parameteren  EventArgs er eventuell tillegsdata om eventen vi ønsker å legge til
        // Navnet følger konvensjonen navn-på-event + EventHandler
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // Steg 2
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            // Steg 3 (delsteg)
        }

        // Steg 3 (delsteg: lag method som publiserer endringer til alle groupies som abonnerer
        // protected virtual void er konvensjon
        // Navnekonvensjon også med On + navn-på-event
        protected virtual void OnVideoEncoded() 
        {

        }
    }
}