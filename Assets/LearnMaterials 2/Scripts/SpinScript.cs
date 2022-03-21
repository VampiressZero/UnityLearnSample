using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class SpinScript : FatherScript
    {
        [Space]
        [Header("Крутись, детка")]

        [SerializeField]
        private bool spin;

        [SerializeField]
        [Range(1f, 100f)]
        private float speed;

        [SerializeField]
        private Quaternion rotation;

        // Start is called before the first frame update
        void Start()
        {
            speed = 5;
            spin = false;
            rotation.eulerAngles = new Vector3(40, 20, 65);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (spin == true)
            {
                Use();
            }
        }

        [ContextMenu("Повращать")]
        public override void Use()
        {
            var direction = rotation.eulerAngles - transform.rotation.eulerAngles;
            
            if (direction.magnitude > 0.01f)
            {
                spin = true;
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed / 100);
            }
            else
            { 
                spin = false;
            }
        }
    }

}