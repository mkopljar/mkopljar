Imports System.Security.Cryptography
Imports System.Text
Public Class SampleIIdentity
    Implements System.Security.Principal.IIdentity

    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole

    Public ReadOnly Property AuthenticationType As String Implements Security.Principal.IIdentity.AuthenticationType
        Get
            Return "Custom Authentication"
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property

    Public ReadOnly Property Name As String Implements Security.Principal.IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property

    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal password As String)
        ' The name is not case sensitive, but the password is. 
        If IsValidNameAndPassword(name.ToUpper, password) Then
            nameValue = name
            authenticatedValue = True
            roleValue = ApplicationServices.BuiltInRole.Guest
        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If
    End Sub

    Shared Function IsValidNameAndPassword(ByVal username As String, ByVal password As String) As Boolean
        Dim ta As New DataSet3TableAdapters.QueriesTableAdapter
        Return (ta.UserPasswordCorrect(GetMd5Hash(password), username) = 1)
    End Function

    Shared Function GetMd5Hash(ByVal input As String) As String
        Dim md5hash As MD5 = MD5.Create

        Dim data As Byte() = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()

    End Function


    
End Class
