
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Cursor.Current = Cursors.WaitCursor
        Dim samplePrincipal As New SampleIPrincipal(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Me.PasswordTextBox.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            ' The user is still not validated.
            MsgBox("Pogrešno korisničko ime ili lozinka !", MsgBoxStyle.Critical, "Neuspjela autorizacija")
            PasswordTextBox.Text = ""
            UsernameTextBox.Text = ""
            UsernameTextBox.Focus()
        Else
            ' Update the current principal.
            My.User.CurrentPrincipal = samplePrincipal
            Dim f As New Skrlin.Prikaz_Radilista
            Dim f1 As New Skrlin.Form1
            If My.User.IsInRole("Admin") Then
                f.Show()
            Else
                f.Show()
            End If
            Me.Close()
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = "Verzija " + My.Application.Info.Version.ToString
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
