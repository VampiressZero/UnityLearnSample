using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class MovementScript : FatherScript
    {
        [Space]
        [Header("А ну двигайся")]

        [SerializeField]
        private bool move;

        [SerializeField]
        [Range(1f, 100f)]
        private float speed;

        [SerializeField]
        private Vector3 finishPosition;

        // Start is called before the first frame update
        void Start()
        {
            speed = 1;
            move = false;
            finishPosition = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z + 1);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (move == true)
            {
                Use();
            }
        }

        [ContextMenu("Принудить к движению")]
        public override void Use()
        {
            Vector3 direction = finishPosition - transform.position;
            if (direction.magnitude > 0.01f)
            {
                move = true;
                transform.position = Vector3.MoveTowards(transform.position, finishPosition, speed / 100);
            }
            else
            {
                move = false;
            }
        }
    }
}
