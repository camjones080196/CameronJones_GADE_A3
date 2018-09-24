using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaleMovement : AIMovement
{
    private Animator anim;

    public void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        this.startMovement();
    }

    public override void getTargets()
    {
        for (int k = 0; k < targets.Length; k++)
        {
            points.Enqueue(targets[k].transform.position);
        }

        newPos = points.Peek();
    }

    public override IEnumerator moveAI()
    {
        yield return new WaitForSeconds(startWaitTime);

        while (points.Count > 0)
        {
            yield return new WaitForFixedUpdate();
            if (this.transform.position == newPos)
            {
                points.Dequeue();

                if (points.Count > 0)
                {
                    newPos = points.Peek();
                }
                else
                {
                    resetPoints();
                }
                anim.SetBool("Move", false);
                yield return new WaitForSeconds(waitTime);
            }
            else
            {
                anim.SetBool("Move", true);
                this.transform.position = Vector3.MoveTowards(this.transform.position, newPos, speed * Time.deltaTime);
            }

        }
    }

    public void resetPoints()
    {
        getTargets();
    }

}