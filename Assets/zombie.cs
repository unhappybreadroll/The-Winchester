using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{

    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDiatance;

    Vector2 wayPoint;
    

    


    void Start()
    {
        SetNewDestination();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,wayPoint) < range)
        {
            SetNewDestination();
        }
    }

    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(maxDiatance, maxDiatance), Random.Range(maxDiatance, maxDiatance));
    }





}
