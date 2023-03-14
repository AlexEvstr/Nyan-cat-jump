using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField] private GameObject _simplePlatformPrefab;

    private int _numberOfPlatforms = 15;
    private float _levelWidth = 2.0f;
    private float _minDistanceBetweenPlatforms = 0.15f;
    private float _maxDistanceBetweenPlatforms = 1.4f;

    private Vector2 spawnPosition = new Vector2();

    private void Start()
    {
        for (int i = 0; i < _numberOfPlatforms; i++)
        {
            spawnPosition.x = Random.Range(-_levelWidth, _levelWidth);
            spawnPosition.y += Random.Range(_minDistanceBetweenPlatforms, _maxDistanceBetweenPlatforms);
            Instantiate(_simplePlatformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    public void SpawnPlatform()
    {
        GameObject SimplePlatform = ObjectPool.SharedInstance.GetPooledObject();
        if(SimplePlatform != null)
        {
            spawnPosition.x = Random.Range(-_levelWidth, _levelWidth);
            spawnPosition.y += Random.Range(_minDistanceBetweenPlatforms, _maxDistanceBetweenPlatforms);
            SimplePlatform.transform.position = spawnPosition;
            SimplePlatform.SetActive(true);
        }
    }
}
