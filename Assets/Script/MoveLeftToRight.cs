using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftToRight : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    [SerializeField] private float _limits = 10.0f;
    private float _mvt;
    private bool _mLeft;
    // Start is called before the first frame update
    void Start()
    {
        _mvt = Random.Range(0, 2);

        Debug.Log(_mvt);

        if (_mvt > 1)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * _speed, ForceMode.Impulse);
            /*// we move left
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
            // if we  pass the limit (negative side)
            if (transform.position.x <= -_limits)
            {
                // we stop moving left
                _mLeft = false;
            }*/
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * _speed, ForceMode.Impulse);
            /*// else, we move right
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
            // if we pass the limit(positive side)
            if (transform.position.x >= _limits)
            {
                _mLeft = true;
            }*/
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*// if move left is true
        if (_mLeft)
        {
            // we move left
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
            // if we  pass the limit (negative side)
            if (transform.position.x <= -_limits)
            {
                // we stop moving left
                _mLeft = false;
            }
        }
        else
        {
            // else, we move right
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
            // if we pass the limit(positive side)
            if (transform.position.x >= _limits)
            {
                _mLeft = true;
            }
        }

        // if we press the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // go towards the opposite direction
            _mLeft = !_mLeft;
        }*/
    }

    public void BallMovement()
    {

    }
}
