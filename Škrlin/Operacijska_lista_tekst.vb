Public Class Operacijska_lista_tekst
    Dim protokol, maticni As String



    Public Sub New(ByVal p As String, m As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        protokol = p
        maticni = m
    End Sub


    Private Sub Operacijska_lista_tekst_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dr As DataSet1.Operacija_XMLRow
        Dim s As String

        Dim O As New Xml.XmlDocument
        Dim O_node_list As Xml.XmlNodeList

        dr = SQL2Škrlin.GetData_Operacija_XML(protokol, maticni)
        O.LoadXml("<?xml version='1.0' encoding='UTF-8'?>" + dr.Tekst)

        O_node_list = O.SelectNodes("//*[@NS='INDIKACIJA']")
        s = O_node_list.Item(0).InnerText
        s = Replace(s, "@MYBR@", Chr(13) + Chr(10))
        Indikacija_TextBox.Text = s

        O_node_list = O.SelectNodes("//*[@NS='OPER']")
        s = O_node_list.Item(0).InnerText
        s = Replace(s, "@MYBR@", Chr(13) + Chr(10))
        Operacija_TextBox.Text = s

        O_node_list = O.SelectNodes("//*[@NS='POSTUPAK']")
        s = O_node_list.Item(0).InnerText
        s = Replace(s, "@MYBR@", Chr(13) + Chr(10))
        Postupak_TextBox.Text = s

        O_node_list = O.SelectNodes("//*[@NS='DIJAG']")
        s = O_node_list.Item(0).InnerText
        s = Replace(s, "@MYBR@", Chr(13) + Chr(10))
        Dijagnoza_TextBox.Text = s

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class