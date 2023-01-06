using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _playerLeft;
    [SerializeField] private GameObject _playerRight;
    [SerializeField] private float _padMoveForce = 10.0f;
    [SerializeField] private TMP_Text _leftScoreText;
    [SerializeField] private TMP_Text _rightScoreText;
    private int _scorePlayerLeft = 0;
    private int _scorePlayerRight = 0;

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    // pad movement
    void PlayerMovement()
    {
        // right player movement
        _playerRight.transform.Translate(Input.GetAxis("Vertical") * Vector3.up * Time.deltaTime * _padMoveForce);

        // left player movement
        if (Input.GetKey(KeyCode.A))
        {
            _playerLeft.transform.Translate(Vector3.up * Time.deltaTime * _padMoveForce);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            _playerLeft.transform.Translate(Vector3.down * Time.deltaTime * _padMoveForce);
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ScoreDisplayer(bool pointForLeft, bool pointForRight)
    {
        if (pointForLeft)
        {
            _scorePlayerLeft++;
            ChangeScoreText(_leftScoreText, _scorePlayerLeft);
        }
        else if (pointForRight)
        {
            _scorePlayerRight++;
            ChangeScoreText(_rightScoreText, _scorePlayerRight);
        }
    }

    public void ChangeScoreText(TMP_Text display, int score)
    {
        display.text = score.ToString();
    }
}
