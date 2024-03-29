mergeInto(LibraryManager.library, {
  
  _Vibe: function (intensity) {
    vibe_intensity.innerText = "vibe:" + intensity + "|ramp:0";
    
    if (buttplug_client === null || !buttplug_client.connected) {
      return
    }
    for (const device of buttplug_client.devices) {
      device.vibrate(intensity / 100);
    }
  },
});