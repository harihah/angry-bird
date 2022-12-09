using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate = 1f;

    public float minHeight = -1f;

    public float maxHeight = 1f;
    // Start is called before the first frame update
    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn), spawnRate, spawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(spawn));
    }
    private void spawn()
    {
        GameObject mountain = Instantiate(prefab, transform.position, Quaternion.identity);
        mountain.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
    
}
