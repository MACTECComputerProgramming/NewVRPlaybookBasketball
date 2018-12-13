using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuINFO : MonoBehaviour {

   private static int playnumber;
   private static int playernumber;

   public static int Playnumber 
   { 
       get 
       {
           return playnumber;
       } 

       set 
       {
           playnumber = value;
       }
   }
   public static int Playernumber
   {
       get
       {
           return playernumber;
       }
       set
       {
           playernumber = value;
       }
   }
   
	
}
