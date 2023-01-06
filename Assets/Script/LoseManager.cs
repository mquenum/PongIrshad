using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LoseManager : MonoBehaviour
{
    public UnityEvent triggerEntered;
    [SerializeField] private bool _isRed;
    [SerializeField] private bool _isBlue;
    [SerializeField] private GameManager _gameManager;

    [SerializeField] private TMP_Text _redScoreText;
    [SerializeField] private TMP_Text _blueScoreText;
    private int _blueScore = 0;
    private int _redScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody _ball = collision.gameObject.GetComponent<Rigidbody>();
            if (_isRed)
            {
                _blueScore++;
                _gameManager.ScoreDisplayer(_blueScore, _blueScoreText);
            }
            else if (_isBlue)
            {
                _redScore++;
                _gameManager.ScoreDisplayer(_redScore, _redScoreText);
            }
        }

        triggerEntered.Invoke();
    }
}
