using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float Speed;

    public Transform waypt1;
    public Transform waypt2;
    private Transform target;
    private void Start()
    {
        target = waypt1;
    }
    // Update is called once per frame
    void Update()
    {
        var distance1 = Vector2.Distance(transform.position, waypt1.position);
        if (distance1 <= 0.2f)
        {
            transform.localScale = new Vector2(-1, 1);
            target = waypt2;
        }
        var distance2 = Vector2.Distance(transform.position, waypt2.position);
        if (distance2 <= 0.2f)
        {
            transform.localScale = new Vector2(1, 1);
            target = waypt1;
        }
        transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
    }
}
