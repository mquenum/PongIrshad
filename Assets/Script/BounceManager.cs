using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceManager : MonoBehaviour
{
    private Rigidbody _ball;
    private Vector3 _lastVelocity;
    // Start is called before the first frame update
    private void Start()
    {
        _ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (_ball)
        {
            _lastVelocity = _ball.velocity;
        }
    }
}
