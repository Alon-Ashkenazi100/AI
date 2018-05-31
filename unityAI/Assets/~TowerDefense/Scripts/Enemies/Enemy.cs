using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{ 
   
public class Enemy : MonoBehaviour
{
    public float health = 100f;

    public void DealDamage(float damage)
    {
          // Deal damage to enemy
          health -= damage;
          // If there is no health
          if(health <= 0)
          {
               // Kill off the GameObject
               Destroy(gameObject);
          }
       }	
	}
}
