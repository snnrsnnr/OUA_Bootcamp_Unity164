using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float time;
    private void Start()
    {
        Destroy(gameObject, 7);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        time += Time.deltaTime * 5;
    }
    
}

