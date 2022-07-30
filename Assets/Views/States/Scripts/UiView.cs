using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Views {

    public abstract class UiView : MonoBehaviour {

        private GraphicRaycaster graphicRaycaster;

        private void Awake() {
            graphicRaycaster = GetComponent<GraphicRaycaster>();
        }

        public virtual void OnUpdate() { }

        public void DisableRaycast() {
            graphicRaycaster.enabled = false;
        }

        public void EnableRaycast() {
            graphicRaycaster.enabled = true;
        }
    }
}