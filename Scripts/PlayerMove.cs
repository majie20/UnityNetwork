using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PlayerMove : NetworkBehaviour {

    public float moveSpeed;
    [SyncVar(hook ="mmm")]
    public int a = 0;
	void Start () {


    }
	
	
	void Update () {
        //transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime;
        if (isLocalPlayer)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * 120);
            transform.Translate(new Vector3(0, 0, Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime, Space.Self);
            a++;
        }
    }

    public override void OnStartLocalPlayer()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    public void mmm(int aa)
    {
        Debug.Log(aa);
    }
}
