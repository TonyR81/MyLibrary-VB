Imports MyLibrary
Imports Newtonsoft.Json.Linq
''' <summary>
''' ICollectionBase interface
''' <para>Created by Antonino Razeti on January 29, 2021</para>
''' <para>Version 1.0</para>
''' <para> ICollectionBase Interface that contains all the properties, 
''' methods and functions of the ICollectionBase class</para>
''' </summary>
Public Interface ICollectionBase

#Region "Getters and Setters"

    ReadOnly Property GetItems As List(Of Database)
    ReadOnly Property GetItemById(id As Integer) As Database

#End Region ' End Getters and Setters

#Region "Subs"

    Sub AddRange(array As JArray)

#End Region ' Subs

#Region "Events"


#End Region ' End Events

End Interface
