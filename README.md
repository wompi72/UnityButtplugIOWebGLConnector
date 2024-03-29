# UnityButtplugIOWebGLConnector

Clone the project into your `Assets` directory.

Create the `WebGLTemplates` directory (in `Assets`) and move or copy the `IntifaceTemplate` directory into that directory.

In the `Project Settings/Player` you can now select `IntifaceTemplate` as your WebGL Template.

Add a GameObject named `ToyConntector` to your first scene and add the `ToyConntector` or `ToyConntectorSingleton` script.
Use the methods of those scripts to control toys.

## Testing XToys integration:
The [itch.io script](https://xtoys.app/scripts/-NtDUDJZeeKhInEXcS-4) can be edited to work for other urls (e.g. localhost)

# For Users:
## Connect Vibrator:
### [Intiface](https://intiface.com/): 
Start Server, connect your device and press the Connect Intiface button under the game.
### [XToys](https://xtoys.app/): 
Install the [Webpage Monitor](https://guide.xtoys.app/tools/webpage-monitor.html). Load the [itch.io script](https://xtoys.app/scripts/-NtDUDJZeeKhInEXcS-4) on XToys connect your device and start it. Press the XToys Redirect button and make sure the Webpage Monitor is active on the page.