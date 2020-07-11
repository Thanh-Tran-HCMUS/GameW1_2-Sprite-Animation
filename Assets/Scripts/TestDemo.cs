using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDemo : MonoBehaviour
{
    //Script để demo về cách điều khiển animation cơ bản
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //Luôn luôn lấy component trước khi thực hiện
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Cách 1: đặt parameter là trigger, xong gọi set trigger để play animation
            anim.SetTrigger("TriggerAttack");

            //Cách 2: gọi phương thức Play để play animation với tên gọi của state
            //anim.Play("aw2");
        }
    }
}
