Public Class ctlAddEditRemove

  Event ClickedAdd()
  Event ClickedEdit()
  Event ClickedRemove()

  Property EnableEditRemove() As Boolean
    Get
      Return btnEdit.Enabled
    End Get
    Set(ByVal value As Boolean)
      btnEdit.Enabled = value
      btnRemove.Enabled = value
    End Set
  End Property

  Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    RaiseEvent ClickedAdd()
  End Sub

  Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
    RaiseEvent ClickedEdit()
  End Sub

  Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click
    RaiseEvent ClickedRemove()
  End Sub
End Class
