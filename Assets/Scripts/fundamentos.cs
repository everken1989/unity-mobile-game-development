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
    public float speedX;
    public float speedY;
    public float speedZ;
    //public bool isActive = true;
    void Start()
    {
        Application.targetFrameRate = 60;
        print("Mi FPS: " + Application.targetFrameRate);
        float fps = 1f / Time.deltaTime;
        print("Real FPS: " + fps);
    }
    //Que se ejecute 
    void Update()
    {
        
        float rTime = Time.deltaTime; 
        //Coords X Y Z 
        transform.Translate(speedX, speedY * rTime, speedZ * rTime);
        
    }
}
