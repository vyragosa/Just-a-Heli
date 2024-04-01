using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    #region Variables
    [Header("Weight Properties")]
    public float weight = 10f;

    private Rigidbody rb;
    #endregion

    #region Builtin Methods
    // Use this for initialization
    void Start ()
    {
        float finalKG = weight;
        rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.mass = finalKG;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		
	}
    #endregion
}
