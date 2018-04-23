Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace NavBarExample.Module.BusinessObjects
	<NavigationItem("Group1")> _
	Public Class DomainObject1
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	<NavigationItem("Group1")> _
	Public Class DomainObject2
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	<NavigationItem("Group1")> _
	Public Class DomainObject3
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	<NavigationItem("Group2")> _
	Public Class DomainObject4
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	<NavigationItem("Group2")> _
	Public Class DomainObject5
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	<NavigationItem("Group2")> _
	Public Class DomainObject6
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	<NavigationItem("Group3")> _
	Public Class DomainObject7
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
End Namespace
