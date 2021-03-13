using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Aircraft1
{
    public class Rotate : MonoBehaviour
    {   public Vector3 rotatespeed;
        void Update()
        {
            transform.Rotate(rotatespeed * Time.deltaTime, Space.Self);
        }
    }
}
