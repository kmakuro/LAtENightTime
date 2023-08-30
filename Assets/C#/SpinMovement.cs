using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace G3
{
    public class SpinMovement : MonoBehaviour
    {
        [SerializeField]private float m_AngularSpeed = 5.0f;
        [SerializeField]private Vector3 m_AxisOfRotation = new Vector3(1.0f,0,0);
        
        Transform m_ObjTransform;

        void Start()
        {
            m_ObjTransform = this.gameObject.GetComponent <Transform >();
        }

        void Update()
        {
            m_ObjTransform.Rotate(m_AxisOfRotation , m_AngularSpeed);
        }
    }
}

