using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmanager : MonoBehaviour
{

    [SerializeField]
    private AudioSource playerAudio;
    [SerializeField]
    private Rigidbody rbBalle;

    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "grosbat")
        {
            playerAudio.Play();
            rbBalle.velocity = Vector3.zero;
            Vector3 dir = (transform.position - collision.contacts[0].point).normalized;
            rbBalle.AddForce(dir * 12f, ForceMode.Impulse);
        }

    }
}
