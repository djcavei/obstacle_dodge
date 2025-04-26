using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.tag = "Hit";
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }

}
