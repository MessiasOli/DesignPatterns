using Bridge.Platforms;
using Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }
        
        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitles();
            live.Comments();
            live.Recording();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartLiveAdvanced(new YouTube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
            StartLiveAdvanced(new DLive());

            Console.Read();
        }
    }
}
