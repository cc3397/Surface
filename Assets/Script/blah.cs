using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blah : MonoBehaviour {

    // Use this for initialization
    private Animator m_Anim;
    void Start () {
        m_Anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            m_Anim.SetBool("Crouch", false);
        }
		
	}
}
