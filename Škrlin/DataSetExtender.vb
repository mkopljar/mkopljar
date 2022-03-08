Option Strict Off
Option Explicit On

Imports System

Namespace DataSet1TableAdapters
    Partial Public Class RegistarTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class BoravciTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class OperacijeTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class Operacija_extTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class MKB_NalaziTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class MKB_FullTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class DTSTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class STACTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class MaterijalTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class

    Partial Public Class Operacija_XMLTableAdapter
        Inherits System.ComponentModel.Component
        Public ReadOnly Property SelectCommandPublic As String
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection()
                End If
                Return Me._commandCollection(0).CommandText
            End Get
        End Property
    End Class
End Namespace
