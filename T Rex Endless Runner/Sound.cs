using System;
using NAudio.Wave;

namespace T_Rex_Endless_Runner
{
    public class Sound
    {
        private WaveStream _soundplayerBgStream;
        private WaveOut _soundplayerBgOut;
        private WaveStream _soundJumpplayerStream;
        private WaveOut _soundJumpplayerOut;
        private WaveStream _soundDeathplayerStream;
        private WaveOut _soundDeathplayerOut;

        public Sound()
        {
            var soundBgFile = System.IO.Directory.GetCurrentDirectory() + "\\sound\\runtrex.wav";
            var soundJumpFile = System.IO.Directory.GetCurrentDirectory() + "\\sound\\jump.wav";
            var soundDeathFile = System.IO.Directory.GetCurrentDirectory() + "\\sound\\death.wav";

            //initiate Background sound
            _soundplayerBgStream = new AudioFileReader(soundBgFile);
            _soundplayerBgOut = new WaveOut();
            _soundplayerBgOut.Init(_soundplayerBgStream);

            //initiate the shuthug
            _soundJumpplayerStream = new AudioFileReader(soundJumpFile);
            _soundJumpplayerOut = new WaveOut();
            _soundJumpplayerOut.Init(_soundJumpplayerStream);

            //initiate Background sound
            _soundplayerBgStream = new AudioFileReader(soundBgFile);
            _soundplayerBgOut = new WaveOut();
            _soundplayerBgOut.Init(_soundplayerBgStream);

            //initiate the shuthug
            _soundDeathplayerStream = new AudioFileReader(soundDeathFile);
            _soundDeathplayerOut = new WaveOut();
            _soundDeathplayerOut.Init(_soundDeathplayerStream);

            //start the sound
            _soundplayerBgOut.Play();
        }

        public void PlayJumpSound()
        {
            //if (_soundplayerBgOut.PlaybackState is PlaybackState.Playing) _soundplayerBgOut.Stop();
            if (_soundJumpplayerOut.PlaybackState is PlaybackState.Playing) _soundJumpplayerOut.Stop();

            //_soundplayerBgStream.CurrentTime = new TimeSpan(0L);
            _soundJumpplayerStream.CurrentTime = new TimeSpan(0L);
            _soundJumpplayerOut.Play();
            //_soundplayerBgOut.Play();

        }

        public void PlayDeathSound()
        {

            //if (_soundplayerBgOut.PlaybackState is PlaybackState.Playing) _soundplayerBgOut.Stop();
            if (_soundDeathplayerOut.PlaybackState is PlaybackState.Playing) _soundDeathplayerOut.Stop();

            _soundplayerBgStream.CurrentTime = new TimeSpan(0L);
            _soundDeathplayerStream.CurrentTime = new TimeSpan(0L);
            _soundDeathplayerOut.Play();
            _soundplayerBgOut.Play();

        }
    }


}
