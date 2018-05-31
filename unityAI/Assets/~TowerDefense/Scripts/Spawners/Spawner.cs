using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public float spawnRate = 1f;

        public float timer = 0f;

        public virtual void Spawn() {}

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if(timer >= spawnRate)
            {
                Spawn();
                timer = 0f;
            }
        }
    }
}