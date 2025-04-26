using UnityEngine;

public class Dropper : MonoBehaviour
{
    private bool _fallen;
    [SerializeField] float timeToWait = 2f;
    
    private MeshRenderer _meshRenderer;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        _meshRenderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_rigidbody.useGravity && Time.time > timeToWait)
        {
            _meshRenderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
    
}
