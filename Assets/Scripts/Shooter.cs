using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject barrel;

    private Vector3 rotationAngle;
    private float speed = 1500.0f;

    // Start is called before the first frame update
    void Start()
    {
        rotationAngle = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        RotateShooter();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBall();
        }
    }

    //ABSTRACTION
    private void RotateShooter()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rotationAngle = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotationAngle = Vector3.back;
        }
        else
        {
            rotationAngle = Vector3.zero;
        }

        transform.Rotate(rotationAngle);
    }

    //ABSTRACTION
    private void ShootBall()
    {
        GameObject gameObj = Instantiate(bulletPrefab, barrel.transform.position, transform.rotation);
        Rigidbody ballRb = gameObj.GetComponent<Rigidbody>();
        ballRb.AddRelativeForce(Vector3.up * speed, ForceMode.Force);
    }
}
