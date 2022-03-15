using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class AlexanderScript : FatherScript
    {
        private Transform myTransform;

        private void Awake()
        {
            myTransform = transform;
        }

        [ContextMenu("Collapse")]
        public override void Use()
        {
            int count = myTransform.childCount;

            myTransform.GetChild(0).localScale = Vector3.zero;
            //for (int i = 0; i < count; i++)
            //{
            //    Destroy(myTransform.GetChild(i).gameObject);
            //}
        }
    }
}
