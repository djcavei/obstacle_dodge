using UnityEngine;

public class TriggerVolume : MonoBehaviour
{

    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject projectile1;
    [SerializeField] private GameObject projectile2;
    [SerializeField] private GameObject projectile3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            projectile.SetActive(true);
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            Destroy(gameObject);
        }
    }
    
}
