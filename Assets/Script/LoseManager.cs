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
                _blueScoreText.text = _blueScore.ToString();
            }
            else if (_isBlue)
            {
                _redScore++;
                _redScoreText.text = _redScore.ToString();
            }
            Destroy(_ball);
        }

        triggerEntered.Invoke();
    }

    public int ReturnBlueScore(int blueScore)
    {
        return blueScore;
    }

    public int ReturnRedScore(int redScore)
    {
        return redScore;
    }
}
