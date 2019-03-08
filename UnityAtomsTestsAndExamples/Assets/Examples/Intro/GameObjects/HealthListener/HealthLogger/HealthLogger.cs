﻿
using UnityEngine;

namespace UnityAtoms.Examples
{
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Health Logger")]
    public class HealthLogger : IntAction
    {
        public override void Do(int health)
        {
            Debug.Log("<3: " + health);
        }
    }
}