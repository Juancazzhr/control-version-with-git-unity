using UnityEngine;

namespace Juancazz.Root
{
    public class Editor : MonoBehaviour
    {
        private void Awake() => Debug.Log("Awake");

        private void OnEnable() => Debug.Log("On Enable");

        private void Start() => Debug.Log("Start");
    }
}
