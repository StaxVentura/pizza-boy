using UnityEngine;

namespace Script
{
    public class MoveForward : MonoBehaviour
    {
        public enum PrefabType
        {
            Border,
            Pug,
            Dober,
            Projectile
        }

        public PrefabType type;
        private float speed;

        // Update is called once per frame
        private void Update()
        {
            speed = type switch
            {
                PrefabType.Projectile => 40.0f,
                PrefabType.Border => 8.0f,
                PrefabType.Pug => 10.0f,
                PrefabType.Dober => 12.0f,
                _ => speed
            };

            transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }
    }
}
