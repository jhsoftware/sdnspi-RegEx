Imports System.Windows.Forms

Public Class frmRegExIP

  Private LastTestStr As String = ""

  Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
    If txtRegEx.Text.Trim.Length = 0 Then
      MessageBox.Show("Regular Expression is empty", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End If
    Dim rx As System.Text.RegularExpressions.Regex
    Try
      rx = New System.Text.RegularExpressions.Regex(txtRegEx.Text.Trim)
    Catch ex As Exception
      MessageBox.Show("Invalid regular expression", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End Try

    Dim s As String = InputBox("Enter domain name to test:", "Test Regular Expression", LastTestStr)
    If s.Length = 0 Then Exit Sub
    LastTestStr = s.Trim.ToLower

    If rx.IsMatch(LastTestStr) Then
      MessageBox.Show("TEST SUCCESSFUL" & vbCrLf & vbCrLf &
                      "Domain name matches regular expression", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      MessageBox.Show("TEST FAILED" & vbCrLf & vbCrLf &
                      "Domain name does NOT match regular expression", "Test Regular Expression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
    If txtRegEx.Text.Trim.Length = 0 Then
      MessageBox.Show("Regular Expression is empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End If
    Dim rx As System.Text.RegularExpressions.Regex
    Try
      rx = New System.Text.RegularExpressions.Regex(txtRegEx.Text)
    Catch ex As Exception
      MessageBox.Show("Invalid regular expression", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtRegEx.Focus()
      Exit Sub
    End Try
    If CtlIP1.Text.Length = 0 Then
      MessageBox.Show("IP address is empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      CtlIP1.Focus()
      Exit Sub
    End If
    Dim ip As System.Net.IPAddress = Nothing
    If Not System.Net.IPAddress.TryParse(CtlIP1.Text, ip) Then
      MessageBox.Show("Invalid IP address", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      CtlIP1.Focus()
      Exit Sub
    End If

    DialogResult = Windows.Forms.DialogResult.OK
  End Sub
End Class
