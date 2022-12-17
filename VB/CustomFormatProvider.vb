Imports System
Imports DevExpress.Mvvm

Namespace DXGridSample

    Public Class CustomFormatProvider
        Implements IFormatProvider, ICustomFormatter

        Public Shared Function GetFormatProvider(ByVal zoom As TimeSpan) As CustomFormatProvider
            Return New CustomFormatProvider(If(zoom.Hours > 2, "{0:MMM}", "{0:MMMM yyyy} - {1:MMMM yyyy}"))
        End Function

        Public ReadOnly Property FormatString As String

        Public Sub New(ByVal formatString As String)
            Me.FormatString = formatString
        End Sub

        Public Function GetFormat(ByVal formatType As Type) As Object Implements IFormatProvider.GetFormat
            If GetType(ICustomFormatter) Is formatType Then
                Return Me
            Else
                Return Nothing
            End If
        End Function

        Public Function Format(ByVal pFormat As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
            Dim range = CType(arg, DateTimeRange?)
            Return If(range.HasValue, String.Format(FormatString, range.Value.Start, range.Value.End), Nothing)
        End Function
    End Class
End Namespace
