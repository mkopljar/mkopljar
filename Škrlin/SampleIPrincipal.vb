Public Class SampleIPrincipal
    Implements System.Security.Principal.IPrincipal

    Private identityValue As SampleIIdentity
    Private roles As New List(Of String)

    Public ReadOnly Property Identity As Security.Principal.IIdentity Implements Security.Principal.IPrincipal.Identity
        Get
            Return identityValue
        End Get
    End Property

    Public Function IsInRole(role As String) As Boolean Implements Security.Principal.IPrincipal.IsInRole
        Return roles.Contains(role)
        'Return role = identityValue.Role.ToString
    End Function

    Public Sub New(ByVal name As String, ByVal password As String)
        identityValue = New SampleIIdentity(name, password)
        roles.Clear()
        Dim ta As New DataSet3TableAdapters.Roles_for_UserNameTableAdapter
        Dim dt As New DataSet3.Roles_for_UserNameDataTable
        Dim dr As DataSet3.Roles_for_UserNameRow
        dt = ta.GetData(identityValue.Name)
        For i As Integer = 0 To dt.Rows.Count - 1
            dr = dt(i)
            roles.Add(dr.RoleName)
        Next

    End Sub
End Class
