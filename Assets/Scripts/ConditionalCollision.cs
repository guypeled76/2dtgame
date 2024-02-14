using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalCollision : MonoBehaviour
{
    
    [SerializeField] private PlayerControllerStats _playerStats;

    [SerializeField] private PlayerForm _playerForm;
    
    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();

        OnPlayerFormChanged(_playerStats.form);
    }

    private void OnEnable()
    {
        _playerStats.FormChanged += OnPlayerFormChanged;
    }

    private void OnDisable()
    {
        _playerStats.FormChanged -= OnPlayerFormChanged;
    }

    private void OnPlayerFormChanged(PlayerForm form)
    {
        _collider.enabled = _playerForm != form;
    }
}
