# UnityIntifaceWebGLConnector

In `Asset` folder execute `git clone git@github.com:wompi72/UnityIntifaceWebGLConnector.git WebGLTemplates/`

It's important that the folder is called `WebGLTemplates` and placed directly in the `Assets` directory.

In the `Project Settings/Player` you can now select `IntifaceTemplate` as your WebGL Template.

Methods in the `IntifaceConnector.cs` shouldn't be called before the `clientInitialized` is true or the `onClientInit` is invoked.