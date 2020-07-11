using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCyclone : MonoBehaviour
{
    //Script demo cho việc xài animation event trong tab Animation

    //Lấy thông tin game object cần điều khiển
    public GameObject cyclone;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //Lấy thành phần animator của game object cần điều khiển
        anim = cyclone.GetComponent<Animator>();
    }

    //Cài đặt phương thức điều khiển bật animation trong animator qua biến trigger
    public void SetCycloneTrigger()
    {
        anim.SetTrigger("Cyclone");
    }

    //Cài đặt phương thức dùng để hiển thị sprite khi chạy vào đúng event
    public void VisibleObj()
    {
        cyclone.GetComponent<SpriteRenderer>().enabled = true;
    }

    //Cài đặt phương thức dùng để tắt hiển thị sprite khi chạy xong event
    public void InvisibleObj()
    {
        cyclone.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
