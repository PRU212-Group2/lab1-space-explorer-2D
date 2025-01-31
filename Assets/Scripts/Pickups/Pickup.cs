using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    const string playerString = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerString))
        {
            OnPickup();
            Destroy(gameObject);
        }
    }
    
    protected abstract void OnPickup();
}
