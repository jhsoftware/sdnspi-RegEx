Public Class OptionsCtrl

  Private NewItemFlag As Boolean

  Public Overrides Sub LoadData(ByVal config As String)
    If config Is Nothing Then Exit Sub 'new instance
    If config.Length = 0 Then Exit Sub
    Dim doc As New Xml.XmlDocument
    Dim root As Xml.XmlElement = doc.CreateElement("root")
    doc.AppendChild(root)
    Dim elem As Xml.XmlElement
    root.InnerXml = config
    For Each elem In root.GetElementsByTagName("match")
      If Not elem.HasAttribute("regex") Then Continue For
      If Not elem.HasAttribute("ip") Then Continue For
      If Not elem.HasAttribute("ttl") Then Continue For
      With lstMatch.Items.Add(elem.GetAttribute("regex"))
        .SubItems.Add(elem.GetAttribute("ip"))
        .Tag = Integer.Parse(elem.GetAttribute("ttl"))
      End With
    Next
  End Sub

  Public Overrides Function SaveData() As String
    Dim doc As New Xml.XmlDocument
    Dim root As Xml.XmlElement = doc.CreateElement("root")
    doc.AppendChild(root)
    Dim elem As Xml.XmlElement
    Dim rv As New System.Text.StringBuilder
    For Each li As Windows.Forms.ListViewItem In lstMatch.Items
      elem = doc.CreateElement("match")
      elem.SetAttribute("regex", li.Text)
      elem.SetAttribute("ip", li.SubItems(1).Text)
      elem.SetAttribute("ttl", DirectCast(li.Tag, Integer).ToString)
      root.AppendChild(elem)
    Next
    Return root.InnerXml
  End Function

  Public Overrides Function ValidateData() As Boolean
    If lstMatch.Items.Count > 0 Then Return True
    Windows.Forms.MessageBox.Show("At least one regular expression is required", "Error", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    Return False
  End Function

  Private Sub btns_ClickedAdd() Handles btns.ClickedAdd
    NewItemFlag = True
    Dim frm = New frmRegExIP
    frm.IPCtrl = GetIPCtrl.Invoke(True, True)
    AddHandler frm.FormClosing, AddressOf SubFrmClosing
    frm.ShowDialog()
  End Sub

  Private Sub btns_ClickedEdit() Handles btns.ClickedEdit
    If lstMatch.SelectedIndices.Count < 1 Then Exit Sub
    NewItemFlag = False
    Dim frm = New frmRegExIP
    frm.IPCtrl = GetIPCtrl.Invoke(True, True)
    AddHandler frm.FormClosing, AddressOf SubFrmClosing
    With lstMatch.SelectedItems(0)
      frm.txtRegEx.Text = .Text
      frm.IPCtrl.Text = .SubItems(1).Text
      frm.CtlTTL1.Value = DirectCast(.Tag, Integer)
    End With
    frm.ShowDialog()
  End Sub

  Private Sub SubFrmClosing(ByVal sender As Object, ByVal e As Windows.Forms.FormClosingEventArgs)
    Dim frm = DirectCast(sender, frmRegExIP)
    If frm.DialogResult <> Windows.Forms.DialogResult.OK Then Exit Sub
    Dim regex As String = frm.txtRegEx.Text.Trim
    Dim ip As String = System.Net.IPAddress.Parse(frm.IPCtrl.Text).ToString
    For i = 0 To lstMatch.Items.Count - 1
      If Not NewItemFlag AndAlso i = lstMatch.SelectedIndices(0) Then Continue For
      If lstMatch.Items(i).Text = regex Then
        Windows.Forms.MessageBox.Show("Regular expression is already in the list", frm.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        frm.txtRegEx.Focus()
        e.Cancel = True
        Exit Sub
      End If
    Next
    If NewItemFlag Then
      Dim li = lstMatch.Items.Add(regex)
      li.SubItems.Add(ip)
      li.Tag = frm.CtlTTL1.Value
      li.Selected = True
    Else
      Dim li = lstMatch.SelectedItems(0)
      li.Text = regex
      li.SubItems(1).Text = ip
      li.Tag = frm.CtlTTL1.Value
    End If
  End Sub

  Private Sub btns_ClickedRemove() Handles btns.ClickedRemove
    If lstMatch.SelectedIndices.Count < 1 Then Exit Sub
    lstMatch.Items.RemoveAt(lstMatch.SelectedIndices(0))
  End Sub

  Private Sub lstMatch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMatch.DoubleClick
    If lstMatch.SelectedIndices.Count > 0 Then btns_ClickedEdit()
  End Sub

  Private Sub lstMatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMatch.SelectedIndexChanged
    btns.EnableEditRemove = lstMatch.SelectedIndices.Count > 0
    btnUp.Enabled = (lstMatch.SelectedIndices.Count > 0 AndAlso lstMatch.SelectedIndices(0) > 0)
    btnDown.Enabled = (lstMatch.SelectedIndices.Count > 0 AndAlso lstMatch.SelectedIndices(0) < lstMatch.Items.Count - 1)
  End Sub

  Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click
    If lstMatch.SelectedIndices.Count < 1 Then Exit Sub
    Dim idx = lstMatch.SelectedIndices(0)
    If idx = 0 Then Exit Sub
    Dim li = lstMatch.Items(idx)
    lstMatch.Items.RemoveAt(idx)
    lstMatch.Items.Insert(idx - 1, li)
  End Sub

  Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
    If lstMatch.SelectedIndices.Count < 1 Then Exit Sub
    Dim idx = lstMatch.SelectedIndices(0)
    If idx > lstMatch.Items.Count - 1 Then Exit Sub
    Dim li = lstMatch.Items(idx)
    lstMatch.Items.RemoveAt(idx)
    lstMatch.Items.Insert(idx + 1, li)
  End Sub
End Class
