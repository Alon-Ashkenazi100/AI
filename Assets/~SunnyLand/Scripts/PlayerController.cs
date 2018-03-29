using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5f; // movement speed
        public int health = 100;
        public int damage = 50;
        public float hitForce = 4f; //Force applied when players hits an object
        public float damageForce = 4f; // Force applied when player is hit by object
        public float maxVelocity = 3f; // Maximum Velocity to limit the player to
        public float maxSlopeAngle = 45f; // Maximum angle the player can walk up
        [Header("Grounding")]
        public float rayDistance = .5f; // Distance of ground ray detector
        public bool isGrounded = false;
        [Header("Crouch")]
        public bool isCrouching = false;
        [Header("Jump")]
        public float jumpHeight = 2f; // Height that the player can jump to
        public int maxJumpCount = 2; // How many multi-jumps the player can do max
        public bool isJumping = false;
        [Header("Climb")]
        public float climbSpeed = 5f;
        public bool isClimbing = false;
        public bool isOnSlope = false;

        private Vector3 groundNormal = Vector3.up;
        private int currentJump = 0;
        private float inputH, inputV;
        // References
        private SpriteRenderer rend;
        private Rigidbody2D rigid;

        #region Unity Functions
        // Use this for initialization
        void Awake()
        {
            rend = GetComponent<SpriteRenderer>();
            rigid = GetComponent<Rigidbody2D>();
        }
        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Custom Functions
        public void Jump()
        {

        }
        public void Crouch()
        {

        }
        public void UnCrouch()
        {

        }
        public void Move(float horizontal)
        {

        }
        public void Climb(float vertical)
        {

        }
        public void Hurt(int damage)
        {

        }

        private void DetectGround()
        {

        }
        private void CheckGround(RaycastHit2D hit)
        {

        }
        private void CheckEnemy(RaycastHit2D hit)
        {

        }
        private void LimitVelocity()
        {

        }
        private void StopClimbing()
        {

        }
        private void DisablePhysics()
        {

        }
        private void EnablePhysics()
        {

        }
        #endregion
    }
}
