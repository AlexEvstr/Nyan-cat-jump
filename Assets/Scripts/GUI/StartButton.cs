using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;

    public void StartGame()
    {
        _startPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
