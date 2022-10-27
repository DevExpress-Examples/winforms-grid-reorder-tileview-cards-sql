Imports System
Imports System.Collections.Generic

Namespace Reorder

    Public Class SampleObject

        Public Property Text As String

        Public Property GroupId As Integer

        Public Property IndexInGroup As Integer
    End Class

    Public Class DataHelper

        Public Shared Function GetData() As List(Of SampleObject)
            Dim data = New List(Of SampleObject)()
            Dim rnd = New Random()
            For n As Integer = 0 To 32 - 1
                Dim record = New SampleObject()
                record.GroupId = rnd.Next(0, 5)
                record.IndexInGroup = n
                record.Text = "Item " & n
                data.Add(record)
            Next

            Return data
        End Function
    End Class
End Namespace
