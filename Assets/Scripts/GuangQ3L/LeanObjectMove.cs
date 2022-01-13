using UnityEngine;

namespace Lean.Touch
{
    // This script allows you to track & pedestral this GameObject (e.g. Camera) based on finger drags
    public class LeanObjectMove : MonoBehaviour
    {
        public bool canRotate = true;
        public bool IgnoreGuiFingers = true;
        public int RequiredFingerCount;
        //private float Distance = .0f;
        public float Sensitivity = 1.0f;

        public float x = 162;
        private float y;

        protected virtual void LateUpdate()
        {
            if (canRotate)
            {
                var fingers = LeanTouch.GetFingers(IgnoreGuiFingers, RequiredFingerCount);
                var sceenDelta = LeanGesture.GetScreenDelta();
                if (sceenDelta != null)
                {
                    x += sceenDelta.x * Sensitivity;
                    y -= sceenDelta.y * Sensitivity;
                    Quaternion rotateAngle = Quaternion.Euler(0, x, 0);
                    transform.rotation = rotateAngle;
                    x = ClampAngle(x);
                    // y = ClampAngle(y, minAngle, maxAngle);
                }
            }
           
            
        }


        //public float minAngle;
        //public float maxAngle;
        static float ClampAngle(float angle)
        {
            if (angle < 0)
                angle += 360;
            if (angle > 360)
                angle -= 360;
            return angle;
        }
    }
}