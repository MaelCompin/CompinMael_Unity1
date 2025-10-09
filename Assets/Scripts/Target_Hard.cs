using System;
using TMPro;
using UnityEngine;

public class Target_Hard : MonoBehaviour
{
   [SerializeField] private TMP_Text _scoreText;

   public void UpdateScore(int newScore)
   {
      _scoreText.text = $"Score : {newScore.ToString()}";
   }
}
