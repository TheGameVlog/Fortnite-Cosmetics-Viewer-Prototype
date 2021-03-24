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
