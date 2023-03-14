using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private GameObject _mainCamera;
    [SerializeField] private Text _scoreText;
    private int _score;

    private void Start()
    {
    }

    private void Update()
    {
        _score = (int)_mainCamera.transform.position.y;
        _scoreText.text = _score.ToString();
    }
}
