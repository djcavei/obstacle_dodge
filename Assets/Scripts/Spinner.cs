using UnityEngine;

public class Spinner : MonoBehaviour
{
     [SerializeField] private float x, y = 70f, z;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x,  y * Time.deltaTime, z);
    }
    
}
