using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace MatchThreeEngine
{
    public class Rounds : MonoBehaviour
    {
        public Next Button;
        public Image Block;
        public TMP_Text Display;
        public CastleHP HPHolder;
        public Damage Dmg;
        public int RoundNum;
        public readonly int MovesLimit = 3;
        private int roundsLeft; 

        void Start()
        {
            RoundNum = 0;
            roundsLeft = MovesLimit;
            Display.text = roundsLeft.ToString();
            Block.enabled = false;
        }

        public void Next()
        {
            if (--roundsLeft < 0)
            {
                roundsLeft = MovesLimit;
            }
            Display.text = roundsLeft.ToString();
            if (roundsLeft == 0)
            {
                Block.enabled = true;
                Button.Self.SetActive(true);
            }
        }

        public void NewRound()
        {
            HPHolder.TakeDamage(Dmg.DamageValue);
            roundsLeft = MovesLimit;
            RoundNum++;
            Dmg.CalculateDamageValue();
            Display.text = roundsLeft.ToString();
        }
    }
}
