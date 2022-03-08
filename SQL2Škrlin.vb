'Imports NHapi.Base


Public Class SQL2Škrlin
    Shared Function GetData_Registar_by_PrezimeIme(ByVal S As String) As DataSet1.RegistarDataTable

        If Not Skrlin.My.Settings.HL7 Then
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
        If Not Skrlin.My.Settings.HL7 Then
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
        If Not Skrlin.My.Settings.HL7 Then
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
        If Not Skrlin.My.Settings.HL7 Then
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
        If Not Skrlin.My.Settings.HL7 Then
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
            query = Replace(query, "@Param1", "'" + protokol.ToString + "'")
            query = Replace(query, "@Param2", "'" + maticni.ToString + "'")
            dr = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.Operacija_extDataTable)).Rows(0)
            GetData_Operacija_ext_by_ProtokolBR = dr
        End If

    End Function

    Shared Function GetData_DTS(ByVal protokol As String, ByVal maticni As String) As DataSet1.DTSDataTable
        If Not Skrlin.My.Settings.HL7 Then
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
            query = Replace(query, "@Param1", "'" + protokol.ToString + "'")
            query = Replace(query, "@Param2", "'" + maticni.ToString + "'")
            GetData_DTS = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.DTSDataTable))
        End If

    End Function

    Shared Function GetData_STAC(ByVal protokol As String, ByVal maticni As String) As DataSet1.STACDataTable
        If Not Skrlin.My.Settings.HL7 Then
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
            query = Replace(query, "@Param1", "'" + protokol.ToString + "'")
            query = Replace(query, "@Param2", "'" + maticni.ToString + "'")
            GetData_STAC = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.STACDataTable))

        End If

    End Function

    Shared Function GetData_Materijal_Naziv_za_Šifru(ByVal sifra As String) As String
        Dim dr As Skrlin.DataSet1.MaterijalRow
        Try
            If Not Skrlin.My.Settings.HL7 Then
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
        If Not Skrlin.My.Settings.HL7 Then
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
        If Not Skrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.Operacija_XMLTableAdapter
            GetData_Operacija_XML = ta.GetData(protokol, maticni).Rows(0)

        Else
            Dim ta As New DataSet1TableAdapters.Operacija_XMLTableAdapter
            Dim dt As New DataSet1.Operacija_XMLDataTable
            'Dim dt1 As New DataTable
            Dim dr As DataSet1.Operacija_XMLRow
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + protokol.ToString + "'")
            query = Replace(query, "@Param2", "'" + maticni.ToString + "'")
            dr = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.Operacija_XMLDataTable)).Rows(0)
            GetData_Operacija_XML = dr
        End If

    End Function


    Shared Function GetData_Radilista() As DataSet1.RadilisteDataTable
        If Not Skrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.RadilisteTableAdapter
            GetData_Radilista = ta.GetData()
        Else
            'Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            'GetData_Registar_by_PrezimeIme = ta.GetData(S)

            Dim ta As New DataSet1TableAdapters.RadilisteTableAdapter
            Dim dt As New DataSet1.RadilisteDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            'query = Replace(query, "@Param1", "'" + S + "'")
            GetData_Radilista = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.RadilisteDataTable))
        End If
    End Function

    Shared Function GetData_Neotpusteni(ByVal S As String) As DataSet1.NeotpusteniDataTable

        If Not Skrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.NeotpusteniTableAdapter
            GetData_Neotpusteni = ta.GetDataByRadilisteID(S)
        Else
            'Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            'GetData_Registar_by_PrezimeIme = ta.GetData(S)

            Dim ta As New DataSet1TableAdapters.NeotpusteniTableAdapter
            Dim dt As New DataSet1.NeotpusteniDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + S + "'")
            GetData_Neotpusteni = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.NeotpusteniDataTable))
        End If

    End Function

    Shared Function GetData_Registar_by_RegistarskiBR(ByVal R As Integer) As DataSet1.RegistarDataTable
        If Not Skrlin.My.Settings.HL7 Then
            Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            GetData_Registar_by_RegistarskiBR = ta.GetData(R)
        Else
            'Dim ta As New DataSet1TableAdapters.BoravciTableAdapter
            'GetData_Boravci_by_RegistarskiBR = ta.GetData(R)

            Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            Dim dt As New DataSet1.RegistarDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic1
            query = Replace(query, "@Param1", "'" + R.ToString + "'")
            GetData_Registar_by_RegistarskiBR = HL7Mirth.Load_table(query, ColNum, GetType(DataSet1.RegistarDataTable))
        End If
    End Function

    Shared Function GetData_Radilista5() As DataSet5.RadilisteDataTable

        If Not Skrlin.My.Settings.HL7 Then
            Dim ta As New DataSet5TableAdapters.RadilisteTableAdapter
            GetData_Radilista5 = ta.GetData
        Else
            'Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            'GetData_Registar_by_PrezimeIme = ta.GetData(S)

            Dim ta As New DataSet5TableAdapters.RadilisteTableAdapter
            Dim dt As New DataSet5.RadilisteDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            'query = Replace(query, "@Param1", "'" + S + "'")
            GetData_Radilista5 = HL7Mirth.Load_table(query, ColNum, GetType(DataSet5.RadilisteDataTable))
        End If

    End Function

    Shared Function GetData_Vitalni_by_RBRDatum(ByVal r As Integer, ByVal d As String) As DataSet6.RegistarVitalniZnakoviDataTable

        If Not Skrlin.My.Settings.HL7 Then
            Dim ta As New DataSet6TableAdapters.RegistarVitalniZnakoviTableAdapter
            GetData_Vitalni_by_RBRDatum = ta.GetDatabyRBRDatum(r, d)
        Else
            'Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            'GetData_Registar_by_PrezimeIme = ta.GetData(S)

            Dim ta As New DataSet6TableAdapters.RegistarVitalniZnakoviTableAdapter
            Dim dt As New DataSet6.RegistarVitalniZnakoviDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + r.ToString + "'")
            query = Replace(query, "@Param2", "'%" + d + "%'")
            GetData_Vitalni_by_RBRDatum = HL7Mirth.Load_table(query, ColNum, GetType(DataSet6.RegistarVitalniZnakoviDataTable))
        End If

    End Function

    Shared Function GetData_PraceniPostupak_by_RBRDatum(ByVal r As String, ByVal d As String) As DataSet6.RegistarPraceniPostupakDataTable

        If Not Skrlin.My.Settings.HL7 Then
            Dim ta As New DataSet6TableAdapters.RegistarPraceniPostupakTableAdapter
            GetData_PraceniPostupak_by_RBRDatum = ta.GetDatabyRBRDatum(r, d)
        Else
            'Dim ta As New DataSet1TableAdapters.RegistarTableAdapter
            'GetData_Registar_by_PrezimeIme = ta.GetData(S)

            Dim ta As New DataSet6TableAdapters.RegistarPraceniPostupakTableAdapter
            Dim dt As New DataSet6.RegistarPraceniPostupakDataTable
            'Dim dt1 As New DataTable
            Dim ColNum = dt.Columns.Count
            Dim query As String = ta.SelectCommandPublic
            query = Replace(query, "@Param1", "'" + r + "'")
            query = Replace(query, "@Param2", "'%" + d + "%'")
            GetData_PraceniPostupak_by_RBRDatum = HL7Mirth.Load_table(query, ColNum, GetType(DataSet6.RegistarPraceniPostupakDataTable))
        End If

    End Function

End Class
