Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.SystemModule

Namespace NavBarExample.Module.Web.Controllers
	Public Class AutoSelectNavigationItemController
		Inherits WindowController
		Implements IXafCallbackHandler
		Public Sub New()
			TargetWindowType = WindowType.Main
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			AddHandler Window.ProcessActionContainer, AddressOf Window_ProcessActionContainer
		End Sub
		Protected Overrides Sub OnDeactivated()
			RemoveHandler Window.ProcessActionContainer, AddressOf Window_ProcessActionContainer
			MyBase.OnDeactivated()
		End Sub
		Private Sub Window_ProcessActionContainer(ByVal sender As Object, ByVal e As ProcessActionContainerEventArgs)
			If TypeOf e.ActionContainer Is NavigationTabsActionContainer Then
				Dim navActionContainer As NavigationTabsActionContainer = TryCast(e.ActionContainer, NavigationTabsActionContainer)
				navActionContainer.PageControl.EnableClientSideAPI = True
				Dim callbackManager As XafCallbackManager = (CType(WebWindow.CurrentRequestPage, ICallbackManagerHolder)).CallbackManager
				callbackManager.RegisterHandler("NavBarViewChangingController", Me)
				navActionContainer.PageControl.ClientSideEvents.ActiveTabChanged = String.Format("function(s, e){{{0}}}", callbackManager.GetScript("NavBarViewChangingController", "e.tab.index"))
			End If
		End Sub
		#Region "IXafCallbackHandler Members"

		Public Sub ProcessAction(ByVal parameter As String) Implements IXafCallbackHandler.ProcessAction
			Dim tabIndex As Integer = Int32.Parse(parameter)
			Dim showNavigationItemAction As SingleChoiceAction = Frame.GetController(Of ShowNavigationItemController)().ShowNavigationItemAction
			showNavigationItemAction.DoExecute(showNavigationItemAction.Items(tabIndex).Items(0))
		End Sub

		#End Region
	End Class
End Namespace
