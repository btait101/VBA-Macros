Sub SelectAone()
    'Credit: Ben Tait 2017
    Dim ws As Worksheet
    For Each ws In Worksheets
        ws.Select
        Application.Goto Reference:=Range("A1"), Scroll:=True
    Next ws
    
    Worksheets(1).Activate
End Sub
