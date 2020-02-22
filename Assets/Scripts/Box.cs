﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
public class Box : Item, IClickable
{
    public bool isClick
    {
        get;
        set;
    }
    public GameObject rabbit;
    public event EventHandler onClicked;

    //   public event EventHandler Clicked;
    // Start is called before the first frame update
    void Start()
    {
        isClick = false;
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }
 

    void OnMouseDown()
    {
        if (!isClick && canInteract)
        {
            onClicked?.Invoke(this, EventArgs.Empty);
            isClick = true;
            //TODO 生出一隻母兔子 和兔子生小孩
            Instantiate(rabbit, transform.position, transform.rotation);
            //TODO 波爆炸特效後刪除

            Destroy(gameObject);

        }
    }
}
