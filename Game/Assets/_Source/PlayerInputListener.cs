using System;
using System.Collections;
using System.Collections.Generic;
using ScoreSystem;
using Unity.VisualScripting;
using UnityEngine;

namespace InputSystem
{
    public class PlayerInputListener : MonoBehaviour
    {
        [SerializeField] private ScoreView scoreView;
        [SerializeField] private KeyCode exitKey;
        public Action OnExitInput;
        public Action<Score> UpdateText;
        private void Update()
        {
            if (Input.GetKeyDown(exitKey))
                OnExitInput?.Invoke();
        }
    }
}
