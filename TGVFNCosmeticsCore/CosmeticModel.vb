Public Class Type
    Public Property value As String
    Public Property displayValue As String
    Public Property backendValue As String
End Class

Public Class Rarity
    Public Property value As String
    Public Property displayValue As String
    Public Property backendValue As String
End Class

Public Class Series
    Public Property value As String
    Public Property image As String
    Public Property backendValue As String
End Class

Public Class [Set]
    Public Property value As String
    Public Property text As String
    Public Property backendValue As String
End Class

Public Class Introduction
    Public Property chapter As String
    Public Property season As String
    Public Property text As String
    Public Property backendValue As Integer
End Class

Public Class Other
    Public Property background As String
    Public Property coverart As String
    Public Property decal As String
End Class

Public Class Images
    Public Property smallIcon As String
    Public Property icon As String
    Public Property featured As String
    Public Property other As Other
End Class

Public Class [Option]
    Public Property tag As String
    Public Property name As String
    Public Property image As String
    Public Property unlockRequirements As String
End Class

Public Class [Variant]
    Public Property channel As String
    Public Property type As String
    Public Property options As [Option]()
End Class

Public Class Item
    Public Property id As String
    Public Property name As String
    Public Property description As String
    Public Property type As Type
    Public Property rarity As Rarity
    Public Property series As Series
    Public Property [Set] As [Set]
    Public Property introduction As Introduction
    Public Property images As Images
    Public Property variants As [Variant]()
    Public Property gameplayTags As String()
    Public Property showcaseVideo As String
    Public Property displayAssetPath As Object
    Public Property definitionPath As String
    Public Property path As String
    Public Property added As DateTime
    Public Property shopHistory As DateTime()
    Public Property exclusiveDescription As String
    Public Property builtInEmoteIds As String()
End Class

Public Class Data
    Public Property build As String
    Public Property previousBuild As String
    Public Property hash As String
    Public Property [Date] As DateTime
    Public Property lastAddition As DateTime
    Public Property items As Item()
End Class

Public Class CosmeticModel
    Public Property status As Integer
    Public Property data As Data
End Class