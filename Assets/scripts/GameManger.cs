using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject endPoint;
    public LineRenderer hookRender;
    
    void Start()
    {
        hookRender = GetComponent<LineRenderer>();
    }
    void Update()
    {
        CatchFish();
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            endPoint.transform.position = Vector3.MoveTowards(endPoint.transform.position, mousePos, Time.deltaTime*5);

        }else{
            endPoint.transform.position = Vector3.MoveTowards(endPoint.transform.position, startPoint.transform.position, Time.deltaTime * 5);
        }

           
       
    }
    public void CatchFish()
    {
        hookRender.SetPosition(0,startPoint.transform.position);
        hookRender.SetPosition(1, endPoint.transform.position);

    }
}
