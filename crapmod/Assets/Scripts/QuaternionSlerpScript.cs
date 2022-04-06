/**
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.VersionControl;

public class QuaternionSlerpScript : MonoBehaviour
{
    Quaternion targetAngle_m90 = Quaternion.Euler(0, 0, 90);
    Quaternion targetAngle_90 = Quaternion.Euler(0, 0, 90);
    Quaternion targetAngle_0 = Quaternion.Euler(0, 0, 0);
    public Quaternion currentAngle;
    public GameObject rotationspot;
    float cooldown = 0f;
    float lastPressed = 0f;
    bool isCooldown = false;

    private IEnumerator theroutine;

    // Start is called before the first frame update
    void Start()
    {
        currentAngle = targetAngle_0;
        //theroutine = Cooldowns(5f);
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.deltaTime;
        float diffSecs = currentTime - lastPressed;

        if (Input.GetKeyDown(KeyCode.E) && isCooldown == false)
        {
            lastPressed = currentTime;
            ChangeCurrentAngle();
            //isCooldown = true;
            //StartCoroutine(Cooldowns(1));

        }

        if (Input.GetKeyDown(KeyCode.Q) && isCooldown == false)
        {
            lastPressed = currentTime;
            ChangeCurrentAngle2();
            //isCooldown = true;
            //StartCoroutine(Cooldowns(1));

        }

        //this.transform.rotation = Quaternion.Slerp(this.transform.rotation, currentAngle, 0.007f);

        
        //transform.RotateAround(rotationspot.transform.position, new Vector3(0, 0, rotationspot.transform.position.z), 0.5f);
        
        
    }
        **/    

    /**
    void ChangeCurrentAngle()
    {
        if (currentAngle.eulerAngles.z == targetAngle_0.eulerAngles.z)
        {
            
            currentAngle = targetAngle_90;
            transform.RotateAround(rotationspot.transform.position, new Vector3(0, 0, rotationspot.transform.position.z), 90f);

        }
        else
        {
            currentAngle = targetAngle_0;
            transform.RotateAround(rotationspot.transform.position, new Vector3(0, 0, rotationspot.transform.position.z), 0f);
        }
    }
    void ChangeCurrentAngle2()
    {
        if (currentAngle.eulerAngles.z == targetAngle_0.eulerAngles.z)
        {
            currentAngle = targetAngle_m90;
            transform.RotateAround(rotationspot.transform.position, new Vector3(0, 0, rotationspot.transform.position.z), -90f);
        }
        else
        {
            currentAngle = targetAngle_0;
            transform.RotateAround(rotationspot.transform.position, new Vector3(0, 0, rotationspot.transform.position.z), 0f);
        }
    }

    //IEnumerator Cooldowns(float waittimer)
   // {
       // yield return new WaitForSeconds(1);
       // isCooldown = false;
   // }
}
    */