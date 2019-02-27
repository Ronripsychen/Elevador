using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcontrol : MonoBehaviour
{
    CharacterController cc;
    public float speed = 10;
    public float mousespeed = 10;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Direction = transform.forward * Input.GetAxisRaw("Vertical");
        Direction += transform.right * Input.GetAxisRaw("Horizontal");

        cc.Move(Direction * speed * Time.deltaTime);

        angle += Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;

        transform.eulerAngles = new Vector3(0, angle, 0);
    }
}
