Imports System.Net
Imports System.Data
Imports Newtonsoft.Json
Imports System.ComponentModel
Imports System.Reflection
Imports Newtonsoft.Json.Linq
Imports Fortnite_API
Imports Fortnite_API.Objects.V2

Public Class OfficersFortniteAPI

    Public Function GetAllCosmetics() As List(Of BrCosmeticV2)
        Dim fortapi As New FortniteApiClient()
        Dim allcosmetics = fortapi.V2.Cosmetics.GetBr()
        Return allcosmetics.Data
    End Function

    Public Function GetNewCosmetics() As BrNewCosmeticsV2
        Dim fortapi As New FortniteApiClient()
        Dim newcosmetics As BrNewCosmeticsV2 = fortapi.V2.Cosmetics.GetBrNew().Data
        Return newcosmetics
    End Function

End Class


Module Module1

    Sub Main()


    End Sub
End Module


Public Module JsonHelper

    Public Function FromClass(Of T)(data As T,
                                    Optional isEmptyToNull As Boolean = False,
                                    Optional jsonSettings As JsonSerializerSettings = Nothing) As String

        Dim response As String = String.Empty

        If Not EqualityComparer(Of T).Default.Equals(data, Nothing) Then
            response = JsonConvert.SerializeObject(data, jsonSettings)
        End If

        Return If(isEmptyToNull, (If(response = "{}", "null", response)), response)

    End Function

    Public Function ToClass(Of T)(data As String,
                                  Optional jsonSettings As JsonSerializerSettings = Nothing) As T

        Dim response = Nothing

        If Not String.IsNullOrEmpty(data) Then
            response = If(jsonSettings Is Nothing,
                JsonConvert.DeserializeObject(Of T)(data),
                JsonConvert.DeserializeObject(Of T)(data, jsonSettings))
        End If

        Return response

    End Function

End Module
