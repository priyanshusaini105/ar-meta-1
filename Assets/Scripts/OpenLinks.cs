using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrls : MonoBehaviour
{
   public void openLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/priyanshusaini105/");
    }
    public void openPortfolio()
    {
        Application.OpenURL("https://priyanshusaini.vercel.app/");
    }
}
