using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MatchThreeEngine;

namespace MatchThreeEngine
{
    public class LvlUp : MonoBehaviour
    {
        public Board board;
        public DisplayVariables varBoard;
        private TMP_Text[] displays;
        private static readonly int[] price = { 3, 9, 27, 50 };
        public int resourceNumber;
        public int TMProNumber;
        private int lvl;


        private void Start()
        {
            lvl = 0;
            displays = GetComponentsInChildren<TMP_Text>();
            display();
        }

        public void lvlUp()
        {
            if (lvl < price.Length && varBoard[resourceNumber] >= price[lvl])
            {
                varBoard.Add(resourceNumber, -price[lvl]);
                board.tileTypes[TMProNumber].value++;
                lvl++;
            }
            display();
        }

        private void display()
        {
            if (lvl < price.Length)
            {
                displays[0].text = "lvl " + lvl.ToString();
                displays[1].text = price[lvl].ToString();
            }
            else
            {
                displays[0].text = "MAX";
                displays[1].text = "MAX";
            }
        }
    }
}