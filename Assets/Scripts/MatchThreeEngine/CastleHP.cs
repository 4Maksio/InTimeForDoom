using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MatchThreeEngine
{
    public class CastleHP : MonoBehaviour
    {
        public Image healthBar;
        public TMP_Text display;
        private float current;
        private int max;
        private int hpBarLength;

        void Start ()
        {
            hpBarLength = 292;
            Upgrade(MatchThreeEngine.Upgrade.hp[0]);
            UpdateHealth();
        }

        public void Upgrade(int newMax)
        {
            current = max = newMax;
            UpdateHealth();
        }

        public void TakeDamage(float amount)
        {
            current -= amount;
            if (current <= 0)
            {
                current = 0;
                SceneManager.LoadScene(2);
            }
            UpdateHealth();
        }

        public void Heal(int value)
        {
            if(value >= 0)
            {
                float tmp = value + current;
                if (tmp > max)
                    current = max;
                else
                    current = tmp;
            }
            UpdateHealth();
        }

        private void UpdateHealth()
        {
            healthBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, hpBarLength * current / max);
            display.text = string.Format("{0}/{1}", Convert.ToUInt32(current), max);
        }
    }
}