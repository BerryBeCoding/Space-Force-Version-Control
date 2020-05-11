using UnityEngine;

public class Male_Marine : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.None) == true)
            anim.SetTrigger("Idle");

        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
            anim.SetTrigger("GunFwd");

        if (Input.GetKeyDown(KeyCode.Alpha2) == true)
            anim.SetTrigger("Jump");

        if (Input.GetKeyDown(KeyCode.Alpha3) == true)
            anim.SetTrigger("Die");

        if (Input.GetKeyDown(KeyCode.Alpha4) == true)
            anim.SetTrigger("1H_Idle");

        if (Input.GetKeyDown(KeyCode.Alpha5) == true)
            anim.SetTrigger("1H_Walk");

        if (Input.GetKeyDown(KeyCode.Alpha6) == true)
            anim.SetTrigger("1H_Jump");

        if (Input.GetKeyDown(KeyCode.Alpha7) == true)
            anim.SetTrigger("Shoot_SMG"); 

        if (Input.GetKeyDown(KeyCode.Alpha8) == true)
            anim.SetTrigger("1H_Die");
    }
}