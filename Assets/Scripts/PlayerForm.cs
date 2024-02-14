using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerForm : ScriptableObject
{
    [SerializeField] private Material _material;

    [SerializeField] private Sprite _sprite;
    
    [SerializeField] private PlayerFormType _type;

    [SerializeField] private bool _freezeRotation;
    
    


    public Material material => _material;

    public Sprite sprite => _sprite;

    public bool freezeRotation => _freezeRotation;

    public PlayerFormType type => _type;
}

public enum PlayerFormType
{
    Rectangle,
    Circle,
    Triangle
}