using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float movementSpeed = 10f;

        private Rigidbody rigid;

        private Transform cam; // << ADDED

        private float currentY = 180;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            cam = Camera.main.transform; //<<ADDED
        }

        // Update is called once per frame
        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            // Rotate input to face direction of Camera (flat on surface)
            inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;

            // Copy position
            Vector3 position = transform.position;
            // Offset to the new position
            position += inputDir * movementSpeed * Time.deltaTime;
            // Apply new position to rigidbody
            rigid.MovePosition(position);
        }
    }
} 