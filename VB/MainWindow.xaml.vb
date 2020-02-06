Imports System.Windows
Imports DevExpress.Xpf.Gantt

Namespace DXGridSample
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub RequestTimescaleRulers(ByVal sender As Object, ByVal e As RequestTimescaleRulersEventArgs)
			e.TimescaleRulers.Clear()
			e.TimescaleRulers.Add(New TimescaleRuler(TimescaleUnit.Month, formatProvider:= CustomFormatProvider.GetFormatProvider(ganttView.Zoom)))
		End Sub
	End Class
End Namespace