﻿using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    private BirdMover _mover;
    private int _score;

    public event UnityAction GameOver;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }

    public void ResetPlayer()
    {
        _score = 0;
        _mover.ResetBird();
    }

    public void IncreaseScore()
    {
        _score++;
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
