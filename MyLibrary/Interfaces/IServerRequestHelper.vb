Imports Newtonsoft.Json.Linq

Public Interface IServerRequestHelper

#Region "Functions"

    Function ToPost() As String
    Function ToJson() As JObject

#End Region ' End Functions

#Region "Subs"

    Sub FromJson(json As JObject)

#End Region ' End Region Subs

End Interface
