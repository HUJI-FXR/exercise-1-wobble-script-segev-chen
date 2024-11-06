using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleScript : MonoBehaviour
{

    [SerializeField] private float positionMultiplier1 = 1.231f;
    [SerializeField] private float positionMultiplier2 = Mathf.PI;
    [SerializeField] private float positionMultiplier3 = 4f;

    [SerializeField] private float scaleMultiplier1 = 2f;
    [SerializeField] private float scaleMultiplier2 = 1.5f;
    [SerializeField] private float scaleMultiplier3 = 3f;

    [SerializeField] private float rotationMultiplier1 = 2.5f;
    [SerializeField] private float rotationMultiplier2 = 1.8f;
    [SerializeField] private float rotationMultiplier3 = 3.2f;

    [SerializeField] private float massMultiplier = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        transform.localPosition = new Vector3(
            Mathf.Sin(positionMultiplier1 * time),
            Mathf.Sin(positionMultiplier2 * time),
            Mathf.Sin(positionMultiplier3 * time)
        );
        transform.localScale = new Vector3(
            Mathf.Sin(scaleMultiplier1 * time), 
            Mathf.Sin(scaleMultiplier2 * time),
            Mathf.Sin(scaleMultiplier3 * time)
        );

        transform.Rotate(
            Mathf.Sin(rotationMultiplier1 * time),
            Mathf.Sin(rotationMultiplier2 * time),
            Mathf.Sin(rotationMultiplier3 * time)
        );

        GetComponent<Rigidbody>().mass = Mathf.Abs(Mathf.Sin(massMultiplier * time));

    }
}
