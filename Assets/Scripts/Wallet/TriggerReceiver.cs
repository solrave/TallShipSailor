using System;
using UnityEngine;

namespace Wallet
{
    public class TriggerReceiver : MonoBehaviour
    {
        public event Action<Collider> TriggerEntered;

        private void OnTriggerEnter(Collider other)
        {
            TriggerEntered?.Invoke(other);
        }
    }
}