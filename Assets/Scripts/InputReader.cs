using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private KeyCode _pushButton = KeyCode.P;
    [SerializeField] private KeyCode _shootingButton = KeyCode.Space;
    [SerializeField] private KeyCode _catapultLoadingButton = KeyCode.Return;

    public event Action Pushing;
    public event Action Shooting;
    public event Action CatapultLoading;
    
    private void Update()
    {
        if (Input.GetKeyDown(_pushButton))
        {
            Pushing?.Invoke();
        }

        if (Input.GetKeyDown(_shootingButton))
        {
            Shooting?.Invoke();
        }

        if (Input.GetKeyDown(_catapultLoadingButton))
        {
            CatapultLoading?.Invoke();
        }
    }
}
