using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPlatformPos : MonoBehaviour
{

    [SerializeField] private GameObject platformPrefab;

    [SerializeField] private int numberOfPlatforms = 200;
    [SerializeField] private float levelWidth = 3f;
    [SerializeField] private float minY = .2f;
    [SerializeField] private float maxY = 1.5f;

    // Use this for initialization
    void Start()
    {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
