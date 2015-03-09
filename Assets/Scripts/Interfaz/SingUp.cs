using UnityEngine;
using System.Collections;

public class SingUp : MonoBehaviour {
  #region PUBLIC_VARIABLES
  public float alturaVentana = 0.3F;
  public float anchoVentana = 0.4F;
  public bool show = false;
  #endregion
  
  #region PRIVATE_VARIABLES
  private Rect windowRect;
  private string name = "";
  private string lastName = "";
  private string mail = "";
  private string token = "";
  private string password = "";
  private string confirmPassword = "";
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
      windowRect = GUILayout.Window(100, windowRect, ContentWindow, "Registro");
    }
  }
  #endregion
  
  #region MY_PUBLIC_METHODS
  void ContentWindow(int id){
    //nombres
    GUILayout.BeginHorizontal();
    GUILayout.Label("*Nombre");
    name = GUILayout.TextField(name);
    GUILayout.EndHorizontal();
    //apellidos
    GUILayout.BeginHorizontal();
    GUILayout.Label("*Apelllidos");
    lastName = GUILayout.TextField(lastName);
    GUILayout.EndHorizontal();
    //correo
    GUILayout.BeginHorizontal();
    GUILayout.Label("*Correo");
    mail = GUILayout.TextField(mail);
    GUILayout.EndHorizontal();
    //token clase
    GUILayout.BeginHorizontal();
    GUILayout.Label("Token clase");
    token = GUILayout.TextField(token);
    GUILayout.EndHorizontal();
    //password
    GUILayout.BeginHorizontal();
    GUILayout.Label("*Contraseña");
    password = GUILayout.PasswordField(password, "*"[0]);
    GUILayout.EndHorizontal();
    //confirm password
    GUILayout.BeginHorizontal();
    GUILayout.Label("*Contraseña");
    confirmPassword = GUILayout.PasswordField(confirmPassword, "*"[0]);
    GUILayout.EndHorizontal();
    if (GUILayout.Button("Registrar")){
      print("Go registro");
    }
  }
  #endregion
}
