using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTarget : MonoBehaviour
{
    //ENCAPSULATION    
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
        Counter.Instance.count += 1;
        Destroy(gameObject);
    }
}
