using UnityEngine;

public class TriggerVolume : MonoBehaviour
{

    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject projectile1;
    [SerializeField] private GameObject projectile2;
    [SerializeField] private GameObject projectile3;
    private bool _stop;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !_stop)
        {
            _stop = true;
            projectile.SetActive(true);
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
        }
    }
    
}
