using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MatchThreeEngine
{
    public class Damage : MonoBehaviour
    {
        public TMP_Text Display;
        public Rounds Round;
        public int DamageValue;

        void Start()
        {
            CalculateDamageValue();
            Display.text = DamageValue.ToString();
        }

        public void CalculateDamageValue()
        {
            int x = Round.RoundNum + 1;
            DamageValue = (int)Mathf.Floor(10 * Mathf.Log(x * x));
            Display.text = DamageValue.ToString();
        }
    }
}
