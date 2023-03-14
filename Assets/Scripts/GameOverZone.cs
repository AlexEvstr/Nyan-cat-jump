using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    [SerializeField] private LevelBuilder _levelBuilder;
    [SerializeField] private GameObject _gameOverPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        _levelBuilder.SpawnPlatform();

        if (collision.gameObject.CompareTag("Player"))
        {
            _gameOverPanel.SetActive(true);
        }
    }
}
