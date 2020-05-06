using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using AudioSwitcher.AudioApi.CoreAudio;
using Enkonos.Model;

namespace Enkonos.Managers
{
    public class VolumeManager
    {
        public ResponseModel VolumeChange(double value)
        {
            try
            {
                CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                Debug.WriteLine("Current Volume:" + defaultPlaybackDevice.Volume);
                defaultPlaybackDevice.Volume = value;
                return new ResponseModel
                {
                    Ok = true,
                    Data = new {value = value},
                    Error = null
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Ok = false,
                    Data = null,
                    Error = ex.Message
                };
            }

    }
}
