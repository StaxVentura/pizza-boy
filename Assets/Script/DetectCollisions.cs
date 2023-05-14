using UnityEngine;

namespace Script
{
    public class DetectCollisions : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}