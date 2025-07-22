using System;
using UnityEngine;

public class CatapultAnchorMover : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    [SerializeField] private float _startPositionY;
    [SerializeField] private float _endPositionY;

    private void Start()
    {
        transform.transform.position = new Vector3(transform.position.x, _startPositionY, transform.position.z);
    }

    private void OnEnable()
    {
        _input.Shooting += OnShooting;
        _input.CatapultLoading += OnLoading;
    }

    private void OnDisable()
    {
        _input.Shooting -= OnShooting;
        _input.CatapultLoading -= OnLoading;
    }

    private void OnShooting()
    {
        transform.position = new Vector3(transform.position.x, _endPositionY, transform.position.z);
    }

    private void OnLoading()
    {
        transform.position = new Vector3(transform.position.x, _startPositionY, transform.position.z);
    }
}
