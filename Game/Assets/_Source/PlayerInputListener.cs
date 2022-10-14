using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace InputSystem
{
    public class PlayerInputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode exitKey;
        public Action OnExitInput;

        private void Update()
        {
            if (Input.GetKeyDown(exitKey))
                OnExitInput?.Invoke();
        }
    }
}
