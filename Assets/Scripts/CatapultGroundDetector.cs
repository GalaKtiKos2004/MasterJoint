using System;
using UnityEngine;

public class CatapultGroundDetector : MonoBehaviour
{
    [SerializeField] private LayerMask _groundLayer;

    public event Action CatapultGrounded;

    private void OnCollisionEnter(Collision other)
    {
        if ((_groundLayer.value & (1 << other.gameObject.layer)) != 0)
        {
            Debug.Log("Catapult ground detected");
            CatapultGrounded?.Invoke();
        }
    }
}
