using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int countUnlockedLevel = 1;

    [SerializeField] private Sprite unlocked;
    [SerializeField] private Sprite locked;

    private void Start()
    {
        
    }
}
