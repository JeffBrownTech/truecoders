using System;

namespace InterfaceDemo;

public class AudioPlayer : IMediaPlayer
{
    public void Pause()
    {
        Console.WriteLine("⏸️ Pausing audio...");
    }

    public void Play()
    {
        Console.WriteLine("▶️ Playing audio...");
    }

    public void Stop()
    {
        Console.WriteLine("⏹️ Stopping audio...");
    }
}
