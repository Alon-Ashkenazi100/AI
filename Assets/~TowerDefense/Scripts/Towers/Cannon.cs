using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    // Cannon "Is a" Tower
    public class Cannon : Tower
    {
        public Transform barrel;
        public float lineDelay = .2f;

        private LineRenderer line;

        // Use this for initialization
        void Awake()
        {
            line = GetComponent<LineRenderer>();
        }

        public override void Aim(Enemy e)
        {
            // Rotate the barrel to look at target enemy
            barrel.LookAt(e.transform);
            // Draw a line from center point...
            line.SetPosition(0, transform.position);
            // ...To barrel
            line.SetPosition(1, barrel.position);
            // ...To enemy
            line.SetPosition(2, e.transform.position);
        }

        public override void Attack(Enemy e)
        {
            // Enable the line
            line.enabled = true;
            // Deal damage to enemy
            e.DealDamage(damage);
        }
    }
}
