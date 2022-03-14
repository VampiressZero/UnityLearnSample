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
        private Transform target;
        public AlexanderScript(Transform target)
        {
            this.target = target;
        }
        public override void Use()
        {
            target.Rotate(new Vector3(30,30), 45);
            // target.DetachChildren();
        }
    }
}
