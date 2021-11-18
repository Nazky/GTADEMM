Imports System.IO
Public Class ModUnistaller
    Shared Sub GTASA(ModPath As String)
        Try
            Directory.Delete(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & ModPath, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Shared Sub GTAVC(ModPath As String)
        Try
            Directory.Delete(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & ModPath, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Shared Sub GTAIII(ModPath As String)
        Try
            Directory.Delete(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & ModPath, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
