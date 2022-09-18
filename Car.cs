using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Car : MonoBehaviour
{
    public AudioSource car;
    public AudioSource carMusic;
    public AudioSource brakeSound;
    public MonoBehaviour CarContoller;
    public Transform Carr;
    public Transform Player;
    public GameObject DriveUI;
    public GameObject DrivSpeedMetereUI;


    //public GameObject nevidljivaPodloga;
    //public GameObject nevidljivaPodloga2;

    bool CanDrive;
    bool driving;

    [Header ("Cameras")]
    public GameObject PayerCam;
    public GameObject CarCam;



    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    /// <summary>
    /// 
    /// </summary>

    public float speed = 1;


    void Start()
    {

        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);

        //nevidljivaPodloga.SetActive(false);
        //nevidljivaPodloga2.SetActive(false);
        CarContoller.enabled = false;
          DriveUI.gameObject.SetActive(false);
        DrivSpeedMetereUI.gameObject.SetActive(false);
    }

    private void Update()
    {
        //////if (CanDrive)
        //////{
        //////    DriveUI.gameObject.SetActive(true);
        //////}
        //////else
        //////{
        //////    DriveUI.gameObject.SetActive(false);
        //////}
            if (Input.GetKeyDown(KeyCode.F) && CanDrive)
        {
           /// nevidljivaPodloga.SetActive(true);
            CarContoller.enabled = true;
            DriveUI.gameObject.SetActive(false);
            DrivSpeedMetereUI.gameObject.SetActive(true);
            driving = true;
            Player.transform.SetParent(Carr);
            Player.gameObject.SetActive(false);
            PayerCam.gameObject.SetActive(false);
            CarCam.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            // nevidljivaPodloga.SetActive(false);

            //nevidljivaPodloga.SetActive(false);
            //nevidljivaPodloga2.SetActive(false);
            CarContoller.enabled = false;
            driving = false;

            Player.transform.SetParent(null);
            Player.gameObject.SetActive(true);

            PayerCam.gameObject.SetActive(true);
            CarCam.gameObject.SetActive(false);
        }
        //if (Input.GetKeyDown(KeyCode.L))
        //    {
        //    nevidljivaPodloga.SetActive(true);
        //}

        //////////////if (Input.GetKeyDown(KeyCode.Q))///&& transform.position.y <310
        //////////////{

        //////////////    particle1.SetActive(true);
        //////////////    particle2.SetActive(true);
        //////////////    particle3.SetActive(true);
        //////////////    particle4.SetActive(true);

        //////////////    nevidljivaPodloga.SetActive(true);
        //////////////    nevidljivaPodloga2.SetActive(true);
        //////////////    transform.position += new Vector3(0, 813, 0);
          
        //////////////    //Time.timeScale = 0.5f;
        //////////////    //Time.fixedDeltaTime = 0.02F * Time.timeScale;
        //////////////    /////////transform.Translate(0, 300, 0);
        //////////////    /////////transform.position = new Vector3(0,300, 0) * Time.deltaTime;
        //////////////    /////////transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //////////////    float x = Input.GetAxis("Vertical");//Horizontal
        //////////////    float y = Input.GetAxis("Vertical");
        //////////////    Vector3 movement = new Vector3(x,0, y);
        //////////////    movement = Vector3.ClampMagnitude(movement, 0);
        //////////////    transform.Translate(movement * speed * Time.deltaTime);





        //////////////}
        //////////////if (Input.GetKeyDown(KeyCode.E))
        //////////////{
        //////////////    nevidljivaPodloga.SetActive(false);
        //////////////    nevidljivaPodloga2.SetActive(false);
        //////////////}

        

    }

    // Update is called once per frame
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            DriveUI.gameObject.SetActive(true);
            DrivSpeedMetereUI.gameObject.SetActive(false);
            CanDrive = true;
            car.Play(0);
            carMusic.Play(0);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            DriveUI.gameObject.SetActive(false);
            DrivSpeedMetereUI.gameObject.SetActive(false);
            CanDrive = false;
            carMusic.Stop();
        }
    }
  
}