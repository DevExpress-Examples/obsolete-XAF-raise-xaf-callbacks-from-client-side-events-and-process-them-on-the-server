<!-- default file list -->
*Files to look at*:

* **[AutoSelectNavigationItemController.cs](./CS/NavBarExample.Module.Web/Controllers/AutoSelectNavigationItemController.cs) (VB: [AutoSelectNavigationItemController.vb](./VB/NavBarExample.Module.Web/Controllers/AutoSelectNavigationItemController.vb))**
<!-- default file list end -->
# How to raise XAF callbacks from client-side events and process them on the server?


<p><strong>============================================================<br>This example is now obsolete. Refer to the <a href="https://documentation.devexpress.com/eXpressAppFramework/119706/Task-Based-Help/Miscellaneous-UI-Customizations/How-to-Raise-XAF-Callbacks-from-Client-Side-Events-and-Process-these-Callbacks-on-Server">How to: Raise XAF Callbacks from Client-Side Events and Process these Callbacks on Server</a> topic for more details.<br>============================================================</strong></p>
<p><strong>Scenario:</strong><br><br>It is necessary to execute server-side code that requires refreshing the current View as a response to user actions in an ASP.NET application. For example, show the first navigation item when a new navigation group is selected.<br><br><strong>Steps to Implement:</strong><br><br>1. Create a Controller that implements the IXafCallbackHandler interface. This interface allows defining server-side code that is executed when an XAF callback is raised.<br>2. Place the required server-side code to the IXafCallbackHandler.ProcessAction method, e.g. change ShowNavigationItemAction's selected item.<br>3. Subscribe to the Window.ProcessActionContainer event to access a navigation control (NavigationTabsActionContainer).<br>4. Raise an XAF callback by passing javascript generated by the XafCallbackManager.GetScript method to the NavigationTabsActionContainer.PageControl.ClientSideEvents.ActiveTabChanged event handler.<br>5. Register your callback handler (Controller) using the XafCallbackManager.RegisterHandler method.<br><br><strong>See also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/E4087">How to implement the drill-down functionality in Web PivotGrid (ASPxPivotGrid)</a><br><a href="https://www.devexpress.com/Support/Center/p/KA18958">How to automatically refresh data in a View after a certain period of time on the Web</a><br><a href="https://documentation.devexpress.com/eXpressAppFramework/112682/Task-Based-Help">Task-Based Help</a> > <a href="https://documentation.devexpress.com/eXpressAppFramework/118348/Task-Based-Help/Dashboards/How-to-Open-a-Detail-View-When-the-Grid-Row-is-Clicked-in-the-Dashboard">How to: Open a Detail View When the Grid Row is Clicked in the Dashboard</a></p>

<br/>


