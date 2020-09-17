using UnityEngine;

public class ThrusterInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Thruster>().enabled = Input.GetKey(KeyCode.Space);
    }
}
