using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Animate : MonoBehaviour
{ 
    private Animator animate;
    // Start is called before the first frame update
    void Start()
    {

        animate = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {        

    }

    // Animation functions
    public void animateRun()
    {
        animate.Play("running", -1, 0f);
    }

    public void animateHit01()
    {
        animate.Play("hit01", -1, 0f);
    }

    public void animateHit02()
    {
        animate.Play("hit02", -1, 0f);
    }

    public void animateHit03()
    {
        animate.Play("hit03", -1, 0f);
    }

    public void animateDamage()
    {
        animate.Play("damage", -1, 0f);
    }

    public void animateKO_big()
    {
        animate.Play("KO_big", -1, 0f);
    }

    public void animateWinpose()
    {
        animate.Play("winpose", -1, 0f);
    }

    public void animateJump()
    {
        animate.Play("jump", -1, 0f);
    }

   
}
