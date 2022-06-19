using UnityEngine;
using Assets.Views;

namespace Assets.States {
    public abstract class BaseState<TuiView, TWorldView> 
        where TuiView : UiView 
        where TWorldView : WorldView {

        protected TuiView uiView;

        protected TWorldView worldView;

        protected Context context;

        private IScreenMachine screenMachine => context.screenMachine;

        public BaseState(Context context) {
            this.context = context;
        }

        protected T GetStateAsset<T>() {
            return context.screenMachine.GetStateAsset<T>();
        }

        protected void PopState() {
            screenMachine.PopState();
        }

        protected void PushState(IStateBase state) {
            screenMachine.PushState(state);
        }

        protected void PresentState(IStateBase state) {
            screenMachine.PresentState(state);
        }


        public void LinkViews(UiView uiView, WorldView worldView) {
            this.uiView = uiView as TuiView;
            this.worldView = worldView as TWorldView;
        }

        public void DestroyViews() {
            Object.Destroy(uiView.gameObject);
            Object.Destroy(worldView.gameObject);
        }
    }
}