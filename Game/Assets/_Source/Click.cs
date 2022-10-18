using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using InputSystem;
using ScoreSystem;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private BootsTrapper bootsTrapper;
    [SerializeField] private PlayerInputListener playerInputListener;

    public bool GoodClick;
    private void OnMouseDown()
    {
        if (!GoodClick)
        {
            bootsTrapper.ReductionScore();
        }
        else
        {
            bootsTrapper.GettingScore();
        }
    }
}
