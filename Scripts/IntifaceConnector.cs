using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace IntifaceConnectorPlugin.Scripts {
    public class IntifaceConnector : MonoBehaviour {
        public static Action onClientInit;
        public static Action onNewDevice;
        public static bool clientInitialized { get; private set; }

        [DllImport("__Internal")] private static extern void _Vibe(int _intesity);

        public int intensity { get; private set; }

        public void Vibe(int newIntensity) {
            intensity = Mathf.Clamp(newIntensity, 0, 100);
            UpdateDevices();
        }
        
        public void OnClientInit() {
            clientInitialized = true;
            onClientInit?.Invoke();
        }
        
        public void OnNewDevice() {
            UpdateDevices();
            onNewDevice?.Invoke();
        }

        private void UpdateDevices() {
            _Vibe(intensity);
        }
    }
}