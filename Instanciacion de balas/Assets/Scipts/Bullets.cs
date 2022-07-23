using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 dir;
    public int restLife = 0;
    public int life = 100;

    // Start is called before the first frame update
    void Start()
    {
        Damage(restLife);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(dir);
    }

    void MovePlayer(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void Damage(int value)
    {
        life = life - value;
    }
}
