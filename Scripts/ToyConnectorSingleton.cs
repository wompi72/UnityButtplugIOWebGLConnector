using System;
using UnityEngine;

namespace IntifaceConnectorPlugin.Scripts {
    public class ToyConnectorSingleton : ToyConnector {
        public static ToyConnectorSingleton Instance { get; protected set; }
        private void Awake() {
            if (Instance != null && Instance != this) {
                Destroy(gameObject);
            } else {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}