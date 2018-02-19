Sub SelectAone()
    'Credit: Ben Tait 2017
    Dim ws As Worksheet
    'This now will work for both hidden and visible worksheets
    For Each ws In ActiveWorkbook.Worksheets
    ws.Activate
        Application.Goto Reference:=Range("A1"), Scroll:=True
    Next ws
    
    Worksheets(1).Activate
End Sub
