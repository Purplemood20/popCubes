using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public LevelManager manager;
    //public bool mouseClic = false;

    //private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            manager.DestroyOnClic();
            manager.addScore();
        }
        
    }

    //void OnClic()
    //{
        //mouseClic = true;
        //animator.SetBool("mouseClic", true);

    //}
}
