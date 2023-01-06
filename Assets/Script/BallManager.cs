using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    private Rigidbody _ball;
    private Vector3 _direction;
    // Start is called before the first frame update
    void Start()
    {
        _ball = GetComponent<Rigidbody>();

        if (Random.Range(0, 6) > 2.5f)
        {
            _direction = Vector3.left;
        }
        else
        {
            _direction = Vector3.right;
        }

        _ball.AddForce(_direction * _speed, ForceMode.Impulse);
        _ball.velocity = (Vector3.Normalize(_ball.velocity) * _speed);
    }
}
