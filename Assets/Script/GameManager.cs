using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int RedScore = 0;
    [HideInInspector] public int BlueScore = 0;
    [SerializeField] private GameObject _ballPrefab;
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        GameObject.Instantiate(_ballPrefab);
    }
}
