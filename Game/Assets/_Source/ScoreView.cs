using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private Text scoreText;

        public void Construct(Score score)
        {
            scoreText.text = score.score.ToString();
        }
    }
}
