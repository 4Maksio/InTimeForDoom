using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MatchThreeEngine
{
    public class Upgrade : MonoBehaviour
    {
        public Board board;
        public CastleHP castle;
        public DisplayVariables varBoard;
        public TMP_Text display;
        public TMP_Text requirement;
        private static readonly int[] price = { 8, 20, 38, 60, 100 };
        public static readonly int[] hp = { 20, 35, 60, 100, 145, 210 };
        public int resourceNumber;
        private int lvl;


        private void Start()
        {
            lvl = 0;
            display.text = "0";
            requirement.text = price[0].ToString();
            castle.Upgrade(hp[0]);
        }

        public void CastleUp()
        {
            if (lvl < price.Length && varBoard[resourceNumber] >= price[lvl])
            {
                varBoard.Add(resourceNumber, -price[lvl]);
                lvl++;
                castle.Upgrade(hp[lvl]);
            }
            if (lvl < price.Length)
            {
                display.text = lvl.ToString();
                requirement.text = price[lvl].ToString();
            }
            else
            {
                display.text = "MAX";
                requirement.text = "MAX";
                SceneManager.LoadScene(3);
            }
        }
    }
}