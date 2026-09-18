using System;
using UnityEditor.UIElements;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public float speed;
    float moveX, moveZ;
    public GameObject myGameObj;
    Renderer rend;
    Material mtl;
    bool isChangeColor = false;
    void Start()
    {
        float time = Application.targetFrameRate = 60;
        float fps = 1f / Time.deltaTime; 
        rend = GetComponent<Renderer>();
        mtl = rend.material;
        mtl.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        float realTime = Time.deltaTime;
        //transform.Rotate(0, 10f * realTime , 0);
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        transform.Translate(moveX * speed * realTime, 0, moveZ *speed * realTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            /*if(!isChangeColor)
            {
                mtl.color = Color.blueViolet;
                isChangeColor = true;  
            } else
            {
                mtl.color = Color.red;
                isChangeColor = false;
            }*/
            isChangeColor = !isChangeColor;
            mtl.color = isChangeColor 
                ? Color.blueViolet
                : Color.red;
            
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            rend.enabled = !rend.enabled;
        }
    }
    private void OnCollisionEnter(Collision other) {
       if(other.gameObject.CompareTag("Enemy"))
        {
            mtl.color = Color.antiqueWhite;
            Destroy(other.gameObject);
        } 
    }

}
