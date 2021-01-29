Imports MyLibrary
''' <summary>
''' User interface
''' <para>Created by Antonino Razeti on January 26, 2021</para>
''' <para>Version 1.0</para>
''' <para> User Interface that contains all the properties, 
''' methods and functions of the User class</para>
''' </summary>
Public Interface IUser

#Region "Getters and Setters"

    Property Location As GeoLocation
    Property FiscalCode As String
    Property Phone As String
    Property Email As String
    Property Registration As Date
    Property Subscription As Date
    Property AccountType As AccountType
    Property AccountPlan As AccountPlan
    Property SessionStatus As SessionStatus
    Property IdToken As String
    Property IsVerified As Boolean
    Property Newsletters As Boolean

#End Region ' End Getters and Setters

#Region "Events"

    Event LocationChanged(ByVal sender As Object, ByVal location As GeoLocation)
    Event CredentialsChanged(ByVal sender As Object, ByVal credentials As Credentials)
    Event FiscalCodeChanged(sender As Object, fiscalCode As String)
    Event PhoneChanged(sender As Object, phone As String)
    Event RegistrationChanged(sender As Object, registration As Date)
    Event SubscriptionChanged(sender As Object, subscription As EventArgs)
    Event NewslettersChanged(sender As Object, newsletters As Boolean)
    Event AccountTypeChanged(sender As Object, accountType As AccountType)
    Event AccountPlanChanged(sender As Object, accountPlan As AccountPlan)
    Event SessionStatusChanged(sender As Object, sessionStatus As SessionStatus)
    Event ReferralCodeChanged(sender As Object, referralCode As String)
    Event idTokenChanged(sender As Object, idToken As String)
    Event IsVerifiedChanged(sender As Object, isVerified As Boolean)

#End Region ' End Events

End Interface
