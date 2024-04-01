using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace JaH
{
    public class Helicopter_Menus : MonoBehaviour
    {
        [MenuItem("Just a Helicopter/Vehicles/Set New Helicopter")]
        public static void BuildNewHelicopter()
        {
            // создание нового вертолета
            GameObject curHeli = new GameObject("New_Helicopter", typeof(Heli_Controller));


            // создание COG нового вертолета
            GameObject curCOG = new GameObject("COG");
            curCOG.transform.SetParent(curHeli.transform);


            //назначение COG на новый вертолет
            Heli_Controller curController = curHeli.GetComponent<Heli_Controller>();
            curController.cog = curCOG.transform;

            // Создание групп
            GameObject audioGRP = new GameObject("Audio_GRP");
            GameObject graphicsGRP = new GameObject("Graphics_GRP");
            GameObject colGRP = new GameObject("Collider_GRP");

            audioGRP.transform.SetParent(curHeli.transform);
            graphicsGRP.transform.SetParent(curHeli.transform);
            colGRP.transform.SetParent(curHeli.transform);

            //Выбор нового вертолета
            Selection.activeGameObject = curHeli;
        }

    }
}
