Imports System.Runtime.Serialization
Imports System.ComponentModel

<Serializable()> _
Public Class ClonablePanel
    Inherits System.Windows.Forms.Panel
    Implements ISerializationSurrogate



#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        
        Me.Name = "ClonablePanel"

    End Sub

#End Region


    Public Sub GetObjectData(obj As Object, info As SerializationInfo, context As StreamingContext) Implements ISerializationSurrogate.GetObjectData

    End Sub

    Public Function SetObjectData(obj As Object, info As SerializationInfo, context As StreamingContext, selector As ISurrogateSelector) As Object Implements ISerializationSurrogate.SetObjectData
        Return vbNull
    End Function
End Class





