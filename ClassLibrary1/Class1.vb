Public Class Class1
    
End Class
Public Module dd
    Dim dd As Date = "01/01/2020"
    Public Sub check()
        Dim r As Date = Date.Today
        If r.ToString("dd/MM/yyyy") > dd Then
            MsgBox("Trial period has been ended")
        End If
    End Sub
End Module
