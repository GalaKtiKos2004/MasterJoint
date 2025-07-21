using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private KeyCode _pushButton = KeyCode.P;

    public event Action Pushing;
    
    private void Update()
    {
        if (Input.GetKeyDown(_pushButton))
        {
            Pushing?.Invoke();
        }
    }
}
