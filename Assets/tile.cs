using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tile : MonoBehaviour
{
    public int count;
    public TextMeshPro _count;
    bool isupdated = false;
    public Transform playercheck;
    public LayerMask playerlayer;
    bool collide;

    void start()
    {

        _count.text = count.ToString();
    }
    void FixedUpdate()
    {

        _count.text = count.ToString();
        collide = Physics2D.OverlapCapsule(playercheck.position, new Vector2(3f, 3f), CapsuleDirection2D.Horizontal, 0, playerlayer);
        if (collide)
        {
            if (isupdated == false)
            {
                count--;
                if (count == 0)
                {
                    Destroy(this);
                }
                isupdated = true;
            }
            
            Debug.Log("collided");
        }
        else
        {
            isupdated = false;
        }
    }

}
