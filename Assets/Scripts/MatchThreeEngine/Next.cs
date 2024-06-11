using MatchThreeEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

namespace MatchThreeEngine
{
    public class Next : MonoBehaviour
    {
        public DisplayVariables AttackContainer;
        public GameObject Self;
        public Rounds Round;
        public Damage Dmg;

        private void Start()
        {
            Self.SetActive(false);
        }

        public void NextRound()
        {
            int finalAttack = AttackContainer[0] - Dmg.DamageValue;
            int finalDamage = Dmg.DamageValue - AttackContainer[0];
            if (finalAttack < 0) finalAttack = 0;
            if (finalDamage < 0) finalDamage = 0;
            AttackContainer.Add(0, -(AttackContainer[0] - finalAttack));
            Dmg.DamageValue = finalDamage;
            Round.NewRound();
            Round.Block.enabled = false;
            Self.SetActive(false);
        }
    }
}
