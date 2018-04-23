using System;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace NavBarExample.Module.Web {
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class NavBarExampleAspNetModule : ModuleBase {
        public NavBarExampleAspNetModule() {
            InitializeComponent();
        }
    }
}
