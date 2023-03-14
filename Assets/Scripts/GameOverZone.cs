using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    [SerializeField] private LevelBuilder _levelBuilder;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        _levelBuilder.SpawnPlatform();

    }
}
