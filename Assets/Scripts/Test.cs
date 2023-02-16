using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class Test : MonoBehaviour
{
    public LayerMask draggableMask;
    //public Ray ray;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("good 1");
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    Debug.DrawRay(ray.origin, ray.direction * 20, Color.white);
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        if (hit.collider != null)
        //        {
        //            Debug.Log("good 2");
        //        }
        //        else
        //        {
        //            Debug.Log("bad ");
        //        }
        //    }
        //}



        // Creates a Ray from the mouse position
        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(Camera.main.transform.position, Input.mousePosition);
    }
}
