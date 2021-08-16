using UnityEngine;

/*
 * Small behaviour to handle menu button callbacks.
 */
public class MenuController : MonoBehaviour
{
  /*
   * When the start button is pressed, load the Game scene.
   */
    public void OnStartEazyClicked()
    {
        ApplicationInstance.SharedInstance.SetMode(3);
        Application.LoadLevel("Game");
    }

    public void OnStartMediumClicked()
    {
        ApplicationInstance.SharedInstance.SetMode(2);
        Application.LoadLevel("Game");
    }

    public void OnStartHardClicked()
    {
        ApplicationInstance.SharedInstance.SetMode(1);
        Application.LoadLevel("Game");
    }

    public void OnRestartClicked()
    {
        Application.LoadLevel("Game");
    }

    /*
     * When the back button is clicked, load the Menu scene.
     */
    public void OnBackClicked()
  {
    Application.LoadLevel("Menu");
  }
}
