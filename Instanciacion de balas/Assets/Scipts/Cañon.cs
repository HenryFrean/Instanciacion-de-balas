using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject[] bulletsPrefabs;
    public float delaySpawn = 2f;
    public float intervalDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo",delaySpawn, intervalDelay);
    }

    private void Disparo()
    {
        int indexBullet = Random.Range(0, bulletsPrefabs.Length);
        Instantiate(bulletsPrefabs[indexBullet], transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
