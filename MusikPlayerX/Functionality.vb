Imports MusikPlayerX.libZPlay


Public Class Functionality
    Sub load(ByVal player As ZPlay, ByVal OFD As OpenFileDialog)
        Dim filename As String
        Dim Fnameonly As String
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = OFD.FileName
            Fnameonly = OFD.SafeFileName
            player.OpenFile(filename, TStreamFormat.sfMp3)
            player.StartPlayback()
        End If
    End Sub
End Class
