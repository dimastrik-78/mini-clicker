using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using ScoreSystem;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private BootsTrapper bootsTrapper;
    private void OnMouseDown()
    {
        bootsTrapper.ReductionScore();
    }
}
