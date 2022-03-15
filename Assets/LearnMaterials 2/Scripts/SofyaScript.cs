using System.Collections;
using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class SofyaScript : FatherScript
    {
        [SerializeField] private int count;
        [SerializeField] private Vector3 step;
        [SerializeField] private GameObject prefab;

        private Transform myTransform;

        private void Awake()
        {
            myTransform = transform;
        }

        [ContextMenu("Clone")]
        public override void Use()
        {
            for (int i = 0; i < count; i++)
            {
                Instantiate(prefab, myTransform.position + step * (i + 1), myTransform.rotation);
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