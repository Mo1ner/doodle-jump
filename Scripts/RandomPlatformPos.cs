using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlatformPos : MonoBehaviour
{
    [SerializeField] private GameObject _platform;
    [SerializeField] private GameObject _player;

    private GameObject _myPlat;

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Instantiate(_platform, new Vector2(Random.Range(-2f, 2f), _player.transform.position.y + (14 + Random.Range(.5f, 1f))), Quaternion.identity);
        Destroy(col.gameObject);
    }
}
