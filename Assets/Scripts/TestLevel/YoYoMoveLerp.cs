using UnityEngine;
using Friedforfun.SteeringBehaviours.Utilities;

namespace Friedforfun.SteeringBehaviours.Demo
{
    public class YoYoMoveLerp : MonoBehaviour
    {
        public Vector3 StartPos;
        public Vector3 EndPos;
        public float frequency = 1;

        static readonly float TAU = 2 * Mathf.PI;
        private float lerpVal;

        private void Awake()
        {
            ReferencePool.Register(gameObject);
        }


        private void OnDisable()
        {
            ReferencePool.DeRegister(gameObject);
        }

        void Update()
        {
            lerpVal = 0.5f * (1 + Mathf.Sin(TAU * frequency * Time.time));
            transform.localPosition = Vector3.Lerp(StartPos, EndPos, lerpVal);
        }
    }
}

