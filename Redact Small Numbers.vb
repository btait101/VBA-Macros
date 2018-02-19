Option Explicit

Public Sub RedactSmallNums()
Dim cell As Variant
    'Loop through all cells in the current selection
    For Each cell In Selection
        'If 0 < x > 5 then redact it with an *
        If cell.Value < 5 And cell.Value > 0 Then
            cell.Value = "*"
        End If
    Next cell
    
    'Left align the selection to tidy it up
    Selection.HorizontalAlignment = xlRight
End Sub
