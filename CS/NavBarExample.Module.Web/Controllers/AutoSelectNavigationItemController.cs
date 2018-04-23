using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;
using DevExpress.ExpressApp.Web.Templates;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.SystemModule;

namespace NavBarExample.Module.Web.Controllers {
    public class AutoSelectNavigationItemController : WindowController, IXafCallbackHandler {
        public AutoSelectNavigationItemController() {
            TargetWindowType = WindowType.Main;
        }
        protected override void OnActivated() {
            base.OnActivated();
            Window.ProcessActionContainer += Window_ProcessActionContainer;
        }
        protected override void OnDeactivated() {
            Window.ProcessActionContainer -= Window_ProcessActionContainer;
            base.OnDeactivated();
        }
        void Window_ProcessActionContainer(object sender, ProcessActionContainerEventArgs e) {
            if (e.ActionContainer is NavigationTabsActionContainer) {
                NavigationTabsActionContainer navActionContainer = e.ActionContainer as NavigationTabsActionContainer;
                navActionContainer.PageControl.EnableClientSideAPI = true;
                XafCallbackManager callbackManager = ((ICallbackManagerHolder)WebWindow.CurrentRequestPage).CallbackManager;
                callbackManager.RegisterHandler("NavBarViewChangingController", this);
                navActionContainer.PageControl.ClientSideEvents.ActiveTabChanged = string.Format("function(s, e){{{0}}}", callbackManager.GetScript("NavBarViewChangingController", "e.tab.index"));
            }
        }
        #region IXafCallbackHandler Members

        public void ProcessAction(string parameter) {
            int tabIndex = Int32.Parse(parameter);
            SingleChoiceAction showNavigationItemAction = Frame.GetController<ShowNavigationItemController>().ShowNavigationItemAction;
            showNavigationItemAction.DoExecute(showNavigationItemAction.Items[tabIndex].Items[0]);
        }

        #endregion
    }
}
