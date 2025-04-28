using UnityEngine;

public class FlyToPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 playerPosition;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private GameObject player;
    [SerializeField] private float maxDistanceDelta = 10f;

    private void Start()
    {
        playerPosition = GameObject.FindWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, maxDistanceDelta * Time.deltaTime);
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}