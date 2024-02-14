using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChanger : MonoBehaviour
{
    [SerializeField] private PlayerForm _form;
    
    [SerializeField] private PlayerControllerStats _stats;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _stats.SetForm(_form);
        }
    }
}
