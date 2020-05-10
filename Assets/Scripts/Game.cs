using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private PipeGenerator _pipeGenerator;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private GameOverScreen _gameOverScreen;

    private void Start()
    {
        Time.timeScale = 0;
        _startScreen.Open();
    }

    private void OnEnable()
    {
        _startScreen.PlayButtonClick += OnStartButtonClick;
        _gameOverScreen.RestartButtonClick += OnResetButtonClick;
        _bird.GameOver += OnGameOver;
    }

    private void OnDisable()
    {
        _startScreen.PlayButtonClick -= OnStartButtonClick;
        _gameOverScreen.RestartButtonClick -= OnResetButtonClick;
        _bird.GameOver -= OnGameOver;
    }

    private void OnStartButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }

    private void OnResetButtonClick()
    {
        _gameOverScreen.Close();
        _pipeGenerator.ResetPool();
        StartGame();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
        _bird.ResetPlayer();   
    }

    private void OnGameOver() 
    {
        _gameOverScreen.Open();
        Time.timeScale = 0;
    }
}
