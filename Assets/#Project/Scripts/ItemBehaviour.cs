using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{

    public int id = -1;
    public LevelManager manager;

    public bool mouseOver = false;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0) && mouseOver){
            manager.RevealMaterial(id);
        }
    }

    private void OnMouseOver() {       
        mouseOver = true;
        animator.SetBool("MouseOver", true);
    }

    private void OnMouseExit() {
        mouseOver = false;
        animator.SetBool("MouseOver", false);
    }

    public void HasBeenSelected(bool selected) {
        animator.SetBool("ItemSelected", selected);

    }

    public void HasBeenMatched() {
        animator.SetBool("ItemMatch", true);
    }
}
