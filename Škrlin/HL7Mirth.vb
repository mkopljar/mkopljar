Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Xml

Public Class HL7Mirth

    Private Shared Function XML2DataTable(ByVal message As String, ByVal c As Integer, ByVal T As Type) As DataTable
        Dim MSG As New Xml.XmlDocument
        Dim el As Xml.XmlElement
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

        Dim dt As DataTable = System.Activator.CreateInstance(T)

        For j As Integer = 0 To c - 1
            dt.Columns.Add()
        Next

        MSG.LoadXml(message)

        m_nodelist = MSG.SelectNodes("//row")
        'Loop through the nodes
        For Each m_node In m_nodelist
            Dim dr As DataRow
            dr = dt.NewRow
            Dim i2 As Integer = 0
            Try
                el = m_node.FirstChild
            Catch ex As Exception
                el = Nothing
            End Try
            While Not el Is Nothing
                If el.InnerText = "null" Then
                    dr.Item(i2) = DBNull.Value
                Else
                    dr.Item(i2) = el.InnerText
                End If
                el = el.NextSibling
                i2 = i2 + 1
            End While
            dt.Rows.Add(dr)
        Next

        Return dt
    End Function

    Shared Function Load_table(ByVal query As String, ByVal c As Integer, ByVal T As Type) As DataTable
        Dim dt As New DataTable

        'send message to Mirth channel ŠKRLIN

        Dim data() As Byte = Encoding.UTF8.GetBytes(query)

        Dim _sender As New TcpClient
        Dim _sender_stream As NetworkStream

        Try
            _sender.Connect(My.Settings.Mirth_host, My.Settings.Mirth_send_port)
            _sender_stream = _sender.GetStream
            _sender_stream.Write(data, 0, data.Length)
            _sender_stream.Close()
        Catch ex As Exception
            MsgBox("Greška u slanju poruke: " + ex.Message, MsgBoxStyle.Critical, "Pogreška")
            Return dt
            Exit Function
        End Try


        'listen 
        Dim received_message As String = Nothing
        Dim port As Int32 = My.Settings.Mirth_receive_port
        Dim _listener As New TcpListener(IPAddress.Any, port)
        Try
            _listener.Start()
            Dim bytes(1024) As [Byte]

            Dim _receiver As TcpClient = _listener.AcceptTcpClient()
            Dim _receiver_stream As NetworkStream = _receiver.GetStream()

            Dim i As Int32
            i = _receiver_stream.Read(bytes, 0, bytes.Length)
            While (i <> 0)
                received_message = received_message + Encoding.UTF8.GetString(bytes, 0, i)
                i = _receiver_stream.Read(bytes, 0, bytes.Length)
            End While
            _listener.Stop()
            _receiver_stream.Close()
        Catch ex As Exception
            MsgBox("Greška u primanju poruke: " + ex.Message, MsgBoxStyle.Critical, "Pogreška")
            Return dt
            Exit Function
        End Try

        dt = HL7Mirth.XML2DataTable(received_message, c, T)

        Return dt
    End Function

    Public Shared Function ConvertToTypedDataTable(Of T As {Data.DataTable, New})(dtBase As Data.DataTable) As T
        Dim dtTyped As New T
        dtTyped.Merge(dtBase)

        Return dtTyped
    End Function
End Class
