using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.LearnMaterials_2.Scripts
{
    public class AlexanderScript : FatherScript
    {
        const float speed = 1;

        private Transform myTransform;

        private void Awake()
        {
            myTransform = transform;
        }

        [ContextMenu("Collapse")]
        public override async void Use()
        {
            for (var i = 0; i < myTransform.childCount; i++)
            {
                StartCoroutine(ScaleCoroutine(myTransform.GetChild(i), Vector3.zero));

                await Task.Delay(Convert.ToInt32(1000 * speed));
                
            }
            await Task.Delay(Convert.ToInt32(1000 * speed));

            for(var i = 0; i < myTransform.childCount; i++)
            {
                Destroy(myTransform.GetChild(i).gameObject);
            }

        }
        private IEnumerator ScaleCoroutine(Transform transform, Vector3 target)
        {

            Vector3 start = transform.lossyScale;
            float t = 0;
            while (t < 1)
            {
                t += Time.deltaTime * speed;
                transform.localScale = Vector3.Lerp(start, target, t);
                yield return null;
            }
            transform.localScale = target;
        }
    }
}
