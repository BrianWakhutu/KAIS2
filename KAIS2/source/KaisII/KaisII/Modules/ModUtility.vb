Module ModUtility
    Public Sub ShowException(ByVal ex As Exception, ByVal UsfMsg As String)
        MsgBox(String.Format("{0} Custom Message  {1}", ex.Message, UsfMsg))
    End Sub
End Module
