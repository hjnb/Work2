Public Class WorkDataGridView
    Inherits DataGridView

    Protected Overrides Function ProcessDialogKey(keyData As System.Windows.Forms.Keys) As Boolean
        'Dim inputStr As String = If(Not IsNothing(Me.EditingControl), CType(Me.EditingControl, DataGridViewTextBoxEditingControl).Text, "") '入力文字
        'Dim columnName As String = Me.Columns(CurrentCell.ColumnIndex).Name '選択列名
        If keyData = Keys.Enter Then
            Return Me.ProcessTabKey(keyData)
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Protected Overrides Function ProcessDataGridViewKey(e As System.Windows.Forms.KeyEventArgs) As Boolean
        'Dim inputStr As String = Util.checkDBNullValue(Me.CurrentCell.Value)
        If e.KeyCode = Keys.Enter Then
            Return Me.ProcessTabKey(e.KeyCode)
        End If

        Dim tb As DataGridViewTextBoxEditingControl = DirectCast(Me.EditingControl, DataGridViewTextBoxEditingControl)
        If Not IsNothing(tb) AndAlso ((e.KeyCode = Keys.Left AndAlso tb.SelectionStart = 0) OrElse (e.KeyCode = Keys.Right AndAlso tb.SelectionStart = tb.TextLength)) Then
            Return False
        Else
            Return MyBase.ProcessDataGridViewKey(e)
        End If
    End Function

    ''' <summary>
    ''' CellPaintingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExDataGridView_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Me.CellPainting
        '選択したセルに枠を付ける
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 AndAlso (e.PaintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
            e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)

            If (e.PaintParts And DataGridViewPaintParts.SelectionBackground) = DataGridViewPaintParts.SelectionBackground AndAlso (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                e.Graphics.DrawRectangle(New Pen(Color.Black, 2I), e.CellBounds.X + 1I, e.CellBounds.Y + 1I, e.CellBounds.Width - 3I, e.CellBounds.Height - 3I)
            End If

            Dim pParts As DataGridViewPaintParts = e.PaintParts And Not DataGridViewPaintParts.Background
            e.Paint(e.ClipBounds, pParts)
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' 列ヘッダーマウスクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub workDataGridView_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Me.ColumnHeaderMouseClick
        '選択列を全選択
        For Each row As DataGridViewRow In Me.Rows
            For i As Integer = 0 To Me.Columns.Count - 1
                If i = e.ColumnIndex Then
                    row.Cells(i).Selected = True
                Else
                    row.Cells(i).Selected = False
                End If
            Next
        Next
    End Sub
End Class
