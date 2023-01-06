using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    private float _originalSpeed;
    private Rigidbody _ball;
    private Vector3 _direction;

    // Start is called before the first frame update
    void Start()
    {
        _ball = GetComponent<Rigidbody>();
        _originalSpeed = _speed;

        if (Random.Range(0, 6) > 2.5f)
        {
            _direction = Vector3.left;
        }
        else
        {
            _direction = Vector3.right;
        }

        _ball.AddForce(_direction * _speed, ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        // _speed * rigidBody.velocity.normalized;
        _ball.velocity = (Vector3.Normalize(_ball.velocity) * _speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pad"))
        {
            GameObject _pad = collision.gameObject;
            ContactPoint contact = collision.GetContact(0);
            Vector3 direction = new Vector3(0,0,0);

            if (contact.point.z > _pad.transform.position.z)
            {
                direction = new Vector3(0, 0, Random.Range(0.0f, 0.6f));
                _speed = _speed * 1.5f;
            }
            else if (contact.point.z < _pad.transform.position.z)
            {
                direction = new Vector3(0, 0, Random.Range(-1.0f, -0.4f));
                _speed = _originalSpeed;
            }

            _ball.AddForce(direction * _speed, ForceMode.VelocityChange);
        }
    }
}
