using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadManager : MonoBehaviour
{
    [SerializeField] private float _moveForce = 10.0f;
    [SerializeField] private float _ballForce = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // pad movement
        if (gameObject.CompareTag("Right Pad"))
        {
            transform.Translate(Input.GetAxis("Vertical") * Vector3.up * Time.deltaTime * _moveForce);
        }
        else if(gameObject.CompareTag("Left Pad"))
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.up * Time.deltaTime * _moveForce);
            }
            else if (Input.GetKey(KeyCode.Z))
            {
                transform.Translate(Vector3.down * Time.deltaTime * _moveForce);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody rbBall = collision.gameObject.GetComponent<Rigidbody>();
            ContactPoint contact = collision.GetContact(0);

            if (contact.point.z > transform.position.z)
            {
                Vector3 direction = new Vector3(0, 0, Random.Range(0.0f, 1.1f));

                collision.rigidbody.AddForce(direction * _ballForce, ForceMode.VelocityChange);
            }
            else if (contact.point.z < transform.position.z)
            {
                Vector3 direction = new Vector3(0, 0, Random.Range(-1.0f, 0.1f));

                collision.rigidbody.AddForce(direction * _ballForce, ForceMode.VelocityChange);

            }
            rbBall.velocity = (Vector3.Normalize(rbBall.velocity) * _ballForce);
        }
    }
}
