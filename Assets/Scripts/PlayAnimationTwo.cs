using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationTwo : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
anim = GetComponent<Animator>();
    }

    public void PlayAnims(){
        anim.Play("rig|Ucapan 7", 0,0);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
