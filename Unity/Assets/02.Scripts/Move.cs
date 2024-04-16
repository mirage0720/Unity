using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{    
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        //1. MoverTowards
        // transform.position =
        //     Vector3.MoveTowards(transform.position
        //                         , target, 1f);   

        //2. SmoothDamp
        // Vector3 velo = Vector3.zero;

        // transform.position =
        //     Vector3.SmoothDamp(transform.position
        //                        , target, ref velo, 0.1f);   

        //3. Lerp (선형 보간)
        // transform.position =
        //      Vector3.Lerp(transform.position
        //                     , target, 1f);       

        //4. Slerp(구면 선형 보간)
        // transform.position =
        //       Vector3.Slerp(transform.position
        //                     , target, 0.05f);    

        //5. 델타타임
        // Vector3 vec = new Vector3(
        //     Input.GetAxis("Horizontal"), 
        //     Input.GetAxis("Vertical"), 0);
        // transform.Translate(vec *Time.deltaTime); 
    }
}
