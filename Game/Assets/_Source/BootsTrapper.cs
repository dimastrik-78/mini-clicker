using System;
using System.Collections;
using System.Collections.Generic;
using InputSystem;
using ScoreSystem;
using UnityEngine;

namespace Core
{
    public class BootsTrapper : MonoBehaviour
    {
        // [SerializeField] private Click click;
        [SerializeField] private ScoreView scoreView;
        [SerializeField] private PlayerInputListener playerInputListener;
        
        private Score _score;
        private Game _game;

        private void Awake()
        {
            _score = new Score();
            _game = new Game(_score, playerInputListener);
            
            playerInputListener.UpdateText = scoreView.Construct;
            playerInputListener.UpdateText?.Invoke(_score);

            playerInputListener.OnExitInput = _game.EndGame;
        }
        public void ReductionScore()
        {
            _score.RemoveScore();
            playerInputListener.UpdateText?.Invoke(_score);
        }

        public void GettingScore()
        {
            _score.AddScore();
            playerInputListener.UpdateText?.Invoke(_score);
        }
    }
}
