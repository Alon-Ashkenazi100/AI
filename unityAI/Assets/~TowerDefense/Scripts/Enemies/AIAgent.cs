using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

namespace TowerDefense
{

    public class AIAgent : MonoBehaviour
    {
        public Transform target;

        private NavMeshAgent nav;

        // Use this for initialization
        void Awake()
        {
            // Use reference to nav mesh
            nav = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            // If there is a target
            if(target)
            {
                nav.SetDestination(target.position);
            }
        }
    }
}
