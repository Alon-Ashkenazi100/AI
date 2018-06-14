using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace TowerDefense
{ 
   
    public class Enemy : MonoBehaviour
    {
        public float maxHealth = 100f;
        [Header("UI")]
        public GameObject healthBarUI;
        public Vector2 healthBarOffset = new Vector2(0f, 5f);

        private Slider healthSlider;
        private float health = 100f;

        void Start()
        {
            health = maxHealth;
        }

        // Gets called when the GameObject gets disabled
        void OnDestroy()
        {
            // If there is a health slider created
            if (healthSlider)
            {
                // Destroy it
                Destroy(healthSlider.gameObject);
            }
        }
    
    // Converts Enemy world position for health bar
    Vector3 GetHealthBarPos()
    {
            Camera cam = Camera.main;
            Vector2 position = cam.WorldToScreenPoint(transform.position);
            return position + healthBarOffset;
    }
    
    void Update()
    {
        // If there is a health slider
        if (healthSlider)
        {
            // Update it's position in UI
            healthSlider.transform.position = GetHealthBarPos();
        }
    }

        public void SpawnHealthBar(Transform parent)
        {
            // Create new health bar at calculated position
            // and attached to the new parent
            GameObject clone = Instantiate(healthBarUI,
                                           GetHealthBarPos(),
                                           Quaternion.identity,
                                           parent);
            // Get the slider component for later user
            healthSlider = clone.GetComponent<Slider>();
        }
        public void DealDamage(float damage)
        {
            // Deal damage to enemy
            health -= damage;
            // Update the slider
            if(healthSlider)
            {
                // Convert health to a 0-1 value
                healthSlider.value = health / maxHealth;
            }
            // If there is no health
            if(health <= 0)
          {
               // Kill off the GameObject
               Destroy(gameObject);
          }
       }	
	}
}
