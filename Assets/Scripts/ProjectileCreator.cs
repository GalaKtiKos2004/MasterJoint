using System;
using UnityEngine;

public class ProjectileCreator : MonoBehaviour
{
    [SerializeField] private InputReader _input;
    [SerializeField] private CatapultGroundDetector _groundDetector;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Rigidbody _projectilePrefab;

    private bool _isSpawned = false;

    private void OnEnable()
    {
        _input.Shooting += OnShooting;
        _groundDetector.CatapultGrounded += Load;
    }

    private void OnDisable()
    {
        _input.Shooting -= OnShooting;
        _groundDetector.CatapultGrounded -= Load;
    }

    private void OnShooting() =>
        _isSpawned = false;

    private void Load()
    {
        if (_isSpawned)
        {
            return;
        }
        
        Instantiate(_projectilePrefab, _spawnPoint.position, Quaternion.identity);
        _isSpawned = true;
    }
}
