Imports System
Imports DevExpress.Mvvm

Namespace DXGridSample
	Public Class CustomFormatProvider
		Implements IFormatProvider, ICustomFormatter

		Public Shared Function GetFormatProvider(ByVal zoom As TimeSpan) As CustomFormatProvider
			Return New CustomFormatProvider(If(zoom.Hours > 2, "{0:MMM}", "{0:MMMM yyyy} - {1:MMMM yyyy}"))
		End Function

		Public ReadOnly Property FormatString() As String

'INSTANT VB NOTE: The variable formatString was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal formatString_Conflict As String)
			Me.FormatString = formatString_Conflict
		End Sub
		Public Function GetFormat(ByVal formatType As Type) As Object Implements IFormatProvider.GetFormat
			If GetType(ICustomFormatter) Is formatType Then
				Return Me
			Else
				Return Nothing
			End If
		End Function
'INSTANT VB NOTE: The parameter format was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
		Public Function Format(ByVal format_Conflict As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
			Dim range = CType(arg, DateTimeRange?)
			Return If(range.HasValue, String.Format(FormatString, range.Value.Start, range.Value.End), Nothing)
		End Function
	End Class
End Namespace