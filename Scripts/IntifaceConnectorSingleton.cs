using System;
using UnityEngine;

namespace IntifaceConnectorPlugin.Scripts {
    public class IntifaceConnectorSingleton : IntifaceConnector {
        public static IntifaceConnectorSingleton Instance { get; protected set; }
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