using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace GoneHome
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onEnter;

        // Trigger function called when other object enters
        void OnTriggerEnter(Collider other)
        {
            if (other.name == "Player")
            {
                onEnter.Invoke();
            }

        }
    }
}