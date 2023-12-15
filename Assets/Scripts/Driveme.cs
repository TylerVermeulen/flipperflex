using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driveme : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject B;
    [SerializeField] GameObject Target;
    [SerializeField] GameObject Car;
    [SerializeField] float Speed;

    [SerializeField] Vector3 begin = new Vector3(-10, 2, 2);
    [SerializeField] Vector3 end = new Vector3(2, 2, 2);

    [SerializeField] Vector3 velocity;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = begin;
    }

    // Update is called once per frame
    void Update()
    {  
        velocity = (end-begin).normalized;
        distance = (end - transform.position).magnitude;
        if (distance < 0.1)
        {
            transform.position = begin;
        }
        transform.position += velocity * Time.deltaTime;
        
    }
}
