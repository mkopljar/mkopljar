Imports NHapi.Base


Public Class SQL2Škrlin
    Shared Function GetData_Registar_by_PrezimeIme(ByVal S As String) As DataSet1.RegistarDataTable

        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            GetData_Registar_by_PrezimeIme = ta.GetData(S)
        Else
            'Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            'GetData_Registar_by_PrezimeIme = ta.GetData(S)

            Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            Dim dt As New DataSet1.RegistarDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + S + "'")
            GetData_Registar_by_PrezimeIme = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.RegistarDataTable))
        End If

    End Function

    Shared Function GetData_Boravci_by_RegistarskiBR(ByVal R As Integer) As DataSet1.BoravciDataTable
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.BoravciTableAdapter
            GetData_Boravci_by_RegistarskiBR = ta.GetData(R)
        Else
            'Dim ta As New DataSet1TableAdapters.BoravciTableAdapter
            'GetData_Boravci_by_RegistarskiBR = ta.GetData(R)

            Dim ta As New DataSet1TableAdapters.BoravciTableAdapter
            Dim dt As New DataSet1.BoravciDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + R.ToString + "'")
            GetData_Boravci_by_RegistarskiBR = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.BoravciDataTable))
        End If
    End Function

    Shared Function GetData_Operacije_by_RegistarskiBR(ByVal R As Integer) As DataSet1.OperacijeDataTable
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.OperacijeTableAdapter
            GetData_Operacije_by_RegistarskiBR = ta.GetData(R)
        Else
            'Dim ta As New DataSet1TableAdapters.OperacijeTableAdapter
            'GetData_Operacije_by_RegistarskiBR = ta.GetData(R)

            Dim ta As New DataSet1TableAdapters.OperacijeTableAdapter
            Dim dt As New DataSet1.OperacijeDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + R.ToString + "'")
            GetData_Operacije_by_RegistarskiBR = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.OperacijeDataTable))

        End If

    End Function

    Shared Function GetData_MKB_Nalazi_by_RegistarskiBR(ByVal R As Integer) As DataSet1.MKB_NalaziDataTable
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.MKB_NalaziTableAdapter
            GetData_MKB_Nalazi_by_RegistarskiBR = ta.GetData(R)
        Else
            'Dim ta As New DataSet1TableAdapters.MKB_NalaziTableAdapter
            'GetData_MKB_Nalazi_by_RegistarskiBR = ta.GetData(R)

            Dim ta As New DataSet1TableAdapters.MKB_NalaziTableAdapter
            Dim dt As New DataSet1.MKB_NalaziDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + R.ToString + "'")
            GetData_MKB_Nalazi_by_RegistarskiBR = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.MKB_NalaziDataTable))
        End If

    End Function

    Shared Function GetData_Operacija_ext_by_ProtokolBR(ByVal protokol As String, ByVal maticni As String) As DataSet1.Operacija_extRow
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.Operacija_extTableAdapter
            GetData_Operacija_ext_by_ProtokolBR = ta.GetData(protokol, maticni).Rows(0)
        Else
            'Dim ta As New DataSet1TableAdapters.Operacija_extTableAdapter
            'GetData_Operacija_ext_by_ProtokolBR = ta.GetData(protokol, maticni).Rows(0)

            Dim ta As New DataSet1TableAdapters.Operacija_extTableAdapter
            Dim dt As New DataSet1.Operacija_extDataTable
            'Dim dt1 As New DataTable
            Dim dr As DataSet1.Operacija_extRow
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", protokol)
            query = Replace(query, "@Param2", maticni)
            dr = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.Operacija_extDataTable)).Rows(0)
            GetData_Operacija_ext_by_ProtokolBR = dr
        End If

    End Function

    Shared Function GetData_DTS(ByVal protokol As String, ByVal maticni As String) As DataSet1.DTSDataTable
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.DTSTableAdapter
            GetData_DTS = ta.GetData(protokol, maticni)
        Else
            'Dim ta As New DataSet1TableAdapters.DTSTableAdapter
            'GetData_DTS = ta.GetDataByProtokolBR(protokol, maticni)

            Dim ta As New DataSet1TableAdapters.DTSTableAdapter
            Dim dt As New DataSet1.DTSDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", protokol)
            query = Replace(query, "@Param2", maticni)
            GetData_DTS = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.DTSDataTable))
        End If

    End Function

    Shared Function GetData_STAC(ByVal protokol As String, ByVal maticni As String) As DataSet1.STACDataTable
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.STACTableAdapter
            GetData_STAC = ta.GetData(protokol, maticni)
        Else
            'Dim ta As New DataSet1TableAdapters.STACTableAdapter
            'GetData_STAC = ta.GetData(protokol, maticni)

            Dim ta As New DataSet1TableAdapters.STACTableAdapter
            Dim dt As New DataSet1.STACDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", protokol)
            query = Replace(query, "@Param2", maticni)
            GetData_STAC = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.STACDataTable))

        End If

    End Function

    Shared Function GetData_Materijal_Naziv_za_Šifru(ByVal sifra As String) As String
        Dim dr As Škrlin.DataSet1.MaterijalRow
        Try
            If Not Škrlin.My.Settings.HL7 Then
                Dim ta As New DataSet1TableAdapters.MaterijalTableAdapter
                dr = ta.GetData(sifra).Rows(0)
                GetData_Materijal_Naziv_za_Šifru = dr.NazivNezasticeni
            Else
                'Dim ta As New DataSet1TableAdapters.MaterijalTableAdapter
                'dr = ta.GetData(sifra).Rows(0)
                'GetData_Materijal_Naziv_za_Šifru = dr.NazivNezasticeni

                Dim ta As New DataSet1TableAdapters.MaterijalTableAdapter
                Dim dt As New DataSet1.MaterijalDataTable
                'Dim dt1 As New DataTable
                Dim ColNum = dt.Columns.Count
                Dim query As String = ta.SelectCommandPublic
                query = Replace(query, "@Param1", "'" + sifra + "'")
                dt = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.MaterijalDataTable))
                dr = dt(0)
                GetData_Materijal_Naziv_za_Šifru = dr.NazivNezasticeni
            End If
        Catch ex As Exception
            GetData_Materijal_Naziv_za_Šifru = ""
        End Try

    End Function

    Shared Function GetData_MKBNalazFull(ByVal narudzba As String) As DataSet1.MKB_FullDataTable
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.MKB_FullTableAdapter
            GetData_MKBNalazFull = ta.GetDataByNarudžbaID(narudzba)

        Else
            'Dim ta As New DataSet1TableAdapters.MKB_FullTableAdapter
            'GetData_MKBNalazFull = ta.GetDataByNarudžbaID(narudzba)

            Dim ta As New DataSet1TableAdapters.MKB_FullTableAdapter
            Dim dt As New DataSet1.MKB_FullDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + narudzba + "'")
            GetData_MKBNalazFull = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.MKB_FullDataTable))
        End If

    End Function


    Shared Function GetData_Operacija_XML(ByVal protokol As String, ByVal maticni As String) As DataSet1.Operacija_XMLRow
        If Not Škrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.Operacija_XMLTableAdapter
            GetData_Operacija_XML = ta.GetData(protokol, maticni).Rows(0)

        Else
            Dim ta As New DataSet1TableAdapters.Operacija_XMLTableAdapter
            Dim dt As New DataSet1.Operacija_XMLDataTable
            'Dim dt1 As New DataTable
            Dim dr As DataSet1.Operacija_XMLRow
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", protokol)
            query = Replace(query, "@Param2", maticni)
            dr = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.Operacija_XMLDataTable)).Rows(0)
            GetData_Operacija_XML = dr
        End If

    End Function
End Class
