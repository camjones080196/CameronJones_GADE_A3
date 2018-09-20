using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheilaMovement : AIMovement
{
    public GameObject[] targets;
    Vector3 newPos;


    private void Start()
    {
        for (int k = 0; k < targets.Length; k++)
        {
            points.Enqueue(targets[k].transform.position);
        }

        newPos = points.Peek();
    }

    private void Update()
    { 
        if(points.Count > 0)
        {
            if (this.transform.position == newPos)
            {
                points.Dequeue();
                if(points.Count > 0)
                {
                    newPos = points.Peek();
                }
                
            }
            else
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, newPos, speed * Time.deltaTime);
            }
        }
    }

    public override void startMovement()
    {
         



         /*while (points.Count > 0)
         {
             Debug.Log(points.Peek());
             Vector2 newPos = points.Peek();
             this.transform.position = Vector2.MoveTowards(this.transform.position, newPos, speed * Time.deltaTime);
             Debug.Log("Moving");
             points.Dequeue();
         }*/

        
    }
}
