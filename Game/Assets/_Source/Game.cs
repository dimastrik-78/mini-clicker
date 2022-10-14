using System;
using System.Collections;
using System.Collections.Generic;
using InputSystem;
using UnityEngine;

namespace Core
{
    public class Game
    {
        private Score _score;
        private PlayerInputListener _playerInputListener;
        
        public Game(Score score, PlayerInputListener playerInputListener)
        {
            _playerInputListener = playerInputListener;
            _score = score;
            StartGame();
        }

        public void StartGame()
        {
            _score.Start();
        }
        
        public void EndGame()
        {
            _score.End();
        }

        void Update()
        {
            
        }
    }
}
