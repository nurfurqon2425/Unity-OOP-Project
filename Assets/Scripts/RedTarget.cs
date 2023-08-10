using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTarget : BaseTarget //INHERITANCE
{
    private Rigidbody targetRb;

    private float moveRange;
    private Vector3 moveVector = new Vector3(1, 1, 0);
    private Vector3 minPosition;
    private Vector3 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        moveRange = Random.Range(RangeLimit - 1, RangeLimit);
        minPosition = new Vector3(transform.position.x - moveRange, transform.position.y - moveRange, transform.position.z);
        maxPosition = new Vector3(transform.position.x + moveRange, transform.position.y + moveRange, transform.position.z);
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(moveVector * Speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        MoveTarget();
    }

    //POLYMORPHISM
    protected override void MoveTarget()
    {
        if (transform.position.x <= minPosition.x && transform.position.y <= minPosition.y)
        {
            targetRb.AddForce(moveVector * Speed * Time.deltaTime, ForceMode.Impulse);
        }
        else if (transform.position.x >= maxPosition.x && transform.position.y >= maxPosition.y)
        {
            targetRb.AddForce(-moveVector * Speed * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
