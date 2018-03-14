using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float movementSpeed = 10f;
        public float maxVelocity = 10f;
        public GameObject deathParticles;

        private Rigidbody rigid;
        private Transform cam; // << ADDED
        private Vector3 spawnPoint;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            cam = Camera.main.transform; //<<ADDED
            // Record starting position
            spawnPoint = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");
            Vector3 inputDir = new Vector3(inputH, 0, inputV);
            // Rotate input to face direction of Camera (flat on surface)
            inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;
            // Add force to rigidbody
            rigid.AddForce(inputDir * movementSpeed);
            // Copy velocity into smaller variable
            Vector3 vel = rigid.velocity;
            // Check if vel's magnitude is greater than max velocity
            if (vel.magnitude > maxVelocity)
            {
                // Cap the velocity
                vel = vel.normalized * maxVelocity;
            }
            // Apply the new velocity to rigidbody
            rigid.velocity = vel;
        }
        // Folds Code: CTRL + M + O

        public void Reset()
        {  
            // Spawn death particles where we reset
            Instantiate(deathParticles, transform.position, transform.rotation);
            // Reset position of the player to start position
            transform.position = spawnPoint;
            // Reset the velocity
            rigid.velocity = Vector3.zero;
        }
    }
}
