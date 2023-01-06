using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LoseManager : MonoBehaviour
{
    public UnityEvent triggerEntered;
    [SerializeField] private bool _leftPoint;
    [SerializeField] private bool _rightPoint;
    [SerializeField] private GameManager _gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody _ball = collision.gameObject.GetComponent<Rigidbody>();

            _gameManager.ScoreDisplayer(_leftPoint, _rightPoint);
        }

        triggerEntered.Invoke();
    }
}
