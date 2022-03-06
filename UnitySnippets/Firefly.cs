/* Firefly
 * Make GameObject move in a pattern similar to fireflies in real world.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySnippets
{
    public class Firefly : MonoBehaviour
    {
        private float _t;
        public float Radius;
        public float Speed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            _t += Time.deltaTime;
            var radiusY = Radius * (0.5f + 0.5f * (Mathf.Sin(_t * 0.3f)
                            + 0.3 * Mathf.Sin(2 * _t + 0.8f)
                            + 0.26 * Mathf.Sin(3 * _t + 0.8f)));

            transform.position = new Vector3(Radius * Mathf.Cos(_t * Speed), (float)radiusY * Mathf.Sin(_t * Speed), 0);
        }
    }
}
