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


    'the largest subroutine that i have ever done, too many parameters
    Sub EQband(ByVal t32 As TrackBar, ByVal b0 As Integer, ByVal t64 As TrackBar, ByVal b1 As Integer, _
               ByVal t125 As TrackBar, ByVal b2 As Integer, ByVal t250 As TrackBar, ByVal b3 As Integer, _
               ByVal t500 As TrackBar, ByVal b4 As Integer, ByVal t1000 As TrackBar, ByVal b5 As Integer, _
               ByVal t2000 As TrackBar, ByVal b6 As Integer, ByVal t4000 As TrackBar, ByVal b7 As Integer, _
               ByVal t8000 As TrackBar, ByVal b8 As Integer, ByVal t16000 As TrackBar, ByVal b9 As Integer)

        t32.Value = b0
        t64.Value = b1
        t125.Value = b2
        t250.Value = b3
        t500.Value = b4
        t1000.Value = b5
        t2000.Value = b6
        t4000.Value = b7
        t8000.Value = b8
        t16000.Value = b9
    End Sub

    Function invert(ByVal iv As Integer) As Integer
        If iv = 24 Then
            Return 0
        ElseIf iv = 23 Then
            Return 1
        ElseIf iv = 22 Then
            Return 2
        ElseIf iv = 21 Then
            Return 3
        ElseIf iv = 20 Then
            Return 4
        ElseIf iv = 19 Then
            Return 5
        ElseIf iv = 18 Then
            Return 6
        ElseIf iv = 17 Then
            Return 7
        ElseIf iv = 16 Then
            Return 8
        ElseIf iv = 15 Then
            Return 9
        ElseIf iv = 14 Then
            Return 10
        ElseIf iv = 13 Then
            Return 11
        ElseIf iv = 12 Then
            Return 12
        ElseIf iv = 11 Then
            Return 13
        ElseIf iv = 10 Then
            Return 14
        ElseIf iv = 9 Then
            Return 15
        ElseIf iv = 8 Then
            Return 16
        ElseIf iv = 7 Then
            Return 17
        ElseIf iv = 6 Then
            Return 18
        ElseIf iv = 5 Then
            Return 19
        ElseIf iv = 4 Then
            Return 20
        ElseIf iv = 3 Then
            Return 21
        ElseIf iv = 2 Then
            Return 22
        ElseIf iv = 1 Then
            Return 23
        ElseIf iv = 0 Then
            Return 24
        End If
    End Function

End Class
