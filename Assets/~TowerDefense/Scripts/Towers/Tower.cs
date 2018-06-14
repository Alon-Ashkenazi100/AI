using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    // Tower "is a" MonoBehaviour
    public class Tower : MonoBehaviour
    {
        public float damage = 10f;
        public float attackDelay = 1f;

        // Tower "has an" enemy
        protected Enemy currentEnemy;

        public float attackTimer = 0f;

        public virtual void Aim(Enemy e) { }
        public virtual void Attack(Enemy e) { }

        // Update is called once per frame
        protected virtual void Update()
        {
            attackTimer += Time.deltaTime;
            // If the tower is targeting an enemy
            if (currentEnemy)
            {
                Aim(currentEnemy);
                if (attackTimer >= attackDelay)
                {
                    Attack(currentEnemy);
                    attackTimer = 0f;
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Enemy hitEnemy = other.GetComponent<Enemy>();
            if (hitEnemy && currentEnemy == null)
            {
                currentEnemy = hitEnemy;
            }
        }
        private void OnTriggerStay(Collider other)
        {
            Enemy hitEnemy = other.GetComponent<Enemy>();
            if (hitEnemy && currentEnemy == null)
            {
                currentEnemy = hitEnemy;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            Enemy hitEnemy = other.GetComponent<Enemy>();
            if (hitEnemy && currentEnemy == hitEnemy)
            {
                currentEnemy = null;
            }
        } 
    }
}
