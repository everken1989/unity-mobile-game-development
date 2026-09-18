using UnityEngine;

public class Collission : MonoBehaviour
{
    Material mtl;
    Renderer rend;
    void Start()
    {
        mtl = GetComponent<Renderer>().material;
        rend = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision other) {
        print("On Dectected");
        mtl.color = Color.darkBlue;
    }
}
