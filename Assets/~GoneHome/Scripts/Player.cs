using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float movementSpeed = 10f;

        private Rigidbody rigid;

        private Transform cam; // << Added this!

        private float currentY;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            cam = Camera.main.transform; //<<ADDED
        }

        // Update is called once per frame
        void Update()
        {
            Movement();
            Rotation();
        }

        void Rotation()
        {
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                currentY += 90;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                currentY -= 90;
            }

            Quaternion rotation = Quaternion.AngleAxis(currentY, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0.1f);
        }
        void Movement()
        {
        
            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = transform.forward * inputV;

            // Copy position
            Vector3 position = transform.position;
            // Offset the new position
            position += inputDir * movementSpeed * Time.deltaTime;
            // Apply new position to rigidbody
            rigid.MovePosition(position);
        }
    }
}