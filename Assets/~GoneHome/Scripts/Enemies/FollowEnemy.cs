using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
// Clean code: CTRL + K + D (In that order)

namespace GoneHome
{
    public class FollowEnemy : MonoBehaviour
    {
        public Transform target;

        private NavMeshAgent agent;

        // Use this for initialization
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(target.position);
        }
    }
}