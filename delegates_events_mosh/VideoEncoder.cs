using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {

        // Steg 1 - Definer en delegate (kontrakt mellom avsender, altså denne klassen,
-       // og alle subscribere som lytter til endringer i denne klassen)
        // Parameteren objekt er en instans av VideoEncoder klassen
        // Parameteren  EventArgs er eventuell tillegsdata om eventen vi ønsker å legge til
        // Navnet følger konvensjonen navn-på-event + EventHandler

        // tror dette kalles "signature", her definerer vi "signature"
         public delegate void VideoEncodedEventHandler(object source, EventArgs args); 

        // Steg 2
        // Definer en event basert på delegaten over
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            // Steg 3 (delsteg)
            // kall på funksjon som publiserer endringer i klassen, til alle som lytter på (når alt over er ferdig)
            // i stedet for mange linjer inni denne funskjonen der jeg kaller på meldinger, telefon, pc osv manuelt
            OnVideoEncoded();
        }

        // Steg 3: Raise/publish the event, dvs lag method som publiserer endringer til ALLE som lytter på
        //(delsteg: lag method som publiserer endringer til alle groupies som abonnerer)
        // protected virtual void er konvensjon
        // Navnekonvensjon også med On + navn-på-event
        protected virtual void OnVideoEncoded() 
        {
            if (VideoEncoded != null) // stemmer denne betyr det at det finnes subscribere
            {
                // this viser til denne instansen av klassen, EventArgs.Empty lager en tom EventArgs
                // mao, man legger ikke med tilleggsdata
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}