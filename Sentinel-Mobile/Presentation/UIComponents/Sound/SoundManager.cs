using System;

using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace Sentinel_Mobile.Presentation.UIComponents.Sound
{
    public class SoundManager
    {
        public static string StartupPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        public static string path = Path.Combine(StartupPath, "Resources\\");
        public static string SUCCESS_PATH = path + "sucess.wav";
        public static string ERROR_PATH = path + "error.wav";

        //Importation de l'API de windows CE
        [DllImport("coredll.dll", EntryPoint = "PlaySound", SetLastError = true)]
        static extern bool PlaySound(string lpszName, int hModule, int dwFlags);


        public enum SoundFlag : int
        {
            SND_ALIAS = 0x00010000,     // name is a WIN.INI [sounds] entry
            SND_ASYNC = 0x00000001,     // play asynchronously
            SND_FILENAME = 0x00020000,  // name is a file name
            SND_LOOP = 0x00000008,      // loop the sound until next sndPlaySound
            SND_MEMORY = 0x00000004,    // lpszSoundName points to a memory file
            SND_NODEFAULT = 0x00000002, // silence not default, if sound not found
            SND_NOSTOP = 0x00000010,    // don't stop any currently playing sound
            SND_NOWAIT = 0x00002000,    // don't wait if the driver is busy
            SND_RESOURCE = 0x00040004,  // name is a resource name or atom
            SND_SYNC = 0x00000000,      // play synchronously (default)
        }

        public static void PlaySoundSuccess()
        {
            PlaySound(SUCCESS_PATH, 0, (int)(SoundManager.SoundFlag.SND_ASYNC));
        }

        public static void PlaySoundError()
        {
            PlaySound(ERROR_PATH, 0, (int)(SoundManager.SoundFlag.SND_ASYNC));
        }
    }
}
