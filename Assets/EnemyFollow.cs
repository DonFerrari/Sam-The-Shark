using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;

    private Transform target;

    void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {

        
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.y, transform.position.x), speed * Time.deltaTime);
    }
}
