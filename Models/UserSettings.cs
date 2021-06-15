// Decompiled with JetBrains decompiler
// Type: RiftLauncher.Models.UserSettings
// Assembly: RiftLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03061649-5402-41ED-BA6A-E445B8CDF1BD
// Assembly location: C:\Users\glitc\Desktop\BetterFN-Update=2.8\Launcher\BetterFNLauncher.exe

using Newtonsoft.Json;

namespace RiftLauncher.Models
{
  public class UserSettings
  {
    [JsonProperty("secret")]
    public string Secret { get; set; }

    [JsonProperty("currentInstall")]
    public string CurrentInstall { get; set; }
  }
}
