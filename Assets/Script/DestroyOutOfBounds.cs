using UnityEngine;

namespace Script
{
    public class DestroyOutOfBounds : MonoBehaviour
    {
        private readonly float topBound = 30.0f;
        private readonly float lowerBound = -10.0f;

        // Update is called once per frame
        private void Update()
        {
            // Destroy Object after leaving viewport
            if (transform.position.z > topBound || transform.position.z < lowerBound)
            {
                Destroy(gameObject);
            }
        }
    }
}