using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int countUnlockedLevel = 1;

    [SerializeField] private Sprite unlocked;
    [SerializeField] private Sprite locked;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.name = "Level " + (i + 1).ToString();
            transform.GetChild(i).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = (i + 1).ToString();
            
            if (i < countUnlockedLevel)
            {
                transform.GetChild(i).GetComponent<Image>().sprite = unlocked;
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = locked;
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }
}
