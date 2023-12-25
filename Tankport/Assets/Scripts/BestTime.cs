using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BestTime : MonoBehaviour
{
    public float time;

    private void Start()
    {
        time = PlayerPrefs.GetFloat("Level_" + SceneManager.GetActiveScene().buildIndex.ToString());
        this.GetComponent<TextMeshProUGUI>().text = time.ToString();
    }
}