using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
anim = GetComponent<Animator>();
    }

    public void PlayAnim(){
        anim.Play("mixamo_com", 0,0);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
