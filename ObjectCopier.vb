Imports System.Runtime.Serialization
Public Class ObjectCopier(Of ObjectType)
    Public Function GetCopy(ByVal original As ObjectType) As ObjectType
        Dim formatter As IFormatter = New Formatters.Binary.BinaryFormatter
        Dim ms As New IO.MemoryStream
        formatter.Serialize(ms, original)
        ms.Seek(0, IO.SeekOrigin.Begin)
        Return CType(formatter.Deserialize(ms), ObjectType)
    End Function
End Class
