using UnityEngine;
using System.Collections;

public abstract class Bullet : TimedBehaviour {


    void TickUpdate()
    {
        if (shouldExplode())
        {
            explode();
        }
    }

    abstract protected void explode();

    abstract protected bool shouldExplode();

}