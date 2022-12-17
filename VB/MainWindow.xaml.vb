Imports System.Windows
Imports DevExpress.Xpf.Gantt

Namespace DXGridSample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub RequestTimescaleRulers(ByVal sender As Object, ByVal e As RequestTimescaleRulersEventArgs)
            e.TimescaleRulers.Clear()
            e.TimescaleRulers.Add(New TimescaleRuler(TimescaleUnit.Month, formatProvider:=CustomFormatProvider.GetFormatProvider(Me.ganttView.Zoom)))
        End Sub
    End Class
End Namespace
