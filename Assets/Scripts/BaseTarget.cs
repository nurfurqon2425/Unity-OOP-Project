using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTarget : MonoBehaviour
{
    //ENCAPSULATION
    private float upperBound = 8.0f;
    public float UpperBound
    {
        get { return upperBound; }
        private set { upperBound = value; }
    }
    private float lowerBound = -6.0f;
    public float LowerBound
    {
        get { return lowerBound; }
        private set { lowerBound = value; }
    }
    private float rightBound = 25.0f;
    public float RightBound
    {
        get { return rightBound; }
        private set { rightBound = value; }
    }
    private float leftBound = -20.0f;
    public float LeftBound
    {
        get { return leftBound; }
        private set { leftBound = value; }
    }
    private float speed = 4.0f;
    public float Speed
    {
        get { return speed; }
        private set { speed = value; }
    }
    private float rangeLimit = 2.0f;
    public float RangeLimit
    {
        get { return rangeLimit; }
        private set { rangeLimit = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //POLYMORPHISM
    protected abstract void MoveTarget();

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
