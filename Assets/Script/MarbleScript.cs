using UnityEngine;

namespace Script
{
    public class MarbleScript : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Hole"))
                Destroy(gameObject);
        }
    }
}