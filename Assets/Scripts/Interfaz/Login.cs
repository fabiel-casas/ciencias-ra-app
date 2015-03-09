using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {
  #region PUBLIC_VARIABLES
  public float alturaVentana = 0.3F;
  public float anchoVentana = 0.4F;
  public bool show = false;
  #endregion
  
  #region PRIVATE_VARIABLES
  private Rect windowRect;
  private string mail = "";
  private string password = "";
  #endregion
  
  #region MONOBEHAVIOUR_METHODS
  // Use this for initialization
  void Start () {
    
  }
  
  // Update is called once per frame
  void Update () {
    windowRect = new Rect((Screen.width / 2) - (anchoVentana / 2), (Screen.height / 2) - (alturaVentana / 2), anchoVentana, alturaVentana);
  }
  
  void OnGUI(){
    if(show){
      windowRect = GUILayout.Window(101, windowRect, ContentWindow, "Login");
    }
  }
  #endregion
  
  #region MY_PUBLIC_METHODS
  void ContentWindow(int id){
    GUILayout.BeginHorizontal();
    GUILayout.Label("Correo");
    mail = GUILayout.TextField(mail);
    GUILayout.EndHorizontal();
    GUILayout.BeginHorizontal();
    GUILayout.Label("Contraseña");
    password = GUILayout.PasswordField(password, "*"[0]);
    GUILayout.EndHorizontal();
    if (GUILayout.Button("Login")){
      print("Go registro");
    }
  }
  #endregion
}
