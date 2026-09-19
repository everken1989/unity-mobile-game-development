using UnityEngine;

public class fundamentos : MonoBehaviour
{
    //Class: Blueprint - Canvas - Plantilla 
    //Properties - Metodos - variables - comportamiento
    //Public todos acceso 
    //Private 
    //Variable: Enteros, Booleans, Flotantes, Tuples, Strings, Char
    //FPS: ¿Como podemos manipular el FPS?
    //int number = 21; 
    //string miNombre = "Su Karla";
    public float speed;
    public float angulo;
    public float moveX, moveZ;

    void Start()
    {
        
    }
    //Que se ejecute 
    void Update()
    {
        float rTime = Time.deltaTime;
        moveX = Input.GetAxis("Horizontal");
        //Declarar axis en el eje que sigue 
        //Incorporar en el Translate 
        //Coords X Y Z 
        //transform.Translate(moveX * speed * rTime, 0, moveZ * speed * rTime);
        //Acumulador
        transform.localScale += new Vector3(1f, 1f, 1f);
        //Posicion al Translate - Escala - Rotation
                          // X Y Z 
        transform.Rotate(angulo,0f,0f);  
        //Escala ++
        
    }
}
