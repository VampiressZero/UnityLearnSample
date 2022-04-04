using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class AlexanderScript : FatherScript
    {
        private Transform myTransform;
        private bool isCollapsed = true;

        private void Awake()
        {
            myTransform = transform;
        }

        [ContextMenu("Collapse")]
        public override void Use()
        {
            isCollapsed = false;
        }

        public void FixedUpdate()
        {
            if (!isCollapsed)
            {
                for (var i = 0; i < myTransform.childCount; i++)
                {
                    var child = myTransform.GetChild(i);
                    child.localScale = child.lossyScale - new Vector3(0.01f, 0.01f, 0.01f);
                    if (child.lossyScale.magnitude < 0.1f)
                    {
                        isCollapsed = true;
                        Destroy(child.gameObject);
                    }
                }
            }
        }
    }
}
