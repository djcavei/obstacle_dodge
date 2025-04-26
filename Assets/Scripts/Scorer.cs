using UnityEngine;

public class Scorer : MonoBehaviour
{
    int _times;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            ++_times;
            Debug.Log("You bumped into object " + _times + " times");     
        }  
    }
}
