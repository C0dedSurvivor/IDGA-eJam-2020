using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Variables
    // This should be a value between -10 -> 10
    private float rotation = 0;
    [SerializeField]
    private float targetrot = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the actual rotation closer to the target rotation
        if (Mathf.Abs(targetrot - rotation) < 0.01)
        {
            rotation = targetrot;
        }
        else
        {
            rotation = Mathf.Lerp(rotation, targetrot, 0.01f);
        }

        // Updates the actual visuals
        Vector3 rotValue = new Vector3(0, 0, rotation);
        this.gameObject.transform.rotation = Quaternion.Euler(rotValue);
    }

    // Method for rotating the object
    public void RotateTo(float value)
    {
        targetrot = value;
    }
}
