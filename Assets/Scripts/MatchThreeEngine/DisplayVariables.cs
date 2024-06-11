using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MatchThreeEngine
{
    public class DisplayVariables : MonoBehaviour
    {
        private Dictionary<int, int> scores = new Dictionary<int, int>();
        public TMP_Text[] Fields_by_ID;
        public CastleHP HP;

        public int this[int key]
        {
            get 
            {
                if (scores.ContainsKey(key))
                {
                    return scores[key];
                }
                else
                    return -1;
            }
        }

        public void Add(int type, int value)
        {
            if (scores.ContainsKey(type) && type != 3)
            {
                scores[type] += value;
                Fields_by_ID[type].text = scores[type].ToString();
            }
            if(type == 3)
            {
                HP.Heal(value);
            }
        }

        void Start()
        {
            for (int i = 0; i<Fields_by_ID.Length; i++)
            {
                scores.Add(i, 0);
                Fields_by_ID[i].text = "0";
            }
        }
    }

}
