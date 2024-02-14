using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerControllerStats : ScriptableObject
{
    public event Action<PlayerForm> FormChanged;

    [SerializeField] private PlayerForm _form;

    public PlayerForm form => _form;

    public void SetForm(PlayerForm form)
    {
        _form = form;
        if (FormChanged != null)
        {
            FormChanged(_form);
        }
    }
}
