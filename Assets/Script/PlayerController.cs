using UnityEngine;

namespace Script
{
    public class PlayerController : MonoBehaviour
    {
        //Public Variables
        public GameObject projectilePrefab;

        //Private Variables
        private readonly float moveSpeed = 30.0f;
        private float horizontalInput;
        private readonly float xRange = 25;

        // Update is called once per frame
        private void Update()
        {
            // Input Axis
            horizontalInput = Input.GetAxis("Horizontal");

            // Move Player left and right
            transform.Translate(horizontalInput * moveSpeed * Time.deltaTime * Vector3.right);

            // Reposition of player moving out the viewport
            if (transform.position.x > xRange) transform.Translate( -(xRange * 2), 0, 0);
            if (transform.position.x < -xRange) transform.Translate((xRange * 2), 0, 0);

            if (Input.GetKeyDown(KeyCode.Space)) {

                // Shoot projectiles by pressing space bar
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
        }
    }
}
