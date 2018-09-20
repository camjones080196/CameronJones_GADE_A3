using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIMovement : MonoBehaviour {

    public bool move = false;
    public float speed;

    public Queue<Vector2> points = new Queue<Vector2>();

    public abstract void startMovement();
    
        
    
}
