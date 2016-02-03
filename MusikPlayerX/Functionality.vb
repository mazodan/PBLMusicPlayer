Imports MusikPlayerX.libZPlay

Public Class Functionality


    Sub load(ByVal player As ZPlay, ByVal filename As String)
        player.OpenFile(filename, TStreamFormat.sfMp3)
        player.StartPlayback()
    End Sub

    Sub VU(ByVal player As ZPlay, ByVal pbarL As ProgressBar, ByVal pbarR As ProgressBar)
        Dim leftvux, rightvux As Integer
        player.GetVUData(leftvux, rightvux)
        pbarL.Value = leftvux
        pbarR.Value = rightvux
    End Sub

End Class
