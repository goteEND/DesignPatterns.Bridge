namespace DesignPatterns.Bridge.V1;

//abstraction
public interface IRemote
{
  void TogglePower();
  void VolumeDown();
  void VolumeUp();
  void ChannelDown();
  void ChannelUp();
}
