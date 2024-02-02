namespace DesignPatterns.Bridge.V1;

public class Tv : IDevice
{
  private bool _isEnabled = false;
  private readonly int _minVolume = 0;
  private readonly int _maxVolume = 100;
  private int _volume = 5;
  private readonly int _minChannel = 1;
  private readonly int _maxChannel = 64;
  private int _channel = 1;

  public bool IsEnabled() => _isEnabled;

  public void Enable()
  {
    _isEnabled = true;
    Console.WriteLine("TV is turned on");
  }

  public void Disable()
  {
    _isEnabled = false;
    Console.WriteLine("TV is turned off");
  }

  public int GetVolume() => _volume;

  public void SetVolume(int volume)
  {
    if (!_isEnabled)
    {
      Console.WriteLine("Can't set volume, TV is turned off");
      return;
    }
    _volume = Math.Max(_minVolume, Math.Min(_maxVolume, volume));
    Console.WriteLine($"TV volume is set to {_volume}");
  }

  public int GetChannel() => _channel;

  public void SetChannel(int channel)
  {
    if (!_isEnabled)
    {
      Console.WriteLine("Can't set channel, TV is turned off");
      return;
    }
    _channel = Math.Max(_minChannel, Math.Min(_maxChannel, channel));
    Console.WriteLine($"TV channel is set to {_channel}");
  }
}
