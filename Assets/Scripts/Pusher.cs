using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Pusher : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    [SerializeField] private float _pushForce;
    
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _input.Pushing += OnPushing;
    }

    private void OnDisable()
    {
        _input.Pushing -= OnPushing;
    }

    private void OnPushing()
    {
        _rigidbody.AddForce(transform.forward * _pushForce, ForceMode.Impulse);
    }
}
