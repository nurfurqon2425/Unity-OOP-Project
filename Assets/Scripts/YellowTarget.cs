using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTarget : BaseTarget
{
    private Rigidbody targetRb;

    private float moveRange;
    private Vector3 moveVector = new Vector3(0, 1, 0);
    private Vector3 minPosition;
    private Vector3 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        moveRange = Random.Range(RangeLimit - 1, RangeLimit);
        minPosition = new Vector3(transform.position.x, transform.position.y - moveRange, transform.position.z);
        maxPosition = new Vector3(transform.position.x, transform.position.y + moveRange, transform.position.z);
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(moveVector * Speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        MoveTarget();
    }

    protected override void MoveTarget()
    {
        if (transform.position.y <= minPosition.y)
        {
            targetRb.AddForce(moveVector * Speed * Time.deltaTime, ForceMode.Impulse);
        }
        else if (transform.position.y >= maxPosition.y)
        {
            targetRb.AddForce(-moveVector * Speed * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
