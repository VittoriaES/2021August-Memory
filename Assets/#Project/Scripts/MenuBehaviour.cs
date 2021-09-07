using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{

    public bool mouseOver = false;  
    private Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseOver() {       
        mouseOver = true;
        animator.SetBool("MouseOver", true);
    }
    private void OnMouseExit() {
        mouseOver = false;
        animator.SetBool("MouseOver", false);
    }
}
