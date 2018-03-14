using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace GoneHome
{
    public class Death : MonoBehaviour
    {
        public UnityEvent onDeath;

        // Gets called when Triggered by other object
        void OnTriggerEnter(Collider other)
        {
            // If it bleeds
            if (other.name.Contains ("DeathZone") ||
                other.name.Contains ("Enemy"))
            {
                // We can kill it!
                onDeath.Invoke();
            }
        }
     }
  }
