using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class SuperScript : FatherScript
    {
        public List<FatherScript> scripts;

        [ContextMenu("USE EVERYTHING")]
        public override void Use()
        {
            foreach(FatherScript script in scripts)
            {
                script.Use();
            }
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}