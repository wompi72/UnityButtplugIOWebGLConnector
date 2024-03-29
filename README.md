# UnityIntifaceWebGLConnector

In `Asset` folder execute `git clone git@github.com:wompi72/UnityIntifaceWebGLConnector.git`

Create the `WebGLTemplates` directory (in `Assets`) and move or copy the `IntifaceTemplate` directory into that directory.

In the `Project Settings/Player` you can now select `IntifaceTemplate` as your WebGL Template.

Methods in the `IntifaceConnector.cs` shouldn't be called before the `clientInitialized` is true or the `onClientInit` is invoked.