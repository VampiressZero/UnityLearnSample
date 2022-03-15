using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class MovementScript : FatherScript
    {
        [SerializeField] private float speed;
        [SerializeField] private Vector3 position;

        private Transform myTransform;

        private void Awake()
        {
            myTransform = transform;
        }

        [ContextMenu("ÄÂÈÃÀÉÑß")]
        public override void Use()
        {
            Vector3 direction = position - myTransform.position;
            if (direction.magnitude > 0.3f)
            {
                myTransform.forward = direction;

                myTransform.position = direction.normalized * Time.deltaTime;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            Application.targetFrameRate = 10;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 direction = position - myTransform.position;
            if (direction.magnitude > 0.3f)
            {
                myTransform.forward = direction;

                myTransform.position = direction.normalized * Time.deltaTime;
            }
        }
    }
}